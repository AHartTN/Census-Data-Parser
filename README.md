# CensusDataParser
US Census Bureau Census Data Parser

Author - Anthony Hart | anthony@anthonyhart.info

This is what I've come up with for mapping out all of the 9,000+ (IT'S OVER 9000!) columns that are included in the US Census Bureau Census data that can be found at ftp://ftp.census.gov

Future commits will add functionality for parsing the other sections of the Census data and possibly streaming the data directly from the US Census Bureau FTP site as an isolated single-use database builder.

To acquire the column names, descriptions, groupings, and mappings, I've utilized the empty Access 2007 databases and stripped the information from them. Some of them included the descriptions and other information regarding the columns. If the other sections had these access files, parsing the additional sections aside from Summary One and Summary Two would be much easier (though still not necessary due to Summary One/Two containing what the other categories have.

Currently, this commit works on a downloaded copy of the census files that have been extracted to a folder. Some path/url contraints as well as not wanting to excessively ping the Census Bureau servers prevented me from working with the files directly, however, a future version may include SSIS integration for downloading the files via FTP similarly to how the application is currently processing the Geography flat-format files that correlate the records to their respective MAF/Tiger topography record(s).

THIS APP IS FUNCTIONAL - YOU SHOULD ONLY NEED TO CHANGE THE PATHS AND CONNECTIONS IN THE CONFIGURATION FILE AND THEN RUN IT. I RECOMMEND RUNNING THE APPLICATION IN DEBUG MODE VIA VISUAL STUDIO 2013 OR GREATER WITH SQL SERVER 2012 *assumed, working with 14*!

DISCLAIMER: Data utilized in this application is all sourced via the US Census Bureau and the Federal Bureau of Investigations.

=== NOTES ===
Ignore the copyright header in each of the files. I've published this to my github making it public. Assume the license file in this same directory supercedes any of the individual file notices.

To generate the model schema(s), the application utilizes approximately 65mb of memory and consumed a maximum (spike value) of 33% of my CPU (I5 3.66GHz, 16GB RAM)
