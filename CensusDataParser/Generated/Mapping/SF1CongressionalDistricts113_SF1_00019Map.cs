#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/06/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1CongressionalDistricts113_SF1_00019Map.cs
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

	public class SF1CongressionalDistricts113_SF1_00019Map : EntityTypeConfiguration<SF1CongressionalDistricts113_SF1_00019>
	{
		public SF1CongressionalDistricts113_SF1_00019Map()
		{
			ToTable("SF1_00019", "SF1CongressionalDistricts113");

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

			Property(p => p.PCT0210001)
				.HasColumnName("PCT0210001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210001")
				.IsOptional();

			Property(p => p.PCT0210002)
				.HasColumnName("PCT0210002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210002")
				.IsOptional();

			Property(p => p.PCT0210003)
				.HasColumnName("PCT0210003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210003")
				.IsOptional();

			Property(p => p.PCT0210004)
				.HasColumnName("PCT0210004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210004")
				.IsOptional();

			Property(p => p.PCT0210005)
				.HasColumnName("PCT0210005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210005")
				.IsOptional();

			Property(p => p.PCT0210006)
				.HasColumnName("PCT0210006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210006")
				.IsOptional();

			Property(p => p.PCT0210007)
				.HasColumnName("PCT0210007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210007")
				.IsOptional();

			Property(p => p.PCT0210008)
				.HasColumnName("PCT0210008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210008")
				.IsOptional();

			Property(p => p.PCT0210009)
				.HasColumnName("PCT0210009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210009")
				.IsOptional();

			Property(p => p.PCT0210010)
				.HasColumnName("PCT0210010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210010")
				.IsOptional();

			Property(p => p.PCT0210011)
				.HasColumnName("PCT0210011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210011")
				.IsOptional();

			Property(p => p.PCT0210012)
				.HasColumnName("PCT0210012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210012")
				.IsOptional();

			Property(p => p.PCT0210013)
				.HasColumnName("PCT0210013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210013")
				.IsOptional();

			Property(p => p.PCT0210014)
				.HasColumnName("PCT0210014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210014")
				.IsOptional();

			Property(p => p.PCT0210015)
				.HasColumnName("PCT0210015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210015")
				.IsOptional();

			Property(p => p.PCT0210016)
				.HasColumnName("PCT0210016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210016")
				.IsOptional();

			Property(p => p.PCT0210017)
				.HasColumnName("PCT0210017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210017")
				.IsOptional();

			Property(p => p.PCT0210018)
				.HasColumnName("PCT0210018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210018")
				.IsOptional();

			Property(p => p.PCT0210019)
				.HasColumnName("PCT0210019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210019")
				.IsOptional();

			Property(p => p.PCT0210020)
				.HasColumnName("PCT0210020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210020")
				.IsOptional();

			Property(p => p.PCT0210021)
				.HasColumnName("PCT0210021")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210021")
				.IsOptional();

			Property(p => p.PCT0210022)
				.HasColumnName("PCT0210022")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210022")
				.IsOptional();

			Property(p => p.PCT0210023)
				.HasColumnName("PCT0210023")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210023")
				.IsOptional();

			Property(p => p.PCT0210024)
				.HasColumnName("PCT0210024")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210024")
				.IsOptional();

			Property(p => p.PCT0210025)
				.HasColumnName("PCT0210025")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210025")
				.IsOptional();

			Property(p => p.PCT0210026)
				.HasColumnName("PCT0210026")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210026")
				.IsOptional();

			Property(p => p.PCT0210027)
				.HasColumnName("PCT0210027")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210027")
				.IsOptional();

			Property(p => p.PCT0210028)
				.HasColumnName("PCT0210028")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210028")
				.IsOptional();

			Property(p => p.PCT0210029)
				.HasColumnName("PCT0210029")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210029")
				.IsOptional();

			Property(p => p.PCT0210030)
				.HasColumnName("PCT0210030")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210030")
				.IsOptional();

			Property(p => p.PCT0210031)
				.HasColumnName("PCT0210031")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210031")
				.IsOptional();

			Property(p => p.PCT0210032)
				.HasColumnName("PCT0210032")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210032")
				.IsOptional();

			Property(p => p.PCT0210033)
				.HasColumnName("PCT0210033")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210033")
				.IsOptional();

			Property(p => p.PCT0210034)
				.HasColumnName("PCT0210034")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210034")
				.IsOptional();

			Property(p => p.PCT0210035)
				.HasColumnName("PCT0210035")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210035")
				.IsOptional();

			Property(p => p.PCT0210036)
				.HasColumnName("PCT0210036")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210036")
				.IsOptional();

			Property(p => p.PCT0210037)
				.HasColumnName("PCT0210037")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210037")
				.IsOptional();

			Property(p => p.PCT0210038)
				.HasColumnName("PCT0210038")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210038")
				.IsOptional();

			Property(p => p.PCT0210039)
				.HasColumnName("PCT0210039")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210039")
				.IsOptional();

			Property(p => p.PCT0210040)
				.HasColumnName("PCT0210040")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210040")
				.IsOptional();

			Property(p => p.PCT0210041)
				.HasColumnName("PCT0210041")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210041")
				.IsOptional();

			Property(p => p.PCT0210042)
				.HasColumnName("PCT0210042")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210042")
				.IsOptional();

			Property(p => p.PCT0210043)
				.HasColumnName("PCT0210043")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210043")
				.IsOptional();

			Property(p => p.PCT0210044)
				.HasColumnName("PCT0210044")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210044")
				.IsOptional();

			Property(p => p.PCT0210045)
				.HasColumnName("PCT0210045")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210045")
				.IsOptional();

			Property(p => p.PCT0210046)
				.HasColumnName("PCT0210046")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210046")
				.IsOptional();

			Property(p => p.PCT0210047)
				.HasColumnName("PCT0210047")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210047")
				.IsOptional();

			Property(p => p.PCT0210048)
				.HasColumnName("PCT0210048")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210048")
				.IsOptional();

			Property(p => p.PCT0210049)
				.HasColumnName("PCT0210049")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210049")
				.IsOptional();

			Property(p => p.PCT0210050)
				.HasColumnName("PCT0210050")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210050")
				.IsOptional();

			Property(p => p.PCT0210051)
				.HasColumnName("PCT0210051")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210051")
				.IsOptional();

			Property(p => p.PCT0210052)
				.HasColumnName("PCT0210052")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210052")
				.IsOptional();

			Property(p => p.PCT0210053)
				.HasColumnName("PCT0210053")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210053")
				.IsOptional();

			Property(p => p.PCT0210054)
				.HasColumnName("PCT0210054")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210054")
				.IsOptional();

			Property(p => p.PCT0210055)
				.HasColumnName("PCT0210055")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210055")
				.IsOptional();

			Property(p => p.PCT0210056)
				.HasColumnName("PCT0210056")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210056")
				.IsOptional();

			Property(p => p.PCT0210057)
				.HasColumnName("PCT0210057")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210057")
				.IsOptional();

			Property(p => p.PCT0210058)
				.HasColumnName("PCT0210058")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210058")
				.IsOptional();

			Property(p => p.PCT0210059)
				.HasColumnName("PCT0210059")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210059")
				.IsOptional();

			Property(p => p.PCT0210060)
				.HasColumnName("PCT0210060")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210060")
				.IsOptional();

			Property(p => p.PCT0210061)
				.HasColumnName("PCT0210061")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210061")
				.IsOptional();

			Property(p => p.PCT0210062)
				.HasColumnName("PCT0210062")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210062")
				.IsOptional();

			Property(p => p.PCT0210063)
				.HasColumnName("PCT0210063")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210063")
				.IsOptional();

			Property(p => p.PCT0210064)
				.HasColumnName("PCT0210064")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210064")
				.IsOptional();

			Property(p => p.PCT0210065)
				.HasColumnName("PCT0210065")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210065")
				.IsOptional();

			Property(p => p.PCT0210066)
				.HasColumnName("PCT0210066")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210066")
				.IsOptional();

			Property(p => p.PCT0210067)
				.HasColumnName("PCT0210067")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210067")
				.IsOptional();

			Property(p => p.PCT0210068)
				.HasColumnName("PCT0210068")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210068")
				.IsOptional();

			Property(p => p.PCT0210069)
				.HasColumnName("PCT0210069")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210069")
				.IsOptional();

			Property(p => p.PCT0210070)
				.HasColumnName("PCT0210070")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210070")
				.IsOptional();

			Property(p => p.PCT0210071)
				.HasColumnName("PCT0210071")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210071")
				.IsOptional();

			Property(p => p.PCT0210072)
				.HasColumnName("PCT0210072")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210072")
				.IsOptional();

			Property(p => p.PCT0210073)
				.HasColumnName("PCT0210073")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210073")
				.IsOptional();

			Property(p => p.PCT0210074)
				.HasColumnName("PCT0210074")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210074")
				.IsOptional();

			Property(p => p.PCT0210075)
				.HasColumnName("PCT0210075")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210075")
				.IsOptional();

			Property(p => p.PCT0210076)
				.HasColumnName("PCT0210076")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210076")
				.IsOptional();

			Property(p => p.PCT0210077)
				.HasColumnName("PCT0210077")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210077")
				.IsOptional();

			Property(p => p.PCT0210078)
				.HasColumnName("PCT0210078")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210078")
				.IsOptional();

			Property(p => p.PCT0210079)
				.HasColumnName("PCT0210079")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210079")
				.IsOptional();

			Property(p => p.PCT0210080)
				.HasColumnName("PCT0210080")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210080")
				.IsOptional();

			Property(p => p.PCT0210081)
				.HasColumnName("PCT0210081")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210081")
				.IsOptional();

			Property(p => p.PCT0210082)
				.HasColumnName("PCT0210082")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210082")
				.IsOptional();

			Property(p => p.PCT0210083)
				.HasColumnName("PCT0210083")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210083")
				.IsOptional();

			Property(p => p.PCT0210084)
				.HasColumnName("PCT0210084")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210084")
				.IsOptional();

			Property(p => p.PCT0210085)
				.HasColumnName("PCT0210085")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210085")
				.IsOptional();

			Property(p => p.PCT0210086)
				.HasColumnName("PCT0210086")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210086")
				.IsOptional();

			Property(p => p.PCT0210087)
				.HasColumnName("PCT0210087")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210087")
				.IsOptional();

			Property(p => p.PCT0210088)
				.HasColumnName("PCT0210088")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210088")
				.IsOptional();

			Property(p => p.PCT0210089)
				.HasColumnName("PCT0210089")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210089")
				.IsOptional();

			Property(p => p.PCT0210090)
				.HasColumnName("PCT0210090")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210090")
				.IsOptional();

			Property(p => p.PCT0210091)
				.HasColumnName("PCT0210091")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210091")
				.IsOptional();

			Property(p => p.PCT0210092)
				.HasColumnName("PCT0210092")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210092")
				.IsOptional();

			Property(p => p.PCT0210093)
				.HasColumnName("PCT0210093")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210093")
				.IsOptional();

			Property(p => p.PCT0210094)
				.HasColumnName("PCT0210094")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210094")
				.IsOptional();

			Property(p => p.PCT0210095)
				.HasColumnName("PCT0210095")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210095")
				.IsOptional();

			Property(p => p.PCT0210096)
				.HasColumnName("PCT0210096")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210096")
				.IsOptional();

			Property(p => p.PCT0210097)
				.HasColumnName("PCT0210097")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210097")
				.IsOptional();

			Property(p => p.PCT0210098)
				.HasColumnName("PCT0210098")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210098")
				.IsOptional();

			Property(p => p.PCT0210099)
				.HasColumnName("PCT0210099")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210099")
				.IsOptional();

			Property(p => p.PCT0210100)
				.HasColumnName("PCT0210100")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210100")
				.IsOptional();

			Property(p => p.PCT0210101)
				.HasColumnName("PCT0210101")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210101")
				.IsOptional();

			Property(p => p.PCT0210102)
				.HasColumnName("PCT0210102")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210102")
				.IsOptional();

			Property(p => p.PCT0210103)
				.HasColumnName("PCT0210103")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210103")
				.IsOptional();

			Property(p => p.PCT0210104)
				.HasColumnName("PCT0210104")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210104")
				.IsOptional();

			Property(p => p.PCT0210105)
				.HasColumnName("PCT0210105")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210105")
				.IsOptional();

			Property(p => p.PCT0210106)
				.HasColumnName("PCT0210106")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210106")
				.IsOptional();

			Property(p => p.PCT0210107)
				.HasColumnName("PCT0210107")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210107")
				.IsOptional();

			Property(p => p.PCT0210108)
				.HasColumnName("PCT0210108")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210108")
				.IsOptional();

			Property(p => p.PCT0210109)
				.HasColumnName("PCT0210109")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210109")
				.IsOptional();

			Property(p => p.PCT0210110)
				.HasColumnName("PCT0210110")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210110")
				.IsOptional();

			Property(p => p.PCT0210111)
				.HasColumnName("PCT0210111")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210111")
				.IsOptional();

			Property(p => p.PCT0210112)
				.HasColumnName("PCT0210112")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210112")
				.IsOptional();

			Property(p => p.PCT0210113)
				.HasColumnName("PCT0210113")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210113")
				.IsOptional();

			Property(p => p.PCT0210114)
				.HasColumnName("PCT0210114")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210114")
				.IsOptional();

			Property(p => p.PCT0210115)
				.HasColumnName("PCT0210115")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210115")
				.IsOptional();

			Property(p => p.PCT0210116)
				.HasColumnName("PCT0210116")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210116")
				.IsOptional();

			Property(p => p.PCT0210117)
				.HasColumnName("PCT0210117")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210117")
				.IsOptional();

			Property(p => p.PCT0210118)
				.HasColumnName("PCT0210118")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210118")
				.IsOptional();

			Property(p => p.PCT0210119)
				.HasColumnName("PCT0210119")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210119")
				.IsOptional();

			Property(p => p.PCT0210120)
				.HasColumnName("PCT0210120")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210120")
				.IsOptional();

			Property(p => p.PCT0210121)
				.HasColumnName("PCT0210121")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210121")
				.IsOptional();

			Property(p => p.PCT0210122)
				.HasColumnName("PCT0210122")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210122")
				.IsOptional();

			Property(p => p.PCT0210123)
				.HasColumnName("PCT0210123")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210123")
				.IsOptional();

			Property(p => p.PCT0210124)
				.HasColumnName("PCT0210124")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210124")
				.IsOptional();

			Property(p => p.PCT0210125)
				.HasColumnName("PCT0210125")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210125")
				.IsOptional();

			Property(p => p.PCT0210126)
				.HasColumnName("PCT0210126")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210126")
				.IsOptional();

			Property(p => p.PCT0210127)
				.HasColumnName("PCT0210127")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210127")
				.IsOptional();

			Property(p => p.PCT0210128)
				.HasColumnName("PCT0210128")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210128")
				.IsOptional();

			Property(p => p.PCT0210129)
				.HasColumnName("PCT0210129")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210129")
				.IsOptional();

			Property(p => p.PCT0210130)
				.HasColumnName("PCT0210130")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210130")
				.IsOptional();

			Property(p => p.PCT0210131)
				.HasColumnName("PCT0210131")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210131")
				.IsOptional();

			Property(p => p.PCT0210132)
				.HasColumnName("PCT0210132")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210132")
				.IsOptional();

			Property(p => p.PCT0210133)
				.HasColumnName("PCT0210133")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210133")
				.IsOptional();

			Property(p => p.PCT0210134)
				.HasColumnName("PCT0210134")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210134")
				.IsOptional();

			Property(p => p.PCT0210135)
				.HasColumnName("PCT0210135")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210135")
				.IsOptional();

			Property(p => p.PCT0210136)
				.HasColumnName("PCT0210136")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210136")
				.IsOptional();

			Property(p => p.PCT0210137)
				.HasColumnName("PCT0210137")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210137")
				.IsOptional();

			Property(p => p.PCT0210138)
				.HasColumnName("PCT0210138")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210138")
				.IsOptional();

			Property(p => p.PCT0210139)
				.HasColumnName("PCT0210139")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210139")
				.IsOptional();

			Property(p => p.PCT0210140)
				.HasColumnName("PCT0210140")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210140")
				.IsOptional();

			Property(p => p.PCT0210141)
				.HasColumnName("PCT0210141")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210141")
				.IsOptional();

			Property(p => p.PCT0210142)
				.HasColumnName("PCT0210142")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210142")
				.IsOptional();

			Property(p => p.PCT0210143)
				.HasColumnName("PCT0210143")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210143")
				.IsOptional();

			Property(p => p.PCT0210144)
				.HasColumnName("PCT0210144")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210144")
				.IsOptional();

			Property(p => p.PCT0210145)
				.HasColumnName("PCT0210145")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210145")
				.IsOptional();

			Property(p => p.PCT0210146)
				.HasColumnName("PCT0210146")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210146")
				.IsOptional();

			Property(p => p.PCT0210147)
				.HasColumnName("PCT0210147")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210147")
				.IsOptional();

			Property(p => p.PCT0210148)
				.HasColumnName("PCT0210148")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210148")
				.IsOptional();

			Property(p => p.PCT0210149)
				.HasColumnName("PCT0210149")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210149")
				.IsOptional();

			Property(p => p.PCT0210150)
				.HasColumnName("PCT0210150")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210150")
				.IsOptional();

			Property(p => p.PCT0210151)
				.HasColumnName("PCT0210151")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210151")
				.IsOptional();

			Property(p => p.PCT0210152)
				.HasColumnName("PCT0210152")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210152")
				.IsOptional();

			Property(p => p.PCT0210153)
				.HasColumnName("PCT0210153")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210153")
				.IsOptional();

			Property(p => p.PCT0210154)
				.HasColumnName("PCT0210154")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210154")
				.IsOptional();

			Property(p => p.PCT0210155)
				.HasColumnName("PCT0210155")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210155")
				.IsOptional();

			Property(p => p.PCT0210156)
				.HasColumnName("PCT0210156")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210156")
				.IsOptional();

			Property(p => p.PCT0210157)
				.HasColumnName("PCT0210157")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210157")
				.IsOptional();

			Property(p => p.PCT0210158)
				.HasColumnName("PCT0210158")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210158")
				.IsOptional();

			Property(p => p.PCT0210159)
				.HasColumnName("PCT0210159")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210159")
				.IsOptional();

			Property(p => p.PCT0210160)
				.HasColumnName("PCT0210160")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210160")
				.IsOptional();

			Property(p => p.PCT0210161)
				.HasColumnName("PCT0210161")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210161")
				.IsOptional();

			Property(p => p.PCT0210162)
				.HasColumnName("PCT0210162")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210162")
				.IsOptional();

			Property(p => p.PCT0210163)
				.HasColumnName("PCT0210163")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210163")
				.IsOptional();

			Property(p => p.PCT0210164)
				.HasColumnName("PCT0210164")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210164")
				.IsOptional();

			Property(p => p.PCT0210165)
				.HasColumnName("PCT0210165")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210165")
				.IsOptional();

			Property(p => p.PCT0210166)
				.HasColumnName("PCT0210166")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210166")
				.IsOptional();

			Property(p => p.PCT0210167)
				.HasColumnName("PCT0210167")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210167")
				.IsOptional();

			Property(p => p.PCT0210168)
				.HasColumnName("PCT0210168")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210168")
				.IsOptional();

			Property(p => p.PCT0210169)
				.HasColumnName("PCT0210169")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210169")
				.IsOptional();

			Property(p => p.PCT0210170)
				.HasColumnName("PCT0210170")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210170")
				.IsOptional();

			Property(p => p.PCT0210171)
				.HasColumnName("PCT0210171")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210171")
				.IsOptional();

			Property(p => p.PCT0210172)
				.HasColumnName("PCT0210172")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210172")
				.IsOptional();

			Property(p => p.PCT0210173)
				.HasColumnName("PCT0210173")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210173")
				.IsOptional();

			Property(p => p.PCT0210174)
				.HasColumnName("PCT0210174")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210174")
				.IsOptional();

			Property(p => p.PCT0210175)
				.HasColumnName("PCT0210175")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210175")
				.IsOptional();

			Property(p => p.PCT0210176)
				.HasColumnName("PCT0210176")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210176")
				.IsOptional();

			Property(p => p.PCT0210177)
				.HasColumnName("PCT0210177")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210177")
				.IsOptional();

			Property(p => p.PCT0210178)
				.HasColumnName("PCT0210178")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210178")
				.IsOptional();

			Property(p => p.PCT0210179)
				.HasColumnName("PCT0210179")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210179")
				.IsOptional();

			Property(p => p.PCT0210180)
				.HasColumnName("PCT0210180")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210180")
				.IsOptional();

			Property(p => p.PCT0210181)
				.HasColumnName("PCT0210181")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210181")
				.IsOptional();

			Property(p => p.PCT0210182)
				.HasColumnName("PCT0210182")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210182")
				.IsOptional();

			Property(p => p.PCT0210183)
				.HasColumnName("PCT0210183")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210183")
				.IsOptional();

			Property(p => p.PCT0210184)
				.HasColumnName("PCT0210184")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210184")
				.IsOptional();

			Property(p => p.PCT0210185)
				.HasColumnName("PCT0210185")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210185")
				.IsOptional();

			Property(p => p.PCT0210186)
				.HasColumnName("PCT0210186")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210186")
				.IsOptional();

			Property(p => p.PCT0210187)
				.HasColumnName("PCT0210187")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210187")
				.IsOptional();

			Property(p => p.PCT0210188)
				.HasColumnName("PCT0210188")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210188")
				.IsOptional();

			Property(p => p.PCT0210189)
				.HasColumnName("PCT0210189")
				.HasColumnOrder(193)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210189")
				.IsOptional();

			Property(p => p.PCT0210190)
				.HasColumnName("PCT0210190")
				.HasColumnOrder(194)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210190")
				.IsOptional();

			Property(p => p.PCT0210191)
				.HasColumnName("PCT0210191")
				.HasColumnOrder(195)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210191")
				.IsOptional();

			Property(p => p.PCT0210192)
				.HasColumnName("PCT0210192")
				.HasColumnOrder(196)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210192")
				.IsOptional();

			Property(p => p.PCT0210193)
				.HasColumnName("PCT0210193")
				.HasColumnOrder(197)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210193")
				.IsOptional();

			Property(p => p.PCT0210194)
				.HasColumnName("PCT0210194")
				.HasColumnOrder(198)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210194")
				.IsOptional();

			Property(p => p.PCT0210195)
				.HasColumnName("PCT0210195")
				.HasColumnOrder(199)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0210195")
				.IsOptional();

			Property(p => p.PCT0220001)
				.HasColumnName("PCT0220001")
				.HasColumnOrder(200)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0220001")
				.IsOptional();

			Property(p => p.PCT0220002)
				.HasColumnName("PCT0220002")
				.HasColumnOrder(201)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0220002")
				.IsOptional();

			Property(p => p.PCT0220003)
				.HasColumnName("PCT0220003")
				.HasColumnOrder(202)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0220003")
				.IsOptional();

			Property(p => p.PCT0220004)
				.HasColumnName("PCT0220004")
				.HasColumnOrder(203)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0220004")
				.IsOptional();

			Property(p => p.PCT0220005)
				.HasColumnName("PCT0220005")
				.HasColumnOrder(204)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0220005")
				.IsOptional();

			Property(p => p.PCT0220006)
				.HasColumnName("PCT0220006")
				.HasColumnOrder(205)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0220006")
				.IsOptional();

			Property(p => p.PCT0220007)
				.HasColumnName("PCT0220007")
				.HasColumnOrder(206)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0220007")
				.IsOptional();

			Property(p => p.PCT0220008)
				.HasColumnName("PCT0220008")
				.HasColumnOrder(207)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0220008")
				.IsOptional();

			Property(p => p.PCT0220009)
				.HasColumnName("PCT0220009")
				.HasColumnOrder(208)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0220009")
				.IsOptional();

			Property(p => p.PCT0220010)
				.HasColumnName("PCT0220010")
				.HasColumnOrder(209)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0220010")
				.IsOptional();

			Property(p => p.PCT0220011)
				.HasColumnName("PCT0220011")
				.HasColumnOrder(210)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0220011")
				.IsOptional();

			Property(p => p.PCT0220012)
				.HasColumnName("PCT0220012")
				.HasColumnOrder(211)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0220012")
				.IsOptional();

			Property(p => p.PCT0220013)
				.HasColumnName("PCT0220013")
				.HasColumnOrder(212)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0220013")
				.IsOptional();

			Property(p => p.PCT0220014)
				.HasColumnName("PCT0220014")
				.HasColumnOrder(213)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0220014")
				.IsOptional();

			Property(p => p.PCT0220015)
				.HasColumnName("PCT0220015")
				.HasColumnOrder(214)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0220015")
				.IsOptional();

			Property(p => p.PCT0220016)
				.HasColumnName("PCT0220016")
				.HasColumnOrder(215)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0220016")
				.IsOptional();

			Property(p => p.PCT0220017)
				.HasColumnName("PCT0220017")
				.HasColumnOrder(216)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0220017")
				.IsOptional();

			Property(p => p.PCT0220018)
				.HasColumnName("PCT0220018")
				.HasColumnOrder(217)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0220018")
				.IsOptional();

			Property(p => p.PCT0220019)
				.HasColumnName("PCT0220019")
				.HasColumnOrder(218)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0220019")
				.IsOptional();

			Property(p => p.PCT0220020)
				.HasColumnName("PCT0220020")
				.HasColumnOrder(219)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0220020")
				.IsOptional();

			Property(p => p.PCT0220021)
				.HasColumnName("PCT0220021")
				.HasColumnOrder(220)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0220021")
				.IsOptional();
		}
	}
}
