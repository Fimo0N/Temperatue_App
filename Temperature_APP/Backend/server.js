const express = require('express');
const mysql = require('mysql2/promise');
const bodyParser = require('body-parser');
const jwt = require('jsonwebtoken');
const swaggerUi = require('swagger-ui-express');
const swaggerSpec = require('./swagger');


const JWT_SECRET = '1234';
const app = express();
const port = 3000; 

app.use(bodyParser.json());

app.use('/api-docs', swaggerUi.serve, swaggerUi.setup(swaggerSpec));
// Connection with Database
const dbConfig = {
    host: 'localhost',
    user: 'root',
    password: '',
    database: 'temperature_data'
};

const pool = mysql.createPool(dbConfig);

function authenticateToken(req, res, next) {
    const authHeader = req.headers['authorization'];
    const token = authHeader && authHeader.split(' ')[1]; 

    if (token == null) return res.sendStatus(401); //Token--> Missing then Unauthorized

    jwt.verify(token, JWT_SECRET, (err, user) => {
        if (err) return res.sendStatus(403); //Token--> Forbidden
        req.user = user; 
        next(); 
    });
}

// Test route
app.get('/', (req, res) => {
    res.send('Temperature API is running!');
});


// To Get all records
app.get('/records', async (req, res) => {
    try {
        const [rows] = await pool.query('SELECT * FROM records');
        res.json(rows);
    } catch (error) {
        console.error("Error fetching records:", error);
        res.status(500).send("Error fetching records"); // Send error status
    }
});

// Get the record by ID
app.get('/records/:id', async (req, res) => {
    try {
        const [rows] = await pool.query('SELECT * FROM records WHERE id = ?', [req.params.id]);
        if (rows.length === 0) {
            return res.status(404).send("Record not found");
        }
        res.json(rows[0]); // Send only the first row (since ID is unique)
    } catch (error) {
        console.error("Error fetching record:", error);
        res.status(500).send("Error fetching record");
    }
});

// Login route Authenticating the user
app.post('/login', (req, res) => {
    const { username, password } = req.body;

    
    if (username === 'testuser' && password === 'password') {
        const user = { username: username }; 
        const token = jwt.sign(user, JWT_SECRET, { expiresIn: '1h' });
        res.json({ token });
    } else {
        res.status(401).json({ message: 'Invalid credentials' });
    }
});

// Post Request --> Needs Authetication
app.post('/records', authenticateToken, async (req, res) => {
    try {
        const { rvalue, rtype, rdate, placeid } = req.body;

     
        if (!rvalue || !rtype || !rdate || !placeid) {
            return res.status(400).send("Missing required fields");
        }

        const [result] = await pool.query('INSERT INTO records (rvalue, rtype, rdate, placeid) VALUES (?, ?, ?, ?)', [rvalue, rtype, rdate, placeid]);
        res.status(201).json({ id: result.insertId, message: "Record created successfully" }); // Send new id for new record
    } catch (error) {
        console.error("Error creating record:", error);
        res.status(500).send("Error creating record");
    }
});

// Put Request --> Needs Authetication
app.put('/records/:id', authenticateToken, async (req, res) => {
    try {
        const { rvalue, rtype, rdate, placeid } = req.body;


         if (!rvalue || !rtype || !rdate || !placeid) {
            return res.status(400).send("Missing required fields");
        }

        const [result] = await pool.query('UPDATE records SET rvalue = ?, rtype = ?, rdate = ?, placeid = ? WHERE id = ?', [rvalue, rtype, rdate, placeid, req.params.id]);

        if (result.affectedRows === 0) {
            return res.status(404).send("Record not found");
        }

        res.send("Record updated successfully");
    } catch (error) {
        console.error("Error updating record:", error);
        res.status(500).send("Error updating record");
    }
});

// Delete Request --> Needs Authetication
app.delete('/records/:id', authenticateToken, async (req, res) => {
    try {
        const [result] = await pool.query('DELETE FROM records WHERE id = ?', [req.params.id]);

        if (result.affectedRows === 0) {
            return res.status(404).send("Record not found");
        }

        res.send("Record deleted successfully");
    } catch (error) {
        console.error("Error deleting record:", error);
        res.status(500).send("Error deleting record");
    }
});

// Query 1: Get records with temperature higher than a given threshold
app.get('/records/above/:threshold', async (req, res) => {
    try {
        const threshold = parseFloat(req.params.threshold); 
        if (isNaN(threshold)) {
            return res.status(400).send("Invalid threshold value");
        }
        const [rows] = await pool.query('SELECT rdate, rvalue FROM records WHERE rvalue > ? ORDER BY rdate', [threshold]);
        res.json(rows);
    } catch (error) {
        console.error("Error fetching records:", error);
        res.status(500).send("Error fetching records");
    }
});

// Query 2: Get min and max temperatures from record table
app.get('/testextremes', async (req, res) => {
    try {
      const [rows] = await pool.query('SELECT MIN(rvalue) AS min_temp, MAX(rvalue) AS max_temp FROM records');
      res.json(rows[0]); 
    } catch (error) {
      console.error("Error fetching extremes:", error);
      res.status(500).send("Error fetching extremes");
    }
  });
  
  

// Query 3: Get minimum temperatures in a given year
app.get('/records/min/:year', async (req, res) => {
    try {
        const year = parseInt(req.params.year);
        if (isNaN(year)) {
            return res.status(400).send("Invalid year value");
        }
        const [rows] = await pool.query('SELECT p.sname, r.rdate, MIN(r.rvalue) AS min_temp FROM records r JOIN places p ON r.placeid = p.id WHERE YEAR(r.rdate) = ? GROUP BY p.sname, r.rdate', [year]);
        res.json(rows);
    } catch (error) {
        console.error("Error fetching minimum temperatures:", error);
        res.status(500).send("Error fetching minimum temperatures");
    }
});

// Start the server
app.listen(port, () => {
    console.log(`Access Server at http://localhost:${port}`);
});