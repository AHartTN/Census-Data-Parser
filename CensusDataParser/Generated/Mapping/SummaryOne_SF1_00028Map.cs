#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2016 12:25 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SummaryOne_SF1_00028Map.cs
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

    public class SummaryOne_SF1_00028Map : EntityTypeConfiguration<SummaryOne_SF1_00028>
    {
        public SummaryOne_SF1_00028Map()
        {
            ToTable("SF1_00028", "SummaryOne");

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

            Property(p => p.PCT012I001)
                .HasColumnName("PCT012I001")
                .HasColumnOrder(5)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I001")
                .IsOptional();

            Property(p => p.PCT012I002)
                .HasColumnName("PCT012I002")
                .HasColumnOrder(6)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I002")
                .IsOptional();

            Property(p => p.PCT012I003)
                .HasColumnName("PCT012I003")
                .HasColumnOrder(7)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I003")
                .IsOptional();

            Property(p => p.PCT012I004)
                .HasColumnName("PCT012I004")
                .HasColumnOrder(8)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I004")
                .IsOptional();

            Property(p => p.PCT012I005)
                .HasColumnName("PCT012I005")
                .HasColumnOrder(9)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I005")
                .IsOptional();

            Property(p => p.PCT012I006)
                .HasColumnName("PCT012I006")
                .HasColumnOrder(10)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I006")
                .IsOptional();

            Property(p => p.PCT012I007)
                .HasColumnName("PCT012I007")
                .HasColumnOrder(11)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I007")
                .IsOptional();

            Property(p => p.PCT012I008)
                .HasColumnName("PCT012I008")
                .HasColumnOrder(12)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I008")
                .IsOptional();

            Property(p => p.PCT012I009)
                .HasColumnName("PCT012I009")
                .HasColumnOrder(13)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I009")
                .IsOptional();

            Property(p => p.PCT012I010)
                .HasColumnName("PCT012I010")
                .HasColumnOrder(14)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I010")
                .IsOptional();

            Property(p => p.PCT012I011)
                .HasColumnName("PCT012I011")
                .HasColumnOrder(15)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I011")
                .IsOptional();

            Property(p => p.PCT012I012)
                .HasColumnName("PCT012I012")
                .HasColumnOrder(16)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I012")
                .IsOptional();

            Property(p => p.PCT012I013)
                .HasColumnName("PCT012I013")
                .HasColumnOrder(17)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I013")
                .IsOptional();

            Property(p => p.PCT012I014)
                .HasColumnName("PCT012I014")
                .HasColumnOrder(18)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I014")
                .IsOptional();

            Property(p => p.PCT012I015)
                .HasColumnName("PCT012I015")
                .HasColumnOrder(19)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I015")
                .IsOptional();

            Property(p => p.PCT012I016)
                .HasColumnName("PCT012I016")
                .HasColumnOrder(20)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I016")
                .IsOptional();

            Property(p => p.PCT012I017)
                .HasColumnName("PCT012I017")
                .HasColumnOrder(21)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I017")
                .IsOptional();

            Property(p => p.PCT012I018)
                .HasColumnName("PCT012I018")
                .HasColumnOrder(22)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I018")
                .IsOptional();

            Property(p => p.PCT012I019)
                .HasColumnName("PCT012I019")
                .HasColumnOrder(23)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I019")
                .IsOptional();

            Property(p => p.PCT012I020)
                .HasColumnName("PCT012I020")
                .HasColumnOrder(24)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I020")
                .IsOptional();

            Property(p => p.PCT012I021)
                .HasColumnName("PCT012I021")
                .HasColumnOrder(25)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I021")
                .IsOptional();

            Property(p => p.PCT012I022)
                .HasColumnName("PCT012I022")
                .HasColumnOrder(26)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I022")
                .IsOptional();

            Property(p => p.PCT012I023)
                .HasColumnName("PCT012I023")
                .HasColumnOrder(27)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I023")
                .IsOptional();

            Property(p => p.PCT012I024)
                .HasColumnName("PCT012I024")
                .HasColumnOrder(28)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I024")
                .IsOptional();

            Property(p => p.PCT012I025)
                .HasColumnName("PCT012I025")
                .HasColumnOrder(29)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I025")
                .IsOptional();

            Property(p => p.PCT012I026)
                .HasColumnName("PCT012I026")
                .HasColumnOrder(30)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I026")
                .IsOptional();

            Property(p => p.PCT012I027)
                .HasColumnName("PCT012I027")
                .HasColumnOrder(31)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I027")
                .IsOptional();

            Property(p => p.PCT012I028)
                .HasColumnName("PCT012I028")
                .HasColumnOrder(32)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I028")
                .IsOptional();

            Property(p => p.PCT012I029)
                .HasColumnName("PCT012I029")
                .HasColumnOrder(33)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I029")
                .IsOptional();

            Property(p => p.PCT012I030)
                .HasColumnName("PCT012I030")
                .HasColumnOrder(34)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I030")
                .IsOptional();

            Property(p => p.PCT012I031)
                .HasColumnName("PCT012I031")
                .HasColumnOrder(35)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I031")
                .IsOptional();

            Property(p => p.PCT012I032)
                .HasColumnName("PCT012I032")
                .HasColumnOrder(36)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I032")
                .IsOptional();

            Property(p => p.PCT012I033)
                .HasColumnName("PCT012I033")
                .HasColumnOrder(37)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I033")
                .IsOptional();

            Property(p => p.PCT012I034)
                .HasColumnName("PCT012I034")
                .HasColumnOrder(38)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I034")
                .IsOptional();

            Property(p => p.PCT012I035)
                .HasColumnName("PCT012I035")
                .HasColumnOrder(39)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I035")
                .IsOptional();

            Property(p => p.PCT012I036)
                .HasColumnName("PCT012I036")
                .HasColumnOrder(40)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I036")
                .IsOptional();

            Property(p => p.PCT012I037)
                .HasColumnName("PCT012I037")
                .HasColumnOrder(41)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I037")
                .IsOptional();

            Property(p => p.PCT012I038)
                .HasColumnName("PCT012I038")
                .HasColumnOrder(42)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I038")
                .IsOptional();

            Property(p => p.PCT012I039)
                .HasColumnName("PCT012I039")
                .HasColumnOrder(43)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I039")
                .IsOptional();

            Property(p => p.PCT012I040)
                .HasColumnName("PCT012I040")
                .HasColumnOrder(44)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I040")
                .IsOptional();

            Property(p => p.PCT012I041)
                .HasColumnName("PCT012I041")
                .HasColumnOrder(45)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I041")
                .IsOptional();

            Property(p => p.PCT012I042)
                .HasColumnName("PCT012I042")
                .HasColumnOrder(46)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I042")
                .IsOptional();

            Property(p => p.PCT012I043)
                .HasColumnName("PCT012I043")
                .HasColumnOrder(47)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I043")
                .IsOptional();

            Property(p => p.PCT012I044)
                .HasColumnName("PCT012I044")
                .HasColumnOrder(48)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I044")
                .IsOptional();

            Property(p => p.PCT012I045)
                .HasColumnName("PCT012I045")
                .HasColumnOrder(49)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I045")
                .IsOptional();

            Property(p => p.PCT012I046)
                .HasColumnName("PCT012I046")
                .HasColumnOrder(50)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I046")
                .IsOptional();

            Property(p => p.PCT012I047)
                .HasColumnName("PCT012I047")
                .HasColumnOrder(51)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I047")
                .IsOptional();

            Property(p => p.PCT012I048)
                .HasColumnName("PCT012I048")
                .HasColumnOrder(52)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I048")
                .IsOptional();

            Property(p => p.PCT012I049)
                .HasColumnName("PCT012I049")
                .HasColumnOrder(53)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I049")
                .IsOptional();

            Property(p => p.PCT012I050)
                .HasColumnName("PCT012I050")
                .HasColumnOrder(54)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I050")
                .IsOptional();

            Property(p => p.PCT012I051)
                .HasColumnName("PCT012I051")
                .HasColumnOrder(55)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I051")
                .IsOptional();

            Property(p => p.PCT012I052)
                .HasColumnName("PCT012I052")
                .HasColumnOrder(56)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I052")
                .IsOptional();

            Property(p => p.PCT012I053)
                .HasColumnName("PCT012I053")
                .HasColumnOrder(57)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I053")
                .IsOptional();

            Property(p => p.PCT012I054)
                .HasColumnName("PCT012I054")
                .HasColumnOrder(58)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I054")
                .IsOptional();

            Property(p => p.PCT012I055)
                .HasColumnName("PCT012I055")
                .HasColumnOrder(59)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I055")
                .IsOptional();

            Property(p => p.PCT012I056)
                .HasColumnName("PCT012I056")
                .HasColumnOrder(60)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I056")
                .IsOptional();

            Property(p => p.PCT012I057)
                .HasColumnName("PCT012I057")
                .HasColumnOrder(61)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I057")
                .IsOptional();

            Property(p => p.PCT012I058)
                .HasColumnName("PCT012I058")
                .HasColumnOrder(62)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I058")
                .IsOptional();

            Property(p => p.PCT012I059)
                .HasColumnName("PCT012I059")
                .HasColumnOrder(63)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I059")
                .IsOptional();

            Property(p => p.PCT012I060)
                .HasColumnName("PCT012I060")
                .HasColumnOrder(64)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I060")
                .IsOptional();

            Property(p => p.PCT012I061)
                .HasColumnName("PCT012I061")
                .HasColumnOrder(65)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I061")
                .IsOptional();

            Property(p => p.PCT012I062)
                .HasColumnName("PCT012I062")
                .HasColumnOrder(66)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I062")
                .IsOptional();

            Property(p => p.PCT012I063)
                .HasColumnName("PCT012I063")
                .HasColumnOrder(67)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I063")
                .IsOptional();

            Property(p => p.PCT012I064)
                .HasColumnName("PCT012I064")
                .HasColumnOrder(68)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I064")
                .IsOptional();

            Property(p => p.PCT012I065)
                .HasColumnName("PCT012I065")
                .HasColumnOrder(69)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I065")
                .IsOptional();

            Property(p => p.PCT012I066)
                .HasColumnName("PCT012I066")
                .HasColumnOrder(70)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I066")
                .IsOptional();

            Property(p => p.PCT012I067)
                .HasColumnName("PCT012I067")
                .HasColumnOrder(71)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I067")
                .IsOptional();

            Property(p => p.PCT012I068)
                .HasColumnName("PCT012I068")
                .HasColumnOrder(72)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I068")
                .IsOptional();

            Property(p => p.PCT012I069)
                .HasColumnName("PCT012I069")
                .HasColumnOrder(73)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I069")
                .IsOptional();

            Property(p => p.PCT012I070)
                .HasColumnName("PCT012I070")
                .HasColumnOrder(74)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I070")
                .IsOptional();

            Property(p => p.PCT012I071)
                .HasColumnName("PCT012I071")
                .HasColumnOrder(75)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I071")
                .IsOptional();

            Property(p => p.PCT012I072)
                .HasColumnName("PCT012I072")
                .HasColumnOrder(76)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I072")
                .IsOptional();

            Property(p => p.PCT012I073)
                .HasColumnName("PCT012I073")
                .HasColumnOrder(77)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I073")
                .IsOptional();

            Property(p => p.PCT012I074)
                .HasColumnName("PCT012I074")
                .HasColumnOrder(78)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I074")
                .IsOptional();

            Property(p => p.PCT012I075)
                .HasColumnName("PCT012I075")
                .HasColumnOrder(79)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I075")
                .IsOptional();

            Property(p => p.PCT012I076)
                .HasColumnName("PCT012I076")
                .HasColumnOrder(80)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I076")
                .IsOptional();

            Property(p => p.PCT012I077)
                .HasColumnName("PCT012I077")
                .HasColumnOrder(81)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I077")
                .IsOptional();

            Property(p => p.PCT012I078)
                .HasColumnName("PCT012I078")
                .HasColumnOrder(82)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I078")
                .IsOptional();

            Property(p => p.PCT012I079)
                .HasColumnName("PCT012I079")
                .HasColumnOrder(83)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I079")
                .IsOptional();

            Property(p => p.PCT012I080)
                .HasColumnName("PCT012I080")
                .HasColumnOrder(84)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I080")
                .IsOptional();

            Property(p => p.PCT012I081)
                .HasColumnName("PCT012I081")
                .HasColumnOrder(85)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I081")
                .IsOptional();

            Property(p => p.PCT012I082)
                .HasColumnName("PCT012I082")
                .HasColumnOrder(86)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I082")
                .IsOptional();

            Property(p => p.PCT012I083)
                .HasColumnName("PCT012I083")
                .HasColumnOrder(87)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I083")
                .IsOptional();

            Property(p => p.PCT012I084)
                .HasColumnName("PCT012I084")
                .HasColumnOrder(88)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I084")
                .IsOptional();

            Property(p => p.PCT012I085)
                .HasColumnName("PCT012I085")
                .HasColumnOrder(89)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I085")
                .IsOptional();

            Property(p => p.PCT012I086)
                .HasColumnName("PCT012I086")
                .HasColumnOrder(90)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I086")
                .IsOptional();

            Property(p => p.PCT012I087)
                .HasColumnName("PCT012I087")
                .HasColumnOrder(91)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I087")
                .IsOptional();

            Property(p => p.PCT012I088)
                .HasColumnName("PCT012I088")
                .HasColumnOrder(92)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I088")
                .IsOptional();

            Property(p => p.PCT012I089)
                .HasColumnName("PCT012I089")
                .HasColumnOrder(93)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I089")
                .IsOptional();

            Property(p => p.PCT012I090)
                .HasColumnName("PCT012I090")
                .HasColumnOrder(94)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I090")
                .IsOptional();

            Property(p => p.PCT012I091)
                .HasColumnName("PCT012I091")
                .HasColumnOrder(95)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I091")
                .IsOptional();

            Property(p => p.PCT012I092)
                .HasColumnName("PCT012I092")
                .HasColumnOrder(96)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I092")
                .IsOptional();

            Property(p => p.PCT012I093)
                .HasColumnName("PCT012I093")
                .HasColumnOrder(97)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I093")
                .IsOptional();

            Property(p => p.PCT012I094)
                .HasColumnName("PCT012I094")
                .HasColumnOrder(98)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I094")
                .IsOptional();

            Property(p => p.PCT012I095)
                .HasColumnName("PCT012I095")
                .HasColumnOrder(99)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I095")
                .IsOptional();

            Property(p => p.PCT012I096)
                .HasColumnName("PCT012I096")
                .HasColumnOrder(100)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I096")
                .IsOptional();

            Property(p => p.PCT012I097)
                .HasColumnName("PCT012I097")
                .HasColumnOrder(101)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I097")
                .IsOptional();

            Property(p => p.PCT012I098)
                .HasColumnName("PCT012I098")
                .HasColumnOrder(102)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I098")
                .IsOptional();

            Property(p => p.PCT012I099)
                .HasColumnName("PCT012I099")
                .HasColumnOrder(103)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I099")
                .IsOptional();

            Property(p => p.PCT012I100)
                .HasColumnName("PCT012I100")
                .HasColumnOrder(104)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I100")
                .IsOptional();

            Property(p => p.PCT012I101)
                .HasColumnName("PCT012I101")
                .HasColumnOrder(105)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I101")
                .IsOptional();

            Property(p => p.PCT012I102)
                .HasColumnName("PCT012I102")
                .HasColumnOrder(106)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I102")
                .IsOptional();

            Property(p => p.PCT012I103)
                .HasColumnName("PCT012I103")
                .HasColumnOrder(107)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I103")
                .IsOptional();

            Property(p => p.PCT012I104)
                .HasColumnName("PCT012I104")
                .HasColumnOrder(108)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I104")
                .IsOptional();

            Property(p => p.PCT012I105)
                .HasColumnName("PCT012I105")
                .HasColumnOrder(109)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I105")
                .IsOptional();

            Property(p => p.PCT012I106)
                .HasColumnName("PCT012I106")
                .HasColumnOrder(110)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I106")
                .IsOptional();

            Property(p => p.PCT012I107)
                .HasColumnName("PCT012I107")
                .HasColumnOrder(111)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I107")
                .IsOptional();

            Property(p => p.PCT012I108)
                .HasColumnName("PCT012I108")
                .HasColumnOrder(112)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I108")
                .IsOptional();

            Property(p => p.PCT012I109)
                .HasColumnName("PCT012I109")
                .HasColumnOrder(113)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I109")
                .IsOptional();

            Property(p => p.PCT012I110)
                .HasColumnName("PCT012I110")
                .HasColumnOrder(114)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I110")
                .IsOptional();

            Property(p => p.PCT012I111)
                .HasColumnName("PCT012I111")
                .HasColumnOrder(115)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I111")
                .IsOptional();

            Property(p => p.PCT012I112)
                .HasColumnName("PCT012I112")
                .HasColumnOrder(116)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I112")
                .IsOptional();

            Property(p => p.PCT012I113)
                .HasColumnName("PCT012I113")
                .HasColumnOrder(117)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I113")
                .IsOptional();

            Property(p => p.PCT012I114)
                .HasColumnName("PCT012I114")
                .HasColumnOrder(118)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I114")
                .IsOptional();

            Property(p => p.PCT012I115)
                .HasColumnName("PCT012I115")
                .HasColumnOrder(119)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I115")
                .IsOptional();

            Property(p => p.PCT012I116)
                .HasColumnName("PCT012I116")
                .HasColumnOrder(120)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I116")
                .IsOptional();

            Property(p => p.PCT012I117)
                .HasColumnName("PCT012I117")
                .HasColumnOrder(121)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I117")
                .IsOptional();

            Property(p => p.PCT012I118)
                .HasColumnName("PCT012I118")
                .HasColumnOrder(122)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I118")
                .IsOptional();

            Property(p => p.PCT012I119)
                .HasColumnName("PCT012I119")
                .HasColumnOrder(123)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I119")
                .IsOptional();

            Property(p => p.PCT012I120)
                .HasColumnName("PCT012I120")
                .HasColumnOrder(124)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I120")
                .IsOptional();

            Property(p => p.PCT012I121)
                .HasColumnName("PCT012I121")
                .HasColumnOrder(125)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I121")
                .IsOptional();

            Property(p => p.PCT012I122)
                .HasColumnName("PCT012I122")
                .HasColumnOrder(126)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I122")
                .IsOptional();

            Property(p => p.PCT012I123)
                .HasColumnName("PCT012I123")
                .HasColumnOrder(127)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I123")
                .IsOptional();

            Property(p => p.PCT012I124)
                .HasColumnName("PCT012I124")
                .HasColumnOrder(128)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I124")
                .IsOptional();

            Property(p => p.PCT012I125)
                .HasColumnName("PCT012I125")
                .HasColumnOrder(129)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I125")
                .IsOptional();

            Property(p => p.PCT012I126)
                .HasColumnName("PCT012I126")
                .HasColumnOrder(130)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I126")
                .IsOptional();

            Property(p => p.PCT012I127)
                .HasColumnName("PCT012I127")
                .HasColumnOrder(131)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I127")
                .IsOptional();

            Property(p => p.PCT012I128)
                .HasColumnName("PCT012I128")
                .HasColumnOrder(132)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I128")
                .IsOptional();

            Property(p => p.PCT012I129)
                .HasColumnName("PCT012I129")
                .HasColumnOrder(133)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I129")
                .IsOptional();

            Property(p => p.PCT012I130)
                .HasColumnName("PCT012I130")
                .HasColumnOrder(134)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I130")
                .IsOptional();

            Property(p => p.PCT012I131)
                .HasColumnName("PCT012I131")
                .HasColumnOrder(135)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I131")
                .IsOptional();

            Property(p => p.PCT012I132)
                .HasColumnName("PCT012I132")
                .HasColumnOrder(136)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I132")
                .IsOptional();

            Property(p => p.PCT012I133)
                .HasColumnName("PCT012I133")
                .HasColumnOrder(137)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I133")
                .IsOptional();

            Property(p => p.PCT012I134)
                .HasColumnName("PCT012I134")
                .HasColumnOrder(138)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I134")
                .IsOptional();

            Property(p => p.PCT012I135)
                .HasColumnName("PCT012I135")
                .HasColumnOrder(139)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I135")
                .IsOptional();

            Property(p => p.PCT012I136)
                .HasColumnName("PCT012I136")
                .HasColumnOrder(140)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I136")
                .IsOptional();

            Property(p => p.PCT012I137)
                .HasColumnName("PCT012I137")
                .HasColumnOrder(141)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I137")
                .IsOptional();

            Property(p => p.PCT012I138)
                .HasColumnName("PCT012I138")
                .HasColumnOrder(142)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I138")
                .IsOptional();

            Property(p => p.PCT012I139)
                .HasColumnName("PCT012I139")
                .HasColumnOrder(143)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I139")
                .IsOptional();

            Property(p => p.PCT012I140)
                .HasColumnName("PCT012I140")
                .HasColumnOrder(144)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I140")
                .IsOptional();

            Property(p => p.PCT012I141)
                .HasColumnName("PCT012I141")
                .HasColumnOrder(145)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I141")
                .IsOptional();

            Property(p => p.PCT012I142)
                .HasColumnName("PCT012I142")
                .HasColumnOrder(146)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I142")
                .IsOptional();

            Property(p => p.PCT012I143)
                .HasColumnName("PCT012I143")
                .HasColumnOrder(147)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I143")
                .IsOptional();

            Property(p => p.PCT012I144)
                .HasColumnName("PCT012I144")
                .HasColumnOrder(148)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I144")
                .IsOptional();

            Property(p => p.PCT012I145)
                .HasColumnName("PCT012I145")
                .HasColumnOrder(149)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I145")
                .IsOptional();

            Property(p => p.PCT012I146)
                .HasColumnName("PCT012I146")
                .HasColumnOrder(150)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I146")
                .IsOptional();

            Property(p => p.PCT012I147)
                .HasColumnName("PCT012I147")
                .HasColumnOrder(151)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I147")
                .IsOptional();

            Property(p => p.PCT012I148)
                .HasColumnName("PCT012I148")
                .HasColumnOrder(152)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I148")
                .IsOptional();

            Property(p => p.PCT012I149)
                .HasColumnName("PCT012I149")
                .HasColumnOrder(153)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I149")
                .IsOptional();

            Property(p => p.PCT012I150)
                .HasColumnName("PCT012I150")
                .HasColumnOrder(154)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I150")
                .IsOptional();

            Property(p => p.PCT012I151)
                .HasColumnName("PCT012I151")
                .HasColumnOrder(155)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I151")
                .IsOptional();

            Property(p => p.PCT012I152)
                .HasColumnName("PCT012I152")
                .HasColumnOrder(156)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I152")
                .IsOptional();

            Property(p => p.PCT012I153)
                .HasColumnName("PCT012I153")
                .HasColumnOrder(157)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I153")
                .IsOptional();

            Property(p => p.PCT012I154)
                .HasColumnName("PCT012I154")
                .HasColumnOrder(158)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I154")
                .IsOptional();

            Property(p => p.PCT012I155)
                .HasColumnName("PCT012I155")
                .HasColumnOrder(159)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I155")
                .IsOptional();

            Property(p => p.PCT012I156)
                .HasColumnName("PCT012I156")
                .HasColumnOrder(160)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I156")
                .IsOptional();

            Property(p => p.PCT012I157)
                .HasColumnName("PCT012I157")
                .HasColumnOrder(161)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I157")
                .IsOptional();

            Property(p => p.PCT012I158)
                .HasColumnName("PCT012I158")
                .HasColumnOrder(162)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I158")
                .IsOptional();

            Property(p => p.PCT012I159)
                .HasColumnName("PCT012I159")
                .HasColumnOrder(163)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I159")
                .IsOptional();

            Property(p => p.PCT012I160)
                .HasColumnName("PCT012I160")
                .HasColumnOrder(164)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I160")
                .IsOptional();

            Property(p => p.PCT012I161)
                .HasColumnName("PCT012I161")
                .HasColumnOrder(165)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I161")
                .IsOptional();

            Property(p => p.PCT012I162)
                .HasColumnName("PCT012I162")
                .HasColumnOrder(166)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I162")
                .IsOptional();

            Property(p => p.PCT012I163)
                .HasColumnName("PCT012I163")
                .HasColumnOrder(167)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I163")
                .IsOptional();

            Property(p => p.PCT012I164)
                .HasColumnName("PCT012I164")
                .HasColumnOrder(168)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I164")
                .IsOptional();

            Property(p => p.PCT012I165)
                .HasColumnName("PCT012I165")
                .HasColumnOrder(169)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I165")
                .IsOptional();

            Property(p => p.PCT012I166)
                .HasColumnName("PCT012I166")
                .HasColumnOrder(170)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I166")
                .IsOptional();

            Property(p => p.PCT012I167)
                .HasColumnName("PCT012I167")
                .HasColumnOrder(171)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I167")
                .IsOptional();

            Property(p => p.PCT012I168)
                .HasColumnName("PCT012I168")
                .HasColumnOrder(172)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I168")
                .IsOptional();

            Property(p => p.PCT012I169)
                .HasColumnName("PCT012I169")
                .HasColumnOrder(173)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I169")
                .IsOptional();

            Property(p => p.PCT012I170)
                .HasColumnName("PCT012I170")
                .HasColumnOrder(174)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I170")
                .IsOptional();

            Property(p => p.PCT012I171)
                .HasColumnName("PCT012I171")
                .HasColumnOrder(175)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I171")
                .IsOptional();

            Property(p => p.PCT012I172)
                .HasColumnName("PCT012I172")
                .HasColumnOrder(176)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I172")
                .IsOptional();

            Property(p => p.PCT012I173)
                .HasColumnName("PCT012I173")
                .HasColumnOrder(177)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I173")
                .IsOptional();

            Property(p => p.PCT012I174)
                .HasColumnName("PCT012I174")
                .HasColumnOrder(178)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I174")
                .IsOptional();

            Property(p => p.PCT012I175)
                .HasColumnName("PCT012I175")
                .HasColumnOrder(179)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I175")
                .IsOptional();

            Property(p => p.PCT012I176)
                .HasColumnName("PCT012I176")
                .HasColumnOrder(180)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I176")
                .IsOptional();

            Property(p => p.PCT012I177)
                .HasColumnName("PCT012I177")
                .HasColumnOrder(181)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I177")
                .IsOptional();

            Property(p => p.PCT012I178)
                .HasColumnName("PCT012I178")
                .HasColumnOrder(182)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I178")
                .IsOptional();

            Property(p => p.PCT012I179)
                .HasColumnName("PCT012I179")
                .HasColumnOrder(183)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I179")
                .IsOptional();

            Property(p => p.PCT012I180)
                .HasColumnName("PCT012I180")
                .HasColumnOrder(184)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I180")
                .IsOptional();

            Property(p => p.PCT012I181)
                .HasColumnName("PCT012I181")
                .HasColumnOrder(185)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I181")
                .IsOptional();

            Property(p => p.PCT012I182)
                .HasColumnName("PCT012I182")
                .HasColumnOrder(186)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I182")
                .IsOptional();

            Property(p => p.PCT012I183)
                .HasColumnName("PCT012I183")
                .HasColumnOrder(187)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I183")
                .IsOptional();

            Property(p => p.PCT012I184)
                .HasColumnName("PCT012I184")
                .HasColumnOrder(188)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I184")
                .IsOptional();

            Property(p => p.PCT012I185)
                .HasColumnName("PCT012I185")
                .HasColumnOrder(189)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I185")
                .IsOptional();

            Property(p => p.PCT012I186)
                .HasColumnName("PCT012I186")
                .HasColumnOrder(190)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I186")
                .IsOptional();

            Property(p => p.PCT012I187)
                .HasColumnName("PCT012I187")
                .HasColumnOrder(191)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I187")
                .IsOptional();

            Property(p => p.PCT012I188)
                .HasColumnName("PCT012I188")
                .HasColumnOrder(192)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I188")
                .IsOptional();

            Property(p => p.PCT012I189)
                .HasColumnName("PCT012I189")
                .HasColumnOrder(193)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I189")
                .IsOptional();

            Property(p => p.PCT012I190)
                .HasColumnName("PCT012I190")
                .HasColumnOrder(194)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I190")
                .IsOptional();

            Property(p => p.PCT012I191)
                .HasColumnName("PCT012I191")
                .HasColumnOrder(195)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I191")
                .IsOptional();

            Property(p => p.PCT012I192)
                .HasColumnName("PCT012I192")
                .HasColumnOrder(196)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I192")
                .IsOptional();

            Property(p => p.PCT012I193)
                .HasColumnName("PCT012I193")
                .HasColumnOrder(197)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I193")
                .IsOptional();

            Property(p => p.PCT012I194)
                .HasColumnName("PCT012I194")
                .HasColumnOrder(198)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I194")
                .IsOptional();

            Property(p => p.PCT012I195)
                .HasColumnName("PCT012I195")
                .HasColumnOrder(199)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I195")
                .IsOptional();

            Property(p => p.PCT012I196)
                .HasColumnName("PCT012I196")
                .HasColumnOrder(200)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I196")
                .IsOptional();

            Property(p => p.PCT012I197)
                .HasColumnName("PCT012I197")
                .HasColumnOrder(201)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I197")
                .IsOptional();

            Property(p => p.PCT012I198)
                .HasColumnName("PCT012I198")
                .HasColumnOrder(202)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I198")
                .IsOptional();

            Property(p => p.PCT012I199)
                .HasColumnName("PCT012I199")
                .HasColumnOrder(203)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I199")
                .IsOptional();

            Property(p => p.PCT012I200)
                .HasColumnName("PCT012I200")
                .HasColumnOrder(204)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I200")
                .IsOptional();

            Property(p => p.PCT012I201)
                .HasColumnName("PCT012I201")
                .HasColumnOrder(205)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I201")
                .IsOptional();

            Property(p => p.PCT012I202)
                .HasColumnName("PCT012I202")
                .HasColumnOrder(206)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I202")
                .IsOptional();

            Property(p => p.PCT012I203)
                .HasColumnName("PCT012I203")
                .HasColumnOrder(207)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I203")
                .IsOptional();

            Property(p => p.PCT012I204)
                .HasColumnName("PCT012I204")
                .HasColumnOrder(208)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I204")
                .IsOptional();

            Property(p => p.PCT012I205)
                .HasColumnName("PCT012I205")
                .HasColumnOrder(209)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I205")
                .IsOptional();

            Property(p => p.PCT012I206)
                .HasColumnName("PCT012I206")
                .HasColumnOrder(210)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I206")
                .IsOptional();

            Property(p => p.PCT012I207)
                .HasColumnName("PCT012I207")
                .HasColumnOrder(211)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I207")
                .IsOptional();

            Property(p => p.PCT012I208)
                .HasColumnName("PCT012I208")
                .HasColumnOrder(212)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I208")
                .IsOptional();

            Property(p => p.PCT012I209)
                .HasColumnName("PCT012I209")
                .HasColumnOrder(213)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012I209")
                .IsOptional();
        }
    }
}
