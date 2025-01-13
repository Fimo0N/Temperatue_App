CREATE DATABASE IF NOT EXISTS temperature_data; -- Creates the database if it doesn't exist
USE temperature_data; -- Selects the database

CREATE TABLE IF NOT EXISTS places (
    id INT PRIMARY KEY,
    sname VARCHAR(255),
    spart VARCHAR(255),
    county VARCHAR(255)
);

CREATE TABLE IF NOT EXISTS records (
    id INT AUTO_INCREMENT PRIMARY KEY, -- Auto-incrementing ID
    rvalue DECIMAL(4, 1), -- Temperature value (4 digits total, 1 after decimal)
    rtype VARCHAR(255),
    rdate DATE,
    placeid INT,
    FOREIGN KEY (placeid) REFERENCES places(id)
);