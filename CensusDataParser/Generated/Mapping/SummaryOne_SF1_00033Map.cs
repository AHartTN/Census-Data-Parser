#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2016 12:27 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SummaryOne_SF1_00033Map.cs
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

    public class SummaryOne_SF1_00033Map : EntityTypeConfiguration<SummaryOne_SF1_00033>
    {
        public SummaryOne_SF1_00033Map()
        {
            ToTable("SF1_00033", "SummaryOne");

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

            Property(p => p.PCT012N001)
                .HasColumnName("PCT012N001")
                .HasColumnOrder(5)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N001")
                .IsOptional();

            Property(p => p.PCT012N002)
                .HasColumnName("PCT012N002")
                .HasColumnOrder(6)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N002")
                .IsOptional();

            Property(p => p.PCT012N003)
                .HasColumnName("PCT012N003")
                .HasColumnOrder(7)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N003")
                .IsOptional();

            Property(p => p.PCT012N004)
                .HasColumnName("PCT012N004")
                .HasColumnOrder(8)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N004")
                .IsOptional();

            Property(p => p.PCT012N005)
                .HasColumnName("PCT012N005")
                .HasColumnOrder(9)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N005")
                .IsOptional();

            Property(p => p.PCT012N006)
                .HasColumnName("PCT012N006")
                .HasColumnOrder(10)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N006")
                .IsOptional();

            Property(p => p.PCT012N007)
                .HasColumnName("PCT012N007")
                .HasColumnOrder(11)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N007")
                .IsOptional();

            Property(p => p.PCT012N008)
                .HasColumnName("PCT012N008")
                .HasColumnOrder(12)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N008")
                .IsOptional();

            Property(p => p.PCT012N009)
                .HasColumnName("PCT012N009")
                .HasColumnOrder(13)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N009")
                .IsOptional();

            Property(p => p.PCT012N010)
                .HasColumnName("PCT012N010")
                .HasColumnOrder(14)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N010")
                .IsOptional();

            Property(p => p.PCT012N011)
                .HasColumnName("PCT012N011")
                .HasColumnOrder(15)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N011")
                .IsOptional();

            Property(p => p.PCT012N012)
                .HasColumnName("PCT012N012")
                .HasColumnOrder(16)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N012")
                .IsOptional();

            Property(p => p.PCT012N013)
                .HasColumnName("PCT012N013")
                .HasColumnOrder(17)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N013")
                .IsOptional();

            Property(p => p.PCT012N014)
                .HasColumnName("PCT012N014")
                .HasColumnOrder(18)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N014")
                .IsOptional();

            Property(p => p.PCT012N015)
                .HasColumnName("PCT012N015")
                .HasColumnOrder(19)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N015")
                .IsOptional();

            Property(p => p.PCT012N016)
                .HasColumnName("PCT012N016")
                .HasColumnOrder(20)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N016")
                .IsOptional();

            Property(p => p.PCT012N017)
                .HasColumnName("PCT012N017")
                .HasColumnOrder(21)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N017")
                .IsOptional();

            Property(p => p.PCT012N018)
                .HasColumnName("PCT012N018")
                .HasColumnOrder(22)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N018")
                .IsOptional();

            Property(p => p.PCT012N019)
                .HasColumnName("PCT012N019")
                .HasColumnOrder(23)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N019")
                .IsOptional();

            Property(p => p.PCT012N020)
                .HasColumnName("PCT012N020")
                .HasColumnOrder(24)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N020")
                .IsOptional();

            Property(p => p.PCT012N021)
                .HasColumnName("PCT012N021")
                .HasColumnOrder(25)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N021")
                .IsOptional();

            Property(p => p.PCT012N022)
                .HasColumnName("PCT012N022")
                .HasColumnOrder(26)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N022")
                .IsOptional();

            Property(p => p.PCT012N023)
                .HasColumnName("PCT012N023")
                .HasColumnOrder(27)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N023")
                .IsOptional();

            Property(p => p.PCT012N024)
                .HasColumnName("PCT012N024")
                .HasColumnOrder(28)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N024")
                .IsOptional();

            Property(p => p.PCT012N025)
                .HasColumnName("PCT012N025")
                .HasColumnOrder(29)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N025")
                .IsOptional();

            Property(p => p.PCT012N026)
                .HasColumnName("PCT012N026")
                .HasColumnOrder(30)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N026")
                .IsOptional();

            Property(p => p.PCT012N027)
                .HasColumnName("PCT012N027")
                .HasColumnOrder(31)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N027")
                .IsOptional();

            Property(p => p.PCT012N028)
                .HasColumnName("PCT012N028")
                .HasColumnOrder(32)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N028")
                .IsOptional();

            Property(p => p.PCT012N029)
                .HasColumnName("PCT012N029")
                .HasColumnOrder(33)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N029")
                .IsOptional();

            Property(p => p.PCT012N030)
                .HasColumnName("PCT012N030")
                .HasColumnOrder(34)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N030")
                .IsOptional();

            Property(p => p.PCT012N031)
                .HasColumnName("PCT012N031")
                .HasColumnOrder(35)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N031")
                .IsOptional();

            Property(p => p.PCT012N032)
                .HasColumnName("PCT012N032")
                .HasColumnOrder(36)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N032")
                .IsOptional();

            Property(p => p.PCT012N033)
                .HasColumnName("PCT012N033")
                .HasColumnOrder(37)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N033")
                .IsOptional();

            Property(p => p.PCT012N034)
                .HasColumnName("PCT012N034")
                .HasColumnOrder(38)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N034")
                .IsOptional();

            Property(p => p.PCT012N035)
                .HasColumnName("PCT012N035")
                .HasColumnOrder(39)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N035")
                .IsOptional();

            Property(p => p.PCT012N036)
                .HasColumnName("PCT012N036")
                .HasColumnOrder(40)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N036")
                .IsOptional();

            Property(p => p.PCT012N037)
                .HasColumnName("PCT012N037")
                .HasColumnOrder(41)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N037")
                .IsOptional();

            Property(p => p.PCT012N038)
                .HasColumnName("PCT012N038")
                .HasColumnOrder(42)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N038")
                .IsOptional();

            Property(p => p.PCT012N039)
                .HasColumnName("PCT012N039")
                .HasColumnOrder(43)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N039")
                .IsOptional();

            Property(p => p.PCT012N040)
                .HasColumnName("PCT012N040")
                .HasColumnOrder(44)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N040")
                .IsOptional();

            Property(p => p.PCT012N041)
                .HasColumnName("PCT012N041")
                .HasColumnOrder(45)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N041")
                .IsOptional();

            Property(p => p.PCT012N042)
                .HasColumnName("PCT012N042")
                .HasColumnOrder(46)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N042")
                .IsOptional();

            Property(p => p.PCT012N043)
                .HasColumnName("PCT012N043")
                .HasColumnOrder(47)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N043")
                .IsOptional();

            Property(p => p.PCT012N044)
                .HasColumnName("PCT012N044")
                .HasColumnOrder(48)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N044")
                .IsOptional();

            Property(p => p.PCT012N045)
                .HasColumnName("PCT012N045")
                .HasColumnOrder(49)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N045")
                .IsOptional();

            Property(p => p.PCT012N046)
                .HasColumnName("PCT012N046")
                .HasColumnOrder(50)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N046")
                .IsOptional();

            Property(p => p.PCT012N047)
                .HasColumnName("PCT012N047")
                .HasColumnOrder(51)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N047")
                .IsOptional();

            Property(p => p.PCT012N048)
                .HasColumnName("PCT012N048")
                .HasColumnOrder(52)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N048")
                .IsOptional();

            Property(p => p.PCT012N049)
                .HasColumnName("PCT012N049")
                .HasColumnOrder(53)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N049")
                .IsOptional();

            Property(p => p.PCT012N050)
                .HasColumnName("PCT012N050")
                .HasColumnOrder(54)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N050")
                .IsOptional();

            Property(p => p.PCT012N051)
                .HasColumnName("PCT012N051")
                .HasColumnOrder(55)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N051")
                .IsOptional();

            Property(p => p.PCT012N052)
                .HasColumnName("PCT012N052")
                .HasColumnOrder(56)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N052")
                .IsOptional();

            Property(p => p.PCT012N053)
                .HasColumnName("PCT012N053")
                .HasColumnOrder(57)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N053")
                .IsOptional();

            Property(p => p.PCT012N054)
                .HasColumnName("PCT012N054")
                .HasColumnOrder(58)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N054")
                .IsOptional();

            Property(p => p.PCT012N055)
                .HasColumnName("PCT012N055")
                .HasColumnOrder(59)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N055")
                .IsOptional();

            Property(p => p.PCT012N056)
                .HasColumnName("PCT012N056")
                .HasColumnOrder(60)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N056")
                .IsOptional();

            Property(p => p.PCT012N057)
                .HasColumnName("PCT012N057")
                .HasColumnOrder(61)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N057")
                .IsOptional();

            Property(p => p.PCT012N058)
                .HasColumnName("PCT012N058")
                .HasColumnOrder(62)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N058")
                .IsOptional();

            Property(p => p.PCT012N059)
                .HasColumnName("PCT012N059")
                .HasColumnOrder(63)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N059")
                .IsOptional();

            Property(p => p.PCT012N060)
                .HasColumnName("PCT012N060")
                .HasColumnOrder(64)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N060")
                .IsOptional();

            Property(p => p.PCT012N061)
                .HasColumnName("PCT012N061")
                .HasColumnOrder(65)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N061")
                .IsOptional();

            Property(p => p.PCT012N062)
                .HasColumnName("PCT012N062")
                .HasColumnOrder(66)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N062")
                .IsOptional();

            Property(p => p.PCT012N063)
                .HasColumnName("PCT012N063")
                .HasColumnOrder(67)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N063")
                .IsOptional();

            Property(p => p.PCT012N064)
                .HasColumnName("PCT012N064")
                .HasColumnOrder(68)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N064")
                .IsOptional();

            Property(p => p.PCT012N065)
                .HasColumnName("PCT012N065")
                .HasColumnOrder(69)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N065")
                .IsOptional();

            Property(p => p.PCT012N066)
                .HasColumnName("PCT012N066")
                .HasColumnOrder(70)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N066")
                .IsOptional();

            Property(p => p.PCT012N067)
                .HasColumnName("PCT012N067")
                .HasColumnOrder(71)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N067")
                .IsOptional();

            Property(p => p.PCT012N068)
                .HasColumnName("PCT012N068")
                .HasColumnOrder(72)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N068")
                .IsOptional();

            Property(p => p.PCT012N069)
                .HasColumnName("PCT012N069")
                .HasColumnOrder(73)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N069")
                .IsOptional();

            Property(p => p.PCT012N070)
                .HasColumnName("PCT012N070")
                .HasColumnOrder(74)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N070")
                .IsOptional();

            Property(p => p.PCT012N071)
                .HasColumnName("PCT012N071")
                .HasColumnOrder(75)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N071")
                .IsOptional();

            Property(p => p.PCT012N072)
                .HasColumnName("PCT012N072")
                .HasColumnOrder(76)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N072")
                .IsOptional();

            Property(p => p.PCT012N073)
                .HasColumnName("PCT012N073")
                .HasColumnOrder(77)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N073")
                .IsOptional();

            Property(p => p.PCT012N074)
                .HasColumnName("PCT012N074")
                .HasColumnOrder(78)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N074")
                .IsOptional();

            Property(p => p.PCT012N075)
                .HasColumnName("PCT012N075")
                .HasColumnOrder(79)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N075")
                .IsOptional();

            Property(p => p.PCT012N076)
                .HasColumnName("PCT012N076")
                .HasColumnOrder(80)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N076")
                .IsOptional();

            Property(p => p.PCT012N077)
                .HasColumnName("PCT012N077")
                .HasColumnOrder(81)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N077")
                .IsOptional();

            Property(p => p.PCT012N078)
                .HasColumnName("PCT012N078")
                .HasColumnOrder(82)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N078")
                .IsOptional();

            Property(p => p.PCT012N079)
                .HasColumnName("PCT012N079")
                .HasColumnOrder(83)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N079")
                .IsOptional();

            Property(p => p.PCT012N080)
                .HasColumnName("PCT012N080")
                .HasColumnOrder(84)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N080")
                .IsOptional();

            Property(p => p.PCT012N081)
                .HasColumnName("PCT012N081")
                .HasColumnOrder(85)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N081")
                .IsOptional();

            Property(p => p.PCT012N082)
                .HasColumnName("PCT012N082")
                .HasColumnOrder(86)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N082")
                .IsOptional();

            Property(p => p.PCT012N083)
                .HasColumnName("PCT012N083")
                .HasColumnOrder(87)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N083")
                .IsOptional();

            Property(p => p.PCT012N084)
                .HasColumnName("PCT012N084")
                .HasColumnOrder(88)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N084")
                .IsOptional();

            Property(p => p.PCT012N085)
                .HasColumnName("PCT012N085")
                .HasColumnOrder(89)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N085")
                .IsOptional();

            Property(p => p.PCT012N086)
                .HasColumnName("PCT012N086")
                .HasColumnOrder(90)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N086")
                .IsOptional();

            Property(p => p.PCT012N087)
                .HasColumnName("PCT012N087")
                .HasColumnOrder(91)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N087")
                .IsOptional();

            Property(p => p.PCT012N088)
                .HasColumnName("PCT012N088")
                .HasColumnOrder(92)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N088")
                .IsOptional();

            Property(p => p.PCT012N089)
                .HasColumnName("PCT012N089")
                .HasColumnOrder(93)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N089")
                .IsOptional();

            Property(p => p.PCT012N090)
                .HasColumnName("PCT012N090")
                .HasColumnOrder(94)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N090")
                .IsOptional();

            Property(p => p.PCT012N091)
                .HasColumnName("PCT012N091")
                .HasColumnOrder(95)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N091")
                .IsOptional();

            Property(p => p.PCT012N092)
                .HasColumnName("PCT012N092")
                .HasColumnOrder(96)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N092")
                .IsOptional();

            Property(p => p.PCT012N093)
                .HasColumnName("PCT012N093")
                .HasColumnOrder(97)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N093")
                .IsOptional();

            Property(p => p.PCT012N094)
                .HasColumnName("PCT012N094")
                .HasColumnOrder(98)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N094")
                .IsOptional();

            Property(p => p.PCT012N095)
                .HasColumnName("PCT012N095")
                .HasColumnOrder(99)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N095")
                .IsOptional();

            Property(p => p.PCT012N096)
                .HasColumnName("PCT012N096")
                .HasColumnOrder(100)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N096")
                .IsOptional();

            Property(p => p.PCT012N097)
                .HasColumnName("PCT012N097")
                .HasColumnOrder(101)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N097")
                .IsOptional();

            Property(p => p.PCT012N098)
                .HasColumnName("PCT012N098")
                .HasColumnOrder(102)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N098")
                .IsOptional();

            Property(p => p.PCT012N099)
                .HasColumnName("PCT012N099")
                .HasColumnOrder(103)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N099")
                .IsOptional();

            Property(p => p.PCT012N100)
                .HasColumnName("PCT012N100")
                .HasColumnOrder(104)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N100")
                .IsOptional();

            Property(p => p.PCT012N101)
                .HasColumnName("PCT012N101")
                .HasColumnOrder(105)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N101")
                .IsOptional();

            Property(p => p.PCT012N102)
                .HasColumnName("PCT012N102")
                .HasColumnOrder(106)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N102")
                .IsOptional();

            Property(p => p.PCT012N103)
                .HasColumnName("PCT012N103")
                .HasColumnOrder(107)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N103")
                .IsOptional();

            Property(p => p.PCT012N104)
                .HasColumnName("PCT012N104")
                .HasColumnOrder(108)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N104")
                .IsOptional();

            Property(p => p.PCT012N105)
                .HasColumnName("PCT012N105")
                .HasColumnOrder(109)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N105")
                .IsOptional();

            Property(p => p.PCT012N106)
                .HasColumnName("PCT012N106")
                .HasColumnOrder(110)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N106")
                .IsOptional();

            Property(p => p.PCT012N107)
                .HasColumnName("PCT012N107")
                .HasColumnOrder(111)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N107")
                .IsOptional();

            Property(p => p.PCT012N108)
                .HasColumnName("PCT012N108")
                .HasColumnOrder(112)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N108")
                .IsOptional();

            Property(p => p.PCT012N109)
                .HasColumnName("PCT012N109")
                .HasColumnOrder(113)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N109")
                .IsOptional();

            Property(p => p.PCT012N110)
                .HasColumnName("PCT012N110")
                .HasColumnOrder(114)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N110")
                .IsOptional();

            Property(p => p.PCT012N111)
                .HasColumnName("PCT012N111")
                .HasColumnOrder(115)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N111")
                .IsOptional();

            Property(p => p.PCT012N112)
                .HasColumnName("PCT012N112")
                .HasColumnOrder(116)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N112")
                .IsOptional();

            Property(p => p.PCT012N113)
                .HasColumnName("PCT012N113")
                .HasColumnOrder(117)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N113")
                .IsOptional();

            Property(p => p.PCT012N114)
                .HasColumnName("PCT012N114")
                .HasColumnOrder(118)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N114")
                .IsOptional();

            Property(p => p.PCT012N115)
                .HasColumnName("PCT012N115")
                .HasColumnOrder(119)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N115")
                .IsOptional();

            Property(p => p.PCT012N116)
                .HasColumnName("PCT012N116")
                .HasColumnOrder(120)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N116")
                .IsOptional();

            Property(p => p.PCT012N117)
                .HasColumnName("PCT012N117")
                .HasColumnOrder(121)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N117")
                .IsOptional();

            Property(p => p.PCT012N118)
                .HasColumnName("PCT012N118")
                .HasColumnOrder(122)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N118")
                .IsOptional();

            Property(p => p.PCT012N119)
                .HasColumnName("PCT012N119")
                .HasColumnOrder(123)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N119")
                .IsOptional();

            Property(p => p.PCT012N120)
                .HasColumnName("PCT012N120")
                .HasColumnOrder(124)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N120")
                .IsOptional();

            Property(p => p.PCT012N121)
                .HasColumnName("PCT012N121")
                .HasColumnOrder(125)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N121")
                .IsOptional();

            Property(p => p.PCT012N122)
                .HasColumnName("PCT012N122")
                .HasColumnOrder(126)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N122")
                .IsOptional();

            Property(p => p.PCT012N123)
                .HasColumnName("PCT012N123")
                .HasColumnOrder(127)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N123")
                .IsOptional();

            Property(p => p.PCT012N124)
                .HasColumnName("PCT012N124")
                .HasColumnOrder(128)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N124")
                .IsOptional();

            Property(p => p.PCT012N125)
                .HasColumnName("PCT012N125")
                .HasColumnOrder(129)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N125")
                .IsOptional();

            Property(p => p.PCT012N126)
                .HasColumnName("PCT012N126")
                .HasColumnOrder(130)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N126")
                .IsOptional();

            Property(p => p.PCT012N127)
                .HasColumnName("PCT012N127")
                .HasColumnOrder(131)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N127")
                .IsOptional();

            Property(p => p.PCT012N128)
                .HasColumnName("PCT012N128")
                .HasColumnOrder(132)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N128")
                .IsOptional();

            Property(p => p.PCT012N129)
                .HasColumnName("PCT012N129")
                .HasColumnOrder(133)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N129")
                .IsOptional();

            Property(p => p.PCT012N130)
                .HasColumnName("PCT012N130")
                .HasColumnOrder(134)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N130")
                .IsOptional();

            Property(p => p.PCT012N131)
                .HasColumnName("PCT012N131")
                .HasColumnOrder(135)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N131")
                .IsOptional();

            Property(p => p.PCT012N132)
                .HasColumnName("PCT012N132")
                .HasColumnOrder(136)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N132")
                .IsOptional();

            Property(p => p.PCT012N133)
                .HasColumnName("PCT012N133")
                .HasColumnOrder(137)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N133")
                .IsOptional();

            Property(p => p.PCT012N134)
                .HasColumnName("PCT012N134")
                .HasColumnOrder(138)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N134")
                .IsOptional();

            Property(p => p.PCT012N135)
                .HasColumnName("PCT012N135")
                .HasColumnOrder(139)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N135")
                .IsOptional();

            Property(p => p.PCT012N136)
                .HasColumnName("PCT012N136")
                .HasColumnOrder(140)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N136")
                .IsOptional();

            Property(p => p.PCT012N137)
                .HasColumnName("PCT012N137")
                .HasColumnOrder(141)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N137")
                .IsOptional();

            Property(p => p.PCT012N138)
                .HasColumnName("PCT012N138")
                .HasColumnOrder(142)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N138")
                .IsOptional();

            Property(p => p.PCT012N139)
                .HasColumnName("PCT012N139")
                .HasColumnOrder(143)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N139")
                .IsOptional();

            Property(p => p.PCT012N140)
                .HasColumnName("PCT012N140")
                .HasColumnOrder(144)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N140")
                .IsOptional();

            Property(p => p.PCT012N141)
                .HasColumnName("PCT012N141")
                .HasColumnOrder(145)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N141")
                .IsOptional();

            Property(p => p.PCT012N142)
                .HasColumnName("PCT012N142")
                .HasColumnOrder(146)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N142")
                .IsOptional();

            Property(p => p.PCT012N143)
                .HasColumnName("PCT012N143")
                .HasColumnOrder(147)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N143")
                .IsOptional();

            Property(p => p.PCT012N144)
                .HasColumnName("PCT012N144")
                .HasColumnOrder(148)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N144")
                .IsOptional();

            Property(p => p.PCT012N145)
                .HasColumnName("PCT012N145")
                .HasColumnOrder(149)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N145")
                .IsOptional();

            Property(p => p.PCT012N146)
                .HasColumnName("PCT012N146")
                .HasColumnOrder(150)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N146")
                .IsOptional();

            Property(p => p.PCT012N147)
                .HasColumnName("PCT012N147")
                .HasColumnOrder(151)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N147")
                .IsOptional();

            Property(p => p.PCT012N148)
                .HasColumnName("PCT012N148")
                .HasColumnOrder(152)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N148")
                .IsOptional();

            Property(p => p.PCT012N149)
                .HasColumnName("PCT012N149")
                .HasColumnOrder(153)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N149")
                .IsOptional();

            Property(p => p.PCT012N150)
                .HasColumnName("PCT012N150")
                .HasColumnOrder(154)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N150")
                .IsOptional();

            Property(p => p.PCT012N151)
                .HasColumnName("PCT012N151")
                .HasColumnOrder(155)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N151")
                .IsOptional();

            Property(p => p.PCT012N152)
                .HasColumnName("PCT012N152")
                .HasColumnOrder(156)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N152")
                .IsOptional();

            Property(p => p.PCT012N153)
                .HasColumnName("PCT012N153")
                .HasColumnOrder(157)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N153")
                .IsOptional();

            Property(p => p.PCT012N154)
                .HasColumnName("PCT012N154")
                .HasColumnOrder(158)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N154")
                .IsOptional();

            Property(p => p.PCT012N155)
                .HasColumnName("PCT012N155")
                .HasColumnOrder(159)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N155")
                .IsOptional();

            Property(p => p.PCT012N156)
                .HasColumnName("PCT012N156")
                .HasColumnOrder(160)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N156")
                .IsOptional();

            Property(p => p.PCT012N157)
                .HasColumnName("PCT012N157")
                .HasColumnOrder(161)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N157")
                .IsOptional();

            Property(p => p.PCT012N158)
                .HasColumnName("PCT012N158")
                .HasColumnOrder(162)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N158")
                .IsOptional();

            Property(p => p.PCT012N159)
                .HasColumnName("PCT012N159")
                .HasColumnOrder(163)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N159")
                .IsOptional();

            Property(p => p.PCT012N160)
                .HasColumnName("PCT012N160")
                .HasColumnOrder(164)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N160")
                .IsOptional();

            Property(p => p.PCT012N161)
                .HasColumnName("PCT012N161")
                .HasColumnOrder(165)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N161")
                .IsOptional();

            Property(p => p.PCT012N162)
                .HasColumnName("PCT012N162")
                .HasColumnOrder(166)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N162")
                .IsOptional();

            Property(p => p.PCT012N163)
                .HasColumnName("PCT012N163")
                .HasColumnOrder(167)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N163")
                .IsOptional();

            Property(p => p.PCT012N164)
                .HasColumnName("PCT012N164")
                .HasColumnOrder(168)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N164")
                .IsOptional();

            Property(p => p.PCT012N165)
                .HasColumnName("PCT012N165")
                .HasColumnOrder(169)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N165")
                .IsOptional();

            Property(p => p.PCT012N166)
                .HasColumnName("PCT012N166")
                .HasColumnOrder(170)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N166")
                .IsOptional();

            Property(p => p.PCT012N167)
                .HasColumnName("PCT012N167")
                .HasColumnOrder(171)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N167")
                .IsOptional();

            Property(p => p.PCT012N168)
                .HasColumnName("PCT012N168")
                .HasColumnOrder(172)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N168")
                .IsOptional();

            Property(p => p.PCT012N169)
                .HasColumnName("PCT012N169")
                .HasColumnOrder(173)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N169")
                .IsOptional();

            Property(p => p.PCT012N170)
                .HasColumnName("PCT012N170")
                .HasColumnOrder(174)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N170")
                .IsOptional();

            Property(p => p.PCT012N171)
                .HasColumnName("PCT012N171")
                .HasColumnOrder(175)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N171")
                .IsOptional();

            Property(p => p.PCT012N172)
                .HasColumnName("PCT012N172")
                .HasColumnOrder(176)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N172")
                .IsOptional();

            Property(p => p.PCT012N173)
                .HasColumnName("PCT012N173")
                .HasColumnOrder(177)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N173")
                .IsOptional();

            Property(p => p.PCT012N174)
                .HasColumnName("PCT012N174")
                .HasColumnOrder(178)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N174")
                .IsOptional();

            Property(p => p.PCT012N175)
                .HasColumnName("PCT012N175")
                .HasColumnOrder(179)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N175")
                .IsOptional();

            Property(p => p.PCT012N176)
                .HasColumnName("PCT012N176")
                .HasColumnOrder(180)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N176")
                .IsOptional();

            Property(p => p.PCT012N177)
                .HasColumnName("PCT012N177")
                .HasColumnOrder(181)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N177")
                .IsOptional();

            Property(p => p.PCT012N178)
                .HasColumnName("PCT012N178")
                .HasColumnOrder(182)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N178")
                .IsOptional();

            Property(p => p.PCT012N179)
                .HasColumnName("PCT012N179")
                .HasColumnOrder(183)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N179")
                .IsOptional();

            Property(p => p.PCT012N180)
                .HasColumnName("PCT012N180")
                .HasColumnOrder(184)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N180")
                .IsOptional();

            Property(p => p.PCT012N181)
                .HasColumnName("PCT012N181")
                .HasColumnOrder(185)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N181")
                .IsOptional();

            Property(p => p.PCT012N182)
                .HasColumnName("PCT012N182")
                .HasColumnOrder(186)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N182")
                .IsOptional();

            Property(p => p.PCT012N183)
                .HasColumnName("PCT012N183")
                .HasColumnOrder(187)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N183")
                .IsOptional();

            Property(p => p.PCT012N184)
                .HasColumnName("PCT012N184")
                .HasColumnOrder(188)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N184")
                .IsOptional();

            Property(p => p.PCT012N185)
                .HasColumnName("PCT012N185")
                .HasColumnOrder(189)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N185")
                .IsOptional();

            Property(p => p.PCT012N186)
                .HasColumnName("PCT012N186")
                .HasColumnOrder(190)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N186")
                .IsOptional();

            Property(p => p.PCT012N187)
                .HasColumnName("PCT012N187")
                .HasColumnOrder(191)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N187")
                .IsOptional();

            Property(p => p.PCT012N188)
                .HasColumnName("PCT012N188")
                .HasColumnOrder(192)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N188")
                .IsOptional();

            Property(p => p.PCT012N189)
                .HasColumnName("PCT012N189")
                .HasColumnOrder(193)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N189")
                .IsOptional();

            Property(p => p.PCT012N190)
                .HasColumnName("PCT012N190")
                .HasColumnOrder(194)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N190")
                .IsOptional();

            Property(p => p.PCT012N191)
                .HasColumnName("PCT012N191")
                .HasColumnOrder(195)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N191")
                .IsOptional();

            Property(p => p.PCT012N192)
                .HasColumnName("PCT012N192")
                .HasColumnOrder(196)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N192")
                .IsOptional();

            Property(p => p.PCT012N193)
                .HasColumnName("PCT012N193")
                .HasColumnOrder(197)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N193")
                .IsOptional();

            Property(p => p.PCT012N194)
                .HasColumnName("PCT012N194")
                .HasColumnOrder(198)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N194")
                .IsOptional();

            Property(p => p.PCT012N195)
                .HasColumnName("PCT012N195")
                .HasColumnOrder(199)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N195")
                .IsOptional();

            Property(p => p.PCT012N196)
                .HasColumnName("PCT012N196")
                .HasColumnOrder(200)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N196")
                .IsOptional();

            Property(p => p.PCT012N197)
                .HasColumnName("PCT012N197")
                .HasColumnOrder(201)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N197")
                .IsOptional();

            Property(p => p.PCT012N198)
                .HasColumnName("PCT012N198")
                .HasColumnOrder(202)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N198")
                .IsOptional();

            Property(p => p.PCT012N199)
                .HasColumnName("PCT012N199")
                .HasColumnOrder(203)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N199")
                .IsOptional();

            Property(p => p.PCT012N200)
                .HasColumnName("PCT012N200")
                .HasColumnOrder(204)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N200")
                .IsOptional();

            Property(p => p.PCT012N201)
                .HasColumnName("PCT012N201")
                .HasColumnOrder(205)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N201")
                .IsOptional();

            Property(p => p.PCT012N202)
                .HasColumnName("PCT012N202")
                .HasColumnOrder(206)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N202")
                .IsOptional();

            Property(p => p.PCT012N203)
                .HasColumnName("PCT012N203")
                .HasColumnOrder(207)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N203")
                .IsOptional();

            Property(p => p.PCT012N204)
                .HasColumnName("PCT012N204")
                .HasColumnOrder(208)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N204")
                .IsOptional();

            Property(p => p.PCT012N205)
                .HasColumnName("PCT012N205")
                .HasColumnOrder(209)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N205")
                .IsOptional();

            Property(p => p.PCT012N206)
                .HasColumnName("PCT012N206")
                .HasColumnOrder(210)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N206")
                .IsOptional();

            Property(p => p.PCT012N207)
                .HasColumnName("PCT012N207")
                .HasColumnOrder(211)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N207")
                .IsOptional();

            Property(p => p.PCT012N208)
                .HasColumnName("PCT012N208")
                .HasColumnOrder(212)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N208")
                .IsOptional();

            Property(p => p.PCT012N209)
                .HasColumnName("PCT012N209")
                .HasColumnOrder(213)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT012N209")
                .IsOptional();
        }
    }
}
