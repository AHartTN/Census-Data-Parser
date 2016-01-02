#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2016 12:12 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1CongressionalDistricts113_SF1_00035Map.cs
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

    public class SF1CongressionalDistricts113_SF1_00035Map : EntityTypeConfiguration<SF1CongressionalDistricts113_SF1_00035>
    {
        public SF1CongressionalDistricts113_SF1_00035Map()
        {
            ToTable("SF1_00035", "SF1CongressionalDistricts113");

            Property(p => p.FILEID)
                .HasColumnName("FILEID")
                .HasColumnOrder(0)
                .HasColumnType("NVARCHAR")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasMaxLength(255)
                .HasParameterName("FILEID")
                .IsOptional();

            Property(p => p.STUSAB)
                .HasColumnName("STUSAB")
                .HasColumnOrder(1)
                .HasColumnType("NVARCHAR")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasMaxLength(255)
                .HasParameterName("STUSAB")
                .IsOptional();

            Property(p => p.CHARITER)
                .HasColumnName("CHARITER")
                .HasColumnOrder(2)
                .HasColumnType("NVARCHAR")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasMaxLength(255)
                .HasParameterName("CHARITER")
                .IsOptional();

            Property(p => p.CIFSN)
                .HasColumnName("CIFSN")
                .HasColumnOrder(3)
                .HasColumnType("NVARCHAR")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasMaxLength(255)
                .HasParameterName("CIFSN")
                .IsOptional();

            Property(p => p.LOGRECNO)
                .HasColumnName("LOGRECNO")
                .HasColumnOrder(4)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("LOGRECNO")
                .IsOptional();

            Property(p => p.PCT013A001)
                .HasColumnName("PCT013A001")
                .HasColumnOrder(5)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A001")
                .IsOptional();

            Property(p => p.PCT013A002)
                .HasColumnName("PCT013A002")
                .HasColumnOrder(6)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A002")
                .IsOptional();

            Property(p => p.PCT013A003)
                .HasColumnName("PCT013A003")
                .HasColumnOrder(7)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A003")
                .IsOptional();

            Property(p => p.PCT013A004)
                .HasColumnName("PCT013A004")
                .HasColumnOrder(8)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A004")
                .IsOptional();

            Property(p => p.PCT013A005)
                .HasColumnName("PCT013A005")
                .HasColumnOrder(9)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A005")
                .IsOptional();

            Property(p => p.PCT013A006)
                .HasColumnName("PCT013A006")
                .HasColumnOrder(10)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A006")
                .IsOptional();

            Property(p => p.PCT013A007)
                .HasColumnName("PCT013A007")
                .HasColumnOrder(11)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A007")
                .IsOptional();

            Property(p => p.PCT013A008)
                .HasColumnName("PCT013A008")
                .HasColumnOrder(12)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A008")
                .IsOptional();

            Property(p => p.PCT013A009)
                .HasColumnName("PCT013A009")
                .HasColumnOrder(13)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A009")
                .IsOptional();

            Property(p => p.PCT013A010)
                .HasColumnName("PCT013A010")
                .HasColumnOrder(14)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A010")
                .IsOptional();

            Property(p => p.PCT013A011)
                .HasColumnName("PCT013A011")
                .HasColumnOrder(15)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A011")
                .IsOptional();

            Property(p => p.PCT013A012)
                .HasColumnName("PCT013A012")
                .HasColumnOrder(16)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A012")
                .IsOptional();

            Property(p => p.PCT013A013)
                .HasColumnName("PCT013A013")
                .HasColumnOrder(17)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A013")
                .IsOptional();

            Property(p => p.PCT013A014)
                .HasColumnName("PCT013A014")
                .HasColumnOrder(18)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A014")
                .IsOptional();

            Property(p => p.PCT013A015)
                .HasColumnName("PCT013A015")
                .HasColumnOrder(19)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A015")
                .IsOptional();

            Property(p => p.PCT013A016)
                .HasColumnName("PCT013A016")
                .HasColumnOrder(20)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A016")
                .IsOptional();

            Property(p => p.PCT013A017)
                .HasColumnName("PCT013A017")
                .HasColumnOrder(21)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A017")
                .IsOptional();

            Property(p => p.PCT013A018)
                .HasColumnName("PCT013A018")
                .HasColumnOrder(22)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A018")
                .IsOptional();

            Property(p => p.PCT013A019)
                .HasColumnName("PCT013A019")
                .HasColumnOrder(23)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A019")
                .IsOptional();

            Property(p => p.PCT013A020)
                .HasColumnName("PCT013A020")
                .HasColumnOrder(24)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A020")
                .IsOptional();

            Property(p => p.PCT013A021)
                .HasColumnName("PCT013A021")
                .HasColumnOrder(25)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A021")
                .IsOptional();

            Property(p => p.PCT013A022)
                .HasColumnName("PCT013A022")
                .HasColumnOrder(26)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A022")
                .IsOptional();

            Property(p => p.PCT013A023)
                .HasColumnName("PCT013A023")
                .HasColumnOrder(27)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A023")
                .IsOptional();

            Property(p => p.PCT013A024)
                .HasColumnName("PCT013A024")
                .HasColumnOrder(28)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A024")
                .IsOptional();

            Property(p => p.PCT013A025)
                .HasColumnName("PCT013A025")
                .HasColumnOrder(29)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A025")
                .IsOptional();

            Property(p => p.PCT013A026)
                .HasColumnName("PCT013A026")
                .HasColumnOrder(30)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A026")
                .IsOptional();

            Property(p => p.PCT013A027)
                .HasColumnName("PCT013A027")
                .HasColumnOrder(31)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A027")
                .IsOptional();

            Property(p => p.PCT013A028)
                .HasColumnName("PCT013A028")
                .HasColumnOrder(32)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A028")
                .IsOptional();

            Property(p => p.PCT013A029)
                .HasColumnName("PCT013A029")
                .HasColumnOrder(33)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A029")
                .IsOptional();

            Property(p => p.PCT013A030)
                .HasColumnName("PCT013A030")
                .HasColumnOrder(34)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A030")
                .IsOptional();

            Property(p => p.PCT013A031)
                .HasColumnName("PCT013A031")
                .HasColumnOrder(35)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A031")
                .IsOptional();

            Property(p => p.PCT013A032)
                .HasColumnName("PCT013A032")
                .HasColumnOrder(36)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A032")
                .IsOptional();

            Property(p => p.PCT013A033)
                .HasColumnName("PCT013A033")
                .HasColumnOrder(37)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A033")
                .IsOptional();

            Property(p => p.PCT013A034)
                .HasColumnName("PCT013A034")
                .HasColumnOrder(38)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A034")
                .IsOptional();

            Property(p => p.PCT013A035)
                .HasColumnName("PCT013A035")
                .HasColumnOrder(39)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A035")
                .IsOptional();

            Property(p => p.PCT013A036)
                .HasColumnName("PCT013A036")
                .HasColumnOrder(40)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A036")
                .IsOptional();

            Property(p => p.PCT013A037)
                .HasColumnName("PCT013A037")
                .HasColumnOrder(41)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A037")
                .IsOptional();

            Property(p => p.PCT013A038)
                .HasColumnName("PCT013A038")
                .HasColumnOrder(42)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A038")
                .IsOptional();

            Property(p => p.PCT013A039)
                .HasColumnName("PCT013A039")
                .HasColumnOrder(43)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A039")
                .IsOptional();

            Property(p => p.PCT013A040)
                .HasColumnName("PCT013A040")
                .HasColumnOrder(44)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A040")
                .IsOptional();

            Property(p => p.PCT013A041)
                .HasColumnName("PCT013A041")
                .HasColumnOrder(45)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A041")
                .IsOptional();

            Property(p => p.PCT013A042)
                .HasColumnName("PCT013A042")
                .HasColumnOrder(46)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A042")
                .IsOptional();

            Property(p => p.PCT013A043)
                .HasColumnName("PCT013A043")
                .HasColumnOrder(47)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A043")
                .IsOptional();

            Property(p => p.PCT013A044)
                .HasColumnName("PCT013A044")
                .HasColumnOrder(48)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A044")
                .IsOptional();

            Property(p => p.PCT013A045)
                .HasColumnName("PCT013A045")
                .HasColumnOrder(49)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A045")
                .IsOptional();

            Property(p => p.PCT013A046)
                .HasColumnName("PCT013A046")
                .HasColumnOrder(50)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A046")
                .IsOptional();

            Property(p => p.PCT013A047)
                .HasColumnName("PCT013A047")
                .HasColumnOrder(51)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A047")
                .IsOptional();

            Property(p => p.PCT013A048)
                .HasColumnName("PCT013A048")
                .HasColumnOrder(52)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A048")
                .IsOptional();

            Property(p => p.PCT013A049)
                .HasColumnName("PCT013A049")
                .HasColumnOrder(53)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013A049")
                .IsOptional();

            Property(p => p.PCT013B001)
                .HasColumnName("PCT013B001")
                .HasColumnOrder(54)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B001")
                .IsOptional();

            Property(p => p.PCT013B002)
                .HasColumnName("PCT013B002")
                .HasColumnOrder(55)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B002")
                .IsOptional();

            Property(p => p.PCT013B003)
                .HasColumnName("PCT013B003")
                .HasColumnOrder(56)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B003")
                .IsOptional();

            Property(p => p.PCT013B004)
                .HasColumnName("PCT013B004")
                .HasColumnOrder(57)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B004")
                .IsOptional();

            Property(p => p.PCT013B005)
                .HasColumnName("PCT013B005")
                .HasColumnOrder(58)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B005")
                .IsOptional();

            Property(p => p.PCT013B006)
                .HasColumnName("PCT013B006")
                .HasColumnOrder(59)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B006")
                .IsOptional();

            Property(p => p.PCT013B007)
                .HasColumnName("PCT013B007")
                .HasColumnOrder(60)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B007")
                .IsOptional();

            Property(p => p.PCT013B008)
                .HasColumnName("PCT013B008")
                .HasColumnOrder(61)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B008")
                .IsOptional();

            Property(p => p.PCT013B009)
                .HasColumnName("PCT013B009")
                .HasColumnOrder(62)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B009")
                .IsOptional();

            Property(p => p.PCT013B010)
                .HasColumnName("PCT013B010")
                .HasColumnOrder(63)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B010")
                .IsOptional();

            Property(p => p.PCT013B011)
                .HasColumnName("PCT013B011")
                .HasColumnOrder(64)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B011")
                .IsOptional();

            Property(p => p.PCT013B012)
                .HasColumnName("PCT013B012")
                .HasColumnOrder(65)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B012")
                .IsOptional();

            Property(p => p.PCT013B013)
                .HasColumnName("PCT013B013")
                .HasColumnOrder(66)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B013")
                .IsOptional();

            Property(p => p.PCT013B014)
                .HasColumnName("PCT013B014")
                .HasColumnOrder(67)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B014")
                .IsOptional();

            Property(p => p.PCT013B015)
                .HasColumnName("PCT013B015")
                .HasColumnOrder(68)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B015")
                .IsOptional();

            Property(p => p.PCT013B016)
                .HasColumnName("PCT013B016")
                .HasColumnOrder(69)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B016")
                .IsOptional();

            Property(p => p.PCT013B017)
                .HasColumnName("PCT013B017")
                .HasColumnOrder(70)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B017")
                .IsOptional();

            Property(p => p.PCT013B018)
                .HasColumnName("PCT013B018")
                .HasColumnOrder(71)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B018")
                .IsOptional();

            Property(p => p.PCT013B019)
                .HasColumnName("PCT013B019")
                .HasColumnOrder(72)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B019")
                .IsOptional();

            Property(p => p.PCT013B020)
                .HasColumnName("PCT013B020")
                .HasColumnOrder(73)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B020")
                .IsOptional();

            Property(p => p.PCT013B021)
                .HasColumnName("PCT013B021")
                .HasColumnOrder(74)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B021")
                .IsOptional();

            Property(p => p.PCT013B022)
                .HasColumnName("PCT013B022")
                .HasColumnOrder(75)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B022")
                .IsOptional();

            Property(p => p.PCT013B023)
                .HasColumnName("PCT013B023")
                .HasColumnOrder(76)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B023")
                .IsOptional();

            Property(p => p.PCT013B024)
                .HasColumnName("PCT013B024")
                .HasColumnOrder(77)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B024")
                .IsOptional();

            Property(p => p.PCT013B025)
                .HasColumnName("PCT013B025")
                .HasColumnOrder(78)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B025")
                .IsOptional();

            Property(p => p.PCT013B026)
                .HasColumnName("PCT013B026")
                .HasColumnOrder(79)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B026")
                .IsOptional();

            Property(p => p.PCT013B027)
                .HasColumnName("PCT013B027")
                .HasColumnOrder(80)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B027")
                .IsOptional();

            Property(p => p.PCT013B028)
                .HasColumnName("PCT013B028")
                .HasColumnOrder(81)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B028")
                .IsOptional();

            Property(p => p.PCT013B029)
                .HasColumnName("PCT013B029")
                .HasColumnOrder(82)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B029")
                .IsOptional();

            Property(p => p.PCT013B030)
                .HasColumnName("PCT013B030")
                .HasColumnOrder(83)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B030")
                .IsOptional();

            Property(p => p.PCT013B031)
                .HasColumnName("PCT013B031")
                .HasColumnOrder(84)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B031")
                .IsOptional();

            Property(p => p.PCT013B032)
                .HasColumnName("PCT013B032")
                .HasColumnOrder(85)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B032")
                .IsOptional();

            Property(p => p.PCT013B033)
                .HasColumnName("PCT013B033")
                .HasColumnOrder(86)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B033")
                .IsOptional();

            Property(p => p.PCT013B034)
                .HasColumnName("PCT013B034")
                .HasColumnOrder(87)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B034")
                .IsOptional();

            Property(p => p.PCT013B035)
                .HasColumnName("PCT013B035")
                .HasColumnOrder(88)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B035")
                .IsOptional();

            Property(p => p.PCT013B036)
                .HasColumnName("PCT013B036")
                .HasColumnOrder(89)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B036")
                .IsOptional();

            Property(p => p.PCT013B037)
                .HasColumnName("PCT013B037")
                .HasColumnOrder(90)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B037")
                .IsOptional();

            Property(p => p.PCT013B038)
                .HasColumnName("PCT013B038")
                .HasColumnOrder(91)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B038")
                .IsOptional();

            Property(p => p.PCT013B039)
                .HasColumnName("PCT013B039")
                .HasColumnOrder(92)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B039")
                .IsOptional();

            Property(p => p.PCT013B040)
                .HasColumnName("PCT013B040")
                .HasColumnOrder(93)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B040")
                .IsOptional();

            Property(p => p.PCT013B041)
                .HasColumnName("PCT013B041")
                .HasColumnOrder(94)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B041")
                .IsOptional();

            Property(p => p.PCT013B042)
                .HasColumnName("PCT013B042")
                .HasColumnOrder(95)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B042")
                .IsOptional();

            Property(p => p.PCT013B043)
                .HasColumnName("PCT013B043")
                .HasColumnOrder(96)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B043")
                .IsOptional();

            Property(p => p.PCT013B044)
                .HasColumnName("PCT013B044")
                .HasColumnOrder(97)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B044")
                .IsOptional();

            Property(p => p.PCT013B045)
                .HasColumnName("PCT013B045")
                .HasColumnOrder(98)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B045")
                .IsOptional();

            Property(p => p.PCT013B046)
                .HasColumnName("PCT013B046")
                .HasColumnOrder(99)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B046")
                .IsOptional();

            Property(p => p.PCT013B047)
                .HasColumnName("PCT013B047")
                .HasColumnOrder(100)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B047")
                .IsOptional();

            Property(p => p.PCT013B048)
                .HasColumnName("PCT013B048")
                .HasColumnOrder(101)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B048")
                .IsOptional();

            Property(p => p.PCT013B049)
                .HasColumnName("PCT013B049")
                .HasColumnOrder(102)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013B049")
                .IsOptional();

            Property(p => p.PCT013C001)
                .HasColumnName("PCT013C001")
                .HasColumnOrder(103)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C001")
                .IsOptional();

            Property(p => p.PCT013C002)
                .HasColumnName("PCT013C002")
                .HasColumnOrder(104)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C002")
                .IsOptional();

            Property(p => p.PCT013C003)
                .HasColumnName("PCT013C003")
                .HasColumnOrder(105)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C003")
                .IsOptional();

            Property(p => p.PCT013C004)
                .HasColumnName("PCT013C004")
                .HasColumnOrder(106)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C004")
                .IsOptional();

            Property(p => p.PCT013C005)
                .HasColumnName("PCT013C005")
                .HasColumnOrder(107)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C005")
                .IsOptional();

            Property(p => p.PCT013C006)
                .HasColumnName("PCT013C006")
                .HasColumnOrder(108)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C006")
                .IsOptional();

            Property(p => p.PCT013C007)
                .HasColumnName("PCT013C007")
                .HasColumnOrder(109)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C007")
                .IsOptional();

            Property(p => p.PCT013C008)
                .HasColumnName("PCT013C008")
                .HasColumnOrder(110)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C008")
                .IsOptional();

            Property(p => p.PCT013C009)
                .HasColumnName("PCT013C009")
                .HasColumnOrder(111)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C009")
                .IsOptional();

            Property(p => p.PCT013C010)
                .HasColumnName("PCT013C010")
                .HasColumnOrder(112)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C010")
                .IsOptional();

            Property(p => p.PCT013C011)
                .HasColumnName("PCT013C011")
                .HasColumnOrder(113)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C011")
                .IsOptional();

            Property(p => p.PCT013C012)
                .HasColumnName("PCT013C012")
                .HasColumnOrder(114)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C012")
                .IsOptional();

            Property(p => p.PCT013C013)
                .HasColumnName("PCT013C013")
                .HasColumnOrder(115)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C013")
                .IsOptional();

            Property(p => p.PCT013C014)
                .HasColumnName("PCT013C014")
                .HasColumnOrder(116)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C014")
                .IsOptional();

            Property(p => p.PCT013C015)
                .HasColumnName("PCT013C015")
                .HasColumnOrder(117)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C015")
                .IsOptional();

            Property(p => p.PCT013C016)
                .HasColumnName("PCT013C016")
                .HasColumnOrder(118)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C016")
                .IsOptional();

            Property(p => p.PCT013C017)
                .HasColumnName("PCT013C017")
                .HasColumnOrder(119)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C017")
                .IsOptional();

            Property(p => p.PCT013C018)
                .HasColumnName("PCT013C018")
                .HasColumnOrder(120)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C018")
                .IsOptional();

            Property(p => p.PCT013C019)
                .HasColumnName("PCT013C019")
                .HasColumnOrder(121)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C019")
                .IsOptional();

            Property(p => p.PCT013C020)
                .HasColumnName("PCT013C020")
                .HasColumnOrder(122)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C020")
                .IsOptional();

            Property(p => p.PCT013C021)
                .HasColumnName("PCT013C021")
                .HasColumnOrder(123)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C021")
                .IsOptional();

            Property(p => p.PCT013C022)
                .HasColumnName("PCT013C022")
                .HasColumnOrder(124)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C022")
                .IsOptional();

            Property(p => p.PCT013C023)
                .HasColumnName("PCT013C023")
                .HasColumnOrder(125)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C023")
                .IsOptional();

            Property(p => p.PCT013C024)
                .HasColumnName("PCT013C024")
                .HasColumnOrder(126)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C024")
                .IsOptional();

            Property(p => p.PCT013C025)
                .HasColumnName("PCT013C025")
                .HasColumnOrder(127)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C025")
                .IsOptional();

            Property(p => p.PCT013C026)
                .HasColumnName("PCT013C026")
                .HasColumnOrder(128)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C026")
                .IsOptional();

            Property(p => p.PCT013C027)
                .HasColumnName("PCT013C027")
                .HasColumnOrder(129)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C027")
                .IsOptional();

            Property(p => p.PCT013C028)
                .HasColumnName("PCT013C028")
                .HasColumnOrder(130)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C028")
                .IsOptional();

            Property(p => p.PCT013C029)
                .HasColumnName("PCT013C029")
                .HasColumnOrder(131)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C029")
                .IsOptional();

            Property(p => p.PCT013C030)
                .HasColumnName("PCT013C030")
                .HasColumnOrder(132)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C030")
                .IsOptional();

            Property(p => p.PCT013C031)
                .HasColumnName("PCT013C031")
                .HasColumnOrder(133)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C031")
                .IsOptional();

            Property(p => p.PCT013C032)
                .HasColumnName("PCT013C032")
                .HasColumnOrder(134)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C032")
                .IsOptional();

            Property(p => p.PCT013C033)
                .HasColumnName("PCT013C033")
                .HasColumnOrder(135)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C033")
                .IsOptional();

            Property(p => p.PCT013C034)
                .HasColumnName("PCT013C034")
                .HasColumnOrder(136)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C034")
                .IsOptional();

            Property(p => p.PCT013C035)
                .HasColumnName("PCT013C035")
                .HasColumnOrder(137)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C035")
                .IsOptional();

            Property(p => p.PCT013C036)
                .HasColumnName("PCT013C036")
                .HasColumnOrder(138)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C036")
                .IsOptional();

            Property(p => p.PCT013C037)
                .HasColumnName("PCT013C037")
                .HasColumnOrder(139)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C037")
                .IsOptional();

            Property(p => p.PCT013C038)
                .HasColumnName("PCT013C038")
                .HasColumnOrder(140)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C038")
                .IsOptional();

            Property(p => p.PCT013C039)
                .HasColumnName("PCT013C039")
                .HasColumnOrder(141)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C039")
                .IsOptional();

            Property(p => p.PCT013C040)
                .HasColumnName("PCT013C040")
                .HasColumnOrder(142)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C040")
                .IsOptional();

            Property(p => p.PCT013C041)
                .HasColumnName("PCT013C041")
                .HasColumnOrder(143)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C041")
                .IsOptional();

            Property(p => p.PCT013C042)
                .HasColumnName("PCT013C042")
                .HasColumnOrder(144)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C042")
                .IsOptional();

            Property(p => p.PCT013C043)
                .HasColumnName("PCT013C043")
                .HasColumnOrder(145)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C043")
                .IsOptional();

            Property(p => p.PCT013C044)
                .HasColumnName("PCT013C044")
                .HasColumnOrder(146)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C044")
                .IsOptional();

            Property(p => p.PCT013C045)
                .HasColumnName("PCT013C045")
                .HasColumnOrder(147)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C045")
                .IsOptional();

            Property(p => p.PCT013C046)
                .HasColumnName("PCT013C046")
                .HasColumnOrder(148)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C046")
                .IsOptional();

            Property(p => p.PCT013C047)
                .HasColumnName("PCT013C047")
                .HasColumnOrder(149)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C047")
                .IsOptional();

            Property(p => p.PCT013C048)
                .HasColumnName("PCT013C048")
                .HasColumnOrder(150)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C048")
                .IsOptional();

            Property(p => p.PCT013C049)
                .HasColumnName("PCT013C049")
                .HasColumnOrder(151)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013C049")
                .IsOptional();

            Property(p => p.PCT013D001)
                .HasColumnName("PCT013D001")
                .HasColumnOrder(152)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D001")
                .IsOptional();

            Property(p => p.PCT013D002)
                .HasColumnName("PCT013D002")
                .HasColumnOrder(153)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D002")
                .IsOptional();

            Property(p => p.PCT013D003)
                .HasColumnName("PCT013D003")
                .HasColumnOrder(154)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D003")
                .IsOptional();

            Property(p => p.PCT013D004)
                .HasColumnName("PCT013D004")
                .HasColumnOrder(155)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D004")
                .IsOptional();

            Property(p => p.PCT013D005)
                .HasColumnName("PCT013D005")
                .HasColumnOrder(156)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D005")
                .IsOptional();

            Property(p => p.PCT013D006)
                .HasColumnName("PCT013D006")
                .HasColumnOrder(157)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D006")
                .IsOptional();

            Property(p => p.PCT013D007)
                .HasColumnName("PCT013D007")
                .HasColumnOrder(158)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D007")
                .IsOptional();

            Property(p => p.PCT013D008)
                .HasColumnName("PCT013D008")
                .HasColumnOrder(159)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D008")
                .IsOptional();

            Property(p => p.PCT013D009)
                .HasColumnName("PCT013D009")
                .HasColumnOrder(160)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D009")
                .IsOptional();

            Property(p => p.PCT013D010)
                .HasColumnName("PCT013D010")
                .HasColumnOrder(161)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D010")
                .IsOptional();

            Property(p => p.PCT013D011)
                .HasColumnName("PCT013D011")
                .HasColumnOrder(162)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D011")
                .IsOptional();

            Property(p => p.PCT013D012)
                .HasColumnName("PCT013D012")
                .HasColumnOrder(163)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D012")
                .IsOptional();

            Property(p => p.PCT013D013)
                .HasColumnName("PCT013D013")
                .HasColumnOrder(164)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D013")
                .IsOptional();

            Property(p => p.PCT013D014)
                .HasColumnName("PCT013D014")
                .HasColumnOrder(165)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D014")
                .IsOptional();

            Property(p => p.PCT013D015)
                .HasColumnName("PCT013D015")
                .HasColumnOrder(166)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D015")
                .IsOptional();

            Property(p => p.PCT013D016)
                .HasColumnName("PCT013D016")
                .HasColumnOrder(167)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D016")
                .IsOptional();

            Property(p => p.PCT013D017)
                .HasColumnName("PCT013D017")
                .HasColumnOrder(168)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D017")
                .IsOptional();

            Property(p => p.PCT013D018)
                .HasColumnName("PCT013D018")
                .HasColumnOrder(169)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D018")
                .IsOptional();

            Property(p => p.PCT013D019)
                .HasColumnName("PCT013D019")
                .HasColumnOrder(170)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D019")
                .IsOptional();

            Property(p => p.PCT013D020)
                .HasColumnName("PCT013D020")
                .HasColumnOrder(171)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D020")
                .IsOptional();

            Property(p => p.PCT013D021)
                .HasColumnName("PCT013D021")
                .HasColumnOrder(172)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D021")
                .IsOptional();

            Property(p => p.PCT013D022)
                .HasColumnName("PCT013D022")
                .HasColumnOrder(173)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D022")
                .IsOptional();

            Property(p => p.PCT013D023)
                .HasColumnName("PCT013D023")
                .HasColumnOrder(174)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D023")
                .IsOptional();

            Property(p => p.PCT013D024)
                .HasColumnName("PCT013D024")
                .HasColumnOrder(175)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D024")
                .IsOptional();

            Property(p => p.PCT013D025)
                .HasColumnName("PCT013D025")
                .HasColumnOrder(176)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D025")
                .IsOptional();

            Property(p => p.PCT013D026)
                .HasColumnName("PCT013D026")
                .HasColumnOrder(177)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D026")
                .IsOptional();

            Property(p => p.PCT013D027)
                .HasColumnName("PCT013D027")
                .HasColumnOrder(178)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D027")
                .IsOptional();

            Property(p => p.PCT013D028)
                .HasColumnName("PCT013D028")
                .HasColumnOrder(179)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D028")
                .IsOptional();

            Property(p => p.PCT013D029)
                .HasColumnName("PCT013D029")
                .HasColumnOrder(180)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D029")
                .IsOptional();

            Property(p => p.PCT013D030)
                .HasColumnName("PCT013D030")
                .HasColumnOrder(181)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D030")
                .IsOptional();

            Property(p => p.PCT013D031)
                .HasColumnName("PCT013D031")
                .HasColumnOrder(182)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D031")
                .IsOptional();

            Property(p => p.PCT013D032)
                .HasColumnName("PCT013D032")
                .HasColumnOrder(183)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D032")
                .IsOptional();

            Property(p => p.PCT013D033)
                .HasColumnName("PCT013D033")
                .HasColumnOrder(184)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D033")
                .IsOptional();

            Property(p => p.PCT013D034)
                .HasColumnName("PCT013D034")
                .HasColumnOrder(185)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D034")
                .IsOptional();

            Property(p => p.PCT013D035)
                .HasColumnName("PCT013D035")
                .HasColumnOrder(186)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D035")
                .IsOptional();

            Property(p => p.PCT013D036)
                .HasColumnName("PCT013D036")
                .HasColumnOrder(187)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D036")
                .IsOptional();

            Property(p => p.PCT013D037)
                .HasColumnName("PCT013D037")
                .HasColumnOrder(188)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D037")
                .IsOptional();

            Property(p => p.PCT013D038)
                .HasColumnName("PCT013D038")
                .HasColumnOrder(189)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D038")
                .IsOptional();

            Property(p => p.PCT013D039)
                .HasColumnName("PCT013D039")
                .HasColumnOrder(190)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D039")
                .IsOptional();

            Property(p => p.PCT013D040)
                .HasColumnName("PCT013D040")
                .HasColumnOrder(191)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D040")
                .IsOptional();

            Property(p => p.PCT013D041)
                .HasColumnName("PCT013D041")
                .HasColumnOrder(192)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D041")
                .IsOptional();

            Property(p => p.PCT013D042)
                .HasColumnName("PCT013D042")
                .HasColumnOrder(193)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D042")
                .IsOptional();

            Property(p => p.PCT013D043)
                .HasColumnName("PCT013D043")
                .HasColumnOrder(194)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D043")
                .IsOptional();

            Property(p => p.PCT013D044)
                .HasColumnName("PCT013D044")
                .HasColumnOrder(195)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D044")
                .IsOptional();

            Property(p => p.PCT013D045)
                .HasColumnName("PCT013D045")
                .HasColumnOrder(196)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D045")
                .IsOptional();

            Property(p => p.PCT013D046)
                .HasColumnName("PCT013D046")
                .HasColumnOrder(197)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D046")
                .IsOptional();

            Property(p => p.PCT013D047)
                .HasColumnName("PCT013D047")
                .HasColumnOrder(198)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D047")
                .IsOptional();

            Property(p => p.PCT013D048)
                .HasColumnName("PCT013D048")
                .HasColumnOrder(199)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D048")
                .IsOptional();

            Property(p => p.PCT013D049)
                .HasColumnName("PCT013D049")
                .HasColumnOrder(200)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013D049")
                .IsOptional();

            Property(p => p.PCT013E001)
                .HasColumnName("PCT013E001")
                .HasColumnOrder(201)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E001")
                .IsOptional();

            Property(p => p.PCT013E002)
                .HasColumnName("PCT013E002")
                .HasColumnOrder(202)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E002")
                .IsOptional();

            Property(p => p.PCT013E003)
                .HasColumnName("PCT013E003")
                .HasColumnOrder(203)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E003")
                .IsOptional();

            Property(p => p.PCT013E004)
                .HasColumnName("PCT013E004")
                .HasColumnOrder(204)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E004")
                .IsOptional();

            Property(p => p.PCT013E005)
                .HasColumnName("PCT013E005")
                .HasColumnOrder(205)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E005")
                .IsOptional();

            Property(p => p.PCT013E006)
                .HasColumnName("PCT013E006")
                .HasColumnOrder(206)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E006")
                .IsOptional();

            Property(p => p.PCT013E007)
                .HasColumnName("PCT013E007")
                .HasColumnOrder(207)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E007")
                .IsOptional();

            Property(p => p.PCT013E008)
                .HasColumnName("PCT013E008")
                .HasColumnOrder(208)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E008")
                .IsOptional();

            Property(p => p.PCT013E009)
                .HasColumnName("PCT013E009")
                .HasColumnOrder(209)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E009")
                .IsOptional();

            Property(p => p.PCT013E010)
                .HasColumnName("PCT013E010")
                .HasColumnOrder(210)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E010")
                .IsOptional();

            Property(p => p.PCT013E011)
                .HasColumnName("PCT013E011")
                .HasColumnOrder(211)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E011")
                .IsOptional();

            Property(p => p.PCT013E012)
                .HasColumnName("PCT013E012")
                .HasColumnOrder(212)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E012")
                .IsOptional();

            Property(p => p.PCT013E013)
                .HasColumnName("PCT013E013")
                .HasColumnOrder(213)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E013")
                .IsOptional();

            Property(p => p.PCT013E014)
                .HasColumnName("PCT013E014")
                .HasColumnOrder(214)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E014")
                .IsOptional();

            Property(p => p.PCT013E015)
                .HasColumnName("PCT013E015")
                .HasColumnOrder(215)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E015")
                .IsOptional();

            Property(p => p.PCT013E016)
                .HasColumnName("PCT013E016")
                .HasColumnOrder(216)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E016")
                .IsOptional();

            Property(p => p.PCT013E017)
                .HasColumnName("PCT013E017")
                .HasColumnOrder(217)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E017")
                .IsOptional();

            Property(p => p.PCT013E018)
                .HasColumnName("PCT013E018")
                .HasColumnOrder(218)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E018")
                .IsOptional();

            Property(p => p.PCT013E019)
                .HasColumnName("PCT013E019")
                .HasColumnOrder(219)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E019")
                .IsOptional();

            Property(p => p.PCT013E020)
                .HasColumnName("PCT013E020")
                .HasColumnOrder(220)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E020")
                .IsOptional();

            Property(p => p.PCT013E021)
                .HasColumnName("PCT013E021")
                .HasColumnOrder(221)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E021")
                .IsOptional();

            Property(p => p.PCT013E022)
                .HasColumnName("PCT013E022")
                .HasColumnOrder(222)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E022")
                .IsOptional();

            Property(p => p.PCT013E023)
                .HasColumnName("PCT013E023")
                .HasColumnOrder(223)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E023")
                .IsOptional();

            Property(p => p.PCT013E024)
                .HasColumnName("PCT013E024")
                .HasColumnOrder(224)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E024")
                .IsOptional();

            Property(p => p.PCT013E025)
                .HasColumnName("PCT013E025")
                .HasColumnOrder(225)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E025")
                .IsOptional();

            Property(p => p.PCT013E026)
                .HasColumnName("PCT013E026")
                .HasColumnOrder(226)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E026")
                .IsOptional();

            Property(p => p.PCT013E027)
                .HasColumnName("PCT013E027")
                .HasColumnOrder(227)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E027")
                .IsOptional();

            Property(p => p.PCT013E028)
                .HasColumnName("PCT013E028")
                .HasColumnOrder(228)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E028")
                .IsOptional();

            Property(p => p.PCT013E029)
                .HasColumnName("PCT013E029")
                .HasColumnOrder(229)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E029")
                .IsOptional();

            Property(p => p.PCT013E030)
                .HasColumnName("PCT013E030")
                .HasColumnOrder(230)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E030")
                .IsOptional();

            Property(p => p.PCT013E031)
                .HasColumnName("PCT013E031")
                .HasColumnOrder(231)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E031")
                .IsOptional();

            Property(p => p.PCT013E032)
                .HasColumnName("PCT013E032")
                .HasColumnOrder(232)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E032")
                .IsOptional();

            Property(p => p.PCT013E033)
                .HasColumnName("PCT013E033")
                .HasColumnOrder(233)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E033")
                .IsOptional();

            Property(p => p.PCT013E034)
                .HasColumnName("PCT013E034")
                .HasColumnOrder(234)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E034")
                .IsOptional();

            Property(p => p.PCT013E035)
                .HasColumnName("PCT013E035")
                .HasColumnOrder(235)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E035")
                .IsOptional();

            Property(p => p.PCT013E036)
                .HasColumnName("PCT013E036")
                .HasColumnOrder(236)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E036")
                .IsOptional();

            Property(p => p.PCT013E037)
                .HasColumnName("PCT013E037")
                .HasColumnOrder(237)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E037")
                .IsOptional();

            Property(p => p.PCT013E038)
                .HasColumnName("PCT013E038")
                .HasColumnOrder(238)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E038")
                .IsOptional();

            Property(p => p.PCT013E039)
                .HasColumnName("PCT013E039")
                .HasColumnOrder(239)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E039")
                .IsOptional();

            Property(p => p.PCT013E040)
                .HasColumnName("PCT013E040")
                .HasColumnOrder(240)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E040")
                .IsOptional();

            Property(p => p.PCT013E041)
                .HasColumnName("PCT013E041")
                .HasColumnOrder(241)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E041")
                .IsOptional();

            Property(p => p.PCT013E042)
                .HasColumnName("PCT013E042")
                .HasColumnOrder(242)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E042")
                .IsOptional();

            Property(p => p.PCT013E043)
                .HasColumnName("PCT013E043")
                .HasColumnOrder(243)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E043")
                .IsOptional();

            Property(p => p.PCT013E044)
                .HasColumnName("PCT013E044")
                .HasColumnOrder(244)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E044")
                .IsOptional();

            Property(p => p.PCT013E045)
                .HasColumnName("PCT013E045")
                .HasColumnOrder(245)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E045")
                .IsOptional();

            Property(p => p.PCT013E046)
                .HasColumnName("PCT013E046")
                .HasColumnOrder(246)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E046")
                .IsOptional();

            Property(p => p.PCT013E047)
                .HasColumnName("PCT013E047")
                .HasColumnOrder(247)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E047")
                .IsOptional();

            Property(p => p.PCT013E048)
                .HasColumnName("PCT013E048")
                .HasColumnOrder(248)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E048")
                .IsOptional();

            Property(p => p.PCT013E049)
                .HasColumnName("PCT013E049")
                .HasColumnOrder(249)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT013E049")
                .IsOptional();
        }
    }
}
