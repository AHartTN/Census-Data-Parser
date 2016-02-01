#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/31/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1CongressionalDistricts113_SF1_00007Map.cs
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

    public class SF1CongressionalDistricts113_SF1_00007Map : EntityTypeConfiguration<SF1CongressionalDistricts113_SF1_00007>
    {
        public SF1CongressionalDistricts113_SF1_00007Map()
        {
            ToTable("SF1_00007", "SF1CongressionalDistricts113");

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

            Property(p => p.P0500001)
                .HasColumnName("P0500001")
                .HasColumnOrder(5)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0500001")
                .IsOptional();

            Property(p => p.P0500002)
                .HasColumnName("P0500002")
                .HasColumnOrder(6)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0500002")
                .IsOptional();

            Property(p => p.P0500003)
                .HasColumnName("P0500003")
                .HasColumnOrder(7)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0500003")
                .IsOptional();

            Property(p => p.P0510001)
                .HasColumnName("P0510001")
                .HasColumnOrder(8)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0510001")
                .IsOptional();

            Property(p => p.P0510002)
                .HasColumnName("P0510002")
                .HasColumnOrder(9)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0510002")
                .IsOptional();

            Property(p => p.P0510003)
                .HasColumnName("P0510003")
                .HasColumnOrder(10)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0510003")
                .IsOptional();

            Property(p => p.P012A001)
                .HasColumnName("P012A001")
                .HasColumnOrder(11)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A001")
                .IsOptional();

            Property(p => p.P012A002)
                .HasColumnName("P012A002")
                .HasColumnOrder(12)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A002")
                .IsOptional();

            Property(p => p.P012A003)
                .HasColumnName("P012A003")
                .HasColumnOrder(13)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A003")
                .IsOptional();

            Property(p => p.P012A004)
                .HasColumnName("P012A004")
                .HasColumnOrder(14)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A004")
                .IsOptional();

            Property(p => p.P012A005)
                .HasColumnName("P012A005")
                .HasColumnOrder(15)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A005")
                .IsOptional();

            Property(p => p.P012A006)
                .HasColumnName("P012A006")
                .HasColumnOrder(16)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A006")
                .IsOptional();

            Property(p => p.P012A007)
                .HasColumnName("P012A007")
                .HasColumnOrder(17)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A007")
                .IsOptional();

            Property(p => p.P012A008)
                .HasColumnName("P012A008")
                .HasColumnOrder(18)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A008")
                .IsOptional();

            Property(p => p.P012A009)
                .HasColumnName("P012A009")
                .HasColumnOrder(19)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A009")
                .IsOptional();

            Property(p => p.P012A010)
                .HasColumnName("P012A010")
                .HasColumnOrder(20)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A010")
                .IsOptional();

            Property(p => p.P012A011)
                .HasColumnName("P012A011")
                .HasColumnOrder(21)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A011")
                .IsOptional();

            Property(p => p.P012A012)
                .HasColumnName("P012A012")
                .HasColumnOrder(22)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A012")
                .IsOptional();

            Property(p => p.P012A013)
                .HasColumnName("P012A013")
                .HasColumnOrder(23)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A013")
                .IsOptional();

            Property(p => p.P012A014)
                .HasColumnName("P012A014")
                .HasColumnOrder(24)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A014")
                .IsOptional();

            Property(p => p.P012A015)
                .HasColumnName("P012A015")
                .HasColumnOrder(25)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A015")
                .IsOptional();

            Property(p => p.P012A016)
                .HasColumnName("P012A016")
                .HasColumnOrder(26)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A016")
                .IsOptional();

            Property(p => p.P012A017)
                .HasColumnName("P012A017")
                .HasColumnOrder(27)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A017")
                .IsOptional();

            Property(p => p.P012A018)
                .HasColumnName("P012A018")
                .HasColumnOrder(28)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A018")
                .IsOptional();

            Property(p => p.P012A019)
                .HasColumnName("P012A019")
                .HasColumnOrder(29)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A019")
                .IsOptional();

            Property(p => p.P012A020)
                .HasColumnName("P012A020")
                .HasColumnOrder(30)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A020")
                .IsOptional();

            Property(p => p.P012A021)
                .HasColumnName("P012A021")
                .HasColumnOrder(31)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A021")
                .IsOptional();

            Property(p => p.P012A022)
                .HasColumnName("P012A022")
                .HasColumnOrder(32)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A022")
                .IsOptional();

            Property(p => p.P012A023)
                .HasColumnName("P012A023")
                .HasColumnOrder(33)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A023")
                .IsOptional();

            Property(p => p.P012A024)
                .HasColumnName("P012A024")
                .HasColumnOrder(34)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A024")
                .IsOptional();

            Property(p => p.P012A025)
                .HasColumnName("P012A025")
                .HasColumnOrder(35)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A025")
                .IsOptional();

            Property(p => p.P012A026)
                .HasColumnName("P012A026")
                .HasColumnOrder(36)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A026")
                .IsOptional();

            Property(p => p.P012A027)
                .HasColumnName("P012A027")
                .HasColumnOrder(37)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A027")
                .IsOptional();

            Property(p => p.P012A028)
                .HasColumnName("P012A028")
                .HasColumnOrder(38)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A028")
                .IsOptional();

            Property(p => p.P012A029)
                .HasColumnName("P012A029")
                .HasColumnOrder(39)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A029")
                .IsOptional();

            Property(p => p.P012A030)
                .HasColumnName("P012A030")
                .HasColumnOrder(40)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A030")
                .IsOptional();

            Property(p => p.P012A031)
                .HasColumnName("P012A031")
                .HasColumnOrder(41)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A031")
                .IsOptional();

            Property(p => p.P012A032)
                .HasColumnName("P012A032")
                .HasColumnOrder(42)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A032")
                .IsOptional();

            Property(p => p.P012A033)
                .HasColumnName("P012A033")
                .HasColumnOrder(43)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A033")
                .IsOptional();

            Property(p => p.P012A034)
                .HasColumnName("P012A034")
                .HasColumnOrder(44)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A034")
                .IsOptional();

            Property(p => p.P012A035)
                .HasColumnName("P012A035")
                .HasColumnOrder(45)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A035")
                .IsOptional();

            Property(p => p.P012A036)
                .HasColumnName("P012A036")
                .HasColumnOrder(46)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A036")
                .IsOptional();

            Property(p => p.P012A037)
                .HasColumnName("P012A037")
                .HasColumnOrder(47)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A037")
                .IsOptional();

            Property(p => p.P012A038)
                .HasColumnName("P012A038")
                .HasColumnOrder(48)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A038")
                .IsOptional();

            Property(p => p.P012A039)
                .HasColumnName("P012A039")
                .HasColumnOrder(49)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A039")
                .IsOptional();

            Property(p => p.P012A040)
                .HasColumnName("P012A040")
                .HasColumnOrder(50)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A040")
                .IsOptional();

            Property(p => p.P012A041)
                .HasColumnName("P012A041")
                .HasColumnOrder(51)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A041")
                .IsOptional();

            Property(p => p.P012A042)
                .HasColumnName("P012A042")
                .HasColumnOrder(52)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A042")
                .IsOptional();

            Property(p => p.P012A043)
                .HasColumnName("P012A043")
                .HasColumnOrder(53)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A043")
                .IsOptional();

            Property(p => p.P012A044)
                .HasColumnName("P012A044")
                .HasColumnOrder(54)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A044")
                .IsOptional();

            Property(p => p.P012A045)
                .HasColumnName("P012A045")
                .HasColumnOrder(55)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A045")
                .IsOptional();

            Property(p => p.P012A046)
                .HasColumnName("P012A046")
                .HasColumnOrder(56)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A046")
                .IsOptional();

            Property(p => p.P012A047)
                .HasColumnName("P012A047")
                .HasColumnOrder(57)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A047")
                .IsOptional();

            Property(p => p.P012A048)
                .HasColumnName("P012A048")
                .HasColumnOrder(58)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A048")
                .IsOptional();

            Property(p => p.P012A049)
                .HasColumnName("P012A049")
                .HasColumnOrder(59)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012A049")
                .IsOptional();

            Property(p => p.P012B001)
                .HasColumnName("P012B001")
                .HasColumnOrder(60)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B001")
                .IsOptional();

            Property(p => p.P012B002)
                .HasColumnName("P012B002")
                .HasColumnOrder(61)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B002")
                .IsOptional();

            Property(p => p.P012B003)
                .HasColumnName("P012B003")
                .HasColumnOrder(62)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B003")
                .IsOptional();

            Property(p => p.P012B004)
                .HasColumnName("P012B004")
                .HasColumnOrder(63)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B004")
                .IsOptional();

            Property(p => p.P012B005)
                .HasColumnName("P012B005")
                .HasColumnOrder(64)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B005")
                .IsOptional();

            Property(p => p.P012B006)
                .HasColumnName("P012B006")
                .HasColumnOrder(65)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B006")
                .IsOptional();

            Property(p => p.P012B007)
                .HasColumnName("P012B007")
                .HasColumnOrder(66)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B007")
                .IsOptional();

            Property(p => p.P012B008)
                .HasColumnName("P012B008")
                .HasColumnOrder(67)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B008")
                .IsOptional();

            Property(p => p.P012B009)
                .HasColumnName("P012B009")
                .HasColumnOrder(68)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B009")
                .IsOptional();

            Property(p => p.P012B010)
                .HasColumnName("P012B010")
                .HasColumnOrder(69)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B010")
                .IsOptional();

            Property(p => p.P012B011)
                .HasColumnName("P012B011")
                .HasColumnOrder(70)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B011")
                .IsOptional();

            Property(p => p.P012B012)
                .HasColumnName("P012B012")
                .HasColumnOrder(71)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B012")
                .IsOptional();

            Property(p => p.P012B013)
                .HasColumnName("P012B013")
                .HasColumnOrder(72)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B013")
                .IsOptional();

            Property(p => p.P012B014)
                .HasColumnName("P012B014")
                .HasColumnOrder(73)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B014")
                .IsOptional();

            Property(p => p.P012B015)
                .HasColumnName("P012B015")
                .HasColumnOrder(74)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B015")
                .IsOptional();

            Property(p => p.P012B016)
                .HasColumnName("P012B016")
                .HasColumnOrder(75)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B016")
                .IsOptional();

            Property(p => p.P012B017)
                .HasColumnName("P012B017")
                .HasColumnOrder(76)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B017")
                .IsOptional();

            Property(p => p.P012B018)
                .HasColumnName("P012B018")
                .HasColumnOrder(77)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B018")
                .IsOptional();

            Property(p => p.P012B019)
                .HasColumnName("P012B019")
                .HasColumnOrder(78)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B019")
                .IsOptional();

            Property(p => p.P012B020)
                .HasColumnName("P012B020")
                .HasColumnOrder(79)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B020")
                .IsOptional();

            Property(p => p.P012B021)
                .HasColumnName("P012B021")
                .HasColumnOrder(80)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B021")
                .IsOptional();

            Property(p => p.P012B022)
                .HasColumnName("P012B022")
                .HasColumnOrder(81)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B022")
                .IsOptional();

            Property(p => p.P012B023)
                .HasColumnName("P012B023")
                .HasColumnOrder(82)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B023")
                .IsOptional();

            Property(p => p.P012B024)
                .HasColumnName("P012B024")
                .HasColumnOrder(83)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B024")
                .IsOptional();

            Property(p => p.P012B025)
                .HasColumnName("P012B025")
                .HasColumnOrder(84)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B025")
                .IsOptional();

            Property(p => p.P012B026)
                .HasColumnName("P012B026")
                .HasColumnOrder(85)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B026")
                .IsOptional();

            Property(p => p.P012B027)
                .HasColumnName("P012B027")
                .HasColumnOrder(86)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B027")
                .IsOptional();

            Property(p => p.P012B028)
                .HasColumnName("P012B028")
                .HasColumnOrder(87)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B028")
                .IsOptional();

            Property(p => p.P012B029)
                .HasColumnName("P012B029")
                .HasColumnOrder(88)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B029")
                .IsOptional();

            Property(p => p.P012B030)
                .HasColumnName("P012B030")
                .HasColumnOrder(89)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B030")
                .IsOptional();

            Property(p => p.P012B031)
                .HasColumnName("P012B031")
                .HasColumnOrder(90)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B031")
                .IsOptional();

            Property(p => p.P012B032)
                .HasColumnName("P012B032")
                .HasColumnOrder(91)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B032")
                .IsOptional();

            Property(p => p.P012B033)
                .HasColumnName("P012B033")
                .HasColumnOrder(92)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B033")
                .IsOptional();

            Property(p => p.P012B034)
                .HasColumnName("P012B034")
                .HasColumnOrder(93)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B034")
                .IsOptional();

            Property(p => p.P012B035)
                .HasColumnName("P012B035")
                .HasColumnOrder(94)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B035")
                .IsOptional();

            Property(p => p.P012B036)
                .HasColumnName("P012B036")
                .HasColumnOrder(95)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B036")
                .IsOptional();

            Property(p => p.P012B037)
                .HasColumnName("P012B037")
                .HasColumnOrder(96)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B037")
                .IsOptional();

            Property(p => p.P012B038)
                .HasColumnName("P012B038")
                .HasColumnOrder(97)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B038")
                .IsOptional();

            Property(p => p.P012B039)
                .HasColumnName("P012B039")
                .HasColumnOrder(98)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B039")
                .IsOptional();

            Property(p => p.P012B040)
                .HasColumnName("P012B040")
                .HasColumnOrder(99)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B040")
                .IsOptional();

            Property(p => p.P012B041)
                .HasColumnName("P012B041")
                .HasColumnOrder(100)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B041")
                .IsOptional();

            Property(p => p.P012B042)
                .HasColumnName("P012B042")
                .HasColumnOrder(101)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B042")
                .IsOptional();

            Property(p => p.P012B043)
                .HasColumnName("P012B043")
                .HasColumnOrder(102)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B043")
                .IsOptional();

            Property(p => p.P012B044)
                .HasColumnName("P012B044")
                .HasColumnOrder(103)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B044")
                .IsOptional();

            Property(p => p.P012B045)
                .HasColumnName("P012B045")
                .HasColumnOrder(104)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B045")
                .IsOptional();

            Property(p => p.P012B046)
                .HasColumnName("P012B046")
                .HasColumnOrder(105)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B046")
                .IsOptional();

            Property(p => p.P012B047)
                .HasColumnName("P012B047")
                .HasColumnOrder(106)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B047")
                .IsOptional();

            Property(p => p.P012B048)
                .HasColumnName("P012B048")
                .HasColumnOrder(107)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B048")
                .IsOptional();

            Property(p => p.P012B049)
                .HasColumnName("P012B049")
                .HasColumnOrder(108)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012B049")
                .IsOptional();

            Property(p => p.P012C001)
                .HasColumnName("P012C001")
                .HasColumnOrder(109)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C001")
                .IsOptional();

            Property(p => p.P012C002)
                .HasColumnName("P012C002")
                .HasColumnOrder(110)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C002")
                .IsOptional();

            Property(p => p.P012C003)
                .HasColumnName("P012C003")
                .HasColumnOrder(111)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C003")
                .IsOptional();

            Property(p => p.P012C004)
                .HasColumnName("P012C004")
                .HasColumnOrder(112)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C004")
                .IsOptional();

            Property(p => p.P012C005)
                .HasColumnName("P012C005")
                .HasColumnOrder(113)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C005")
                .IsOptional();

            Property(p => p.P012C006)
                .HasColumnName("P012C006")
                .HasColumnOrder(114)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C006")
                .IsOptional();

            Property(p => p.P012C007)
                .HasColumnName("P012C007")
                .HasColumnOrder(115)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C007")
                .IsOptional();

            Property(p => p.P012C008)
                .HasColumnName("P012C008")
                .HasColumnOrder(116)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C008")
                .IsOptional();

            Property(p => p.P012C009)
                .HasColumnName("P012C009")
                .HasColumnOrder(117)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C009")
                .IsOptional();

            Property(p => p.P012C010)
                .HasColumnName("P012C010")
                .HasColumnOrder(118)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C010")
                .IsOptional();

            Property(p => p.P012C011)
                .HasColumnName("P012C011")
                .HasColumnOrder(119)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C011")
                .IsOptional();

            Property(p => p.P012C012)
                .HasColumnName("P012C012")
                .HasColumnOrder(120)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C012")
                .IsOptional();

            Property(p => p.P012C013)
                .HasColumnName("P012C013")
                .HasColumnOrder(121)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C013")
                .IsOptional();

            Property(p => p.P012C014)
                .HasColumnName("P012C014")
                .HasColumnOrder(122)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C014")
                .IsOptional();

            Property(p => p.P012C015)
                .HasColumnName("P012C015")
                .HasColumnOrder(123)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C015")
                .IsOptional();

            Property(p => p.P012C016)
                .HasColumnName("P012C016")
                .HasColumnOrder(124)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C016")
                .IsOptional();

            Property(p => p.P012C017)
                .HasColumnName("P012C017")
                .HasColumnOrder(125)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C017")
                .IsOptional();

            Property(p => p.P012C018)
                .HasColumnName("P012C018")
                .HasColumnOrder(126)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C018")
                .IsOptional();

            Property(p => p.P012C019)
                .HasColumnName("P012C019")
                .HasColumnOrder(127)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C019")
                .IsOptional();

            Property(p => p.P012C020)
                .HasColumnName("P012C020")
                .HasColumnOrder(128)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C020")
                .IsOptional();

            Property(p => p.P012C021)
                .HasColumnName("P012C021")
                .HasColumnOrder(129)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C021")
                .IsOptional();

            Property(p => p.P012C022)
                .HasColumnName("P012C022")
                .HasColumnOrder(130)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C022")
                .IsOptional();

            Property(p => p.P012C023)
                .HasColumnName("P012C023")
                .HasColumnOrder(131)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C023")
                .IsOptional();

            Property(p => p.P012C024)
                .HasColumnName("P012C024")
                .HasColumnOrder(132)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C024")
                .IsOptional();

            Property(p => p.P012C025)
                .HasColumnName("P012C025")
                .HasColumnOrder(133)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C025")
                .IsOptional();

            Property(p => p.P012C026)
                .HasColumnName("P012C026")
                .HasColumnOrder(134)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C026")
                .IsOptional();

            Property(p => p.P012C027)
                .HasColumnName("P012C027")
                .HasColumnOrder(135)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C027")
                .IsOptional();

            Property(p => p.P012C028)
                .HasColumnName("P012C028")
                .HasColumnOrder(136)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C028")
                .IsOptional();

            Property(p => p.P012C029)
                .HasColumnName("P012C029")
                .HasColumnOrder(137)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C029")
                .IsOptional();

            Property(p => p.P012C030)
                .HasColumnName("P012C030")
                .HasColumnOrder(138)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C030")
                .IsOptional();

            Property(p => p.P012C031)
                .HasColumnName("P012C031")
                .HasColumnOrder(139)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C031")
                .IsOptional();

            Property(p => p.P012C032)
                .HasColumnName("P012C032")
                .HasColumnOrder(140)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C032")
                .IsOptional();

            Property(p => p.P012C033)
                .HasColumnName("P012C033")
                .HasColumnOrder(141)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C033")
                .IsOptional();

            Property(p => p.P012C034)
                .HasColumnName("P012C034")
                .HasColumnOrder(142)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C034")
                .IsOptional();

            Property(p => p.P012C035)
                .HasColumnName("P012C035")
                .HasColumnOrder(143)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C035")
                .IsOptional();

            Property(p => p.P012C036)
                .HasColumnName("P012C036")
                .HasColumnOrder(144)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C036")
                .IsOptional();

            Property(p => p.P012C037)
                .HasColumnName("P012C037")
                .HasColumnOrder(145)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C037")
                .IsOptional();

            Property(p => p.P012C038)
                .HasColumnName("P012C038")
                .HasColumnOrder(146)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C038")
                .IsOptional();

            Property(p => p.P012C039)
                .HasColumnName("P012C039")
                .HasColumnOrder(147)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C039")
                .IsOptional();

            Property(p => p.P012C040)
                .HasColumnName("P012C040")
                .HasColumnOrder(148)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C040")
                .IsOptional();

            Property(p => p.P012C041)
                .HasColumnName("P012C041")
                .HasColumnOrder(149)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C041")
                .IsOptional();

            Property(p => p.P012C042)
                .HasColumnName("P012C042")
                .HasColumnOrder(150)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C042")
                .IsOptional();

            Property(p => p.P012C043)
                .HasColumnName("P012C043")
                .HasColumnOrder(151)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C043")
                .IsOptional();

            Property(p => p.P012C044)
                .HasColumnName("P012C044")
                .HasColumnOrder(152)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C044")
                .IsOptional();

            Property(p => p.P012C045)
                .HasColumnName("P012C045")
                .HasColumnOrder(153)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C045")
                .IsOptional();

            Property(p => p.P012C046)
                .HasColumnName("P012C046")
                .HasColumnOrder(154)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C046")
                .IsOptional();

            Property(p => p.P012C047)
                .HasColumnName("P012C047")
                .HasColumnOrder(155)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C047")
                .IsOptional();

            Property(p => p.P012C048)
                .HasColumnName("P012C048")
                .HasColumnOrder(156)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C048")
                .IsOptional();

            Property(p => p.P012C049)
                .HasColumnName("P012C049")
                .HasColumnOrder(157)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012C049")
                .IsOptional();

            Property(p => p.P012D001)
                .HasColumnName("P012D001")
                .HasColumnOrder(158)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D001")
                .IsOptional();

            Property(p => p.P012D002)
                .HasColumnName("P012D002")
                .HasColumnOrder(159)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D002")
                .IsOptional();

            Property(p => p.P012D003)
                .HasColumnName("P012D003")
                .HasColumnOrder(160)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D003")
                .IsOptional();

            Property(p => p.P012D004)
                .HasColumnName("P012D004")
                .HasColumnOrder(161)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D004")
                .IsOptional();

            Property(p => p.P012D005)
                .HasColumnName("P012D005")
                .HasColumnOrder(162)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D005")
                .IsOptional();

            Property(p => p.P012D006)
                .HasColumnName("P012D006")
                .HasColumnOrder(163)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D006")
                .IsOptional();

            Property(p => p.P012D007)
                .HasColumnName("P012D007")
                .HasColumnOrder(164)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D007")
                .IsOptional();

            Property(p => p.P012D008)
                .HasColumnName("P012D008")
                .HasColumnOrder(165)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D008")
                .IsOptional();

            Property(p => p.P012D009)
                .HasColumnName("P012D009")
                .HasColumnOrder(166)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D009")
                .IsOptional();

            Property(p => p.P012D010)
                .HasColumnName("P012D010")
                .HasColumnOrder(167)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D010")
                .IsOptional();

            Property(p => p.P012D011)
                .HasColumnName("P012D011")
                .HasColumnOrder(168)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D011")
                .IsOptional();

            Property(p => p.P012D012)
                .HasColumnName("P012D012")
                .HasColumnOrder(169)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D012")
                .IsOptional();

            Property(p => p.P012D013)
                .HasColumnName("P012D013")
                .HasColumnOrder(170)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D013")
                .IsOptional();

            Property(p => p.P012D014)
                .HasColumnName("P012D014")
                .HasColumnOrder(171)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D014")
                .IsOptional();

            Property(p => p.P012D015)
                .HasColumnName("P012D015")
                .HasColumnOrder(172)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D015")
                .IsOptional();

            Property(p => p.P012D016)
                .HasColumnName("P012D016")
                .HasColumnOrder(173)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D016")
                .IsOptional();

            Property(p => p.P012D017)
                .HasColumnName("P012D017")
                .HasColumnOrder(174)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D017")
                .IsOptional();

            Property(p => p.P012D018)
                .HasColumnName("P012D018")
                .HasColumnOrder(175)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D018")
                .IsOptional();

            Property(p => p.P012D019)
                .HasColumnName("P012D019")
                .HasColumnOrder(176)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D019")
                .IsOptional();

            Property(p => p.P012D020)
                .HasColumnName("P012D020")
                .HasColumnOrder(177)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D020")
                .IsOptional();

            Property(p => p.P012D021)
                .HasColumnName("P012D021")
                .HasColumnOrder(178)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D021")
                .IsOptional();

            Property(p => p.P012D022)
                .HasColumnName("P012D022")
                .HasColumnOrder(179)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D022")
                .IsOptional();

            Property(p => p.P012D023)
                .HasColumnName("P012D023")
                .HasColumnOrder(180)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D023")
                .IsOptional();

            Property(p => p.P012D024)
                .HasColumnName("P012D024")
                .HasColumnOrder(181)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D024")
                .IsOptional();

            Property(p => p.P012D025)
                .HasColumnName("P012D025")
                .HasColumnOrder(182)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D025")
                .IsOptional();

            Property(p => p.P012D026)
                .HasColumnName("P012D026")
                .HasColumnOrder(183)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D026")
                .IsOptional();

            Property(p => p.P012D027)
                .HasColumnName("P012D027")
                .HasColumnOrder(184)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D027")
                .IsOptional();

            Property(p => p.P012D028)
                .HasColumnName("P012D028")
                .HasColumnOrder(185)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D028")
                .IsOptional();

            Property(p => p.P012D029)
                .HasColumnName("P012D029")
                .HasColumnOrder(186)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D029")
                .IsOptional();

            Property(p => p.P012D030)
                .HasColumnName("P012D030")
                .HasColumnOrder(187)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D030")
                .IsOptional();

            Property(p => p.P012D031)
                .HasColumnName("P012D031")
                .HasColumnOrder(188)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D031")
                .IsOptional();

            Property(p => p.P012D032)
                .HasColumnName("P012D032")
                .HasColumnOrder(189)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D032")
                .IsOptional();

            Property(p => p.P012D033)
                .HasColumnName("P012D033")
                .HasColumnOrder(190)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D033")
                .IsOptional();

            Property(p => p.P012D034)
                .HasColumnName("P012D034")
                .HasColumnOrder(191)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D034")
                .IsOptional();

            Property(p => p.P012D035)
                .HasColumnName("P012D035")
                .HasColumnOrder(192)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D035")
                .IsOptional();

            Property(p => p.P012D036)
                .HasColumnName("P012D036")
                .HasColumnOrder(193)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D036")
                .IsOptional();

            Property(p => p.P012D037)
                .HasColumnName("P012D037")
                .HasColumnOrder(194)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D037")
                .IsOptional();

            Property(p => p.P012D038)
                .HasColumnName("P012D038")
                .HasColumnOrder(195)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D038")
                .IsOptional();

            Property(p => p.P012D039)
                .HasColumnName("P012D039")
                .HasColumnOrder(196)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D039")
                .IsOptional();

            Property(p => p.P012D040)
                .HasColumnName("P012D040")
                .HasColumnOrder(197)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D040")
                .IsOptional();

            Property(p => p.P012D041)
                .HasColumnName("P012D041")
                .HasColumnOrder(198)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D041")
                .IsOptional();

            Property(p => p.P012D042)
                .HasColumnName("P012D042")
                .HasColumnOrder(199)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D042")
                .IsOptional();

            Property(p => p.P012D043)
                .HasColumnName("P012D043")
                .HasColumnOrder(200)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D043")
                .IsOptional();

            Property(p => p.P012D044)
                .HasColumnName("P012D044")
                .HasColumnOrder(201)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D044")
                .IsOptional();

            Property(p => p.P012D045)
                .HasColumnName("P012D045")
                .HasColumnOrder(202)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D045")
                .IsOptional();

            Property(p => p.P012D046)
                .HasColumnName("P012D046")
                .HasColumnOrder(203)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D046")
                .IsOptional();

            Property(p => p.P012D047)
                .HasColumnName("P012D047")
                .HasColumnOrder(204)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D047")
                .IsOptional();

            Property(p => p.P012D048)
                .HasColumnName("P012D048")
                .HasColumnOrder(205)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D048")
                .IsOptional();

            Property(p => p.P012D049)
                .HasColumnName("P012D049")
                .HasColumnOrder(206)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012D049")
                .IsOptional();

            Property(p => p.P012E001)
                .HasColumnName("P012E001")
                .HasColumnOrder(207)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E001")
                .IsOptional();

            Property(p => p.P012E002)
                .HasColumnName("P012E002")
                .HasColumnOrder(208)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E002")
                .IsOptional();

            Property(p => p.P012E003)
                .HasColumnName("P012E003")
                .HasColumnOrder(209)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E003")
                .IsOptional();

            Property(p => p.P012E004)
                .HasColumnName("P012E004")
                .HasColumnOrder(210)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E004")
                .IsOptional();

            Property(p => p.P012E005)
                .HasColumnName("P012E005")
                .HasColumnOrder(211)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E005")
                .IsOptional();

            Property(p => p.P012E006)
                .HasColumnName("P012E006")
                .HasColumnOrder(212)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E006")
                .IsOptional();

            Property(p => p.P012E007)
                .HasColumnName("P012E007")
                .HasColumnOrder(213)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E007")
                .IsOptional();

            Property(p => p.P012E008)
                .HasColumnName("P012E008")
                .HasColumnOrder(214)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E008")
                .IsOptional();

            Property(p => p.P012E009)
                .HasColumnName("P012E009")
                .HasColumnOrder(215)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E009")
                .IsOptional();

            Property(p => p.P012E010)
                .HasColumnName("P012E010")
                .HasColumnOrder(216)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E010")
                .IsOptional();

            Property(p => p.P012E011)
                .HasColumnName("P012E011")
                .HasColumnOrder(217)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E011")
                .IsOptional();

            Property(p => p.P012E012)
                .HasColumnName("P012E012")
                .HasColumnOrder(218)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E012")
                .IsOptional();

            Property(p => p.P012E013)
                .HasColumnName("P012E013")
                .HasColumnOrder(219)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E013")
                .IsOptional();

            Property(p => p.P012E014)
                .HasColumnName("P012E014")
                .HasColumnOrder(220)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E014")
                .IsOptional();

            Property(p => p.P012E015)
                .HasColumnName("P012E015")
                .HasColumnOrder(221)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E015")
                .IsOptional();

            Property(p => p.P012E016)
                .HasColumnName("P012E016")
                .HasColumnOrder(222)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E016")
                .IsOptional();

            Property(p => p.P012E017)
                .HasColumnName("P012E017")
                .HasColumnOrder(223)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E017")
                .IsOptional();

            Property(p => p.P012E018)
                .HasColumnName("P012E018")
                .HasColumnOrder(224)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E018")
                .IsOptional();

            Property(p => p.P012E019)
                .HasColumnName("P012E019")
                .HasColumnOrder(225)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E019")
                .IsOptional();

            Property(p => p.P012E020)
                .HasColumnName("P012E020")
                .HasColumnOrder(226)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E020")
                .IsOptional();

            Property(p => p.P012E021)
                .HasColumnName("P012E021")
                .HasColumnOrder(227)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E021")
                .IsOptional();

            Property(p => p.P012E022)
                .HasColumnName("P012E022")
                .HasColumnOrder(228)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E022")
                .IsOptional();

            Property(p => p.P012E023)
                .HasColumnName("P012E023")
                .HasColumnOrder(229)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E023")
                .IsOptional();

            Property(p => p.P012E024)
                .HasColumnName("P012E024")
                .HasColumnOrder(230)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E024")
                .IsOptional();

            Property(p => p.P012E025)
                .HasColumnName("P012E025")
                .HasColumnOrder(231)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E025")
                .IsOptional();

            Property(p => p.P012E026)
                .HasColumnName("P012E026")
                .HasColumnOrder(232)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E026")
                .IsOptional();

            Property(p => p.P012E027)
                .HasColumnName("P012E027")
                .HasColumnOrder(233)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E027")
                .IsOptional();

            Property(p => p.P012E028)
                .HasColumnName("P012E028")
                .HasColumnOrder(234)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E028")
                .IsOptional();

            Property(p => p.P012E029)
                .HasColumnName("P012E029")
                .HasColumnOrder(235)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E029")
                .IsOptional();

            Property(p => p.P012E030)
                .HasColumnName("P012E030")
                .HasColumnOrder(236)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E030")
                .IsOptional();

            Property(p => p.P012E031)
                .HasColumnName("P012E031")
                .HasColumnOrder(237)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E031")
                .IsOptional();

            Property(p => p.P012E032)
                .HasColumnName("P012E032")
                .HasColumnOrder(238)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E032")
                .IsOptional();

            Property(p => p.P012E033)
                .HasColumnName("P012E033")
                .HasColumnOrder(239)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E033")
                .IsOptional();

            Property(p => p.P012E034)
                .HasColumnName("P012E034")
                .HasColumnOrder(240)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E034")
                .IsOptional();

            Property(p => p.P012E035)
                .HasColumnName("P012E035")
                .HasColumnOrder(241)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E035")
                .IsOptional();

            Property(p => p.P012E036)
                .HasColumnName("P012E036")
                .HasColumnOrder(242)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E036")
                .IsOptional();

            Property(p => p.P012E037)
                .HasColumnName("P012E037")
                .HasColumnOrder(243)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E037")
                .IsOptional();

            Property(p => p.P012E038)
                .HasColumnName("P012E038")
                .HasColumnOrder(244)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E038")
                .IsOptional();

            Property(p => p.P012E039)
                .HasColumnName("P012E039")
                .HasColumnOrder(245)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E039")
                .IsOptional();

            Property(p => p.P012E040)
                .HasColumnName("P012E040")
                .HasColumnOrder(246)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E040")
                .IsOptional();

            Property(p => p.P012E041)
                .HasColumnName("P012E041")
                .HasColumnOrder(247)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E041")
                .IsOptional();

            Property(p => p.P012E042)
                .HasColumnName("P012E042")
                .HasColumnOrder(248)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E042")
                .IsOptional();

            Property(p => p.P012E043)
                .HasColumnName("P012E043")
                .HasColumnOrder(249)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E043")
                .IsOptional();

            Property(p => p.P012E044)
                .HasColumnName("P012E044")
                .HasColumnOrder(250)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E044")
                .IsOptional();

            Property(p => p.P012E045)
                .HasColumnName("P012E045")
                .HasColumnOrder(251)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E045")
                .IsOptional();

            Property(p => p.P012E046)
                .HasColumnName("P012E046")
                .HasColumnOrder(252)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E046")
                .IsOptional();

            Property(p => p.P012E047)
                .HasColumnName("P012E047")
                .HasColumnOrder(253)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E047")
                .IsOptional();

            Property(p => p.P012E048)
                .HasColumnName("P012E048")
                .HasColumnOrder(254)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E048")
                .IsOptional();

            Property(p => p.P012E049)
                .HasColumnName("P012E049")
                .HasColumnOrder(255)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P012E049")
                .IsOptional();
        }
    }
}
