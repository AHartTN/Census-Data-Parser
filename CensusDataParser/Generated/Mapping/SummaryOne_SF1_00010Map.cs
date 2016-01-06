#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/06/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SummaryOne_SF1_00010Map.cs
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

	public class SummaryOne_SF1_00010Map : EntityTypeConfiguration<SummaryOne_SF1_00010>
	{
		public SummaryOne_SF1_00010Map()
		{
			ToTable("SF1_00010", "SummaryOne");

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

			Property(p => p.P029A001)
				.HasColumnName("P029A001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A001")
				.IsOptional();

			Property(p => p.P029A002)
				.HasColumnName("P029A002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A002")
				.IsOptional();

			Property(p => p.P029A003)
				.HasColumnName("P029A003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A003")
				.IsOptional();

			Property(p => p.P029A004)
				.HasColumnName("P029A004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A004")
				.IsOptional();

			Property(p => p.P029A005)
				.HasColumnName("P029A005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A005")
				.IsOptional();

			Property(p => p.P029A006)
				.HasColumnName("P029A006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A006")
				.IsOptional();

			Property(p => p.P029A007)
				.HasColumnName("P029A007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A007")
				.IsOptional();

			Property(p => p.P029A008)
				.HasColumnName("P029A008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A008")
				.IsOptional();

			Property(p => p.P029A009)
				.HasColumnName("P029A009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A009")
				.IsOptional();

			Property(p => p.P029A010)
				.HasColumnName("P029A010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A010")
				.IsOptional();

			Property(p => p.P029A011)
				.HasColumnName("P029A011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A011")
				.IsOptional();

			Property(p => p.P029A012)
				.HasColumnName("P029A012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A012")
				.IsOptional();

			Property(p => p.P029A013)
				.HasColumnName("P029A013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A013")
				.IsOptional();

			Property(p => p.P029A014)
				.HasColumnName("P029A014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A014")
				.IsOptional();

			Property(p => p.P029A015)
				.HasColumnName("P029A015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A015")
				.IsOptional();

			Property(p => p.P029A016)
				.HasColumnName("P029A016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A016")
				.IsOptional();

			Property(p => p.P029A017)
				.HasColumnName("P029A017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A017")
				.IsOptional();

			Property(p => p.P029A018)
				.HasColumnName("P029A018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A018")
				.IsOptional();

			Property(p => p.P029A019)
				.HasColumnName("P029A019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A019")
				.IsOptional();

			Property(p => p.P029A020)
				.HasColumnName("P029A020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A020")
				.IsOptional();

			Property(p => p.P029A021)
				.HasColumnName("P029A021")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A021")
				.IsOptional();

			Property(p => p.P029A022)
				.HasColumnName("P029A022")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A022")
				.IsOptional();

			Property(p => p.P029A023)
				.HasColumnName("P029A023")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A023")
				.IsOptional();

			Property(p => p.P029A024)
				.HasColumnName("P029A024")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A024")
				.IsOptional();

			Property(p => p.P029A025)
				.HasColumnName("P029A025")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A025")
				.IsOptional();

			Property(p => p.P029A026)
				.HasColumnName("P029A026")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A026")
				.IsOptional();

			Property(p => p.P029A027)
				.HasColumnName("P029A027")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A027")
				.IsOptional();

			Property(p => p.P029A028)
				.HasColumnName("P029A028")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029A028")
				.IsOptional();

			Property(p => p.P029B001)
				.HasColumnName("P029B001")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B001")
				.IsOptional();

			Property(p => p.P029B002)
				.HasColumnName("P029B002")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B002")
				.IsOptional();

			Property(p => p.P029B003)
				.HasColumnName("P029B003")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B003")
				.IsOptional();

			Property(p => p.P029B004)
				.HasColumnName("P029B004")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B004")
				.IsOptional();

			Property(p => p.P029B005)
				.HasColumnName("P029B005")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B005")
				.IsOptional();

			Property(p => p.P029B006)
				.HasColumnName("P029B006")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B006")
				.IsOptional();

			Property(p => p.P029B007)
				.HasColumnName("P029B007")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B007")
				.IsOptional();

			Property(p => p.P029B008)
				.HasColumnName("P029B008")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B008")
				.IsOptional();

			Property(p => p.P029B009)
				.HasColumnName("P029B009")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B009")
				.IsOptional();

			Property(p => p.P029B010)
				.HasColumnName("P029B010")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B010")
				.IsOptional();

			Property(p => p.P029B011)
				.HasColumnName("P029B011")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B011")
				.IsOptional();

			Property(p => p.P029B012)
				.HasColumnName("P029B012")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B012")
				.IsOptional();

			Property(p => p.P029B013)
				.HasColumnName("P029B013")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B013")
				.IsOptional();

			Property(p => p.P029B014)
				.HasColumnName("P029B014")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B014")
				.IsOptional();

			Property(p => p.P029B015)
				.HasColumnName("P029B015")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B015")
				.IsOptional();

			Property(p => p.P029B016)
				.HasColumnName("P029B016")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B016")
				.IsOptional();

			Property(p => p.P029B017)
				.HasColumnName("P029B017")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B017")
				.IsOptional();

			Property(p => p.P029B018)
				.HasColumnName("P029B018")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B018")
				.IsOptional();

			Property(p => p.P029B019)
				.HasColumnName("P029B019")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B019")
				.IsOptional();

			Property(p => p.P029B020)
				.HasColumnName("P029B020")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B020")
				.IsOptional();

			Property(p => p.P029B021)
				.HasColumnName("P029B021")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B021")
				.IsOptional();

			Property(p => p.P029B022)
				.HasColumnName("P029B022")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B022")
				.IsOptional();

			Property(p => p.P029B023)
				.HasColumnName("P029B023")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B023")
				.IsOptional();

			Property(p => p.P029B024)
				.HasColumnName("P029B024")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B024")
				.IsOptional();

			Property(p => p.P029B025)
				.HasColumnName("P029B025")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B025")
				.IsOptional();

			Property(p => p.P029B026)
				.HasColumnName("P029B026")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B026")
				.IsOptional();

			Property(p => p.P029B027)
				.HasColumnName("P029B027")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B027")
				.IsOptional();

			Property(p => p.P029B028)
				.HasColumnName("P029B028")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029B028")
				.IsOptional();

			Property(p => p.P029C001)
				.HasColumnName("P029C001")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C001")
				.IsOptional();

			Property(p => p.P029C002)
				.HasColumnName("P029C002")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C002")
				.IsOptional();

			Property(p => p.P029C003)
				.HasColumnName("P029C003")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C003")
				.IsOptional();

			Property(p => p.P029C004)
				.HasColumnName("P029C004")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C004")
				.IsOptional();

			Property(p => p.P029C005)
				.HasColumnName("P029C005")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C005")
				.IsOptional();

			Property(p => p.P029C006)
				.HasColumnName("P029C006")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C006")
				.IsOptional();

			Property(p => p.P029C007)
				.HasColumnName("P029C007")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C007")
				.IsOptional();

			Property(p => p.P029C008)
				.HasColumnName("P029C008")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C008")
				.IsOptional();

			Property(p => p.P029C009)
				.HasColumnName("P029C009")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C009")
				.IsOptional();

			Property(p => p.P029C010)
				.HasColumnName("P029C010")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C010")
				.IsOptional();

			Property(p => p.P029C011)
				.HasColumnName("P029C011")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C011")
				.IsOptional();

			Property(p => p.P029C012)
				.HasColumnName("P029C012")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C012")
				.IsOptional();

			Property(p => p.P029C013)
				.HasColumnName("P029C013")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C013")
				.IsOptional();

			Property(p => p.P029C014)
				.HasColumnName("P029C014")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C014")
				.IsOptional();

			Property(p => p.P029C015)
				.HasColumnName("P029C015")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C015")
				.IsOptional();

			Property(p => p.P029C016)
				.HasColumnName("P029C016")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C016")
				.IsOptional();

			Property(p => p.P029C017)
				.HasColumnName("P029C017")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C017")
				.IsOptional();

			Property(p => p.P029C018)
				.HasColumnName("P029C018")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C018")
				.IsOptional();

			Property(p => p.P029C019)
				.HasColumnName("P029C019")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C019")
				.IsOptional();

			Property(p => p.P029C020)
				.HasColumnName("P029C020")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C020")
				.IsOptional();

			Property(p => p.P029C021)
				.HasColumnName("P029C021")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C021")
				.IsOptional();

			Property(p => p.P029C022)
				.HasColumnName("P029C022")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C022")
				.IsOptional();

			Property(p => p.P029C023)
				.HasColumnName("P029C023")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C023")
				.IsOptional();

			Property(p => p.P029C024)
				.HasColumnName("P029C024")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C024")
				.IsOptional();

			Property(p => p.P029C025)
				.HasColumnName("P029C025")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C025")
				.IsOptional();

			Property(p => p.P029C026)
				.HasColumnName("P029C026")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C026")
				.IsOptional();

			Property(p => p.P029C027)
				.HasColumnName("P029C027")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C027")
				.IsOptional();

			Property(p => p.P029C028)
				.HasColumnName("P029C028")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029C028")
				.IsOptional();

			Property(p => p.P029D001)
				.HasColumnName("P029D001")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D001")
				.IsOptional();

			Property(p => p.P029D002)
				.HasColumnName("P029D002")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D002")
				.IsOptional();

			Property(p => p.P029D003)
				.HasColumnName("P029D003")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D003")
				.IsOptional();

			Property(p => p.P029D004)
				.HasColumnName("P029D004")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D004")
				.IsOptional();

			Property(p => p.P029D005)
				.HasColumnName("P029D005")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D005")
				.IsOptional();

			Property(p => p.P029D006)
				.HasColumnName("P029D006")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D006")
				.IsOptional();

			Property(p => p.P029D007)
				.HasColumnName("P029D007")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D007")
				.IsOptional();

			Property(p => p.P029D008)
				.HasColumnName("P029D008")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D008")
				.IsOptional();

			Property(p => p.P029D009)
				.HasColumnName("P029D009")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D009")
				.IsOptional();

			Property(p => p.P029D010)
				.HasColumnName("P029D010")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D010")
				.IsOptional();

			Property(p => p.P029D011)
				.HasColumnName("P029D011")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D011")
				.IsOptional();

			Property(p => p.P029D012)
				.HasColumnName("P029D012")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D012")
				.IsOptional();

			Property(p => p.P029D013)
				.HasColumnName("P029D013")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D013")
				.IsOptional();

			Property(p => p.P029D014)
				.HasColumnName("P029D014")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D014")
				.IsOptional();

			Property(p => p.P029D015)
				.HasColumnName("P029D015")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D015")
				.IsOptional();

			Property(p => p.P029D016)
				.HasColumnName("P029D016")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D016")
				.IsOptional();

			Property(p => p.P029D017)
				.HasColumnName("P029D017")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D017")
				.IsOptional();

			Property(p => p.P029D018)
				.HasColumnName("P029D018")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D018")
				.IsOptional();

			Property(p => p.P029D019)
				.HasColumnName("P029D019")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D019")
				.IsOptional();

			Property(p => p.P029D020)
				.HasColumnName("P029D020")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D020")
				.IsOptional();

			Property(p => p.P029D021)
				.HasColumnName("P029D021")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D021")
				.IsOptional();

			Property(p => p.P029D022)
				.HasColumnName("P029D022")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D022")
				.IsOptional();

			Property(p => p.P029D023)
				.HasColumnName("P029D023")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D023")
				.IsOptional();

			Property(p => p.P029D024)
				.HasColumnName("P029D024")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D024")
				.IsOptional();

			Property(p => p.P029D025)
				.HasColumnName("P029D025")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D025")
				.IsOptional();

			Property(p => p.P029D026)
				.HasColumnName("P029D026")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D026")
				.IsOptional();

			Property(p => p.P029D027)
				.HasColumnName("P029D027")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D027")
				.IsOptional();

			Property(p => p.P029D028)
				.HasColumnName("P029D028")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029D028")
				.IsOptional();

			Property(p => p.P029E001)
				.HasColumnName("P029E001")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E001")
				.IsOptional();

			Property(p => p.P029E002)
				.HasColumnName("P029E002")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E002")
				.IsOptional();

			Property(p => p.P029E003)
				.HasColumnName("P029E003")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E003")
				.IsOptional();

			Property(p => p.P029E004)
				.HasColumnName("P029E004")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E004")
				.IsOptional();

			Property(p => p.P029E005)
				.HasColumnName("P029E005")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E005")
				.IsOptional();

			Property(p => p.P029E006)
				.HasColumnName("P029E006")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E006")
				.IsOptional();

			Property(p => p.P029E007)
				.HasColumnName("P029E007")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E007")
				.IsOptional();

			Property(p => p.P029E008)
				.HasColumnName("P029E008")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E008")
				.IsOptional();

			Property(p => p.P029E009)
				.HasColumnName("P029E009")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E009")
				.IsOptional();

			Property(p => p.P029E010)
				.HasColumnName("P029E010")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E010")
				.IsOptional();

			Property(p => p.P029E011)
				.HasColumnName("P029E011")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E011")
				.IsOptional();

			Property(p => p.P029E012)
				.HasColumnName("P029E012")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E012")
				.IsOptional();

			Property(p => p.P029E013)
				.HasColumnName("P029E013")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E013")
				.IsOptional();

			Property(p => p.P029E014)
				.HasColumnName("P029E014")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E014")
				.IsOptional();

			Property(p => p.P029E015)
				.HasColumnName("P029E015")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E015")
				.IsOptional();

			Property(p => p.P029E016)
				.HasColumnName("P029E016")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E016")
				.IsOptional();

			Property(p => p.P029E017)
				.HasColumnName("P029E017")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E017")
				.IsOptional();

			Property(p => p.P029E018)
				.HasColumnName("P029E018")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E018")
				.IsOptional();

			Property(p => p.P029E019)
				.HasColumnName("P029E019")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E019")
				.IsOptional();

			Property(p => p.P029E020)
				.HasColumnName("P029E020")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E020")
				.IsOptional();

			Property(p => p.P029E021)
				.HasColumnName("P029E021")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E021")
				.IsOptional();

			Property(p => p.P029E022)
				.HasColumnName("P029E022")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E022")
				.IsOptional();

			Property(p => p.P029E023)
				.HasColumnName("P029E023")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E023")
				.IsOptional();

			Property(p => p.P029E024)
				.HasColumnName("P029E024")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E024")
				.IsOptional();

			Property(p => p.P029E025)
				.HasColumnName("P029E025")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E025")
				.IsOptional();

			Property(p => p.P029E026)
				.HasColumnName("P029E026")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E026")
				.IsOptional();

			Property(p => p.P029E027)
				.HasColumnName("P029E027")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E027")
				.IsOptional();

			Property(p => p.P029E028)
				.HasColumnName("P029E028")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029E028")
				.IsOptional();

			Property(p => p.P029F001)
				.HasColumnName("P029F001")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F001")
				.IsOptional();

			Property(p => p.P029F002)
				.HasColumnName("P029F002")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F002")
				.IsOptional();

			Property(p => p.P029F003)
				.HasColumnName("P029F003")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F003")
				.IsOptional();

			Property(p => p.P029F004)
				.HasColumnName("P029F004")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F004")
				.IsOptional();

			Property(p => p.P029F005)
				.HasColumnName("P029F005")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F005")
				.IsOptional();

			Property(p => p.P029F006)
				.HasColumnName("P029F006")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F006")
				.IsOptional();

			Property(p => p.P029F007)
				.HasColumnName("P029F007")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F007")
				.IsOptional();

			Property(p => p.P029F008)
				.HasColumnName("P029F008")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F008")
				.IsOptional();

			Property(p => p.P029F009)
				.HasColumnName("P029F009")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F009")
				.IsOptional();

			Property(p => p.P029F010)
				.HasColumnName("P029F010")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F010")
				.IsOptional();

			Property(p => p.P029F011)
				.HasColumnName("P029F011")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F011")
				.IsOptional();

			Property(p => p.P029F012)
				.HasColumnName("P029F012")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F012")
				.IsOptional();

			Property(p => p.P029F013)
				.HasColumnName("P029F013")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F013")
				.IsOptional();

			Property(p => p.P029F014)
				.HasColumnName("P029F014")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F014")
				.IsOptional();

			Property(p => p.P029F015)
				.HasColumnName("P029F015")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F015")
				.IsOptional();

			Property(p => p.P029F016)
				.HasColumnName("P029F016")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F016")
				.IsOptional();

			Property(p => p.P029F017)
				.HasColumnName("P029F017")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F017")
				.IsOptional();

			Property(p => p.P029F018)
				.HasColumnName("P029F018")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F018")
				.IsOptional();

			Property(p => p.P029F019)
				.HasColumnName("P029F019")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F019")
				.IsOptional();

			Property(p => p.P029F020)
				.HasColumnName("P029F020")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F020")
				.IsOptional();

			Property(p => p.P029F021)
				.HasColumnName("P029F021")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F021")
				.IsOptional();

			Property(p => p.P029F022)
				.HasColumnName("P029F022")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F022")
				.IsOptional();

			Property(p => p.P029F023)
				.HasColumnName("P029F023")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F023")
				.IsOptional();

			Property(p => p.P029F024)
				.HasColumnName("P029F024")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F024")
				.IsOptional();

			Property(p => p.P029F025)
				.HasColumnName("P029F025")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F025")
				.IsOptional();

			Property(p => p.P029F026)
				.HasColumnName("P029F026")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F026")
				.IsOptional();

			Property(p => p.P029F027)
				.HasColumnName("P029F027")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F027")
				.IsOptional();

			Property(p => p.P029F028)
				.HasColumnName("P029F028")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029F028")
				.IsOptional();

			Property(p => p.P029G001)
				.HasColumnName("P029G001")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G001")
				.IsOptional();

			Property(p => p.P029G002)
				.HasColumnName("P029G002")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G002")
				.IsOptional();

			Property(p => p.P029G003)
				.HasColumnName("P029G003")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G003")
				.IsOptional();

			Property(p => p.P029G004)
				.HasColumnName("P029G004")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G004")
				.IsOptional();

			Property(p => p.P029G005)
				.HasColumnName("P029G005")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G005")
				.IsOptional();

			Property(p => p.P029G006)
				.HasColumnName("P029G006")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G006")
				.IsOptional();

			Property(p => p.P029G007)
				.HasColumnName("P029G007")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G007")
				.IsOptional();

			Property(p => p.P029G008)
				.HasColumnName("P029G008")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G008")
				.IsOptional();

			Property(p => p.P029G009)
				.HasColumnName("P029G009")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G009")
				.IsOptional();

			Property(p => p.P029G010)
				.HasColumnName("P029G010")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G010")
				.IsOptional();

			Property(p => p.P029G011)
				.HasColumnName("P029G011")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G011")
				.IsOptional();

			Property(p => p.P029G012)
				.HasColumnName("P029G012")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G012")
				.IsOptional();

			Property(p => p.P029G013)
				.HasColumnName("P029G013")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G013")
				.IsOptional();

			Property(p => p.P029G014)
				.HasColumnName("P029G014")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G014")
				.IsOptional();

			Property(p => p.P029G015)
				.HasColumnName("P029G015")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G015")
				.IsOptional();

			Property(p => p.P029G016)
				.HasColumnName("P029G016")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G016")
				.IsOptional();

			Property(p => p.P029G017)
				.HasColumnName("P029G017")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G017")
				.IsOptional();

			Property(p => p.P029G018)
				.HasColumnName("P029G018")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G018")
				.IsOptional();

			Property(p => p.P029G019)
				.HasColumnName("P029G019")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G019")
				.IsOptional();

			Property(p => p.P029G020)
				.HasColumnName("P029G020")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G020")
				.IsOptional();

			Property(p => p.P029G021)
				.HasColumnName("P029G021")
				.HasColumnOrder(193)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G021")
				.IsOptional();

			Property(p => p.P029G022)
				.HasColumnName("P029G022")
				.HasColumnOrder(194)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G022")
				.IsOptional();

			Property(p => p.P029G023)
				.HasColumnName("P029G023")
				.HasColumnOrder(195)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G023")
				.IsOptional();

			Property(p => p.P029G024)
				.HasColumnName("P029G024")
				.HasColumnOrder(196)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G024")
				.IsOptional();

			Property(p => p.P029G025)
				.HasColumnName("P029G025")
				.HasColumnOrder(197)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G025")
				.IsOptional();

			Property(p => p.P029G026)
				.HasColumnName("P029G026")
				.HasColumnOrder(198)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G026")
				.IsOptional();

			Property(p => p.P029G027)
				.HasColumnName("P029G027")
				.HasColumnOrder(199)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G027")
				.IsOptional();

			Property(p => p.P029G028)
				.HasColumnName("P029G028")
				.HasColumnOrder(200)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029G028")
				.IsOptional();

			Property(p => p.P029H001)
				.HasColumnName("P029H001")
				.HasColumnOrder(201)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H001")
				.IsOptional();

			Property(p => p.P029H002)
				.HasColumnName("P029H002")
				.HasColumnOrder(202)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H002")
				.IsOptional();

			Property(p => p.P029H003)
				.HasColumnName("P029H003")
				.HasColumnOrder(203)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H003")
				.IsOptional();

			Property(p => p.P029H004)
				.HasColumnName("P029H004")
				.HasColumnOrder(204)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H004")
				.IsOptional();

			Property(p => p.P029H005)
				.HasColumnName("P029H005")
				.HasColumnOrder(205)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H005")
				.IsOptional();

			Property(p => p.P029H006)
				.HasColumnName("P029H006")
				.HasColumnOrder(206)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H006")
				.IsOptional();

			Property(p => p.P029H007)
				.HasColumnName("P029H007")
				.HasColumnOrder(207)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H007")
				.IsOptional();

			Property(p => p.P029H008)
				.HasColumnName("P029H008")
				.HasColumnOrder(208)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H008")
				.IsOptional();

			Property(p => p.P029H009)
				.HasColumnName("P029H009")
				.HasColumnOrder(209)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H009")
				.IsOptional();

			Property(p => p.P029H010)
				.HasColumnName("P029H010")
				.HasColumnOrder(210)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H010")
				.IsOptional();

			Property(p => p.P029H011)
				.HasColumnName("P029H011")
				.HasColumnOrder(211)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H011")
				.IsOptional();

			Property(p => p.P029H012)
				.HasColumnName("P029H012")
				.HasColumnOrder(212)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H012")
				.IsOptional();

			Property(p => p.P029H013)
				.HasColumnName("P029H013")
				.HasColumnOrder(213)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H013")
				.IsOptional();

			Property(p => p.P029H014)
				.HasColumnName("P029H014")
				.HasColumnOrder(214)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H014")
				.IsOptional();

			Property(p => p.P029H015)
				.HasColumnName("P029H015")
				.HasColumnOrder(215)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H015")
				.IsOptional();

			Property(p => p.P029H016)
				.HasColumnName("P029H016")
				.HasColumnOrder(216)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H016")
				.IsOptional();

			Property(p => p.P029H017)
				.HasColumnName("P029H017")
				.HasColumnOrder(217)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H017")
				.IsOptional();

			Property(p => p.P029H018)
				.HasColumnName("P029H018")
				.HasColumnOrder(218)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H018")
				.IsOptional();

			Property(p => p.P029H019)
				.HasColumnName("P029H019")
				.HasColumnOrder(219)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H019")
				.IsOptional();

			Property(p => p.P029H020)
				.HasColumnName("P029H020")
				.HasColumnOrder(220)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H020")
				.IsOptional();

			Property(p => p.P029H021)
				.HasColumnName("P029H021")
				.HasColumnOrder(221)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H021")
				.IsOptional();

			Property(p => p.P029H022)
				.HasColumnName("P029H022")
				.HasColumnOrder(222)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H022")
				.IsOptional();

			Property(p => p.P029H023)
				.HasColumnName("P029H023")
				.HasColumnOrder(223)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H023")
				.IsOptional();

			Property(p => p.P029H024)
				.HasColumnName("P029H024")
				.HasColumnOrder(224)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H024")
				.IsOptional();

			Property(p => p.P029H025)
				.HasColumnName("P029H025")
				.HasColumnOrder(225)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H025")
				.IsOptional();

			Property(p => p.P029H026)
				.HasColumnName("P029H026")
				.HasColumnOrder(226)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H026")
				.IsOptional();

			Property(p => p.P029H027)
				.HasColumnName("P029H027")
				.HasColumnOrder(227)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H027")
				.IsOptional();

			Property(p => p.P029H028)
				.HasColumnName("P029H028")
				.HasColumnOrder(228)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029H028")
				.IsOptional();

			Property(p => p.P029I001)
				.HasColumnName("P029I001")
				.HasColumnOrder(229)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I001")
				.IsOptional();

			Property(p => p.P029I002)
				.HasColumnName("P029I002")
				.HasColumnOrder(230)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I002")
				.IsOptional();

			Property(p => p.P029I003)
				.HasColumnName("P029I003")
				.HasColumnOrder(231)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I003")
				.IsOptional();

			Property(p => p.P029I004)
				.HasColumnName("P029I004")
				.HasColumnOrder(232)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I004")
				.IsOptional();

			Property(p => p.P029I005)
				.HasColumnName("P029I005")
				.HasColumnOrder(233)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I005")
				.IsOptional();

			Property(p => p.P029I006)
				.HasColumnName("P029I006")
				.HasColumnOrder(234)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I006")
				.IsOptional();

			Property(p => p.P029I007)
				.HasColumnName("P029I007")
				.HasColumnOrder(235)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I007")
				.IsOptional();

			Property(p => p.P029I008)
				.HasColumnName("P029I008")
				.HasColumnOrder(236)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I008")
				.IsOptional();

			Property(p => p.P029I009)
				.HasColumnName("P029I009")
				.HasColumnOrder(237)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I009")
				.IsOptional();

			Property(p => p.P029I010)
				.HasColumnName("P029I010")
				.HasColumnOrder(238)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I010")
				.IsOptional();

			Property(p => p.P029I011)
				.HasColumnName("P029I011")
				.HasColumnOrder(239)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I011")
				.IsOptional();

			Property(p => p.P029I012)
				.HasColumnName("P029I012")
				.HasColumnOrder(240)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I012")
				.IsOptional();

			Property(p => p.P029I013)
				.HasColumnName("P029I013")
				.HasColumnOrder(241)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I013")
				.IsOptional();

			Property(p => p.P029I014)
				.HasColumnName("P029I014")
				.HasColumnOrder(242)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I014")
				.IsOptional();

			Property(p => p.P029I015)
				.HasColumnName("P029I015")
				.HasColumnOrder(243)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I015")
				.IsOptional();

			Property(p => p.P029I016)
				.HasColumnName("P029I016")
				.HasColumnOrder(244)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I016")
				.IsOptional();

			Property(p => p.P029I017)
				.HasColumnName("P029I017")
				.HasColumnOrder(245)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I017")
				.IsOptional();

			Property(p => p.P029I018)
				.HasColumnName("P029I018")
				.HasColumnOrder(246)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I018")
				.IsOptional();

			Property(p => p.P029I019)
				.HasColumnName("P029I019")
				.HasColumnOrder(247)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I019")
				.IsOptional();

			Property(p => p.P029I020)
				.HasColumnName("P029I020")
				.HasColumnOrder(248)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I020")
				.IsOptional();

			Property(p => p.P029I021)
				.HasColumnName("P029I021")
				.HasColumnOrder(249)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I021")
				.IsOptional();

			Property(p => p.P029I022)
				.HasColumnName("P029I022")
				.HasColumnOrder(250)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I022")
				.IsOptional();

			Property(p => p.P029I023)
				.HasColumnName("P029I023")
				.HasColumnOrder(251)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I023")
				.IsOptional();

			Property(p => p.P029I024)
				.HasColumnName("P029I024")
				.HasColumnOrder(252)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I024")
				.IsOptional();

			Property(p => p.P029I025)
				.HasColumnName("P029I025")
				.HasColumnOrder(253)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I025")
				.IsOptional();

			Property(p => p.P029I026)
				.HasColumnName("P029I026")
				.HasColumnOrder(254)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I026")
				.IsOptional();

			Property(p => p.P029I027)
				.HasColumnName("P029I027")
				.HasColumnOrder(255)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I027")
				.IsOptional();

			Property(p => p.P029I028)
				.HasColumnName("P029I028")
				.HasColumnOrder(256)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P029I028")
				.IsOptional();
		}
	}
}
