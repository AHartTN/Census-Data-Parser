#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/06/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1CongressionalDistricts113_SF1_00015Map.cs
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

	public class SF1CongressionalDistricts113_SF1_00015Map : EntityTypeConfiguration<SF1CongressionalDistricts113_SF1_00015>
	{
		public SF1CongressionalDistricts113_SF1_00015Map()
		{
			ToTable("SF1_00015", "SF1CongressionalDistricts113");

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

			Property(p => p.PCT0010001)
				.HasColumnName("PCT0010001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010001")
				.IsOptional();

			Property(p => p.PCT0010002)
				.HasColumnName("PCT0010002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010002")
				.IsOptional();

			Property(p => p.PCT0010003)
				.HasColumnName("PCT0010003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010003")
				.IsOptional();

			Property(p => p.PCT0010004)
				.HasColumnName("PCT0010004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010004")
				.IsOptional();

			Property(p => p.PCT0010005)
				.HasColumnName("PCT0010005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010005")
				.IsOptional();

			Property(p => p.PCT0010006)
				.HasColumnName("PCT0010006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010006")
				.IsOptional();

			Property(p => p.PCT0010007)
				.HasColumnName("PCT0010007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010007")
				.IsOptional();

			Property(p => p.PCT0010008)
				.HasColumnName("PCT0010008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010008")
				.IsOptional();

			Property(p => p.PCT0010009)
				.HasColumnName("PCT0010009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010009")
				.IsOptional();

			Property(p => p.PCT0010010)
				.HasColumnName("PCT0010010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010010")
				.IsOptional();

			Property(p => p.PCT0010011)
				.HasColumnName("PCT0010011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010011")
				.IsOptional();

			Property(p => p.PCT0010012)
				.HasColumnName("PCT0010012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010012")
				.IsOptional();

			Property(p => p.PCT0010013)
				.HasColumnName("PCT0010013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010013")
				.IsOptional();

			Property(p => p.PCT0010014)
				.HasColumnName("PCT0010014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010014")
				.IsOptional();

			Property(p => p.PCT0010015)
				.HasColumnName("PCT0010015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010015")
				.IsOptional();

			Property(p => p.PCT0010016)
				.HasColumnName("PCT0010016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010016")
				.IsOptional();

			Property(p => p.PCT0010017)
				.HasColumnName("PCT0010017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010017")
				.IsOptional();

			Property(p => p.PCT0010018)
				.HasColumnName("PCT0010018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010018")
				.IsOptional();

			Property(p => p.PCT0010019)
				.HasColumnName("PCT0010019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010019")
				.IsOptional();

			Property(p => p.PCT0010020)
				.HasColumnName("PCT0010020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010020")
				.IsOptional();

			Property(p => p.PCT0010021)
				.HasColumnName("PCT0010021")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010021")
				.IsOptional();

			Property(p => p.PCT0010022)
				.HasColumnName("PCT0010022")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010022")
				.IsOptional();

			Property(p => p.PCT0010023)
				.HasColumnName("PCT0010023")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010023")
				.IsOptional();

			Property(p => p.PCT0010024)
				.HasColumnName("PCT0010024")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010024")
				.IsOptional();

			Property(p => p.PCT0010025)
				.HasColumnName("PCT0010025")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010025")
				.IsOptional();

			Property(p => p.PCT0010026)
				.HasColumnName("PCT0010026")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010026")
				.IsOptional();

			Property(p => p.PCT0010027)
				.HasColumnName("PCT0010027")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010027")
				.IsOptional();

			Property(p => p.PCT0010028)
				.HasColumnName("PCT0010028")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010028")
				.IsOptional();

			Property(p => p.PCT0010029)
				.HasColumnName("PCT0010029")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010029")
				.IsOptional();

			Property(p => p.PCT0010030)
				.HasColumnName("PCT0010030")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010030")
				.IsOptional();

			Property(p => p.PCT0010031)
				.HasColumnName("PCT0010031")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010031")
				.IsOptional();

			Property(p => p.PCT0010032)
				.HasColumnName("PCT0010032")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010032")
				.IsOptional();

			Property(p => p.PCT0010033)
				.HasColumnName("PCT0010033")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010033")
				.IsOptional();

			Property(p => p.PCT0010034)
				.HasColumnName("PCT0010034")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010034")
				.IsOptional();

			Property(p => p.PCT0010035)
				.HasColumnName("PCT0010035")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010035")
				.IsOptional();

			Property(p => p.PCT0010036)
				.HasColumnName("PCT0010036")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010036")
				.IsOptional();

			Property(p => p.PCT0010037)
				.HasColumnName("PCT0010037")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010037")
				.IsOptional();

			Property(p => p.PCT0010038)
				.HasColumnName("PCT0010038")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010038")
				.IsOptional();

			Property(p => p.PCT0010039)
				.HasColumnName("PCT0010039")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010039")
				.IsOptional();

			Property(p => p.PCT0010040)
				.HasColumnName("PCT0010040")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010040")
				.IsOptional();

			Property(p => p.PCT0010041)
				.HasColumnName("PCT0010041")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010041")
				.IsOptional();

			Property(p => p.PCT0010042)
				.HasColumnName("PCT0010042")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010042")
				.IsOptional();

			Property(p => p.PCT0010043)
				.HasColumnName("PCT0010043")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010043")
				.IsOptional();

			Property(p => p.PCT0010044)
				.HasColumnName("PCT0010044")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010044")
				.IsOptional();

			Property(p => p.PCT0010045)
				.HasColumnName("PCT0010045")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010045")
				.IsOptional();

			Property(p => p.PCT0010046)
				.HasColumnName("PCT0010046")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010046")
				.IsOptional();

			Property(p => p.PCT0010047)
				.HasColumnName("PCT0010047")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010047")
				.IsOptional();

			Property(p => p.PCT0010048)
				.HasColumnName("PCT0010048")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010048")
				.IsOptional();

			Property(p => p.PCT0010049)
				.HasColumnName("PCT0010049")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010049")
				.IsOptional();

			Property(p => p.PCT0010050)
				.HasColumnName("PCT0010050")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010050")
				.IsOptional();

			Property(p => p.PCT0010051)
				.HasColumnName("PCT0010051")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010051")
				.IsOptional();

			Property(p => p.PCT0010052)
				.HasColumnName("PCT0010052")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010052")
				.IsOptional();

			Property(p => p.PCT0010053)
				.HasColumnName("PCT0010053")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010053")
				.IsOptional();

			Property(p => p.PCT0010054)
				.HasColumnName("PCT0010054")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0010054")
				.IsOptional();

			Property(p => p.PCT0020001)
				.HasColumnName("PCT0020001")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020001")
				.IsOptional();

			Property(p => p.PCT0020002)
				.HasColumnName("PCT0020002")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020002")
				.IsOptional();

			Property(p => p.PCT0020003)
				.HasColumnName("PCT0020003")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020003")
				.IsOptional();

			Property(p => p.PCT0020004)
				.HasColumnName("PCT0020004")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020004")
				.IsOptional();

			Property(p => p.PCT0020005)
				.HasColumnName("PCT0020005")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020005")
				.IsOptional();

			Property(p => p.PCT0020006)
				.HasColumnName("PCT0020006")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020006")
				.IsOptional();

			Property(p => p.PCT0020007)
				.HasColumnName("PCT0020007")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020007")
				.IsOptional();

			Property(p => p.PCT0020008)
				.HasColumnName("PCT0020008")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020008")
				.IsOptional();

			Property(p => p.PCT0020009)
				.HasColumnName("PCT0020009")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020009")
				.IsOptional();

			Property(p => p.PCT0020010)
				.HasColumnName("PCT0020010")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020010")
				.IsOptional();

			Property(p => p.PCT0020011)
				.HasColumnName("PCT0020011")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020011")
				.IsOptional();

			Property(p => p.PCT0020012)
				.HasColumnName("PCT0020012")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020012")
				.IsOptional();

			Property(p => p.PCT0020013)
				.HasColumnName("PCT0020013")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020013")
				.IsOptional();

			Property(p => p.PCT0020014)
				.HasColumnName("PCT0020014")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020014")
				.IsOptional();

			Property(p => p.PCT0020015)
				.HasColumnName("PCT0020015")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020015")
				.IsOptional();

			Property(p => p.PCT0020016)
				.HasColumnName("PCT0020016")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020016")
				.IsOptional();

			Property(p => p.PCT0020017)
				.HasColumnName("PCT0020017")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020017")
				.IsOptional();

			Property(p => p.PCT0020018)
				.HasColumnName("PCT0020018")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020018")
				.IsOptional();

			Property(p => p.PCT0020019)
				.HasColumnName("PCT0020019")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020019")
				.IsOptional();

			Property(p => p.PCT0020020)
				.HasColumnName("PCT0020020")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020020")
				.IsOptional();

			Property(p => p.PCT0020021)
				.HasColumnName("PCT0020021")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020021")
				.IsOptional();

			Property(p => p.PCT0020022)
				.HasColumnName("PCT0020022")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020022")
				.IsOptional();

			Property(p => p.PCT0020023)
				.HasColumnName("PCT0020023")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020023")
				.IsOptional();

			Property(p => p.PCT0020024)
				.HasColumnName("PCT0020024")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020024")
				.IsOptional();

			Property(p => p.PCT0020025)
				.HasColumnName("PCT0020025")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020025")
				.IsOptional();

			Property(p => p.PCT0020026)
				.HasColumnName("PCT0020026")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020026")
				.IsOptional();

			Property(p => p.PCT0020027)
				.HasColumnName("PCT0020027")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020027")
				.IsOptional();

			Property(p => p.PCT0020028)
				.HasColumnName("PCT0020028")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020028")
				.IsOptional();

			Property(p => p.PCT0020029)
				.HasColumnName("PCT0020029")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020029")
				.IsOptional();

			Property(p => p.PCT0020030)
				.HasColumnName("PCT0020030")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020030")
				.IsOptional();

			Property(p => p.PCT0020031)
				.HasColumnName("PCT0020031")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020031")
				.IsOptional();

			Property(p => p.PCT0020032)
				.HasColumnName("PCT0020032")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020032")
				.IsOptional();

			Property(p => p.PCT0020033)
				.HasColumnName("PCT0020033")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020033")
				.IsOptional();

			Property(p => p.PCT0020034)
				.HasColumnName("PCT0020034")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020034")
				.IsOptional();

			Property(p => p.PCT0020035)
				.HasColumnName("PCT0020035")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020035")
				.IsOptional();

			Property(p => p.PCT0020036)
				.HasColumnName("PCT0020036")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020036")
				.IsOptional();

			Property(p => p.PCT0020037)
				.HasColumnName("PCT0020037")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020037")
				.IsOptional();

			Property(p => p.PCT0020038)
				.HasColumnName("PCT0020038")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020038")
				.IsOptional();

			Property(p => p.PCT0020039)
				.HasColumnName("PCT0020039")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020039")
				.IsOptional();

			Property(p => p.PCT0020040)
				.HasColumnName("PCT0020040")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020040")
				.IsOptional();

			Property(p => p.PCT0020041)
				.HasColumnName("PCT0020041")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020041")
				.IsOptional();

			Property(p => p.PCT0020042)
				.HasColumnName("PCT0020042")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020042")
				.IsOptional();

			Property(p => p.PCT0020043)
				.HasColumnName("PCT0020043")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020043")
				.IsOptional();

			Property(p => p.PCT0020044)
				.HasColumnName("PCT0020044")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020044")
				.IsOptional();

			Property(p => p.PCT0020045)
				.HasColumnName("PCT0020045")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020045")
				.IsOptional();

			Property(p => p.PCT0020046)
				.HasColumnName("PCT0020046")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020046")
				.IsOptional();

			Property(p => p.PCT0020047)
				.HasColumnName("PCT0020047")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020047")
				.IsOptional();

			Property(p => p.PCT0020048)
				.HasColumnName("PCT0020048")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020048")
				.IsOptional();

			Property(p => p.PCT0020049)
				.HasColumnName("PCT0020049")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020049")
				.IsOptional();

			Property(p => p.PCT0020050)
				.HasColumnName("PCT0020050")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020050")
				.IsOptional();

			Property(p => p.PCT0020051)
				.HasColumnName("PCT0020051")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020051")
				.IsOptional();

			Property(p => p.PCT0020052)
				.HasColumnName("PCT0020052")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020052")
				.IsOptional();

			Property(p => p.PCT0020053)
				.HasColumnName("PCT0020053")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020053")
				.IsOptional();

			Property(p => p.PCT0020054)
				.HasColumnName("PCT0020054")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0020054")
				.IsOptional();

			Property(p => p.PCT0030001)
				.HasColumnName("PCT0030001")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030001")
				.IsOptional();

			Property(p => p.PCT0030002)
				.HasColumnName("PCT0030002")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030002")
				.IsOptional();

			Property(p => p.PCT0030003)
				.HasColumnName("PCT0030003")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030003")
				.IsOptional();

			Property(p => p.PCT0030004)
				.HasColumnName("PCT0030004")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030004")
				.IsOptional();

			Property(p => p.PCT0030005)
				.HasColumnName("PCT0030005")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030005")
				.IsOptional();

			Property(p => p.PCT0030006)
				.HasColumnName("PCT0030006")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030006")
				.IsOptional();

			Property(p => p.PCT0030007)
				.HasColumnName("PCT0030007")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030007")
				.IsOptional();

			Property(p => p.PCT0030008)
				.HasColumnName("PCT0030008")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030008")
				.IsOptional();

			Property(p => p.PCT0030009)
				.HasColumnName("PCT0030009")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030009")
				.IsOptional();

			Property(p => p.PCT0030010)
				.HasColumnName("PCT0030010")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030010")
				.IsOptional();

			Property(p => p.PCT0030011)
				.HasColumnName("PCT0030011")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030011")
				.IsOptional();

			Property(p => p.PCT0030012)
				.HasColumnName("PCT0030012")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030012")
				.IsOptional();

			Property(p => p.PCT0030013)
				.HasColumnName("PCT0030013")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030013")
				.IsOptional();

			Property(p => p.PCT0030014)
				.HasColumnName("PCT0030014")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030014")
				.IsOptional();

			Property(p => p.PCT0030015)
				.HasColumnName("PCT0030015")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030015")
				.IsOptional();

			Property(p => p.PCT0030016)
				.HasColumnName("PCT0030016")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030016")
				.IsOptional();

			Property(p => p.PCT0030017)
				.HasColumnName("PCT0030017")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030017")
				.IsOptional();

			Property(p => p.PCT0030018)
				.HasColumnName("PCT0030018")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030018")
				.IsOptional();

			Property(p => p.PCT0030019)
				.HasColumnName("PCT0030019")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030019")
				.IsOptional();

			Property(p => p.PCT0030020)
				.HasColumnName("PCT0030020")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030020")
				.IsOptional();

			Property(p => p.PCT0030021)
				.HasColumnName("PCT0030021")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030021")
				.IsOptional();

			Property(p => p.PCT0030022)
				.HasColumnName("PCT0030022")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030022")
				.IsOptional();

			Property(p => p.PCT0030023)
				.HasColumnName("PCT0030023")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030023")
				.IsOptional();

			Property(p => p.PCT0030024)
				.HasColumnName("PCT0030024")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030024")
				.IsOptional();

			Property(p => p.PCT0030025)
				.HasColumnName("PCT0030025")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030025")
				.IsOptional();

			Property(p => p.PCT0030026)
				.HasColumnName("PCT0030026")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030026")
				.IsOptional();

			Property(p => p.PCT0030027)
				.HasColumnName("PCT0030027")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030027")
				.IsOptional();

			Property(p => p.PCT0030028)
				.HasColumnName("PCT0030028")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030028")
				.IsOptional();

			Property(p => p.PCT0030029)
				.HasColumnName("PCT0030029")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030029")
				.IsOptional();

			Property(p => p.PCT0030030)
				.HasColumnName("PCT0030030")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030030")
				.IsOptional();

			Property(p => p.PCT0030031)
				.HasColumnName("PCT0030031")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030031")
				.IsOptional();

			Property(p => p.PCT0030032)
				.HasColumnName("PCT0030032")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030032")
				.IsOptional();

			Property(p => p.PCT0030033)
				.HasColumnName("PCT0030033")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030033")
				.IsOptional();

			Property(p => p.PCT0030034)
				.HasColumnName("PCT0030034")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030034")
				.IsOptional();

			Property(p => p.PCT0030035)
				.HasColumnName("PCT0030035")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030035")
				.IsOptional();

			Property(p => p.PCT0030036)
				.HasColumnName("PCT0030036")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030036")
				.IsOptional();

			Property(p => p.PCT0030037)
				.HasColumnName("PCT0030037")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030037")
				.IsOptional();

			Property(p => p.PCT0030038)
				.HasColumnName("PCT0030038")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030038")
				.IsOptional();

			Property(p => p.PCT0030039)
				.HasColumnName("PCT0030039")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030039")
				.IsOptional();

			Property(p => p.PCT0030040)
				.HasColumnName("PCT0030040")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030040")
				.IsOptional();

			Property(p => p.PCT0030041)
				.HasColumnName("PCT0030041")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030041")
				.IsOptional();

			Property(p => p.PCT0030042)
				.HasColumnName("PCT0030042")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030042")
				.IsOptional();

			Property(p => p.PCT0030043)
				.HasColumnName("PCT0030043")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030043")
				.IsOptional();

			Property(p => p.PCT0030044)
				.HasColumnName("PCT0030044")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030044")
				.IsOptional();

			Property(p => p.PCT0030045)
				.HasColumnName("PCT0030045")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030045")
				.IsOptional();

			Property(p => p.PCT0030046)
				.HasColumnName("PCT0030046")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030046")
				.IsOptional();

			Property(p => p.PCT0030047)
				.HasColumnName("PCT0030047")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030047")
				.IsOptional();

			Property(p => p.PCT0030048)
				.HasColumnName("PCT0030048")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030048")
				.IsOptional();

			Property(p => p.PCT0030049)
				.HasColumnName("PCT0030049")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030049")
				.IsOptional();

			Property(p => p.PCT0030050)
				.HasColumnName("PCT0030050")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030050")
				.IsOptional();

			Property(p => p.PCT0030051)
				.HasColumnName("PCT0030051")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030051")
				.IsOptional();

			Property(p => p.PCT0030052)
				.HasColumnName("PCT0030052")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030052")
				.IsOptional();

			Property(p => p.PCT0030053)
				.HasColumnName("PCT0030053")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030053")
				.IsOptional();

			Property(p => p.PCT0030054)
				.HasColumnName("PCT0030054")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030054")
				.IsOptional();

			Property(p => p.PCT0040001)
				.HasColumnName("PCT0040001")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0040001")
				.IsOptional();

			Property(p => p.PCT0040002)
				.HasColumnName("PCT0040002")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0040002")
				.IsOptional();

			Property(p => p.PCT0040003)
				.HasColumnName("PCT0040003")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0040003")
				.IsOptional();

			Property(p => p.PCT0040004)
				.HasColumnName("PCT0040004")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0040004")
				.IsOptional();

			Property(p => p.PCT0040005)
				.HasColumnName("PCT0040005")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0040005")
				.IsOptional();

			Property(p => p.PCT0040006)
				.HasColumnName("PCT0040006")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0040006")
				.IsOptional();

			Property(p => p.PCT0040007)
				.HasColumnName("PCT0040007")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0040007")
				.IsOptional();

			Property(p => p.PCT0040008)
				.HasColumnName("PCT0040008")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0040008")
				.IsOptional();

			Property(p => p.PCT0040009)
				.HasColumnName("PCT0040009")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0040009")
				.IsOptional();

			Property(p => p.PCT0050001)
				.HasColumnName("PCT0050001")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050001")
				.IsOptional();

			Property(p => p.PCT0050002)
				.HasColumnName("PCT0050002")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050002")
				.IsOptional();

			Property(p => p.PCT0050003)
				.HasColumnName("PCT0050003")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050003")
				.IsOptional();

			Property(p => p.PCT0050004)
				.HasColumnName("PCT0050004")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050004")
				.IsOptional();

			Property(p => p.PCT0050005)
				.HasColumnName("PCT0050005")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050005")
				.IsOptional();

			Property(p => p.PCT0050006)
				.HasColumnName("PCT0050006")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050006")
				.IsOptional();

			Property(p => p.PCT0050007)
				.HasColumnName("PCT0050007")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050007")
				.IsOptional();

			Property(p => p.PCT0050008)
				.HasColumnName("PCT0050008")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050008")
				.IsOptional();

			Property(p => p.PCT0050009)
				.HasColumnName("PCT0050009")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050009")
				.IsOptional();

			Property(p => p.PCT0050010)
				.HasColumnName("PCT0050010")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050010")
				.IsOptional();

			Property(p => p.PCT0050011)
				.HasColumnName("PCT0050011")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050011")
				.IsOptional();

			Property(p => p.PCT0050012)
				.HasColumnName("PCT0050012")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050012")
				.IsOptional();

			Property(p => p.PCT0050013)
				.HasColumnName("PCT0050013")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050013")
				.IsOptional();

			Property(p => p.PCT0050014)
				.HasColumnName("PCT0050014")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050014")
				.IsOptional();

			Property(p => p.PCT0050015)
				.HasColumnName("PCT0050015")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050015")
				.IsOptional();

			Property(p => p.PCT0050016)
				.HasColumnName("PCT0050016")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050016")
				.IsOptional();

			Property(p => p.PCT0050017)
				.HasColumnName("PCT0050017")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050017")
				.IsOptional();

			Property(p => p.PCT0050018)
				.HasColumnName("PCT0050018")
				.HasColumnOrder(193)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050018")
				.IsOptional();

			Property(p => p.PCT0050019)
				.HasColumnName("PCT0050019")
				.HasColumnOrder(194)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050019")
				.IsOptional();

			Property(p => p.PCT0050020)
				.HasColumnName("PCT0050020")
				.HasColumnOrder(195)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050020")
				.IsOptional();

			Property(p => p.PCT0050021)
				.HasColumnName("PCT0050021")
				.HasColumnOrder(196)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050021")
				.IsOptional();

			Property(p => p.PCT0050022)
				.HasColumnName("PCT0050022")
				.HasColumnOrder(197)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050022")
				.IsOptional();

			Property(p => p.PCT0060001)
				.HasColumnName("PCT0060001")
				.HasColumnOrder(198)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0060001")
				.IsOptional();

			Property(p => p.PCT0060002)
				.HasColumnName("PCT0060002")
				.HasColumnOrder(199)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0060002")
				.IsOptional();

			Property(p => p.PCT0060003)
				.HasColumnName("PCT0060003")
				.HasColumnOrder(200)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0060003")
				.IsOptional();

			Property(p => p.PCT0060004)
				.HasColumnName("PCT0060004")
				.HasColumnOrder(201)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0060004")
				.IsOptional();

			Property(p => p.PCT0060005)
				.HasColumnName("PCT0060005")
				.HasColumnOrder(202)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0060005")
				.IsOptional();

			Property(p => p.PCT0060006)
				.HasColumnName("PCT0060006")
				.HasColumnOrder(203)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0060006")
				.IsOptional();

			Property(p => p.PCT0060007)
				.HasColumnName("PCT0060007")
				.HasColumnOrder(204)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0060007")
				.IsOptional();

			Property(p => p.PCT0060008)
				.HasColumnName("PCT0060008")
				.HasColumnOrder(205)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0060008")
				.IsOptional();

			Property(p => p.PCT0060009)
				.HasColumnName("PCT0060009")
				.HasColumnOrder(206)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0060009")
				.IsOptional();

			Property(p => p.PCT0060010)
				.HasColumnName("PCT0060010")
				.HasColumnOrder(207)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0060010")
				.IsOptional();

			Property(p => p.PCT0060011)
				.HasColumnName("PCT0060011")
				.HasColumnOrder(208)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0060011")
				.IsOptional();

			Property(p => p.PCT0060012)
				.HasColumnName("PCT0060012")
				.HasColumnOrder(209)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0060012")
				.IsOptional();

			Property(p => p.PCT0060013)
				.HasColumnName("PCT0060013")
				.HasColumnOrder(210)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0060013")
				.IsOptional();

			Property(p => p.PCT0060014)
				.HasColumnName("PCT0060014")
				.HasColumnOrder(211)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0060014")
				.IsOptional();

			Property(p => p.PCT0060015)
				.HasColumnName("PCT0060015")
				.HasColumnOrder(212)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0060015")
				.IsOptional();

			Property(p => p.PCT0060016)
				.HasColumnName("PCT0060016")
				.HasColumnOrder(213)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0060016")
				.IsOptional();

			Property(p => p.PCT0060017)
				.HasColumnName("PCT0060017")
				.HasColumnOrder(214)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0060017")
				.IsOptional();

			Property(p => p.PCT0060018)
				.HasColumnName("PCT0060018")
				.HasColumnOrder(215)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0060018")
				.IsOptional();

			Property(p => p.PCT0060019)
				.HasColumnName("PCT0060019")
				.HasColumnOrder(216)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0060019")
				.IsOptional();

			Property(p => p.PCT0060020)
				.HasColumnName("PCT0060020")
				.HasColumnOrder(217)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0060020")
				.IsOptional();

			Property(p => p.PCT0060021)
				.HasColumnName("PCT0060021")
				.HasColumnOrder(218)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0060021")
				.IsOptional();

			Property(p => p.PCT0060022)
				.HasColumnName("PCT0060022")
				.HasColumnOrder(219)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0060022")
				.IsOptional();

			Property(p => p.PCT0070001)
				.HasColumnName("PCT0070001")
				.HasColumnOrder(220)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0070001")
				.IsOptional();

			Property(p => p.PCT0070002)
				.HasColumnName("PCT0070002")
				.HasColumnOrder(221)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0070002")
				.IsOptional();

			Property(p => p.PCT0070003)
				.HasColumnName("PCT0070003")
				.HasColumnOrder(222)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0070003")
				.IsOptional();

			Property(p => p.PCT0070004)
				.HasColumnName("PCT0070004")
				.HasColumnOrder(223)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0070004")
				.IsOptional();

			Property(p => p.PCT0070005)
				.HasColumnName("PCT0070005")
				.HasColumnOrder(224)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0070005")
				.IsOptional();

			Property(p => p.PCT0070006)
				.HasColumnName("PCT0070006")
				.HasColumnOrder(225)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0070006")
				.IsOptional();

			Property(p => p.PCT0070007)
				.HasColumnName("PCT0070007")
				.HasColumnOrder(226)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0070007")
				.IsOptional();

			Property(p => p.PCT0070008)
				.HasColumnName("PCT0070008")
				.HasColumnOrder(227)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0070008")
				.IsOptional();

			Property(p => p.PCT0070009)
				.HasColumnName("PCT0070009")
				.HasColumnOrder(228)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0070009")
				.IsOptional();

			Property(p => p.PCT0070010)
				.HasColumnName("PCT0070010")
				.HasColumnOrder(229)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0070010")
				.IsOptional();

			Property(p => p.PCT0070011)
				.HasColumnName("PCT0070011")
				.HasColumnOrder(230)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0070011")
				.IsOptional();

			Property(p => p.PCT0070012)
				.HasColumnName("PCT0070012")
				.HasColumnOrder(231)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0070012")
				.IsOptional();

			Property(p => p.PCT0070013)
				.HasColumnName("PCT0070013")
				.HasColumnOrder(232)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0070013")
				.IsOptional();

			Property(p => p.PCT0070014)
				.HasColumnName("PCT0070014")
				.HasColumnOrder(233)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0070014")
				.IsOptional();

			Property(p => p.PCT0070015)
				.HasColumnName("PCT0070015")
				.HasColumnOrder(234)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0070015")
				.IsOptional();

			Property(p => p.PCT0070016)
				.HasColumnName("PCT0070016")
				.HasColumnOrder(235)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0070016")
				.IsOptional();

			Property(p => p.PCT0070017)
				.HasColumnName("PCT0070017")
				.HasColumnOrder(236)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0070017")
				.IsOptional();

			Property(p => p.PCT0070018)
				.HasColumnName("PCT0070018")
				.HasColumnOrder(237)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0070018")
				.IsOptional();

			Property(p => p.PCT0070019)
				.HasColumnName("PCT0070019")
				.HasColumnOrder(238)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0070019")
				.IsOptional();

			Property(p => p.PCT0070020)
				.HasColumnName("PCT0070020")
				.HasColumnOrder(239)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0070020")
				.IsOptional();

			Property(p => p.PCT0070021)
				.HasColumnName("PCT0070021")
				.HasColumnOrder(240)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0070021")
				.IsOptional();

			Property(p => p.PCT0070022)
				.HasColumnName("PCT0070022")
				.HasColumnOrder(241)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0070022")
				.IsOptional();

			Property(p => p.PCT0080001)
				.HasColumnName("PCT0080001")
				.HasColumnOrder(242)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0080001")
				.IsOptional();

			Property(p => p.PCT0080002)
				.HasColumnName("PCT0080002")
				.HasColumnOrder(243)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0080002")
				.IsOptional();

			Property(p => p.PCT0080003)
				.HasColumnName("PCT0080003")
				.HasColumnOrder(244)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0080003")
				.IsOptional();

			Property(p => p.PCT0080004)
				.HasColumnName("PCT0080004")
				.HasColumnOrder(245)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0080004")
				.IsOptional();

			Property(p => p.PCT0080005)
				.HasColumnName("PCT0080005")
				.HasColumnOrder(246)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0080005")
				.IsOptional();

			Property(p => p.PCT0080006)
				.HasColumnName("PCT0080006")
				.HasColumnOrder(247)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0080006")
				.IsOptional();

			Property(p => p.PCT0080007)
				.HasColumnName("PCT0080007")
				.HasColumnOrder(248)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0080007")
				.IsOptional();

			Property(p => p.PCT0080008)
				.HasColumnName("PCT0080008")
				.HasColumnOrder(249)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0080008")
				.IsOptional();

			Property(p => p.PCT0080009)
				.HasColumnName("PCT0080009")
				.HasColumnOrder(250)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0080009")
				.IsOptional();

			Property(p => p.PCT0080010)
				.HasColumnName("PCT0080010")
				.HasColumnOrder(251)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0080010")
				.IsOptional();

			Property(p => p.PCT0080011)
				.HasColumnName("PCT0080011")
				.HasColumnOrder(252)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0080011")
				.IsOptional();

			Property(p => p.PCT0080012)
				.HasColumnName("PCT0080012")
				.HasColumnOrder(253)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0080012")
				.IsOptional();

			Property(p => p.PCT0080013)
				.HasColumnName("PCT0080013")
				.HasColumnOrder(254)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0080013")
				.IsOptional();

			Property(p => p.PCT0080014)
				.HasColumnName("PCT0080014")
				.HasColumnOrder(255)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0080014")
				.IsOptional();
		}
	}
}
