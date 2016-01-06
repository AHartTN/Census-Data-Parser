#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/06/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SummaryTwo_SF2_Segment_09Map.cs
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

	public class SummaryTwo_SF2_Segment_09Map : EntityTypeConfiguration<SummaryTwo_SF2_Segment_09>
	{
		public SummaryTwo_SF2_Segment_09Map()
		{
			ToTable("SF2_Segment_09", "SummaryTwo");

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

			Property(p => p.PCO0080001)
				.HasColumnName("PCO0080001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080001")
				.IsOptional();

			Property(p => p.PCO0080002)
				.HasColumnName("PCO0080002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080002")
				.IsOptional();

			Property(p => p.PCO0080003)
				.HasColumnName("PCO0080003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080003")
				.IsOptional();

			Property(p => p.PCO0080004)
				.HasColumnName("PCO0080004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080004")
				.IsOptional();

			Property(p => p.PCO0080005)
				.HasColumnName("PCO0080005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080005")
				.IsOptional();

			Property(p => p.PCO0080006)
				.HasColumnName("PCO0080006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080006")
				.IsOptional();

			Property(p => p.PCO0080007)
				.HasColumnName("PCO0080007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080007")
				.IsOptional();

			Property(p => p.PCO0080008)
				.HasColumnName("PCO0080008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080008")
				.IsOptional();

			Property(p => p.PCO0080009)
				.HasColumnName("PCO0080009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080009")
				.IsOptional();

			Property(p => p.PCO0080010)
				.HasColumnName("PCO0080010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080010")
				.IsOptional();

			Property(p => p.PCO0080011)
				.HasColumnName("PCO0080011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080011")
				.IsOptional();

			Property(p => p.PCO0080012)
				.HasColumnName("PCO0080012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080012")
				.IsOptional();

			Property(p => p.PCO0080013)
				.HasColumnName("PCO0080013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080013")
				.IsOptional();

			Property(p => p.PCO0080014)
				.HasColumnName("PCO0080014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080014")
				.IsOptional();

			Property(p => p.PCO0080015)
				.HasColumnName("PCO0080015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080015")
				.IsOptional();

			Property(p => p.PCO0080016)
				.HasColumnName("PCO0080016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080016")
				.IsOptional();

			Property(p => p.PCO0080017)
				.HasColumnName("PCO0080017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080017")
				.IsOptional();

			Property(p => p.PCO0080018)
				.HasColumnName("PCO0080018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080018")
				.IsOptional();

			Property(p => p.PCO0080019)
				.HasColumnName("PCO0080019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080019")
				.IsOptional();

			Property(p => p.PCO0080020)
				.HasColumnName("PCO0080020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080020")
				.IsOptional();

			Property(p => p.PCO0080021)
				.HasColumnName("PCO0080021")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080021")
				.IsOptional();

			Property(p => p.PCO0080022)
				.HasColumnName("PCO0080022")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080022")
				.IsOptional();

			Property(p => p.PCO0080023)
				.HasColumnName("PCO0080023")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080023")
				.IsOptional();

			Property(p => p.PCO0080024)
				.HasColumnName("PCO0080024")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080024")
				.IsOptional();

			Property(p => p.PCO0080025)
				.HasColumnName("PCO0080025")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080025")
				.IsOptional();

			Property(p => p.PCO0090001)
				.HasColumnName("PCO0090001")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090001")
				.IsOptional();

			Property(p => p.PCO0090002)
				.HasColumnName("PCO0090002")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090002")
				.IsOptional();

			Property(p => p.PCO0090003)
				.HasColumnName("PCO0090003")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090003")
				.IsOptional();

			Property(p => p.PCO0090004)
				.HasColumnName("PCO0090004")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090004")
				.IsOptional();

			Property(p => p.PCO0090005)
				.HasColumnName("PCO0090005")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090005")
				.IsOptional();

			Property(p => p.PCO0090006)
				.HasColumnName("PCO0090006")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090006")
				.IsOptional();

			Property(p => p.PCO0090007)
				.HasColumnName("PCO0090007")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090007")
				.IsOptional();

			Property(p => p.PCO0090008)
				.HasColumnName("PCO0090008")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090008")
				.IsOptional();

			Property(p => p.PCO0090009)
				.HasColumnName("PCO0090009")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090009")
				.IsOptional();

			Property(p => p.PCO0090010)
				.HasColumnName("PCO0090010")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090010")
				.IsOptional();

			Property(p => p.PCO0090011)
				.HasColumnName("PCO0090011")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090011")
				.IsOptional();

			Property(p => p.PCO0090012)
				.HasColumnName("PCO0090012")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090012")
				.IsOptional();

			Property(p => p.PCO0090013)
				.HasColumnName("PCO0090013")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090013")
				.IsOptional();

			Property(p => p.PCO0090014)
				.HasColumnName("PCO0090014")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090014")
				.IsOptional();

			Property(p => p.PCO0090015)
				.HasColumnName("PCO0090015")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090015")
				.IsOptional();

			Property(p => p.PCO0090016)
				.HasColumnName("PCO0090016")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090016")
				.IsOptional();

			Property(p => p.PCO0090017)
				.HasColumnName("PCO0090017")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090017")
				.IsOptional();

			Property(p => p.PCO0090018)
				.HasColumnName("PCO0090018")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090018")
				.IsOptional();

			Property(p => p.PCO0090019)
				.HasColumnName("PCO0090019")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090019")
				.IsOptional();

			Property(p => p.PCO0090020)
				.HasColumnName("PCO0090020")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090020")
				.IsOptional();

			Property(p => p.PCO0090021)
				.HasColumnName("PCO0090021")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090021")
				.IsOptional();

			Property(p => p.PCO0090022)
				.HasColumnName("PCO0090022")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090022")
				.IsOptional();

			Property(p => p.PCO0090023)
				.HasColumnName("PCO0090023")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090023")
				.IsOptional();

			Property(p => p.PCO0090024)
				.HasColumnName("PCO0090024")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090024")
				.IsOptional();

			Property(p => p.PCO0090025)
				.HasColumnName("PCO0090025")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090025")
				.IsOptional();

			Property(p => p.PCO0100001)
				.HasColumnName("PCO0100001")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100001")
				.IsOptional();

			Property(p => p.PCO0100002)
				.HasColumnName("PCO0100002")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100002")
				.IsOptional();

			Property(p => p.PCO0100003)
				.HasColumnName("PCO0100003")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100003")
				.IsOptional();

			Property(p => p.PCO0100004)
				.HasColumnName("PCO0100004")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100004")
				.IsOptional();

			Property(p => p.PCO0100005)
				.HasColumnName("PCO0100005")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100005")
				.IsOptional();

			Property(p => p.PCO0100006)
				.HasColumnName("PCO0100006")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100006")
				.IsOptional();

			Property(p => p.PCO0100007)
				.HasColumnName("PCO0100007")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100007")
				.IsOptional();

			Property(p => p.PCO0100008)
				.HasColumnName("PCO0100008")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100008")
				.IsOptional();

			Property(p => p.PCO0100009)
				.HasColumnName("PCO0100009")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100009")
				.IsOptional();

			Property(p => p.PCO0100010)
				.HasColumnName("PCO0100010")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100010")
				.IsOptional();

			Property(p => p.PCO0100011)
				.HasColumnName("PCO0100011")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100011")
				.IsOptional();

			Property(p => p.PCO0100012)
				.HasColumnName("PCO0100012")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100012")
				.IsOptional();

			Property(p => p.PCO0100013)
				.HasColumnName("PCO0100013")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100013")
				.IsOptional();

			Property(p => p.PCO0100014)
				.HasColumnName("PCO0100014")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100014")
				.IsOptional();

			Property(p => p.PCO0100015)
				.HasColumnName("PCO0100015")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100015")
				.IsOptional();

			Property(p => p.PCO0100016)
				.HasColumnName("PCO0100016")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100016")
				.IsOptional();

			Property(p => p.PCO0100017)
				.HasColumnName("PCO0100017")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100017")
				.IsOptional();

			Property(p => p.PCO0100018)
				.HasColumnName("PCO0100018")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100018")
				.IsOptional();

			Property(p => p.PCO0100019)
				.HasColumnName("PCO0100019")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100019")
				.IsOptional();

			Property(p => p.PCO0100020)
				.HasColumnName("PCO0100020")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100020")
				.IsOptional();

			Property(p => p.PCO0100021)
				.HasColumnName("PCO0100021")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100021")
				.IsOptional();

			Property(p => p.PCO0100022)
				.HasColumnName("PCO0100022")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100022")
				.IsOptional();

			Property(p => p.PCO0100023)
				.HasColumnName("PCO0100023")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100023")
				.IsOptional();

			Property(p => p.PCO0100024)
				.HasColumnName("PCO0100024")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100024")
				.IsOptional();

			Property(p => p.PCO0100025)
				.HasColumnName("PCO0100025")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100025")
				.IsOptional();

			Property(p => p.PCO0100026)
				.HasColumnName("PCO0100026")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100026")
				.IsOptional();

			Property(p => p.PCO0100027)
				.HasColumnName("PCO0100027")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100027")
				.IsOptional();

			Property(p => p.PCO0100028)
				.HasColumnName("PCO0100028")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100028")
				.IsOptional();

			Property(p => p.PCO0100029)
				.HasColumnName("PCO0100029")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100029")
				.IsOptional();

			Property(p => p.PCO0100030)
				.HasColumnName("PCO0100030")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100030")
				.IsOptional();

			Property(p => p.PCO0100031)
				.HasColumnName("PCO0100031")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100031")
				.IsOptional();

			Property(p => p.PCO0100032)
				.HasColumnName("PCO0100032")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100032")
				.IsOptional();

			Property(p => p.PCO0100033)
				.HasColumnName("PCO0100033")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100033")
				.IsOptional();

			Property(p => p.PCO0100034)
				.HasColumnName("PCO0100034")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100034")
				.IsOptional();

			Property(p => p.PCO0100035)
				.HasColumnName("PCO0100035")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100035")
				.IsOptional();

			Property(p => p.PCO0100036)
				.HasColumnName("PCO0100036")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100036")
				.IsOptional();

			Property(p => p.PCO0100037)
				.HasColumnName("PCO0100037")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100037")
				.IsOptional();

			Property(p => p.PCO0100038)
				.HasColumnName("PCO0100038")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100038")
				.IsOptional();

			Property(p => p.PCO0100039)
				.HasColumnName("PCO0100039")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100039")
				.IsOptional();
		}
	}
}
