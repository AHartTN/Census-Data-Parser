#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/06/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SummaryOne_SF1_00026Map.cs
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

	public class SummaryOne_SF1_00026Map : EntityTypeConfiguration<SummaryOne_SF1_00026>
	{
		public SummaryOne_SF1_00026Map()
		{
			ToTable("SF1_00026", "SummaryOne");

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

			Property(p => p.PCT012G001)
				.HasColumnName("PCT012G001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G001")
				.IsOptional();

			Property(p => p.PCT012G002)
				.HasColumnName("PCT012G002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G002")
				.IsOptional();

			Property(p => p.PCT012G003)
				.HasColumnName("PCT012G003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G003")
				.IsOptional();

			Property(p => p.PCT012G004)
				.HasColumnName("PCT012G004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G004")
				.IsOptional();

			Property(p => p.PCT012G005)
				.HasColumnName("PCT012G005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G005")
				.IsOptional();

			Property(p => p.PCT012G006)
				.HasColumnName("PCT012G006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G006")
				.IsOptional();

			Property(p => p.PCT012G007)
				.HasColumnName("PCT012G007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G007")
				.IsOptional();

			Property(p => p.PCT012G008)
				.HasColumnName("PCT012G008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G008")
				.IsOptional();

			Property(p => p.PCT012G009)
				.HasColumnName("PCT012G009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G009")
				.IsOptional();

			Property(p => p.PCT012G010)
				.HasColumnName("PCT012G010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G010")
				.IsOptional();

			Property(p => p.PCT012G011)
				.HasColumnName("PCT012G011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G011")
				.IsOptional();

			Property(p => p.PCT012G012)
				.HasColumnName("PCT012G012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G012")
				.IsOptional();

			Property(p => p.PCT012G013)
				.HasColumnName("PCT012G013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G013")
				.IsOptional();

			Property(p => p.PCT012G014)
				.HasColumnName("PCT012G014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G014")
				.IsOptional();

			Property(p => p.PCT012G015)
				.HasColumnName("PCT012G015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G015")
				.IsOptional();

			Property(p => p.PCT012G016)
				.HasColumnName("PCT012G016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G016")
				.IsOptional();

			Property(p => p.PCT012G017)
				.HasColumnName("PCT012G017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G017")
				.IsOptional();

			Property(p => p.PCT012G018)
				.HasColumnName("PCT012G018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G018")
				.IsOptional();

			Property(p => p.PCT012G019)
				.HasColumnName("PCT012G019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G019")
				.IsOptional();

			Property(p => p.PCT012G020)
				.HasColumnName("PCT012G020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G020")
				.IsOptional();

			Property(p => p.PCT012G021)
				.HasColumnName("PCT012G021")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G021")
				.IsOptional();

			Property(p => p.PCT012G022)
				.HasColumnName("PCT012G022")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G022")
				.IsOptional();

			Property(p => p.PCT012G023)
				.HasColumnName("PCT012G023")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G023")
				.IsOptional();

			Property(p => p.PCT012G024)
				.HasColumnName("PCT012G024")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G024")
				.IsOptional();

			Property(p => p.PCT012G025)
				.HasColumnName("PCT012G025")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G025")
				.IsOptional();

			Property(p => p.PCT012G026)
				.HasColumnName("PCT012G026")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G026")
				.IsOptional();

			Property(p => p.PCT012G027)
				.HasColumnName("PCT012G027")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G027")
				.IsOptional();

			Property(p => p.PCT012G028)
				.HasColumnName("PCT012G028")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G028")
				.IsOptional();

			Property(p => p.PCT012G029)
				.HasColumnName("PCT012G029")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G029")
				.IsOptional();

			Property(p => p.PCT012G030)
				.HasColumnName("PCT012G030")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G030")
				.IsOptional();

			Property(p => p.PCT012G031)
				.HasColumnName("PCT012G031")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G031")
				.IsOptional();

			Property(p => p.PCT012G032)
				.HasColumnName("PCT012G032")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G032")
				.IsOptional();

			Property(p => p.PCT012G033)
				.HasColumnName("PCT012G033")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G033")
				.IsOptional();

			Property(p => p.PCT012G034)
				.HasColumnName("PCT012G034")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G034")
				.IsOptional();

			Property(p => p.PCT012G035)
				.HasColumnName("PCT012G035")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G035")
				.IsOptional();

			Property(p => p.PCT012G036)
				.HasColumnName("PCT012G036")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G036")
				.IsOptional();

			Property(p => p.PCT012G037)
				.HasColumnName("PCT012G037")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G037")
				.IsOptional();

			Property(p => p.PCT012G038)
				.HasColumnName("PCT012G038")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G038")
				.IsOptional();

			Property(p => p.PCT012G039)
				.HasColumnName("PCT012G039")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G039")
				.IsOptional();

			Property(p => p.PCT012G040)
				.HasColumnName("PCT012G040")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G040")
				.IsOptional();

			Property(p => p.PCT012G041)
				.HasColumnName("PCT012G041")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G041")
				.IsOptional();

			Property(p => p.PCT012G042)
				.HasColumnName("PCT012G042")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G042")
				.IsOptional();

			Property(p => p.PCT012G043)
				.HasColumnName("PCT012G043")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G043")
				.IsOptional();

			Property(p => p.PCT012G044)
				.HasColumnName("PCT012G044")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G044")
				.IsOptional();

			Property(p => p.PCT012G045)
				.HasColumnName("PCT012G045")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G045")
				.IsOptional();

			Property(p => p.PCT012G046)
				.HasColumnName("PCT012G046")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G046")
				.IsOptional();

			Property(p => p.PCT012G047)
				.HasColumnName("PCT012G047")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G047")
				.IsOptional();

			Property(p => p.PCT012G048)
				.HasColumnName("PCT012G048")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G048")
				.IsOptional();

			Property(p => p.PCT012G049)
				.HasColumnName("PCT012G049")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G049")
				.IsOptional();

			Property(p => p.PCT012G050)
				.HasColumnName("PCT012G050")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G050")
				.IsOptional();

			Property(p => p.PCT012G051)
				.HasColumnName("PCT012G051")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G051")
				.IsOptional();

			Property(p => p.PCT012G052)
				.HasColumnName("PCT012G052")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G052")
				.IsOptional();

			Property(p => p.PCT012G053)
				.HasColumnName("PCT012G053")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G053")
				.IsOptional();

			Property(p => p.PCT012G054)
				.HasColumnName("PCT012G054")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G054")
				.IsOptional();

			Property(p => p.PCT012G055)
				.HasColumnName("PCT012G055")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G055")
				.IsOptional();

			Property(p => p.PCT012G056)
				.HasColumnName("PCT012G056")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G056")
				.IsOptional();

			Property(p => p.PCT012G057)
				.HasColumnName("PCT012G057")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G057")
				.IsOptional();

			Property(p => p.PCT012G058)
				.HasColumnName("PCT012G058")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G058")
				.IsOptional();

			Property(p => p.PCT012G059)
				.HasColumnName("PCT012G059")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G059")
				.IsOptional();

			Property(p => p.PCT012G060)
				.HasColumnName("PCT012G060")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G060")
				.IsOptional();

			Property(p => p.PCT012G061)
				.HasColumnName("PCT012G061")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G061")
				.IsOptional();

			Property(p => p.PCT012G062)
				.HasColumnName("PCT012G062")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G062")
				.IsOptional();

			Property(p => p.PCT012G063)
				.HasColumnName("PCT012G063")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G063")
				.IsOptional();

			Property(p => p.PCT012G064)
				.HasColumnName("PCT012G064")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G064")
				.IsOptional();

			Property(p => p.PCT012G065)
				.HasColumnName("PCT012G065")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G065")
				.IsOptional();

			Property(p => p.PCT012G066)
				.HasColumnName("PCT012G066")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G066")
				.IsOptional();

			Property(p => p.PCT012G067)
				.HasColumnName("PCT012G067")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G067")
				.IsOptional();

			Property(p => p.PCT012G068)
				.HasColumnName("PCT012G068")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G068")
				.IsOptional();

			Property(p => p.PCT012G069)
				.HasColumnName("PCT012G069")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G069")
				.IsOptional();

			Property(p => p.PCT012G070)
				.HasColumnName("PCT012G070")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G070")
				.IsOptional();

			Property(p => p.PCT012G071)
				.HasColumnName("PCT012G071")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G071")
				.IsOptional();

			Property(p => p.PCT012G072)
				.HasColumnName("PCT012G072")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G072")
				.IsOptional();

			Property(p => p.PCT012G073)
				.HasColumnName("PCT012G073")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G073")
				.IsOptional();

			Property(p => p.PCT012G074)
				.HasColumnName("PCT012G074")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G074")
				.IsOptional();

			Property(p => p.PCT012G075)
				.HasColumnName("PCT012G075")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G075")
				.IsOptional();

			Property(p => p.PCT012G076)
				.HasColumnName("PCT012G076")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G076")
				.IsOptional();

			Property(p => p.PCT012G077)
				.HasColumnName("PCT012G077")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G077")
				.IsOptional();

			Property(p => p.PCT012G078)
				.HasColumnName("PCT012G078")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G078")
				.IsOptional();

			Property(p => p.PCT012G079)
				.HasColumnName("PCT012G079")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G079")
				.IsOptional();

			Property(p => p.PCT012G080)
				.HasColumnName("PCT012G080")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G080")
				.IsOptional();

			Property(p => p.PCT012G081)
				.HasColumnName("PCT012G081")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G081")
				.IsOptional();

			Property(p => p.PCT012G082)
				.HasColumnName("PCT012G082")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G082")
				.IsOptional();

			Property(p => p.PCT012G083)
				.HasColumnName("PCT012G083")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G083")
				.IsOptional();

			Property(p => p.PCT012G084)
				.HasColumnName("PCT012G084")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G084")
				.IsOptional();

			Property(p => p.PCT012G085)
				.HasColumnName("PCT012G085")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G085")
				.IsOptional();

			Property(p => p.PCT012G086)
				.HasColumnName("PCT012G086")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G086")
				.IsOptional();

			Property(p => p.PCT012G087)
				.HasColumnName("PCT012G087")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G087")
				.IsOptional();

			Property(p => p.PCT012G088)
				.HasColumnName("PCT012G088")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G088")
				.IsOptional();

			Property(p => p.PCT012G089)
				.HasColumnName("PCT012G089")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G089")
				.IsOptional();

			Property(p => p.PCT012G090)
				.HasColumnName("PCT012G090")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G090")
				.IsOptional();

			Property(p => p.PCT012G091)
				.HasColumnName("PCT012G091")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G091")
				.IsOptional();

			Property(p => p.PCT012G092)
				.HasColumnName("PCT012G092")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G092")
				.IsOptional();

			Property(p => p.PCT012G093)
				.HasColumnName("PCT012G093")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G093")
				.IsOptional();

			Property(p => p.PCT012G094)
				.HasColumnName("PCT012G094")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G094")
				.IsOptional();

			Property(p => p.PCT012G095)
				.HasColumnName("PCT012G095")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G095")
				.IsOptional();

			Property(p => p.PCT012G096)
				.HasColumnName("PCT012G096")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G096")
				.IsOptional();

			Property(p => p.PCT012G097)
				.HasColumnName("PCT012G097")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G097")
				.IsOptional();

			Property(p => p.PCT012G098)
				.HasColumnName("PCT012G098")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G098")
				.IsOptional();

			Property(p => p.PCT012G099)
				.HasColumnName("PCT012G099")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G099")
				.IsOptional();

			Property(p => p.PCT012G100)
				.HasColumnName("PCT012G100")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G100")
				.IsOptional();

			Property(p => p.PCT012G101)
				.HasColumnName("PCT012G101")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G101")
				.IsOptional();

			Property(p => p.PCT012G102)
				.HasColumnName("PCT012G102")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G102")
				.IsOptional();

			Property(p => p.PCT012G103)
				.HasColumnName("PCT012G103")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G103")
				.IsOptional();

			Property(p => p.PCT012G104)
				.HasColumnName("PCT012G104")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G104")
				.IsOptional();

			Property(p => p.PCT012G105)
				.HasColumnName("PCT012G105")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G105")
				.IsOptional();

			Property(p => p.PCT012G106)
				.HasColumnName("PCT012G106")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G106")
				.IsOptional();

			Property(p => p.PCT012G107)
				.HasColumnName("PCT012G107")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G107")
				.IsOptional();

			Property(p => p.PCT012G108)
				.HasColumnName("PCT012G108")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G108")
				.IsOptional();

			Property(p => p.PCT012G109)
				.HasColumnName("PCT012G109")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G109")
				.IsOptional();

			Property(p => p.PCT012G110)
				.HasColumnName("PCT012G110")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G110")
				.IsOptional();

			Property(p => p.PCT012G111)
				.HasColumnName("PCT012G111")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G111")
				.IsOptional();

			Property(p => p.PCT012G112)
				.HasColumnName("PCT012G112")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G112")
				.IsOptional();

			Property(p => p.PCT012G113)
				.HasColumnName("PCT012G113")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G113")
				.IsOptional();

			Property(p => p.PCT012G114)
				.HasColumnName("PCT012G114")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G114")
				.IsOptional();

			Property(p => p.PCT012G115)
				.HasColumnName("PCT012G115")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G115")
				.IsOptional();

			Property(p => p.PCT012G116)
				.HasColumnName("PCT012G116")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G116")
				.IsOptional();

			Property(p => p.PCT012G117)
				.HasColumnName("PCT012G117")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G117")
				.IsOptional();

			Property(p => p.PCT012G118)
				.HasColumnName("PCT012G118")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G118")
				.IsOptional();

			Property(p => p.PCT012G119)
				.HasColumnName("PCT012G119")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G119")
				.IsOptional();

			Property(p => p.PCT012G120)
				.HasColumnName("PCT012G120")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G120")
				.IsOptional();

			Property(p => p.PCT012G121)
				.HasColumnName("PCT012G121")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G121")
				.IsOptional();

			Property(p => p.PCT012G122)
				.HasColumnName("PCT012G122")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G122")
				.IsOptional();

			Property(p => p.PCT012G123)
				.HasColumnName("PCT012G123")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G123")
				.IsOptional();

			Property(p => p.PCT012G124)
				.HasColumnName("PCT012G124")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G124")
				.IsOptional();

			Property(p => p.PCT012G125)
				.HasColumnName("PCT012G125")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G125")
				.IsOptional();

			Property(p => p.PCT012G126)
				.HasColumnName("PCT012G126")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G126")
				.IsOptional();

			Property(p => p.PCT012G127)
				.HasColumnName("PCT012G127")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G127")
				.IsOptional();

			Property(p => p.PCT012G128)
				.HasColumnName("PCT012G128")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G128")
				.IsOptional();

			Property(p => p.PCT012G129)
				.HasColumnName("PCT012G129")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G129")
				.IsOptional();

			Property(p => p.PCT012G130)
				.HasColumnName("PCT012G130")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G130")
				.IsOptional();

			Property(p => p.PCT012G131)
				.HasColumnName("PCT012G131")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G131")
				.IsOptional();

			Property(p => p.PCT012G132)
				.HasColumnName("PCT012G132")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G132")
				.IsOptional();

			Property(p => p.PCT012G133)
				.HasColumnName("PCT012G133")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G133")
				.IsOptional();

			Property(p => p.PCT012G134)
				.HasColumnName("PCT012G134")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G134")
				.IsOptional();

			Property(p => p.PCT012G135)
				.HasColumnName("PCT012G135")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G135")
				.IsOptional();

			Property(p => p.PCT012G136)
				.HasColumnName("PCT012G136")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G136")
				.IsOptional();

			Property(p => p.PCT012G137)
				.HasColumnName("PCT012G137")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G137")
				.IsOptional();

			Property(p => p.PCT012G138)
				.HasColumnName("PCT012G138")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G138")
				.IsOptional();

			Property(p => p.PCT012G139)
				.HasColumnName("PCT012G139")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G139")
				.IsOptional();

			Property(p => p.PCT012G140)
				.HasColumnName("PCT012G140")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G140")
				.IsOptional();

			Property(p => p.PCT012G141)
				.HasColumnName("PCT012G141")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G141")
				.IsOptional();

			Property(p => p.PCT012G142)
				.HasColumnName("PCT012G142")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G142")
				.IsOptional();

			Property(p => p.PCT012G143)
				.HasColumnName("PCT012G143")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G143")
				.IsOptional();

			Property(p => p.PCT012G144)
				.HasColumnName("PCT012G144")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G144")
				.IsOptional();

			Property(p => p.PCT012G145)
				.HasColumnName("PCT012G145")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G145")
				.IsOptional();

			Property(p => p.PCT012G146)
				.HasColumnName("PCT012G146")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G146")
				.IsOptional();

			Property(p => p.PCT012G147)
				.HasColumnName("PCT012G147")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G147")
				.IsOptional();

			Property(p => p.PCT012G148)
				.HasColumnName("PCT012G148")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G148")
				.IsOptional();

			Property(p => p.PCT012G149)
				.HasColumnName("PCT012G149")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G149")
				.IsOptional();

			Property(p => p.PCT012G150)
				.HasColumnName("PCT012G150")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G150")
				.IsOptional();

			Property(p => p.PCT012G151)
				.HasColumnName("PCT012G151")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G151")
				.IsOptional();

			Property(p => p.PCT012G152)
				.HasColumnName("PCT012G152")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G152")
				.IsOptional();

			Property(p => p.PCT012G153)
				.HasColumnName("PCT012G153")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G153")
				.IsOptional();

			Property(p => p.PCT012G154)
				.HasColumnName("PCT012G154")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G154")
				.IsOptional();

			Property(p => p.PCT012G155)
				.HasColumnName("PCT012G155")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G155")
				.IsOptional();

			Property(p => p.PCT012G156)
				.HasColumnName("PCT012G156")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G156")
				.IsOptional();

			Property(p => p.PCT012G157)
				.HasColumnName("PCT012G157")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G157")
				.IsOptional();

			Property(p => p.PCT012G158)
				.HasColumnName("PCT012G158")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G158")
				.IsOptional();

			Property(p => p.PCT012G159)
				.HasColumnName("PCT012G159")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G159")
				.IsOptional();

			Property(p => p.PCT012G160)
				.HasColumnName("PCT012G160")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G160")
				.IsOptional();

			Property(p => p.PCT012G161)
				.HasColumnName("PCT012G161")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G161")
				.IsOptional();

			Property(p => p.PCT012G162)
				.HasColumnName("PCT012G162")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G162")
				.IsOptional();

			Property(p => p.PCT012G163)
				.HasColumnName("PCT012G163")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G163")
				.IsOptional();

			Property(p => p.PCT012G164)
				.HasColumnName("PCT012G164")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G164")
				.IsOptional();

			Property(p => p.PCT012G165)
				.HasColumnName("PCT012G165")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G165")
				.IsOptional();

			Property(p => p.PCT012G166)
				.HasColumnName("PCT012G166")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G166")
				.IsOptional();

			Property(p => p.PCT012G167)
				.HasColumnName("PCT012G167")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G167")
				.IsOptional();

			Property(p => p.PCT012G168)
				.HasColumnName("PCT012G168")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G168")
				.IsOptional();

			Property(p => p.PCT012G169)
				.HasColumnName("PCT012G169")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G169")
				.IsOptional();

			Property(p => p.PCT012G170)
				.HasColumnName("PCT012G170")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G170")
				.IsOptional();

			Property(p => p.PCT012G171)
				.HasColumnName("PCT012G171")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G171")
				.IsOptional();

			Property(p => p.PCT012G172)
				.HasColumnName("PCT012G172")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G172")
				.IsOptional();

			Property(p => p.PCT012G173)
				.HasColumnName("PCT012G173")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G173")
				.IsOptional();

			Property(p => p.PCT012G174)
				.HasColumnName("PCT012G174")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G174")
				.IsOptional();

			Property(p => p.PCT012G175)
				.HasColumnName("PCT012G175")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G175")
				.IsOptional();

			Property(p => p.PCT012G176)
				.HasColumnName("PCT012G176")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G176")
				.IsOptional();

			Property(p => p.PCT012G177)
				.HasColumnName("PCT012G177")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G177")
				.IsOptional();

			Property(p => p.PCT012G178)
				.HasColumnName("PCT012G178")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G178")
				.IsOptional();

			Property(p => p.PCT012G179)
				.HasColumnName("PCT012G179")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G179")
				.IsOptional();

			Property(p => p.PCT012G180)
				.HasColumnName("PCT012G180")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G180")
				.IsOptional();

			Property(p => p.PCT012G181)
				.HasColumnName("PCT012G181")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G181")
				.IsOptional();

			Property(p => p.PCT012G182)
				.HasColumnName("PCT012G182")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G182")
				.IsOptional();

			Property(p => p.PCT012G183)
				.HasColumnName("PCT012G183")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G183")
				.IsOptional();

			Property(p => p.PCT012G184)
				.HasColumnName("PCT012G184")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G184")
				.IsOptional();

			Property(p => p.PCT012G185)
				.HasColumnName("PCT012G185")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G185")
				.IsOptional();

			Property(p => p.PCT012G186)
				.HasColumnName("PCT012G186")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G186")
				.IsOptional();

			Property(p => p.PCT012G187)
				.HasColumnName("PCT012G187")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G187")
				.IsOptional();

			Property(p => p.PCT012G188)
				.HasColumnName("PCT012G188")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G188")
				.IsOptional();

			Property(p => p.PCT012G189)
				.HasColumnName("PCT012G189")
				.HasColumnOrder(193)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G189")
				.IsOptional();

			Property(p => p.PCT012G190)
				.HasColumnName("PCT012G190")
				.HasColumnOrder(194)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G190")
				.IsOptional();

			Property(p => p.PCT012G191)
				.HasColumnName("PCT012G191")
				.HasColumnOrder(195)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G191")
				.IsOptional();

			Property(p => p.PCT012G192)
				.HasColumnName("PCT012G192")
				.HasColumnOrder(196)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G192")
				.IsOptional();

			Property(p => p.PCT012G193)
				.HasColumnName("PCT012G193")
				.HasColumnOrder(197)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G193")
				.IsOptional();

			Property(p => p.PCT012G194)
				.HasColumnName("PCT012G194")
				.HasColumnOrder(198)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G194")
				.IsOptional();

			Property(p => p.PCT012G195)
				.HasColumnName("PCT012G195")
				.HasColumnOrder(199)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G195")
				.IsOptional();

			Property(p => p.PCT012G196)
				.HasColumnName("PCT012G196")
				.HasColumnOrder(200)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G196")
				.IsOptional();

			Property(p => p.PCT012G197)
				.HasColumnName("PCT012G197")
				.HasColumnOrder(201)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G197")
				.IsOptional();

			Property(p => p.PCT012G198)
				.HasColumnName("PCT012G198")
				.HasColumnOrder(202)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G198")
				.IsOptional();

			Property(p => p.PCT012G199)
				.HasColumnName("PCT012G199")
				.HasColumnOrder(203)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G199")
				.IsOptional();

			Property(p => p.PCT012G200)
				.HasColumnName("PCT012G200")
				.HasColumnOrder(204)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G200")
				.IsOptional();

			Property(p => p.PCT012G201)
				.HasColumnName("PCT012G201")
				.HasColumnOrder(205)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G201")
				.IsOptional();

			Property(p => p.PCT012G202)
				.HasColumnName("PCT012G202")
				.HasColumnOrder(206)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G202")
				.IsOptional();

			Property(p => p.PCT012G203)
				.HasColumnName("PCT012G203")
				.HasColumnOrder(207)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G203")
				.IsOptional();

			Property(p => p.PCT012G204)
				.HasColumnName("PCT012G204")
				.HasColumnOrder(208)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G204")
				.IsOptional();

			Property(p => p.PCT012G205)
				.HasColumnName("PCT012G205")
				.HasColumnOrder(209)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G205")
				.IsOptional();

			Property(p => p.PCT012G206)
				.HasColumnName("PCT012G206")
				.HasColumnOrder(210)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G206")
				.IsOptional();

			Property(p => p.PCT012G207)
				.HasColumnName("PCT012G207")
				.HasColumnOrder(211)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G207")
				.IsOptional();

			Property(p => p.PCT012G208)
				.HasColumnName("PCT012G208")
				.HasColumnOrder(212)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G208")
				.IsOptional();

			Property(p => p.PCT012G209)
				.HasColumnName("PCT012G209")
				.HasColumnOrder(213)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012G209")
				.IsOptional();
		}
	}
}
