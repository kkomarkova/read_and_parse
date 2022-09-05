# Create new files in at least these formats: text, xml, yaml, json, csv.
# Create scripts that can read and parse the files in 2 programming languages of your choice.

# JSON
import xml.dom.minidom
import yaml
import csv
from importlib.resources import contents
import json

with open('person.json', 'r') as f:
    data = json.load(f)
print(data)

# CSV
with open('person.csv') as csvfile:
    csv_reader = csv.reader(csvfile, delimiter=',')
    line_count = 0
    for row in csv_reader:
        if line_count == 0:
            print(f'Column names are {",".join(row)}')
            line_count += 1
        else:
            print(
                f'\t{row[0]} works in the {row[1]} department, and was born in {row[2]}.')
            line_count += 1
    print(f'Processed {line_count} lines.')

# YAML

with open('example.yaml') as yamlfile:
    data = yaml.load(yamlfile, Loader=yaml.FullLoader)
    print(data)

# TEXT FILE
with open('programminglanguages.txt', "r") as textfile:
    if textfile.mode == "r":
        contents = textfile.read()
        print(contents)

# XML
doc = xml.dom.minidom.parse("note.xml")
# NodeName - the name of the file
print(doc.nodeName)
print(doc.firstChild.tagName)
