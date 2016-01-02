#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2016 12:10 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1CongressionalDistricts113_SF1_00029Map.cs
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

namespace CensusDataParser.Generated.Mapping
{
    #region Using Directives
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using Binding;
    #endregion

    public class SF1CongressionalDistricts113_SF1_00029Map : EntityTypeConfiguration<SF1CongressionalDistricts113_SF1_00029>
    {
        public SF1CongressionalDistricts113_SF1_00029Map()
        {
            ToTable("SF1_00029", "SF1CongressionalDistricts113");

            Property(p => p.FILEID)
                .HasColumnName("FILEID")
                .HasColumnOrder(0)
                .HasColumnType("NVARCHAR")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasMaxLength(255)
                .HasParameterName("FILEID")
                .IsOptional();

            Property(p => p.STUSAB)
                .HasColumnName("STUSAB")
                .HasColumnOrder(1)
                .HasColumnType("NVARCHAR")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasMaxLength(255)
                .HasParameterName("STUSAB")
                .IsOptional();

            Property(p => p.CHARITER)
                .HasColumnName("CHARITER")
                .HasColumnOrder(2)
                .HasColumnType("NVARCHAR")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasMaxLength(255)
                .HasParameterName("CHARITER")
                .IsOptional();

            Property(p => p.CIFSN)
                .HasColumnName("CIFSN")
                .HasColumnOrder(3)
                .HasColumnType("NVARCHAR")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasMaxLength(255)
                .HasParameterName("CIFSN")
                .IsOptional();

            Property(p => p.LOGRECNO)
                .HasColumnName("LOGRECNO")
                .HasColumnOrder(4)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("LOGRECNO")
                .IsOptional();

            Property(p => p.PCT012J001)
                .HasColumnName("PCT012J001")
                .HasColumnOrder(5)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J001")
                .IsOptional();

            Property(p => p.PCT012J002)
                .HasColumnName("PCT012J002")
                .HasColumnOrder(6)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J002")
                .IsOptional();

            Property(p => p.PCT012J003)
                .HasColumnName("PCT012J003")
                .HasColumnOrder(7)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J003")
                .IsOptional();

            Property(p => p.PCT012J004)
                .HasColumnName("PCT012J004")
                .HasColumnOrder(8)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J004")
                .IsOptional();

            Property(p => p.PCT012J005)
                .HasColumnName("PCT012J005")
                .HasColumnOrder(9)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J005")
                .IsOptional();

            Property(p => p.PCT012J006)
                .HasColumnName("PCT012J006")
                .HasColumnOrder(10)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J006")
                .IsOptional();

            Property(p => p.PCT012J007)
                .HasColumnName("PCT012J007")
                .HasColumnOrder(11)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J007")
                .IsOptional();

            Property(p => p.PCT012J008)
                .HasColumnName("PCT012J008")
                .HasColumnOrder(12)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J008")
                .IsOptional();

            Property(p => p.PCT012J009)
                .HasColumnName("PCT012J009")
                .HasColumnOrder(13)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J009")
                .IsOptional();

            Property(p => p.PCT012J010)
                .HasColumnName("PCT012J010")
                .HasColumnOrder(14)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J010")
                .IsOptional();

            Property(p => p.PCT012J011)
                .HasColumnName("PCT012J011")
                .HasColumnOrder(15)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J011")
                .IsOptional();

            Property(p => p.PCT012J012)
                .HasColumnName("PCT012J012")
                .HasColumnOrder(16)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J012")
                .IsOptional();

            Property(p => p.PCT012J013)
                .HasColumnName("PCT012J013")
                .HasColumnOrder(17)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J013")
                .IsOptional();

            Property(p => p.PCT012J014)
                .HasColumnName("PCT012J014")
                .HasColumnOrder(18)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J014")
                .IsOptional();

            Property(p => p.PCT012J015)
                .HasColumnName("PCT012J015")
                .HasColumnOrder(19)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J015")
                .IsOptional();

            Property(p => p.PCT012J016)
                .HasColumnName("PCT012J016")
                .HasColumnOrder(20)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J016")
                .IsOptional();

            Property(p => p.PCT012J017)
                .HasColumnName("PCT012J017")
                .HasColumnOrder(21)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J017")
                .IsOptional();

            Property(p => p.PCT012J018)
                .HasColumnName("PCT012J018")
                .HasColumnOrder(22)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J018")
                .IsOptional();

            Property(p => p.PCT012J019)
                .HasColumnName("PCT012J019")
                .HasColumnOrder(23)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J019")
                .IsOptional();

            Property(p => p.PCT012J020)
                .HasColumnName("PCT012J020")
                .HasColumnOrder(24)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J020")
                .IsOptional();

            Property(p => p.PCT012J021)
                .HasColumnName("PCT012J021")
                .HasColumnOrder(25)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J021")
                .IsOptional();

            Property(p => p.PCT012J022)
                .HasColumnName("PCT012J022")
                .HasColumnOrder(26)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J022")
                .IsOptional();

            Property(p => p.PCT012J023)
                .HasColumnName("PCT012J023")
                .HasColumnOrder(27)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J023")
                .IsOptional();

            Property(p => p.PCT012J024)
                .HasColumnName("PCT012J024")
                .HasColumnOrder(28)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J024")
                .IsOptional();

            Property(p => p.PCT012J025)
                .HasColumnName("PCT012J025")
                .HasColumnOrder(29)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J025")
                .IsOptional();

            Property(p => p.PCT012J026)
                .HasColumnName("PCT012J026")
                .HasColumnOrder(30)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J026")
                .IsOptional();

            Property(p => p.PCT012J027)
                .HasColumnName("PCT012J027")
                .HasColumnOrder(31)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J027")
                .IsOptional();

            Property(p => p.PCT012J028)
                .HasColumnName("PCT012J028")
                .HasColumnOrder(32)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J028")
                .IsOptional();

            Property(p => p.PCT012J029)
                .HasColumnName("PCT012J029")
                .HasColumnOrder(33)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J029")
                .IsOptional();

            Property(p => p.PCT012J030)
                .HasColumnName("PCT012J030")
                .HasColumnOrder(34)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J030")
                .IsOptional();

            Property(p => p.PCT012J031)
                .HasColumnName("PCT012J031")
                .HasColumnOrder(35)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J031")
                .IsOptional();

            Property(p => p.PCT012J032)
                .HasColumnName("PCT012J032")
                .HasColumnOrder(36)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J032")
                .IsOptional();

            Property(p => p.PCT012J033)
                .HasColumnName("PCT012J033")
                .HasColumnOrder(37)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J033")
                .IsOptional();

            Property(p => p.PCT012J034)
                .HasColumnName("PCT012J034")
                .HasColumnOrder(38)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J034")
                .IsOptional();

            Property(p => p.PCT012J035)
                .HasColumnName("PCT012J035")
                .HasColumnOrder(39)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J035")
                .IsOptional();

            Property(p => p.PCT012J036)
                .HasColumnName("PCT012J036")
                .HasColumnOrder(40)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J036")
                .IsOptional();

            Property(p => p.PCT012J037)
                .HasColumnName("PCT012J037")
                .HasColumnOrder(41)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J037")
                .IsOptional();

            Property(p => p.PCT012J038)
                .HasColumnName("PCT012J038")
                .HasColumnOrder(42)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J038")
                .IsOptional();

            Property(p => p.PCT012J039)
                .HasColumnName("PCT012J039")
                .HasColumnOrder(43)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J039")
                .IsOptional();

            Property(p => p.PCT012J040)
                .HasColumnName("PCT012J040")
                .HasColumnOrder(44)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J040")
                .IsOptional();

            Property(p => p.PCT012J041)
                .HasColumnName("PCT012J041")
                .HasColumnOrder(45)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J041")
                .IsOptional();

            Property(p => p.PCT012J042)
                .HasColumnName("PCT012J042")
                .HasColumnOrder(46)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J042")
                .IsOptional();

            Property(p => p.PCT012J043)
                .HasColumnName("PCT012J043")
                .HasColumnOrder(47)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J043")
                .IsOptional();

            Property(p => p.PCT012J044)
                .HasColumnName("PCT012J044")
                .HasColumnOrder(48)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J044")
                .IsOptional();

            Property(p => p.PCT012J045)
                .HasColumnName("PCT012J045")
                .HasColumnOrder(49)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J045")
                .IsOptional();

            Property(p => p.PCT012J046)
                .HasColumnName("PCT012J046")
                .HasColumnOrder(50)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J046")
                .IsOptional();

            Property(p => p.PCT012J047)
                .HasColumnName("PCT012J047")
                .HasColumnOrder(51)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J047")
                .IsOptional();

            Property(p => p.PCT012J048)
                .HasColumnName("PCT012J048")
                .HasColumnOrder(52)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J048")
                .IsOptional();

            Property(p => p.PCT012J049)
                .HasColumnName("PCT012J049")
                .HasColumnOrder(53)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J049")
                .IsOptional();

            Property(p => p.PCT012J050)
                .HasColumnName("PCT012J050")
                .HasColumnOrder(54)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J050")
                .IsOptional();

            Property(p => p.PCT012J051)
                .HasColumnName("PCT012J051")
                .HasColumnOrder(55)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J051")
                .IsOptional();

            Property(p => p.PCT012J052)
                .HasColumnName("PCT012J052")
                .HasColumnOrder(56)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J052")
                .IsOptional();

            Property(p => p.PCT012J053)
                .HasColumnName("PCT012J053")
                .HasColumnOrder(57)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J053")
                .IsOptional();

            Property(p => p.PCT012J054)
                .HasColumnName("PCT012J054")
                .HasColumnOrder(58)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J054")
                .IsOptional();

            Property(p => p.PCT012J055)
                .HasColumnName("PCT012J055")
                .HasColumnOrder(59)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J055")
                .IsOptional();

            Property(p => p.PCT012J056)
                .HasColumnName("PCT012J056")
                .HasColumnOrder(60)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J056")
                .IsOptional();

            Property(p => p.PCT012J057)
                .HasColumnName("PCT012J057")
                .HasColumnOrder(61)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J057")
                .IsOptional();

            Property(p => p.PCT012J058)
                .HasColumnName("PCT012J058")
                .HasColumnOrder(62)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J058")
                .IsOptional();

            Property(p => p.PCT012J059)
                .HasColumnName("PCT012J059")
                .HasColumnOrder(63)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J059")
                .IsOptional();

            Property(p => p.PCT012J060)
                .HasColumnName("PCT012J060")
                .HasColumnOrder(64)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J060")
                .IsOptional();

            Property(p => p.PCT012J061)
                .HasColumnName("PCT012J061")
                .HasColumnOrder(65)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J061")
                .IsOptional();

            Property(p => p.PCT012J062)
                .HasColumnName("PCT012J062")
                .HasColumnOrder(66)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J062")
                .IsOptional();

            Property(p => p.PCT012J063)
                .HasColumnName("PCT012J063")
                .HasColumnOrder(67)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J063")
                .IsOptional();

            Property(p => p.PCT012J064)
                .HasColumnName("PCT012J064")
                .HasColumnOrder(68)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J064")
                .IsOptional();

            Property(p => p.PCT012J065)
                .HasColumnName("PCT012J065")
                .HasColumnOrder(69)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J065")
                .IsOptional();

            Property(p => p.PCT012J066)
                .HasColumnName("PCT012J066")
                .HasColumnOrder(70)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J066")
                .IsOptional();

            Property(p => p.PCT012J067)
                .HasColumnName("PCT012J067")
                .HasColumnOrder(71)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J067")
                .IsOptional();

            Property(p => p.PCT012J068)
                .HasColumnName("PCT012J068")
                .HasColumnOrder(72)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J068")
                .IsOptional();

            Property(p => p.PCT012J069)
                .HasColumnName("PCT012J069")
                .HasColumnOrder(73)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J069")
                .IsOptional();

            Property(p => p.PCT012J070)
                .HasColumnName("PCT012J070")
                .HasColumnOrder(74)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J070")
                .IsOptional();

            Property(p => p.PCT012J071)
                .HasColumnName("PCT012J071")
                .HasColumnOrder(75)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J071")
                .IsOptional();

            Property(p => p.PCT012J072)
                .HasColumnName("PCT012J072")
                .HasColumnOrder(76)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J072")
                .IsOptional();

            Property(p => p.PCT012J073)
                .HasColumnName("PCT012J073")
                .HasColumnOrder(77)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J073")
                .IsOptional();

            Property(p => p.PCT012J074)
                .HasColumnName("PCT012J074")
                .HasColumnOrder(78)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J074")
                .IsOptional();

            Property(p => p.PCT012J075)
                .HasColumnName("PCT012J075")
                .HasColumnOrder(79)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J075")
                .IsOptional();

            Property(p => p.PCT012J076)
                .HasColumnName("PCT012J076")
                .HasColumnOrder(80)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J076")
                .IsOptional();

            Property(p => p.PCT012J077)
                .HasColumnName("PCT012J077")
                .HasColumnOrder(81)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J077")
                .IsOptional();

            Property(p => p.PCT012J078)
                .HasColumnName("PCT012J078")
                .HasColumnOrder(82)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J078")
                .IsOptional();

            Property(p => p.PCT012J079)
                .HasColumnName("PCT012J079")
                .HasColumnOrder(83)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J079")
                .IsOptional();

            Property(p => p.PCT012J080)
                .HasColumnName("PCT012J080")
                .HasColumnOrder(84)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J080")
                .IsOptional();

            Property(p => p.PCT012J081)
                .HasColumnName("PCT012J081")
                .HasColumnOrder(85)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J081")
                .IsOptional();

            Property(p => p.PCT012J082)
                .HasColumnName("PCT012J082")
                .HasColumnOrder(86)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J082")
                .IsOptional();

            Property(p => p.PCT012J083)
                .HasColumnName("PCT012J083")
                .HasColumnOrder(87)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J083")
                .IsOptional();

            Property(p => p.PCT012J084)
                .HasColumnName("PCT012J084")
                .HasColumnOrder(88)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J084")
                .IsOptional();

            Property(p => p.PCT012J085)
                .HasColumnName("PCT012J085")
                .HasColumnOrder(89)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J085")
                .IsOptional();

            Property(p => p.PCT012J086)
                .HasColumnName("PCT012J086")
                .HasColumnOrder(90)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J086")
                .IsOptional();

            Property(p => p.PCT012J087)
                .HasColumnName("PCT012J087")
                .HasColumnOrder(91)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J087")
                .IsOptional();

            Property(p => p.PCT012J088)
                .HasColumnName("PCT012J088")
                .HasColumnOrder(92)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J088")
                .IsOptional();

            Property(p => p.PCT012J089)
                .HasColumnName("PCT012J089")
                .HasColumnOrder(93)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J089")
                .IsOptional();

            Property(p => p.PCT012J090)
                .HasColumnName("PCT012J090")
                .HasColumnOrder(94)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J090")
                .IsOptional();

            Property(p => p.PCT012J091)
                .HasColumnName("PCT012J091")
                .HasColumnOrder(95)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J091")
                .IsOptional();

            Property(p => p.PCT012J092)
                .HasColumnName("PCT012J092")
                .HasColumnOrder(96)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J092")
                .IsOptional();

            Property(p => p.PCT012J093)
                .HasColumnName("PCT012J093")
                .HasColumnOrder(97)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J093")
                .IsOptional();

            Property(p => p.PCT012J094)
                .HasColumnName("PCT012J094")
                .HasColumnOrder(98)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J094")
                .IsOptional();

            Property(p => p.PCT012J095)
                .HasColumnName("PCT012J095")
                .HasColumnOrder(99)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J095")
                .IsOptional();

            Property(p => p.PCT012J096)
                .HasColumnName("PCT012J096")
                .HasColumnOrder(100)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J096")
                .IsOptional();

            Property(p => p.PCT012J097)
                .HasColumnName("PCT012J097")
                .HasColumnOrder(101)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J097")
                .IsOptional();

            Property(p => p.PCT012J098)
                .HasColumnName("PCT012J098")
                .HasColumnOrder(102)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J098")
                .IsOptional();

            Property(p => p.PCT012J099)
                .HasColumnName("PCT012J099")
                .HasColumnOrder(103)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J099")
                .IsOptional();

            Property(p => p.PCT012J100)
                .HasColumnName("PCT012J100")
                .HasColumnOrder(104)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J100")
                .IsOptional();

            Property(p => p.PCT012J101)
                .HasColumnName("PCT012J101")
                .HasColumnOrder(105)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J101")
                .IsOptional();

            Property(p => p.PCT012J102)
                .HasColumnName("PCT012J102")
                .HasColumnOrder(106)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J102")
                .IsOptional();

            Property(p => p.PCT012J103)
                .HasColumnName("PCT012J103")
                .HasColumnOrder(107)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J103")
                .IsOptional();

            Property(p => p.PCT012J104)
                .HasColumnName("PCT012J104")
                .HasColumnOrder(108)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J104")
                .IsOptional();

            Property(p => p.PCT012J105)
                .HasColumnName("PCT012J105")
                .HasColumnOrder(109)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J105")
                .IsOptional();

            Property(p => p.PCT012J106)
                .HasColumnName("PCT012J106")
                .HasColumnOrder(110)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J106")
                .IsOptional();

            Property(p => p.PCT012J107)
                .HasColumnName("PCT012J107")
                .HasColumnOrder(111)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J107")
                .IsOptional();

            Property(p => p.PCT012J108)
                .HasColumnName("PCT012J108")
                .HasColumnOrder(112)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J108")
                .IsOptional();

            Property(p => p.PCT012J109)
                .HasColumnName("PCT012J109")
                .HasColumnOrder(113)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J109")
                .IsOptional();

            Property(p => p.PCT012J110)
                .HasColumnName("PCT012J110")
                .HasColumnOrder(114)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J110")
                .IsOptional();

            Property(p => p.PCT012J111)
                .HasColumnName("PCT012J111")
                .HasColumnOrder(115)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J111")
                .IsOptional();

            Property(p => p.PCT012J112)
                .HasColumnName("PCT012J112")
                .HasColumnOrder(116)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J112")
                .IsOptional();

            Property(p => p.PCT012J113)
                .HasColumnName("PCT012J113")
                .HasColumnOrder(117)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J113")
                .IsOptional();

            Property(p => p.PCT012J114)
                .HasColumnName("PCT012J114")
                .HasColumnOrder(118)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J114")
                .IsOptional();

            Property(p => p.PCT012J115)
                .HasColumnName("PCT012J115")
                .HasColumnOrder(119)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J115")
                .IsOptional();

            Property(p => p.PCT012J116)
                .HasColumnName("PCT012J116")
                .HasColumnOrder(120)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J116")
                .IsOptional();

            Property(p => p.PCT012J117)
                .HasColumnName("PCT012J117")
                .HasColumnOrder(121)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J117")
                .IsOptional();

            Property(p => p.PCT012J118)
                .HasColumnName("PCT012J118")
                .HasColumnOrder(122)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J118")
                .IsOptional();

            Property(p => p.PCT012J119)
                .HasColumnName("PCT012J119")
                .HasColumnOrder(123)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J119")
                .IsOptional();

            Property(p => p.PCT012J120)
                .HasColumnName("PCT012J120")
                .HasColumnOrder(124)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J120")
                .IsOptional();

            Property(p => p.PCT012J121)
                .HasColumnName("PCT012J121")
                .HasColumnOrder(125)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J121")
                .IsOptional();

            Property(p => p.PCT012J122)
                .HasColumnName("PCT012J122")
                .HasColumnOrder(126)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J122")
                .IsOptional();

            Property(p => p.PCT012J123)
                .HasColumnName("PCT012J123")
                .HasColumnOrder(127)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J123")
                .IsOptional();

            Property(p => p.PCT012J124)
                .HasColumnName("PCT012J124")
                .HasColumnOrder(128)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J124")
                .IsOptional();

            Property(p => p.PCT012J125)
                .HasColumnName("PCT012J125")
                .HasColumnOrder(129)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J125")
                .IsOptional();

            Property(p => p.PCT012J126)
                .HasColumnName("PCT012J126")
                .HasColumnOrder(130)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J126")
                .IsOptional();

            Property(p => p.PCT012J127)
                .HasColumnName("PCT012J127")
                .HasColumnOrder(131)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J127")
                .IsOptional();

            Property(p => p.PCT012J128)
                .HasColumnName("PCT012J128")
                .HasColumnOrder(132)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J128")
                .IsOptional();

            Property(p => p.PCT012J129)
                .HasColumnName("PCT012J129")
                .HasColumnOrder(133)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J129")
                .IsOptional();

            Property(p => p.PCT012J130)
                .HasColumnName("PCT012J130")
                .HasColumnOrder(134)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J130")
                .IsOptional();

            Property(p => p.PCT012J131)
                .HasColumnName("PCT012J131")
                .HasColumnOrder(135)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J131")
                .IsOptional();

            Property(p => p.PCT012J132)
                .HasColumnName("PCT012J132")
                .HasColumnOrder(136)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J132")
                .IsOptional();

            Property(p => p.PCT012J133)
                .HasColumnName("PCT012J133")
                .HasColumnOrder(137)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J133")
                .IsOptional();

            Property(p => p.PCT012J134)
                .HasColumnName("PCT012J134")
                .HasColumnOrder(138)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J134")
                .IsOptional();

            Property(p => p.PCT012J135)
                .HasColumnName("PCT012J135")
                .HasColumnOrder(139)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J135")
                .IsOptional();

            Property(p => p.PCT012J136)
                .HasColumnName("PCT012J136")
                .HasColumnOrder(140)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J136")
                .IsOptional();

            Property(p => p.PCT012J137)
                .HasColumnName("PCT012J137")
                .HasColumnOrder(141)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J137")
                .IsOptional();

            Property(p => p.PCT012J138)
                .HasColumnName("PCT012J138")
                .HasColumnOrder(142)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J138")
                .IsOptional();

            Property(p => p.PCT012J139)
                .HasColumnName("PCT012J139")
                .HasColumnOrder(143)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J139")
                .IsOptional();

            Property(p => p.PCT012J140)
                .HasColumnName("PCT012J140")
                .HasColumnOrder(144)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J140")
                .IsOptional();

            Property(p => p.PCT012J141)
                .HasColumnName("PCT012J141")
                .HasColumnOrder(145)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J141")
                .IsOptional();

            Property(p => p.PCT012J142)
                .HasColumnName("PCT012J142")
                .HasColumnOrder(146)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J142")
                .IsOptional();

            Property(p => p.PCT012J143)
                .HasColumnName("PCT012J143")
                .HasColumnOrder(147)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J143")
                .IsOptional();

            Property(p => p.PCT012J144)
                .HasColumnName("PCT012J144")
                .HasColumnOrder(148)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J144")
                .IsOptional();

            Property(p => p.PCT012J145)
                .HasColumnName("PCT012J145")
                .HasColumnOrder(149)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J145")
                .IsOptional();

            Property(p => p.PCT012J146)
                .HasColumnName("PCT012J146")
                .HasColumnOrder(150)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J146")
                .IsOptional();

            Property(p => p.PCT012J147)
                .HasColumnName("PCT012J147")
                .HasColumnOrder(151)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J147")
                .IsOptional();

            Property(p => p.PCT012J148)
                .HasColumnName("PCT012J148")
                .HasColumnOrder(152)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J148")
                .IsOptional();

            Property(p => p.PCT012J149)
                .HasColumnName("PCT012J149")
                .HasColumnOrder(153)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J149")
                .IsOptional();

            Property(p => p.PCT012J150)
                .HasColumnName("PCT012J150")
                .HasColumnOrder(154)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J150")
                .IsOptional();

            Property(p => p.PCT012J151)
                .HasColumnName("PCT012J151")
                .HasColumnOrder(155)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J151")
                .IsOptional();

            Property(p => p.PCT012J152)
                .HasColumnName("PCT012J152")
                .HasColumnOrder(156)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J152")
                .IsOptional();

            Property(p => p.PCT012J153)
                .HasColumnName("PCT012J153")
                .HasColumnOrder(157)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J153")
                .IsOptional();

            Property(p => p.PCT012J154)
                .HasColumnName("PCT012J154")
                .HasColumnOrder(158)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J154")
                .IsOptional();

            Property(p => p.PCT012J155)
                .HasColumnName("PCT012J155")
                .HasColumnOrder(159)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J155")
                .IsOptional();

            Property(p => p.PCT012J156)
                .HasColumnName("PCT012J156")
                .HasColumnOrder(160)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J156")
                .IsOptional();

            Property(p => p.PCT012J157)
                .HasColumnName("PCT012J157")
                .HasColumnOrder(161)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J157")
                .IsOptional();

            Property(p => p.PCT012J158)
                .HasColumnName("PCT012J158")
                .HasColumnOrder(162)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J158")
                .IsOptional();

            Property(p => p.PCT012J159)
                .HasColumnName("PCT012J159")
                .HasColumnOrder(163)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J159")
                .IsOptional();

            Property(p => p.PCT012J160)
                .HasColumnName("PCT012J160")
                .HasColumnOrder(164)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J160")
                .IsOptional();

            Property(p => p.PCT012J161)
                .HasColumnName("PCT012J161")
                .HasColumnOrder(165)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J161")
                .IsOptional();

            Property(p => p.PCT012J162)
                .HasColumnName("PCT012J162")
                .HasColumnOrder(166)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J162")
                .IsOptional();

            Property(p => p.PCT012J163)
                .HasColumnName("PCT012J163")
                .HasColumnOrder(167)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J163")
                .IsOptional();

            Property(p => p.PCT012J164)
                .HasColumnName("PCT012J164")
                .HasColumnOrder(168)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J164")
                .IsOptional();

            Property(p => p.PCT012J165)
                .HasColumnName("PCT012J165")
                .HasColumnOrder(169)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J165")
                .IsOptional();

            Property(p => p.PCT012J166)
                .HasColumnName("PCT012J166")
                .HasColumnOrder(170)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J166")
                .IsOptional();

            Property(p => p.PCT012J167)
                .HasColumnName("PCT012J167")
                .HasColumnOrder(171)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J167")
                .IsOptional();

            Property(p => p.PCT012J168)
                .HasColumnName("PCT012J168")
                .HasColumnOrder(172)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J168")
                .IsOptional();

            Property(p => p.PCT012J169)
                .HasColumnName("PCT012J169")
                .HasColumnOrder(173)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J169")
                .IsOptional();

            Property(p => p.PCT012J170)
                .HasColumnName("PCT012J170")
                .HasColumnOrder(174)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J170")
                .IsOptional();

            Property(p => p.PCT012J171)
                .HasColumnName("PCT012J171")
                .HasColumnOrder(175)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J171")
                .IsOptional();

            Property(p => p.PCT012J172)
                .HasColumnName("PCT012J172")
                .HasColumnOrder(176)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J172")
                .IsOptional();

            Property(p => p.PCT012J173)
                .HasColumnName("PCT012J173")
                .HasColumnOrder(177)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J173")
                .IsOptional();

            Property(p => p.PCT012J174)
                .HasColumnName("PCT012J174")
                .HasColumnOrder(178)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J174")
                .IsOptional();

            Property(p => p.PCT012J175)
                .HasColumnName("PCT012J175")
                .HasColumnOrder(179)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J175")
                .IsOptional();

            Property(p => p.PCT012J176)
                .HasColumnName("PCT012J176")
                .HasColumnOrder(180)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J176")
                .IsOptional();

            Property(p => p.PCT012J177)
                .HasColumnName("PCT012J177")
                .HasColumnOrder(181)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J177")
                .IsOptional();

            Property(p => p.PCT012J178)
                .HasColumnName("PCT012J178")
                .HasColumnOrder(182)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J178")
                .IsOptional();

            Property(p => p.PCT012J179)
                .HasColumnName("PCT012J179")
                .HasColumnOrder(183)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J179")
                .IsOptional();

            Property(p => p.PCT012J180)
                .HasColumnName("PCT012J180")
                .HasColumnOrder(184)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J180")
                .IsOptional();

            Property(p => p.PCT012J181)
                .HasColumnName("PCT012J181")
                .HasColumnOrder(185)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J181")
                .IsOptional();

            Property(p => p.PCT012J182)
                .HasColumnName("PCT012J182")
                .HasColumnOrder(186)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J182")
                .IsOptional();

            Property(p => p.PCT012J183)
                .HasColumnName("PCT012J183")
                .HasColumnOrder(187)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J183")
                .IsOptional();

            Property(p => p.PCT012J184)
                .HasColumnName("PCT012J184")
                .HasColumnOrder(188)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J184")
                .IsOptional();

            Property(p => p.PCT012J185)
                .HasColumnName("PCT012J185")
                .HasColumnOrder(189)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J185")
                .IsOptional();

            Property(p => p.PCT012J186)
                .HasColumnName("PCT012J186")
                .HasColumnOrder(190)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J186")
                .IsOptional();

            Property(p => p.PCT012J187)
                .HasColumnName("PCT012J187")
                .HasColumnOrder(191)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J187")
                .IsOptional();

            Property(p => p.PCT012J188)
                .HasColumnName("PCT012J188")
                .HasColumnOrder(192)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J188")
                .IsOptional();

            Property(p => p.PCT012J189)
                .HasColumnName("PCT012J189")
                .HasColumnOrder(193)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J189")
                .IsOptional();

            Property(p => p.PCT012J190)
                .HasColumnName("PCT012J190")
                .HasColumnOrder(194)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J190")
                .IsOptional();

            Property(p => p.PCT012J191)
                .HasColumnName("PCT012J191")
                .HasColumnOrder(195)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J191")
                .IsOptional();

            Property(p => p.PCT012J192)
                .HasColumnName("PCT012J192")
                .HasColumnOrder(196)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J192")
                .IsOptional();

            Property(p => p.PCT012J193)
                .HasColumnName("PCT012J193")
                .HasColumnOrder(197)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J193")
                .IsOptional();

            Property(p => p.PCT012J194)
                .HasColumnName("PCT012J194")
                .HasColumnOrder(198)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J194")
                .IsOptional();

            Property(p => p.PCT012J195)
                .HasColumnName("PCT012J195")
                .HasColumnOrder(199)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J195")
                .IsOptional();

            Property(p => p.PCT012J196)
                .HasColumnName("PCT012J196")
                .HasColumnOrder(200)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J196")
                .IsOptional();

            Property(p => p.PCT012J197)
                .HasColumnName("PCT012J197")
                .HasColumnOrder(201)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J197")
                .IsOptional();

            Property(p => p.PCT012J198)
                .HasColumnName("PCT012J198")
                .HasColumnOrder(202)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J198")
                .IsOptional();

            Property(p => p.PCT012J199)
                .HasColumnName("PCT012J199")
                .HasColumnOrder(203)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J199")
                .IsOptional();

            Property(p => p.PCT012J200)
                .HasColumnName("PCT012J200")
                .HasColumnOrder(204)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J200")
                .IsOptional();

            Property(p => p.PCT012J201)
                .HasColumnName("PCT012J201")
                .HasColumnOrder(205)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J201")
                .IsOptional();

            Property(p => p.PCT012J202)
                .HasColumnName("PCT012J202")
                .HasColumnOrder(206)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J202")
                .IsOptional();

            Property(p => p.PCT012J203)
                .HasColumnName("PCT012J203")
                .HasColumnOrder(207)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J203")
                .IsOptional();

            Property(p => p.PCT012J204)
                .HasColumnName("PCT012J204")
                .HasColumnOrder(208)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J204")
                .IsOptional();

            Property(p => p.PCT012J205)
                .HasColumnName("PCT012J205")
                .HasColumnOrder(209)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J205")
                .IsOptional();

            Property(p => p.PCT012J206)
                .HasColumnName("PCT012J206")
                .HasColumnOrder(210)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J206")
                .IsOptional();

            Property(p => p.PCT012J207)
                .HasColumnName("PCT012J207")
                .HasColumnOrder(211)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J207")
                .IsOptional();

            Property(p => p.PCT012J208)
                .HasColumnName("PCT012J208")
                .HasColumnOrder(212)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J208")
                .IsOptional();

            Property(p => p.PCT012J209)
                .HasColumnName("PCT012J209")
                .HasColumnOrder(213)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012J209")
                .IsOptional();
        }
    }
}
