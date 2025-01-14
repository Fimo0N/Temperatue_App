const YAML = require('yamljs');
const swaggerSpec = YAML.load('./swagger.yaml');    // Swagger Documentation can be generated using swagger-autogen package

module.exports = swaggerSpec;



/*
const outputFile = './swagger.yaml'; 
const endpointsFiles = ['./server.js']; 
swaggerAutogen(outputFile, endpointsFiles, doc);*/