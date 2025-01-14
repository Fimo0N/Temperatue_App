const mysql = require('mysql2/promise'); 
const fs = require('fs/promises');

// Connection
async function importData() {
    try {
        const connection = await mysql.createConnection({
            host: 'localhost',
            user: 'root',
            password: '', 
            database: 'temperature_data'
        });

        async function parseTextFile(filePath, delimiter) {
            const fileContent = await fs.readFile(filePath, 'utf-8');
            const lines = fileContent.trim().split('\n');
            return lines.map(line => line.split(delimiter));
        }

        // Import places.txt data
        const placesData = await parseTextFile('places.txt', ',');
        for (const place of placesData) {
            await connection.execute('INSERT INTO places (id, sname, spart, county) VALUES (?, ?, ?, ?)', place);
        }

        // Import records.txt data
        const recordsData = await parseTextFile('records.txt', ',');
        for (const record of recordsData) {
            await connection.execute('INSERT INTO records (rvalue, rtype, rdate, placeid) VALUES (?, ?, ?, ?)', record);
        }

        console.log('Data imported successfully!');
        await connection.close();
    } catch (error) {
        console.error('Error importing data:', error);
    }
}

importData();