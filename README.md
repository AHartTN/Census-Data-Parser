# CensusDataParser
US Census Bureau Census Data Parser

Author - Anthony Hart | anthony@anthonyhart.info

This is what I've come up with for mapping out all of the 9,000+ (IT'S OVER 9000!) columns that are included in the US Census Bureau Census data that can be found at ftp://ftp.census.gov

Future commits will add functionality for parsing the other sections of the Census data and possibly streaming the data directly from the US Census Bureau FTP site as an isolated single-use database builder.

To acquire the column names, descriptions, groupings, and mappings, I've utilized the empty Access 2007 databases and stripped the information from them. Some of them included the descriptions and other information regarding the columns. If the other sections had these access files, parsing the additional sections aside from Summary One and Summary Two would be much easier (though still not necessary due to Summary One/Two containing what the other categories have.

Census Data Parser - How does it work?
This application has two phases of operation.

Phase one is schema/model generation based off of the physical file structure of the US Census Bureau 2010 Census data directory on their FTP site. An exact copy of ftp://ftp.census.gov/census_2010/, containing at a minimum the Summary One and Summary Two directories under the parent directory, is what this application was designed to work with. This application will generate an EF 6 Code First database schema full and complete with Context, Models, Mapping, and basic relational integrity and output the resulting C# code (.cs) files to the specified directory.

After generating that schema, I implemented that schema into the application (located in the Generated folder) of which gets utilized for phase two.

Phase Two will check to see if the database exists, will create it if it does not, and then begins processing the actual files themselves. The application will look at the directory structure, pick the specific category it is working with and will then go state by state processing each of the files. It starts by grabbing each appropriate zip file, extracting the file it is currently working with, processing it, and then moves on for each file in the zip. The first file that should be processed is the geographical data file. By programmatically building an SSIS package's data flow by adding all of the necessary columns with lengths that were retrieved from the access database files, I was able to build out all of the necessary flow programmatically to which I simply just execute the SSIS package's specific data flow task. In the end, I wind up having an SSIS package that outlines all of the specific tasks. Will include in future commit.

Currently, this commit works on a downloaded copy of the census files that have been extracted to a folder. Some path/url contraints as well as not wanting to excessively ping the Census Bureau servers prevented me from working with the files directly, however, a future version may include SSIS integration for downloading the files via FTP similarly to how the application is currently processing the Geography flat-format files that correlate the records to their respective MAF/Tiger topography record(s).

THIS APP IS FUNCTIONAL - AFTER DOWNLOADING THE DIRECTORY SPECIFIED ABOVE, YOU SHOULD ONLY NEED TO CHANGE THE PATHS AND CONNECTIONS IN THE CONFIGURATION FILE AND THEN RUN IT. I RECOMMEND RUNNING THE APPLICATION IN DEBUG MODE VIA VISUAL STUDIO 2013 OR GREATER WITH SQL SERVER 2012 *assumed, working with 14*!

DISCLAIMER: Data utilized in this application is all sourced via the US Census Bureau and the Federal Bureau of Investigations.

=== NOTES ===
Ignore the copyright header in each of the files. I've published this to my github making it public. Assume the license file in this same directory supercedes any of the individual file notices.

