#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/31/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: DemographicProfile_Part1Map.cs
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

    public class DemographicProfile_Part1Map : EntityTypeConfiguration<DemographicProfile_Part1>
    {
        public DemographicProfile_Part1Map()
        {
            ToTable("Part1", "DemographicProfile");

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
                .HasMaxLength(6)
                .HasParameterName("FILEID")
                .IsRequired();

            Property(p => p.STUSAB)
                .HasColumnName("STUSAB")
                .HasColumnOrder(1)
                .HasColumnType("NVARCHAR")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasMaxLength(2)
                .HasParameterName("STUSAB")
                .IsRequired();

            Property(p => p.CHARITER)
                .HasColumnName("CHARITER")
                .HasColumnOrder(2)
                .HasColumnType("NVARCHAR")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasMaxLength(3)
                .HasParameterName("CHARITER")
                .IsRequired();

            Property(p => p.CIFSN)
                .HasColumnName("CIFSN")
                .HasColumnOrder(3)
                .HasColumnType("NVARCHAR")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasMaxLength(2)
                .HasParameterName("CIFSN")
                .IsRequired();

            Property(p => p.LOGRECNO)
                .HasColumnName("LOGRECNO")
                .HasColumnOrder(4)
                .HasColumnType("NVARCHAR")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasMaxLength(7)
                .HasParameterName("LOGRECNO")
                .IsRequired();

            Property(p => p.DPSF0010001)
                .HasColumnName("DPSF0010001")
                .HasColumnOrder(5)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010001")
                .IsOptional();

            Property(p => p.DPSF0010002)
                .HasColumnName("DPSF0010002")
                .HasColumnOrder(6)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010002")
                .IsOptional();

            Property(p => p.DPSF0010003)
                .HasColumnName("DPSF0010003")
                .HasColumnOrder(7)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010003")
                .IsOptional();

            Property(p => p.DPSF0010004)
                .HasColumnName("DPSF0010004")
                .HasColumnOrder(8)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010004")
                .IsOptional();

            Property(p => p.DPSF0010005)
                .HasColumnName("DPSF0010005")
                .HasColumnOrder(9)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010005")
                .IsOptional();

            Property(p => p.DPSF0010006)
                .HasColumnName("DPSF0010006")
                .HasColumnOrder(10)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010006")
                .IsOptional();

            Property(p => p.DPSF0010007)
                .HasColumnName("DPSF0010007")
                .HasColumnOrder(11)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010007")
                .IsOptional();

            Property(p => p.DPSF0010008)
                .HasColumnName("DPSF0010008")
                .HasColumnOrder(12)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010008")
                .IsOptional();

            Property(p => p.DPSF0010009)
                .HasColumnName("DPSF0010009")
                .HasColumnOrder(13)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010009")
                .IsOptional();

            Property(p => p.DPSF0010010)
                .HasColumnName("DPSF0010010")
                .HasColumnOrder(14)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010010")
                .IsOptional();

            Property(p => p.DPSF0010011)
                .HasColumnName("DPSF0010011")
                .HasColumnOrder(15)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010011")
                .IsOptional();

            Property(p => p.DPSF0010012)
                .HasColumnName("DPSF0010012")
                .HasColumnOrder(16)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010012")
                .IsOptional();

            Property(p => p.DPSF0010013)
                .HasColumnName("DPSF0010013")
                .HasColumnOrder(17)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010013")
                .IsOptional();

            Property(p => p.DPSF0010014)
                .HasColumnName("DPSF0010014")
                .HasColumnOrder(18)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010014")
                .IsOptional();

            Property(p => p.DPSF0010015)
                .HasColumnName("DPSF0010015")
                .HasColumnOrder(19)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010015")
                .IsOptional();

            Property(p => p.DPSF0010016)
                .HasColumnName("DPSF0010016")
                .HasColumnOrder(20)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010016")
                .IsOptional();

            Property(p => p.DPSF0010017)
                .HasColumnName("DPSF0010017")
                .HasColumnOrder(21)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010017")
                .IsOptional();

            Property(p => p.DPSF0010018)
                .HasColumnName("DPSF0010018")
                .HasColumnOrder(22)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010018")
                .IsOptional();

            Property(p => p.DPSF0010019)
                .HasColumnName("DPSF0010019")
                .HasColumnOrder(23)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010019")
                .IsOptional();

            Property(p => p.DPSF0010020)
                .HasColumnName("DPSF0010020")
                .HasColumnOrder(24)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010020")
                .IsOptional();

            Property(p => p.DPSF0010021)
                .HasColumnName("DPSF0010021")
                .HasColumnOrder(25)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010021")
                .IsOptional();

            Property(p => p.DPSF0010022)
                .HasColumnName("DPSF0010022")
                .HasColumnOrder(26)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010022")
                .IsOptional();

            Property(p => p.DPSF0010023)
                .HasColumnName("DPSF0010023")
                .HasColumnOrder(27)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010023")
                .IsOptional();

            Property(p => p.DPSF0010024)
                .HasColumnName("DPSF0010024")
                .HasColumnOrder(28)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010024")
                .IsOptional();

            Property(p => p.DPSF0010025)
                .HasColumnName("DPSF0010025")
                .HasColumnOrder(29)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010025")
                .IsOptional();

            Property(p => p.DPSF0010026)
                .HasColumnName("DPSF0010026")
                .HasColumnOrder(30)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010026")
                .IsOptional();

            Property(p => p.DPSF0010027)
                .HasColumnName("DPSF0010027")
                .HasColumnOrder(31)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010027")
                .IsOptional();

            Property(p => p.DPSF0010028)
                .HasColumnName("DPSF0010028")
                .HasColumnOrder(32)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010028")
                .IsOptional();

            Property(p => p.DPSF0010029)
                .HasColumnName("DPSF0010029")
                .HasColumnOrder(33)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010029")
                .IsOptional();

            Property(p => p.DPSF0010030)
                .HasColumnName("DPSF0010030")
                .HasColumnOrder(34)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010030")
                .IsOptional();

            Property(p => p.DPSF0010031)
                .HasColumnName("DPSF0010031")
                .HasColumnOrder(35)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010031")
                .IsOptional();

            Property(p => p.DPSF0010032)
                .HasColumnName("DPSF0010032")
                .HasColumnOrder(36)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010032")
                .IsOptional();

            Property(p => p.DPSF0010033)
                .HasColumnName("DPSF0010033")
                .HasColumnOrder(37)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010033")
                .IsOptional();

            Property(p => p.DPSF0010034)
                .HasColumnName("DPSF0010034")
                .HasColumnOrder(38)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010034")
                .IsOptional();

            Property(p => p.DPSF0010035)
                .HasColumnName("DPSF0010035")
                .HasColumnOrder(39)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010035")
                .IsOptional();

            Property(p => p.DPSF0010036)
                .HasColumnName("DPSF0010036")
                .HasColumnOrder(40)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010036")
                .IsOptional();

            Property(p => p.DPSF0010037)
                .HasColumnName("DPSF0010037")
                .HasColumnOrder(41)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010037")
                .IsOptional();

            Property(p => p.DPSF0010038)
                .HasColumnName("DPSF0010038")
                .HasColumnOrder(42)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010038")
                .IsOptional();

            Property(p => p.DPSF0010039)
                .HasColumnName("DPSF0010039")
                .HasColumnOrder(43)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010039")
                .IsOptional();

            Property(p => p.DPSF0010040)
                .HasColumnName("DPSF0010040")
                .HasColumnOrder(44)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010040")
                .IsOptional();

            Property(p => p.DPSF0010041)
                .HasColumnName("DPSF0010041")
                .HasColumnOrder(45)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010041")
                .IsOptional();

            Property(p => p.DPSF0010042)
                .HasColumnName("DPSF0010042")
                .HasColumnOrder(46)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010042")
                .IsOptional();

            Property(p => p.DPSF0010043)
                .HasColumnName("DPSF0010043")
                .HasColumnOrder(47)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010043")
                .IsOptional();

            Property(p => p.DPSF0010044)
                .HasColumnName("DPSF0010044")
                .HasColumnOrder(48)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010044")
                .IsOptional();

            Property(p => p.DPSF0010045)
                .HasColumnName("DPSF0010045")
                .HasColumnOrder(49)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010045")
                .IsOptional();

            Property(p => p.DPSF0010046)
                .HasColumnName("DPSF0010046")
                .HasColumnOrder(50)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010046")
                .IsOptional();

            Property(p => p.DPSF0010047)
                .HasColumnName("DPSF0010047")
                .HasColumnOrder(51)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010047")
                .IsOptional();

            Property(p => p.DPSF0010048)
                .HasColumnName("DPSF0010048")
                .HasColumnOrder(52)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010048")
                .IsOptional();

            Property(p => p.DPSF0010049)
                .HasColumnName("DPSF0010049")
                .HasColumnOrder(53)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010049")
                .IsOptional();

            Property(p => p.DPSF0010050)
                .HasColumnName("DPSF0010050")
                .HasColumnOrder(54)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010050")
                .IsOptional();

            Property(p => p.DPSF0010051)
                .HasColumnName("DPSF0010051")
                .HasColumnOrder(55)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010051")
                .IsOptional();

            Property(p => p.DPSF0010052)
                .HasColumnName("DPSF0010052")
                .HasColumnOrder(56)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010052")
                .IsOptional();

            Property(p => p.DPSF0010053)
                .HasColumnName("DPSF0010053")
                .HasColumnOrder(57)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010053")
                .IsOptional();

            Property(p => p.DPSF0010054)
                .HasColumnName("DPSF0010054")
                .HasColumnOrder(58)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010054")
                .IsOptional();

            Property(p => p.DPSF0010055)
                .HasColumnName("DPSF0010055")
                .HasColumnOrder(59)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010055")
                .IsOptional();

            Property(p => p.DPSF0010056)
                .HasColumnName("DPSF0010056")
                .HasColumnOrder(60)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010056")
                .IsOptional();

            Property(p => p.DPSF0010057)
                .HasColumnName("DPSF0010057")
                .HasColumnOrder(61)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0010057")
                .IsOptional();

            Property(p => p.DPSF0020001)
                .HasColumnName("DPSF0020001")
                .HasColumnOrder(62)
                .HasColumnType("DECIMAL")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0020001")
                .IsOptional();

            Property(p => p.DPSF0020002)
                .HasColumnName("DPSF0020002")
                .HasColumnOrder(63)
                .HasColumnType("DECIMAL")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0020002")
                .IsOptional();

            Property(p => p.DPSF0020003)
                .HasColumnName("DPSF0020003")
                .HasColumnOrder(64)
                .HasColumnType("DECIMAL")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0020003")
                .IsOptional();

            Property(p => p.DPSF0030001)
                .HasColumnName("DPSF0030001")
                .HasColumnOrder(65)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0030001")
                .IsOptional();

            Property(p => p.DPSF0030002)
                .HasColumnName("DPSF0030002")
                .HasColumnOrder(66)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0030002")
                .IsOptional();

            Property(p => p.DPSF0030003)
                .HasColumnName("DPSF0030003")
                .HasColumnOrder(67)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0030003")
                .IsOptional();

            Property(p => p.DPSF0040001)
                .HasColumnName("DPSF0040001")
                .HasColumnOrder(68)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0040001")
                .IsOptional();

            Property(p => p.DPSF0040002)
                .HasColumnName("DPSF0040002")
                .HasColumnOrder(69)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0040002")
                .IsOptional();

            Property(p => p.DPSF0040003)
                .HasColumnName("DPSF0040003")
                .HasColumnOrder(70)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0040003")
                .IsOptional();

            Property(p => p.DPSF0050001)
                .HasColumnName("DPSF0050001")
                .HasColumnOrder(71)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0050001")
                .IsOptional();

            Property(p => p.DPSF0050002)
                .HasColumnName("DPSF0050002")
                .HasColumnOrder(72)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0050002")
                .IsOptional();

            Property(p => p.DPSF0050003)
                .HasColumnName("DPSF0050003")
                .HasColumnOrder(73)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0050003")
                .IsOptional();

            Property(p => p.DPSF0060001)
                .HasColumnName("DPSF0060001")
                .HasColumnOrder(74)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0060001")
                .IsOptional();

            Property(p => p.DPSF0060002)
                .HasColumnName("DPSF0060002")
                .HasColumnOrder(75)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0060002")
                .IsOptional();

            Property(p => p.DPSF0060003)
                .HasColumnName("DPSF0060003")
                .HasColumnOrder(76)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0060003")
                .IsOptional();

            Property(p => p.DPSF0070001)
                .HasColumnName("DPSF0070001")
                .HasColumnOrder(77)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0070001")
                .IsOptional();

            Property(p => p.DPSF0070002)
                .HasColumnName("DPSF0070002")
                .HasColumnOrder(78)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0070002")
                .IsOptional();

            Property(p => p.DPSF0070003)
                .HasColumnName("DPSF0070003")
                .HasColumnOrder(79)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0070003")
                .IsOptional();

            Property(p => p.DPSF0080001)
                .HasColumnName("DPSF0080001")
                .HasColumnOrder(80)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0080001")
                .IsOptional();

            Property(p => p.DPSF0080002)
                .HasColumnName("DPSF0080002")
                .HasColumnOrder(81)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0080002")
                .IsOptional();

            Property(p => p.DPSF0080003)
                .HasColumnName("DPSF0080003")
                .HasColumnOrder(82)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0080003")
                .IsOptional();

            Property(p => p.DPSF0080004)
                .HasColumnName("DPSF0080004")
                .HasColumnOrder(83)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0080004")
                .IsOptional();

            Property(p => p.DPSF0080005)
                .HasColumnName("DPSF0080005")
                .HasColumnOrder(84)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0080005")
                .IsOptional();

            Property(p => p.DPSF0080006)
                .HasColumnName("DPSF0080006")
                .HasColumnOrder(85)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0080006")
                .IsOptional();

            Property(p => p.DPSF0080007)
                .HasColumnName("DPSF0080007")
                .HasColumnOrder(86)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0080007")
                .IsOptional();

            Property(p => p.DPSF0080008)
                .HasColumnName("DPSF0080008")
                .HasColumnOrder(87)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0080008")
                .IsOptional();

            Property(p => p.DPSF0080009)
                .HasColumnName("DPSF0080009")
                .HasColumnOrder(88)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0080009")
                .IsOptional();

            Property(p => p.DPSF0080010)
                .HasColumnName("DPSF0080010")
                .HasColumnOrder(89)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0080010")
                .IsOptional();

            Property(p => p.DPSF0080011)
                .HasColumnName("DPSF0080011")
                .HasColumnOrder(90)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0080011")
                .IsOptional();

            Property(p => p.DPSF0080012)
                .HasColumnName("DPSF0080012")
                .HasColumnOrder(91)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0080012")
                .IsOptional();

            Property(p => p.DPSF0080013)
                .HasColumnName("DPSF0080013")
                .HasColumnOrder(92)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0080013")
                .IsOptional();

            Property(p => p.DPSF0080014)
                .HasColumnName("DPSF0080014")
                .HasColumnOrder(93)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0080014")
                .IsOptional();

            Property(p => p.DPSF0080015)
                .HasColumnName("DPSF0080015")
                .HasColumnOrder(94)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0080015")
                .IsOptional();

            Property(p => p.DPSF0080016)
                .HasColumnName("DPSF0080016")
                .HasColumnOrder(95)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0080016")
                .IsOptional();

            Property(p => p.DPSF0080017)
                .HasColumnName("DPSF0080017")
                .HasColumnOrder(96)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0080017")
                .IsOptional();

            Property(p => p.DPSF0080018)
                .HasColumnName("DPSF0080018")
                .HasColumnOrder(97)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0080018")
                .IsOptional();

            Property(p => p.DPSF0080019)
                .HasColumnName("DPSF0080019")
                .HasColumnOrder(98)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0080019")
                .IsOptional();

            Property(p => p.DPSF0080020)
                .HasColumnName("DPSF0080020")
                .HasColumnOrder(99)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0080020")
                .IsOptional();

            Property(p => p.DPSF0080021)
                .HasColumnName("DPSF0080021")
                .HasColumnOrder(100)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0080021")
                .IsOptional();

            Property(p => p.DPSF0080022)
                .HasColumnName("DPSF0080022")
                .HasColumnOrder(101)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0080022")
                .IsOptional();

            Property(p => p.DPSF0080023)
                .HasColumnName("DPSF0080023")
                .HasColumnOrder(102)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0080023")
                .IsOptional();

            Property(p => p.DPSF0080024)
                .HasColumnName("DPSF0080024")
                .HasColumnOrder(103)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0080024")
                .IsOptional();

            Property(p => p.DPSF0090001)
                .HasColumnName("DPSF0090001")
                .HasColumnOrder(104)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0090001")
                .IsOptional();

            Property(p => p.DPSF0090002)
                .HasColumnName("DPSF0090002")
                .HasColumnOrder(105)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0090002")
                .IsOptional();

            Property(p => p.DPSF0090003)
                .HasColumnName("DPSF0090003")
                .HasColumnOrder(106)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0090003")
                .IsOptional();

            Property(p => p.DPSF0090004)
                .HasColumnName("DPSF0090004")
                .HasColumnOrder(107)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0090004")
                .IsOptional();

            Property(p => p.DPSF0090005)
                .HasColumnName("DPSF0090005")
                .HasColumnOrder(108)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0090005")
                .IsOptional();

            Property(p => p.DPSF0090006)
                .HasColumnName("DPSF0090006")
                .HasColumnOrder(109)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0090006")
                .IsOptional();

            Property(p => p.DPSF0100001)
                .HasColumnName("DPSF0100001")
                .HasColumnOrder(110)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0100001")
                .IsOptional();

            Property(p => p.DPSF0100002)
                .HasColumnName("DPSF0100002")
                .HasColumnOrder(111)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0100002")
                .IsOptional();

            Property(p => p.DPSF0100003)
                .HasColumnName("DPSF0100003")
                .HasColumnOrder(112)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0100003")
                .IsOptional();

            Property(p => p.DPSF0100004)
                .HasColumnName("DPSF0100004")
                .HasColumnOrder(113)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0100004")
                .IsOptional();

            Property(p => p.DPSF0100005)
                .HasColumnName("DPSF0100005")
                .HasColumnOrder(114)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0100005")
                .IsOptional();

            Property(p => p.DPSF0100006)
                .HasColumnName("DPSF0100006")
                .HasColumnOrder(115)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0100006")
                .IsOptional();

            Property(p => p.DPSF0100007)
                .HasColumnName("DPSF0100007")
                .HasColumnOrder(116)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0100007")
                .IsOptional();

            Property(p => p.DPSF0110001)
                .HasColumnName("DPSF0110001")
                .HasColumnOrder(117)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0110001")
                .IsOptional();

            Property(p => p.DPSF0110002)
                .HasColumnName("DPSF0110002")
                .HasColumnOrder(118)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0110002")
                .IsOptional();

            Property(p => p.DPSF0110003)
                .HasColumnName("DPSF0110003")
                .HasColumnOrder(119)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0110003")
                .IsOptional();

            Property(p => p.DPSF0110004)
                .HasColumnName("DPSF0110004")
                .HasColumnOrder(120)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0110004")
                .IsOptional();

            Property(p => p.DPSF0110005)
                .HasColumnName("DPSF0110005")
                .HasColumnOrder(121)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0110005")
                .IsOptional();

            Property(p => p.DPSF0110006)
                .HasColumnName("DPSF0110006")
                .HasColumnOrder(122)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0110006")
                .IsOptional();

            Property(p => p.DPSF0110007)
                .HasColumnName("DPSF0110007")
                .HasColumnOrder(123)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0110007")
                .IsOptional();

            Property(p => p.DPSF0110008)
                .HasColumnName("DPSF0110008")
                .HasColumnOrder(124)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0110008")
                .IsOptional();

            Property(p => p.DPSF0110009)
                .HasColumnName("DPSF0110009")
                .HasColumnOrder(125)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0110009")
                .IsOptional();

            Property(p => p.DPSF0110010)
                .HasColumnName("DPSF0110010")
                .HasColumnOrder(126)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0110010")
                .IsOptional();

            Property(p => p.DPSF0110011)
                .HasColumnName("DPSF0110011")
                .HasColumnOrder(127)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0110011")
                .IsOptional();

            Property(p => p.DPSF0110012)
                .HasColumnName("DPSF0110012")
                .HasColumnOrder(128)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0110012")
                .IsOptional();

            Property(p => p.DPSF0110013)
                .HasColumnName("DPSF0110013")
                .HasColumnOrder(129)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0110013")
                .IsOptional();

            Property(p => p.DPSF0110014)
                .HasColumnName("DPSF0110014")
                .HasColumnOrder(130)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0110014")
                .IsOptional();

            Property(p => p.DPSF0110015)
                .HasColumnName("DPSF0110015")
                .HasColumnOrder(131)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0110015")
                .IsOptional();

            Property(p => p.DPSF0110016)
                .HasColumnName("DPSF0110016")
                .HasColumnOrder(132)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0110016")
                .IsOptional();

            Property(p => p.DPSF0110017)
                .HasColumnName("DPSF0110017")
                .HasColumnOrder(133)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0110017")
                .IsOptional();

            Property(p => p.DPSF0120001)
                .HasColumnName("DPSF0120001")
                .HasColumnOrder(134)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0120001")
                .IsOptional();

            Property(p => p.DPSF0120002)
                .HasColumnName("DPSF0120002")
                .HasColumnOrder(135)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0120002")
                .IsOptional();

            Property(p => p.DPSF0120003)
                .HasColumnName("DPSF0120003")
                .HasColumnOrder(136)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0120003")
                .IsOptional();

            Property(p => p.DPSF0120004)
                .HasColumnName("DPSF0120004")
                .HasColumnOrder(137)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0120004")
                .IsOptional();

            Property(p => p.DPSF0120005)
                .HasColumnName("DPSF0120005")
                .HasColumnOrder(138)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0120005")
                .IsOptional();

            Property(p => p.DPSF0120006)
                .HasColumnName("DPSF0120006")
                .HasColumnOrder(139)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0120006")
                .IsOptional();

            Property(p => p.DPSF0120007)
                .HasColumnName("DPSF0120007")
                .HasColumnOrder(140)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0120007")
                .IsOptional();

            Property(p => p.DPSF0120008)
                .HasColumnName("DPSF0120008")
                .HasColumnOrder(141)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0120008")
                .IsOptional();

            Property(p => p.DPSF0120009)
                .HasColumnName("DPSF0120009")
                .HasColumnOrder(142)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0120009")
                .IsOptional();

            Property(p => p.DPSF0120010)
                .HasColumnName("DPSF0120010")
                .HasColumnOrder(143)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0120010")
                .IsOptional();

            Property(p => p.DPSF0120011)
                .HasColumnName("DPSF0120011")
                .HasColumnOrder(144)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0120011")
                .IsOptional();

            Property(p => p.DPSF0120012)
                .HasColumnName("DPSF0120012")
                .HasColumnOrder(145)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0120012")
                .IsOptional();

            Property(p => p.DPSF0120013)
                .HasColumnName("DPSF0120013")
                .HasColumnOrder(146)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0120013")
                .IsOptional();

            Property(p => p.DPSF0120014)
                .HasColumnName("DPSF0120014")
                .HasColumnOrder(147)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0120014")
                .IsOptional();

            Property(p => p.DPSF0120015)
                .HasColumnName("DPSF0120015")
                .HasColumnOrder(148)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0120015")
                .IsOptional();

            Property(p => p.DPSF0120016)
                .HasColumnName("DPSF0120016")
                .HasColumnOrder(149)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0120016")
                .IsOptional();

            Property(p => p.DPSF0120017)
                .HasColumnName("DPSF0120017")
                .HasColumnOrder(150)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0120017")
                .IsOptional();

            Property(p => p.DPSF0120018)
                .HasColumnName("DPSF0120018")
                .HasColumnOrder(151)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0120018")
                .IsOptional();

            Property(p => p.DPSF0120019)
                .HasColumnName("DPSF0120019")
                .HasColumnOrder(152)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0120019")
                .IsOptional();

            Property(p => p.DPSF0120020)
                .HasColumnName("DPSF0120020")
                .HasColumnOrder(153)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0120020")
                .IsOptional();

            Property(p => p.DPSF0130001)
                .HasColumnName("DPSF0130001")
                .HasColumnOrder(154)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0130001")
                .IsOptional();

            Property(p => p.DPSF0130002)
                .HasColumnName("DPSF0130002")
                .HasColumnOrder(155)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0130002")
                .IsOptional();

            Property(p => p.DPSF0130003)
                .HasColumnName("DPSF0130003")
                .HasColumnOrder(156)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0130003")
                .IsOptional();

            Property(p => p.DPSF0130004)
                .HasColumnName("DPSF0130004")
                .HasColumnOrder(157)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0130004")
                .IsOptional();

            Property(p => p.DPSF0130005)
                .HasColumnName("DPSF0130005")
                .HasColumnOrder(158)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0130005")
                .IsOptional();

            Property(p => p.DPSF0130006)
                .HasColumnName("DPSF0130006")
                .HasColumnOrder(159)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0130006")
                .IsOptional();

            Property(p => p.DPSF0130007)
                .HasColumnName("DPSF0130007")
                .HasColumnOrder(160)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0130007")
                .IsOptional();

            Property(p => p.DPSF0130008)
                .HasColumnName("DPSF0130008")
                .HasColumnOrder(161)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0130008")
                .IsOptional();

            Property(p => p.DPSF0130009)
                .HasColumnName("DPSF0130009")
                .HasColumnOrder(162)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0130009")
                .IsOptional();

            Property(p => p.DPSF0130010)
                .HasColumnName("DPSF0130010")
                .HasColumnOrder(163)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0130010")
                .IsOptional();

            Property(p => p.DPSF0130011)
                .HasColumnName("DPSF0130011")
                .HasColumnOrder(164)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0130011")
                .IsOptional();

            Property(p => p.DPSF0130012)
                .HasColumnName("DPSF0130012")
                .HasColumnOrder(165)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0130012")
                .IsOptional();

            Property(p => p.DPSF0130013)
                .HasColumnName("DPSF0130013")
                .HasColumnOrder(166)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0130013")
                .IsOptional();

            Property(p => p.DPSF0130014)
                .HasColumnName("DPSF0130014")
                .HasColumnOrder(167)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0130014")
                .IsOptional();

            Property(p => p.DPSF0130015)
                .HasColumnName("DPSF0130015")
                .HasColumnOrder(168)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0130015")
                .IsOptional();

            Property(p => p.DPSF0140001)
                .HasColumnName("DPSF0140001")
                .HasColumnOrder(169)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0140001")
                .IsOptional();

            Property(p => p.DPSF0150001)
                .HasColumnName("DPSF0150001")
                .HasColumnOrder(170)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0150001")
                .IsOptional();

            Property(p => p.DPSF0160001)
                .HasColumnName("DPSF0160001")
                .HasColumnOrder(171)
                .HasColumnType("DECIMAL")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0160001")
                .IsOptional();

            Property(p => p.DPSF0170001)
                .HasColumnName("DPSF0170001")
                .HasColumnOrder(172)
                .HasColumnType("DECIMAL")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0170001")
                .IsOptional();

            Property(p => p.DPSF0180001)
                .HasColumnName("DPSF0180001")
                .HasColumnOrder(173)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0180001")
                .IsOptional();

            Property(p => p.DPSF0180002)
                .HasColumnName("DPSF0180002")
                .HasColumnOrder(174)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0180002")
                .IsOptional();

            Property(p => p.DPSF0180003)
                .HasColumnName("DPSF0180003")
                .HasColumnOrder(175)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0180003")
                .IsOptional();

            Property(p => p.DPSF0180004)
                .HasColumnName("DPSF0180004")
                .HasColumnOrder(176)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0180004")
                .IsOptional();

            Property(p => p.DPSF0180005)
                .HasColumnName("DPSF0180005")
                .HasColumnOrder(177)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0180005")
                .IsOptional();

            Property(p => p.DPSF0180006)
                .HasColumnName("DPSF0180006")
                .HasColumnOrder(178)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0180006")
                .IsOptional();

            Property(p => p.DPSF0180007)
                .HasColumnName("DPSF0180007")
                .HasColumnOrder(179)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0180007")
                .IsOptional();

            Property(p => p.DPSF0180008)
                .HasColumnName("DPSF0180008")
                .HasColumnOrder(180)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0180008")
                .IsOptional();

            Property(p => p.DPSF0180009)
                .HasColumnName("DPSF0180009")
                .HasColumnOrder(181)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0180009")
                .IsOptional();

            Property(p => p.DPSF0190001)
                .HasColumnName("DPSF0190001")
                .HasColumnOrder(182)
                .HasColumnType("DECIMAL")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0190001")
                .IsOptional();

            Property(p => p.DPSF0200001)
                .HasColumnName("DPSF0200001")
                .HasColumnOrder(183)
                .HasColumnType("DECIMAL")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0200001")
                .IsOptional();

            Property(p => p.DPSF0210001)
                .HasColumnName("DPSF0210001")
                .HasColumnOrder(184)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0210001")
                .IsOptional();

            Property(p => p.DPSF0210002)
                .HasColumnName("DPSF0210002")
                .HasColumnOrder(185)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0210002")
                .IsOptional();

            Property(p => p.DPSF0210003)
                .HasColumnName("DPSF0210003")
                .HasColumnOrder(186)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0210003")
                .IsOptional();

            Property(p => p.DPSF0220001)
                .HasColumnName("DPSF0220001")
                .HasColumnOrder(187)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0220001")
                .IsOptional();

            Property(p => p.DPSF0220002)
                .HasColumnName("DPSF0220002")
                .HasColumnOrder(188)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0220002")
                .IsOptional();

            Property(p => p.DPSF0230001)
                .HasColumnName("DPSF0230001")
                .HasColumnOrder(189)
                .HasColumnType("DECIMAL")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0230001")
                .IsOptional();

            Property(p => p.DPSF0230002)
                .HasColumnName("DPSF0230002")
                .HasColumnOrder(190)
                .HasColumnType("DECIMAL")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("DPSF0230002")
                .IsOptional();
        }
    }
}
