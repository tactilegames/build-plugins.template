// READ README.md content
// Replace all instances of "VERSION" with "arg[1]"

const fs = require('fs');
const path = require('path');


// Log all args

console.log('process.argv: ', process.argv);

const readmePath = path.join(__dirname, '../README.md');
const readmeContent = fs.readFileSync(readmePath, 'utf8');
let regex = /(version:\s*)(\d+\.\d+\.\d+)/;
const newReadmeContent = readmeContent.replace(regex, `version: ${process.argv[2]}`);

fs.writeFileSync(readmePath, newReadmeContent);

