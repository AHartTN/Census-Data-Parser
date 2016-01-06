#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/06/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1CongressionalDistricts113_SF1_00009Map.cs
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

	public class SF1CongressionalDistricts113_SF1_00009Map : EntityTypeConfiguration<SF1CongressionalDistricts113_SF1_00009>
	{
		public SF1CongressionalDistricts113_SF1_00009Map()
		{
			ToTable("SF1_00009", "SF1CongressionalDistricts113");

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

			Property(p => p.P017B001)
				.HasColumnName("P017B001")
				.HasColumnOrder(5)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P017B001")
				.IsOptional();

			Property(p => p.P017B002)
				.HasColumnName("P017B002")
				.HasColumnOrder(6)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P017B002")
				.IsOptional();

			Property(p => p.P017B003)
				.HasColumnName("P017B003")
				.HasColumnOrder(7)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P017B003")
				.IsOptional();

			Property(p => p.P017C001)
				.HasColumnName("P017C001")
				.HasColumnOrder(8)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P017C001")
				.IsOptional();

			Property(p => p.P017C002)
				.HasColumnName("P017C002")
				.HasColumnOrder(9)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P017C002")
				.IsOptional();

			Property(p => p.P017C003)
				.HasColumnName("P017C003")
				.HasColumnOrder(10)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P017C003")
				.IsOptional();

			Property(p => p.P017D001)
				.HasColumnName("P017D001")
				.HasColumnOrder(11)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P017D001")
				.IsOptional();

			Property(p => p.P017D002)
				.HasColumnName("P017D002")
				.HasColumnOrder(12)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P017D002")
				.IsOptional();

			Property(p => p.P017D003)
				.HasColumnName("P017D003")
				.HasColumnOrder(13)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P017D003")
				.IsOptional();

			Property(p => p.P017E001)
				.HasColumnName("P017E001")
				.HasColumnOrder(14)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P017E001")
				.IsOptional();

			Property(p => p.P017E002)
				.HasColumnName("P017E002")
				.HasColumnOrder(15)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P017E002")
				.IsOptional();

			Property(p => p.P017E003)
				.HasColumnName("P017E003")
				.HasColumnOrder(16)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P017E003")
				.IsOptional();

			Property(p => p.P017F001)
				.HasColumnName("P017F001")
				.HasColumnOrder(17)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P017F001")
				.IsOptional();

			Property(p => p.P017F002)
				.HasColumnName("P017F002")
				.HasColumnOrder(18)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P017F002")
				.IsOptional();

			Property(p => p.P017F003)
				.HasColumnName("P017F003")
				.HasColumnOrder(19)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P017F003")
				.IsOptional();

			Property(p => p.P017G001)
				.HasColumnName("P017G001")
				.HasColumnOrder(20)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P017G001")
				.IsOptional();

			Property(p => p.P017G002)
				.HasColumnName("P017G002")
				.HasColumnOrder(21)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P017G002")
				.IsOptional();

			Property(p => p.P017G003)
				.HasColumnName("P017G003")
				.HasColumnOrder(22)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P017G003")
				.IsOptional();

			Property(p => p.P017H001)
				.HasColumnName("P017H001")
				.HasColumnOrder(23)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P017H001")
				.IsOptional();

			Property(p => p.P017H002)
				.HasColumnName("P017H002")
				.HasColumnOrder(24)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P017H002")
				.IsOptional();

			Property(p => p.P017H003)
				.HasColumnName("P017H003")
				.HasColumnOrder(25)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P017H003")
				.IsOptional();

			Property(p => p.P017I001)
				.HasColumnName("P017I001")
				.HasColumnOrder(26)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P017I001")
				.IsOptional();

			Property(p => p.P017I002)
				.HasColumnName("P017I002")
				.HasColumnOrder(27)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P017I002")
				.IsOptional();

			Property(p => p.P017I003)
				.HasColumnName("P017I003")
				.HasColumnOrder(28)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P017I003")
				.IsOptional();

			Property(p => p.P018A001)
				.HasColumnName("P018A001")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018A001")
				.IsOptional();

			Property(p => p.P018A002)
				.HasColumnName("P018A002")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018A002")
				.IsOptional();

			Property(p => p.P018A003)
				.HasColumnName("P018A003")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018A003")
				.IsOptional();

			Property(p => p.P018A004)
				.HasColumnName("P018A004")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018A004")
				.IsOptional();

			Property(p => p.P018A005)
				.HasColumnName("P018A005")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018A005")
				.IsOptional();

			Property(p => p.P018A006)
				.HasColumnName("P018A006")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018A006")
				.IsOptional();

			Property(p => p.P018A007)
				.HasColumnName("P018A007")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018A007")
				.IsOptional();

			Property(p => p.P018A008)
				.HasColumnName("P018A008")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018A008")
				.IsOptional();

			Property(p => p.P018A009)
				.HasColumnName("P018A009")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018A009")
				.IsOptional();

			Property(p => p.P018B001)
				.HasColumnName("P018B001")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018B001")
				.IsOptional();

			Property(p => p.P018B002)
				.HasColumnName("P018B002")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018B002")
				.IsOptional();

			Property(p => p.P018B003)
				.HasColumnName("P018B003")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018B003")
				.IsOptional();

			Property(p => p.P018B004)
				.HasColumnName("P018B004")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018B004")
				.IsOptional();

			Property(p => p.P018B005)
				.HasColumnName("P018B005")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018B005")
				.IsOptional();

			Property(p => p.P018B006)
				.HasColumnName("P018B006")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018B006")
				.IsOptional();

			Property(p => p.P018B007)
				.HasColumnName("P018B007")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018B007")
				.IsOptional();

			Property(p => p.P018B008)
				.HasColumnName("P018B008")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018B008")
				.IsOptional();

			Property(p => p.P018B009)
				.HasColumnName("P018B009")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018B009")
				.IsOptional();

			Property(p => p.P018C001)
				.HasColumnName("P018C001")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018C001")
				.IsOptional();

			Property(p => p.P018C002)
				.HasColumnName("P018C002")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018C002")
				.IsOptional();

			Property(p => p.P018C003)
				.HasColumnName("P018C003")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018C003")
				.IsOptional();

			Property(p => p.P018C004)
				.HasColumnName("P018C004")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018C004")
				.IsOptional();

			Property(p => p.P018C005)
				.HasColumnName("P018C005")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018C005")
				.IsOptional();

			Property(p => p.P018C006)
				.HasColumnName("P018C006")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018C006")
				.IsOptional();

			Property(p => p.P018C007)
				.HasColumnName("P018C007")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018C007")
				.IsOptional();

			Property(p => p.P018C008)
				.HasColumnName("P018C008")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018C008")
				.IsOptional();

			Property(p => p.P018C009)
				.HasColumnName("P018C009")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018C009")
				.IsOptional();

			Property(p => p.P018D001)
				.HasColumnName("P018D001")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018D001")
				.IsOptional();

			Property(p => p.P018D002)
				.HasColumnName("P018D002")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018D002")
				.IsOptional();

			Property(p => p.P018D003)
				.HasColumnName("P018D003")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018D003")
				.IsOptional();

			Property(p => p.P018D004)
				.HasColumnName("P018D004")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018D004")
				.IsOptional();

			Property(p => p.P018D005)
				.HasColumnName("P018D005")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018D005")
				.IsOptional();

			Property(p => p.P018D006)
				.HasColumnName("P018D006")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018D006")
				.IsOptional();

			Property(p => p.P018D007)
				.HasColumnName("P018D007")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018D007")
				.IsOptional();

			Property(p => p.P018D008)
				.HasColumnName("P018D008")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018D008")
				.IsOptional();

			Property(p => p.P018D009)
				.HasColumnName("P018D009")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018D009")
				.IsOptional();

			Property(p => p.P018E001)
				.HasColumnName("P018E001")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018E001")
				.IsOptional();

			Property(p => p.P018E002)
				.HasColumnName("P018E002")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018E002")
				.IsOptional();

			Property(p => p.P018E003)
				.HasColumnName("P018E003")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018E003")
				.IsOptional();

			Property(p => p.P018E004)
				.HasColumnName("P018E004")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018E004")
				.IsOptional();

			Property(p => p.P018E005)
				.HasColumnName("P018E005")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018E005")
				.IsOptional();

			Property(p => p.P018E006)
				.HasColumnName("P018E006")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018E006")
				.IsOptional();

			Property(p => p.P018E007)
				.HasColumnName("P018E007")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018E007")
				.IsOptional();

			Property(p => p.P018E008)
				.HasColumnName("P018E008")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018E008")
				.IsOptional();

			Property(p => p.P018E009)
				.HasColumnName("P018E009")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018E009")
				.IsOptional();

			Property(p => p.P018F001)
				.HasColumnName("P018F001")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018F001")
				.IsOptional();

			Property(p => p.P018F002)
				.HasColumnName("P018F002")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018F002")
				.IsOptional();

			Property(p => p.P018F003)
				.HasColumnName("P018F003")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018F003")
				.IsOptional();

			Property(p => p.P018F004)
				.HasColumnName("P018F004")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018F004")
				.IsOptional();

			Property(p => p.P018F005)
				.HasColumnName("P018F005")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018F005")
				.IsOptional();

			Property(p => p.P018F006)
				.HasColumnName("P018F006")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018F006")
				.IsOptional();

			Property(p => p.P018F007)
				.HasColumnName("P018F007")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018F007")
				.IsOptional();

			Property(p => p.P018F008)
				.HasColumnName("P018F008")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018F008")
				.IsOptional();

			Property(p => p.P018F009)
				.HasColumnName("P018F009")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018F009")
				.IsOptional();

			Property(p => p.P018G001)
				.HasColumnName("P018G001")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018G001")
				.IsOptional();

			Property(p => p.P018G002)
				.HasColumnName("P018G002")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018G002")
				.IsOptional();

			Property(p => p.P018G003)
				.HasColumnName("P018G003")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018G003")
				.IsOptional();

			Property(p => p.P018G004)
				.HasColumnName("P018G004")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018G004")
				.IsOptional();

			Property(p => p.P018G005)
				.HasColumnName("P018G005")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018G005")
				.IsOptional();

			Property(p => p.P018G006)
				.HasColumnName("P018G006")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018G006")
				.IsOptional();

			Property(p => p.P018G007)
				.HasColumnName("P018G007")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018G007")
				.IsOptional();

			Property(p => p.P018G008)
				.HasColumnName("P018G008")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018G008")
				.IsOptional();

			Property(p => p.P018G009)
				.HasColumnName("P018G009")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018G009")
				.IsOptional();

			Property(p => p.P018H001)
				.HasColumnName("P018H001")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018H001")
				.IsOptional();

			Property(p => p.P018H002)
				.HasColumnName("P018H002")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018H002")
				.IsOptional();

			Property(p => p.P018H003)
				.HasColumnName("P018H003")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018H003")
				.IsOptional();

			Property(p => p.P018H004)
				.HasColumnName("P018H004")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018H004")
				.IsOptional();

			Property(p => p.P018H005)
				.HasColumnName("P018H005")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018H005")
				.IsOptional();

			Property(p => p.P018H006)
				.HasColumnName("P018H006")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018H006")
				.IsOptional();

			Property(p => p.P018H007)
				.HasColumnName("P018H007")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018H007")
				.IsOptional();

			Property(p => p.P018H008)
				.HasColumnName("P018H008")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018H008")
				.IsOptional();

			Property(p => p.P018H009)
				.HasColumnName("P018H009")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018H009")
				.IsOptional();

			Property(p => p.P018I001)
				.HasColumnName("P018I001")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018I001")
				.IsOptional();

			Property(p => p.P018I002)
				.HasColumnName("P018I002")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018I002")
				.IsOptional();

			Property(p => p.P018I003)
				.HasColumnName("P018I003")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018I003")
				.IsOptional();

			Property(p => p.P018I004)
				.HasColumnName("P018I004")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018I004")
				.IsOptional();

			Property(p => p.P018I005)
				.HasColumnName("P018I005")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018I005")
				.IsOptional();

			Property(p => p.P018I006)
				.HasColumnName("P018I006")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018I006")
				.IsOptional();

			Property(p => p.P018I007)
				.HasColumnName("P018I007")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018I007")
				.IsOptional();

			Property(p => p.P018I008)
				.HasColumnName("P018I008")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018I008")
				.IsOptional();

			Property(p => p.P018I009)
				.HasColumnName("P018I009")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P018I009")
				.IsOptional();

			Property(p => p.P028A001)
				.HasColumnName("P028A001")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028A001")
				.IsOptional();

			Property(p => p.P028A002)
				.HasColumnName("P028A002")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028A002")
				.IsOptional();

			Property(p => p.P028A003)
				.HasColumnName("P028A003")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028A003")
				.IsOptional();

			Property(p => p.P028A004)
				.HasColumnName("P028A004")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028A004")
				.IsOptional();

			Property(p => p.P028A005)
				.HasColumnName("P028A005")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028A005")
				.IsOptional();

			Property(p => p.P028A006)
				.HasColumnName("P028A006")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028A006")
				.IsOptional();

			Property(p => p.P028A007)
				.HasColumnName("P028A007")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028A007")
				.IsOptional();

			Property(p => p.P028A008)
				.HasColumnName("P028A008")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028A008")
				.IsOptional();

			Property(p => p.P028A009)
				.HasColumnName("P028A009")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028A009")
				.IsOptional();

			Property(p => p.P028A010)
				.HasColumnName("P028A010")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028A010")
				.IsOptional();

			Property(p => p.P028A011)
				.HasColumnName("P028A011")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028A011")
				.IsOptional();

			Property(p => p.P028A012)
				.HasColumnName("P028A012")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028A012")
				.IsOptional();

			Property(p => p.P028A013)
				.HasColumnName("P028A013")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028A013")
				.IsOptional();

			Property(p => p.P028A014)
				.HasColumnName("P028A014")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028A014")
				.IsOptional();

			Property(p => p.P028A015)
				.HasColumnName("P028A015")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028A015")
				.IsOptional();

			Property(p => p.P028A016)
				.HasColumnName("P028A016")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028A016")
				.IsOptional();

			Property(p => p.P028B001)
				.HasColumnName("P028B001")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028B001")
				.IsOptional();

			Property(p => p.P028B002)
				.HasColumnName("P028B002")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028B002")
				.IsOptional();

			Property(p => p.P028B003)
				.HasColumnName("P028B003")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028B003")
				.IsOptional();

			Property(p => p.P028B004)
				.HasColumnName("P028B004")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028B004")
				.IsOptional();

			Property(p => p.P028B005)
				.HasColumnName("P028B005")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028B005")
				.IsOptional();

			Property(p => p.P028B006)
				.HasColumnName("P028B006")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028B006")
				.IsOptional();

			Property(p => p.P028B007)
				.HasColumnName("P028B007")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028B007")
				.IsOptional();

			Property(p => p.P028B008)
				.HasColumnName("P028B008")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028B008")
				.IsOptional();

			Property(p => p.P028B009)
				.HasColumnName("P028B009")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028B009")
				.IsOptional();

			Property(p => p.P028B010)
				.HasColumnName("P028B010")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028B010")
				.IsOptional();

			Property(p => p.P028B011)
				.HasColumnName("P028B011")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028B011")
				.IsOptional();

			Property(p => p.P028B012)
				.HasColumnName("P028B012")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028B012")
				.IsOptional();

			Property(p => p.P028B013)
				.HasColumnName("P028B013")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028B013")
				.IsOptional();

			Property(p => p.P028B014)
				.HasColumnName("P028B014")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028B014")
				.IsOptional();

			Property(p => p.P028B015)
				.HasColumnName("P028B015")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028B015")
				.IsOptional();

			Property(p => p.P028B016)
				.HasColumnName("P028B016")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028B016")
				.IsOptional();

			Property(p => p.P028C001)
				.HasColumnName("P028C001")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028C001")
				.IsOptional();

			Property(p => p.P028C002)
				.HasColumnName("P028C002")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028C002")
				.IsOptional();

			Property(p => p.P028C003)
				.HasColumnName("P028C003")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028C003")
				.IsOptional();

			Property(p => p.P028C004)
				.HasColumnName("P028C004")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028C004")
				.IsOptional();

			Property(p => p.P028C005)
				.HasColumnName("P028C005")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028C005")
				.IsOptional();

			Property(p => p.P028C006)
				.HasColumnName("P028C006")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028C006")
				.IsOptional();

			Property(p => p.P028C007)
				.HasColumnName("P028C007")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028C007")
				.IsOptional();

			Property(p => p.P028C008)
				.HasColumnName("P028C008")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028C008")
				.IsOptional();

			Property(p => p.P028C009)
				.HasColumnName("P028C009")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028C009")
				.IsOptional();

			Property(p => p.P028C010)
				.HasColumnName("P028C010")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028C010")
				.IsOptional();

			Property(p => p.P028C011)
				.HasColumnName("P028C011")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028C011")
				.IsOptional();

			Property(p => p.P028C012)
				.HasColumnName("P028C012")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028C012")
				.IsOptional();

			Property(p => p.P028C013)
				.HasColumnName("P028C013")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028C013")
				.IsOptional();

			Property(p => p.P028C014)
				.HasColumnName("P028C014")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028C014")
				.IsOptional();

			Property(p => p.P028C015)
				.HasColumnName("P028C015")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028C015")
				.IsOptional();

			Property(p => p.P028C016)
				.HasColumnName("P028C016")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028C016")
				.IsOptional();

			Property(p => p.P028D001)
				.HasColumnName("P028D001")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028D001")
				.IsOptional();

			Property(p => p.P028D002)
				.HasColumnName("P028D002")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028D002")
				.IsOptional();

			Property(p => p.P028D003)
				.HasColumnName("P028D003")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028D003")
				.IsOptional();

			Property(p => p.P028D004)
				.HasColumnName("P028D004")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028D004")
				.IsOptional();

			Property(p => p.P028D005)
				.HasColumnName("P028D005")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028D005")
				.IsOptional();

			Property(p => p.P028D006)
				.HasColumnName("P028D006")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028D006")
				.IsOptional();

			Property(p => p.P028D007)
				.HasColumnName("P028D007")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028D007")
				.IsOptional();

			Property(p => p.P028D008)
				.HasColumnName("P028D008")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028D008")
				.IsOptional();

			Property(p => p.P028D009)
				.HasColumnName("P028D009")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028D009")
				.IsOptional();

			Property(p => p.P028D010)
				.HasColumnName("P028D010")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028D010")
				.IsOptional();

			Property(p => p.P028D011)
				.HasColumnName("P028D011")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028D011")
				.IsOptional();

			Property(p => p.P028D012)
				.HasColumnName("P028D012")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028D012")
				.IsOptional();

			Property(p => p.P028D013)
				.HasColumnName("P028D013")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028D013")
				.IsOptional();

			Property(p => p.P028D014)
				.HasColumnName("P028D014")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028D014")
				.IsOptional();

			Property(p => p.P028D015)
				.HasColumnName("P028D015")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028D015")
				.IsOptional();

			Property(p => p.P028D016)
				.HasColumnName("P028D016")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028D016")
				.IsOptional();

			Property(p => p.P028E001)
				.HasColumnName("P028E001")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028E001")
				.IsOptional();

			Property(p => p.P028E002)
				.HasColumnName("P028E002")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028E002")
				.IsOptional();

			Property(p => p.P028E003)
				.HasColumnName("P028E003")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028E003")
				.IsOptional();

			Property(p => p.P028E004)
				.HasColumnName("P028E004")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028E004")
				.IsOptional();

			Property(p => p.P028E005)
				.HasColumnName("P028E005")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028E005")
				.IsOptional();

			Property(p => p.P028E006)
				.HasColumnName("P028E006")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028E006")
				.IsOptional();

			Property(p => p.P028E007)
				.HasColumnName("P028E007")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028E007")
				.IsOptional();

			Property(p => p.P028E008)
				.HasColumnName("P028E008")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028E008")
				.IsOptional();

			Property(p => p.P028E009)
				.HasColumnName("P028E009")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028E009")
				.IsOptional();

			Property(p => p.P028E010)
				.HasColumnName("P028E010")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028E010")
				.IsOptional();

			Property(p => p.P028E011)
				.HasColumnName("P028E011")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028E011")
				.IsOptional();

			Property(p => p.P028E012)
				.HasColumnName("P028E012")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028E012")
				.IsOptional();

			Property(p => p.P028E013)
				.HasColumnName("P028E013")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028E013")
				.IsOptional();

			Property(p => p.P028E014)
				.HasColumnName("P028E014")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028E014")
				.IsOptional();

			Property(p => p.P028E015)
				.HasColumnName("P028E015")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028E015")
				.IsOptional();

			Property(p => p.P028E016)
				.HasColumnName("P028E016")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028E016")
				.IsOptional();

			Property(p => p.P028F001)
				.HasColumnName("P028F001")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028F001")
				.IsOptional();

			Property(p => p.P028F002)
				.HasColumnName("P028F002")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028F002")
				.IsOptional();

			Property(p => p.P028F003)
				.HasColumnName("P028F003")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028F003")
				.IsOptional();

			Property(p => p.P028F004)
				.HasColumnName("P028F004")
				.HasColumnOrder(193)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028F004")
				.IsOptional();

			Property(p => p.P028F005)
				.HasColumnName("P028F005")
				.HasColumnOrder(194)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028F005")
				.IsOptional();

			Property(p => p.P028F006)
				.HasColumnName("P028F006")
				.HasColumnOrder(195)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028F006")
				.IsOptional();

			Property(p => p.P028F007)
				.HasColumnName("P028F007")
				.HasColumnOrder(196)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028F007")
				.IsOptional();

			Property(p => p.P028F008)
				.HasColumnName("P028F008")
				.HasColumnOrder(197)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028F008")
				.IsOptional();

			Property(p => p.P028F009)
				.HasColumnName("P028F009")
				.HasColumnOrder(198)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028F009")
				.IsOptional();

			Property(p => p.P028F010)
				.HasColumnName("P028F010")
				.HasColumnOrder(199)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028F010")
				.IsOptional();

			Property(p => p.P028F011)
				.HasColumnName("P028F011")
				.HasColumnOrder(200)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028F011")
				.IsOptional();

			Property(p => p.P028F012)
				.HasColumnName("P028F012")
				.HasColumnOrder(201)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028F012")
				.IsOptional();

			Property(p => p.P028F013)
				.HasColumnName("P028F013")
				.HasColumnOrder(202)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028F013")
				.IsOptional();

			Property(p => p.P028F014)
				.HasColumnName("P028F014")
				.HasColumnOrder(203)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028F014")
				.IsOptional();

			Property(p => p.P028F015)
				.HasColumnName("P028F015")
				.HasColumnOrder(204)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028F015")
				.IsOptional();

			Property(p => p.P028F016)
				.HasColumnName("P028F016")
				.HasColumnOrder(205)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028F016")
				.IsOptional();

			Property(p => p.P028G001)
				.HasColumnName("P028G001")
				.HasColumnOrder(206)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028G001")
				.IsOptional();

			Property(p => p.P028G002)
				.HasColumnName("P028G002")
				.HasColumnOrder(207)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028G002")
				.IsOptional();

			Property(p => p.P028G003)
				.HasColumnName("P028G003")
				.HasColumnOrder(208)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028G003")
				.IsOptional();

			Property(p => p.P028G004)
				.HasColumnName("P028G004")
				.HasColumnOrder(209)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028G004")
				.IsOptional();

			Property(p => p.P028G005)
				.HasColumnName("P028G005")
				.HasColumnOrder(210)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028G005")
				.IsOptional();

			Property(p => p.P028G006)
				.HasColumnName("P028G006")
				.HasColumnOrder(211)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028G006")
				.IsOptional();

			Property(p => p.P028G007)
				.HasColumnName("P028G007")
				.HasColumnOrder(212)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028G007")
				.IsOptional();

			Property(p => p.P028G008)
				.HasColumnName("P028G008")
				.HasColumnOrder(213)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028G008")
				.IsOptional();

			Property(p => p.P028G009)
				.HasColumnName("P028G009")
				.HasColumnOrder(214)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028G009")
				.IsOptional();

			Property(p => p.P028G010)
				.HasColumnName("P028G010")
				.HasColumnOrder(215)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028G010")
				.IsOptional();

			Property(p => p.P028G011)
				.HasColumnName("P028G011")
				.HasColumnOrder(216)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028G011")
				.IsOptional();

			Property(p => p.P028G012)
				.HasColumnName("P028G012")
				.HasColumnOrder(217)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028G012")
				.IsOptional();

			Property(p => p.P028G013)
				.HasColumnName("P028G013")
				.HasColumnOrder(218)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028G013")
				.IsOptional();

			Property(p => p.P028G014)
				.HasColumnName("P028G014")
				.HasColumnOrder(219)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028G014")
				.IsOptional();

			Property(p => p.P028G015)
				.HasColumnName("P028G015")
				.HasColumnOrder(220)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028G015")
				.IsOptional();

			Property(p => p.P028G016)
				.HasColumnName("P028G016")
				.HasColumnOrder(221)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028G016")
				.IsOptional();

			Property(p => p.P028H001)
				.HasColumnName("P028H001")
				.HasColumnOrder(222)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028H001")
				.IsOptional();

			Property(p => p.P028H002)
				.HasColumnName("P028H002")
				.HasColumnOrder(223)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028H002")
				.IsOptional();

			Property(p => p.P028H003)
				.HasColumnName("P028H003")
				.HasColumnOrder(224)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028H003")
				.IsOptional();

			Property(p => p.P028H004)
				.HasColumnName("P028H004")
				.HasColumnOrder(225)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028H004")
				.IsOptional();

			Property(p => p.P028H005)
				.HasColumnName("P028H005")
				.HasColumnOrder(226)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028H005")
				.IsOptional();

			Property(p => p.P028H006)
				.HasColumnName("P028H006")
				.HasColumnOrder(227)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028H006")
				.IsOptional();

			Property(p => p.P028H007)
				.HasColumnName("P028H007")
				.HasColumnOrder(228)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028H007")
				.IsOptional();

			Property(p => p.P028H008)
				.HasColumnName("P028H008")
				.HasColumnOrder(229)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028H008")
				.IsOptional();

			Property(p => p.P028H009)
				.HasColumnName("P028H009")
				.HasColumnOrder(230)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028H009")
				.IsOptional();

			Property(p => p.P028H010)
				.HasColumnName("P028H010")
				.HasColumnOrder(231)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028H010")
				.IsOptional();

			Property(p => p.P028H011)
				.HasColumnName("P028H011")
				.HasColumnOrder(232)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028H011")
				.IsOptional();

			Property(p => p.P028H012)
				.HasColumnName("P028H012")
				.HasColumnOrder(233)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028H012")
				.IsOptional();

			Property(p => p.P028H013)
				.HasColumnName("P028H013")
				.HasColumnOrder(234)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028H013")
				.IsOptional();

			Property(p => p.P028H014)
				.HasColumnName("P028H014")
				.HasColumnOrder(235)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028H014")
				.IsOptional();

			Property(p => p.P028H015)
				.HasColumnName("P028H015")
				.HasColumnOrder(236)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028H015")
				.IsOptional();

			Property(p => p.P028H016)
				.HasColumnName("P028H016")
				.HasColumnOrder(237)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028H016")
				.IsOptional();

			Property(p => p.P028I001)
				.HasColumnName("P028I001")
				.HasColumnOrder(238)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028I001")
				.IsOptional();

			Property(p => p.P028I002)
				.HasColumnName("P028I002")
				.HasColumnOrder(239)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028I002")
				.IsOptional();

			Property(p => p.P028I003)
				.HasColumnName("P028I003")
				.HasColumnOrder(240)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028I003")
				.IsOptional();

			Property(p => p.P028I004)
				.HasColumnName("P028I004")
				.HasColumnOrder(241)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028I004")
				.IsOptional();

			Property(p => p.P028I005)
				.HasColumnName("P028I005")
				.HasColumnOrder(242)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028I005")
				.IsOptional();

			Property(p => p.P028I006)
				.HasColumnName("P028I006")
				.HasColumnOrder(243)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028I006")
				.IsOptional();

			Property(p => p.P028I007)
				.HasColumnName("P028I007")
				.HasColumnOrder(244)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028I007")
				.IsOptional();

			Property(p => p.P028I008)
				.HasColumnName("P028I008")
				.HasColumnOrder(245)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028I008")
				.IsOptional();

			Property(p => p.P028I009)
				.HasColumnName("P028I009")
				.HasColumnOrder(246)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028I009")
				.IsOptional();

			Property(p => p.P028I010)
				.HasColumnName("P028I010")
				.HasColumnOrder(247)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028I010")
				.IsOptional();

			Property(p => p.P028I011)
				.HasColumnName("P028I011")
				.HasColumnOrder(248)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028I011")
				.IsOptional();

			Property(p => p.P028I012)
				.HasColumnName("P028I012")
				.HasColumnOrder(249)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028I012")
				.IsOptional();

			Property(p => p.P028I013)
				.HasColumnName("P028I013")
				.HasColumnOrder(250)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028I013")
				.IsOptional();

			Property(p => p.P028I014)
				.HasColumnName("P028I014")
				.HasColumnOrder(251)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028I014")
				.IsOptional();

			Property(p => p.P028I015)
				.HasColumnName("P028I015")
				.HasColumnOrder(252)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028I015")
				.IsOptional();

			Property(p => p.P028I016)
				.HasColumnName("P028I016")
				.HasColumnOrder(253)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P028I016")
				.IsOptional();
		}
	}
}
