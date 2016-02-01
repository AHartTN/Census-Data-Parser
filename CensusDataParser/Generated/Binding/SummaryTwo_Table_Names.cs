#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/31/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SummaryTwo_Table_Names.cs
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

namespace CensusDataParser.Generated.Binding
{
    #region Using Directives
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.OleDb;
    using Models;
    #endregion

    public class SummaryTwo_Table_Names : BaseModel
    {
        #region Properties
        [Display(Name = "SORT ID", ShortName = "SORT ID", Order = 0)]
        public int SORT_ID { get; set; }

        [Display(Name = "TABLE CODE", ShortName = "TABLE CODE", Order = 1)]
        public string TABLE_CODE { get; set; }

        [Display(Name = "TABLE NAME", ShortName = "TABLE NAME", Order = 2)]
        public string TABLE_NAME { get; set; }

        [Display(Name = "CELL COUNT", ShortName = "CELL COUNT", Order = 3)]
        public string CELL_COUNT { get; set; }
        #endregion Properties

        #region Constructors
        public SummaryTwo_Table_Names() { }

        public SummaryTwo_Table_Names(string csvLine) : base(csvLine) { }

        public SummaryTwo_Table_Names(string[] values) : base(values) { }

        public SummaryTwo_Table_Names(OleDbDataReader reader)
        {
            if (reader[0] != DBNull.Value)
            {
                SORT_ID = (int)reader[0];
            }
            if (reader[1] != DBNull.Value)
            {
                TABLE_CODE = (string)reader[1];
            }
            if (reader[2] != DBNull.Value)
            {
                TABLE_NAME = (string)reader[2];
            }
            if (reader[3] != DBNull.Value)
            {
                CELL_COUNT = (string)reader[3];
            }
        }
        #endregion Constructors
    }
}
