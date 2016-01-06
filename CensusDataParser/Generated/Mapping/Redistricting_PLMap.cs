#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/06/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: Redistricting_PLMap.cs
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

	public class Redistricting_PLMap : EntityTypeConfiguration<Redistricting_PL>
	{
		public Redistricting_PLMap()
		{
			ToTable("PL", "Redistricting");

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

			Property(p => p.P0010001)
				.HasColumnName("P0010001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010001")
				.IsOptional();

			Property(p => p.P0010002)
				.HasColumnName("P0010002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010002")
				.IsOptional();

			Property(p => p.P0010003)
				.HasColumnName("P0010003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010003")
				.IsOptional();

			Property(p => p.P0010004)
				.HasColumnName("P0010004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010004")
				.IsOptional();

			Property(p => p.P0010005)
				.HasColumnName("P0010005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010005")
				.IsOptional();

			Property(p => p.P0010006)
				.HasColumnName("P0010006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010006")
				.IsOptional();

			Property(p => p.P0010007)
				.HasColumnName("P0010007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010007")
				.IsOptional();

			Property(p => p.P0010008)
				.HasColumnName("P0010008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010008")
				.IsOptional();

			Property(p => p.P0010009)
				.HasColumnName("P0010009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010009")
				.IsOptional();

			Property(p => p.P0010010)
				.HasColumnName("P0010010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010010")
				.IsOptional();

			Property(p => p.P0010011)
				.HasColumnName("P0010011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010011")
				.IsOptional();

			Property(p => p.P0010012)
				.HasColumnName("P0010012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010012")
				.IsOptional();

			Property(p => p.P0010013)
				.HasColumnName("P0010013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010013")
				.IsOptional();

			Property(p => p.P0010014)
				.HasColumnName("P0010014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010014")
				.IsOptional();

			Property(p => p.P0010015)
				.HasColumnName("P0010015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010015")
				.IsOptional();

			Property(p => p.P0010016)
				.HasColumnName("P0010016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010016")
				.IsOptional();

			Property(p => p.P0010017)
				.HasColumnName("P0010017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010017")
				.IsOptional();

			Property(p => p.P0010018)
				.HasColumnName("P0010018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010018")
				.IsOptional();

			Property(p => p.P0010019)
				.HasColumnName("P0010019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010019")
				.IsOptional();

			Property(p => p.P0010020)
				.HasColumnName("P0010020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010020")
				.IsOptional();

			Property(p => p.P0010021)
				.HasColumnName("P0010021")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010021")
				.IsOptional();

			Property(p => p.P0010022)
				.HasColumnName("P0010022")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010022")
				.IsOptional();

			Property(p => p.P0010023)
				.HasColumnName("P0010023")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010023")
				.IsOptional();

			Property(p => p.P0010024)
				.HasColumnName("P0010024")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010024")
				.IsOptional();

			Property(p => p.P0010025)
				.HasColumnName("P0010025")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010025")
				.IsOptional();

			Property(p => p.P0010026)
				.HasColumnName("P0010026")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010026")
				.IsOptional();

			Property(p => p.P0010027)
				.HasColumnName("P0010027")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010027")
				.IsOptional();

			Property(p => p.P0010028)
				.HasColumnName("P0010028")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010028")
				.IsOptional();

			Property(p => p.P0010029)
				.HasColumnName("P0010029")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010029")
				.IsOptional();

			Property(p => p.P0010030)
				.HasColumnName("P0010030")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010030")
				.IsOptional();

			Property(p => p.P0010031)
				.HasColumnName("P0010031")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010031")
				.IsOptional();

			Property(p => p.P0010032)
				.HasColumnName("P0010032")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010032")
				.IsOptional();

			Property(p => p.P0010033)
				.HasColumnName("P0010033")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010033")
				.IsOptional();

			Property(p => p.P0010034)
				.HasColumnName("P0010034")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010034")
				.IsOptional();

			Property(p => p.P0010035)
				.HasColumnName("P0010035")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010035")
				.IsOptional();

			Property(p => p.P0010036)
				.HasColumnName("P0010036")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010036")
				.IsOptional();

			Property(p => p.P0010037)
				.HasColumnName("P0010037")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010037")
				.IsOptional();

			Property(p => p.P0010038)
				.HasColumnName("P0010038")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010038")
				.IsOptional();

			Property(p => p.P0010039)
				.HasColumnName("P0010039")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010039")
				.IsOptional();

			Property(p => p.P0010040)
				.HasColumnName("P0010040")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010040")
				.IsOptional();

			Property(p => p.P0010041)
				.HasColumnName("P0010041")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010041")
				.IsOptional();

			Property(p => p.P0010042)
				.HasColumnName("P0010042")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010042")
				.IsOptional();

			Property(p => p.P0010043)
				.HasColumnName("P0010043")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010043")
				.IsOptional();

			Property(p => p.P0010044)
				.HasColumnName("P0010044")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010044")
				.IsOptional();

			Property(p => p.P0010045)
				.HasColumnName("P0010045")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010045")
				.IsOptional();

			Property(p => p.P0010046)
				.HasColumnName("P0010046")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010046")
				.IsOptional();

			Property(p => p.P0010047)
				.HasColumnName("P0010047")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010047")
				.IsOptional();

			Property(p => p.P0010048)
				.HasColumnName("P0010048")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010048")
				.IsOptional();

			Property(p => p.P0010049)
				.HasColumnName("P0010049")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010049")
				.IsOptional();

			Property(p => p.P0010050)
				.HasColumnName("P0010050")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010050")
				.IsOptional();

			Property(p => p.P0010051)
				.HasColumnName("P0010051")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010051")
				.IsOptional();

			Property(p => p.P0010052)
				.HasColumnName("P0010052")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010052")
				.IsOptional();

			Property(p => p.P0010053)
				.HasColumnName("P0010053")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010053")
				.IsOptional();

			Property(p => p.P0010054)
				.HasColumnName("P0010054")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010054")
				.IsOptional();

			Property(p => p.P0010055)
				.HasColumnName("P0010055")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010055")
				.IsOptional();

			Property(p => p.P0010056)
				.HasColumnName("P0010056")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010056")
				.IsOptional();

			Property(p => p.P0010057)
				.HasColumnName("P0010057")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010057")
				.IsOptional();

			Property(p => p.P0010058)
				.HasColumnName("P0010058")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010058")
				.IsOptional();

			Property(p => p.P0010059)
				.HasColumnName("P0010059")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010059")
				.IsOptional();

			Property(p => p.P0010060)
				.HasColumnName("P0010060")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010060")
				.IsOptional();

			Property(p => p.P0010061)
				.HasColumnName("P0010061")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010061")
				.IsOptional();

			Property(p => p.P0010062)
				.HasColumnName("P0010062")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010062")
				.IsOptional();

			Property(p => p.P0010063)
				.HasColumnName("P0010063")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010063")
				.IsOptional();

			Property(p => p.P0010064)
				.HasColumnName("P0010064")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010064")
				.IsOptional();

			Property(p => p.P0010065)
				.HasColumnName("P0010065")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010065")
				.IsOptional();

			Property(p => p.P0010066)
				.HasColumnName("P0010066")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010066")
				.IsOptional();

			Property(p => p.P0010067)
				.HasColumnName("P0010067")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010067")
				.IsOptional();

			Property(p => p.P0010068)
				.HasColumnName("P0010068")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010068")
				.IsOptional();

			Property(p => p.P0010069)
				.HasColumnName("P0010069")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010069")
				.IsOptional();

			Property(p => p.P0010070)
				.HasColumnName("P0010070")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010070")
				.IsOptional();

			Property(p => p.P0010071)
				.HasColumnName("P0010071")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0010071")
				.IsOptional();

			Property(p => p.P0020001)
				.HasColumnName("P0020001")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020001")
				.IsOptional();

			Property(p => p.P0020002)
				.HasColumnName("P0020002")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020002")
				.IsOptional();

			Property(p => p.P0020003)
				.HasColumnName("P0020003")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020003")
				.IsOptional();

			Property(p => p.P0020004)
				.HasColumnName("P0020004")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020004")
				.IsOptional();

			Property(p => p.P0020005)
				.HasColumnName("P0020005")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020005")
				.IsOptional();

			Property(p => p.P0020006)
				.HasColumnName("P0020006")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020006")
				.IsOptional();

			Property(p => p.P0020007)
				.HasColumnName("P0020007")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020007")
				.IsOptional();

			Property(p => p.P0020008)
				.HasColumnName("P0020008")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020008")
				.IsOptional();

			Property(p => p.P0020009)
				.HasColumnName("P0020009")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020009")
				.IsOptional();

			Property(p => p.P0020010)
				.HasColumnName("P0020010")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020010")
				.IsOptional();

			Property(p => p.P0020011)
				.HasColumnName("P0020011")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020011")
				.IsOptional();

			Property(p => p.P0020012)
				.HasColumnName("P0020012")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020012")
				.IsOptional();

			Property(p => p.P0020013)
				.HasColumnName("P0020013")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020013")
				.IsOptional();

			Property(p => p.P0020014)
				.HasColumnName("P0020014")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020014")
				.IsOptional();

			Property(p => p.P0020015)
				.HasColumnName("P0020015")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020015")
				.IsOptional();

			Property(p => p.P0020016)
				.HasColumnName("P0020016")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020016")
				.IsOptional();

			Property(p => p.P0020017)
				.HasColumnName("P0020017")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020017")
				.IsOptional();

			Property(p => p.P0020018)
				.HasColumnName("P0020018")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020018")
				.IsOptional();

			Property(p => p.P0020019)
				.HasColumnName("P0020019")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020019")
				.IsOptional();

			Property(p => p.P0020020)
				.HasColumnName("P0020020")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020020")
				.IsOptional();

			Property(p => p.P0020021)
				.HasColumnName("P0020021")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020021")
				.IsOptional();

			Property(p => p.P0020022)
				.HasColumnName("P0020022")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020022")
				.IsOptional();

			Property(p => p.P0020023)
				.HasColumnName("P0020023")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020023")
				.IsOptional();

			Property(p => p.P0020024)
				.HasColumnName("P0020024")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020024")
				.IsOptional();

			Property(p => p.P0020025)
				.HasColumnName("P0020025")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020025")
				.IsOptional();

			Property(p => p.P0020026)
				.HasColumnName("P0020026")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020026")
				.IsOptional();

			Property(p => p.P0020027)
				.HasColumnName("P0020027")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020027")
				.IsOptional();

			Property(p => p.P0020028)
				.HasColumnName("P0020028")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020028")
				.IsOptional();

			Property(p => p.P0020029)
				.HasColumnName("P0020029")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020029")
				.IsOptional();

			Property(p => p.P0020030)
				.HasColumnName("P0020030")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020030")
				.IsOptional();

			Property(p => p.P0020031)
				.HasColumnName("P0020031")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020031")
				.IsOptional();

			Property(p => p.P0020032)
				.HasColumnName("P0020032")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020032")
				.IsOptional();

			Property(p => p.P0020033)
				.HasColumnName("P0020033")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020033")
				.IsOptional();

			Property(p => p.P0020034)
				.HasColumnName("P0020034")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020034")
				.IsOptional();

			Property(p => p.P0020035)
				.HasColumnName("P0020035")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020035")
				.IsOptional();

			Property(p => p.P0020036)
				.HasColumnName("P0020036")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020036")
				.IsOptional();

			Property(p => p.P0020037)
				.HasColumnName("P0020037")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020037")
				.IsOptional();

			Property(p => p.P0020038)
				.HasColumnName("P0020038")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020038")
				.IsOptional();

			Property(p => p.P0020039)
				.HasColumnName("P0020039")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020039")
				.IsOptional();

			Property(p => p.P0020040)
				.HasColumnName("P0020040")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020040")
				.IsOptional();

			Property(p => p.P0020041)
				.HasColumnName("P0020041")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020041")
				.IsOptional();

			Property(p => p.P0020042)
				.HasColumnName("P0020042")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020042")
				.IsOptional();

			Property(p => p.P0020043)
				.HasColumnName("P0020043")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020043")
				.IsOptional();

			Property(p => p.P0020044)
				.HasColumnName("P0020044")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020044")
				.IsOptional();

			Property(p => p.P0020045)
				.HasColumnName("P0020045")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020045")
				.IsOptional();

			Property(p => p.P0020046)
				.HasColumnName("P0020046")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020046")
				.IsOptional();

			Property(p => p.P0020047)
				.HasColumnName("P0020047")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020047")
				.IsOptional();

			Property(p => p.P0020048)
				.HasColumnName("P0020048")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020048")
				.IsOptional();

			Property(p => p.P0020049)
				.HasColumnName("P0020049")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020049")
				.IsOptional();

			Property(p => p.P0020050)
				.HasColumnName("P0020050")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020050")
				.IsOptional();

			Property(p => p.P0020051)
				.HasColumnName("P0020051")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020051")
				.IsOptional();

			Property(p => p.P0020052)
				.HasColumnName("P0020052")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020052")
				.IsOptional();

			Property(p => p.P0020053)
				.HasColumnName("P0020053")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020053")
				.IsOptional();

			Property(p => p.P0020054)
				.HasColumnName("P0020054")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020054")
				.IsOptional();

			Property(p => p.P0020055)
				.HasColumnName("P0020055")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020055")
				.IsOptional();

			Property(p => p.P0020056)
				.HasColumnName("P0020056")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020056")
				.IsOptional();

			Property(p => p.P0020057)
				.HasColumnName("P0020057")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020057")
				.IsOptional();

			Property(p => p.P0020058)
				.HasColumnName("P0020058")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020058")
				.IsOptional();

			Property(p => p.P0020059)
				.HasColumnName("P0020059")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020059")
				.IsOptional();

			Property(p => p.P0020060)
				.HasColumnName("P0020060")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020060")
				.IsOptional();

			Property(p => p.P0020061)
				.HasColumnName("P0020061")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020061")
				.IsOptional();

			Property(p => p.P0020062)
				.HasColumnName("P0020062")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020062")
				.IsOptional();

			Property(p => p.P0020063)
				.HasColumnName("P0020063")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020063")
				.IsOptional();

			Property(p => p.P0020064)
				.HasColumnName("P0020064")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020064")
				.IsOptional();

			Property(p => p.P0020065)
				.HasColumnName("P0020065")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020065")
				.IsOptional();

			Property(p => p.P0020066)
				.HasColumnName("P0020066")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020066")
				.IsOptional();

			Property(p => p.P0020067)
				.HasColumnName("P0020067")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020067")
				.IsOptional();

			Property(p => p.P0020068)
				.HasColumnName("P0020068")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020068")
				.IsOptional();

			Property(p => p.P0020069)
				.HasColumnName("P0020069")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020069")
				.IsOptional();

			Property(p => p.P0020070)
				.HasColumnName("P0020070")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020070")
				.IsOptional();

			Property(p => p.P0020071)
				.HasColumnName("P0020071")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020071")
				.IsOptional();

			Property(p => p.P0020072)
				.HasColumnName("P0020072")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020072")
				.IsOptional();

			Property(p => p.P0020073)
				.HasColumnName("P0020073")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0020073")
				.IsOptional();

			Property(p => p.P0030001)
				.HasColumnName("P0030001")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030001")
				.IsOptional();

			Property(p => p.P0030002)
				.HasColumnName("P0030002")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030002")
				.IsOptional();

			Property(p => p.P0030003)
				.HasColumnName("P0030003")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030003")
				.IsOptional();

			Property(p => p.P0030004)
				.HasColumnName("P0030004")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030004")
				.IsOptional();

			Property(p => p.P0030005)
				.HasColumnName("P0030005")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030005")
				.IsOptional();

			Property(p => p.P0030006)
				.HasColumnName("P0030006")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030006")
				.IsOptional();

			Property(p => p.P0030007)
				.HasColumnName("P0030007")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030007")
				.IsOptional();

			Property(p => p.P0030008)
				.HasColumnName("P0030008")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030008")
				.IsOptional();

			Property(p => p.P0030009)
				.HasColumnName("P0030009")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030009")
				.IsOptional();

			Property(p => p.P0030010)
				.HasColumnName("P0030010")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030010")
				.IsOptional();

			Property(p => p.P0030011)
				.HasColumnName("P0030011")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030011")
				.IsOptional();

			Property(p => p.P0030012)
				.HasColumnName("P0030012")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030012")
				.IsOptional();

			Property(p => p.P0030013)
				.HasColumnName("P0030013")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030013")
				.IsOptional();

			Property(p => p.P0030014)
				.HasColumnName("P0030014")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030014")
				.IsOptional();

			Property(p => p.P0030015)
				.HasColumnName("P0030015")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030015")
				.IsOptional();

			Property(p => p.P0030016)
				.HasColumnName("P0030016")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030016")
				.IsOptional();

			Property(p => p.P0030017)
				.HasColumnName("P0030017")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030017")
				.IsOptional();

			Property(p => p.P0030018)
				.HasColumnName("P0030018")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030018")
				.IsOptional();

			Property(p => p.P0030019)
				.HasColumnName("P0030019")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030019")
				.IsOptional();

			Property(p => p.P0030020)
				.HasColumnName("P0030020")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030020")
				.IsOptional();

			Property(p => p.P0030021)
				.HasColumnName("P0030021")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030021")
				.IsOptional();

			Property(p => p.P0030022)
				.HasColumnName("P0030022")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030022")
				.IsOptional();

			Property(p => p.P0030023)
				.HasColumnName("P0030023")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030023")
				.IsOptional();

			Property(p => p.P0030024)
				.HasColumnName("P0030024")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030024")
				.IsOptional();

			Property(p => p.P0030025)
				.HasColumnName("P0030025")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030025")
				.IsOptional();

			Property(p => p.P0030026)
				.HasColumnName("P0030026")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030026")
				.IsOptional();

			Property(p => p.P0030027)
				.HasColumnName("P0030027")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030027")
				.IsOptional();

			Property(p => p.P0030028)
				.HasColumnName("P0030028")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030028")
				.IsOptional();

			Property(p => p.P0030029)
				.HasColumnName("P0030029")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030029")
				.IsOptional();

			Property(p => p.P0030030)
				.HasColumnName("P0030030")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030030")
				.IsOptional();

			Property(p => p.P0030031)
				.HasColumnName("P0030031")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030031")
				.IsOptional();

			Property(p => p.P0030032)
				.HasColumnName("P0030032")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030032")
				.IsOptional();

			Property(p => p.P0030033)
				.HasColumnName("P0030033")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030033")
				.IsOptional();

			Property(p => p.P0030034)
				.HasColumnName("P0030034")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030034")
				.IsOptional();

			Property(p => p.P0030035)
				.HasColumnName("P0030035")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030035")
				.IsOptional();

			Property(p => p.P0030036)
				.HasColumnName("P0030036")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030036")
				.IsOptional();

			Property(p => p.P0030037)
				.HasColumnName("P0030037")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030037")
				.IsOptional();

			Property(p => p.P0030038)
				.HasColumnName("P0030038")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030038")
				.IsOptional();

			Property(p => p.P0030039)
				.HasColumnName("P0030039")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030039")
				.IsOptional();

			Property(p => p.P0030040)
				.HasColumnName("P0030040")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030040")
				.IsOptional();

			Property(p => p.P0030041)
				.HasColumnName("P0030041")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030041")
				.IsOptional();

			Property(p => p.P0030042)
				.HasColumnName("P0030042")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030042")
				.IsOptional();

			Property(p => p.P0030043)
				.HasColumnName("P0030043")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030043")
				.IsOptional();

			Property(p => p.P0030044)
				.HasColumnName("P0030044")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030044")
				.IsOptional();

			Property(p => p.P0030045)
				.HasColumnName("P0030045")
				.HasColumnOrder(193)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030045")
				.IsOptional();

			Property(p => p.P0030046)
				.HasColumnName("P0030046")
				.HasColumnOrder(194)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030046")
				.IsOptional();

			Property(p => p.P0030047)
				.HasColumnName("P0030047")
				.HasColumnOrder(195)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030047")
				.IsOptional();

			Property(p => p.P0030048)
				.HasColumnName("P0030048")
				.HasColumnOrder(196)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030048")
				.IsOptional();

			Property(p => p.P0030049)
				.HasColumnName("P0030049")
				.HasColumnOrder(197)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030049")
				.IsOptional();

			Property(p => p.P0030050)
				.HasColumnName("P0030050")
				.HasColumnOrder(198)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030050")
				.IsOptional();

			Property(p => p.P0030051)
				.HasColumnName("P0030051")
				.HasColumnOrder(199)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030051")
				.IsOptional();

			Property(p => p.P0030052)
				.HasColumnName("P0030052")
				.HasColumnOrder(200)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030052")
				.IsOptional();

			Property(p => p.P0030053)
				.HasColumnName("P0030053")
				.HasColumnOrder(201)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030053")
				.IsOptional();

			Property(p => p.P0030054)
				.HasColumnName("P0030054")
				.HasColumnOrder(202)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030054")
				.IsOptional();

			Property(p => p.P0030055)
				.HasColumnName("P0030055")
				.HasColumnOrder(203)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030055")
				.IsOptional();

			Property(p => p.P0030056)
				.HasColumnName("P0030056")
				.HasColumnOrder(204)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030056")
				.IsOptional();

			Property(p => p.P0030057)
				.HasColumnName("P0030057")
				.HasColumnOrder(205)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030057")
				.IsOptional();

			Property(p => p.P0030058)
				.HasColumnName("P0030058")
				.HasColumnOrder(206)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030058")
				.IsOptional();

			Property(p => p.P0030059)
				.HasColumnName("P0030059")
				.HasColumnOrder(207)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030059")
				.IsOptional();

			Property(p => p.P0030060)
				.HasColumnName("P0030060")
				.HasColumnOrder(208)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030060")
				.IsOptional();

			Property(p => p.P0030061)
				.HasColumnName("P0030061")
				.HasColumnOrder(209)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030061")
				.IsOptional();

			Property(p => p.P0030062)
				.HasColumnName("P0030062")
				.HasColumnOrder(210)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030062")
				.IsOptional();

			Property(p => p.P0030063)
				.HasColumnName("P0030063")
				.HasColumnOrder(211)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030063")
				.IsOptional();

			Property(p => p.P0030064)
				.HasColumnName("P0030064")
				.HasColumnOrder(212)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030064")
				.IsOptional();

			Property(p => p.P0030065)
				.HasColumnName("P0030065")
				.HasColumnOrder(213)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030065")
				.IsOptional();

			Property(p => p.P0030066)
				.HasColumnName("P0030066")
				.HasColumnOrder(214)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030066")
				.IsOptional();

			Property(p => p.P0030067)
				.HasColumnName("P0030067")
				.HasColumnOrder(215)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030067")
				.IsOptional();

			Property(p => p.P0030068)
				.HasColumnName("P0030068")
				.HasColumnOrder(216)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030068")
				.IsOptional();

			Property(p => p.P0030069)
				.HasColumnName("P0030069")
				.HasColumnOrder(217)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030069")
				.IsOptional();

			Property(p => p.P0030070)
				.HasColumnName("P0030070")
				.HasColumnOrder(218)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030070")
				.IsOptional();

			Property(p => p.P0030071)
				.HasColumnName("P0030071")
				.HasColumnOrder(219)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030071")
				.IsOptional();

			Property(p => p.P0040001)
				.HasColumnName("P0040001")
				.HasColumnOrder(220)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040001")
				.IsOptional();

			Property(p => p.P0040002)
				.HasColumnName("P0040002")
				.HasColumnOrder(221)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040002")
				.IsOptional();

			Property(p => p.P0040003)
				.HasColumnName("P0040003")
				.HasColumnOrder(222)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040003")
				.IsOptional();

			Property(p => p.P0040004)
				.HasColumnName("P0040004")
				.HasColumnOrder(223)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040004")
				.IsOptional();

			Property(p => p.P0040005)
				.HasColumnName("P0040005")
				.HasColumnOrder(224)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040005")
				.IsOptional();

			Property(p => p.P0040006)
				.HasColumnName("P0040006")
				.HasColumnOrder(225)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040006")
				.IsOptional();

			Property(p => p.P0040007)
				.HasColumnName("P0040007")
				.HasColumnOrder(226)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040007")
				.IsOptional();

			Property(p => p.P0040008)
				.HasColumnName("P0040008")
				.HasColumnOrder(227)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040008")
				.IsOptional();

			Property(p => p.P0040009)
				.HasColumnName("P0040009")
				.HasColumnOrder(228)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040009")
				.IsOptional();

			Property(p => p.P0040010)
				.HasColumnName("P0040010")
				.HasColumnOrder(229)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040010")
				.IsOptional();

			Property(p => p.P0040011)
				.HasColumnName("P0040011")
				.HasColumnOrder(230)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040011")
				.IsOptional();

			Property(p => p.P0040012)
				.HasColumnName("P0040012")
				.HasColumnOrder(231)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040012")
				.IsOptional();

			Property(p => p.P0040013)
				.HasColumnName("P0040013")
				.HasColumnOrder(232)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040013")
				.IsOptional();

			Property(p => p.P0040014)
				.HasColumnName("P0040014")
				.HasColumnOrder(233)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040014")
				.IsOptional();

			Property(p => p.P0040015)
				.HasColumnName("P0040015")
				.HasColumnOrder(234)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040015")
				.IsOptional();

			Property(p => p.P0040016)
				.HasColumnName("P0040016")
				.HasColumnOrder(235)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040016")
				.IsOptional();

			Property(p => p.P0040017)
				.HasColumnName("P0040017")
				.HasColumnOrder(236)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040017")
				.IsOptional();

			Property(p => p.P0040018)
				.HasColumnName("P0040018")
				.HasColumnOrder(237)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040018")
				.IsOptional();

			Property(p => p.P0040019)
				.HasColumnName("P0040019")
				.HasColumnOrder(238)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040019")
				.IsOptional();

			Property(p => p.P0040020)
				.HasColumnName("P0040020")
				.HasColumnOrder(239)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040020")
				.IsOptional();

			Property(p => p.P0040021)
				.HasColumnName("P0040021")
				.HasColumnOrder(240)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040021")
				.IsOptional();

			Property(p => p.P0040022)
				.HasColumnName("P0040022")
				.HasColumnOrder(241)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040022")
				.IsOptional();

			Property(p => p.P0040023)
				.HasColumnName("P0040023")
				.HasColumnOrder(242)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040023")
				.IsOptional();

			Property(p => p.P0040024)
				.HasColumnName("P0040024")
				.HasColumnOrder(243)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040024")
				.IsOptional();

			Property(p => p.P0040025)
				.HasColumnName("P0040025")
				.HasColumnOrder(244)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040025")
				.IsOptional();

			Property(p => p.P0040026)
				.HasColumnName("P0040026")
				.HasColumnOrder(245)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040026")
				.IsOptional();

			Property(p => p.P0040027)
				.HasColumnName("P0040027")
				.HasColumnOrder(246)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040027")
				.IsOptional();

			Property(p => p.P0040028)
				.HasColumnName("P0040028")
				.HasColumnOrder(247)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040028")
				.IsOptional();

			Property(p => p.P0040029)
				.HasColumnName("P0040029")
				.HasColumnOrder(248)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040029")
				.IsOptional();

			Property(p => p.P0040030)
				.HasColumnName("P0040030")
				.HasColumnOrder(249)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040030")
				.IsOptional();

			Property(p => p.P0040031)
				.HasColumnName("P0040031")
				.HasColumnOrder(250)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040031")
				.IsOptional();

			Property(p => p.P0040032)
				.HasColumnName("P0040032")
				.HasColumnOrder(251)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040032")
				.IsOptional();

			Property(p => p.P0040033)
				.HasColumnName("P0040033")
				.HasColumnOrder(252)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040033")
				.IsOptional();

			Property(p => p.P0040034)
				.HasColumnName("P0040034")
				.HasColumnOrder(253)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040034")
				.IsOptional();

			Property(p => p.P0040035)
				.HasColumnName("P0040035")
				.HasColumnOrder(254)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040035")
				.IsOptional();

			Property(p => p.P0040036)
				.HasColumnName("P0040036")
				.HasColumnOrder(255)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040036")
				.IsOptional();

			Property(p => p.P0040037)
				.HasColumnName("P0040037")
				.HasColumnOrder(256)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040037")
				.IsOptional();

			Property(p => p.P0040038)
				.HasColumnName("P0040038")
				.HasColumnOrder(257)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040038")
				.IsOptional();

			Property(p => p.P0040039)
				.HasColumnName("P0040039")
				.HasColumnOrder(258)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040039")
				.IsOptional();

			Property(p => p.P0040040)
				.HasColumnName("P0040040")
				.HasColumnOrder(259)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040040")
				.IsOptional();

			Property(p => p.P0040041)
				.HasColumnName("P0040041")
				.HasColumnOrder(260)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040041")
				.IsOptional();

			Property(p => p.P0040042)
				.HasColumnName("P0040042")
				.HasColumnOrder(261)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040042")
				.IsOptional();

			Property(p => p.P0040043)
				.HasColumnName("P0040043")
				.HasColumnOrder(262)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040043")
				.IsOptional();

			Property(p => p.P0040044)
				.HasColumnName("P0040044")
				.HasColumnOrder(263)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040044")
				.IsOptional();

			Property(p => p.P0040045)
				.HasColumnName("P0040045")
				.HasColumnOrder(264)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040045")
				.IsOptional();

			Property(p => p.P0040046)
				.HasColumnName("P0040046")
				.HasColumnOrder(265)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040046")
				.IsOptional();

			Property(p => p.P0040047)
				.HasColumnName("P0040047")
				.HasColumnOrder(266)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040047")
				.IsOptional();

			Property(p => p.P0040048)
				.HasColumnName("P0040048")
				.HasColumnOrder(267)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040048")
				.IsOptional();

			Property(p => p.P0040049)
				.HasColumnName("P0040049")
				.HasColumnOrder(268)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040049")
				.IsOptional();

			Property(p => p.P0040050)
				.HasColumnName("P0040050")
				.HasColumnOrder(269)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040050")
				.IsOptional();

			Property(p => p.P0040051)
				.HasColumnName("P0040051")
				.HasColumnOrder(270)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040051")
				.IsOptional();

			Property(p => p.P0040052)
				.HasColumnName("P0040052")
				.HasColumnOrder(271)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040052")
				.IsOptional();

			Property(p => p.P0040053)
				.HasColumnName("P0040053")
				.HasColumnOrder(272)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040053")
				.IsOptional();

			Property(p => p.P0040054)
				.HasColumnName("P0040054")
				.HasColumnOrder(273)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040054")
				.IsOptional();

			Property(p => p.P0040055)
				.HasColumnName("P0040055")
				.HasColumnOrder(274)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040055")
				.IsOptional();

			Property(p => p.P0040056)
				.HasColumnName("P0040056")
				.HasColumnOrder(275)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040056")
				.IsOptional();

			Property(p => p.P0040057)
				.HasColumnName("P0040057")
				.HasColumnOrder(276)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040057")
				.IsOptional();

			Property(p => p.P0040058)
				.HasColumnName("P0040058")
				.HasColumnOrder(277)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040058")
				.IsOptional();

			Property(p => p.P0040059)
				.HasColumnName("P0040059")
				.HasColumnOrder(278)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040059")
				.IsOptional();

			Property(p => p.P0040060)
				.HasColumnName("P0040060")
				.HasColumnOrder(279)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040060")
				.IsOptional();

			Property(p => p.P0040061)
				.HasColumnName("P0040061")
				.HasColumnOrder(280)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040061")
				.IsOptional();

			Property(p => p.P0040062)
				.HasColumnName("P0040062")
				.HasColumnOrder(281)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040062")
				.IsOptional();

			Property(p => p.P0040063)
				.HasColumnName("P0040063")
				.HasColumnOrder(282)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040063")
				.IsOptional();

			Property(p => p.P0040064)
				.HasColumnName("P0040064")
				.HasColumnOrder(283)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040064")
				.IsOptional();

			Property(p => p.P0040065)
				.HasColumnName("P0040065")
				.HasColumnOrder(284)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040065")
				.IsOptional();

			Property(p => p.P0040066)
				.HasColumnName("P0040066")
				.HasColumnOrder(285)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040066")
				.IsOptional();

			Property(p => p.P0040067)
				.HasColumnName("P0040067")
				.HasColumnOrder(286)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040067")
				.IsOptional();

			Property(p => p.P0040068)
				.HasColumnName("P0040068")
				.HasColumnOrder(287)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040068")
				.IsOptional();

			Property(p => p.P0040069)
				.HasColumnName("P0040069")
				.HasColumnOrder(288)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040069")
				.IsOptional();

			Property(p => p.P0040070)
				.HasColumnName("P0040070")
				.HasColumnOrder(289)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040070")
				.IsOptional();

			Property(p => p.P0040071)
				.HasColumnName("P0040071")
				.HasColumnOrder(290)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040071")
				.IsOptional();

			Property(p => p.P0040072)
				.HasColumnName("P0040072")
				.HasColumnOrder(291)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040072")
				.IsOptional();

			Property(p => p.P0040073)
				.HasColumnName("P0040073")
				.HasColumnOrder(292)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040073")
				.IsOptional();

			Property(p => p.H0010001)
				.HasColumnName("H0010001")
				.HasColumnOrder(293)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H0010001")
				.IsOptional();

			Property(p => p.H0010002)
				.HasColumnName("H0010002")
				.HasColumnOrder(294)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H0010002")
				.IsOptional();

			Property(p => p.H0010003)
				.HasColumnName("H0010003")
				.HasColumnOrder(295)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H0010003")
				.IsOptional();
		}
	}
}
