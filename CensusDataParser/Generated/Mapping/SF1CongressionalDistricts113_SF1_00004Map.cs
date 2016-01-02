#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2016 12:01 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1CongressionalDistricts113_SF1_00004Map.cs
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

    public class SF1CongressionalDistricts113_SF1_00004Map : EntityTypeConfiguration<SF1CongressionalDistricts113_SF1_00004>
    {
        public SF1CongressionalDistricts113_SF1_00004Map()
        {
            ToTable("SF1_00004", "SF1CongressionalDistricts113");

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

            Property(p => p.P0100001)
                .HasColumnName("P0100001")
                .HasColumnOrder(5)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100001")
                .IsOptional();

            Property(p => p.P0100002)
                .HasColumnName("P0100002")
                .HasColumnOrder(6)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100002")
                .IsOptional();

            Property(p => p.P0100003)
                .HasColumnName("P0100003")
                .HasColumnOrder(7)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100003")
                .IsOptional();

            Property(p => p.P0100004)
                .HasColumnName("P0100004")
                .HasColumnOrder(8)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100004")
                .IsOptional();

            Property(p => p.P0100005)
                .HasColumnName("P0100005")
                .HasColumnOrder(9)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100005")
                .IsOptional();

            Property(p => p.P0100006)
                .HasColumnName("P0100006")
                .HasColumnOrder(10)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100006")
                .IsOptional();

            Property(p => p.P0100007)
                .HasColumnName("P0100007")
                .HasColumnOrder(11)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100007")
                .IsOptional();

            Property(p => p.P0100008)
                .HasColumnName("P0100008")
                .HasColumnOrder(12)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100008")
                .IsOptional();

            Property(p => p.P0100009)
                .HasColumnName("P0100009")
                .HasColumnOrder(13)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100009")
                .IsOptional();

            Property(p => p.P0100010)
                .HasColumnName("P0100010")
                .HasColumnOrder(14)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100010")
                .IsOptional();

            Property(p => p.P0100011)
                .HasColumnName("P0100011")
                .HasColumnOrder(15)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100011")
                .IsOptional();

            Property(p => p.P0100012)
                .HasColumnName("P0100012")
                .HasColumnOrder(16)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100012")
                .IsOptional();

            Property(p => p.P0100013)
                .HasColumnName("P0100013")
                .HasColumnOrder(17)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100013")
                .IsOptional();

            Property(p => p.P0100014)
                .HasColumnName("P0100014")
                .HasColumnOrder(18)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100014")
                .IsOptional();

            Property(p => p.P0100015)
                .HasColumnName("P0100015")
                .HasColumnOrder(19)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100015")
                .IsOptional();

            Property(p => p.P0100016)
                .HasColumnName("P0100016")
                .HasColumnOrder(20)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100016")
                .IsOptional();

            Property(p => p.P0100017)
                .HasColumnName("P0100017")
                .HasColumnOrder(21)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100017")
                .IsOptional();

            Property(p => p.P0100018)
                .HasColumnName("P0100018")
                .HasColumnOrder(22)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100018")
                .IsOptional();

            Property(p => p.P0100019)
                .HasColumnName("P0100019")
                .HasColumnOrder(23)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100019")
                .IsOptional();

            Property(p => p.P0100020)
                .HasColumnName("P0100020")
                .HasColumnOrder(24)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100020")
                .IsOptional();

            Property(p => p.P0100021)
                .HasColumnName("P0100021")
                .HasColumnOrder(25)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100021")
                .IsOptional();

            Property(p => p.P0100022)
                .HasColumnName("P0100022")
                .HasColumnOrder(26)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100022")
                .IsOptional();

            Property(p => p.P0100023)
                .HasColumnName("P0100023")
                .HasColumnOrder(27)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100023")
                .IsOptional();

            Property(p => p.P0100024)
                .HasColumnName("P0100024")
                .HasColumnOrder(28)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100024")
                .IsOptional();

            Property(p => p.P0100025)
                .HasColumnName("P0100025")
                .HasColumnOrder(29)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100025")
                .IsOptional();

            Property(p => p.P0100026)
                .HasColumnName("P0100026")
                .HasColumnOrder(30)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100026")
                .IsOptional();

            Property(p => p.P0100027)
                .HasColumnName("P0100027")
                .HasColumnOrder(31)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100027")
                .IsOptional();

            Property(p => p.P0100028)
                .HasColumnName("P0100028")
                .HasColumnOrder(32)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100028")
                .IsOptional();

            Property(p => p.P0100029)
                .HasColumnName("P0100029")
                .HasColumnOrder(33)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100029")
                .IsOptional();

            Property(p => p.P0100030)
                .HasColumnName("P0100030")
                .HasColumnOrder(34)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100030")
                .IsOptional();

            Property(p => p.P0100031)
                .HasColumnName("P0100031")
                .HasColumnOrder(35)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100031")
                .IsOptional();

            Property(p => p.P0100032)
                .HasColumnName("P0100032")
                .HasColumnOrder(36)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100032")
                .IsOptional();

            Property(p => p.P0100033)
                .HasColumnName("P0100033")
                .HasColumnOrder(37)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100033")
                .IsOptional();

            Property(p => p.P0100034)
                .HasColumnName("P0100034")
                .HasColumnOrder(38)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100034")
                .IsOptional();

            Property(p => p.P0100035)
                .HasColumnName("P0100035")
                .HasColumnOrder(39)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100035")
                .IsOptional();

            Property(p => p.P0100036)
                .HasColumnName("P0100036")
                .HasColumnOrder(40)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100036")
                .IsOptional();

            Property(p => p.P0100037)
                .HasColumnName("P0100037")
                .HasColumnOrder(41)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100037")
                .IsOptional();

            Property(p => p.P0100038)
                .HasColumnName("P0100038")
                .HasColumnOrder(42)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100038")
                .IsOptional();

            Property(p => p.P0100039)
                .HasColumnName("P0100039")
                .HasColumnOrder(43)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100039")
                .IsOptional();

            Property(p => p.P0100040)
                .HasColumnName("P0100040")
                .HasColumnOrder(44)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100040")
                .IsOptional();

            Property(p => p.P0100041)
                .HasColumnName("P0100041")
                .HasColumnOrder(45)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100041")
                .IsOptional();

            Property(p => p.P0100042)
                .HasColumnName("P0100042")
                .HasColumnOrder(46)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100042")
                .IsOptional();

            Property(p => p.P0100043)
                .HasColumnName("P0100043")
                .HasColumnOrder(47)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100043")
                .IsOptional();

            Property(p => p.P0100044)
                .HasColumnName("P0100044")
                .HasColumnOrder(48)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100044")
                .IsOptional();

            Property(p => p.P0100045)
                .HasColumnName("P0100045")
                .HasColumnOrder(49)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100045")
                .IsOptional();

            Property(p => p.P0100046)
                .HasColumnName("P0100046")
                .HasColumnOrder(50)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100046")
                .IsOptional();

            Property(p => p.P0100047)
                .HasColumnName("P0100047")
                .HasColumnOrder(51)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100047")
                .IsOptional();

            Property(p => p.P0100048)
                .HasColumnName("P0100048")
                .HasColumnOrder(52)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100048")
                .IsOptional();

            Property(p => p.P0100049)
                .HasColumnName("P0100049")
                .HasColumnOrder(53)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100049")
                .IsOptional();

            Property(p => p.P0100050)
                .HasColumnName("P0100050")
                .HasColumnOrder(54)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100050")
                .IsOptional();

            Property(p => p.P0100051)
                .HasColumnName("P0100051")
                .HasColumnOrder(55)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100051")
                .IsOptional();

            Property(p => p.P0100052)
                .HasColumnName("P0100052")
                .HasColumnOrder(56)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100052")
                .IsOptional();

            Property(p => p.P0100053)
                .HasColumnName("P0100053")
                .HasColumnOrder(57)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100053")
                .IsOptional();

            Property(p => p.P0100054)
                .HasColumnName("P0100054")
                .HasColumnOrder(58)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100054")
                .IsOptional();

            Property(p => p.P0100055)
                .HasColumnName("P0100055")
                .HasColumnOrder(59)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100055")
                .IsOptional();

            Property(p => p.P0100056)
                .HasColumnName("P0100056")
                .HasColumnOrder(60)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100056")
                .IsOptional();

            Property(p => p.P0100057)
                .HasColumnName("P0100057")
                .HasColumnOrder(61)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100057")
                .IsOptional();

            Property(p => p.P0100058)
                .HasColumnName("P0100058")
                .HasColumnOrder(62)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100058")
                .IsOptional();

            Property(p => p.P0100059)
                .HasColumnName("P0100059")
                .HasColumnOrder(63)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100059")
                .IsOptional();

            Property(p => p.P0100060)
                .HasColumnName("P0100060")
                .HasColumnOrder(64)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100060")
                .IsOptional();

            Property(p => p.P0100061)
                .HasColumnName("P0100061")
                .HasColumnOrder(65)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100061")
                .IsOptional();

            Property(p => p.P0100062)
                .HasColumnName("P0100062")
                .HasColumnOrder(66)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100062")
                .IsOptional();

            Property(p => p.P0100063)
                .HasColumnName("P0100063")
                .HasColumnOrder(67)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100063")
                .IsOptional();

            Property(p => p.P0100064)
                .HasColumnName("P0100064")
                .HasColumnOrder(68)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100064")
                .IsOptional();

            Property(p => p.P0100065)
                .HasColumnName("P0100065")
                .HasColumnOrder(69)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100065")
                .IsOptional();

            Property(p => p.P0100066)
                .HasColumnName("P0100066")
                .HasColumnOrder(70)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100066")
                .IsOptional();

            Property(p => p.P0100067)
                .HasColumnName("P0100067")
                .HasColumnOrder(71)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100067")
                .IsOptional();

            Property(p => p.P0100068)
                .HasColumnName("P0100068")
                .HasColumnOrder(72)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100068")
                .IsOptional();

            Property(p => p.P0100069)
                .HasColumnName("P0100069")
                .HasColumnOrder(73)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100069")
                .IsOptional();

            Property(p => p.P0100070)
                .HasColumnName("P0100070")
                .HasColumnOrder(74)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100070")
                .IsOptional();

            Property(p => p.P0100071)
                .HasColumnName("P0100071")
                .HasColumnOrder(75)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0100071")
                .IsOptional();

            Property(p => p.P0110001)
                .HasColumnName("P0110001")
                .HasColumnOrder(76)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110001")
                .IsOptional();

            Property(p => p.P0110002)
                .HasColumnName("P0110002")
                .HasColumnOrder(77)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110002")
                .IsOptional();

            Property(p => p.P0110003)
                .HasColumnName("P0110003")
                .HasColumnOrder(78)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110003")
                .IsOptional();

            Property(p => p.P0110004)
                .HasColumnName("P0110004")
                .HasColumnOrder(79)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110004")
                .IsOptional();

            Property(p => p.P0110005)
                .HasColumnName("P0110005")
                .HasColumnOrder(80)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110005")
                .IsOptional();

            Property(p => p.P0110006)
                .HasColumnName("P0110006")
                .HasColumnOrder(81)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110006")
                .IsOptional();

            Property(p => p.P0110007)
                .HasColumnName("P0110007")
                .HasColumnOrder(82)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110007")
                .IsOptional();

            Property(p => p.P0110008)
                .HasColumnName("P0110008")
                .HasColumnOrder(83)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110008")
                .IsOptional();

            Property(p => p.P0110009)
                .HasColumnName("P0110009")
                .HasColumnOrder(84)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110009")
                .IsOptional();

            Property(p => p.P0110010)
                .HasColumnName("P0110010")
                .HasColumnOrder(85)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110010")
                .IsOptional();

            Property(p => p.P0110011)
                .HasColumnName("P0110011")
                .HasColumnOrder(86)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110011")
                .IsOptional();

            Property(p => p.P0110012)
                .HasColumnName("P0110012")
                .HasColumnOrder(87)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110012")
                .IsOptional();

            Property(p => p.P0110013)
                .HasColumnName("P0110013")
                .HasColumnOrder(88)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110013")
                .IsOptional();

            Property(p => p.P0110014)
                .HasColumnName("P0110014")
                .HasColumnOrder(89)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110014")
                .IsOptional();

            Property(p => p.P0110015)
                .HasColumnName("P0110015")
                .HasColumnOrder(90)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110015")
                .IsOptional();

            Property(p => p.P0110016)
                .HasColumnName("P0110016")
                .HasColumnOrder(91)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110016")
                .IsOptional();

            Property(p => p.P0110017)
                .HasColumnName("P0110017")
                .HasColumnOrder(92)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110017")
                .IsOptional();

            Property(p => p.P0110018)
                .HasColumnName("P0110018")
                .HasColumnOrder(93)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110018")
                .IsOptional();

            Property(p => p.P0110019)
                .HasColumnName("P0110019")
                .HasColumnOrder(94)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110019")
                .IsOptional();

            Property(p => p.P0110020)
                .HasColumnName("P0110020")
                .HasColumnOrder(95)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110020")
                .IsOptional();

            Property(p => p.P0110021)
                .HasColumnName("P0110021")
                .HasColumnOrder(96)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110021")
                .IsOptional();

            Property(p => p.P0110022)
                .HasColumnName("P0110022")
                .HasColumnOrder(97)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110022")
                .IsOptional();

            Property(p => p.P0110023)
                .HasColumnName("P0110023")
                .HasColumnOrder(98)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110023")
                .IsOptional();

            Property(p => p.P0110024)
                .HasColumnName("P0110024")
                .HasColumnOrder(99)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110024")
                .IsOptional();

            Property(p => p.P0110025)
                .HasColumnName("P0110025")
                .HasColumnOrder(100)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110025")
                .IsOptional();

            Property(p => p.P0110026)
                .HasColumnName("P0110026")
                .HasColumnOrder(101)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110026")
                .IsOptional();

            Property(p => p.P0110027)
                .HasColumnName("P0110027")
                .HasColumnOrder(102)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110027")
                .IsOptional();

            Property(p => p.P0110028)
                .HasColumnName("P0110028")
                .HasColumnOrder(103)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110028")
                .IsOptional();

            Property(p => p.P0110029)
                .HasColumnName("P0110029")
                .HasColumnOrder(104)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110029")
                .IsOptional();

            Property(p => p.P0110030)
                .HasColumnName("P0110030")
                .HasColumnOrder(105)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110030")
                .IsOptional();

            Property(p => p.P0110031)
                .HasColumnName("P0110031")
                .HasColumnOrder(106)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110031")
                .IsOptional();

            Property(p => p.P0110032)
                .HasColumnName("P0110032")
                .HasColumnOrder(107)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110032")
                .IsOptional();

            Property(p => p.P0110033)
                .HasColumnName("P0110033")
                .HasColumnOrder(108)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110033")
                .IsOptional();

            Property(p => p.P0110034)
                .HasColumnName("P0110034")
                .HasColumnOrder(109)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110034")
                .IsOptional();

            Property(p => p.P0110035)
                .HasColumnName("P0110035")
                .HasColumnOrder(110)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110035")
                .IsOptional();

            Property(p => p.P0110036)
                .HasColumnName("P0110036")
                .HasColumnOrder(111)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110036")
                .IsOptional();

            Property(p => p.P0110037)
                .HasColumnName("P0110037")
                .HasColumnOrder(112)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110037")
                .IsOptional();

            Property(p => p.P0110038)
                .HasColumnName("P0110038")
                .HasColumnOrder(113)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110038")
                .IsOptional();

            Property(p => p.P0110039)
                .HasColumnName("P0110039")
                .HasColumnOrder(114)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110039")
                .IsOptional();

            Property(p => p.P0110040)
                .HasColumnName("P0110040")
                .HasColumnOrder(115)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110040")
                .IsOptional();

            Property(p => p.P0110041)
                .HasColumnName("P0110041")
                .HasColumnOrder(116)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110041")
                .IsOptional();

            Property(p => p.P0110042)
                .HasColumnName("P0110042")
                .HasColumnOrder(117)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110042")
                .IsOptional();

            Property(p => p.P0110043)
                .HasColumnName("P0110043")
                .HasColumnOrder(118)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110043")
                .IsOptional();

            Property(p => p.P0110044)
                .HasColumnName("P0110044")
                .HasColumnOrder(119)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110044")
                .IsOptional();

            Property(p => p.P0110045)
                .HasColumnName("P0110045")
                .HasColumnOrder(120)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110045")
                .IsOptional();

            Property(p => p.P0110046)
                .HasColumnName("P0110046")
                .HasColumnOrder(121)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110046")
                .IsOptional();

            Property(p => p.P0110047)
                .HasColumnName("P0110047")
                .HasColumnOrder(122)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110047")
                .IsOptional();

            Property(p => p.P0110048)
                .HasColumnName("P0110048")
                .HasColumnOrder(123)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110048")
                .IsOptional();

            Property(p => p.P0110049)
                .HasColumnName("P0110049")
                .HasColumnOrder(124)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110049")
                .IsOptional();

            Property(p => p.P0110050)
                .HasColumnName("P0110050")
                .HasColumnOrder(125)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110050")
                .IsOptional();

            Property(p => p.P0110051)
                .HasColumnName("P0110051")
                .HasColumnOrder(126)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110051")
                .IsOptional();

            Property(p => p.P0110052)
                .HasColumnName("P0110052")
                .HasColumnOrder(127)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110052")
                .IsOptional();

            Property(p => p.P0110053)
                .HasColumnName("P0110053")
                .HasColumnOrder(128)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110053")
                .IsOptional();

            Property(p => p.P0110054)
                .HasColumnName("P0110054")
                .HasColumnOrder(129)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110054")
                .IsOptional();

            Property(p => p.P0110055)
                .HasColumnName("P0110055")
                .HasColumnOrder(130)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110055")
                .IsOptional();

            Property(p => p.P0110056)
                .HasColumnName("P0110056")
                .HasColumnOrder(131)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110056")
                .IsOptional();

            Property(p => p.P0110057)
                .HasColumnName("P0110057")
                .HasColumnOrder(132)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110057")
                .IsOptional();

            Property(p => p.P0110058)
                .HasColumnName("P0110058")
                .HasColumnOrder(133)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110058")
                .IsOptional();

            Property(p => p.P0110059)
                .HasColumnName("P0110059")
                .HasColumnOrder(134)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110059")
                .IsOptional();

            Property(p => p.P0110060)
                .HasColumnName("P0110060")
                .HasColumnOrder(135)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110060")
                .IsOptional();

            Property(p => p.P0110061)
                .HasColumnName("P0110061")
                .HasColumnOrder(136)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110061")
                .IsOptional();

            Property(p => p.P0110062)
                .HasColumnName("P0110062")
                .HasColumnOrder(137)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110062")
                .IsOptional();

            Property(p => p.P0110063)
                .HasColumnName("P0110063")
                .HasColumnOrder(138)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110063")
                .IsOptional();

            Property(p => p.P0110064)
                .HasColumnName("P0110064")
                .HasColumnOrder(139)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110064")
                .IsOptional();

            Property(p => p.P0110065)
                .HasColumnName("P0110065")
                .HasColumnOrder(140)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110065")
                .IsOptional();

            Property(p => p.P0110066)
                .HasColumnName("P0110066")
                .HasColumnOrder(141)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110066")
                .IsOptional();

            Property(p => p.P0110067)
                .HasColumnName("P0110067")
                .HasColumnOrder(142)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110067")
                .IsOptional();

            Property(p => p.P0110068)
                .HasColumnName("P0110068")
                .HasColumnOrder(143)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110068")
                .IsOptional();

            Property(p => p.P0110069)
                .HasColumnName("P0110069")
                .HasColumnOrder(144)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110069")
                .IsOptional();

            Property(p => p.P0110070)
                .HasColumnName("P0110070")
                .HasColumnOrder(145)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110070")
                .IsOptional();

            Property(p => p.P0110071)
                .HasColumnName("P0110071")
                .HasColumnOrder(146)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110071")
                .IsOptional();

            Property(p => p.P0110072)
                .HasColumnName("P0110072")
                .HasColumnOrder(147)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110072")
                .IsOptional();

            Property(p => p.P0110073)
                .HasColumnName("P0110073")
                .HasColumnOrder(148)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0110073")
                .IsOptional();

            Property(p => p.P0120001)
                .HasColumnName("P0120001")
                .HasColumnOrder(149)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120001")
                .IsOptional();

            Property(p => p.P0120002)
                .HasColumnName("P0120002")
                .HasColumnOrder(150)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120002")
                .IsOptional();

            Property(p => p.P0120003)
                .HasColumnName("P0120003")
                .HasColumnOrder(151)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120003")
                .IsOptional();

            Property(p => p.P0120004)
                .HasColumnName("P0120004")
                .HasColumnOrder(152)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120004")
                .IsOptional();

            Property(p => p.P0120005)
                .HasColumnName("P0120005")
                .HasColumnOrder(153)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120005")
                .IsOptional();

            Property(p => p.P0120006)
                .HasColumnName("P0120006")
                .HasColumnOrder(154)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120006")
                .IsOptional();

            Property(p => p.P0120007)
                .HasColumnName("P0120007")
                .HasColumnOrder(155)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120007")
                .IsOptional();

            Property(p => p.P0120008)
                .HasColumnName("P0120008")
                .HasColumnOrder(156)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120008")
                .IsOptional();

            Property(p => p.P0120009)
                .HasColumnName("P0120009")
                .HasColumnOrder(157)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120009")
                .IsOptional();

            Property(p => p.P0120010)
                .HasColumnName("P0120010")
                .HasColumnOrder(158)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120010")
                .IsOptional();

            Property(p => p.P0120011)
                .HasColumnName("P0120011")
                .HasColumnOrder(159)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120011")
                .IsOptional();

            Property(p => p.P0120012)
                .HasColumnName("P0120012")
                .HasColumnOrder(160)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120012")
                .IsOptional();

            Property(p => p.P0120013)
                .HasColumnName("P0120013")
                .HasColumnOrder(161)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120013")
                .IsOptional();

            Property(p => p.P0120014)
                .HasColumnName("P0120014")
                .HasColumnOrder(162)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120014")
                .IsOptional();

            Property(p => p.P0120015)
                .HasColumnName("P0120015")
                .HasColumnOrder(163)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120015")
                .IsOptional();

            Property(p => p.P0120016)
                .HasColumnName("P0120016")
                .HasColumnOrder(164)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120016")
                .IsOptional();

            Property(p => p.P0120017)
                .HasColumnName("P0120017")
                .HasColumnOrder(165)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120017")
                .IsOptional();

            Property(p => p.P0120018)
                .HasColumnName("P0120018")
                .HasColumnOrder(166)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120018")
                .IsOptional();

            Property(p => p.P0120019)
                .HasColumnName("P0120019")
                .HasColumnOrder(167)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120019")
                .IsOptional();

            Property(p => p.P0120020)
                .HasColumnName("P0120020")
                .HasColumnOrder(168)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120020")
                .IsOptional();

            Property(p => p.P0120021)
                .HasColumnName("P0120021")
                .HasColumnOrder(169)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120021")
                .IsOptional();

            Property(p => p.P0120022)
                .HasColumnName("P0120022")
                .HasColumnOrder(170)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120022")
                .IsOptional();

            Property(p => p.P0120023)
                .HasColumnName("P0120023")
                .HasColumnOrder(171)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120023")
                .IsOptional();

            Property(p => p.P0120024)
                .HasColumnName("P0120024")
                .HasColumnOrder(172)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120024")
                .IsOptional();

            Property(p => p.P0120025)
                .HasColumnName("P0120025")
                .HasColumnOrder(173)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120025")
                .IsOptional();

            Property(p => p.P0120026)
                .HasColumnName("P0120026")
                .HasColumnOrder(174)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120026")
                .IsOptional();

            Property(p => p.P0120027)
                .HasColumnName("P0120027")
                .HasColumnOrder(175)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120027")
                .IsOptional();

            Property(p => p.P0120028)
                .HasColumnName("P0120028")
                .HasColumnOrder(176)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120028")
                .IsOptional();

            Property(p => p.P0120029)
                .HasColumnName("P0120029")
                .HasColumnOrder(177)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120029")
                .IsOptional();

            Property(p => p.P0120030)
                .HasColumnName("P0120030")
                .HasColumnOrder(178)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120030")
                .IsOptional();

            Property(p => p.P0120031)
                .HasColumnName("P0120031")
                .HasColumnOrder(179)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120031")
                .IsOptional();

            Property(p => p.P0120032)
                .HasColumnName("P0120032")
                .HasColumnOrder(180)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120032")
                .IsOptional();

            Property(p => p.P0120033)
                .HasColumnName("P0120033")
                .HasColumnOrder(181)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120033")
                .IsOptional();

            Property(p => p.P0120034)
                .HasColumnName("P0120034")
                .HasColumnOrder(182)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120034")
                .IsOptional();

            Property(p => p.P0120035)
                .HasColumnName("P0120035")
                .HasColumnOrder(183)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120035")
                .IsOptional();

            Property(p => p.P0120036)
                .HasColumnName("P0120036")
                .HasColumnOrder(184)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120036")
                .IsOptional();

            Property(p => p.P0120037)
                .HasColumnName("P0120037")
                .HasColumnOrder(185)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120037")
                .IsOptional();

            Property(p => p.P0120038)
                .HasColumnName("P0120038")
                .HasColumnOrder(186)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120038")
                .IsOptional();

            Property(p => p.P0120039)
                .HasColumnName("P0120039")
                .HasColumnOrder(187)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120039")
                .IsOptional();

            Property(p => p.P0120040)
                .HasColumnName("P0120040")
                .HasColumnOrder(188)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120040")
                .IsOptional();

            Property(p => p.P0120041)
                .HasColumnName("P0120041")
                .HasColumnOrder(189)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120041")
                .IsOptional();

            Property(p => p.P0120042)
                .HasColumnName("P0120042")
                .HasColumnOrder(190)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120042")
                .IsOptional();

            Property(p => p.P0120043)
                .HasColumnName("P0120043")
                .HasColumnOrder(191)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120043")
                .IsOptional();

            Property(p => p.P0120044)
                .HasColumnName("P0120044")
                .HasColumnOrder(192)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120044")
                .IsOptional();

            Property(p => p.P0120045)
                .HasColumnName("P0120045")
                .HasColumnOrder(193)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120045")
                .IsOptional();

            Property(p => p.P0120046)
                .HasColumnName("P0120046")
                .HasColumnOrder(194)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120046")
                .IsOptional();

            Property(p => p.P0120047)
                .HasColumnName("P0120047")
                .HasColumnOrder(195)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120047")
                .IsOptional();

            Property(p => p.P0120048)
                .HasColumnName("P0120048")
                .HasColumnOrder(196)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120048")
                .IsOptional();

            Property(p => p.P0120049)
                .HasColumnName("P0120049")
                .HasColumnOrder(197)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0120049")
                .IsOptional();

            Property(p => p.P0130001)
                .HasColumnName("P0130001")
                .HasColumnOrder(198)
                .HasColumnType("DOUBLE")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0130001")
                .IsOptional();

            Property(p => p.P0130002)
                .HasColumnName("P0130002")
                .HasColumnOrder(199)
                .HasColumnType("DOUBLE")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0130002")
                .IsOptional();

            Property(p => p.P0130003)
                .HasColumnName("P0130003")
                .HasColumnOrder(200)
                .HasColumnType("DOUBLE")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0130003")
                .IsOptional();

            Property(p => p.P0140001)
                .HasColumnName("P0140001")
                .HasColumnOrder(201)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140001")
                .IsOptional();

            Property(p => p.P0140002)
                .HasColumnName("P0140002")
                .HasColumnOrder(202)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140002")
                .IsOptional();

            Property(p => p.P0140003)
                .HasColumnName("P0140003")
                .HasColumnOrder(203)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140003")
                .IsOptional();

            Property(p => p.P0140004)
                .HasColumnName("P0140004")
                .HasColumnOrder(204)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140004")
                .IsOptional();

            Property(p => p.P0140005)
                .HasColumnName("P0140005")
                .HasColumnOrder(205)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140005")
                .IsOptional();

            Property(p => p.P0140006)
                .HasColumnName("P0140006")
                .HasColumnOrder(206)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140006")
                .IsOptional();

            Property(p => p.P0140007)
                .HasColumnName("P0140007")
                .HasColumnOrder(207)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140007")
                .IsOptional();

            Property(p => p.P0140008)
                .HasColumnName("P0140008")
                .HasColumnOrder(208)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140008")
                .IsOptional();

            Property(p => p.P0140009)
                .HasColumnName("P0140009")
                .HasColumnOrder(209)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140009")
                .IsOptional();

            Property(p => p.P0140010)
                .HasColumnName("P0140010")
                .HasColumnOrder(210)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140010")
                .IsOptional();

            Property(p => p.P0140011)
                .HasColumnName("P0140011")
                .HasColumnOrder(211)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140011")
                .IsOptional();

            Property(p => p.P0140012)
                .HasColumnName("P0140012")
                .HasColumnOrder(212)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140012")
                .IsOptional();

            Property(p => p.P0140013)
                .HasColumnName("P0140013")
                .HasColumnOrder(213)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140013")
                .IsOptional();

            Property(p => p.P0140014)
                .HasColumnName("P0140014")
                .HasColumnOrder(214)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140014")
                .IsOptional();

            Property(p => p.P0140015)
                .HasColumnName("P0140015")
                .HasColumnOrder(215)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140015")
                .IsOptional();

            Property(p => p.P0140016)
                .HasColumnName("P0140016")
                .HasColumnOrder(216)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140016")
                .IsOptional();

            Property(p => p.P0140017)
                .HasColumnName("P0140017")
                .HasColumnOrder(217)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140017")
                .IsOptional();

            Property(p => p.P0140018)
                .HasColumnName("P0140018")
                .HasColumnOrder(218)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140018")
                .IsOptional();

            Property(p => p.P0140019)
                .HasColumnName("P0140019")
                .HasColumnOrder(219)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140019")
                .IsOptional();

            Property(p => p.P0140020)
                .HasColumnName("P0140020")
                .HasColumnOrder(220)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140020")
                .IsOptional();

            Property(p => p.P0140021)
                .HasColumnName("P0140021")
                .HasColumnOrder(221)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140021")
                .IsOptional();

            Property(p => p.P0140022)
                .HasColumnName("P0140022")
                .HasColumnOrder(222)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140022")
                .IsOptional();

            Property(p => p.P0140023)
                .HasColumnName("P0140023")
                .HasColumnOrder(223)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140023")
                .IsOptional();

            Property(p => p.P0140024)
                .HasColumnName("P0140024")
                .HasColumnOrder(224)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140024")
                .IsOptional();

            Property(p => p.P0140025)
                .HasColumnName("P0140025")
                .HasColumnOrder(225)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140025")
                .IsOptional();

            Property(p => p.P0140026)
                .HasColumnName("P0140026")
                .HasColumnOrder(226)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140026")
                .IsOptional();

            Property(p => p.P0140027)
                .HasColumnName("P0140027")
                .HasColumnOrder(227)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140027")
                .IsOptional();

            Property(p => p.P0140028)
                .HasColumnName("P0140028")
                .HasColumnOrder(228)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140028")
                .IsOptional();

            Property(p => p.P0140029)
                .HasColumnName("P0140029")
                .HasColumnOrder(229)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140029")
                .IsOptional();

            Property(p => p.P0140030)
                .HasColumnName("P0140030")
                .HasColumnOrder(230)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140030")
                .IsOptional();

            Property(p => p.P0140031)
                .HasColumnName("P0140031")
                .HasColumnOrder(231)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140031")
                .IsOptional();

            Property(p => p.P0140032)
                .HasColumnName("P0140032")
                .HasColumnOrder(232)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140032")
                .IsOptional();

            Property(p => p.P0140033)
                .HasColumnName("P0140033")
                .HasColumnOrder(233)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140033")
                .IsOptional();

            Property(p => p.P0140034)
                .HasColumnName("P0140034")
                .HasColumnOrder(234)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140034")
                .IsOptional();

            Property(p => p.P0140035)
                .HasColumnName("P0140035")
                .HasColumnOrder(235)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140035")
                .IsOptional();

            Property(p => p.P0140036)
                .HasColumnName("P0140036")
                .HasColumnOrder(236)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140036")
                .IsOptional();

            Property(p => p.P0140037)
                .HasColumnName("P0140037")
                .HasColumnOrder(237)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140037")
                .IsOptional();

            Property(p => p.P0140038)
                .HasColumnName("P0140038")
                .HasColumnOrder(238)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140038")
                .IsOptional();

            Property(p => p.P0140039)
                .HasColumnName("P0140039")
                .HasColumnOrder(239)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140039")
                .IsOptional();

            Property(p => p.P0140040)
                .HasColumnName("P0140040")
                .HasColumnOrder(240)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140040")
                .IsOptional();

            Property(p => p.P0140041)
                .HasColumnName("P0140041")
                .HasColumnOrder(241)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140041")
                .IsOptional();

            Property(p => p.P0140042)
                .HasColumnName("P0140042")
                .HasColumnOrder(242)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140042")
                .IsOptional();

            Property(p => p.P0140043)
                .HasColumnName("P0140043")
                .HasColumnOrder(243)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0140043")
                .IsOptional();
        }
    }
}
