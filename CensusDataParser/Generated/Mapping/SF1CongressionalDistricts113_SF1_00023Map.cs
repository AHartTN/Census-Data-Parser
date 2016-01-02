#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2016 12:08 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1CongressionalDistricts113_SF1_00023Map.cs
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

    public class SF1CongressionalDistricts113_SF1_00023Map : EntityTypeConfiguration<SF1CongressionalDistricts113_SF1_00023>
    {
        public SF1CongressionalDistricts113_SF1_00023Map()
        {
            ToTable("SF1_00023", "SF1CongressionalDistricts113");

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

            Property(p => p.PCT012D001)
                .HasColumnName("PCT012D001")
                .HasColumnOrder(5)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D001")
                .IsOptional();

            Property(p => p.PCT012D002)
                .HasColumnName("PCT012D002")
                .HasColumnOrder(6)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D002")
                .IsOptional();

            Property(p => p.PCT012D003)
                .HasColumnName("PCT012D003")
                .HasColumnOrder(7)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D003")
                .IsOptional();

            Property(p => p.PCT012D004)
                .HasColumnName("PCT012D004")
                .HasColumnOrder(8)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D004")
                .IsOptional();

            Property(p => p.PCT012D005)
                .HasColumnName("PCT012D005")
                .HasColumnOrder(9)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D005")
                .IsOptional();

            Property(p => p.PCT012D006)
                .HasColumnName("PCT012D006")
                .HasColumnOrder(10)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D006")
                .IsOptional();

            Property(p => p.PCT012D007)
                .HasColumnName("PCT012D007")
                .HasColumnOrder(11)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D007")
                .IsOptional();

            Property(p => p.PCT012D008)
                .HasColumnName("PCT012D008")
                .HasColumnOrder(12)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D008")
                .IsOptional();

            Property(p => p.PCT012D009)
                .HasColumnName("PCT012D009")
                .HasColumnOrder(13)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D009")
                .IsOptional();

            Property(p => p.PCT012D010)
                .HasColumnName("PCT012D010")
                .HasColumnOrder(14)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D010")
                .IsOptional();

            Property(p => p.PCT012D011)
                .HasColumnName("PCT012D011")
                .HasColumnOrder(15)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D011")
                .IsOptional();

            Property(p => p.PCT012D012)
                .HasColumnName("PCT012D012")
                .HasColumnOrder(16)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D012")
                .IsOptional();

            Property(p => p.PCT012D013)
                .HasColumnName("PCT012D013")
                .HasColumnOrder(17)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D013")
                .IsOptional();

            Property(p => p.PCT012D014)
                .HasColumnName("PCT012D014")
                .HasColumnOrder(18)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D014")
                .IsOptional();

            Property(p => p.PCT012D015)
                .HasColumnName("PCT012D015")
                .HasColumnOrder(19)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D015")
                .IsOptional();

            Property(p => p.PCT012D016)
                .HasColumnName("PCT012D016")
                .HasColumnOrder(20)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D016")
                .IsOptional();

            Property(p => p.PCT012D017)
                .HasColumnName("PCT012D017")
                .HasColumnOrder(21)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D017")
                .IsOptional();

            Property(p => p.PCT012D018)
                .HasColumnName("PCT012D018")
                .HasColumnOrder(22)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D018")
                .IsOptional();

            Property(p => p.PCT012D019)
                .HasColumnName("PCT012D019")
                .HasColumnOrder(23)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D019")
                .IsOptional();

            Property(p => p.PCT012D020)
                .HasColumnName("PCT012D020")
                .HasColumnOrder(24)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D020")
                .IsOptional();

            Property(p => p.PCT012D021)
                .HasColumnName("PCT012D021")
                .HasColumnOrder(25)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D021")
                .IsOptional();

            Property(p => p.PCT012D022)
                .HasColumnName("PCT012D022")
                .HasColumnOrder(26)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D022")
                .IsOptional();

            Property(p => p.PCT012D023)
                .HasColumnName("PCT012D023")
                .HasColumnOrder(27)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D023")
                .IsOptional();

            Property(p => p.PCT012D024)
                .HasColumnName("PCT012D024")
                .HasColumnOrder(28)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D024")
                .IsOptional();

            Property(p => p.PCT012D025)
                .HasColumnName("PCT012D025")
                .HasColumnOrder(29)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D025")
                .IsOptional();

            Property(p => p.PCT012D026)
                .HasColumnName("PCT012D026")
                .HasColumnOrder(30)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D026")
                .IsOptional();

            Property(p => p.PCT012D027)
                .HasColumnName("PCT012D027")
                .HasColumnOrder(31)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D027")
                .IsOptional();

            Property(p => p.PCT012D028)
                .HasColumnName("PCT012D028")
                .HasColumnOrder(32)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D028")
                .IsOptional();

            Property(p => p.PCT012D029)
                .HasColumnName("PCT012D029")
                .HasColumnOrder(33)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D029")
                .IsOptional();

            Property(p => p.PCT012D030)
                .HasColumnName("PCT012D030")
                .HasColumnOrder(34)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D030")
                .IsOptional();

            Property(p => p.PCT012D031)
                .HasColumnName("PCT012D031")
                .HasColumnOrder(35)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D031")
                .IsOptional();

            Property(p => p.PCT012D032)
                .HasColumnName("PCT012D032")
                .HasColumnOrder(36)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D032")
                .IsOptional();

            Property(p => p.PCT012D033)
                .HasColumnName("PCT012D033")
                .HasColumnOrder(37)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D033")
                .IsOptional();

            Property(p => p.PCT012D034)
                .HasColumnName("PCT012D034")
                .HasColumnOrder(38)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D034")
                .IsOptional();

            Property(p => p.PCT012D035)
                .HasColumnName("PCT012D035")
                .HasColumnOrder(39)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D035")
                .IsOptional();

            Property(p => p.PCT012D036)
                .HasColumnName("PCT012D036")
                .HasColumnOrder(40)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D036")
                .IsOptional();

            Property(p => p.PCT012D037)
                .HasColumnName("PCT012D037")
                .HasColumnOrder(41)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D037")
                .IsOptional();

            Property(p => p.PCT012D038)
                .HasColumnName("PCT012D038")
                .HasColumnOrder(42)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D038")
                .IsOptional();

            Property(p => p.PCT012D039)
                .HasColumnName("PCT012D039")
                .HasColumnOrder(43)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D039")
                .IsOptional();

            Property(p => p.PCT012D040)
                .HasColumnName("PCT012D040")
                .HasColumnOrder(44)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D040")
                .IsOptional();

            Property(p => p.PCT012D041)
                .HasColumnName("PCT012D041")
                .HasColumnOrder(45)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D041")
                .IsOptional();

            Property(p => p.PCT012D042)
                .HasColumnName("PCT012D042")
                .HasColumnOrder(46)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D042")
                .IsOptional();

            Property(p => p.PCT012D043)
                .HasColumnName("PCT012D043")
                .HasColumnOrder(47)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D043")
                .IsOptional();

            Property(p => p.PCT012D044)
                .HasColumnName("PCT012D044")
                .HasColumnOrder(48)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D044")
                .IsOptional();

            Property(p => p.PCT012D045)
                .HasColumnName("PCT012D045")
                .HasColumnOrder(49)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D045")
                .IsOptional();

            Property(p => p.PCT012D046)
                .HasColumnName("PCT012D046")
                .HasColumnOrder(50)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D046")
                .IsOptional();

            Property(p => p.PCT012D047)
                .HasColumnName("PCT012D047")
                .HasColumnOrder(51)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D047")
                .IsOptional();

            Property(p => p.PCT012D048)
                .HasColumnName("PCT012D048")
                .HasColumnOrder(52)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D048")
                .IsOptional();

            Property(p => p.PCT012D049)
                .HasColumnName("PCT012D049")
                .HasColumnOrder(53)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D049")
                .IsOptional();

            Property(p => p.PCT012D050)
                .HasColumnName("PCT012D050")
                .HasColumnOrder(54)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D050")
                .IsOptional();

            Property(p => p.PCT012D051)
                .HasColumnName("PCT012D051")
                .HasColumnOrder(55)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D051")
                .IsOptional();

            Property(p => p.PCT012D052)
                .HasColumnName("PCT012D052")
                .HasColumnOrder(56)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D052")
                .IsOptional();

            Property(p => p.PCT012D053)
                .HasColumnName("PCT012D053")
                .HasColumnOrder(57)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D053")
                .IsOptional();

            Property(p => p.PCT012D054)
                .HasColumnName("PCT012D054")
                .HasColumnOrder(58)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D054")
                .IsOptional();

            Property(p => p.PCT012D055)
                .HasColumnName("PCT012D055")
                .HasColumnOrder(59)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D055")
                .IsOptional();

            Property(p => p.PCT012D056)
                .HasColumnName("PCT012D056")
                .HasColumnOrder(60)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D056")
                .IsOptional();

            Property(p => p.PCT012D057)
                .HasColumnName("PCT012D057")
                .HasColumnOrder(61)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D057")
                .IsOptional();

            Property(p => p.PCT012D058)
                .HasColumnName("PCT012D058")
                .HasColumnOrder(62)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D058")
                .IsOptional();

            Property(p => p.PCT012D059)
                .HasColumnName("PCT012D059")
                .HasColumnOrder(63)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D059")
                .IsOptional();

            Property(p => p.PCT012D060)
                .HasColumnName("PCT012D060")
                .HasColumnOrder(64)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D060")
                .IsOptional();

            Property(p => p.PCT012D061)
                .HasColumnName("PCT012D061")
                .HasColumnOrder(65)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D061")
                .IsOptional();

            Property(p => p.PCT012D062)
                .HasColumnName("PCT012D062")
                .HasColumnOrder(66)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D062")
                .IsOptional();

            Property(p => p.PCT012D063)
                .HasColumnName("PCT012D063")
                .HasColumnOrder(67)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D063")
                .IsOptional();

            Property(p => p.PCT012D064)
                .HasColumnName("PCT012D064")
                .HasColumnOrder(68)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D064")
                .IsOptional();

            Property(p => p.PCT012D065)
                .HasColumnName("PCT012D065")
                .HasColumnOrder(69)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D065")
                .IsOptional();

            Property(p => p.PCT012D066)
                .HasColumnName("PCT012D066")
                .HasColumnOrder(70)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D066")
                .IsOptional();

            Property(p => p.PCT012D067)
                .HasColumnName("PCT012D067")
                .HasColumnOrder(71)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D067")
                .IsOptional();

            Property(p => p.PCT012D068)
                .HasColumnName("PCT012D068")
                .HasColumnOrder(72)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D068")
                .IsOptional();

            Property(p => p.PCT012D069)
                .HasColumnName("PCT012D069")
                .HasColumnOrder(73)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D069")
                .IsOptional();

            Property(p => p.PCT012D070)
                .HasColumnName("PCT012D070")
                .HasColumnOrder(74)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D070")
                .IsOptional();

            Property(p => p.PCT012D071)
                .HasColumnName("PCT012D071")
                .HasColumnOrder(75)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D071")
                .IsOptional();

            Property(p => p.PCT012D072)
                .HasColumnName("PCT012D072")
                .HasColumnOrder(76)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D072")
                .IsOptional();

            Property(p => p.PCT012D073)
                .HasColumnName("PCT012D073")
                .HasColumnOrder(77)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D073")
                .IsOptional();

            Property(p => p.PCT012D074)
                .HasColumnName("PCT012D074")
                .HasColumnOrder(78)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D074")
                .IsOptional();

            Property(p => p.PCT012D075)
                .HasColumnName("PCT012D075")
                .HasColumnOrder(79)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D075")
                .IsOptional();

            Property(p => p.PCT012D076)
                .HasColumnName("PCT012D076")
                .HasColumnOrder(80)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D076")
                .IsOptional();

            Property(p => p.PCT012D077)
                .HasColumnName("PCT012D077")
                .HasColumnOrder(81)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D077")
                .IsOptional();

            Property(p => p.PCT012D078)
                .HasColumnName("PCT012D078")
                .HasColumnOrder(82)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D078")
                .IsOptional();

            Property(p => p.PCT012D079)
                .HasColumnName("PCT012D079")
                .HasColumnOrder(83)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D079")
                .IsOptional();

            Property(p => p.PCT012D080)
                .HasColumnName("PCT012D080")
                .HasColumnOrder(84)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D080")
                .IsOptional();

            Property(p => p.PCT012D081)
                .HasColumnName("PCT012D081")
                .HasColumnOrder(85)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D081")
                .IsOptional();

            Property(p => p.PCT012D082)
                .HasColumnName("PCT012D082")
                .HasColumnOrder(86)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D082")
                .IsOptional();

            Property(p => p.PCT012D083)
                .HasColumnName("PCT012D083")
                .HasColumnOrder(87)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D083")
                .IsOptional();

            Property(p => p.PCT012D084)
                .HasColumnName("PCT012D084")
                .HasColumnOrder(88)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D084")
                .IsOptional();

            Property(p => p.PCT012D085)
                .HasColumnName("PCT012D085")
                .HasColumnOrder(89)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D085")
                .IsOptional();

            Property(p => p.PCT012D086)
                .HasColumnName("PCT012D086")
                .HasColumnOrder(90)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D086")
                .IsOptional();

            Property(p => p.PCT012D087)
                .HasColumnName("PCT012D087")
                .HasColumnOrder(91)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D087")
                .IsOptional();

            Property(p => p.PCT012D088)
                .HasColumnName("PCT012D088")
                .HasColumnOrder(92)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D088")
                .IsOptional();

            Property(p => p.PCT012D089)
                .HasColumnName("PCT012D089")
                .HasColumnOrder(93)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D089")
                .IsOptional();

            Property(p => p.PCT012D090)
                .HasColumnName("PCT012D090")
                .HasColumnOrder(94)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D090")
                .IsOptional();

            Property(p => p.PCT012D091)
                .HasColumnName("PCT012D091")
                .HasColumnOrder(95)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D091")
                .IsOptional();

            Property(p => p.PCT012D092)
                .HasColumnName("PCT012D092")
                .HasColumnOrder(96)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D092")
                .IsOptional();

            Property(p => p.PCT012D093)
                .HasColumnName("PCT012D093")
                .HasColumnOrder(97)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D093")
                .IsOptional();

            Property(p => p.PCT012D094)
                .HasColumnName("PCT012D094")
                .HasColumnOrder(98)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D094")
                .IsOptional();

            Property(p => p.PCT012D095)
                .HasColumnName("PCT012D095")
                .HasColumnOrder(99)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D095")
                .IsOptional();

            Property(p => p.PCT012D096)
                .HasColumnName("PCT012D096")
                .HasColumnOrder(100)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D096")
                .IsOptional();

            Property(p => p.PCT012D097)
                .HasColumnName("PCT012D097")
                .HasColumnOrder(101)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D097")
                .IsOptional();

            Property(p => p.PCT012D098)
                .HasColumnName("PCT012D098")
                .HasColumnOrder(102)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D098")
                .IsOptional();

            Property(p => p.PCT012D099)
                .HasColumnName("PCT012D099")
                .HasColumnOrder(103)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D099")
                .IsOptional();

            Property(p => p.PCT012D100)
                .HasColumnName("PCT012D100")
                .HasColumnOrder(104)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D100")
                .IsOptional();

            Property(p => p.PCT012D101)
                .HasColumnName("PCT012D101")
                .HasColumnOrder(105)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D101")
                .IsOptional();

            Property(p => p.PCT012D102)
                .HasColumnName("PCT012D102")
                .HasColumnOrder(106)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D102")
                .IsOptional();

            Property(p => p.PCT012D103)
                .HasColumnName("PCT012D103")
                .HasColumnOrder(107)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D103")
                .IsOptional();

            Property(p => p.PCT012D104)
                .HasColumnName("PCT012D104")
                .HasColumnOrder(108)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D104")
                .IsOptional();

            Property(p => p.PCT012D105)
                .HasColumnName("PCT012D105")
                .HasColumnOrder(109)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D105")
                .IsOptional();

            Property(p => p.PCT012D106)
                .HasColumnName("PCT012D106")
                .HasColumnOrder(110)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D106")
                .IsOptional();

            Property(p => p.PCT012D107)
                .HasColumnName("PCT012D107")
                .HasColumnOrder(111)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D107")
                .IsOptional();

            Property(p => p.PCT012D108)
                .HasColumnName("PCT012D108")
                .HasColumnOrder(112)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D108")
                .IsOptional();

            Property(p => p.PCT012D109)
                .HasColumnName("PCT012D109")
                .HasColumnOrder(113)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D109")
                .IsOptional();

            Property(p => p.PCT012D110)
                .HasColumnName("PCT012D110")
                .HasColumnOrder(114)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D110")
                .IsOptional();

            Property(p => p.PCT012D111)
                .HasColumnName("PCT012D111")
                .HasColumnOrder(115)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D111")
                .IsOptional();

            Property(p => p.PCT012D112)
                .HasColumnName("PCT012D112")
                .HasColumnOrder(116)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D112")
                .IsOptional();

            Property(p => p.PCT012D113)
                .HasColumnName("PCT012D113")
                .HasColumnOrder(117)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D113")
                .IsOptional();

            Property(p => p.PCT012D114)
                .HasColumnName("PCT012D114")
                .HasColumnOrder(118)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D114")
                .IsOptional();

            Property(p => p.PCT012D115)
                .HasColumnName("PCT012D115")
                .HasColumnOrder(119)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D115")
                .IsOptional();

            Property(p => p.PCT012D116)
                .HasColumnName("PCT012D116")
                .HasColumnOrder(120)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D116")
                .IsOptional();

            Property(p => p.PCT012D117)
                .HasColumnName("PCT012D117")
                .HasColumnOrder(121)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D117")
                .IsOptional();

            Property(p => p.PCT012D118)
                .HasColumnName("PCT012D118")
                .HasColumnOrder(122)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D118")
                .IsOptional();

            Property(p => p.PCT012D119)
                .HasColumnName("PCT012D119")
                .HasColumnOrder(123)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D119")
                .IsOptional();

            Property(p => p.PCT012D120)
                .HasColumnName("PCT012D120")
                .HasColumnOrder(124)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D120")
                .IsOptional();

            Property(p => p.PCT012D121)
                .HasColumnName("PCT012D121")
                .HasColumnOrder(125)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D121")
                .IsOptional();

            Property(p => p.PCT012D122)
                .HasColumnName("PCT012D122")
                .HasColumnOrder(126)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D122")
                .IsOptional();

            Property(p => p.PCT012D123)
                .HasColumnName("PCT012D123")
                .HasColumnOrder(127)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D123")
                .IsOptional();

            Property(p => p.PCT012D124)
                .HasColumnName("PCT012D124")
                .HasColumnOrder(128)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D124")
                .IsOptional();

            Property(p => p.PCT012D125)
                .HasColumnName("PCT012D125")
                .HasColumnOrder(129)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D125")
                .IsOptional();

            Property(p => p.PCT012D126)
                .HasColumnName("PCT012D126")
                .HasColumnOrder(130)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D126")
                .IsOptional();

            Property(p => p.PCT012D127)
                .HasColumnName("PCT012D127")
                .HasColumnOrder(131)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D127")
                .IsOptional();

            Property(p => p.PCT012D128)
                .HasColumnName("PCT012D128")
                .HasColumnOrder(132)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D128")
                .IsOptional();

            Property(p => p.PCT012D129)
                .HasColumnName("PCT012D129")
                .HasColumnOrder(133)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D129")
                .IsOptional();

            Property(p => p.PCT012D130)
                .HasColumnName("PCT012D130")
                .HasColumnOrder(134)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D130")
                .IsOptional();

            Property(p => p.PCT012D131)
                .HasColumnName("PCT012D131")
                .HasColumnOrder(135)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D131")
                .IsOptional();

            Property(p => p.PCT012D132)
                .HasColumnName("PCT012D132")
                .HasColumnOrder(136)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D132")
                .IsOptional();

            Property(p => p.PCT012D133)
                .HasColumnName("PCT012D133")
                .HasColumnOrder(137)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D133")
                .IsOptional();

            Property(p => p.PCT012D134)
                .HasColumnName("PCT012D134")
                .HasColumnOrder(138)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D134")
                .IsOptional();

            Property(p => p.PCT012D135)
                .HasColumnName("PCT012D135")
                .HasColumnOrder(139)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D135")
                .IsOptional();

            Property(p => p.PCT012D136)
                .HasColumnName("PCT012D136")
                .HasColumnOrder(140)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D136")
                .IsOptional();

            Property(p => p.PCT012D137)
                .HasColumnName("PCT012D137")
                .HasColumnOrder(141)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D137")
                .IsOptional();

            Property(p => p.PCT012D138)
                .HasColumnName("PCT012D138")
                .HasColumnOrder(142)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D138")
                .IsOptional();

            Property(p => p.PCT012D139)
                .HasColumnName("PCT012D139")
                .HasColumnOrder(143)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D139")
                .IsOptional();

            Property(p => p.PCT012D140)
                .HasColumnName("PCT012D140")
                .HasColumnOrder(144)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D140")
                .IsOptional();

            Property(p => p.PCT012D141)
                .HasColumnName("PCT012D141")
                .HasColumnOrder(145)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D141")
                .IsOptional();

            Property(p => p.PCT012D142)
                .HasColumnName("PCT012D142")
                .HasColumnOrder(146)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D142")
                .IsOptional();

            Property(p => p.PCT012D143)
                .HasColumnName("PCT012D143")
                .HasColumnOrder(147)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D143")
                .IsOptional();

            Property(p => p.PCT012D144)
                .HasColumnName("PCT012D144")
                .HasColumnOrder(148)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D144")
                .IsOptional();

            Property(p => p.PCT012D145)
                .HasColumnName("PCT012D145")
                .HasColumnOrder(149)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D145")
                .IsOptional();

            Property(p => p.PCT012D146)
                .HasColumnName("PCT012D146")
                .HasColumnOrder(150)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D146")
                .IsOptional();

            Property(p => p.PCT012D147)
                .HasColumnName("PCT012D147")
                .HasColumnOrder(151)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D147")
                .IsOptional();

            Property(p => p.PCT012D148)
                .HasColumnName("PCT012D148")
                .HasColumnOrder(152)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D148")
                .IsOptional();

            Property(p => p.PCT012D149)
                .HasColumnName("PCT012D149")
                .HasColumnOrder(153)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D149")
                .IsOptional();

            Property(p => p.PCT012D150)
                .HasColumnName("PCT012D150")
                .HasColumnOrder(154)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D150")
                .IsOptional();

            Property(p => p.PCT012D151)
                .HasColumnName("PCT012D151")
                .HasColumnOrder(155)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D151")
                .IsOptional();

            Property(p => p.PCT012D152)
                .HasColumnName("PCT012D152")
                .HasColumnOrder(156)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D152")
                .IsOptional();

            Property(p => p.PCT012D153)
                .HasColumnName("PCT012D153")
                .HasColumnOrder(157)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D153")
                .IsOptional();

            Property(p => p.PCT012D154)
                .HasColumnName("PCT012D154")
                .HasColumnOrder(158)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D154")
                .IsOptional();

            Property(p => p.PCT012D155)
                .HasColumnName("PCT012D155")
                .HasColumnOrder(159)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D155")
                .IsOptional();

            Property(p => p.PCT012D156)
                .HasColumnName("PCT012D156")
                .HasColumnOrder(160)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D156")
                .IsOptional();

            Property(p => p.PCT012D157)
                .HasColumnName("PCT012D157")
                .HasColumnOrder(161)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D157")
                .IsOptional();

            Property(p => p.PCT012D158)
                .HasColumnName("PCT012D158")
                .HasColumnOrder(162)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D158")
                .IsOptional();

            Property(p => p.PCT012D159)
                .HasColumnName("PCT012D159")
                .HasColumnOrder(163)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D159")
                .IsOptional();

            Property(p => p.PCT012D160)
                .HasColumnName("PCT012D160")
                .HasColumnOrder(164)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D160")
                .IsOptional();

            Property(p => p.PCT012D161)
                .HasColumnName("PCT012D161")
                .HasColumnOrder(165)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D161")
                .IsOptional();

            Property(p => p.PCT012D162)
                .HasColumnName("PCT012D162")
                .HasColumnOrder(166)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D162")
                .IsOptional();

            Property(p => p.PCT012D163)
                .HasColumnName("PCT012D163")
                .HasColumnOrder(167)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D163")
                .IsOptional();

            Property(p => p.PCT012D164)
                .HasColumnName("PCT012D164")
                .HasColumnOrder(168)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D164")
                .IsOptional();

            Property(p => p.PCT012D165)
                .HasColumnName("PCT012D165")
                .HasColumnOrder(169)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D165")
                .IsOptional();

            Property(p => p.PCT012D166)
                .HasColumnName("PCT012D166")
                .HasColumnOrder(170)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D166")
                .IsOptional();

            Property(p => p.PCT012D167)
                .HasColumnName("PCT012D167")
                .HasColumnOrder(171)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D167")
                .IsOptional();

            Property(p => p.PCT012D168)
                .HasColumnName("PCT012D168")
                .HasColumnOrder(172)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D168")
                .IsOptional();

            Property(p => p.PCT012D169)
                .HasColumnName("PCT012D169")
                .HasColumnOrder(173)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D169")
                .IsOptional();

            Property(p => p.PCT012D170)
                .HasColumnName("PCT012D170")
                .HasColumnOrder(174)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D170")
                .IsOptional();

            Property(p => p.PCT012D171)
                .HasColumnName("PCT012D171")
                .HasColumnOrder(175)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D171")
                .IsOptional();

            Property(p => p.PCT012D172)
                .HasColumnName("PCT012D172")
                .HasColumnOrder(176)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D172")
                .IsOptional();

            Property(p => p.PCT012D173)
                .HasColumnName("PCT012D173")
                .HasColumnOrder(177)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D173")
                .IsOptional();

            Property(p => p.PCT012D174)
                .HasColumnName("PCT012D174")
                .HasColumnOrder(178)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D174")
                .IsOptional();

            Property(p => p.PCT012D175)
                .HasColumnName("PCT012D175")
                .HasColumnOrder(179)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D175")
                .IsOptional();

            Property(p => p.PCT012D176)
                .HasColumnName("PCT012D176")
                .HasColumnOrder(180)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D176")
                .IsOptional();

            Property(p => p.PCT012D177)
                .HasColumnName("PCT012D177")
                .HasColumnOrder(181)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D177")
                .IsOptional();

            Property(p => p.PCT012D178)
                .HasColumnName("PCT012D178")
                .HasColumnOrder(182)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D178")
                .IsOptional();

            Property(p => p.PCT012D179)
                .HasColumnName("PCT012D179")
                .HasColumnOrder(183)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D179")
                .IsOptional();

            Property(p => p.PCT012D180)
                .HasColumnName("PCT012D180")
                .HasColumnOrder(184)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D180")
                .IsOptional();

            Property(p => p.PCT012D181)
                .HasColumnName("PCT012D181")
                .HasColumnOrder(185)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D181")
                .IsOptional();

            Property(p => p.PCT012D182)
                .HasColumnName("PCT012D182")
                .HasColumnOrder(186)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D182")
                .IsOptional();

            Property(p => p.PCT012D183)
                .HasColumnName("PCT012D183")
                .HasColumnOrder(187)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D183")
                .IsOptional();

            Property(p => p.PCT012D184)
                .HasColumnName("PCT012D184")
                .HasColumnOrder(188)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D184")
                .IsOptional();

            Property(p => p.PCT012D185)
                .HasColumnName("PCT012D185")
                .HasColumnOrder(189)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D185")
                .IsOptional();

            Property(p => p.PCT012D186)
                .HasColumnName("PCT012D186")
                .HasColumnOrder(190)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D186")
                .IsOptional();

            Property(p => p.PCT012D187)
                .HasColumnName("PCT012D187")
                .HasColumnOrder(191)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D187")
                .IsOptional();

            Property(p => p.PCT012D188)
                .HasColumnName("PCT012D188")
                .HasColumnOrder(192)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D188")
                .IsOptional();

            Property(p => p.PCT012D189)
                .HasColumnName("PCT012D189")
                .HasColumnOrder(193)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D189")
                .IsOptional();

            Property(p => p.PCT012D190)
                .HasColumnName("PCT012D190")
                .HasColumnOrder(194)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D190")
                .IsOptional();

            Property(p => p.PCT012D191)
                .HasColumnName("PCT012D191")
                .HasColumnOrder(195)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D191")
                .IsOptional();

            Property(p => p.PCT012D192)
                .HasColumnName("PCT012D192")
                .HasColumnOrder(196)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D192")
                .IsOptional();

            Property(p => p.PCT012D193)
                .HasColumnName("PCT012D193")
                .HasColumnOrder(197)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D193")
                .IsOptional();

            Property(p => p.PCT012D194)
                .HasColumnName("PCT012D194")
                .HasColumnOrder(198)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D194")
                .IsOptional();

            Property(p => p.PCT012D195)
                .HasColumnName("PCT012D195")
                .HasColumnOrder(199)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D195")
                .IsOptional();

            Property(p => p.PCT012D196)
                .HasColumnName("PCT012D196")
                .HasColumnOrder(200)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D196")
                .IsOptional();

            Property(p => p.PCT012D197)
                .HasColumnName("PCT012D197")
                .HasColumnOrder(201)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D197")
                .IsOptional();

            Property(p => p.PCT012D198)
                .HasColumnName("PCT012D198")
                .HasColumnOrder(202)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D198")
                .IsOptional();

            Property(p => p.PCT012D199)
                .HasColumnName("PCT012D199")
                .HasColumnOrder(203)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D199")
                .IsOptional();

            Property(p => p.PCT012D200)
                .HasColumnName("PCT012D200")
                .HasColumnOrder(204)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D200")
                .IsOptional();

            Property(p => p.PCT012D201)
                .HasColumnName("PCT012D201")
                .HasColumnOrder(205)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D201")
                .IsOptional();

            Property(p => p.PCT012D202)
                .HasColumnName("PCT012D202")
                .HasColumnOrder(206)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D202")
                .IsOptional();

            Property(p => p.PCT012D203)
                .HasColumnName("PCT012D203")
                .HasColumnOrder(207)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D203")
                .IsOptional();

            Property(p => p.PCT012D204)
                .HasColumnName("PCT012D204")
                .HasColumnOrder(208)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D204")
                .IsOptional();

            Property(p => p.PCT012D205)
                .HasColumnName("PCT012D205")
                .HasColumnOrder(209)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D205")
                .IsOptional();

            Property(p => p.PCT012D206)
                .HasColumnName("PCT012D206")
                .HasColumnOrder(210)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D206")
                .IsOptional();

            Property(p => p.PCT012D207)
                .HasColumnName("PCT012D207")
                .HasColumnOrder(211)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D207")
                .IsOptional();

            Property(p => p.PCT012D208)
                .HasColumnName("PCT012D208")
                .HasColumnOrder(212)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D208")
                .IsOptional();

            Property(p => p.PCT012D209)
                .HasColumnName("PCT012D209")
                .HasColumnOrder(213)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012D209")
                .IsOptional();
        }
    }
}
