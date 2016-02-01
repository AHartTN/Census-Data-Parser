#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/31/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SummaryTwo_SF2_Segment_06Map.cs
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

    public class SummaryTwo_SF2_Segment_06Map : EntityTypeConfiguration<SummaryTwo_SF2_Segment_06>
    {
        public SummaryTwo_SF2_Segment_06Map()
        {
            ToTable("SF2_Segment_06", "SummaryTwo");

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

            Property(p => p.PCT0320001)
                .HasColumnName("PCT0320001")
                .HasColumnOrder(5)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0320001")
                .IsOptional();

            Property(p => p.PCT0320002)
                .HasColumnName("PCT0320002")
                .HasColumnOrder(6)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0320002")
                .IsOptional();

            Property(p => p.PCT0320003)
                .HasColumnName("PCT0320003")
                .HasColumnOrder(7)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0320003")
                .IsOptional();

            Property(p => p.PCT0320004)
                .HasColumnName("PCT0320004")
                .HasColumnOrder(8)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0320004")
                .IsOptional();

            Property(p => p.PCT0320005)
                .HasColumnName("PCT0320005")
                .HasColumnOrder(9)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0320005")
                .IsOptional();

            Property(p => p.PCT0320006)
                .HasColumnName("PCT0320006")
                .HasColumnOrder(10)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0320006")
                .IsOptional();

            Property(p => p.PCT0320007)
                .HasColumnName("PCT0320007")
                .HasColumnOrder(11)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0320007")
                .IsOptional();

            Property(p => p.PCT0320008)
                .HasColumnName("PCT0320008")
                .HasColumnOrder(12)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0320008")
                .IsOptional();

            Property(p => p.PCT0320009)
                .HasColumnName("PCT0320009")
                .HasColumnOrder(13)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0320009")
                .IsOptional();

            Property(p => p.PCT0320010)
                .HasColumnName("PCT0320010")
                .HasColumnOrder(14)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0320010")
                .IsOptional();

            Property(p => p.PCT0320011)
                .HasColumnName("PCT0320011")
                .HasColumnOrder(15)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0320011")
                .IsOptional();

            Property(p => p.PCT0320012)
                .HasColumnName("PCT0320012")
                .HasColumnOrder(16)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0320012")
                .IsOptional();

            Property(p => p.PCT0320013)
                .HasColumnName("PCT0320013")
                .HasColumnOrder(17)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0320013")
                .IsOptional();

            Property(p => p.PCT0320014)
                .HasColumnName("PCT0320014")
                .HasColumnOrder(18)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0320014")
                .IsOptional();

            Property(p => p.PCT0320015)
                .HasColumnName("PCT0320015")
                .HasColumnOrder(19)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0320015")
                .IsOptional();

            Property(p => p.PCT0320016)
                .HasColumnName("PCT0320016")
                .HasColumnOrder(20)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0320016")
                .IsOptional();

            Property(p => p.PCT0320017)
                .HasColumnName("PCT0320017")
                .HasColumnOrder(21)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0320017")
                .IsOptional();

            Property(p => p.PCT0320018)
                .HasColumnName("PCT0320018")
                .HasColumnOrder(22)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0320018")
                .IsOptional();

            Property(p => p.PCT0320019)
                .HasColumnName("PCT0320019")
                .HasColumnOrder(23)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0320019")
                .IsOptional();

            Property(p => p.PCT0320020)
                .HasColumnName("PCT0320020")
                .HasColumnOrder(24)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0320020")
                .IsOptional();

            Property(p => p.PCT0330001)
                .HasColumnName("PCT0330001")
                .HasColumnOrder(25)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0330001")
                .IsOptional();

            Property(p => p.PCT0330002)
                .HasColumnName("PCT0330002")
                .HasColumnOrder(26)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0330002")
                .IsOptional();

            Property(p => p.PCT0330003)
                .HasColumnName("PCT0330003")
                .HasColumnOrder(27)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0330003")
                .IsOptional();

            Property(p => p.PCT0330004)
                .HasColumnName("PCT0330004")
                .HasColumnOrder(28)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0330004")
                .IsOptional();

            Property(p => p.PCT0330005)
                .HasColumnName("PCT0330005")
                .HasColumnOrder(29)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0330005")
                .IsOptional();

            Property(p => p.PCT0330006)
                .HasColumnName("PCT0330006")
                .HasColumnOrder(30)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0330006")
                .IsOptional();

            Property(p => p.PCT0330007)
                .HasColumnName("PCT0330007")
                .HasColumnOrder(31)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0330007")
                .IsOptional();

            Property(p => p.PCT0330008)
                .HasColumnName("PCT0330008")
                .HasColumnOrder(32)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0330008")
                .IsOptional();

            Property(p => p.PCT0330009)
                .HasColumnName("PCT0330009")
                .HasColumnOrder(33)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0330009")
                .IsOptional();

            Property(p => p.PCT0330010)
                .HasColumnName("PCT0330010")
                .HasColumnOrder(34)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0330010")
                .IsOptional();

            Property(p => p.PCT0330011)
                .HasColumnName("PCT0330011")
                .HasColumnOrder(35)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0330011")
                .IsOptional();

            Property(p => p.PCT0330012)
                .HasColumnName("PCT0330012")
                .HasColumnOrder(36)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0330012")
                .IsOptional();

            Property(p => p.PCT0330013)
                .HasColumnName("PCT0330013")
                .HasColumnOrder(37)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0330013")
                .IsOptional();

            Property(p => p.PCT0330014)
                .HasColumnName("PCT0330014")
                .HasColumnOrder(38)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0330014")
                .IsOptional();

            Property(p => p.PCT0330015)
                .HasColumnName("PCT0330015")
                .HasColumnOrder(39)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0330015")
                .IsOptional();

            Property(p => p.PCT0330016)
                .HasColumnName("PCT0330016")
                .HasColumnOrder(40)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0330016")
                .IsOptional();

            Property(p => p.PCT0330017)
                .HasColumnName("PCT0330017")
                .HasColumnOrder(41)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0330017")
                .IsOptional();

            Property(p => p.PCT0330018)
                .HasColumnName("PCT0330018")
                .HasColumnOrder(42)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0330018")
                .IsOptional();

            Property(p => p.PCT0330019)
                .HasColumnName("PCT0330019")
                .HasColumnOrder(43)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0330019")
                .IsOptional();

            Property(p => p.PCT0330020)
                .HasColumnName("PCT0330020")
                .HasColumnOrder(44)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0330020")
                .IsOptional();

            Property(p => p.PCT0340001)
                .HasColumnName("PCT0340001")
                .HasColumnOrder(45)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0340001")
                .IsOptional();

            Property(p => p.PCT0340002)
                .HasColumnName("PCT0340002")
                .HasColumnOrder(46)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0340002")
                .IsOptional();

            Property(p => p.PCT0340003)
                .HasColumnName("PCT0340003")
                .HasColumnOrder(47)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0340003")
                .IsOptional();

            Property(p => p.PCT0340004)
                .HasColumnName("PCT0340004")
                .HasColumnOrder(48)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0340004")
                .IsOptional();

            Property(p => p.PCT0340005)
                .HasColumnName("PCT0340005")
                .HasColumnOrder(49)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0340005")
                .IsOptional();

            Property(p => p.PCT0340006)
                .HasColumnName("PCT0340006")
                .HasColumnOrder(50)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0340006")
                .IsOptional();

            Property(p => p.PCT0340007)
                .HasColumnName("PCT0340007")
                .HasColumnOrder(51)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0340007")
                .IsOptional();

            Property(p => p.PCT0340008)
                .HasColumnName("PCT0340008")
                .HasColumnOrder(52)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0340008")
                .IsOptional();

            Property(p => p.PCT0340009)
                .HasColumnName("PCT0340009")
                .HasColumnOrder(53)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0340009")
                .IsOptional();

            Property(p => p.PCT0340010)
                .HasColumnName("PCT0340010")
                .HasColumnOrder(54)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0340010")
                .IsOptional();

            Property(p => p.PCT0340011)
                .HasColumnName("PCT0340011")
                .HasColumnOrder(55)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0340011")
                .IsOptional();

            Property(p => p.PCT0340012)
                .HasColumnName("PCT0340012")
                .HasColumnOrder(56)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0340012")
                .IsOptional();

            Property(p => p.PCT0340013)
                .HasColumnName("PCT0340013")
                .HasColumnOrder(57)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0340013")
                .IsOptional();

            Property(p => p.PCT0340014)
                .HasColumnName("PCT0340014")
                .HasColumnOrder(58)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0340014")
                .IsOptional();

            Property(p => p.PCT0340015)
                .HasColumnName("PCT0340015")
                .HasColumnOrder(59)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0340015")
                .IsOptional();

            Property(p => p.PCT0340016)
                .HasColumnName("PCT0340016")
                .HasColumnOrder(60)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0340016")
                .IsOptional();

            Property(p => p.PCT0340017)
                .HasColumnName("PCT0340017")
                .HasColumnOrder(61)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0340017")
                .IsOptional();

            Property(p => p.PCT0340018)
                .HasColumnName("PCT0340018")
                .HasColumnOrder(62)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0340018")
                .IsOptional();

            Property(p => p.PCT0340019)
                .HasColumnName("PCT0340019")
                .HasColumnOrder(63)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0340019")
                .IsOptional();

            Property(p => p.PCT0340020)
                .HasColumnName("PCT0340020")
                .HasColumnOrder(64)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0340020")
                .IsOptional();

            Property(p => p.PCT0350001)
                .HasColumnName("PCT0350001")
                .HasColumnOrder(65)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0350001")
                .IsOptional();

            Property(p => p.PCT0350002)
                .HasColumnName("PCT0350002")
                .HasColumnOrder(66)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0350002")
                .IsOptional();

            Property(p => p.PCT0350003)
                .HasColumnName("PCT0350003")
                .HasColumnOrder(67)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0350003")
                .IsOptional();

            Property(p => p.PCT0350004)
                .HasColumnName("PCT0350004")
                .HasColumnOrder(68)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0350004")
                .IsOptional();

            Property(p => p.PCT0350005)
                .HasColumnName("PCT0350005")
                .HasColumnOrder(69)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0350005")
                .IsOptional();

            Property(p => p.PCT0350006)
                .HasColumnName("PCT0350006")
                .HasColumnOrder(70)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0350006")
                .IsOptional();

            Property(p => p.PCT0360001)
                .HasColumnName("PCT0360001")
                .HasColumnOrder(71)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0360001")
                .IsOptional();

            Property(p => p.PCT0360002)
                .HasColumnName("PCT0360002")
                .HasColumnOrder(72)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0360002")
                .IsOptional();

            Property(p => p.PCT0360003)
                .HasColumnName("PCT0360003")
                .HasColumnOrder(73)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0360003")
                .IsOptional();

            Property(p => p.PCT0360004)
                .HasColumnName("PCT0360004")
                .HasColumnOrder(74)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0360004")
                .IsOptional();

            Property(p => p.PCT0360005)
                .HasColumnName("PCT0360005")
                .HasColumnOrder(75)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0360005")
                .IsOptional();

            Property(p => p.PCT0360006)
                .HasColumnName("PCT0360006")
                .HasColumnOrder(76)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0360006")
                .IsOptional();

            Property(p => p.PCT0360007)
                .HasColumnName("PCT0360007")
                .HasColumnOrder(77)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0360007")
                .IsOptional();

            Property(p => p.PCT0360008)
                .HasColumnName("PCT0360008")
                .HasColumnOrder(78)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0360008")
                .IsOptional();

            Property(p => p.PCT0360009)
                .HasColumnName("PCT0360009")
                .HasColumnOrder(79)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0360009")
                .IsOptional();

            Property(p => p.PCT0360010)
                .HasColumnName("PCT0360010")
                .HasColumnOrder(80)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0360010")
                .IsOptional();

            Property(p => p.PCT0360011)
                .HasColumnName("PCT0360011")
                .HasColumnOrder(81)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0360011")
                .IsOptional();

            Property(p => p.PCT0360012)
                .HasColumnName("PCT0360012")
                .HasColumnOrder(82)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0360012")
                .IsOptional();

            Property(p => p.PCT0360013)
                .HasColumnName("PCT0360013")
                .HasColumnOrder(83)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0360013")
                .IsOptional();

            Property(p => p.PCT0360014)
                .HasColumnName("PCT0360014")
                .HasColumnOrder(84)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0360014")
                .IsOptional();

            Property(p => p.PCT0360015)
                .HasColumnName("PCT0360015")
                .HasColumnOrder(85)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0360015")
                .IsOptional();

            Property(p => p.PCT0370001)
                .HasColumnName("PCT0370001")
                .HasColumnOrder(86)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0370001")
                .IsOptional();

            Property(p => p.PCT0370002)
                .HasColumnName("PCT0370002")
                .HasColumnOrder(87)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0370002")
                .IsOptional();

            Property(p => p.PCT0370003)
                .HasColumnName("PCT0370003")
                .HasColumnOrder(88)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0370003")
                .IsOptional();

            Property(p => p.PCT0370004)
                .HasColumnName("PCT0370004")
                .HasColumnOrder(89)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0370004")
                .IsOptional();

            Property(p => p.PCT0370005)
                .HasColumnName("PCT0370005")
                .HasColumnOrder(90)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0370005")
                .IsOptional();

            Property(p => p.PCT0370006)
                .HasColumnName("PCT0370006")
                .HasColumnOrder(91)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0370006")
                .IsOptional();

            Property(p => p.PCT0370007)
                .HasColumnName("PCT0370007")
                .HasColumnOrder(92)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0370007")
                .IsOptional();

            Property(p => p.PCT0370008)
                .HasColumnName("PCT0370008")
                .HasColumnOrder(93)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0370008")
                .IsOptional();

            Property(p => p.PCT0370009)
                .HasColumnName("PCT0370009")
                .HasColumnOrder(94)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0370009")
                .IsOptional();

            Property(p => p.PCT0370010)
                .HasColumnName("PCT0370010")
                .HasColumnOrder(95)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0370010")
                .IsOptional();

            Property(p => p.PCT0370011)
                .HasColumnName("PCT0370011")
                .HasColumnOrder(96)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0370011")
                .IsOptional();

            Property(p => p.PCT038_0001)
                .HasColumnName("PCT038_0001")
                .HasColumnOrder(97)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0001")
                .IsOptional();

            Property(p => p.PCT038_0002)
                .HasColumnName("PCT038_0002")
                .HasColumnOrder(98)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0002")
                .IsOptional();

            Property(p => p.PCT038_0003)
                .HasColumnName("PCT038_0003")
                .HasColumnOrder(99)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0003")
                .IsOptional();

            Property(p => p.PCT038_0004)
                .HasColumnName("PCT038_0004")
                .HasColumnOrder(100)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0004")
                .IsOptional();

            Property(p => p.PCT038_0005)
                .HasColumnName("PCT038_0005")
                .HasColumnOrder(101)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0005")
                .IsOptional();

            Property(p => p.PCT038_0006)
                .HasColumnName("PCT038_0006")
                .HasColumnOrder(102)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0006")
                .IsOptional();

            Property(p => p.PCT038_0007)
                .HasColumnName("PCT038_0007")
                .HasColumnOrder(103)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0007")
                .IsOptional();

            Property(p => p.PCT038_0008)
                .HasColumnName("PCT038_0008")
                .HasColumnOrder(104)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0008")
                .IsOptional();

            Property(p => p.PCT038_0009)
                .HasColumnName("PCT038_0009")
                .HasColumnOrder(105)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0009")
                .IsOptional();

            Property(p => p.PCT038_0010)
                .HasColumnName("PCT038_0010")
                .HasColumnOrder(106)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0010")
                .IsOptional();

            Property(p => p.PCT038_0011)
                .HasColumnName("PCT038_0011")
                .HasColumnOrder(107)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0011")
                .IsOptional();

            Property(p => p.PCT038_0012)
                .HasColumnName("PCT038_0012")
                .HasColumnOrder(108)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0012")
                .IsOptional();

            Property(p => p.PCT038_0013)
                .HasColumnName("PCT038_0013")
                .HasColumnOrder(109)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0013")
                .IsOptional();

            Property(p => p.PCT038_0014)
                .HasColumnName("PCT038_0014")
                .HasColumnOrder(110)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0014")
                .IsOptional();

            Property(p => p.PCT038_0015)
                .HasColumnName("PCT038_0015")
                .HasColumnOrder(111)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0015")
                .IsOptional();

            Property(p => p.PCT038_0016)
                .HasColumnName("PCT038_0016")
                .HasColumnOrder(112)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0016")
                .IsOptional();

            Property(p => p.PCT038_0017)
                .HasColumnName("PCT038_0017")
                .HasColumnOrder(113)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0017")
                .IsOptional();

            Property(p => p.PCT038_0018)
                .HasColumnName("PCT038_0018")
                .HasColumnOrder(114)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0018")
                .IsOptional();

            Property(p => p.PCT038_0019)
                .HasColumnName("PCT038_0019")
                .HasColumnOrder(115)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0019")
                .IsOptional();

            Property(p => p.PCT038_0020)
                .HasColumnName("PCT038_0020")
                .HasColumnOrder(116)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0020")
                .IsOptional();

            Property(p => p.PCT038_0021)
                .HasColumnName("PCT038_0021")
                .HasColumnOrder(117)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0021")
                .IsOptional();

            Property(p => p.PCT038_0022)
                .HasColumnName("PCT038_0022")
                .HasColumnOrder(118)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0022")
                .IsOptional();

            Property(p => p.PCT038_0023)
                .HasColumnName("PCT038_0023")
                .HasColumnOrder(119)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0023")
                .IsOptional();

            Property(p => p.PCT038_0024)
                .HasColumnName("PCT038_0024")
                .HasColumnOrder(120)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0024")
                .IsOptional();

            Property(p => p.PCT038_0025)
                .HasColumnName("PCT038_0025")
                .HasColumnOrder(121)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0025")
                .IsOptional();

            Property(p => p.PCT038_0026)
                .HasColumnName("PCT038_0026")
                .HasColumnOrder(122)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0026")
                .IsOptional();

            Property(p => p.PCT038_0027)
                .HasColumnName("PCT038_0027")
                .HasColumnOrder(123)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0027")
                .IsOptional();

            Property(p => p.PCT038_0028)
                .HasColumnName("PCT038_0028")
                .HasColumnOrder(124)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0028")
                .IsOptional();

            Property(p => p.PCT038_0029)
                .HasColumnName("PCT038_0029")
                .HasColumnOrder(125)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0029")
                .IsOptional();

            Property(p => p.PCT038_0030)
                .HasColumnName("PCT038_0030")
                .HasColumnOrder(126)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0030")
                .IsOptional();

            Property(p => p.PCT038_0031)
                .HasColumnName("PCT038_0031")
                .HasColumnOrder(127)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0031")
                .IsOptional();

            Property(p => p.PCT038_0032)
                .HasColumnName("PCT038_0032")
                .HasColumnOrder(128)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT038_0032")
                .IsOptional();
        }
    }
}
