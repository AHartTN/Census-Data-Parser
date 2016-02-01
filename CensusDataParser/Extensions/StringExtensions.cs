#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/31/2015 6:09 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: StringExtensions.cs
// 
// Anthony Hart ("ANTHONY") CONFIDENTIAL
// 
// Unpublished Copyright (c) 1985-2016 Anthony Hart, All Rights Reserved.
// 
// === NOTICE ===
// All information contained herein is, and remains the property of ANTHONY. The intellectual and technical concepts contained
// herein are proprietary to ANTHONY and may be covered by U.S. and Foreign Patents, patents in process, and are protected by trade secret or copyright law.
// Dissemination of this information or reproduction of this material is strictly forbidden unless prior written permission is obtained
// from ANTHONY. Access to the source code contained herein is hereby forbidden to anyone except current ANTHONY employees, managers or contractors who have executed 
// Confidentiality and Non-disclosure agreements explicitly covering such access. 
// 
// The copyright notice above does not evidence any actual or intended publication or disclosure of this source code, which includes 
// information that is confidential and/or proprietary, and is a trade secret, of ANTHONY. ANY REPRODUCTION, MODIFICATION, DISTRIBUTION, PUBLIC PERFORMANCE, 
// OR PUBLIC DISPLAY OF OR THROUGH USE OF THIS SOURCE CODE WITHOUT THE EXPRESS WRITTEN CONSENT OF ANTHONY IS STRICTLY PROHIBITED, AND IN VIOLATION OF APPLICABLE 
// LAWS AND INTERNATIONAL TREATIES. THE RECEIPT OR POSSESSION OF THIS SOURCE CODE AND/OR RELATED INFORMATION DOES NOT CONVEY OR IMPLY ANY RIGHTS 
// TO REPRODUCE, DISCLOSE OR DISTRIBUTE ITS CONTENTS, OR TO MANUFACTURE, USE, OR SELL ANYTHING THAT IT MAY DESCRIBE, IN WHOLE OR IN PART.
// 
// ANTHONY reserves the right to make public any and all contents of this file at the sole discretion of ANTHONY. In such case, licensing included with said publication(s) will supercede this notice only if made public by ANTHONY.
// 
// DISCLAIMERS (When Implemented):
// MAF/TIGER SHAPEFILES AND CENSUS DATA OBTAINED FROM THE US CENSUS BUREAU VIA FTP.
// http://www.census.gov
// ftp://ftp.census.gov
// 
// CRIME/POLICE INFORMATION OBTAINED FROM THE FEDERAL BUREAU OF INVESTIGATIONS VIA HTTP
// http://www.fbi.gov
#endregion

namespace CensusDataParser.Extensions
{
    #region Using Directives
    using Microsoft.VisualBasic.FileIO;

    #region Using Directives
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    #endregion

    #endregion

    public static class StringExtensions
    {
        public static string CleanResponseString(this string source)
        {
            if (source.IsNullOrWhiteSpace())
            {
                return source;
            }

            while (source.Contains("\t"))
            {
                source = source.Replace("\t", "");
            }

            while (Regex.IsMatch(source, @"\n\s*?\n"))
            {
                source = Regex.Replace(source, @"\n\s*?\n", "\n");
            }

            while (Regex.IsMatch(source, @"\r"))
            {
                source = Regex.Replace(source, @"\r", "");
            }

            while (Regex.IsMatch(source, @"\n"))
            {
                source = Regex.Replace(source, @"\n", "");
            }

            while (Regex.IsMatch(source, @"<head(.*?|[\s\r\n]*?)*?</head>"))
            {
                source = Regex.Replace(source, @"<head(.*?|[\s\r\n]*?)*?</head>", "");
            }

            while (Regex.IsMatch(source, @"<script(.*?|[\s\r\n]*?)*?</script>"))
            {
                source = Regex.Replace(source, @"<script(.*?|[\s\r\n]*?)*?</script>", "");
            }

            while (Regex.IsMatch(source, @"<style(.*?|[\s\r\n]*?)*?</style>"))
            {
                source = Regex.Replace(source, @"<style(.*?|[\s\r\n]*?)*?</style>", "");
            }

            while (Regex.IsMatch(source, @"<!--(.*?|[\s\r\n]*?)*?-->"))
            {
                source = Regex.Replace(source, @"<!--(.*?|[\s\r\n]*?)*?-->", "");
            }

            while (source.Contains("  "))
            {
                source = source.Replace("  ", " ");
            }

            source = source.Trim();

            return source;
        }

        /// <summary>
        ///     Returns a replacement string if the source string is equal to any of the specified strings
        /// </summary>
        /// <param name="source">The source string to check against</param>
        /// <param name="replacement">The replacement string should the check come back true</param>
        /// <param name="input">The values to compare the source string against</param>
        /// <returns>The replacement string if the source string equals any of the input strings, otherwise the source string</returns>
        public static string IfEquals(this string source, string[] input, string replacement)
        {
            if (input.Any(a => a.Equals(source)))
            {
                return replacement;
            }

            return source;
        }

        /// <summary>
        ///     Returns a replacement string if the source string is null, empty, or contains nothing but whtiespace characters
        /// </summary>
        /// <param name="source">The source string to check against</param>
        /// <param name="replacement">The replacement string should the check come back true</param>
        /// <returns>The replacement string if true, otherwise the source string</returns>
        public static string IfNullOrWhiteSpace(this string source, string replacement)
        {
            if (string.IsNullOrWhiteSpace(source))
            {
                return replacement;
            }

            return source;
        }

        public static bool IsNullOrWhiteSpace(this string source) { return string.IsNullOrWhiteSpace(source); }

        public static IEnumerable<string> SplitCSV(this string source)
        {
            using (TextFieldParser parser = new TextFieldParser(new StringReader(source))
                                            {
                                                HasFieldsEnclosedInQuotes = true,
                                                TextFieldType = FieldType.Delimited,
                                                Delimiters = new[] {","},
                                                TrimWhiteSpace = true
                                            })
            {
                parser.SetDelimiters(",");

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    if (fields == null
                        || !fields.Any())
                    {
                        continue;
                    }

                    foreach (string field in fields)
                    {
                        yield return field;
                    }
                }

                parser.Close();
            }
        }

        /// <summary>
        ///     Converts a string decimalo a nullable decimaleger
        /// </summary>
        /// <param name="source">The source string containing the number</param>
        /// <returns>An decimaleger representing the source string</returns>
        public static decimal? ToNullableDecimal(this string source)
        {
            decimal? result;
            if (string.IsNullOrWhiteSpace(source))
            {
                result = null;
            }
            else
            {
                decimal j;
                if (decimal.TryParse(source, out j))
                {
                    result = j;
                }
                else
                {
                    result = null;
                }
            }

            return result;
        }

        /// <summary>
        ///     Converts a string into a nullable integer
        /// </summary>
        /// <param name="source">The source string containing the number</param>
        /// <returns>An integer representing the source string</returns>
        public static int? ToNullableInt(this string source)
        {
            int? result;
            if (string.IsNullOrWhiteSpace(source))
            {
                result = null;
            }
            else
            {
                int j;
                if (int.TryParse(source, out j))
                {
                    result = j;
                }
                else
                {
                    result = null;
                }
            }

            return result;
        }
    }
}
