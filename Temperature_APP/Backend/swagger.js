const YAML = require('yamljs');
const swaggerSpec = YAML.load('./swagger.yaml');

module.exports = swaggerSpec;
