#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2016 10:59 AM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: DemographicProfile_Geo_Header.cs
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
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.OleDb;
    using Enumerators;
    #endregion

    public class DemographicProfile_Geo_Header : BaseModel
    {
        #region Properties
        [MaxLength(6)]
        [ReadOnly(false)]
        [Column("FILEID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
        public string FILEID { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("STUSAB", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }

        [MaxLength(3)]
        [ReadOnly(false)]
        [Column("SUMLEV", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Summary Level", ShortName = "Summary Level", Order = 2)]
        public string SUMLEV { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("GEOCOMP", Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Geographic Component", ShortName = "Geographic Component", Order = 3)]
        public string GEOCOMP { get; set; }

        [MaxLength(3)]
        [ReadOnly(false)]
        [Column("CHARITER", Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 4)]
        public string CHARITER { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("CIFSN", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 5)]
        public string CIFSN { get; set; }

        [MaxLength(7)]
        [ReadOnly(false)]
        [Column("LOGRECNO", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 6)]
        public string LOGRECNO { get; set; }

        [MaxLength(1)]
        [ReadOnly(false)]
        [Column("REGION", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Region", ShortName = "Region", Order = 7)]
        public string REGION { get; set; }

        [MaxLength(1)]
        [ReadOnly(false)]
        [Column("DIVISION", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Division", ShortName = "Division", Order = 8)]
        public string DIVISION { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("STATE", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State (FIPS)", ShortName = "State (FIPS)", Order = 9)]
        public string STATE { get; set; }

        [MaxLength(3)]
        [ReadOnly(false)]
        [Column("COUNTY", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "County", ShortName = "County", Order = 10)]
        public string COUNTY { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("COUNTYCC", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "FIPS County Class Code", ShortName = "FIPS County Class Code", Order = 11)]
        public string COUNTYCC { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("COUNTYSC", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "County Size Code", ShortName = "County Size Code", Order = 12)]
        public string COUNTYSC { get; set; }

        [MaxLength(5)]
        [ReadOnly(false)]
        [Column("COUSUB", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "County Subdivision (FIPS)", ShortName = "County Subdivision (FIPS)", Order = 13)]
        public string COUSUB { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("COUSUBCC", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "FIPS County Subdivision Class Code", ShortName = "FIPS County Subdivision Class Code", Order = 14)]
        public string COUSUBCC { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("COUSUBSC", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "County Subdivision Size Code", ShortName = "County Subdivision Size Code", Order = 15)]
        public string COUSUBSC { get; set; }

        [MaxLength(5)]
        [ReadOnly(false)]
        [Column("PLACE", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Place (FIPS)", ShortName = "Place (FIPS)", Order = 16)]
        public string PLACE { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("PLACECC", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "FIPS Place Class Code", ShortName = "FIPS Place Class Code", Order = 17)]
        public string PLACECC { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("PLACESC", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Place Size Code", ShortName = "Place Size Code", Order = 18)]
        public string PLACESC { get; set; }

        [MaxLength(6)]
        [ReadOnly(false)]
        [Column("TRACT", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Census Tract", ShortName = "Census Tract", Order = 19)]
        public string TRACT { get; set; }

        [MaxLength(1)]
        [ReadOnly(false)]
        [Column("BLKGRP", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Block Group", ShortName = "Block Group", Order = 20)]
        public string BLKGRP { get; set; }

        [MaxLength(4)]
        [ReadOnly(false)]
        [Column("BLOCK", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Block", ShortName = "Block", Order = 21)]
        public string BLOCK { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("IUC", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Internal Use Code", ShortName = "Internal Use Code", Order = 22)]
        public string IUC { get; set; }

        [MaxLength(5)]
        [ReadOnly(false)]
        [Column("CONCIT", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Consolidated City (FIPS)", ShortName = "Consolidated City (FIPS)", Order = 23)]
        public string CONCIT { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("CONCITCC", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "FIPS Consolidated City Class Code", ShortName = "FIPS Consolidated City Class Code", Order = 24)]
        public string CONCITCC { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("CONCITSC", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Consolidated City Size Code", ShortName = "Consolidated City Size Code", Order = 25)]
        public string CONCITSC { get; set; }

        [MaxLength(4)]
        [ReadOnly(false)]
        [Column("AIANHH", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian Area/Alaska Native Area/Hawaiian Home Land (Census)", ShortName = "American Indian Area/Alaska Native Area/Hawaiian Home Land (Census)", Order = 26)]
        public string AIANHH { get; set; }

        [MaxLength(5)]
        [ReadOnly(false)]
        [Column("AIANHHFP", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian Area/Alaska Native Area/Hawaiian Home Land (FIPS)", ShortName = "American Indian Area/Alaska Native Area/Hawaiian Home Land (FIPS)", Order = 27)]
        public string AIANHHFP { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("AIANHHCC", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "FIPS American Indian Area/Alaska Native Area/Hawaiian Home Land Class Code", ShortName = "FIPS American Indian Area/Alaska Native Area/Hawaiian Home Land Class Code", Order = 28)]
        public string AIANHHCC { get; set; }

        [MaxLength(1)]
        [ReadOnly(false)]
        [Column("AIHHTLI", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian Trust Land/Hawaiian Home Land Indicator", ShortName = "American Indian Trust Land/Hawaiian Home Land Indicator", Order = 29)]
        public string AIHHTLI { get; set; }

        [MaxLength(3)]
        [ReadOnly(false)]
        [Column("AITSCE", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian Tribal Subdivision (Census)", ShortName = "American Indian Tribal Subdivision (Census)", Order = 30)]
        public string AITSCE { get; set; }

        [MaxLength(5)]
        [ReadOnly(false)]
        [Column("AITS", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian Tribal Subdivision (FIPS)", ShortName = "American Indian Tribal Subdivision (FIPS)", Order = 31)]
        public string AITS { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("AITSCC", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "FIPS American Indian Tribal Subdivision Class Code", ShortName = "FIPS American Indian Tribal Subdivision Class Code", Order = 32)]
        public string AITSCC { get; set; }

        [MaxLength(6)]
        [ReadOnly(false)]
        [Column("TTRACT", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Tribal Census Tract", ShortName = "Tribal Census Tract", Order = 33)]
        public string TTRACT { get; set; }

        [MaxLength(1)]
        [ReadOnly(false)]
        [Column("TBLKGRP", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Tribal Block Group", ShortName = "Tribal Block Group", Order = 34)]
        public string TBLKGRP { get; set; }

        [MaxLength(5)]
        [ReadOnly(false)]
        [Column("ANRC", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Alaska Native Regional Corporation (FIPS)", ShortName = "Alaska Native Regional Corporation (FIPS)", Order = 35)]
        public string ANRC { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("ANRCCC", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "FIPS Alaska Native Regional Corporation Class Code", ShortName = "FIPS Alaska Native Regional Corporation Class Code", Order = 36)]
        public string ANRCCC { get; set; }

        [MaxLength(5)]
        [ReadOnly(false)]
        [Column("CBSA", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Metropolitan Statistical Area/Micropolitan Statistical Area", ShortName = "Metropolitan Statistical Area/Micropolitan Statistical Area", Order = 37)]
        public string CBSA { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("CBSASC", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Metropolitan Statistical Area/Micropolitan Statistical Area Size Code", ShortName = "Metropolitan Statistical Area/Micropolitan Statistical Area Size Code", Order = 38)]
        public string CBSASC { get; set; }

        [MaxLength(5)]
        [ReadOnly(false)]
        [Column("METDIV", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Metropolitan Division", ShortName = "Metropolitan Division", Order = 39)]
        public string METDIV { get; set; }

        [MaxLength(3)]
        [ReadOnly(false)]
        [Column("CSA", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Combined Statistical Area", ShortName = "Combined Statistical Area", Order = 40)]
        public string CSA { get; set; }

        [MaxLength(5)]
        [ReadOnly(false)]
        [Column("NECTA", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "New England City and Town Area", ShortName = "New England City and Town Area", Order = 41)]
        public string NECTA { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("NECTASC", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "New England City and Town Area Size Code", ShortName = "New England City and Town Area Size Code", Order = 42)]
        public string NECTASC { get; set; }

        [MaxLength(5)]
        [ReadOnly(false)]
        [Column("NECTADIV", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "New England City and Town Area Division", ShortName = "New England City and Town Area Division", Order = 43)]
        public string NECTADIV { get; set; }

        [MaxLength(3)]
        [ReadOnly(false)]
        [Column("CNECTA", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Combined New England City and Town Area", ShortName = "Combined New England City and Town Area", Order = 44)]
        public string CNECTA { get; set; }

        [MaxLength(1)]
        [ReadOnly(false)]
        [Column("CBSAPCI", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Metropolitan Statistical Area/Micropolitan Statistical Area Principal City Indicator", ShortName = "Metropolitan Statistical Area/Micropolitan Statistical Area Principal City Indicator", Order = 45)]
        public string CBSAPCI { get; set; }

        [MaxLength(1)]
        [ReadOnly(false)]
        [Column("NECTAPCI", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "New England City and Town Area Principal City Indicator", ShortName = "New England City and Town Area Principal City Indicator", Order = 46)]
        public string NECTAPCI { get; set; }

        [MaxLength(5)]
        [ReadOnly(false)]
        [Column("UA", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Urban Area", ShortName = "Urban Area", Order = 47)]
        public string UA { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("UASC", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Urban Area Size Code", ShortName = "Urban Area Size Code", Order = 48)]
        public string UASC { get; set; }

        [MaxLength(1)]
        [ReadOnly(false)]
        [Column("UATYPE", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Urban Area Type", ShortName = "Urban Area Type", Order = 49)]
        public string UATYPE { get; set; }

        [MaxLength(1)]
        [ReadOnly(false)]
        [Column("UR", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Urban/Rural", ShortName = "Urban/Rural", Order = 50)]
        public string UR { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("CD", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Congressional District (111th)", ShortName = "Congressional District (111th)", Order = 51)]
        public string CD { get; set; }

        [MaxLength(3)]
        [ReadOnly(false)]
        [Column("SLDU", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State Legislative District (Upper Chamber) (Year 1)", ShortName = "State Legislative District (Upper Chamber) (Year 1)", Order = 52)]
        public string SLDU { get; set; }

        [MaxLength(3)]
        [ReadOnly(false)]
        [Column("SLDL", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State Legislative District (Lower Chamber) (Year 1)", ShortName = "State Legislative District (Lower Chamber) (Year 1)", Order = 53)]
        public string SLDL { get; set; }

        [MaxLength(6)]
        [ReadOnly(false)]
        [Column("VTD", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Voting District", ShortName = "Voting District", Order = 54)]
        public string VTD { get; set; }

        [MaxLength(1)]
        [ReadOnly(false)]
        [Column("VTDI", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Voting District Indicator", ShortName = "Voting District Indicator", Order = 55)]
        public string VTDI { get; set; }

        [MaxLength(3)]
        [ReadOnly(false)]
        [Column("RESERVE2", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Reserved", ShortName = "Reserved", Order = 56)]
        public string RESERVE2 { get; set; }

        [MaxLength(5)]
        [ReadOnly(false)]
        [Column("ZCTA5", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "ZIP Code Tabulation Area (5 digit)", ShortName = "ZIP Code Tabulation Area (5 digit)", Order = 57)]
        public string ZCTA5 { get; set; }

        [MaxLength(5)]
        [ReadOnly(false)]
        [Column("SUBMCD", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Subminor Civil Division (FIPS)", ShortName = "Subminor Civil Division (FIPS)", Order = 58)]
        public string SUBMCD { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("SUBMCDCC", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "FIPS Subminor Civil Division Class Code", ShortName = "FIPS Subminor Civil Division Class Code", Order = 59)]
        public string SUBMCDCC { get; set; }

        [MaxLength(5)]
        [ReadOnly(false)]
        [Column("SDELM", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "School District (Elementary)", ShortName = "School District (Elementary)", Order = 60)]
        public string SDELM { get; set; }

        [MaxLength(5)]
        [ReadOnly(false)]
        [Column("SDSEC", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "School District (Secondary)", ShortName = "School District (Secondary)", Order = 61)]
        public string SDSEC { get; set; }

        [MaxLength(5)]
        [ReadOnly(false)]
        [Column("SDUNI", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "School District (Unified)", ShortName = "School District (Unified)", Order = 62)]
        public string SDUNI { get; set; }

        [MaxLength(14)]
        [ReadOnly(false)]
        [Column("AREALAND", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Area (Land)", ShortName = "Area (Land)", Order = 63)]
        public string AREALAND { get; set; }

        [MaxLength(14)]
        [ReadOnly(false)]
        [Column("AREAWATR", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Area (Water)", ShortName = "Area (Water)", Order = 64)]
        public string AREAWATR { get; set; }

        [MaxLength(90)]
        [ReadOnly(false)]
        [Column("NAME", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Area Name-Legal/Statistical Area Description (LSAD) Term-Part Indicator", ShortName = "Area Name-Legal/Statistical Area Description (LSAD) Term-Part Indicator", Order = 65)]
        public string NAME { get; set; }

        [MaxLength(1)]
        [ReadOnly(false)]
        [Column("FUNCSTAT", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Functional Status Code", ShortName = "Functional Status Code", Order = 66)]
        public string FUNCSTAT { get; set; }

        [MaxLength(1)]
        [ReadOnly(false)]
        [Column("GCUNI", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Geographic Change User Note Indicator", ShortName = "Geographic Change User Note Indicator", Order = 67)]
        public string GCUNI { get; set; }

        [MaxLength(9)]
        [ReadOnly(false)]
        [Column("POP100", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population Count (100%)", ShortName = "Population Count (100%)", Order = 68)]
        public string POP100 { get; set; }

        [MaxLength(9)]
        [ReadOnly(false)]
        [Column("HU100", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Housing Unit Count (100%)", ShortName = "Housing Unit Count (100%)", Order = 69)]
        public string HU100 { get; set; }

        [MaxLength(11)]
        [ReadOnly(false)]
        [Column("INTPTLAT", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Internal Point (Latitude)", ShortName = "Internal Point (Latitude)", Order = 70)]
        public string INTPTLAT { get; set; }

        [MaxLength(12)]
        [ReadOnly(false)]
        [Column("INTPTLON", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Internal Point (Longitude)", ShortName = "Internal Point (Longitude)", Order = 71)]
        public string INTPTLON { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("LSADC", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Legal/Statistical Area Description Code", ShortName = "Legal/Statistical Area Description Code", Order = 72)]
        public string LSADC { get; set; }

        [MaxLength(1)]
        [ReadOnly(false)]
        [Column("PARTFLAG", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Part Flag", ShortName = "Part Flag", Order = 73)]
        public string PARTFLAG { get; set; }

        [MaxLength(6)]
        [ReadOnly(false)]
        [Column("RESERVE3", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Reserved", ShortName = "Reserved", Order = 74)]
        public string RESERVE3 { get; set; }

        [MaxLength(5)]
        [ReadOnly(false)]
        [Column("UGA", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Urban Growth Area", ShortName = "Urban Growth Area", Order = 75)]
        public string UGA { get; set; }

        [MaxLength(8)]
        [ReadOnly(false)]
        [Column("STATENS", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State (ANSI)", ShortName = "State (ANSI)", Order = 76)]
        public string STATENS { get; set; }

        [MaxLength(8)]
        [ReadOnly(false)]
        [Column("COUNTYNS", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "County (ANSI)", ShortName = "County (ANSI)", Order = 77)]
        public string COUNTYNS { get; set; }

        [MaxLength(8)]
        [ReadOnly(false)]
        [Column("COUSUBNS", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "County Subdivision (ANSI)", ShortName = "County Subdivision (ANSI)", Order = 78)]
        public string COUSUBNS { get; set; }

        [MaxLength(8)]
        [ReadOnly(false)]
        [Column("PLACENS", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Place (ANSI)", ShortName = "Place (ANSI)", Order = 79)]
        public string PLACENS { get; set; }

        [MaxLength(8)]
        [ReadOnly(false)]
        [Column("CONCITNS", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Consolidated City (ANSI)", ShortName = "Consolidated City (ANSI)", Order = 80)]
        public string CONCITNS { get; set; }

        [MaxLength(8)]
        [ReadOnly(false)]
        [Column("AIANHHNS", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian Area/Alaska Native Area/Hawaiian Home Land (ANSI)", ShortName = "American Indian Area/Alaska Native Area/Hawaiian Home Land (ANSI)", Order = 81)]
        public string AIANHHNS { get; set; }

        [MaxLength(8)]
        [ReadOnly(false)]
        [Column("AITSNS", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian Tribal Subdivision (ANSI)", ShortName = "American Indian Tribal Subdivision (ANSI)", Order = 82)]
        public string AITSNS { get; set; }

        [MaxLength(8)]
        [ReadOnly(false)]
        [Column("ANRCNS", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Alaska Native Regional Corporation (ANSI)", ShortName = "Alaska Native Regional Corporation (ANSI)", Order = 83)]
        public string ANRCNS { get; set; }

        [MaxLength(8)]
        [ReadOnly(false)]
        [Column("SUBMCDNS", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Subminor Civil Division (ANSI)", ShortName = "Subminor Civil Division (ANSI)", Order = 84)]
        public string SUBMCDNS { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("CD113", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Congressional District (113th)", ShortName = "Congressional District (113th)", Order = 85)]
        public string CD113 { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("CD114", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Congressional District (114th)", ShortName = "Congressional District (114th)", Order = 86)]
        public string CD114 { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("CD115", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Congressional District (115th)", ShortName = "Congressional District (115th)", Order = 87)]
        public string CD115 { get; set; }

        [MaxLength(3)]
        [ReadOnly(false)]
        [Column("SLDU2", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State Legislative District (Upper Chamber) (Year 2)", ShortName = "State Legislative District (Upper Chamber) (Year 2)", Order = 88)]
        public string SLDU2 { get; set; }

        [MaxLength(3)]
        [ReadOnly(false)]
        [Column("SLDU3", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State Legislative District (Upper Chamber) (Year 3)", ShortName = "State Legislative District (Upper Chamber) (Year 3)", Order = 89)]
        public string SLDU3 { get; set; }

        [MaxLength(3)]
        [ReadOnly(false)]
        [Column("SLDU4", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State Legislative District (Upper Chamber) (Year 4)", ShortName = "State Legislative District (Upper Chamber) (Year 4)", Order = 90)]
        public string SLDU4 { get; set; }

        [MaxLength(3)]
        [ReadOnly(false)]
        [Column("SLDL2", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State Legislative District (Lower Chamber) (Year 2)", ShortName = "State Legislative District (Lower Chamber) (Year 2)", Order = 91)]
        public string SLDL2 { get; set; }

        [MaxLength(3)]
        [ReadOnly(false)]
        [Column("SLDL3", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State Legislative District (Lower Chamber) (Year 3)", ShortName = "State Legislative District (Lower Chamber) (Year 3)", Order = 92)]
        public string SLDL3 { get; set; }

        [MaxLength(3)]
        [ReadOnly(false)]
        [Column("SLDL4", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State Legislative District (Lower Chamber) (Year 4)", ShortName = "State Legislative District (Lower Chamber) (Year 4)", Order = 93)]
        public string SLDL4 { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("AIANHHSC", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian Area/Alaska Native Area/Hawaiian Home Land Size Code", ShortName = "American Indian Area/Alaska Native Area/Hawaiian Home Land Size Code", Order = 94)]
        public string AIANHHSC { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("CSASC", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Combined Statistical Area Size Code", ShortName = "Combined Statistical Area Size Code", Order = 95)]
        public string CSASC { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("CNECTASC", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Combined NECTA Size Code", ShortName = "Combined NECTA Size Code", Order = 96)]
        public string CNECTASC { get; set; }

        [MaxLength(1)]
        [ReadOnly(false)]
        [Column("MEMI", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Metropolitan Micropolitan Indicator", ShortName = "Metropolitan Micropolitan Indicator", Order = 97)]
        public string MEMI { get; set; }

        [MaxLength(1)]
        [ReadOnly(false)]
        [Column("NMEMI", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "NECTA Metropolitan Micropolitan Indicator", ShortName = "NECTA Metropolitan Micropolitan Indicator", Order = 98)]
        public string NMEMI { get; set; }

        [MaxLength(5)]
        [ReadOnly(false)]
        [Column("PUMA", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Public Use Microdata Area", ShortName = "Public Use Microdata Area", Order = 99)]
        public string PUMA { get; set; }

        [MaxLength(18)]
        [ReadOnly(false)]
        [Column("RESERVED", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Reserved", ShortName = "Reserved", Order = 100)]
        public string RESERVED { get; set; }
        #endregion Properties

        #region Constructors
        public DemographicProfile_Geo_Header(string csvLine) : base(csvLine) { }

        public DemographicProfile_Geo_Header(string[] values) : base(values) { }

        public DemographicProfile_Geo_Header(OleDbDataReader reader, CensusFileType fileType)
        {
            if (reader[0] != DBNull.Value)
            {
                FILEID = (string)reader[0];
            }
            if (reader[1] != DBNull.Value)
            {
                STUSAB = (string)reader[1];
            }
            if (reader[2] != DBNull.Value)
            {
                SUMLEV = (string)reader[2];
            }
            if (reader[3] != DBNull.Value)
            {
                GEOCOMP = (string)reader[3];
            }
            if (reader[4] != DBNull.Value)
            {
                CHARITER = (string)reader[4];
            }
            if (reader[5] != DBNull.Value)
            {
                CIFSN = (string)reader[5];
            }
            if (reader[6] != DBNull.Value)
            {
                LOGRECNO = (string)reader[6];
            }
            if (reader[7] != DBNull.Value)
            {
                REGION = (string)reader[7];
            }
            if (reader[8] != DBNull.Value)
            {
                DIVISION = (string)reader[8];
            }
            if (reader[9] != DBNull.Value)
            {
                STATE = (string)reader[9];
            }
            if (reader[10] != DBNull.Value)
            {
                COUNTY = (string)reader[10];
            }
            if (reader[11] != DBNull.Value)
            {
                COUNTYCC = (string)reader[11];
            }
            if (reader[12] != DBNull.Value)
            {
                COUNTYSC = (string)reader[12];
            }
            if (reader[13] != DBNull.Value)
            {
                COUSUB = (string)reader[13];
            }
            if (reader[14] != DBNull.Value)
            {
                COUSUBCC = (string)reader[14];
            }
            if (reader[15] != DBNull.Value)
            {
                COUSUBSC = (string)reader[15];
            }
            if (reader[16] != DBNull.Value)
            {
                PLACE = (string)reader[16];
            }
            if (reader[17] != DBNull.Value)
            {
                PLACECC = (string)reader[17];
            }
            if (reader[18] != DBNull.Value)
            {
                PLACESC = (string)reader[18];
            }
            if (reader[19] != DBNull.Value)
            {
                TRACT = (string)reader[19];
            }
            if (reader[20] != DBNull.Value)
            {
                BLKGRP = (string)reader[20];
            }
            if (reader[21] != DBNull.Value)
            {
                BLOCK = (string)reader[21];
            }
            if (reader[22] != DBNull.Value)
            {
                IUC = (string)reader[22];
            }
            if (reader[23] != DBNull.Value)
            {
                CONCIT = (string)reader[23];
            }
            if (reader[24] != DBNull.Value)
            {
                CONCITCC = (string)reader[24];
            }
            if (reader[25] != DBNull.Value)
            {
                CONCITSC = (string)reader[25];
            }
            if (reader[26] != DBNull.Value)
            {
                AIANHH = (string)reader[26];
            }
            if (reader[27] != DBNull.Value)
            {
                AIANHHFP = (string)reader[27];
            }
            if (reader[28] != DBNull.Value)
            {
                AIANHHCC = (string)reader[28];
            }
            if (reader[29] != DBNull.Value)
            {
                AIHHTLI = (string)reader[29];
            }
            if (reader[30] != DBNull.Value)
            {
                AITSCE = (string)reader[30];
            }
            if (reader[31] != DBNull.Value)
            {
                AITS = (string)reader[31];
            }
            if (reader[32] != DBNull.Value)
            {
                AITSCC = (string)reader[32];
            }
            if (reader[33] != DBNull.Value)
            {
                TTRACT = (string)reader[33];
            }
            if (reader[34] != DBNull.Value)
            {
                TBLKGRP = (string)reader[34];
            }
            if (reader[35] != DBNull.Value)
            {
                ANRC = (string)reader[35];
            }
            if (reader[36] != DBNull.Value)
            {
                ANRCCC = (string)reader[36];
            }
            if (reader[37] != DBNull.Value)
            {
                CBSA = (string)reader[37];
            }
            if (reader[38] != DBNull.Value)
            {
                CBSASC = (string)reader[38];
            }
            if (reader[39] != DBNull.Value)
            {
                METDIV = (string)reader[39];
            }
            if (reader[40] != DBNull.Value)
            {
                CSA = (string)reader[40];
            }
            if (reader[41] != DBNull.Value)
            {
                NECTA = (string)reader[41];
            }
            if (reader[42] != DBNull.Value)
            {
                NECTASC = (string)reader[42];
            }
            if (reader[43] != DBNull.Value)
            {
                NECTADIV = (string)reader[43];
            }
            if (reader[44] != DBNull.Value)
            {
                CNECTA = (string)reader[44];
            }
            if (reader[45] != DBNull.Value)
            {
                CBSAPCI = (string)reader[45];
            }
            if (reader[46] != DBNull.Value)
            {
                NECTAPCI = (string)reader[46];
            }
            if (reader[47] != DBNull.Value)
            {
                UA = (string)reader[47];
            }
            if (reader[48] != DBNull.Value)
            {
                UASC = (string)reader[48];
            }
            if (reader[49] != DBNull.Value)
            {
                UATYPE = (string)reader[49];
            }
            if (reader[50] != DBNull.Value)
            {
                UR = (string)reader[50];
            }
            if (reader[51] != DBNull.Value)
            {
                CD = (string)reader[51];
            }
            if (reader[52] != DBNull.Value)
            {
                SLDU = (string)reader[52];
            }
            if (reader[53] != DBNull.Value)
            {
                SLDL = (string)reader[53];
            }
            if (reader[54] != DBNull.Value)
            {
                VTD = (string)reader[54];
            }
            if (reader[55] != DBNull.Value)
            {
                VTDI = (string)reader[55];
            }
            if (reader[56] != DBNull.Value)
            {
                RESERVE2 = (string)reader[56];
            }
            if (reader[57] != DBNull.Value)
            {
                ZCTA5 = (string)reader[57];
            }
            if (reader[58] != DBNull.Value)
            {
                SUBMCD = (string)reader[58];
            }
            if (reader[59] != DBNull.Value)
            {
                SUBMCDCC = (string)reader[59];
            }
            if (reader[60] != DBNull.Value)
            {
                SDELM = (string)reader[60];
            }
            if (reader[61] != DBNull.Value)
            {
                SDSEC = (string)reader[61];
            }
            if (reader[62] != DBNull.Value)
            {
                SDUNI = (string)reader[62];
            }
            if (reader[63] != DBNull.Value)
            {
                AREALAND = (string)reader[63];
            }
            if (reader[64] != DBNull.Value)
            {
                AREAWATR = (string)reader[64];
            }
            if (reader[65] != DBNull.Value)
            {
                NAME = (string)reader[65];
            }
            if (reader[66] != DBNull.Value)
            {
                FUNCSTAT = (string)reader[66];
            }
            if (reader[67] != DBNull.Value)
            {
                GCUNI = (string)reader[67];
            }
            if (reader[68] != DBNull.Value)
            {
                POP100 = (string)reader[68];
            }
            if (reader[69] != DBNull.Value)
            {
                HU100 = (string)reader[69];
            }
            if (reader[70] != DBNull.Value)
            {
                INTPTLAT = (string)reader[70];
            }
            if (reader[71] != DBNull.Value)
            {
                INTPTLON = (string)reader[71];
            }
            if (reader[72] != DBNull.Value)
            {
                LSADC = (string)reader[72];
            }
            if (reader[73] != DBNull.Value)
            {
                PARTFLAG = (string)reader[73];
            }
            if (reader[74] != DBNull.Value)
            {
                RESERVE3 = (string)reader[74];
            }
            if (reader[75] != DBNull.Value)
            {
                UGA = (string)reader[75];
            }
            if (reader[76] != DBNull.Value)
            {
                STATENS = (string)reader[76];
            }
            if (reader[77] != DBNull.Value)
            {
                COUNTYNS = (string)reader[77];
            }
            if (reader[78] != DBNull.Value)
            {
                COUSUBNS = (string)reader[78];
            }
            if (reader[79] != DBNull.Value)
            {
                PLACENS = (string)reader[79];
            }
            if (reader[80] != DBNull.Value)
            {
                CONCITNS = (string)reader[80];
            }
            if (reader[81] != DBNull.Value)
            {
                AIANHHNS = (string)reader[81];
            }
            if (reader[82] != DBNull.Value)
            {
                AITSNS = (string)reader[82];
            }
            if (reader[83] != DBNull.Value)
            {
                ANRCNS = (string)reader[83];
            }
            if (reader[84] != DBNull.Value)
            {
                SUBMCDNS = (string)reader[84];
            }
            if (reader[85] != DBNull.Value)
            {
                CD113 = (string)reader[85];
            }
            if (reader[86] != DBNull.Value)
            {
                CD114 = (string)reader[86];
            }
            if (reader[87] != DBNull.Value)
            {
                CD115 = (string)reader[87];
            }
            if (reader[88] != DBNull.Value)
            {
                SLDU2 = (string)reader[88];
            }
            if (reader[89] != DBNull.Value)
            {
                SLDU3 = (string)reader[89];
            }
            if (reader[90] != DBNull.Value)
            {
                SLDU4 = (string)reader[90];
            }
            if (reader[91] != DBNull.Value)
            {
                SLDL2 = (string)reader[91];
            }
            if (reader[92] != DBNull.Value)
            {
                SLDL3 = (string)reader[92];
            }
            if (reader[93] != DBNull.Value)
            {
                SLDL4 = (string)reader[93];
            }
            if (reader[94] != DBNull.Value)
            {
                AIANHHSC = (string)reader[94];
            }
            if (reader[95] != DBNull.Value)
            {
                CSASC = (string)reader[95];
            }
            if (reader[96] != DBNull.Value)
            {
                CNECTASC = (string)reader[96];
            }
            if (reader[97] != DBNull.Value)
            {
                MEMI = (string)reader[97];
            }
            if (reader[98] != DBNull.Value)
            {
                NMEMI = (string)reader[98];
            }
            if (reader[99] != DBNull.Value)
            {
                PUMA = (string)reader[99];
            }
            if (reader[100] != DBNull.Value)
            {
                RESERVED = (string)reader[100];
            }
        }
        #endregion Constructors
    }
}
