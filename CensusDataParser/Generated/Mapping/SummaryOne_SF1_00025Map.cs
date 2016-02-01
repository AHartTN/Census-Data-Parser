#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/31/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SummaryOne_SF1_00025Map.cs
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

    public class SummaryOne_SF1_00025Map : EntityTypeConfiguration<SummaryOne_SF1_00025>
    {
        public SummaryOne_SF1_00025Map()
        {
            ToTable("SF1_00025", "SummaryOne");

            HasKey(k => new
                        {
                            k.FILEID,
                            k.STUSAB,
                            k.CHARITER,
                            k.CIFSN,
                            k.LOGRECNO
                        });

            Property(p => p.FILEID)
                .HasColumnName("FILEID")
                .HasColumnOrder(0)
                .HasColumnType("NVARCHAR")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasMaxLength(255)
                .HasParameterName("FILEID")
                .IsRequired();

            Property(p => p.STUSAB)
                .HasColumnName("STUSAB")
                .HasColumnOrder(1)
                .HasColumnType("NVARCHAR")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasMaxLength(255)
                .HasParameterName("STUSAB")
                .IsRequired();

            Property(p => p.CHARITER)
                .HasColumnName("CHARITER")
                .HasColumnOrder(2)
                .HasColumnType("NVARCHAR")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasMaxLength(255)
                .HasParameterName("CHARITER")
                .IsRequired();

            Property(p => p.CIFSN)
                .HasColumnName("CIFSN")
                .HasColumnOrder(3)
                .HasColumnType("NVARCHAR")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasMaxLength(255)
                .HasParameterName("CIFSN")
                .IsRequired();

            Property(p => p.LOGRECNO)
                .HasColumnName("LOGRECNO")
                .HasColumnOrder(4)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("LOGRECNO")
                .IsRequired();

            Property(p => p.PCT012F001)
                .HasColumnName("PCT012F001")
                .HasColumnOrder(5)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F001")
                .IsOptional();

            Property(p => p.PCT012F002)
                .HasColumnName("PCT012F002")
                .HasColumnOrder(6)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F002")
                .IsOptional();

            Property(p => p.PCT012F003)
                .HasColumnName("PCT012F003")
                .HasColumnOrder(7)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F003")
                .IsOptional();

            Property(p => p.PCT012F004)
                .HasColumnName("PCT012F004")
                .HasColumnOrder(8)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F004")
                .IsOptional();

            Property(p => p.PCT012F005)
                .HasColumnName("PCT012F005")
                .HasColumnOrder(9)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F005")
                .IsOptional();

            Property(p => p.PCT012F006)
                .HasColumnName("PCT012F006")
                .HasColumnOrder(10)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F006")
                .IsOptional();

            Property(p => p.PCT012F007)
                .HasColumnName("PCT012F007")
                .HasColumnOrder(11)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F007")
                .IsOptional();

            Property(p => p.PCT012F008)
                .HasColumnName("PCT012F008")
                .HasColumnOrder(12)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F008")
                .IsOptional();

            Property(p => p.PCT012F009)
                .HasColumnName("PCT012F009")
                .HasColumnOrder(13)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F009")
                .IsOptional();

            Property(p => p.PCT012F010)
                .HasColumnName("PCT012F010")
                .HasColumnOrder(14)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F010")
                .IsOptional();

            Property(p => p.PCT012F011)
                .HasColumnName("PCT012F011")
                .HasColumnOrder(15)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F011")
                .IsOptional();

            Property(p => p.PCT012F012)
                .HasColumnName("PCT012F012")
                .HasColumnOrder(16)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F012")
                .IsOptional();

            Property(p => p.PCT012F013)
                .HasColumnName("PCT012F013")
                .HasColumnOrder(17)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F013")
                .IsOptional();

            Property(p => p.PCT012F014)
                .HasColumnName("PCT012F014")
                .HasColumnOrder(18)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F014")
                .IsOptional();

            Property(p => p.PCT012F015)
                .HasColumnName("PCT012F015")
                .HasColumnOrder(19)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F015")
                .IsOptional();

            Property(p => p.PCT012F016)
                .HasColumnName("PCT012F016")
                .HasColumnOrder(20)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F016")
                .IsOptional();

            Property(p => p.PCT012F017)
                .HasColumnName("PCT012F017")
                .HasColumnOrder(21)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F017")
                .IsOptional();

            Property(p => p.PCT012F018)
                .HasColumnName("PCT012F018")
                .HasColumnOrder(22)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F018")
                .IsOptional();

            Property(p => p.PCT012F019)
                .HasColumnName("PCT012F019")
                .HasColumnOrder(23)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F019")
                .IsOptional();

            Property(p => p.PCT012F020)
                .HasColumnName("PCT012F020")
                .HasColumnOrder(24)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F020")
                .IsOptional();

            Property(p => p.PCT012F021)
                .HasColumnName("PCT012F021")
                .HasColumnOrder(25)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F021")
                .IsOptional();

            Property(p => p.PCT012F022)
                .HasColumnName("PCT012F022")
                .HasColumnOrder(26)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F022")
                .IsOptional();

            Property(p => p.PCT012F023)
                .HasColumnName("PCT012F023")
                .HasColumnOrder(27)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F023")
                .IsOptional();

            Property(p => p.PCT012F024)
                .HasColumnName("PCT012F024")
                .HasColumnOrder(28)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F024")
                .IsOptional();

            Property(p => p.PCT012F025)
                .HasColumnName("PCT012F025")
                .HasColumnOrder(29)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F025")
                .IsOptional();

            Property(p => p.PCT012F026)
                .HasColumnName("PCT012F026")
                .HasColumnOrder(30)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F026")
                .IsOptional();

            Property(p => p.PCT012F027)
                .HasColumnName("PCT012F027")
                .HasColumnOrder(31)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F027")
                .IsOptional();

            Property(p => p.PCT012F028)
                .HasColumnName("PCT012F028")
                .HasColumnOrder(32)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F028")
                .IsOptional();

            Property(p => p.PCT012F029)
                .HasColumnName("PCT012F029")
                .HasColumnOrder(33)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F029")
                .IsOptional();

            Property(p => p.PCT012F030)
                .HasColumnName("PCT012F030")
                .HasColumnOrder(34)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F030")
                .IsOptional();

            Property(p => p.PCT012F031)
                .HasColumnName("PCT012F031")
                .HasColumnOrder(35)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F031")
                .IsOptional();

            Property(p => p.PCT012F032)
                .HasColumnName("PCT012F032")
                .HasColumnOrder(36)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F032")
                .IsOptional();

            Property(p => p.PCT012F033)
                .HasColumnName("PCT012F033")
                .HasColumnOrder(37)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F033")
                .IsOptional();

            Property(p => p.PCT012F034)
                .HasColumnName("PCT012F034")
                .HasColumnOrder(38)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F034")
                .IsOptional();

            Property(p => p.PCT012F035)
                .HasColumnName("PCT012F035")
                .HasColumnOrder(39)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F035")
                .IsOptional();

            Property(p => p.PCT012F036)
                .HasColumnName("PCT012F036")
                .HasColumnOrder(40)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F036")
                .IsOptional();

            Property(p => p.PCT012F037)
                .HasColumnName("PCT012F037")
                .HasColumnOrder(41)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F037")
                .IsOptional();

            Property(p => p.PCT012F038)
                .HasColumnName("PCT012F038")
                .HasColumnOrder(42)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F038")
                .IsOptional();

            Property(p => p.PCT012F039)
                .HasColumnName("PCT012F039")
                .HasColumnOrder(43)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F039")
                .IsOptional();

            Property(p => p.PCT012F040)
                .HasColumnName("PCT012F040")
                .HasColumnOrder(44)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F040")
                .IsOptional();

            Property(p => p.PCT012F041)
                .HasColumnName("PCT012F041")
                .HasColumnOrder(45)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F041")
                .IsOptional();

            Property(p => p.PCT012F042)
                .HasColumnName("PCT012F042")
                .HasColumnOrder(46)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F042")
                .IsOptional();

            Property(p => p.PCT012F043)
                .HasColumnName("PCT012F043")
                .HasColumnOrder(47)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F043")
                .IsOptional();

            Property(p => p.PCT012F044)
                .HasColumnName("PCT012F044")
                .HasColumnOrder(48)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F044")
                .IsOptional();

            Property(p => p.PCT012F045)
                .HasColumnName("PCT012F045")
                .HasColumnOrder(49)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F045")
                .IsOptional();

            Property(p => p.PCT012F046)
                .HasColumnName("PCT012F046")
                .HasColumnOrder(50)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F046")
                .IsOptional();

            Property(p => p.PCT012F047)
                .HasColumnName("PCT012F047")
                .HasColumnOrder(51)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F047")
                .IsOptional();

            Property(p => p.PCT012F048)
                .HasColumnName("PCT012F048")
                .HasColumnOrder(52)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F048")
                .IsOptional();

            Property(p => p.PCT012F049)
                .HasColumnName("PCT012F049")
                .HasColumnOrder(53)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F049")
                .IsOptional();

            Property(p => p.PCT012F050)
                .HasColumnName("PCT012F050")
                .HasColumnOrder(54)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F050")
                .IsOptional();

            Property(p => p.PCT012F051)
                .HasColumnName("PCT012F051")
                .HasColumnOrder(55)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F051")
                .IsOptional();

            Property(p => p.PCT012F052)
                .HasColumnName("PCT012F052")
                .HasColumnOrder(56)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F052")
                .IsOptional();

            Property(p => p.PCT012F053)
                .HasColumnName("PCT012F053")
                .HasColumnOrder(57)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F053")
                .IsOptional();

            Property(p => p.PCT012F054)
                .HasColumnName("PCT012F054")
                .HasColumnOrder(58)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F054")
                .IsOptional();

            Property(p => p.PCT012F055)
                .HasColumnName("PCT012F055")
                .HasColumnOrder(59)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F055")
                .IsOptional();

            Property(p => p.PCT012F056)
                .HasColumnName("PCT012F056")
                .HasColumnOrder(60)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F056")
                .IsOptional();

            Property(p => p.PCT012F057)
                .HasColumnName("PCT012F057")
                .HasColumnOrder(61)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F057")
                .IsOptional();

            Property(p => p.PCT012F058)
                .HasColumnName("PCT012F058")
                .HasColumnOrder(62)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F058")
                .IsOptional();

            Property(p => p.PCT012F059)
                .HasColumnName("PCT012F059")
                .HasColumnOrder(63)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F059")
                .IsOptional();

            Property(p => p.PCT012F060)
                .HasColumnName("PCT012F060")
                .HasColumnOrder(64)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F060")
                .IsOptional();

            Property(p => p.PCT012F061)
                .HasColumnName("PCT012F061")
                .HasColumnOrder(65)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F061")
                .IsOptional();

            Property(p => p.PCT012F062)
                .HasColumnName("PCT012F062")
                .HasColumnOrder(66)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F062")
                .IsOptional();

            Property(p => p.PCT012F063)
                .HasColumnName("PCT012F063")
                .HasColumnOrder(67)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F063")
                .IsOptional();

            Property(p => p.PCT012F064)
                .HasColumnName("PCT012F064")
                .HasColumnOrder(68)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F064")
                .IsOptional();

            Property(p => p.PCT012F065)
                .HasColumnName("PCT012F065")
                .HasColumnOrder(69)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F065")
                .IsOptional();

            Property(p => p.PCT012F066)
                .HasColumnName("PCT012F066")
                .HasColumnOrder(70)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F066")
                .IsOptional();

            Property(p => p.PCT012F067)
                .HasColumnName("PCT012F067")
                .HasColumnOrder(71)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F067")
                .IsOptional();

            Property(p => p.PCT012F068)
                .HasColumnName("PCT012F068")
                .HasColumnOrder(72)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F068")
                .IsOptional();

            Property(p => p.PCT012F069)
                .HasColumnName("PCT012F069")
                .HasColumnOrder(73)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F069")
                .IsOptional();

            Property(p => p.PCT012F070)
                .HasColumnName("PCT012F070")
                .HasColumnOrder(74)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F070")
                .IsOptional();

            Property(p => p.PCT012F071)
                .HasColumnName("PCT012F071")
                .HasColumnOrder(75)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F071")
                .IsOptional();

            Property(p => p.PCT012F072)
                .HasColumnName("PCT012F072")
                .HasColumnOrder(76)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F072")
                .IsOptional();

            Property(p => p.PCT012F073)
                .HasColumnName("PCT012F073")
                .HasColumnOrder(77)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F073")
                .IsOptional();

            Property(p => p.PCT012F074)
                .HasColumnName("PCT012F074")
                .HasColumnOrder(78)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F074")
                .IsOptional();

            Property(p => p.PCT012F075)
                .HasColumnName("PCT012F075")
                .HasColumnOrder(79)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F075")
                .IsOptional();

            Property(p => p.PCT012F076)
                .HasColumnName("PCT012F076")
                .HasColumnOrder(80)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F076")
                .IsOptional();

            Property(p => p.PCT012F077)
                .HasColumnName("PCT012F077")
                .HasColumnOrder(81)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F077")
                .IsOptional();

            Property(p => p.PCT012F078)
                .HasColumnName("PCT012F078")
                .HasColumnOrder(82)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F078")
                .IsOptional();

            Property(p => p.PCT012F079)
                .HasColumnName("PCT012F079")
                .HasColumnOrder(83)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F079")
                .IsOptional();

            Property(p => p.PCT012F080)
                .HasColumnName("PCT012F080")
                .HasColumnOrder(84)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F080")
                .IsOptional();

            Property(p => p.PCT012F081)
                .HasColumnName("PCT012F081")
                .HasColumnOrder(85)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F081")
                .IsOptional();

            Property(p => p.PCT012F082)
                .HasColumnName("PCT012F082")
                .HasColumnOrder(86)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F082")
                .IsOptional();

            Property(p => p.PCT012F083)
                .HasColumnName("PCT012F083")
                .HasColumnOrder(87)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F083")
                .IsOptional();

            Property(p => p.PCT012F084)
                .HasColumnName("PCT012F084")
                .HasColumnOrder(88)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F084")
                .IsOptional();

            Property(p => p.PCT012F085)
                .HasColumnName("PCT012F085")
                .HasColumnOrder(89)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F085")
                .IsOptional();

            Property(p => p.PCT012F086)
                .HasColumnName("PCT012F086")
                .HasColumnOrder(90)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F086")
                .IsOptional();

            Property(p => p.PCT012F087)
                .HasColumnName("PCT012F087")
                .HasColumnOrder(91)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F087")
                .IsOptional();

            Property(p => p.PCT012F088)
                .HasColumnName("PCT012F088")
                .HasColumnOrder(92)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F088")
                .IsOptional();

            Property(p => p.PCT012F089)
                .HasColumnName("PCT012F089")
                .HasColumnOrder(93)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F089")
                .IsOptional();

            Property(p => p.PCT012F090)
                .HasColumnName("PCT012F090")
                .HasColumnOrder(94)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F090")
                .IsOptional();

            Property(p => p.PCT012F091)
                .HasColumnName("PCT012F091")
                .HasColumnOrder(95)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F091")
                .IsOptional();

            Property(p => p.PCT012F092)
                .HasColumnName("PCT012F092")
                .HasColumnOrder(96)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F092")
                .IsOptional();

            Property(p => p.PCT012F093)
                .HasColumnName("PCT012F093")
                .HasColumnOrder(97)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F093")
                .IsOptional();

            Property(p => p.PCT012F094)
                .HasColumnName("PCT012F094")
                .HasColumnOrder(98)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F094")
                .IsOptional();

            Property(p => p.PCT012F095)
                .HasColumnName("PCT012F095")
                .HasColumnOrder(99)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F095")
                .IsOptional();

            Property(p => p.PCT012F096)
                .HasColumnName("PCT012F096")
                .HasColumnOrder(100)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F096")
                .IsOptional();

            Property(p => p.PCT012F097)
                .HasColumnName("PCT012F097")
                .HasColumnOrder(101)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F097")
                .IsOptional();

            Property(p => p.PCT012F098)
                .HasColumnName("PCT012F098")
                .HasColumnOrder(102)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F098")
                .IsOptional();

            Property(p => p.PCT012F099)
                .HasColumnName("PCT012F099")
                .HasColumnOrder(103)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F099")
                .IsOptional();

            Property(p => p.PCT012F100)
                .HasColumnName("PCT012F100")
                .HasColumnOrder(104)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F100")
                .IsOptional();

            Property(p => p.PCT012F101)
                .HasColumnName("PCT012F101")
                .HasColumnOrder(105)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F101")
                .IsOptional();

            Property(p => p.PCT012F102)
                .HasColumnName("PCT012F102")
                .HasColumnOrder(106)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F102")
                .IsOptional();

            Property(p => p.PCT012F103)
                .HasColumnName("PCT012F103")
                .HasColumnOrder(107)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F103")
                .IsOptional();

            Property(p => p.PCT012F104)
                .HasColumnName("PCT012F104")
                .HasColumnOrder(108)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F104")
                .IsOptional();

            Property(p => p.PCT012F105)
                .HasColumnName("PCT012F105")
                .HasColumnOrder(109)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F105")
                .IsOptional();

            Property(p => p.PCT012F106)
                .HasColumnName("PCT012F106")
                .HasColumnOrder(110)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F106")
                .IsOptional();

            Property(p => p.PCT012F107)
                .HasColumnName("PCT012F107")
                .HasColumnOrder(111)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F107")
                .IsOptional();

            Property(p => p.PCT012F108)
                .HasColumnName("PCT012F108")
                .HasColumnOrder(112)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F108")
                .IsOptional();

            Property(p => p.PCT012F109)
                .HasColumnName("PCT012F109")
                .HasColumnOrder(113)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F109")
                .IsOptional();

            Property(p => p.PCT012F110)
                .HasColumnName("PCT012F110")
                .HasColumnOrder(114)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F110")
                .IsOptional();

            Property(p => p.PCT012F111)
                .HasColumnName("PCT012F111")
                .HasColumnOrder(115)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F111")
                .IsOptional();

            Property(p => p.PCT012F112)
                .HasColumnName("PCT012F112")
                .HasColumnOrder(116)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F112")
                .IsOptional();

            Property(p => p.PCT012F113)
                .HasColumnName("PCT012F113")
                .HasColumnOrder(117)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F113")
                .IsOptional();

            Property(p => p.PCT012F114)
                .HasColumnName("PCT012F114")
                .HasColumnOrder(118)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F114")
                .IsOptional();

            Property(p => p.PCT012F115)
                .HasColumnName("PCT012F115")
                .HasColumnOrder(119)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F115")
                .IsOptional();

            Property(p => p.PCT012F116)
                .HasColumnName("PCT012F116")
                .HasColumnOrder(120)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F116")
                .IsOptional();

            Property(p => p.PCT012F117)
                .HasColumnName("PCT012F117")
                .HasColumnOrder(121)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F117")
                .IsOptional();

            Property(p => p.PCT012F118)
                .HasColumnName("PCT012F118")
                .HasColumnOrder(122)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F118")
                .IsOptional();

            Property(p => p.PCT012F119)
                .HasColumnName("PCT012F119")
                .HasColumnOrder(123)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F119")
                .IsOptional();

            Property(p => p.PCT012F120)
                .HasColumnName("PCT012F120")
                .HasColumnOrder(124)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F120")
                .IsOptional();

            Property(p => p.PCT012F121)
                .HasColumnName("PCT012F121")
                .HasColumnOrder(125)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F121")
                .IsOptional();

            Property(p => p.PCT012F122)
                .HasColumnName("PCT012F122")
                .HasColumnOrder(126)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F122")
                .IsOptional();

            Property(p => p.PCT012F123)
                .HasColumnName("PCT012F123")
                .HasColumnOrder(127)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F123")
                .IsOptional();

            Property(p => p.PCT012F124)
                .HasColumnName("PCT012F124")
                .HasColumnOrder(128)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F124")
                .IsOptional();

            Property(p => p.PCT012F125)
                .HasColumnName("PCT012F125")
                .HasColumnOrder(129)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F125")
                .IsOptional();

            Property(p => p.PCT012F126)
                .HasColumnName("PCT012F126")
                .HasColumnOrder(130)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F126")
                .IsOptional();

            Property(p => p.PCT012F127)
                .HasColumnName("PCT012F127")
                .HasColumnOrder(131)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F127")
                .IsOptional();

            Property(p => p.PCT012F128)
                .HasColumnName("PCT012F128")
                .HasColumnOrder(132)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F128")
                .IsOptional();

            Property(p => p.PCT012F129)
                .HasColumnName("PCT012F129")
                .HasColumnOrder(133)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F129")
                .IsOptional();

            Property(p => p.PCT012F130)
                .HasColumnName("PCT012F130")
                .HasColumnOrder(134)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F130")
                .IsOptional();

            Property(p => p.PCT012F131)
                .HasColumnName("PCT012F131")
                .HasColumnOrder(135)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F131")
                .IsOptional();

            Property(p => p.PCT012F132)
                .HasColumnName("PCT012F132")
                .HasColumnOrder(136)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F132")
                .IsOptional();

            Property(p => p.PCT012F133)
                .HasColumnName("PCT012F133")
                .HasColumnOrder(137)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F133")
                .IsOptional();

            Property(p => p.PCT012F134)
                .HasColumnName("PCT012F134")
                .HasColumnOrder(138)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F134")
                .IsOptional();

            Property(p => p.PCT012F135)
                .HasColumnName("PCT012F135")
                .HasColumnOrder(139)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F135")
                .IsOptional();

            Property(p => p.PCT012F136)
                .HasColumnName("PCT012F136")
                .HasColumnOrder(140)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F136")
                .IsOptional();

            Property(p => p.PCT012F137)
                .HasColumnName("PCT012F137")
                .HasColumnOrder(141)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F137")
                .IsOptional();

            Property(p => p.PCT012F138)
                .HasColumnName("PCT012F138")
                .HasColumnOrder(142)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F138")
                .IsOptional();

            Property(p => p.PCT012F139)
                .HasColumnName("PCT012F139")
                .HasColumnOrder(143)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F139")
                .IsOptional();

            Property(p => p.PCT012F140)
                .HasColumnName("PCT012F140")
                .HasColumnOrder(144)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F140")
                .IsOptional();

            Property(p => p.PCT012F141)
                .HasColumnName("PCT012F141")
                .HasColumnOrder(145)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F141")
                .IsOptional();

            Property(p => p.PCT012F142)
                .HasColumnName("PCT012F142")
                .HasColumnOrder(146)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F142")
                .IsOptional();

            Property(p => p.PCT012F143)
                .HasColumnName("PCT012F143")
                .HasColumnOrder(147)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F143")
                .IsOptional();

            Property(p => p.PCT012F144)
                .HasColumnName("PCT012F144")
                .HasColumnOrder(148)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F144")
                .IsOptional();

            Property(p => p.PCT012F145)
                .HasColumnName("PCT012F145")
                .HasColumnOrder(149)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F145")
                .IsOptional();

            Property(p => p.PCT012F146)
                .HasColumnName("PCT012F146")
                .HasColumnOrder(150)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F146")
                .IsOptional();

            Property(p => p.PCT012F147)
                .HasColumnName("PCT012F147")
                .HasColumnOrder(151)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F147")
                .IsOptional();

            Property(p => p.PCT012F148)
                .HasColumnName("PCT012F148")
                .HasColumnOrder(152)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F148")
                .IsOptional();

            Property(p => p.PCT012F149)
                .HasColumnName("PCT012F149")
                .HasColumnOrder(153)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F149")
                .IsOptional();

            Property(p => p.PCT012F150)
                .HasColumnName("PCT012F150")
                .HasColumnOrder(154)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F150")
                .IsOptional();

            Property(p => p.PCT012F151)
                .HasColumnName("PCT012F151")
                .HasColumnOrder(155)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F151")
                .IsOptional();

            Property(p => p.PCT012F152)
                .HasColumnName("PCT012F152")
                .HasColumnOrder(156)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F152")
                .IsOptional();

            Property(p => p.PCT012F153)
                .HasColumnName("PCT012F153")
                .HasColumnOrder(157)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F153")
                .IsOptional();

            Property(p => p.PCT012F154)
                .HasColumnName("PCT012F154")
                .HasColumnOrder(158)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F154")
                .IsOptional();

            Property(p => p.PCT012F155)
                .HasColumnName("PCT012F155")
                .HasColumnOrder(159)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F155")
                .IsOptional();

            Property(p => p.PCT012F156)
                .HasColumnName("PCT012F156")
                .HasColumnOrder(160)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F156")
                .IsOptional();

            Property(p => p.PCT012F157)
                .HasColumnName("PCT012F157")
                .HasColumnOrder(161)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F157")
                .IsOptional();

            Property(p => p.PCT012F158)
                .HasColumnName("PCT012F158")
                .HasColumnOrder(162)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F158")
                .IsOptional();

            Property(p => p.PCT012F159)
                .HasColumnName("PCT012F159")
                .HasColumnOrder(163)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F159")
                .IsOptional();

            Property(p => p.PCT012F160)
                .HasColumnName("PCT012F160")
                .HasColumnOrder(164)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F160")
                .IsOptional();

            Property(p => p.PCT012F161)
                .HasColumnName("PCT012F161")
                .HasColumnOrder(165)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F161")
                .IsOptional();

            Property(p => p.PCT012F162)
                .HasColumnName("PCT012F162")
                .HasColumnOrder(166)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F162")
                .IsOptional();

            Property(p => p.PCT012F163)
                .HasColumnName("PCT012F163")
                .HasColumnOrder(167)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F163")
                .IsOptional();

            Property(p => p.PCT012F164)
                .HasColumnName("PCT012F164")
                .HasColumnOrder(168)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F164")
                .IsOptional();

            Property(p => p.PCT012F165)
                .HasColumnName("PCT012F165")
                .HasColumnOrder(169)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F165")
                .IsOptional();

            Property(p => p.PCT012F166)
                .HasColumnName("PCT012F166")
                .HasColumnOrder(170)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F166")
                .IsOptional();

            Property(p => p.PCT012F167)
                .HasColumnName("PCT012F167")
                .HasColumnOrder(171)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F167")
                .IsOptional();

            Property(p => p.PCT012F168)
                .HasColumnName("PCT012F168")
                .HasColumnOrder(172)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F168")
                .IsOptional();

            Property(p => p.PCT012F169)
                .HasColumnName("PCT012F169")
                .HasColumnOrder(173)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F169")
                .IsOptional();

            Property(p => p.PCT012F170)
                .HasColumnName("PCT012F170")
                .HasColumnOrder(174)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F170")
                .IsOptional();

            Property(p => p.PCT012F171)
                .HasColumnName("PCT012F171")
                .HasColumnOrder(175)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F171")
                .IsOptional();

            Property(p => p.PCT012F172)
                .HasColumnName("PCT012F172")
                .HasColumnOrder(176)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F172")
                .IsOptional();

            Property(p => p.PCT012F173)
                .HasColumnName("PCT012F173")
                .HasColumnOrder(177)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F173")
                .IsOptional();

            Property(p => p.PCT012F174)
                .HasColumnName("PCT012F174")
                .HasColumnOrder(178)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F174")
                .IsOptional();

            Property(p => p.PCT012F175)
                .HasColumnName("PCT012F175")
                .HasColumnOrder(179)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F175")
                .IsOptional();

            Property(p => p.PCT012F176)
                .HasColumnName("PCT012F176")
                .HasColumnOrder(180)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F176")
                .IsOptional();

            Property(p => p.PCT012F177)
                .HasColumnName("PCT012F177")
                .HasColumnOrder(181)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F177")
                .IsOptional();

            Property(p => p.PCT012F178)
                .HasColumnName("PCT012F178")
                .HasColumnOrder(182)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F178")
                .IsOptional();

            Property(p => p.PCT012F179)
                .HasColumnName("PCT012F179")
                .HasColumnOrder(183)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F179")
                .IsOptional();

            Property(p => p.PCT012F180)
                .HasColumnName("PCT012F180")
                .HasColumnOrder(184)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F180")
                .IsOptional();

            Property(p => p.PCT012F181)
                .HasColumnName("PCT012F181")
                .HasColumnOrder(185)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F181")
                .IsOptional();

            Property(p => p.PCT012F182)
                .HasColumnName("PCT012F182")
                .HasColumnOrder(186)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F182")
                .IsOptional();

            Property(p => p.PCT012F183)
                .HasColumnName("PCT012F183")
                .HasColumnOrder(187)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F183")
                .IsOptional();

            Property(p => p.PCT012F184)
                .HasColumnName("PCT012F184")
                .HasColumnOrder(188)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F184")
                .IsOptional();

            Property(p => p.PCT012F185)
                .HasColumnName("PCT012F185")
                .HasColumnOrder(189)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F185")
                .IsOptional();

            Property(p => p.PCT012F186)
                .HasColumnName("PCT012F186")
                .HasColumnOrder(190)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F186")
                .IsOptional();

            Property(p => p.PCT012F187)
                .HasColumnName("PCT012F187")
                .HasColumnOrder(191)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F187")
                .IsOptional();

            Property(p => p.PCT012F188)
                .HasColumnName("PCT012F188")
                .HasColumnOrder(192)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F188")
                .IsOptional();

            Property(p => p.PCT012F189)
                .HasColumnName("PCT012F189")
                .HasColumnOrder(193)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F189")
                .IsOptional();

            Property(p => p.PCT012F190)
                .HasColumnName("PCT012F190")
                .HasColumnOrder(194)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F190")
                .IsOptional();

            Property(p => p.PCT012F191)
                .HasColumnName("PCT012F191")
                .HasColumnOrder(195)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F191")
                .IsOptional();

            Property(p => p.PCT012F192)
                .HasColumnName("PCT012F192")
                .HasColumnOrder(196)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F192")
                .IsOptional();

            Property(p => p.PCT012F193)
                .HasColumnName("PCT012F193")
                .HasColumnOrder(197)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F193")
                .IsOptional();

            Property(p => p.PCT012F194)
                .HasColumnName("PCT012F194")
                .HasColumnOrder(198)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F194")
                .IsOptional();

            Property(p => p.PCT012F195)
                .HasColumnName("PCT012F195")
                .HasColumnOrder(199)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F195")
                .IsOptional();

            Property(p => p.PCT012F196)
                .HasColumnName("PCT012F196")
                .HasColumnOrder(200)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F196")
                .IsOptional();

            Property(p => p.PCT012F197)
                .HasColumnName("PCT012F197")
                .HasColumnOrder(201)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F197")
                .IsOptional();

            Property(p => p.PCT012F198)
                .HasColumnName("PCT012F198")
                .HasColumnOrder(202)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F198")
                .IsOptional();

            Property(p => p.PCT012F199)
                .HasColumnName("PCT012F199")
                .HasColumnOrder(203)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F199")
                .IsOptional();

            Property(p => p.PCT012F200)
                .HasColumnName("PCT012F200")
                .HasColumnOrder(204)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F200")
                .IsOptional();

            Property(p => p.PCT012F201)
                .HasColumnName("PCT012F201")
                .HasColumnOrder(205)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F201")
                .IsOptional();

            Property(p => p.PCT012F202)
                .HasColumnName("PCT012F202")
                .HasColumnOrder(206)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F202")
                .IsOptional();

            Property(p => p.PCT012F203)
                .HasColumnName("PCT012F203")
                .HasColumnOrder(207)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F203")
                .IsOptional();

            Property(p => p.PCT012F204)
                .HasColumnName("PCT012F204")
                .HasColumnOrder(208)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F204")
                .IsOptional();

            Property(p => p.PCT012F205)
                .HasColumnName("PCT012F205")
                .HasColumnOrder(209)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F205")
                .IsOptional();

            Property(p => p.PCT012F206)
                .HasColumnName("PCT012F206")
                .HasColumnOrder(210)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F206")
                .IsOptional();

            Property(p => p.PCT012F207)
                .HasColumnName("PCT012F207")
                .HasColumnOrder(211)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F207")
                .IsOptional();

            Property(p => p.PCT012F208)
                .HasColumnName("PCT012F208")
                .HasColumnOrder(212)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F208")
                .IsOptional();

            Property(p => p.PCT012F209)
                .HasColumnName("PCT012F209")
                .HasColumnOrder(213)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012F209")
                .IsOptional();
        }
    }
}
