#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 1:14 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: DATA_FIELD_DESCRIPTORS.cs
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
    using System.ComponentModel.DataAnnotations;
    using System.Data.OleDb;
    #endregion

    public class DATA_FIELD_DESCRIPTORS
    {
        [Display(Name = "Is Decimal?", ShortName = "#.#?", Order = 5)]
        public short DECIMAL { get; set; }

        [Display(Name = "Code", ShortName = "Code", Order = 4)]
        public string FIELD_CODE { get; set; }

        [Display(Name = "Name", ShortName = "Name", Order = 3)]
        public string FIELD_NAME { get; set; }

        [Key]
        public int ID { get; set; }

        [Display(Name = "Segment", ShortName = "Segment", Order = 1)]
        public string SEGMENT { get; set; }

        [Display(Name = "Sort ID", ShortName = "Sort ID", Order = 0)]
        public int? SORT_ID { get; set; }

        [Display(Name = "Table Number", ShortName = "Tbl #", Order = 2)]
        public string TABLE_NUMBER { get; set; }

        public DATA_FIELD_DESCRIPTORS()
        {
            // Empty constructor to ensure JSON operability
        }

        public DATA_FIELD_DESCRIPTORS(OleDbDataReader row, CensusFileType summaryFileType)
        {
            switch (summaryFileType)
            {
                case CensusFileType.SummaryOne:
                case CensusFileType.SF1CongressionalDistricts113:
                    if (row[0] != DBNull.Value)
                    {
                        SORT_ID = (int?)row[0];
                    }
                    if (row[1] != DBNull.Value)
                    {
                        SEGMENT = (string)row[1];
                    }
                    if (row[2] != DBNull.Value)
                    {
                        TABLE_NUMBER = (string)row[2];
                    }
                    if (row[3] != DBNull.Value)
                    {
                        FIELD_NAME = (string)row[3];
                    }
                    if (row[4] != DBNull.Value)
                    {
                        FIELD_CODE = (string)row[4];
                    }
                    if (row[5] != DBNull.Value)
                    {
                        DECIMAL = (short)row[5];
                    }
                    break;
                case CensusFileType.SummaryTwo:
                    if (row[0] != DBNull.Value)
                    {
                        SORT_ID = (int)row[0];
                    }
                    if (row[1] != DBNull.Value)
                    {
                        TABLE_NUMBER = (string)row[1];
                    }
                    if (row[2] != DBNull.Value)
                    {
                        SEGMENT = (string)row[2];
                    }
                    if (row[3] != DBNull.Value)
                    {
                        FIELD_NAME = (string)row[3];
                    }
                    if (row[4] != DBNull.Value)
                    {
                        FIELD_CODE = (string)row[4];
                    }
                    break;
                case CensusFileType.Redistricting:
                case CensusFileType.DemographicProfile:
                    if (row[0] != DBNull.Value)
                    {
                        FIELD_NAME = (string)row[0];
                    }
                    if (row[1] != DBNull.Value)
                    {
                        FIELD_CODE = (string)row[1];
                    }
                    if (row[2] != DBNull.Value)
                    {
                        SEGMENT = (row[2] as double?)?.ToString() ?? (string)row[2];
                    }
                    break;
                case CensusFileType.AdvanceGroupQuarters:
                case CensusFileType.IslandAreas_DPSF:
                case CensusFileType.AIANSummaryFile:
                case CensusFileType.IslandAreas_IASF:
                case CensusFileType.IslandAreasDetailedCrossTabulations:
                case CensusFileType.IslandAreas_PUMS:
                case CensusFileType.Stateside_PUMS:
                    throw new NotImplementedException("The Data Field Descriptors table is not included in this specific dataset.");
                default:
                    throw new ArgumentOutOfRangeException(nameof(summaryFileType), summaryFileType, null);
            }
        }

        #region Overrides of Object
        /// <summary>
        ///     Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        ///     A string that represents the current object.
        /// </returns>
        public override string ToString() { return $"{FIELD_CODE} | {FIELD_NAME} | {SORT_ID} | {SEGMENT} | {TABLE_NUMBER} | {DECIMAL}"; }
        #endregion
    }
}
