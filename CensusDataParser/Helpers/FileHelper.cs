#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 1:14 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: FileHelper.cs
// 
// Anthony Hart ("ANTHONY") CONFIDENTIAL
// 
// Unpublished Copyright (c) 1985-2015 Anthony Hart, All Rights Reserved.
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

namespace CensusDataParser.Helpers
{
    #region Using Directives
    using System;
    using System.IO;
    using System.Linq;
    #endregion

    public class FileHelper
    {
        public static void AppendToFile(FileInfo file, string response) { AppendToFile(file, new[] {response}); }

        public static void AppendToFile(FileInfo file, string[] responses)
        {
            if (responses == null
                || !responses.Any())
            {
                return;
            }

            if (file.Directory == null
                || !file.Directory.Exists
                || !file.Exists)
            {
                WriteToFile(file, responses[0]);

                if (responses.Length > 1)
                {
                    File.AppendAllLines(file.FullName, responses.Skip(1));
                }
            }
            else
            {
                File.AppendAllLines(file.FullName, responses);
            }
        }

        public static void WriteToFile(FileInfo file, string response)
        {
            if (string.IsNullOrWhiteSpace(response))
            {
                return;
            }

            if (file.Directory == null)
            {
                throw new ArgumentException();
            }

            if (file.Directory != null
                && !file.Directory.Exists)
            {
                file.Directory.Create();
            }

            using (FileStream fs = File.Create(file.FullName))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(response);
                }
            }
        }
    }
}
