#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/31/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SummaryTwo_SF2_Segment_11Map.cs
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

    public class SummaryTwo_SF2_Segment_11Map : EntityTypeConfiguration<SummaryTwo_SF2_Segment_11>
    {
        public SummaryTwo_SF2_Segment_11Map()
        {
            ToTable("SF2_Segment_11", "SummaryTwo");

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

            Property(p => p.HCT0020001)
                .HasColumnName("HCT0020001")
                .HasColumnOrder(5)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0020001")
                .IsOptional();

            Property(p => p.HCT0020002)
                .HasColumnName("HCT0020002")
                .HasColumnOrder(6)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0020002")
                .IsOptional();

            Property(p => p.HCT0020003)
                .HasColumnName("HCT0020003")
                .HasColumnOrder(7)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0020003")
                .IsOptional();

            Property(p => p.HCT0020004)
                .HasColumnName("HCT0020004")
                .HasColumnOrder(8)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0020004")
                .IsOptional();

            Property(p => p.HCT0030001)
                .HasColumnName("HCT0030001")
                .HasColumnOrder(9)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0030001")
                .IsOptional();

            Property(p => p.HCT0040001)
                .HasColumnName("HCT0040001")
                .HasColumnOrder(10)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0040001")
                .IsOptional();

            Property(p => p.HCT0040002)
                .HasColumnName("HCT0040002")
                .HasColumnOrder(11)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0040002")
                .IsOptional();

            Property(p => p.HCT0040003)
                .HasColumnName("HCT0040003")
                .HasColumnOrder(12)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0040003")
                .IsOptional();

            Property(p => p.HCT0040004)
                .HasColumnName("HCT0040004")
                .HasColumnOrder(13)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0040004")
                .IsOptional();

            Property(p => p.HCT0050001)
                .HasColumnName("HCT0050001")
                .HasColumnOrder(14)
                .HasColumnType("DECIMAL")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0050001")
                .IsOptional();

            Property(p => p.HCT0050002)
                .HasColumnName("HCT0050002")
                .HasColumnOrder(15)
                .HasColumnType("DECIMAL")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0050002")
                .IsOptional();

            Property(p => p.HCT0050003)
                .HasColumnName("HCT0050003")
                .HasColumnOrder(16)
                .HasColumnType("DECIMAL")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0050003")
                .IsOptional();

            Property(p => p.HCT0060001)
                .HasColumnName("HCT0060001")
                .HasColumnOrder(17)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0060001")
                .IsOptional();

            Property(p => p.HCT0060002)
                .HasColumnName("HCT0060002")
                .HasColumnOrder(18)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0060002")
                .IsOptional();

            Property(p => p.HCT0060003)
                .HasColumnName("HCT0060003")
                .HasColumnOrder(19)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0060003")
                .IsOptional();

            Property(p => p.HCT0060004)
                .HasColumnName("HCT0060004")
                .HasColumnOrder(20)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0060004")
                .IsOptional();

            Property(p => p.HCT0060005)
                .HasColumnName("HCT0060005")
                .HasColumnOrder(21)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0060005")
                .IsOptional();

            Property(p => p.HCT0060006)
                .HasColumnName("HCT0060006")
                .HasColumnOrder(22)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0060006")
                .IsOptional();

            Property(p => p.HCT0060007)
                .HasColumnName("HCT0060007")
                .HasColumnOrder(23)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0060007")
                .IsOptional();

            Property(p => p.HCT0060008)
                .HasColumnName("HCT0060008")
                .HasColumnOrder(24)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0060008")
                .IsOptional();

            Property(p => p.HCT0070001)
                .HasColumnName("HCT0070001")
                .HasColumnOrder(25)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0070001")
                .IsOptional();

            Property(p => p.HCT0070002)
                .HasColumnName("HCT0070002")
                .HasColumnOrder(26)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0070002")
                .IsOptional();

            Property(p => p.HCT0070003)
                .HasColumnName("HCT0070003")
                .HasColumnOrder(27)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0070003")
                .IsOptional();

            Property(p => p.HCT0070004)
                .HasColumnName("HCT0070004")
                .HasColumnOrder(28)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0070004")
                .IsOptional();

            Property(p => p.HCT0070005)
                .HasColumnName("HCT0070005")
                .HasColumnOrder(29)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0070005")
                .IsOptional();

            Property(p => p.HCT0070006)
                .HasColumnName("HCT0070006")
                .HasColumnOrder(30)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0070006")
                .IsOptional();

            Property(p => p.HCT0070007)
                .HasColumnName("HCT0070007")
                .HasColumnOrder(31)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0070007")
                .IsOptional();

            Property(p => p.HCT0070008)
                .HasColumnName("HCT0070008")
                .HasColumnOrder(32)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0070008")
                .IsOptional();

            Property(p => p.HCT0070009)
                .HasColumnName("HCT0070009")
                .HasColumnOrder(33)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0070009")
                .IsOptional();

            Property(p => p.HCT0070010)
                .HasColumnName("HCT0070010")
                .HasColumnOrder(34)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0070010")
                .IsOptional();

            Property(p => p.HCT0070011)
                .HasColumnName("HCT0070011")
                .HasColumnOrder(35)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0070011")
                .IsOptional();

            Property(p => p.HCT0070012)
                .HasColumnName("HCT0070012")
                .HasColumnOrder(36)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0070012")
                .IsOptional();

            Property(p => p.HCT0070013)
                .HasColumnName("HCT0070013")
                .HasColumnOrder(37)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0070013")
                .IsOptional();

            Property(p => p.HCT0070014)
                .HasColumnName("HCT0070014")
                .HasColumnOrder(38)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0070014")
                .IsOptional();

            Property(p => p.HCT0070015)
                .HasColumnName("HCT0070015")
                .HasColumnOrder(39)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0070015")
                .IsOptional();

            Property(p => p.HCT0070016)
                .HasColumnName("HCT0070016")
                .HasColumnOrder(40)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0070016")
                .IsOptional();

            Property(p => p.HCT0070017)
                .HasColumnName("HCT0070017")
                .HasColumnOrder(41)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0070017")
                .IsOptional();

            Property(p => p.HCT0080001)
                .HasColumnName("HCT0080001")
                .HasColumnOrder(42)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0080001")
                .IsOptional();

            Property(p => p.HCT0080002)
                .HasColumnName("HCT0080002")
                .HasColumnOrder(43)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0080002")
                .IsOptional();

            Property(p => p.HCT0080003)
                .HasColumnName("HCT0080003")
                .HasColumnOrder(44)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0080003")
                .IsOptional();

            Property(p => p.HCT0080004)
                .HasColumnName("HCT0080004")
                .HasColumnOrder(45)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0080004")
                .IsOptional();

            Property(p => p.HCT0080005)
                .HasColumnName("HCT0080005")
                .HasColumnOrder(46)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0080005")
                .IsOptional();

            Property(p => p.HCT0080006)
                .HasColumnName("HCT0080006")
                .HasColumnOrder(47)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0080006")
                .IsOptional();

            Property(p => p.HCT0080007)
                .HasColumnName("HCT0080007")
                .HasColumnOrder(48)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0080007")
                .IsOptional();

            Property(p => p.HCT0080008)
                .HasColumnName("HCT0080008")
                .HasColumnOrder(49)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0080008")
                .IsOptional();

            Property(p => p.HCT0080009)
                .HasColumnName("HCT0080009")
                .HasColumnOrder(50)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0080009")
                .IsOptional();

            Property(p => p.HCT0080010)
                .HasColumnName("HCT0080010")
                .HasColumnOrder(51)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0080010")
                .IsOptional();

            Property(p => p.HCT0080011)
                .HasColumnName("HCT0080011")
                .HasColumnOrder(52)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0080011")
                .IsOptional();

            Property(p => p.HCT0080012)
                .HasColumnName("HCT0080012")
                .HasColumnOrder(53)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0080012")
                .IsOptional();

            Property(p => p.HCT0080013)
                .HasColumnName("HCT0080013")
                .HasColumnOrder(54)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0080013")
                .IsOptional();

            Property(p => p.HCT0080014)
                .HasColumnName("HCT0080014")
                .HasColumnOrder(55)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0080014")
                .IsOptional();

            Property(p => p.HCT0080015)
                .HasColumnName("HCT0080015")
                .HasColumnOrder(56)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0080015")
                .IsOptional();

            Property(p => p.HCT0080016)
                .HasColumnName("HCT0080016")
                .HasColumnOrder(57)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0080016")
                .IsOptional();

            Property(p => p.HCT0080017)
                .HasColumnName("HCT0080017")
                .HasColumnOrder(58)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0080017")
                .IsOptional();

            Property(p => p.HCT0080018)
                .HasColumnName("HCT0080018")
                .HasColumnOrder(59)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0080018")
                .IsOptional();

            Property(p => p.HCT0080019)
                .HasColumnName("HCT0080019")
                .HasColumnOrder(60)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0080019")
                .IsOptional();

            Property(p => p.HCT0080020)
                .HasColumnName("HCT0080020")
                .HasColumnOrder(61)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0080020")
                .IsOptional();

            Property(p => p.HCT0080021)
                .HasColumnName("HCT0080021")
                .HasColumnOrder(62)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0080021")
                .IsOptional();

            Property(p => p.HCT0090001)
                .HasColumnName("HCT0090001")
                .HasColumnOrder(63)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090001")
                .IsOptional();

            Property(p => p.HCT0090002)
                .HasColumnName("HCT0090002")
                .HasColumnOrder(64)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090002")
                .IsOptional();

            Property(p => p.HCT0090003)
                .HasColumnName("HCT0090003")
                .HasColumnOrder(65)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090003")
                .IsOptional();

            Property(p => p.HCT0090004)
                .HasColumnName("HCT0090004")
                .HasColumnOrder(66)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090004")
                .IsOptional();

            Property(p => p.HCT0090005)
                .HasColumnName("HCT0090005")
                .HasColumnOrder(67)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090005")
                .IsOptional();

            Property(p => p.HCT0090006)
                .HasColumnName("HCT0090006")
                .HasColumnOrder(68)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090006")
                .IsOptional();

            Property(p => p.HCT0090007)
                .HasColumnName("HCT0090007")
                .HasColumnOrder(69)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090007")
                .IsOptional();

            Property(p => p.HCT0090008)
                .HasColumnName("HCT0090008")
                .HasColumnOrder(70)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090008")
                .IsOptional();

            Property(p => p.HCT0090009)
                .HasColumnName("HCT0090009")
                .HasColumnOrder(71)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090009")
                .IsOptional();

            Property(p => p.HCT0090010)
                .HasColumnName("HCT0090010")
                .HasColumnOrder(72)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090010")
                .IsOptional();

            Property(p => p.HCT0090011)
                .HasColumnName("HCT0090011")
                .HasColumnOrder(73)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090011")
                .IsOptional();

            Property(p => p.HCT0090012)
                .HasColumnName("HCT0090012")
                .HasColumnOrder(74)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090012")
                .IsOptional();

            Property(p => p.HCT0090013)
                .HasColumnName("HCT0090013")
                .HasColumnOrder(75)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090013")
                .IsOptional();

            Property(p => p.HCT0090014)
                .HasColumnName("HCT0090014")
                .HasColumnOrder(76)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090014")
                .IsOptional();

            Property(p => p.HCT0090015)
                .HasColumnName("HCT0090015")
                .HasColumnOrder(77)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090015")
                .IsOptional();

            Property(p => p.HCT0090016)
                .HasColumnName("HCT0090016")
                .HasColumnOrder(78)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090016")
                .IsOptional();

            Property(p => p.HCT0090017)
                .HasColumnName("HCT0090017")
                .HasColumnOrder(79)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090017")
                .IsOptional();

            Property(p => p.HCT0090018)
                .HasColumnName("HCT0090018")
                .HasColumnOrder(80)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090018")
                .IsOptional();

            Property(p => p.HCT0090019)
                .HasColumnName("HCT0090019")
                .HasColumnOrder(81)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090019")
                .IsOptional();

            Property(p => p.HCT0090020)
                .HasColumnName("HCT0090020")
                .HasColumnOrder(82)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090020")
                .IsOptional();

            Property(p => p.HCT0090021)
                .HasColumnName("HCT0090021")
                .HasColumnOrder(83)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090021")
                .IsOptional();

            Property(p => p.HCT0090022)
                .HasColumnName("HCT0090022")
                .HasColumnOrder(84)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090022")
                .IsOptional();

            Property(p => p.HCT0090023)
                .HasColumnName("HCT0090023")
                .HasColumnOrder(85)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090023")
                .IsOptional();

            Property(p => p.HCT0090024)
                .HasColumnName("HCT0090024")
                .HasColumnOrder(86)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090024")
                .IsOptional();

            Property(p => p.HCT0090025)
                .HasColumnName("HCT0090025")
                .HasColumnOrder(87)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090025")
                .IsOptional();

            Property(p => p.HCT0090026)
                .HasColumnName("HCT0090026")
                .HasColumnOrder(88)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090026")
                .IsOptional();

            Property(p => p.HCT0090027)
                .HasColumnName("HCT0090027")
                .HasColumnOrder(89)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090027")
                .IsOptional();

            Property(p => p.HCT0090028)
                .HasColumnName("HCT0090028")
                .HasColumnOrder(90)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090028")
                .IsOptional();

            Property(p => p.HCT0090029)
                .HasColumnName("HCT0090029")
                .HasColumnOrder(91)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090029")
                .IsOptional();

            Property(p => p.HCT0090030)
                .HasColumnName("HCT0090030")
                .HasColumnOrder(92)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090030")
                .IsOptional();

            Property(p => p.HCT0090031)
                .HasColumnName("HCT0090031")
                .HasColumnOrder(93)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090031")
                .IsOptional();

            Property(p => p.HCT0090032)
                .HasColumnName("HCT0090032")
                .HasColumnOrder(94)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090032")
                .IsOptional();

            Property(p => p.HCT0090033)
                .HasColumnName("HCT0090033")
                .HasColumnOrder(95)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090033")
                .IsOptional();

            Property(p => p.HCT0090034)
                .HasColumnName("HCT0090034")
                .HasColumnOrder(96)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090034")
                .IsOptional();

            Property(p => p.HCT0090035)
                .HasColumnName("HCT0090035")
                .HasColumnOrder(97)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090035")
                .IsOptional();

            Property(p => p.HCT0090036)
                .HasColumnName("HCT0090036")
                .HasColumnOrder(98)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090036")
                .IsOptional();

            Property(p => p.HCT0090037)
                .HasColumnName("HCT0090037")
                .HasColumnOrder(99)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090037")
                .IsOptional();

            Property(p => p.HCT0090038)
                .HasColumnName("HCT0090038")
                .HasColumnOrder(100)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090038")
                .IsOptional();

            Property(p => p.HCT0090039)
                .HasColumnName("HCT0090039")
                .HasColumnOrder(101)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090039")
                .IsOptional();

            Property(p => p.HCT0090040)
                .HasColumnName("HCT0090040")
                .HasColumnOrder(102)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090040")
                .IsOptional();

            Property(p => p.HCT0090041)
                .HasColumnName("HCT0090041")
                .HasColumnOrder(103)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090041")
                .IsOptional();

            Property(p => p.HCT0090042)
                .HasColumnName("HCT0090042")
                .HasColumnOrder(104)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090042")
                .IsOptional();

            Property(p => p.HCT0090043)
                .HasColumnName("HCT0090043")
                .HasColumnOrder(105)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090043")
                .IsOptional();

            Property(p => p.HCT0090044)
                .HasColumnName("HCT0090044")
                .HasColumnOrder(106)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090044")
                .IsOptional();

            Property(p => p.HCT0090045)
                .HasColumnName("HCT0090045")
                .HasColumnOrder(107)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090045")
                .IsOptional();

            Property(p => p.HCT0090046)
                .HasColumnName("HCT0090046")
                .HasColumnOrder(108)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090046")
                .IsOptional();

            Property(p => p.HCT0090047)
                .HasColumnName("HCT0090047")
                .HasColumnOrder(109)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090047")
                .IsOptional();

            Property(p => p.HCT0090048)
                .HasColumnName("HCT0090048")
                .HasColumnOrder(110)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090048")
                .IsOptional();

            Property(p => p.HCT0090049)
                .HasColumnName("HCT0090049")
                .HasColumnOrder(111)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090049")
                .IsOptional();

            Property(p => p.HCT0090050)
                .HasColumnName("HCT0090050")
                .HasColumnOrder(112)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090050")
                .IsOptional();

            Property(p => p.HCT0090051)
                .HasColumnName("HCT0090051")
                .HasColumnOrder(113)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090051")
                .IsOptional();

            Property(p => p.HCT0090052)
                .HasColumnName("HCT0090052")
                .HasColumnOrder(114)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090052")
                .IsOptional();

            Property(p => p.HCT0090053)
                .HasColumnName("HCT0090053")
                .HasColumnOrder(115)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090053")
                .IsOptional();

            Property(p => p.HCT0090054)
                .HasColumnName("HCT0090054")
                .HasColumnOrder(116)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090054")
                .IsOptional();

            Property(p => p.HCT0090055)
                .HasColumnName("HCT0090055")
                .HasColumnOrder(117)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090055")
                .IsOptional();

            Property(p => p.HCT0090056)
                .HasColumnName("HCT0090056")
                .HasColumnOrder(118)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090056")
                .IsOptional();

            Property(p => p.HCT0090057)
                .HasColumnName("HCT0090057")
                .HasColumnOrder(119)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090057")
                .IsOptional();

            Property(p => p.HCT0090058)
                .HasColumnName("HCT0090058")
                .HasColumnOrder(120)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090058")
                .IsOptional();

            Property(p => p.HCT0090059)
                .HasColumnName("HCT0090059")
                .HasColumnOrder(121)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090059")
                .IsOptional();

            Property(p => p.HCT0090060)
                .HasColumnName("HCT0090060")
                .HasColumnOrder(122)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090060")
                .IsOptional();

            Property(p => p.HCT0090061)
                .HasColumnName("HCT0090061")
                .HasColumnOrder(123)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090061")
                .IsOptional();

            Property(p => p.HCT0090062)
                .HasColumnName("HCT0090062")
                .HasColumnOrder(124)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090062")
                .IsOptional();

            Property(p => p.HCT0090063)
                .HasColumnName("HCT0090063")
                .HasColumnOrder(125)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090063")
                .IsOptional();

            Property(p => p.HCT0090064)
                .HasColumnName("HCT0090064")
                .HasColumnOrder(126)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090064")
                .IsOptional();

            Property(p => p.HCT0090065)
                .HasColumnName("HCT0090065")
                .HasColumnOrder(127)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090065")
                .IsOptional();

            Property(p => p.HCT0090066)
                .HasColumnName("HCT0090066")
                .HasColumnOrder(128)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090066")
                .IsOptional();

            Property(p => p.HCT0090067)
                .HasColumnName("HCT0090067")
                .HasColumnOrder(129)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090067")
                .IsOptional();

            Property(p => p.HCT0090068)
                .HasColumnName("HCT0090068")
                .HasColumnOrder(130)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090068")
                .IsOptional();

            Property(p => p.HCT0090069)
                .HasColumnName("HCT0090069")
                .HasColumnOrder(131)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0090069")
                .IsOptional();

            Property(p => p.HCT0100001)
                .HasColumnName("HCT0100001")
                .HasColumnOrder(132)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0100001")
                .IsOptional();

            Property(p => p.HCT0100002)
                .HasColumnName("HCT0100002")
                .HasColumnOrder(133)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0100002")
                .IsOptional();

            Property(p => p.HCT0100003)
                .HasColumnName("HCT0100003")
                .HasColumnOrder(134)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0100003")
                .IsOptional();

            Property(p => p.HCT0100004)
                .HasColumnName("HCT0100004")
                .HasColumnOrder(135)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0100004")
                .IsOptional();

            Property(p => p.HCT0100005)
                .HasColumnName("HCT0100005")
                .HasColumnOrder(136)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0100005")
                .IsOptional();

            Property(p => p.HCT0100006)
                .HasColumnName("HCT0100006")
                .HasColumnOrder(137)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0100006")
                .IsOptional();

            Property(p => p.HCT0100007)
                .HasColumnName("HCT0100007")
                .HasColumnOrder(138)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0100007")
                .IsOptional();

            Property(p => p.HCT0100008)
                .HasColumnName("HCT0100008")
                .HasColumnOrder(139)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0100008")
                .IsOptional();

            Property(p => p.HCT0100009)
                .HasColumnName("HCT0100009")
                .HasColumnOrder(140)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0100009")
                .IsOptional();

            Property(p => p.HCT0100010)
                .HasColumnName("HCT0100010")
                .HasColumnOrder(141)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0100010")
                .IsOptional();

            Property(p => p.HCT0100011)
                .HasColumnName("HCT0100011")
                .HasColumnOrder(142)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0100011")
                .IsOptional();

            Property(p => p.HCT0100012)
                .HasColumnName("HCT0100012")
                .HasColumnOrder(143)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0100012")
                .IsOptional();

            Property(p => p.HCT0100013)
                .HasColumnName("HCT0100013")
                .HasColumnOrder(144)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0100013")
                .IsOptional();

            Property(p => p.HCT0110001)
                .HasColumnName("HCT0110001")
                .HasColumnOrder(145)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0110001")
                .IsOptional();

            Property(p => p.HCT0110002)
                .HasColumnName("HCT0110002")
                .HasColumnOrder(146)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0110002")
                .IsOptional();

            Property(p => p.HCT0110003)
                .HasColumnName("HCT0110003")
                .HasColumnOrder(147)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0110003")
                .IsOptional();

            Property(p => p.HCT0110004)
                .HasColumnName("HCT0110004")
                .HasColumnOrder(148)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0110004")
                .IsOptional();

            Property(p => p.HCT0110005)
                .HasColumnName("HCT0110005")
                .HasColumnOrder(149)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0110005")
                .IsOptional();

            Property(p => p.HCT0110006)
                .HasColumnName("HCT0110006")
                .HasColumnOrder(150)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0110006")
                .IsOptional();

            Property(p => p.HCT0110007)
                .HasColumnName("HCT0110007")
                .HasColumnOrder(151)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0110007")
                .IsOptional();

            Property(p => p.HCT0110008)
                .HasColumnName("HCT0110008")
                .HasColumnOrder(152)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0110008")
                .IsOptional();

            Property(p => p.HCT0110009)
                .HasColumnName("HCT0110009")
                .HasColumnOrder(153)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0110009")
                .IsOptional();

            Property(p => p.HCT0110010)
                .HasColumnName("HCT0110010")
                .HasColumnOrder(154)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0110010")
                .IsOptional();

            Property(p => p.HCT0110011)
                .HasColumnName("HCT0110011")
                .HasColumnOrder(155)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0110011")
                .IsOptional();

            Property(p => p.HCT0110012)
                .HasColumnName("HCT0110012")
                .HasColumnOrder(156)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0110012")
                .IsOptional();

            Property(p => p.HCT0110013)
                .HasColumnName("HCT0110013")
                .HasColumnOrder(157)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0110013")
                .IsOptional();

            Property(p => p.HCT0120001)
                .HasColumnName("HCT0120001")
                .HasColumnOrder(158)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0120001")
                .IsOptional();

            Property(p => p.HCT0120002)
                .HasColumnName("HCT0120002")
                .HasColumnOrder(159)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0120002")
                .IsOptional();

            Property(p => p.HCT0120003)
                .HasColumnName("HCT0120003")
                .HasColumnOrder(160)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0120003")
                .IsOptional();

            Property(p => p.HCT0120004)
                .HasColumnName("HCT0120004")
                .HasColumnOrder(161)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0120004")
                .IsOptional();

            Property(p => p.HCT0120005)
                .HasColumnName("HCT0120005")
                .HasColumnOrder(162)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0120005")
                .IsOptional();

            Property(p => p.HCT0120006)
                .HasColumnName("HCT0120006")
                .HasColumnOrder(163)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0120006")
                .IsOptional();

            Property(p => p.HCT0120007)
                .HasColumnName("HCT0120007")
                .HasColumnOrder(164)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0120007")
                .IsOptional();

            Property(p => p.HCT0120008)
                .HasColumnName("HCT0120008")
                .HasColumnOrder(165)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0120008")
                .IsOptional();

            Property(p => p.HCT0120009)
                .HasColumnName("HCT0120009")
                .HasColumnOrder(166)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0120009")
                .IsOptional();

            Property(p => p.HCT0120010)
                .HasColumnName("HCT0120010")
                .HasColumnOrder(167)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0120010")
                .IsOptional();

            Property(p => p.HCT0120011)
                .HasColumnName("HCT0120011")
                .HasColumnOrder(168)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0120011")
                .IsOptional();

            Property(p => p.HCT0120012)
                .HasColumnName("HCT0120012")
                .HasColumnOrder(169)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0120012")
                .IsOptional();

            Property(p => p.HCT0120013)
                .HasColumnName("HCT0120013")
                .HasColumnOrder(170)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0120013")
                .IsOptional();

            Property(p => p.HCT0130001)
                .HasColumnName("HCT0130001")
                .HasColumnOrder(171)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0130001")
                .IsOptional();

            Property(p => p.HCT0130002)
                .HasColumnName("HCT0130002")
                .HasColumnOrder(172)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0130002")
                .IsOptional();

            Property(p => p.HCT0130003)
                .HasColumnName("HCT0130003")
                .HasColumnOrder(173)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0130003")
                .IsOptional();

            Property(p => p.HCT0140001)
                .HasColumnName("HCT0140001")
                .HasColumnOrder(174)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0140001")
                .IsOptional();

            Property(p => p.HCT0140002)
                .HasColumnName("HCT0140002")
                .HasColumnOrder(175)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0140002")
                .IsOptional();

            Property(p => p.HCT0140003)
                .HasColumnName("HCT0140003")
                .HasColumnOrder(176)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("HCT0140003")
                .IsOptional();
        }
    }
}
