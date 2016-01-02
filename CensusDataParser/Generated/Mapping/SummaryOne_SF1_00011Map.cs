#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2016 12:19 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SummaryOne_SF1_00011Map.cs
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

    public class SummaryOne_SF1_00011Map : EntityTypeConfiguration<SummaryOne_SF1_00011>
    {
        public SummaryOne_SF1_00011Map()
        {
            ToTable("SF1_00011", "SummaryOne");

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

            Property(p => p.P031A001)
                .HasColumnName("P031A001")
                .HasColumnOrder(5)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031A001")
                .IsOptional();

            Property(p => p.P031A002)
                .HasColumnName("P031A002")
                .HasColumnOrder(6)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031A002")
                .IsOptional();

            Property(p => p.P031A003)
                .HasColumnName("P031A003")
                .HasColumnOrder(7)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031A003")
                .IsOptional();

            Property(p => p.P031A004)
                .HasColumnName("P031A004")
                .HasColumnOrder(8)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031A004")
                .IsOptional();

            Property(p => p.P031A005)
                .HasColumnName("P031A005")
                .HasColumnOrder(9)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031A005")
                .IsOptional();

            Property(p => p.P031A006)
                .HasColumnName("P031A006")
                .HasColumnOrder(10)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031A006")
                .IsOptional();

            Property(p => p.P031A007)
                .HasColumnName("P031A007")
                .HasColumnOrder(11)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031A007")
                .IsOptional();

            Property(p => p.P031A008)
                .HasColumnName("P031A008")
                .HasColumnOrder(12)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031A008")
                .IsOptional();

            Property(p => p.P031A009)
                .HasColumnName("P031A009")
                .HasColumnOrder(13)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031A009")
                .IsOptional();

            Property(p => p.P031A010)
                .HasColumnName("P031A010")
                .HasColumnOrder(14)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031A010")
                .IsOptional();

            Property(p => p.P031A011)
                .HasColumnName("P031A011")
                .HasColumnOrder(15)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031A011")
                .IsOptional();

            Property(p => p.P031A012)
                .HasColumnName("P031A012")
                .HasColumnOrder(16)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031A012")
                .IsOptional();

            Property(p => p.P031A013)
                .HasColumnName("P031A013")
                .HasColumnOrder(17)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031A013")
                .IsOptional();

            Property(p => p.P031A014)
                .HasColumnName("P031A014")
                .HasColumnOrder(18)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031A014")
                .IsOptional();

            Property(p => p.P031A015)
                .HasColumnName("P031A015")
                .HasColumnOrder(19)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031A015")
                .IsOptional();

            Property(p => p.P031A016)
                .HasColumnName("P031A016")
                .HasColumnOrder(20)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031A016")
                .IsOptional();

            Property(p => p.P031B001)
                .HasColumnName("P031B001")
                .HasColumnOrder(21)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031B001")
                .IsOptional();

            Property(p => p.P031B002)
                .HasColumnName("P031B002")
                .HasColumnOrder(22)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031B002")
                .IsOptional();

            Property(p => p.P031B003)
                .HasColumnName("P031B003")
                .HasColumnOrder(23)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031B003")
                .IsOptional();

            Property(p => p.P031B004)
                .HasColumnName("P031B004")
                .HasColumnOrder(24)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031B004")
                .IsOptional();

            Property(p => p.P031B005)
                .HasColumnName("P031B005")
                .HasColumnOrder(25)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031B005")
                .IsOptional();

            Property(p => p.P031B006)
                .HasColumnName("P031B006")
                .HasColumnOrder(26)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031B006")
                .IsOptional();

            Property(p => p.P031B007)
                .HasColumnName("P031B007")
                .HasColumnOrder(27)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031B007")
                .IsOptional();

            Property(p => p.P031B008)
                .HasColumnName("P031B008")
                .HasColumnOrder(28)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031B008")
                .IsOptional();

            Property(p => p.P031B009)
                .HasColumnName("P031B009")
                .HasColumnOrder(29)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031B009")
                .IsOptional();

            Property(p => p.P031B010)
                .HasColumnName("P031B010")
                .HasColumnOrder(30)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031B010")
                .IsOptional();

            Property(p => p.P031B011)
                .HasColumnName("P031B011")
                .HasColumnOrder(31)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031B011")
                .IsOptional();

            Property(p => p.P031B012)
                .HasColumnName("P031B012")
                .HasColumnOrder(32)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031B012")
                .IsOptional();

            Property(p => p.P031B013)
                .HasColumnName("P031B013")
                .HasColumnOrder(33)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031B013")
                .IsOptional();

            Property(p => p.P031B014)
                .HasColumnName("P031B014")
                .HasColumnOrder(34)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031B014")
                .IsOptional();

            Property(p => p.P031B015)
                .HasColumnName("P031B015")
                .HasColumnOrder(35)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031B015")
                .IsOptional();

            Property(p => p.P031B016)
                .HasColumnName("P031B016")
                .HasColumnOrder(36)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031B016")
                .IsOptional();

            Property(p => p.P031C001)
                .HasColumnName("P031C001")
                .HasColumnOrder(37)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031C001")
                .IsOptional();

            Property(p => p.P031C002)
                .HasColumnName("P031C002")
                .HasColumnOrder(38)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031C002")
                .IsOptional();

            Property(p => p.P031C003)
                .HasColumnName("P031C003")
                .HasColumnOrder(39)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031C003")
                .IsOptional();

            Property(p => p.P031C004)
                .HasColumnName("P031C004")
                .HasColumnOrder(40)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031C004")
                .IsOptional();

            Property(p => p.P031C005)
                .HasColumnName("P031C005")
                .HasColumnOrder(41)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031C005")
                .IsOptional();

            Property(p => p.P031C006)
                .HasColumnName("P031C006")
                .HasColumnOrder(42)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031C006")
                .IsOptional();

            Property(p => p.P031C007)
                .HasColumnName("P031C007")
                .HasColumnOrder(43)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031C007")
                .IsOptional();

            Property(p => p.P031C008)
                .HasColumnName("P031C008")
                .HasColumnOrder(44)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031C008")
                .IsOptional();

            Property(p => p.P031C009)
                .HasColumnName("P031C009")
                .HasColumnOrder(45)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031C009")
                .IsOptional();

            Property(p => p.P031C010)
                .HasColumnName("P031C010")
                .HasColumnOrder(46)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031C010")
                .IsOptional();

            Property(p => p.P031C011)
                .HasColumnName("P031C011")
                .HasColumnOrder(47)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031C011")
                .IsOptional();

            Property(p => p.P031C012)
                .HasColumnName("P031C012")
                .HasColumnOrder(48)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031C012")
                .IsOptional();

            Property(p => p.P031C013)
                .HasColumnName("P031C013")
                .HasColumnOrder(49)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031C013")
                .IsOptional();

            Property(p => p.P031C014)
                .HasColumnName("P031C014")
                .HasColumnOrder(50)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031C014")
                .IsOptional();

            Property(p => p.P031C015)
                .HasColumnName("P031C015")
                .HasColumnOrder(51)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031C015")
                .IsOptional();

            Property(p => p.P031C016)
                .HasColumnName("P031C016")
                .HasColumnOrder(52)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031C016")
                .IsOptional();

            Property(p => p.P031D001)
                .HasColumnName("P031D001")
                .HasColumnOrder(53)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031D001")
                .IsOptional();

            Property(p => p.P031D002)
                .HasColumnName("P031D002")
                .HasColumnOrder(54)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031D002")
                .IsOptional();

            Property(p => p.P031D003)
                .HasColumnName("P031D003")
                .HasColumnOrder(55)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031D003")
                .IsOptional();

            Property(p => p.P031D004)
                .HasColumnName("P031D004")
                .HasColumnOrder(56)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031D004")
                .IsOptional();

            Property(p => p.P031D005)
                .HasColumnName("P031D005")
                .HasColumnOrder(57)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031D005")
                .IsOptional();

            Property(p => p.P031D006)
                .HasColumnName("P031D006")
                .HasColumnOrder(58)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031D006")
                .IsOptional();

            Property(p => p.P031D007)
                .HasColumnName("P031D007")
                .HasColumnOrder(59)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031D007")
                .IsOptional();

            Property(p => p.P031D008)
                .HasColumnName("P031D008")
                .HasColumnOrder(60)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031D008")
                .IsOptional();

            Property(p => p.P031D009)
                .HasColumnName("P031D009")
                .HasColumnOrder(61)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031D009")
                .IsOptional();

            Property(p => p.P031D010)
                .HasColumnName("P031D010")
                .HasColumnOrder(62)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031D010")
                .IsOptional();

            Property(p => p.P031D011)
                .HasColumnName("P031D011")
                .HasColumnOrder(63)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031D011")
                .IsOptional();

            Property(p => p.P031D012)
                .HasColumnName("P031D012")
                .HasColumnOrder(64)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031D012")
                .IsOptional();

            Property(p => p.P031D013)
                .HasColumnName("P031D013")
                .HasColumnOrder(65)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031D013")
                .IsOptional();

            Property(p => p.P031D014)
                .HasColumnName("P031D014")
                .HasColumnOrder(66)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031D014")
                .IsOptional();

            Property(p => p.P031D015)
                .HasColumnName("P031D015")
                .HasColumnOrder(67)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031D015")
                .IsOptional();

            Property(p => p.P031D016)
                .HasColumnName("P031D016")
                .HasColumnOrder(68)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031D016")
                .IsOptional();

            Property(p => p.P031E001)
                .HasColumnName("P031E001")
                .HasColumnOrder(69)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031E001")
                .IsOptional();

            Property(p => p.P031E002)
                .HasColumnName("P031E002")
                .HasColumnOrder(70)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031E002")
                .IsOptional();

            Property(p => p.P031E003)
                .HasColumnName("P031E003")
                .HasColumnOrder(71)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031E003")
                .IsOptional();

            Property(p => p.P031E004)
                .HasColumnName("P031E004")
                .HasColumnOrder(72)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031E004")
                .IsOptional();

            Property(p => p.P031E005)
                .HasColumnName("P031E005")
                .HasColumnOrder(73)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031E005")
                .IsOptional();

            Property(p => p.P031E006)
                .HasColumnName("P031E006")
                .HasColumnOrder(74)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031E006")
                .IsOptional();

            Property(p => p.P031E007)
                .HasColumnName("P031E007")
                .HasColumnOrder(75)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031E007")
                .IsOptional();

            Property(p => p.P031E008)
                .HasColumnName("P031E008")
                .HasColumnOrder(76)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031E008")
                .IsOptional();

            Property(p => p.P031E009)
                .HasColumnName("P031E009")
                .HasColumnOrder(77)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031E009")
                .IsOptional();

            Property(p => p.P031E010)
                .HasColumnName("P031E010")
                .HasColumnOrder(78)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031E010")
                .IsOptional();

            Property(p => p.P031E011)
                .HasColumnName("P031E011")
                .HasColumnOrder(79)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031E011")
                .IsOptional();

            Property(p => p.P031E012)
                .HasColumnName("P031E012")
                .HasColumnOrder(80)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031E012")
                .IsOptional();

            Property(p => p.P031E013)
                .HasColumnName("P031E013")
                .HasColumnOrder(81)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031E013")
                .IsOptional();

            Property(p => p.P031E014)
                .HasColumnName("P031E014")
                .HasColumnOrder(82)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031E014")
                .IsOptional();

            Property(p => p.P031E015)
                .HasColumnName("P031E015")
                .HasColumnOrder(83)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031E015")
                .IsOptional();

            Property(p => p.P031E016)
                .HasColumnName("P031E016")
                .HasColumnOrder(84)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031E016")
                .IsOptional();

            Property(p => p.P031F001)
                .HasColumnName("P031F001")
                .HasColumnOrder(85)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031F001")
                .IsOptional();

            Property(p => p.P031F002)
                .HasColumnName("P031F002")
                .HasColumnOrder(86)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031F002")
                .IsOptional();

            Property(p => p.P031F003)
                .HasColumnName("P031F003")
                .HasColumnOrder(87)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031F003")
                .IsOptional();

            Property(p => p.P031F004)
                .HasColumnName("P031F004")
                .HasColumnOrder(88)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031F004")
                .IsOptional();

            Property(p => p.P031F005)
                .HasColumnName("P031F005")
                .HasColumnOrder(89)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031F005")
                .IsOptional();

            Property(p => p.P031F006)
                .HasColumnName("P031F006")
                .HasColumnOrder(90)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031F006")
                .IsOptional();

            Property(p => p.P031F007)
                .HasColumnName("P031F007")
                .HasColumnOrder(91)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031F007")
                .IsOptional();

            Property(p => p.P031F008)
                .HasColumnName("P031F008")
                .HasColumnOrder(92)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031F008")
                .IsOptional();

            Property(p => p.P031F009)
                .HasColumnName("P031F009")
                .HasColumnOrder(93)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031F009")
                .IsOptional();

            Property(p => p.P031F010)
                .HasColumnName("P031F010")
                .HasColumnOrder(94)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031F010")
                .IsOptional();

            Property(p => p.P031F011)
                .HasColumnName("P031F011")
                .HasColumnOrder(95)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031F011")
                .IsOptional();

            Property(p => p.P031F012)
                .HasColumnName("P031F012")
                .HasColumnOrder(96)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031F012")
                .IsOptional();

            Property(p => p.P031F013)
                .HasColumnName("P031F013")
                .HasColumnOrder(97)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031F013")
                .IsOptional();

            Property(p => p.P031F014)
                .HasColumnName("P031F014")
                .HasColumnOrder(98)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031F014")
                .IsOptional();

            Property(p => p.P031F015)
                .HasColumnName("P031F015")
                .HasColumnOrder(99)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031F015")
                .IsOptional();

            Property(p => p.P031F016)
                .HasColumnName("P031F016")
                .HasColumnOrder(100)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031F016")
                .IsOptional();

            Property(p => p.P031G001)
                .HasColumnName("P031G001")
                .HasColumnOrder(101)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031G001")
                .IsOptional();

            Property(p => p.P031G002)
                .HasColumnName("P031G002")
                .HasColumnOrder(102)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031G002")
                .IsOptional();

            Property(p => p.P031G003)
                .HasColumnName("P031G003")
                .HasColumnOrder(103)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031G003")
                .IsOptional();

            Property(p => p.P031G004)
                .HasColumnName("P031G004")
                .HasColumnOrder(104)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031G004")
                .IsOptional();

            Property(p => p.P031G005)
                .HasColumnName("P031G005")
                .HasColumnOrder(105)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031G005")
                .IsOptional();

            Property(p => p.P031G006)
                .HasColumnName("P031G006")
                .HasColumnOrder(106)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031G006")
                .IsOptional();

            Property(p => p.P031G007)
                .HasColumnName("P031G007")
                .HasColumnOrder(107)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031G007")
                .IsOptional();

            Property(p => p.P031G008)
                .HasColumnName("P031G008")
                .HasColumnOrder(108)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031G008")
                .IsOptional();

            Property(p => p.P031G009)
                .HasColumnName("P031G009")
                .HasColumnOrder(109)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031G009")
                .IsOptional();

            Property(p => p.P031G010)
                .HasColumnName("P031G010")
                .HasColumnOrder(110)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031G010")
                .IsOptional();

            Property(p => p.P031G011)
                .HasColumnName("P031G011")
                .HasColumnOrder(111)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031G011")
                .IsOptional();

            Property(p => p.P031G012)
                .HasColumnName("P031G012")
                .HasColumnOrder(112)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031G012")
                .IsOptional();

            Property(p => p.P031G013)
                .HasColumnName("P031G013")
                .HasColumnOrder(113)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031G013")
                .IsOptional();

            Property(p => p.P031G014)
                .HasColumnName("P031G014")
                .HasColumnOrder(114)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031G014")
                .IsOptional();

            Property(p => p.P031G015)
                .HasColumnName("P031G015")
                .HasColumnOrder(115)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031G015")
                .IsOptional();

            Property(p => p.P031G016)
                .HasColumnName("P031G016")
                .HasColumnOrder(116)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031G016")
                .IsOptional();

            Property(p => p.P031H001)
                .HasColumnName("P031H001")
                .HasColumnOrder(117)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031H001")
                .IsOptional();

            Property(p => p.P031H002)
                .HasColumnName("P031H002")
                .HasColumnOrder(118)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031H002")
                .IsOptional();

            Property(p => p.P031H003)
                .HasColumnName("P031H003")
                .HasColumnOrder(119)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031H003")
                .IsOptional();

            Property(p => p.P031H004)
                .HasColumnName("P031H004")
                .HasColumnOrder(120)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031H004")
                .IsOptional();

            Property(p => p.P031H005)
                .HasColumnName("P031H005")
                .HasColumnOrder(121)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031H005")
                .IsOptional();

            Property(p => p.P031H006)
                .HasColumnName("P031H006")
                .HasColumnOrder(122)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031H006")
                .IsOptional();

            Property(p => p.P031H007)
                .HasColumnName("P031H007")
                .HasColumnOrder(123)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031H007")
                .IsOptional();

            Property(p => p.P031H008)
                .HasColumnName("P031H008")
                .HasColumnOrder(124)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031H008")
                .IsOptional();

            Property(p => p.P031H009)
                .HasColumnName("P031H009")
                .HasColumnOrder(125)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031H009")
                .IsOptional();

            Property(p => p.P031H010)
                .HasColumnName("P031H010")
                .HasColumnOrder(126)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031H010")
                .IsOptional();

            Property(p => p.P031H011)
                .HasColumnName("P031H011")
                .HasColumnOrder(127)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031H011")
                .IsOptional();

            Property(p => p.P031H012)
                .HasColumnName("P031H012")
                .HasColumnOrder(128)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031H012")
                .IsOptional();

            Property(p => p.P031H013)
                .HasColumnName("P031H013")
                .HasColumnOrder(129)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031H013")
                .IsOptional();

            Property(p => p.P031H014)
                .HasColumnName("P031H014")
                .HasColumnOrder(130)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031H014")
                .IsOptional();

            Property(p => p.P031H015)
                .HasColumnName("P031H015")
                .HasColumnOrder(131)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031H015")
                .IsOptional();

            Property(p => p.P031H016)
                .HasColumnName("P031H016")
                .HasColumnOrder(132)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031H016")
                .IsOptional();

            Property(p => p.P031I001)
                .HasColumnName("P031I001")
                .HasColumnOrder(133)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031I001")
                .IsOptional();

            Property(p => p.P031I002)
                .HasColumnName("P031I002")
                .HasColumnOrder(134)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031I002")
                .IsOptional();

            Property(p => p.P031I003)
                .HasColumnName("P031I003")
                .HasColumnOrder(135)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031I003")
                .IsOptional();

            Property(p => p.P031I004)
                .HasColumnName("P031I004")
                .HasColumnOrder(136)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031I004")
                .IsOptional();

            Property(p => p.P031I005)
                .HasColumnName("P031I005")
                .HasColumnOrder(137)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031I005")
                .IsOptional();

            Property(p => p.P031I006)
                .HasColumnName("P031I006")
                .HasColumnOrder(138)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031I006")
                .IsOptional();

            Property(p => p.P031I007)
                .HasColumnName("P031I007")
                .HasColumnOrder(139)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031I007")
                .IsOptional();

            Property(p => p.P031I008)
                .HasColumnName("P031I008")
                .HasColumnOrder(140)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031I008")
                .IsOptional();

            Property(p => p.P031I009)
                .HasColumnName("P031I009")
                .HasColumnOrder(141)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031I009")
                .IsOptional();

            Property(p => p.P031I010)
                .HasColumnName("P031I010")
                .HasColumnOrder(142)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031I010")
                .IsOptional();

            Property(p => p.P031I011)
                .HasColumnName("P031I011")
                .HasColumnOrder(143)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031I011")
                .IsOptional();

            Property(p => p.P031I012)
                .HasColumnName("P031I012")
                .HasColumnOrder(144)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031I012")
                .IsOptional();

            Property(p => p.P031I013)
                .HasColumnName("P031I013")
                .HasColumnOrder(145)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031I013")
                .IsOptional();

            Property(p => p.P031I014)
                .HasColumnName("P031I014")
                .HasColumnOrder(146)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031I014")
                .IsOptional();

            Property(p => p.P031I015)
                .HasColumnName("P031I015")
                .HasColumnOrder(147)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031I015")
                .IsOptional();

            Property(p => p.P031I016)
                .HasColumnName("P031I016")
                .HasColumnOrder(148)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P031I016")
                .IsOptional();

            Property(p => p.P034A001)
                .HasColumnName("P034A001")
                .HasColumnOrder(149)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034A001")
                .IsOptional();

            Property(p => p.P034A002)
                .HasColumnName("P034A002")
                .HasColumnOrder(150)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034A002")
                .IsOptional();

            Property(p => p.P034A003)
                .HasColumnName("P034A003")
                .HasColumnOrder(151)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034A003")
                .IsOptional();

            Property(p => p.P034A004)
                .HasColumnName("P034A004")
                .HasColumnOrder(152)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034A004")
                .IsOptional();

            Property(p => p.P034A005)
                .HasColumnName("P034A005")
                .HasColumnOrder(153)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034A005")
                .IsOptional();

            Property(p => p.P034A006)
                .HasColumnName("P034A006")
                .HasColumnOrder(154)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034A006")
                .IsOptional();

            Property(p => p.P034A007)
                .HasColumnName("P034A007")
                .HasColumnOrder(155)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034A007")
                .IsOptional();

            Property(p => p.P034A008)
                .HasColumnName("P034A008")
                .HasColumnOrder(156)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034A008")
                .IsOptional();

            Property(p => p.P034A009)
                .HasColumnName("P034A009")
                .HasColumnOrder(157)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034A009")
                .IsOptional();

            Property(p => p.P034A010)
                .HasColumnName("P034A010")
                .HasColumnOrder(158)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034A010")
                .IsOptional();

            Property(p => p.P034A011)
                .HasColumnName("P034A011")
                .HasColumnOrder(159)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034A011")
                .IsOptional();

            Property(p => p.P034A012)
                .HasColumnName("P034A012")
                .HasColumnOrder(160)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034A012")
                .IsOptional();

            Property(p => p.P034A013)
                .HasColumnName("P034A013")
                .HasColumnOrder(161)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034A013")
                .IsOptional();

            Property(p => p.P034A014)
                .HasColumnName("P034A014")
                .HasColumnOrder(162)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034A014")
                .IsOptional();

            Property(p => p.P034A015)
                .HasColumnName("P034A015")
                .HasColumnOrder(163)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034A015")
                .IsOptional();

            Property(p => p.P034A016)
                .HasColumnName("P034A016")
                .HasColumnOrder(164)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034A016")
                .IsOptional();

            Property(p => p.P034A017)
                .HasColumnName("P034A017")
                .HasColumnOrder(165)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034A017")
                .IsOptional();

            Property(p => p.P034A018)
                .HasColumnName("P034A018")
                .HasColumnOrder(166)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034A018")
                .IsOptional();

            Property(p => p.P034A019)
                .HasColumnName("P034A019")
                .HasColumnOrder(167)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034A019")
                .IsOptional();

            Property(p => p.P034A020)
                .HasColumnName("P034A020")
                .HasColumnOrder(168)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034A020")
                .IsOptional();

            Property(p => p.P034A021)
                .HasColumnName("P034A021")
                .HasColumnOrder(169)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034A021")
                .IsOptional();

            Property(p => p.P034A022)
                .HasColumnName("P034A022")
                .HasColumnOrder(170)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034A022")
                .IsOptional();

            Property(p => p.P034B001)
                .HasColumnName("P034B001")
                .HasColumnOrder(171)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034B001")
                .IsOptional();

            Property(p => p.P034B002)
                .HasColumnName("P034B002")
                .HasColumnOrder(172)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034B002")
                .IsOptional();

            Property(p => p.P034B003)
                .HasColumnName("P034B003")
                .HasColumnOrder(173)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034B003")
                .IsOptional();

            Property(p => p.P034B004)
                .HasColumnName("P034B004")
                .HasColumnOrder(174)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034B004")
                .IsOptional();

            Property(p => p.P034B005)
                .HasColumnName("P034B005")
                .HasColumnOrder(175)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034B005")
                .IsOptional();

            Property(p => p.P034B006)
                .HasColumnName("P034B006")
                .HasColumnOrder(176)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034B006")
                .IsOptional();

            Property(p => p.P034B007)
                .HasColumnName("P034B007")
                .HasColumnOrder(177)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034B007")
                .IsOptional();

            Property(p => p.P034B008)
                .HasColumnName("P034B008")
                .HasColumnOrder(178)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034B008")
                .IsOptional();

            Property(p => p.P034B009)
                .HasColumnName("P034B009")
                .HasColumnOrder(179)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034B009")
                .IsOptional();

            Property(p => p.P034B010)
                .HasColumnName("P034B010")
                .HasColumnOrder(180)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034B010")
                .IsOptional();

            Property(p => p.P034B011)
                .HasColumnName("P034B011")
                .HasColumnOrder(181)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034B011")
                .IsOptional();

            Property(p => p.P034B012)
                .HasColumnName("P034B012")
                .HasColumnOrder(182)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034B012")
                .IsOptional();

            Property(p => p.P034B013)
                .HasColumnName("P034B013")
                .HasColumnOrder(183)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034B013")
                .IsOptional();

            Property(p => p.P034B014)
                .HasColumnName("P034B014")
                .HasColumnOrder(184)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034B014")
                .IsOptional();

            Property(p => p.P034B015)
                .HasColumnName("P034B015")
                .HasColumnOrder(185)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034B015")
                .IsOptional();

            Property(p => p.P034B016)
                .HasColumnName("P034B016")
                .HasColumnOrder(186)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034B016")
                .IsOptional();

            Property(p => p.P034B017)
                .HasColumnName("P034B017")
                .HasColumnOrder(187)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034B017")
                .IsOptional();

            Property(p => p.P034B018)
                .HasColumnName("P034B018")
                .HasColumnOrder(188)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034B018")
                .IsOptional();

            Property(p => p.P034B019)
                .HasColumnName("P034B019")
                .HasColumnOrder(189)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034B019")
                .IsOptional();

            Property(p => p.P034B020)
                .HasColumnName("P034B020")
                .HasColumnOrder(190)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034B020")
                .IsOptional();

            Property(p => p.P034B021)
                .HasColumnName("P034B021")
                .HasColumnOrder(191)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034B021")
                .IsOptional();

            Property(p => p.P034B022)
                .HasColumnName("P034B022")
                .HasColumnOrder(192)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034B022")
                .IsOptional();

            Property(p => p.P034C001)
                .HasColumnName("P034C001")
                .HasColumnOrder(193)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034C001")
                .IsOptional();

            Property(p => p.P034C002)
                .HasColumnName("P034C002")
                .HasColumnOrder(194)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034C002")
                .IsOptional();

            Property(p => p.P034C003)
                .HasColumnName("P034C003")
                .HasColumnOrder(195)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034C003")
                .IsOptional();

            Property(p => p.P034C004)
                .HasColumnName("P034C004")
                .HasColumnOrder(196)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034C004")
                .IsOptional();

            Property(p => p.P034C005)
                .HasColumnName("P034C005")
                .HasColumnOrder(197)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034C005")
                .IsOptional();

            Property(p => p.P034C006)
                .HasColumnName("P034C006")
                .HasColumnOrder(198)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034C006")
                .IsOptional();

            Property(p => p.P034C007)
                .HasColumnName("P034C007")
                .HasColumnOrder(199)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034C007")
                .IsOptional();

            Property(p => p.P034C008)
                .HasColumnName("P034C008")
                .HasColumnOrder(200)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034C008")
                .IsOptional();

            Property(p => p.P034C009)
                .HasColumnName("P034C009")
                .HasColumnOrder(201)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034C009")
                .IsOptional();

            Property(p => p.P034C010)
                .HasColumnName("P034C010")
                .HasColumnOrder(202)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034C010")
                .IsOptional();

            Property(p => p.P034C011)
                .HasColumnName("P034C011")
                .HasColumnOrder(203)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034C011")
                .IsOptional();

            Property(p => p.P034C012)
                .HasColumnName("P034C012")
                .HasColumnOrder(204)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034C012")
                .IsOptional();

            Property(p => p.P034C013)
                .HasColumnName("P034C013")
                .HasColumnOrder(205)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034C013")
                .IsOptional();

            Property(p => p.P034C014)
                .HasColumnName("P034C014")
                .HasColumnOrder(206)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034C014")
                .IsOptional();

            Property(p => p.P034C015)
                .HasColumnName("P034C015")
                .HasColumnOrder(207)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034C015")
                .IsOptional();

            Property(p => p.P034C016)
                .HasColumnName("P034C016")
                .HasColumnOrder(208)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034C016")
                .IsOptional();

            Property(p => p.P034C017)
                .HasColumnName("P034C017")
                .HasColumnOrder(209)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034C017")
                .IsOptional();

            Property(p => p.P034C018)
                .HasColumnName("P034C018")
                .HasColumnOrder(210)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034C018")
                .IsOptional();

            Property(p => p.P034C019)
                .HasColumnName("P034C019")
                .HasColumnOrder(211)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034C019")
                .IsOptional();

            Property(p => p.P034C020)
                .HasColumnName("P034C020")
                .HasColumnOrder(212)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034C020")
                .IsOptional();

            Property(p => p.P034C021)
                .HasColumnName("P034C021")
                .HasColumnOrder(213)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034C021")
                .IsOptional();

            Property(p => p.P034C022)
                .HasColumnName("P034C022")
                .HasColumnOrder(214)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034C022")
                .IsOptional();

            Property(p => p.P034D001)
                .HasColumnName("P034D001")
                .HasColumnOrder(215)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034D001")
                .IsOptional();

            Property(p => p.P034D002)
                .HasColumnName("P034D002")
                .HasColumnOrder(216)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034D002")
                .IsOptional();

            Property(p => p.P034D003)
                .HasColumnName("P034D003")
                .HasColumnOrder(217)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034D003")
                .IsOptional();

            Property(p => p.P034D004)
                .HasColumnName("P034D004")
                .HasColumnOrder(218)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034D004")
                .IsOptional();

            Property(p => p.P034D005)
                .HasColumnName("P034D005")
                .HasColumnOrder(219)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034D005")
                .IsOptional();

            Property(p => p.P034D006)
                .HasColumnName("P034D006")
                .HasColumnOrder(220)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034D006")
                .IsOptional();

            Property(p => p.P034D007)
                .HasColumnName("P034D007")
                .HasColumnOrder(221)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034D007")
                .IsOptional();

            Property(p => p.P034D008)
                .HasColumnName("P034D008")
                .HasColumnOrder(222)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034D008")
                .IsOptional();

            Property(p => p.P034D009)
                .HasColumnName("P034D009")
                .HasColumnOrder(223)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034D009")
                .IsOptional();

            Property(p => p.P034D010)
                .HasColumnName("P034D010")
                .HasColumnOrder(224)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034D010")
                .IsOptional();

            Property(p => p.P034D011)
                .HasColumnName("P034D011")
                .HasColumnOrder(225)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034D011")
                .IsOptional();

            Property(p => p.P034D012)
                .HasColumnName("P034D012")
                .HasColumnOrder(226)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034D012")
                .IsOptional();

            Property(p => p.P034D013)
                .HasColumnName("P034D013")
                .HasColumnOrder(227)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034D013")
                .IsOptional();

            Property(p => p.P034D014)
                .HasColumnName("P034D014")
                .HasColumnOrder(228)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034D014")
                .IsOptional();

            Property(p => p.P034D015)
                .HasColumnName("P034D015")
                .HasColumnOrder(229)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034D015")
                .IsOptional();

            Property(p => p.P034D016)
                .HasColumnName("P034D016")
                .HasColumnOrder(230)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034D016")
                .IsOptional();

            Property(p => p.P034D017)
                .HasColumnName("P034D017")
                .HasColumnOrder(231)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034D017")
                .IsOptional();

            Property(p => p.P034D018)
                .HasColumnName("P034D018")
                .HasColumnOrder(232)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034D018")
                .IsOptional();

            Property(p => p.P034D019)
                .HasColumnName("P034D019")
                .HasColumnOrder(233)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034D019")
                .IsOptional();

            Property(p => p.P034D020)
                .HasColumnName("P034D020")
                .HasColumnOrder(234)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034D020")
                .IsOptional();

            Property(p => p.P034D021)
                .HasColumnName("P034D021")
                .HasColumnOrder(235)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034D021")
                .IsOptional();

            Property(p => p.P034D022)
                .HasColumnName("P034D022")
                .HasColumnOrder(236)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034D022")
                .IsOptional();

            Property(p => p.P034E001)
                .HasColumnName("P034E001")
                .HasColumnOrder(237)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034E001")
                .IsOptional();

            Property(p => p.P034E002)
                .HasColumnName("P034E002")
                .HasColumnOrder(238)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034E002")
                .IsOptional();

            Property(p => p.P034E003)
                .HasColumnName("P034E003")
                .HasColumnOrder(239)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034E003")
                .IsOptional();

            Property(p => p.P034E004)
                .HasColumnName("P034E004")
                .HasColumnOrder(240)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034E004")
                .IsOptional();

            Property(p => p.P034E005)
                .HasColumnName("P034E005")
                .HasColumnOrder(241)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034E005")
                .IsOptional();

            Property(p => p.P034E006)
                .HasColumnName("P034E006")
                .HasColumnOrder(242)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034E006")
                .IsOptional();

            Property(p => p.P034E007)
                .HasColumnName("P034E007")
                .HasColumnOrder(243)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034E007")
                .IsOptional();

            Property(p => p.P034E008)
                .HasColumnName("P034E008")
                .HasColumnOrder(244)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034E008")
                .IsOptional();

            Property(p => p.P034E009)
                .HasColumnName("P034E009")
                .HasColumnOrder(245)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034E009")
                .IsOptional();

            Property(p => p.P034E010)
                .HasColumnName("P034E010")
                .HasColumnOrder(246)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034E010")
                .IsOptional();

            Property(p => p.P034E011)
                .HasColumnName("P034E011")
                .HasColumnOrder(247)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034E011")
                .IsOptional();

            Property(p => p.P034E012)
                .HasColumnName("P034E012")
                .HasColumnOrder(248)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034E012")
                .IsOptional();

            Property(p => p.P034E013)
                .HasColumnName("P034E013")
                .HasColumnOrder(249)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034E013")
                .IsOptional();

            Property(p => p.P034E014)
                .HasColumnName("P034E014")
                .HasColumnOrder(250)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034E014")
                .IsOptional();

            Property(p => p.P034E015)
                .HasColumnName("P034E015")
                .HasColumnOrder(251)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034E015")
                .IsOptional();

            Property(p => p.P034E016)
                .HasColumnName("P034E016")
                .HasColumnOrder(252)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034E016")
                .IsOptional();

            Property(p => p.P034E017)
                .HasColumnName("P034E017")
                .HasColumnOrder(253)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034E017")
                .IsOptional();

            Property(p => p.P034E018)
                .HasColumnName("P034E018")
                .HasColumnOrder(254)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034E018")
                .IsOptional();

            Property(p => p.P034E019)
                .HasColumnName("P034E019")
                .HasColumnOrder(255)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034E019")
                .IsOptional();

            Property(p => p.P034E020)
                .HasColumnName("P034E020")
                .HasColumnOrder(256)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034E020")
                .IsOptional();

            Property(p => p.P034E021)
                .HasColumnName("P034E021")
                .HasColumnOrder(257)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034E021")
                .IsOptional();

            Property(p => p.P034E022)
                .HasColumnName("P034E022")
                .HasColumnOrder(258)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P034E022")
                .IsOptional();
        }
    }
}
