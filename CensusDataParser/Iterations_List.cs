#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 1:14 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: Iterations_List.cs
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

    public class Iterations_List
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Iteration Code", ShortName = "Code", Order = 1)]
        public string Iteration_Code { get; set; }

        [Display(Name = "Iterations", ShortName = "Iterations", Order = 2)]
        public string Iterations { get; set; }

        [Display(Name = "Sort ID", ShortName = "Sort ID", Order = 0)]
        public int? SORT_ID { get; set; }

        public Iterations_List()
        {
            // Empty constructor to ensure JSON operability
        }

        public Iterations_List(OleDbDataReader reader, CensusFileType fileType)
        {
            switch (fileType)
            {
                case CensusFileType.SummaryTwo:
                    if (reader[0] != DBNull.Value)
                    {
                        SORT_ID = (int?)reader[0];
                    }
                    if (reader[1] != DBNull.Value)
                    {
                        Iteration_Code = (string)reader[1];
                    }
                    if (reader[2] != DBNull.Value)
                    {
                        Iterations = (string)reader[2];
                    }
                    break;
                case CensusFileType.Redistricting:
                case CensusFileType.AdvanceGroupQuarters:
                case CensusFileType.DemographicProfile:
                case CensusFileType.SummaryOne:
                case CensusFileType.IslandAreas_DPSF:
                case CensusFileType.AIANSummaryFile:
                case CensusFileType.SF1CongressionalDistricts113:
                case CensusFileType.IslandAreas_IASF:
                case CensusFileType.IslandAreasDetailedCrossTabulations:
                case CensusFileType.IslandAreas_PUMS:
                case CensusFileType.Stateside_PUMS:
                    throw new NotImplementedException("The Iterations table is not included in this specific dataset.");
                default:
                    throw new ArgumentOutOfRangeException(nameof(fileType), fileType, null);
            }
        }

        #region Overrides of Object
        /// <summary>
        ///     Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        ///     A string that represents the current object.
        /// </returns>
        public override string ToString() { return $"{SORT_ID} | {Iteration_Code} | {Iterations}"; }
        #endregion
    }
}
