CREATE DATABASE IF NOT EXISTS temperature_data; 
USE temperature_data; 

CREATE TABLE IF NOT EXISTS places (
    id INT PRIMARY KEY,
    sname VARCHAR(255),
    spart VARCHAR(255),
    county VARCHAR(255)
);

CREATE TABLE IF NOT EXISTS records (
    id INT AUTO_INCREMENT PRIMARY KEY,
    rvalue DECIMAL(4, 1),
    rtype VARCHAR(255),
    rdate DATE,
    placeid INT,
    FOREIGN KEY (placeid) REFERENCES places(id)
);