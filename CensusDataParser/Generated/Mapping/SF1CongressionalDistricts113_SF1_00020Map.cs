#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2016 12:07 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1CongressionalDistricts113_SF1_00020Map.cs
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

    public class SF1CongressionalDistricts113_SF1_00020Map : EntityTypeConfiguration<SF1CongressionalDistricts113_SF1_00020>
    {
        public SF1CongressionalDistricts113_SF1_00020Map()
        {
            ToTable("SF1_00020", "SF1CongressionalDistricts113");

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

            Property(p => p.PCT012A001)
                .HasColumnName("PCT012A001")
                .HasColumnOrder(5)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A001")
                .IsOptional();

            Property(p => p.PCT012A002)
                .HasColumnName("PCT012A002")
                .HasColumnOrder(6)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A002")
                .IsOptional();

            Property(p => p.PCT012A003)
                .HasColumnName("PCT012A003")
                .HasColumnOrder(7)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A003")
                .IsOptional();

            Property(p => p.PCT012A004)
                .HasColumnName("PCT012A004")
                .HasColumnOrder(8)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A004")
                .IsOptional();

            Property(p => p.PCT012A005)
                .HasColumnName("PCT012A005")
                .HasColumnOrder(9)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A005")
                .IsOptional();

            Property(p => p.PCT012A006)
                .HasColumnName("PCT012A006")
                .HasColumnOrder(10)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A006")
                .IsOptional();

            Property(p => p.PCT012A007)
                .HasColumnName("PCT012A007")
                .HasColumnOrder(11)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A007")
                .IsOptional();

            Property(p => p.PCT012A008)
                .HasColumnName("PCT012A008")
                .HasColumnOrder(12)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A008")
                .IsOptional();

            Property(p => p.PCT012A009)
                .HasColumnName("PCT012A009")
                .HasColumnOrder(13)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A009")
                .IsOptional();

            Property(p => p.PCT012A010)
                .HasColumnName("PCT012A010")
                .HasColumnOrder(14)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A010")
                .IsOptional();

            Property(p => p.PCT012A011)
                .HasColumnName("PCT012A011")
                .HasColumnOrder(15)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A011")
                .IsOptional();

            Property(p => p.PCT012A012)
                .HasColumnName("PCT012A012")
                .HasColumnOrder(16)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A012")
                .IsOptional();

            Property(p => p.PCT012A013)
                .HasColumnName("PCT012A013")
                .HasColumnOrder(17)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A013")
                .IsOptional();

            Property(p => p.PCT012A014)
                .HasColumnName("PCT012A014")
                .HasColumnOrder(18)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A014")
                .IsOptional();

            Property(p => p.PCT012A015)
                .HasColumnName("PCT012A015")
                .HasColumnOrder(19)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A015")
                .IsOptional();

            Property(p => p.PCT012A016)
                .HasColumnName("PCT012A016")
                .HasColumnOrder(20)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A016")
                .IsOptional();

            Property(p => p.PCT012A017)
                .HasColumnName("PCT012A017")
                .HasColumnOrder(21)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A017")
                .IsOptional();

            Property(p => p.PCT012A018)
                .HasColumnName("PCT012A018")
                .HasColumnOrder(22)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A018")
                .IsOptional();

            Property(p => p.PCT012A019)
                .HasColumnName("PCT012A019")
                .HasColumnOrder(23)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A019")
                .IsOptional();

            Property(p => p.PCT012A020)
                .HasColumnName("PCT012A020")
                .HasColumnOrder(24)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A020")
                .IsOptional();

            Property(p => p.PCT012A021)
                .HasColumnName("PCT012A021")
                .HasColumnOrder(25)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A021")
                .IsOptional();

            Property(p => p.PCT012A022)
                .HasColumnName("PCT012A022")
                .HasColumnOrder(26)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A022")
                .IsOptional();

            Property(p => p.PCT012A023)
                .HasColumnName("PCT012A023")
                .HasColumnOrder(27)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A023")
                .IsOptional();

            Property(p => p.PCT012A024)
                .HasColumnName("PCT012A024")
                .HasColumnOrder(28)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A024")
                .IsOptional();

            Property(p => p.PCT012A025)
                .HasColumnName("PCT012A025")
                .HasColumnOrder(29)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A025")
                .IsOptional();

            Property(p => p.PCT012A026)
                .HasColumnName("PCT012A026")
                .HasColumnOrder(30)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A026")
                .IsOptional();

            Property(p => p.PCT012A027)
                .HasColumnName("PCT012A027")
                .HasColumnOrder(31)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A027")
                .IsOptional();

            Property(p => p.PCT012A028)
                .HasColumnName("PCT012A028")
                .HasColumnOrder(32)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A028")
                .IsOptional();

            Property(p => p.PCT012A029)
                .HasColumnName("PCT012A029")
                .HasColumnOrder(33)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A029")
                .IsOptional();

            Property(p => p.PCT012A030)
                .HasColumnName("PCT012A030")
                .HasColumnOrder(34)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A030")
                .IsOptional();

            Property(p => p.PCT012A031)
                .HasColumnName("PCT012A031")
                .HasColumnOrder(35)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A031")
                .IsOptional();

            Property(p => p.PCT012A032)
                .HasColumnName("PCT012A032")
                .HasColumnOrder(36)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A032")
                .IsOptional();

            Property(p => p.PCT012A033)
                .HasColumnName("PCT012A033")
                .HasColumnOrder(37)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A033")
                .IsOptional();

            Property(p => p.PCT012A034)
                .HasColumnName("PCT012A034")
                .HasColumnOrder(38)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A034")
                .IsOptional();

            Property(p => p.PCT012A035)
                .HasColumnName("PCT012A035")
                .HasColumnOrder(39)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A035")
                .IsOptional();

            Property(p => p.PCT012A036)
                .HasColumnName("PCT012A036")
                .HasColumnOrder(40)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A036")
                .IsOptional();

            Property(p => p.PCT012A037)
                .HasColumnName("PCT012A037")
                .HasColumnOrder(41)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A037")
                .IsOptional();

            Property(p => p.PCT012A038)
                .HasColumnName("PCT012A038")
                .HasColumnOrder(42)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A038")
                .IsOptional();

            Property(p => p.PCT012A039)
                .HasColumnName("PCT012A039")
                .HasColumnOrder(43)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A039")
                .IsOptional();

            Property(p => p.PCT012A040)
                .HasColumnName("PCT012A040")
                .HasColumnOrder(44)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A040")
                .IsOptional();

            Property(p => p.PCT012A041)
                .HasColumnName("PCT012A041")
                .HasColumnOrder(45)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A041")
                .IsOptional();

            Property(p => p.PCT012A042)
                .HasColumnName("PCT012A042")
                .HasColumnOrder(46)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A042")
                .IsOptional();

            Property(p => p.PCT012A043)
                .HasColumnName("PCT012A043")
                .HasColumnOrder(47)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A043")
                .IsOptional();

            Property(p => p.PCT012A044)
                .HasColumnName("PCT012A044")
                .HasColumnOrder(48)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A044")
                .IsOptional();

            Property(p => p.PCT012A045)
                .HasColumnName("PCT012A045")
                .HasColumnOrder(49)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A045")
                .IsOptional();

            Property(p => p.PCT012A046)
                .HasColumnName("PCT012A046")
                .HasColumnOrder(50)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A046")
                .IsOptional();

            Property(p => p.PCT012A047)
                .HasColumnName("PCT012A047")
                .HasColumnOrder(51)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A047")
                .IsOptional();

            Property(p => p.PCT012A048)
                .HasColumnName("PCT012A048")
                .HasColumnOrder(52)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A048")
                .IsOptional();

            Property(p => p.PCT012A049)
                .HasColumnName("PCT012A049")
                .HasColumnOrder(53)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A049")
                .IsOptional();

            Property(p => p.PCT012A050)
                .HasColumnName("PCT012A050")
                .HasColumnOrder(54)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A050")
                .IsOptional();

            Property(p => p.PCT012A051)
                .HasColumnName("PCT012A051")
                .HasColumnOrder(55)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A051")
                .IsOptional();

            Property(p => p.PCT012A052)
                .HasColumnName("PCT012A052")
                .HasColumnOrder(56)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A052")
                .IsOptional();

            Property(p => p.PCT012A053)
                .HasColumnName("PCT012A053")
                .HasColumnOrder(57)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A053")
                .IsOptional();

            Property(p => p.PCT012A054)
                .HasColumnName("PCT012A054")
                .HasColumnOrder(58)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A054")
                .IsOptional();

            Property(p => p.PCT012A055)
                .HasColumnName("PCT012A055")
                .HasColumnOrder(59)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A055")
                .IsOptional();

            Property(p => p.PCT012A056)
                .HasColumnName("PCT012A056")
                .HasColumnOrder(60)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A056")
                .IsOptional();

            Property(p => p.PCT012A057)
                .HasColumnName("PCT012A057")
                .HasColumnOrder(61)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A057")
                .IsOptional();

            Property(p => p.PCT012A058)
                .HasColumnName("PCT012A058")
                .HasColumnOrder(62)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A058")
                .IsOptional();

            Property(p => p.PCT012A059)
                .HasColumnName("PCT012A059")
                .HasColumnOrder(63)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A059")
                .IsOptional();

            Property(p => p.PCT012A060)
                .HasColumnName("PCT012A060")
                .HasColumnOrder(64)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A060")
                .IsOptional();

            Property(p => p.PCT012A061)
                .HasColumnName("PCT012A061")
                .HasColumnOrder(65)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A061")
                .IsOptional();

            Property(p => p.PCT012A062)
                .HasColumnName("PCT012A062")
                .HasColumnOrder(66)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A062")
                .IsOptional();

            Property(p => p.PCT012A063)
                .HasColumnName("PCT012A063")
                .HasColumnOrder(67)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A063")
                .IsOptional();

            Property(p => p.PCT012A064)
                .HasColumnName("PCT012A064")
                .HasColumnOrder(68)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A064")
                .IsOptional();

            Property(p => p.PCT012A065)
                .HasColumnName("PCT012A065")
                .HasColumnOrder(69)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A065")
                .IsOptional();

            Property(p => p.PCT012A066)
                .HasColumnName("PCT012A066")
                .HasColumnOrder(70)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A066")
                .IsOptional();

            Property(p => p.PCT012A067)
                .HasColumnName("PCT012A067")
                .HasColumnOrder(71)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A067")
                .IsOptional();

            Property(p => p.PCT012A068)
                .HasColumnName("PCT012A068")
                .HasColumnOrder(72)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A068")
                .IsOptional();

            Property(p => p.PCT012A069)
                .HasColumnName("PCT012A069")
                .HasColumnOrder(73)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A069")
                .IsOptional();

            Property(p => p.PCT012A070)
                .HasColumnName("PCT012A070")
                .HasColumnOrder(74)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A070")
                .IsOptional();

            Property(p => p.PCT012A071)
                .HasColumnName("PCT012A071")
                .HasColumnOrder(75)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A071")
                .IsOptional();

            Property(p => p.PCT012A072)
                .HasColumnName("PCT012A072")
                .HasColumnOrder(76)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A072")
                .IsOptional();

            Property(p => p.PCT012A073)
                .HasColumnName("PCT012A073")
                .HasColumnOrder(77)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A073")
                .IsOptional();

            Property(p => p.PCT012A074)
                .HasColumnName("PCT012A074")
                .HasColumnOrder(78)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A074")
                .IsOptional();

            Property(p => p.PCT012A075)
                .HasColumnName("PCT012A075")
                .HasColumnOrder(79)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A075")
                .IsOptional();

            Property(p => p.PCT012A076)
                .HasColumnName("PCT012A076")
                .HasColumnOrder(80)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A076")
                .IsOptional();

            Property(p => p.PCT012A077)
                .HasColumnName("PCT012A077")
                .HasColumnOrder(81)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A077")
                .IsOptional();

            Property(p => p.PCT012A078)
                .HasColumnName("PCT012A078")
                .HasColumnOrder(82)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A078")
                .IsOptional();

            Property(p => p.PCT012A079)
                .HasColumnName("PCT012A079")
                .HasColumnOrder(83)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A079")
                .IsOptional();

            Property(p => p.PCT012A080)
                .HasColumnName("PCT012A080")
                .HasColumnOrder(84)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A080")
                .IsOptional();

            Property(p => p.PCT012A081)
                .HasColumnName("PCT012A081")
                .HasColumnOrder(85)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A081")
                .IsOptional();

            Property(p => p.PCT012A082)
                .HasColumnName("PCT012A082")
                .HasColumnOrder(86)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A082")
                .IsOptional();

            Property(p => p.PCT012A083)
                .HasColumnName("PCT012A083")
                .HasColumnOrder(87)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A083")
                .IsOptional();

            Property(p => p.PCT012A084)
                .HasColumnName("PCT012A084")
                .HasColumnOrder(88)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A084")
                .IsOptional();

            Property(p => p.PCT012A085)
                .HasColumnName("PCT012A085")
                .HasColumnOrder(89)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A085")
                .IsOptional();

            Property(p => p.PCT012A086)
                .HasColumnName("PCT012A086")
                .HasColumnOrder(90)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A086")
                .IsOptional();

            Property(p => p.PCT012A087)
                .HasColumnName("PCT012A087")
                .HasColumnOrder(91)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A087")
                .IsOptional();

            Property(p => p.PCT012A088)
                .HasColumnName("PCT012A088")
                .HasColumnOrder(92)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A088")
                .IsOptional();

            Property(p => p.PCT012A089)
                .HasColumnName("PCT012A089")
                .HasColumnOrder(93)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A089")
                .IsOptional();

            Property(p => p.PCT012A090)
                .HasColumnName("PCT012A090")
                .HasColumnOrder(94)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A090")
                .IsOptional();

            Property(p => p.PCT012A091)
                .HasColumnName("PCT012A091")
                .HasColumnOrder(95)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A091")
                .IsOptional();

            Property(p => p.PCT012A092)
                .HasColumnName("PCT012A092")
                .HasColumnOrder(96)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A092")
                .IsOptional();

            Property(p => p.PCT012A093)
                .HasColumnName("PCT012A093")
                .HasColumnOrder(97)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A093")
                .IsOptional();

            Property(p => p.PCT012A094)
                .HasColumnName("PCT012A094")
                .HasColumnOrder(98)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A094")
                .IsOptional();

            Property(p => p.PCT012A095)
                .HasColumnName("PCT012A095")
                .HasColumnOrder(99)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A095")
                .IsOptional();

            Property(p => p.PCT012A096)
                .HasColumnName("PCT012A096")
                .HasColumnOrder(100)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A096")
                .IsOptional();

            Property(p => p.PCT012A097)
                .HasColumnName("PCT012A097")
                .HasColumnOrder(101)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A097")
                .IsOptional();

            Property(p => p.PCT012A098)
                .HasColumnName("PCT012A098")
                .HasColumnOrder(102)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A098")
                .IsOptional();

            Property(p => p.PCT012A099)
                .HasColumnName("PCT012A099")
                .HasColumnOrder(103)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A099")
                .IsOptional();

            Property(p => p.PCT012A100)
                .HasColumnName("PCT012A100")
                .HasColumnOrder(104)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A100")
                .IsOptional();

            Property(p => p.PCT012A101)
                .HasColumnName("PCT012A101")
                .HasColumnOrder(105)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A101")
                .IsOptional();

            Property(p => p.PCT012A102)
                .HasColumnName("PCT012A102")
                .HasColumnOrder(106)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A102")
                .IsOptional();

            Property(p => p.PCT012A103)
                .HasColumnName("PCT012A103")
                .HasColumnOrder(107)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A103")
                .IsOptional();

            Property(p => p.PCT012A104)
                .HasColumnName("PCT012A104")
                .HasColumnOrder(108)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A104")
                .IsOptional();

            Property(p => p.PCT012A105)
                .HasColumnName("PCT012A105")
                .HasColumnOrder(109)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A105")
                .IsOptional();

            Property(p => p.PCT012A106)
                .HasColumnName("PCT012A106")
                .HasColumnOrder(110)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A106")
                .IsOptional();

            Property(p => p.PCT012A107)
                .HasColumnName("PCT012A107")
                .HasColumnOrder(111)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A107")
                .IsOptional();

            Property(p => p.PCT012A108)
                .HasColumnName("PCT012A108")
                .HasColumnOrder(112)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A108")
                .IsOptional();

            Property(p => p.PCT012A109)
                .HasColumnName("PCT012A109")
                .HasColumnOrder(113)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A109")
                .IsOptional();

            Property(p => p.PCT012A110)
                .HasColumnName("PCT012A110")
                .HasColumnOrder(114)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A110")
                .IsOptional();

            Property(p => p.PCT012A111)
                .HasColumnName("PCT012A111")
                .HasColumnOrder(115)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A111")
                .IsOptional();

            Property(p => p.PCT012A112)
                .HasColumnName("PCT012A112")
                .HasColumnOrder(116)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A112")
                .IsOptional();

            Property(p => p.PCT012A113)
                .HasColumnName("PCT012A113")
                .HasColumnOrder(117)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A113")
                .IsOptional();

            Property(p => p.PCT012A114)
                .HasColumnName("PCT012A114")
                .HasColumnOrder(118)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A114")
                .IsOptional();

            Property(p => p.PCT012A115)
                .HasColumnName("PCT012A115")
                .HasColumnOrder(119)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A115")
                .IsOptional();

            Property(p => p.PCT012A116)
                .HasColumnName("PCT012A116")
                .HasColumnOrder(120)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A116")
                .IsOptional();

            Property(p => p.PCT012A117)
                .HasColumnName("PCT012A117")
                .HasColumnOrder(121)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A117")
                .IsOptional();

            Property(p => p.PCT012A118)
                .HasColumnName("PCT012A118")
                .HasColumnOrder(122)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A118")
                .IsOptional();

            Property(p => p.PCT012A119)
                .HasColumnName("PCT012A119")
                .HasColumnOrder(123)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A119")
                .IsOptional();

            Property(p => p.PCT012A120)
                .HasColumnName("PCT012A120")
                .HasColumnOrder(124)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A120")
                .IsOptional();

            Property(p => p.PCT012A121)
                .HasColumnName("PCT012A121")
                .HasColumnOrder(125)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A121")
                .IsOptional();

            Property(p => p.PCT012A122)
                .HasColumnName("PCT012A122")
                .HasColumnOrder(126)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A122")
                .IsOptional();

            Property(p => p.PCT012A123)
                .HasColumnName("PCT012A123")
                .HasColumnOrder(127)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A123")
                .IsOptional();

            Property(p => p.PCT012A124)
                .HasColumnName("PCT012A124")
                .HasColumnOrder(128)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A124")
                .IsOptional();

            Property(p => p.PCT012A125)
                .HasColumnName("PCT012A125")
                .HasColumnOrder(129)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A125")
                .IsOptional();

            Property(p => p.PCT012A126)
                .HasColumnName("PCT012A126")
                .HasColumnOrder(130)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A126")
                .IsOptional();

            Property(p => p.PCT012A127)
                .HasColumnName("PCT012A127")
                .HasColumnOrder(131)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A127")
                .IsOptional();

            Property(p => p.PCT012A128)
                .HasColumnName("PCT012A128")
                .HasColumnOrder(132)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A128")
                .IsOptional();

            Property(p => p.PCT012A129)
                .HasColumnName("PCT012A129")
                .HasColumnOrder(133)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A129")
                .IsOptional();

            Property(p => p.PCT012A130)
                .HasColumnName("PCT012A130")
                .HasColumnOrder(134)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A130")
                .IsOptional();

            Property(p => p.PCT012A131)
                .HasColumnName("PCT012A131")
                .HasColumnOrder(135)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A131")
                .IsOptional();

            Property(p => p.PCT012A132)
                .HasColumnName("PCT012A132")
                .HasColumnOrder(136)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A132")
                .IsOptional();

            Property(p => p.PCT012A133)
                .HasColumnName("PCT012A133")
                .HasColumnOrder(137)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A133")
                .IsOptional();

            Property(p => p.PCT012A134)
                .HasColumnName("PCT012A134")
                .HasColumnOrder(138)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A134")
                .IsOptional();

            Property(p => p.PCT012A135)
                .HasColumnName("PCT012A135")
                .HasColumnOrder(139)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A135")
                .IsOptional();

            Property(p => p.PCT012A136)
                .HasColumnName("PCT012A136")
                .HasColumnOrder(140)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A136")
                .IsOptional();

            Property(p => p.PCT012A137)
                .HasColumnName("PCT012A137")
                .HasColumnOrder(141)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A137")
                .IsOptional();

            Property(p => p.PCT012A138)
                .HasColumnName("PCT012A138")
                .HasColumnOrder(142)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A138")
                .IsOptional();

            Property(p => p.PCT012A139)
                .HasColumnName("PCT012A139")
                .HasColumnOrder(143)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A139")
                .IsOptional();

            Property(p => p.PCT012A140)
                .HasColumnName("PCT012A140")
                .HasColumnOrder(144)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A140")
                .IsOptional();

            Property(p => p.PCT012A141)
                .HasColumnName("PCT012A141")
                .HasColumnOrder(145)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A141")
                .IsOptional();

            Property(p => p.PCT012A142)
                .HasColumnName("PCT012A142")
                .HasColumnOrder(146)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A142")
                .IsOptional();

            Property(p => p.PCT012A143)
                .HasColumnName("PCT012A143")
                .HasColumnOrder(147)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A143")
                .IsOptional();

            Property(p => p.PCT012A144)
                .HasColumnName("PCT012A144")
                .HasColumnOrder(148)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A144")
                .IsOptional();

            Property(p => p.PCT012A145)
                .HasColumnName("PCT012A145")
                .HasColumnOrder(149)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A145")
                .IsOptional();

            Property(p => p.PCT012A146)
                .HasColumnName("PCT012A146")
                .HasColumnOrder(150)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A146")
                .IsOptional();

            Property(p => p.PCT012A147)
                .HasColumnName("PCT012A147")
                .HasColumnOrder(151)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A147")
                .IsOptional();

            Property(p => p.PCT012A148)
                .HasColumnName("PCT012A148")
                .HasColumnOrder(152)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A148")
                .IsOptional();

            Property(p => p.PCT012A149)
                .HasColumnName("PCT012A149")
                .HasColumnOrder(153)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A149")
                .IsOptional();

            Property(p => p.PCT012A150)
                .HasColumnName("PCT012A150")
                .HasColumnOrder(154)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A150")
                .IsOptional();

            Property(p => p.PCT012A151)
                .HasColumnName("PCT012A151")
                .HasColumnOrder(155)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A151")
                .IsOptional();

            Property(p => p.PCT012A152)
                .HasColumnName("PCT012A152")
                .HasColumnOrder(156)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A152")
                .IsOptional();

            Property(p => p.PCT012A153)
                .HasColumnName("PCT012A153")
                .HasColumnOrder(157)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A153")
                .IsOptional();

            Property(p => p.PCT012A154)
                .HasColumnName("PCT012A154")
                .HasColumnOrder(158)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A154")
                .IsOptional();

            Property(p => p.PCT012A155)
                .HasColumnName("PCT012A155")
                .HasColumnOrder(159)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A155")
                .IsOptional();

            Property(p => p.PCT012A156)
                .HasColumnName("PCT012A156")
                .HasColumnOrder(160)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A156")
                .IsOptional();

            Property(p => p.PCT012A157)
                .HasColumnName("PCT012A157")
                .HasColumnOrder(161)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A157")
                .IsOptional();

            Property(p => p.PCT012A158)
                .HasColumnName("PCT012A158")
                .HasColumnOrder(162)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A158")
                .IsOptional();

            Property(p => p.PCT012A159)
                .HasColumnName("PCT012A159")
                .HasColumnOrder(163)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A159")
                .IsOptional();

            Property(p => p.PCT012A160)
                .HasColumnName("PCT012A160")
                .HasColumnOrder(164)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A160")
                .IsOptional();

            Property(p => p.PCT012A161)
                .HasColumnName("PCT012A161")
                .HasColumnOrder(165)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A161")
                .IsOptional();

            Property(p => p.PCT012A162)
                .HasColumnName("PCT012A162")
                .HasColumnOrder(166)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A162")
                .IsOptional();

            Property(p => p.PCT012A163)
                .HasColumnName("PCT012A163")
                .HasColumnOrder(167)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A163")
                .IsOptional();

            Property(p => p.PCT012A164)
                .HasColumnName("PCT012A164")
                .HasColumnOrder(168)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A164")
                .IsOptional();

            Property(p => p.PCT012A165)
                .HasColumnName("PCT012A165")
                .HasColumnOrder(169)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A165")
                .IsOptional();

            Property(p => p.PCT012A166)
                .HasColumnName("PCT012A166")
                .HasColumnOrder(170)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A166")
                .IsOptional();

            Property(p => p.PCT012A167)
                .HasColumnName("PCT012A167")
                .HasColumnOrder(171)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A167")
                .IsOptional();

            Property(p => p.PCT012A168)
                .HasColumnName("PCT012A168")
                .HasColumnOrder(172)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A168")
                .IsOptional();

            Property(p => p.PCT012A169)
                .HasColumnName("PCT012A169")
                .HasColumnOrder(173)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A169")
                .IsOptional();

            Property(p => p.PCT012A170)
                .HasColumnName("PCT012A170")
                .HasColumnOrder(174)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A170")
                .IsOptional();

            Property(p => p.PCT012A171)
                .HasColumnName("PCT012A171")
                .HasColumnOrder(175)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A171")
                .IsOptional();

            Property(p => p.PCT012A172)
                .HasColumnName("PCT012A172")
                .HasColumnOrder(176)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A172")
                .IsOptional();

            Property(p => p.PCT012A173)
                .HasColumnName("PCT012A173")
                .HasColumnOrder(177)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A173")
                .IsOptional();

            Property(p => p.PCT012A174)
                .HasColumnName("PCT012A174")
                .HasColumnOrder(178)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A174")
                .IsOptional();

            Property(p => p.PCT012A175)
                .HasColumnName("PCT012A175")
                .HasColumnOrder(179)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A175")
                .IsOptional();

            Property(p => p.PCT012A176)
                .HasColumnName("PCT012A176")
                .HasColumnOrder(180)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A176")
                .IsOptional();

            Property(p => p.PCT012A177)
                .HasColumnName("PCT012A177")
                .HasColumnOrder(181)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A177")
                .IsOptional();

            Property(p => p.PCT012A178)
                .HasColumnName("PCT012A178")
                .HasColumnOrder(182)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A178")
                .IsOptional();

            Property(p => p.PCT012A179)
                .HasColumnName("PCT012A179")
                .HasColumnOrder(183)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A179")
                .IsOptional();

            Property(p => p.PCT012A180)
                .HasColumnName("PCT012A180")
                .HasColumnOrder(184)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A180")
                .IsOptional();

            Property(p => p.PCT012A181)
                .HasColumnName("PCT012A181")
                .HasColumnOrder(185)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A181")
                .IsOptional();

            Property(p => p.PCT012A182)
                .HasColumnName("PCT012A182")
                .HasColumnOrder(186)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A182")
                .IsOptional();

            Property(p => p.PCT012A183)
                .HasColumnName("PCT012A183")
                .HasColumnOrder(187)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A183")
                .IsOptional();

            Property(p => p.PCT012A184)
                .HasColumnName("PCT012A184")
                .HasColumnOrder(188)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A184")
                .IsOptional();

            Property(p => p.PCT012A185)
                .HasColumnName("PCT012A185")
                .HasColumnOrder(189)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A185")
                .IsOptional();

            Property(p => p.PCT012A186)
                .HasColumnName("PCT012A186")
                .HasColumnOrder(190)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A186")
                .IsOptional();

            Property(p => p.PCT012A187)
                .HasColumnName("PCT012A187")
                .HasColumnOrder(191)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A187")
                .IsOptional();

            Property(p => p.PCT012A188)
                .HasColumnName("PCT012A188")
                .HasColumnOrder(192)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A188")
                .IsOptional();

            Property(p => p.PCT012A189)
                .HasColumnName("PCT012A189")
                .HasColumnOrder(193)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A189")
                .IsOptional();

            Property(p => p.PCT012A190)
                .HasColumnName("PCT012A190")
                .HasColumnOrder(194)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A190")
                .IsOptional();

            Property(p => p.PCT012A191)
                .HasColumnName("PCT012A191")
                .HasColumnOrder(195)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A191")
                .IsOptional();

            Property(p => p.PCT012A192)
                .HasColumnName("PCT012A192")
                .HasColumnOrder(196)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A192")
                .IsOptional();

            Property(p => p.PCT012A193)
                .HasColumnName("PCT012A193")
                .HasColumnOrder(197)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A193")
                .IsOptional();

            Property(p => p.PCT012A194)
                .HasColumnName("PCT012A194")
                .HasColumnOrder(198)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A194")
                .IsOptional();

            Property(p => p.PCT012A195)
                .HasColumnName("PCT012A195")
                .HasColumnOrder(199)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A195")
                .IsOptional();

            Property(p => p.PCT012A196)
                .HasColumnName("PCT012A196")
                .HasColumnOrder(200)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A196")
                .IsOptional();

            Property(p => p.PCT012A197)
                .HasColumnName("PCT012A197")
                .HasColumnOrder(201)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A197")
                .IsOptional();

            Property(p => p.PCT012A198)
                .HasColumnName("PCT012A198")
                .HasColumnOrder(202)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A198")
                .IsOptional();

            Property(p => p.PCT012A199)
                .HasColumnName("PCT012A199")
                .HasColumnOrder(203)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A199")
                .IsOptional();

            Property(p => p.PCT012A200)
                .HasColumnName("PCT012A200")
                .HasColumnOrder(204)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A200")
                .IsOptional();

            Property(p => p.PCT012A201)
                .HasColumnName("PCT012A201")
                .HasColumnOrder(205)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A201")
                .IsOptional();

            Property(p => p.PCT012A202)
                .HasColumnName("PCT012A202")
                .HasColumnOrder(206)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A202")
                .IsOptional();

            Property(p => p.PCT012A203)
                .HasColumnName("PCT012A203")
                .HasColumnOrder(207)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A203")
                .IsOptional();

            Property(p => p.PCT012A204)
                .HasColumnName("PCT012A204")
                .HasColumnOrder(208)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A204")
                .IsOptional();

            Property(p => p.PCT012A205)
                .HasColumnName("PCT012A205")
                .HasColumnOrder(209)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A205")
                .IsOptional();

            Property(p => p.PCT012A206)
                .HasColumnName("PCT012A206")
                .HasColumnOrder(210)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A206")
                .IsOptional();

            Property(p => p.PCT012A207)
                .HasColumnName("PCT012A207")
                .HasColumnOrder(211)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A207")
                .IsOptional();

            Property(p => p.PCT012A208)
                .HasColumnName("PCT012A208")
                .HasColumnOrder(212)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A208")
                .IsOptional();

            Property(p => p.PCT012A209)
                .HasColumnName("PCT012A209")
                .HasColumnOrder(213)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012A209")
                .IsOptional();
        }
    }
}
