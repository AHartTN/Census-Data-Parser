# CensusDataParser
US Census Bureau Census Data Parser

Author - Anthony Hart | anthony@anthonyhart.info

This is what I've come up with for mapping out all of the 9,000+ (IT'S OVER 9000!) columns that are included in the US Census Bureau Census data that can be found at ftp://ftp.census.gov

Future commits will add functionality for parsing the other sections of the Census data and possibly streaming the data directly from the US Census Bureau FTP site as an isolated single-use database builder.

I've currently got the application looking at the access database provided as a template to acquire all of the column mappings and their codes as well as their names.

Next few commits will add functionality for actually looking into each state's zip file (to access the .SF# files) and then iterate through them for processing to a SQL Server database.

DISCLAIMER: Data utilized in this application is all sourced via the US Census Bureau and the Federal Bureau of Investigations.

=== NOTES ===
Ignore the copyright header in each of the files. I've published this to my github making it public. Assume the license file in this same directory supercedes any of the individual file notices.

To generate the model schema(s), the application utilizes approximately 65mb of memory and consumed a maximum (spike value) of 33% of my CPU (I5 3.66GHz, 16GB RAM)