#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/06/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1CongressionalDistricts113_SF1_00018Map.cs
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

	public class SF1CongressionalDistricts113_SF1_00018Map : EntityTypeConfiguration<SF1CongressionalDistricts113_SF1_00018>
	{
		public SF1CongressionalDistricts113_SF1_00018Map()
		{
			ToTable("SF1_00018", "SF1CongressionalDistricts113");

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

			Property(p => p.PCT0130001)
				.HasColumnName("PCT0130001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130001")
				.IsOptional();

			Property(p => p.PCT0130002)
				.HasColumnName("PCT0130002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130002")
				.IsOptional();

			Property(p => p.PCT0130003)
				.HasColumnName("PCT0130003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130003")
				.IsOptional();

			Property(p => p.PCT0130004)
				.HasColumnName("PCT0130004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130004")
				.IsOptional();

			Property(p => p.PCT0130005)
				.HasColumnName("PCT0130005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130005")
				.IsOptional();

			Property(p => p.PCT0130006)
				.HasColumnName("PCT0130006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130006")
				.IsOptional();

			Property(p => p.PCT0130007)
				.HasColumnName("PCT0130007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130007")
				.IsOptional();

			Property(p => p.PCT0130008)
				.HasColumnName("PCT0130008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130008")
				.IsOptional();

			Property(p => p.PCT0130009)
				.HasColumnName("PCT0130009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130009")
				.IsOptional();

			Property(p => p.PCT0130010)
				.HasColumnName("PCT0130010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130010")
				.IsOptional();

			Property(p => p.PCT0130011)
				.HasColumnName("PCT0130011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130011")
				.IsOptional();

			Property(p => p.PCT0130012)
				.HasColumnName("PCT0130012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130012")
				.IsOptional();

			Property(p => p.PCT0130013)
				.HasColumnName("PCT0130013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130013")
				.IsOptional();

			Property(p => p.PCT0130014)
				.HasColumnName("PCT0130014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130014")
				.IsOptional();

			Property(p => p.PCT0130015)
				.HasColumnName("PCT0130015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130015")
				.IsOptional();

			Property(p => p.PCT0130016)
				.HasColumnName("PCT0130016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130016")
				.IsOptional();

			Property(p => p.PCT0130017)
				.HasColumnName("PCT0130017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130017")
				.IsOptional();

			Property(p => p.PCT0130018)
				.HasColumnName("PCT0130018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130018")
				.IsOptional();

			Property(p => p.PCT0130019)
				.HasColumnName("PCT0130019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130019")
				.IsOptional();

			Property(p => p.PCT0130020)
				.HasColumnName("PCT0130020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130020")
				.IsOptional();

			Property(p => p.PCT0130021)
				.HasColumnName("PCT0130021")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130021")
				.IsOptional();

			Property(p => p.PCT0130022)
				.HasColumnName("PCT0130022")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130022")
				.IsOptional();

			Property(p => p.PCT0130023)
				.HasColumnName("PCT0130023")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130023")
				.IsOptional();

			Property(p => p.PCT0130024)
				.HasColumnName("PCT0130024")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130024")
				.IsOptional();

			Property(p => p.PCT0130025)
				.HasColumnName("PCT0130025")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130025")
				.IsOptional();

			Property(p => p.PCT0130026)
				.HasColumnName("PCT0130026")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130026")
				.IsOptional();

			Property(p => p.PCT0130027)
				.HasColumnName("PCT0130027")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130027")
				.IsOptional();

			Property(p => p.PCT0130028)
				.HasColumnName("PCT0130028")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130028")
				.IsOptional();

			Property(p => p.PCT0130029)
				.HasColumnName("PCT0130029")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130029")
				.IsOptional();

			Property(p => p.PCT0130030)
				.HasColumnName("PCT0130030")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130030")
				.IsOptional();

			Property(p => p.PCT0130031)
				.HasColumnName("PCT0130031")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130031")
				.IsOptional();

			Property(p => p.PCT0130032)
				.HasColumnName("PCT0130032")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130032")
				.IsOptional();

			Property(p => p.PCT0130033)
				.HasColumnName("PCT0130033")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130033")
				.IsOptional();

			Property(p => p.PCT0130034)
				.HasColumnName("PCT0130034")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130034")
				.IsOptional();

			Property(p => p.PCT0130035)
				.HasColumnName("PCT0130035")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130035")
				.IsOptional();

			Property(p => p.PCT0130036)
				.HasColumnName("PCT0130036")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130036")
				.IsOptional();

			Property(p => p.PCT0130037)
				.HasColumnName("PCT0130037")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130037")
				.IsOptional();

			Property(p => p.PCT0130038)
				.HasColumnName("PCT0130038")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130038")
				.IsOptional();

			Property(p => p.PCT0130039)
				.HasColumnName("PCT0130039")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130039")
				.IsOptional();

			Property(p => p.PCT0130040)
				.HasColumnName("PCT0130040")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130040")
				.IsOptional();

			Property(p => p.PCT0130041)
				.HasColumnName("PCT0130041")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130041")
				.IsOptional();

			Property(p => p.PCT0130042)
				.HasColumnName("PCT0130042")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130042")
				.IsOptional();

			Property(p => p.PCT0130043)
				.HasColumnName("PCT0130043")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130043")
				.IsOptional();

			Property(p => p.PCT0130044)
				.HasColumnName("PCT0130044")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130044")
				.IsOptional();

			Property(p => p.PCT0130045)
				.HasColumnName("PCT0130045")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130045")
				.IsOptional();

			Property(p => p.PCT0130046)
				.HasColumnName("PCT0130046")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130046")
				.IsOptional();

			Property(p => p.PCT0130047)
				.HasColumnName("PCT0130047")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130047")
				.IsOptional();

			Property(p => p.PCT0130048)
				.HasColumnName("PCT0130048")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130048")
				.IsOptional();

			Property(p => p.PCT0130049)
				.HasColumnName("PCT0130049")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130049")
				.IsOptional();

			Property(p => p.PCT0140001)
				.HasColumnName("PCT0140001")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0140001")
				.IsOptional();

			Property(p => p.PCT0140002)
				.HasColumnName("PCT0140002")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0140002")
				.IsOptional();

			Property(p => p.PCT0140003)
				.HasColumnName("PCT0140003")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0140003")
				.IsOptional();

			Property(p => p.PCT0150001)
				.HasColumnName("PCT0150001")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150001")
				.IsOptional();

			Property(p => p.PCT0150002)
				.HasColumnName("PCT0150002")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150002")
				.IsOptional();

			Property(p => p.PCT0150003)
				.HasColumnName("PCT0150003")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150003")
				.IsOptional();

			Property(p => p.PCT0150004)
				.HasColumnName("PCT0150004")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150004")
				.IsOptional();

			Property(p => p.PCT0150005)
				.HasColumnName("PCT0150005")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150005")
				.IsOptional();

			Property(p => p.PCT0150006)
				.HasColumnName("PCT0150006")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150006")
				.IsOptional();

			Property(p => p.PCT0150007)
				.HasColumnName("PCT0150007")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150007")
				.IsOptional();

			Property(p => p.PCT0150008)
				.HasColumnName("PCT0150008")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150008")
				.IsOptional();

			Property(p => p.PCT0150009)
				.HasColumnName("PCT0150009")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150009")
				.IsOptional();

			Property(p => p.PCT0150010)
				.HasColumnName("PCT0150010")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150010")
				.IsOptional();

			Property(p => p.PCT0150011)
				.HasColumnName("PCT0150011")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150011")
				.IsOptional();

			Property(p => p.PCT0150012)
				.HasColumnName("PCT0150012")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150012")
				.IsOptional();

			Property(p => p.PCT0150013)
				.HasColumnName("PCT0150013")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150013")
				.IsOptional();

			Property(p => p.PCT0150014)
				.HasColumnName("PCT0150014")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150014")
				.IsOptional();

			Property(p => p.PCT0150015)
				.HasColumnName("PCT0150015")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150015")
				.IsOptional();

			Property(p => p.PCT0150016)
				.HasColumnName("PCT0150016")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150016")
				.IsOptional();

			Property(p => p.PCT0150017)
				.HasColumnName("PCT0150017")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150017")
				.IsOptional();

			Property(p => p.PCT0150018)
				.HasColumnName("PCT0150018")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150018")
				.IsOptional();

			Property(p => p.PCT0150019)
				.HasColumnName("PCT0150019")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150019")
				.IsOptional();

			Property(p => p.PCT0150020)
				.HasColumnName("PCT0150020")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150020")
				.IsOptional();

			Property(p => p.PCT0150021)
				.HasColumnName("PCT0150021")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150021")
				.IsOptional();

			Property(p => p.PCT0150022)
				.HasColumnName("PCT0150022")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150022")
				.IsOptional();

			Property(p => p.PCT0150023)
				.HasColumnName("PCT0150023")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150023")
				.IsOptional();

			Property(p => p.PCT0150024)
				.HasColumnName("PCT0150024")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150024")
				.IsOptional();

			Property(p => p.PCT0150025)
				.HasColumnName("PCT0150025")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150025")
				.IsOptional();

			Property(p => p.PCT0150026)
				.HasColumnName("PCT0150026")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150026")
				.IsOptional();

			Property(p => p.PCT0150027)
				.HasColumnName("PCT0150027")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150027")
				.IsOptional();

			Property(p => p.PCT0150028)
				.HasColumnName("PCT0150028")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150028")
				.IsOptional();

			Property(p => p.PCT0150029)
				.HasColumnName("PCT0150029")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150029")
				.IsOptional();

			Property(p => p.PCT0150030)
				.HasColumnName("PCT0150030")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150030")
				.IsOptional();

			Property(p => p.PCT0150031)
				.HasColumnName("PCT0150031")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150031")
				.IsOptional();

			Property(p => p.PCT0150032)
				.HasColumnName("PCT0150032")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150032")
				.IsOptional();

			Property(p => p.PCT0150033)
				.HasColumnName("PCT0150033")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150033")
				.IsOptional();

			Property(p => p.PCT0150034)
				.HasColumnName("PCT0150034")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150034")
				.IsOptional();

			Property(p => p.PCT0160001)
				.HasColumnName("PCT0160001")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160001")
				.IsOptional();

			Property(p => p.PCT0160002)
				.HasColumnName("PCT0160002")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160002")
				.IsOptional();

			Property(p => p.PCT0160003)
				.HasColumnName("PCT0160003")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160003")
				.IsOptional();

			Property(p => p.PCT0160004)
				.HasColumnName("PCT0160004")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160004")
				.IsOptional();

			Property(p => p.PCT0160005)
				.HasColumnName("PCT0160005")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160005")
				.IsOptional();

			Property(p => p.PCT0160006)
				.HasColumnName("PCT0160006")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160006")
				.IsOptional();

			Property(p => p.PCT0160007)
				.HasColumnName("PCT0160007")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160007")
				.IsOptional();

			Property(p => p.PCT0160008)
				.HasColumnName("PCT0160008")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160008")
				.IsOptional();

			Property(p => p.PCT0160009)
				.HasColumnName("PCT0160009")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160009")
				.IsOptional();

			Property(p => p.PCT0160010)
				.HasColumnName("PCT0160010")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160010")
				.IsOptional();

			Property(p => p.PCT0160011)
				.HasColumnName("PCT0160011")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160011")
				.IsOptional();

			Property(p => p.PCT0160012)
				.HasColumnName("PCT0160012")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160012")
				.IsOptional();

			Property(p => p.PCT0160013)
				.HasColumnName("PCT0160013")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160013")
				.IsOptional();

			Property(p => p.PCT0160014)
				.HasColumnName("PCT0160014")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160014")
				.IsOptional();

			Property(p => p.PCT0160015)
				.HasColumnName("PCT0160015")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160015")
				.IsOptional();

			Property(p => p.PCT0160016)
				.HasColumnName("PCT0160016")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160016")
				.IsOptional();

			Property(p => p.PCT0160017)
				.HasColumnName("PCT0160017")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160017")
				.IsOptional();

			Property(p => p.PCT0160018)
				.HasColumnName("PCT0160018")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160018")
				.IsOptional();

			Property(p => p.PCT0160019)
				.HasColumnName("PCT0160019")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160019")
				.IsOptional();

			Property(p => p.PCT0160020)
				.HasColumnName("PCT0160020")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160020")
				.IsOptional();

			Property(p => p.PCT0160021)
				.HasColumnName("PCT0160021")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160021")
				.IsOptional();

			Property(p => p.PCT0160022)
				.HasColumnName("PCT0160022")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160022")
				.IsOptional();

			Property(p => p.PCT0160023)
				.HasColumnName("PCT0160023")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160023")
				.IsOptional();

			Property(p => p.PCT0160024)
				.HasColumnName("PCT0160024")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160024")
				.IsOptional();

			Property(p => p.PCT0160025)
				.HasColumnName("PCT0160025")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160025")
				.IsOptional();

			Property(p => p.PCT0160026)
				.HasColumnName("PCT0160026")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160026")
				.IsOptional();

			Property(p => p.PCT0170001)
				.HasColumnName("PCT0170001")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0170001")
				.IsOptional();

			Property(p => p.PCT0170002)
				.HasColumnName("PCT0170002")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0170002")
				.IsOptional();

			Property(p => p.PCT0170003)
				.HasColumnName("PCT0170003")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0170003")
				.IsOptional();

			Property(p => p.PCT0170004)
				.HasColumnName("PCT0170004")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0170004")
				.IsOptional();

			Property(p => p.PCT0170005)
				.HasColumnName("PCT0170005")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0170005")
				.IsOptional();

			Property(p => p.PCT0170006)
				.HasColumnName("PCT0170006")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0170006")
				.IsOptional();

			Property(p => p.PCT0170007)
				.HasColumnName("PCT0170007")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0170007")
				.IsOptional();

			Property(p => p.PCT0170008)
				.HasColumnName("PCT0170008")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0170008")
				.IsOptional();

			Property(p => p.PCT0170009)
				.HasColumnName("PCT0170009")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0170009")
				.IsOptional();

			Property(p => p.PCT0170010)
				.HasColumnName("PCT0170010")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0170010")
				.IsOptional();

			Property(p => p.PCT0170011)
				.HasColumnName("PCT0170011")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0170011")
				.IsOptional();

			Property(p => p.PCT0170012)
				.HasColumnName("PCT0170012")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0170012")
				.IsOptional();

			Property(p => p.PCT0170013)
				.HasColumnName("PCT0170013")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0170013")
				.IsOptional();

			Property(p => p.PCT0170014)
				.HasColumnName("PCT0170014")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0170014")
				.IsOptional();

			Property(p => p.PCT0170015)
				.HasColumnName("PCT0170015")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0170015")
				.IsOptional();

			Property(p => p.PCT0170016)
				.HasColumnName("PCT0170016")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0170016")
				.IsOptional();

			Property(p => p.PCT0170017)
				.HasColumnName("PCT0170017")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0170017")
				.IsOptional();

			Property(p => p.PCT0170018)
				.HasColumnName("PCT0170018")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0170018")
				.IsOptional();

			Property(p => p.PCT0180001)
				.HasColumnName("PCT0180001")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0180001")
				.IsOptional();

			Property(p => p.PCT0180002)
				.HasColumnName("PCT0180002")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0180002")
				.IsOptional();

			Property(p => p.PCT0180003)
				.HasColumnName("PCT0180003")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0180003")
				.IsOptional();

			Property(p => p.PCT0180004)
				.HasColumnName("PCT0180004")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0180004")
				.IsOptional();

			Property(p => p.PCT0180005)
				.HasColumnName("PCT0180005")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0180005")
				.IsOptional();

			Property(p => p.PCT0180006)
				.HasColumnName("PCT0180006")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0180006")
				.IsOptional();

			Property(p => p.PCT0180007)
				.HasColumnName("PCT0180007")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0180007")
				.IsOptional();

			Property(p => p.PCT0180008)
				.HasColumnName("PCT0180008")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0180008")
				.IsOptional();

			Property(p => p.PCT0180009)
				.HasColumnName("PCT0180009")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0180009")
				.IsOptional();

			Property(p => p.PCT0180010)
				.HasColumnName("PCT0180010")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0180010")
				.IsOptional();

			Property(p => p.PCT0180011)
				.HasColumnName("PCT0180011")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0180011")
				.IsOptional();

			Property(p => p.PCT0180012)
				.HasColumnName("PCT0180012")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0180012")
				.IsOptional();

			Property(p => p.PCT0180013)
				.HasColumnName("PCT0180013")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0180013")
				.IsOptional();

			Property(p => p.PCT0180014)
				.HasColumnName("PCT0180014")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0180014")
				.IsOptional();

			Property(p => p.PCT0180015)
				.HasColumnName("PCT0180015")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0180015")
				.IsOptional();

			Property(p => p.PCT0190001)
				.HasColumnName("PCT0190001")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0190001")
				.IsOptional();

			Property(p => p.PCT0190002)
				.HasColumnName("PCT0190002")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0190002")
				.IsOptional();

			Property(p => p.PCT0190003)
				.HasColumnName("PCT0190003")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0190003")
				.IsOptional();

			Property(p => p.PCT0190004)
				.HasColumnName("PCT0190004")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0190004")
				.IsOptional();

			Property(p => p.PCT0190005)
				.HasColumnName("PCT0190005")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0190005")
				.IsOptional();

			Property(p => p.PCT0190006)
				.HasColumnName("PCT0190006")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0190006")
				.IsOptional();

			Property(p => p.PCT0190007)
				.HasColumnName("PCT0190007")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0190007")
				.IsOptional();

			Property(p => p.PCT0190008)
				.HasColumnName("PCT0190008")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0190008")
				.IsOptional();

			Property(p => p.PCT0190009)
				.HasColumnName("PCT0190009")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0190009")
				.IsOptional();

			Property(p => p.PCT0190010)
				.HasColumnName("PCT0190010")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0190010")
				.IsOptional();

			Property(p => p.PCT0190011)
				.HasColumnName("PCT0190011")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0190011")
				.IsOptional();

			Property(p => p.PCT0200001)
				.HasColumnName("PCT0200001")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200001")
				.IsOptional();

			Property(p => p.PCT0200002)
				.HasColumnName("PCT0200002")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200002")
				.IsOptional();

			Property(p => p.PCT0200003)
				.HasColumnName("PCT0200003")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200003")
				.IsOptional();

			Property(p => p.PCT0200004)
				.HasColumnName("PCT0200004")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200004")
				.IsOptional();

			Property(p => p.PCT0200005)
				.HasColumnName("PCT0200005")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200005")
				.IsOptional();

			Property(p => p.PCT0200006)
				.HasColumnName("PCT0200006")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200006")
				.IsOptional();

			Property(p => p.PCT0200007)
				.HasColumnName("PCT0200007")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200007")
				.IsOptional();

			Property(p => p.PCT0200008)
				.HasColumnName("PCT0200008")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200008")
				.IsOptional();

			Property(p => p.PCT0200009)
				.HasColumnName("PCT0200009")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200009")
				.IsOptional();

			Property(p => p.PCT0200010)
				.HasColumnName("PCT0200010")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200010")
				.IsOptional();

			Property(p => p.PCT0200011)
				.HasColumnName("PCT0200011")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200011")
				.IsOptional();

			Property(p => p.PCT0200012)
				.HasColumnName("PCT0200012")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200012")
				.IsOptional();

			Property(p => p.PCT0200013)
				.HasColumnName("PCT0200013")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200013")
				.IsOptional();

			Property(p => p.PCT0200014)
				.HasColumnName("PCT0200014")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200014")
				.IsOptional();

			Property(p => p.PCT0200015)
				.HasColumnName("PCT0200015")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200015")
				.IsOptional();

			Property(p => p.PCT0200016)
				.HasColumnName("PCT0200016")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200016")
				.IsOptional();

			Property(p => p.PCT0200017)
				.HasColumnName("PCT0200017")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200017")
				.IsOptional();

			Property(p => p.PCT0200018)
				.HasColumnName("PCT0200018")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200018")
				.IsOptional();

			Property(p => p.PCT0200019)
				.HasColumnName("PCT0200019")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200019")
				.IsOptional();

			Property(p => p.PCT0200020)
				.HasColumnName("PCT0200020")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200020")
				.IsOptional();

			Property(p => p.PCT0200021)
				.HasColumnName("PCT0200021")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200021")
				.IsOptional();

			Property(p => p.PCT0200022)
				.HasColumnName("PCT0200022")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200022")
				.IsOptional();

			Property(p => p.PCT0200023)
				.HasColumnName("PCT0200023")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200023")
				.IsOptional();

			Property(p => p.PCT0200024)
				.HasColumnName("PCT0200024")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200024")
				.IsOptional();

			Property(p => p.PCT0200025)
				.HasColumnName("PCT0200025")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200025")
				.IsOptional();

			Property(p => p.PCT0200026)
				.HasColumnName("PCT0200026")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200026")
				.IsOptional();

			Property(p => p.PCT0200027)
				.HasColumnName("PCT0200027")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200027")
				.IsOptional();

			Property(p => p.PCT0200028)
				.HasColumnName("PCT0200028")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200028")
				.IsOptional();

			Property(p => p.PCT0200029)
				.HasColumnName("PCT0200029")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200029")
				.IsOptional();

			Property(p => p.PCT0200030)
				.HasColumnName("PCT0200030")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200030")
				.IsOptional();

			Property(p => p.PCT0200031)
				.HasColumnName("PCT0200031")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200031")
				.IsOptional();

			Property(p => p.PCT0200032)
				.HasColumnName("PCT0200032")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0200032")
				.IsOptional();
		}
	}
}
