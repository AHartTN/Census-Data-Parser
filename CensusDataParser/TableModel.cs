#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 3:18 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: TableModel.cs
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

namespace CensusDataParser
{
    #region Using Directives
    using System;
    using System.Data;
    #endregion

    public class TableModel
    {
        public string Name
        {
            get
            {
                string output = "";
                if (!string.IsNullOrWhiteSpace(TableCatalog)
                    && !string.IsNullOrWhiteSpace(TableSchema))
                {
                    output += $"{TableCatalog}.{TableSchema}.";
                }
                else if (string.IsNullOrWhiteSpace(TableCatalog)
                         && !string.IsNullOrWhiteSpace(TableSchema))
                {
                    output += $"{TableSchema}.";
                }
                else if (!string.IsNullOrWhiteSpace(TableCatalog)
                         && string.IsNullOrWhiteSpace(TableSchema))
                {
                    output += $"{TableCatalog}.dbo.";
                }
                output += TableName;
                return output;
            }
        }

        public DateTime? Date_Created { get; set; }
        public DateTime? Date_Modified { get; set; }
        public string Description { get; set; }

        public string TableCatalog { get; set; }
        public Guid TableGuid { get; set; }
        public string TableName { get; set; }
        public string TablePropID { get; set; }
        public string TableSchema { get; set; }
        public string TableType { get; set; }

        public TableModel()
        {
            // Empty constructor to ensure JSON operability
        }

        public TableModel(DataRow row)
        {
            if (row[0] != DBNull.Value)
            {
                TableCatalog = (string)row[0];
            }
            if (row[1] != DBNull.Value)
            {
                TableSchema = (string)row[1];
            }
            if (row[2] != DBNull.Value)
            {
                TableName = (string)row[2];
            }
            if (row[3] != DBNull.Value)
            {
                TableType = (string)row[3];
            }
            if (row[4] != DBNull.Value)
            {
                TableGuid = (Guid)row[4];
            }
            if (row[5] != DBNull.Value)
            {
                Description = (string)row[5];
            }
            if (row[6] != DBNull.Value)
            {
                TablePropID = (string)row[6];
            }
            if (row[7] != DBNull.Value)
            {
                Date_Created = (DateTime?)row[7];
            }
            if (row[8] != DBNull.Value)
            {
                Date_Modified = (DateTime?)row[8];
            }
        }

        #region Overrides of Object
        /// <summary>
        ///     Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        ///     A string that represents the current object.
        /// </returns>
        public override string ToString() { return $"{Name} | {Date_Created} | {Date_Modified} | {Description}"; }
        #endregion
    }
}
