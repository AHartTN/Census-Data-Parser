#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2015 12:37 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: CensusDataPaths.cs
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

namespace CensusDataParser
{
    #region Using Directives
    using System.Configuration;
    #endregion

    public class CensusDataPaths
    {
        public static string AssembledCongressionalDistrictsPath => $@"{(UseFtp
                                                                             ? FtpRootPath
                                                                             : LocalRootPath)}\{ContainerPath}\{CongressionalDistrictsPath}";

        public static string AssembledDemographicProfilePath => $@"{(UseFtp
                                                                         ? FtpRootPath
                                                                         : LocalRootPath)}\{ContainerPath}\{DemographicProfilePath}";

        public static string AssembledRedistrictingPath => $@"{(UseFtp
                                                                    ? FtpRootPath
                                                                    : LocalRootPath)}\{ContainerPath}\{RedistrictingPath}";

        public static string AssembledSummary1Path => $@"{(UseFtp
                                                               ? FtpRootPath
                                                               : LocalRootPath)}\{ContainerPath}\{Summary1Path}";

        public static string AssembledSummary2Path => $@"{(UseFtp
                                                               ? FtpRootPath
                                                               : LocalRootPath)}\{ContainerPath}\{Summary2Path}";

        public static string CongressionalDistrictsAccessFile => $@"{AssembledCongressionalDistrictsPath}\{CongressionalDistrictsAccessFileName}";

        public static string DemographicProfileAccessFile => $@"{AssembledDemographicProfilePath}\{DemographicProfileAccessFileName}";

        public static string RedistrictingAccessFile => $@"{AssembledRedistrictingPath}\{RedistrictingAccessFileName}";

        public static string Summary1AccessFile => $@"{AssembledSummary1Path}\{Summary1AccessFileName}";
        public static string Summary2AccessFile => $@"{AssembledSummary2Path}\{Summary2AccessFileName}";

        public static bool UseFtp => bool.Parse(ConfigurationManager.AppSettings["UseFTP"]);
        public const string CongressionalDistrictsAccessFileName = @"SF1_Access2007_v2.accdb";
        public const string CongressionalDistrictsPath = @"08-SF1_Congressional_Districts_113";
        public const string ContainerPath = @"census_2010";
        public const string DemographicProfileAccessFileName = @"DPSF2010_Access.accdb";
        public const string DemographicProfilePath = @"03-Demographic_Profile_with_SF1geos";
        public const string FtpRootPath = @"ftp://ftp.census.gov";

        public const string RedistrictingAccessFileName = @"PL2010_Access.accdb";

        public const string RedistrictingPath = @"01-Redistricting_File--PL_94-171";
        public const string Summary1AccessFileName = @"SF1_Access2007.accdb";
        public const string Summary1Path = @"04-Summary_File_1";
        public const string Summary2AccessFileName = @"SF2_MSAccess_2007.accdb";
        public const string Summary2Path = @"05-Summary_File_2";
        public static string LocalRootPath = ConfigurationManager.AppSettings["LocalRootPath"];
        public static string[] AllPaths = {AssembledRedistrictingPath, AssembledDemographicProfilePath, AssembledSummary1Path, AssembledSummary2Path, AssembledCongressionalDistrictsPath};
        public static string[] AllAccessFiles = {RedistrictingAccessFile, DemographicProfileAccessFile, Summary1AccessFile, Summary2AccessFile, CongressionalDistrictsAccessFile};
    }
}
