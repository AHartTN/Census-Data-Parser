#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/31/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SummaryTwo_SF2_Segment_05Map.cs
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

    public class SummaryTwo_SF2_Segment_05Map : EntityTypeConfiguration<SummaryTwo_SF2_Segment_05>
    {
        public SummaryTwo_SF2_Segment_05Map()
        {
            ToTable("SF2_Segment_05", "SummaryTwo");

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

            Property(p => p.PCT0190001)
                .HasColumnName("PCT0190001")
                .HasColumnOrder(5)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190001")
                .IsOptional();

            Property(p => p.PCT0190002)
                .HasColumnName("PCT0190002")
                .HasColumnOrder(6)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190002")
                .IsOptional();

            Property(p => p.PCT0190003)
                .HasColumnName("PCT0190003")
                .HasColumnOrder(7)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190003")
                .IsOptional();

            Property(p => p.PCT0190004)
                .HasColumnName("PCT0190004")
                .HasColumnOrder(8)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190004")
                .IsOptional();

            Property(p => p.PCT0190005)
                .HasColumnName("PCT0190005")
                .HasColumnOrder(9)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190005")
                .IsOptional();

            Property(p => p.PCT0190006)
                .HasColumnName("PCT0190006")
                .HasColumnOrder(10)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190006")
                .IsOptional();

            Property(p => p.PCT0190007)
                .HasColumnName("PCT0190007")
                .HasColumnOrder(11)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190007")
                .IsOptional();

            Property(p => p.PCT0190008)
                .HasColumnName("PCT0190008")
                .HasColumnOrder(12)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190008")
                .IsOptional();

            Property(p => p.PCT0190009)
                .HasColumnName("PCT0190009")
                .HasColumnOrder(13)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190009")
                .IsOptional();

            Property(p => p.PCT0190010)
                .HasColumnName("PCT0190010")
                .HasColumnOrder(14)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190010")
                .IsOptional();

            Property(p => p.PCT0190011)
                .HasColumnName("PCT0190011")
                .HasColumnOrder(15)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190011")
                .IsOptional();

            Property(p => p.PCT0190012)
                .HasColumnName("PCT0190012")
                .HasColumnOrder(16)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190012")
                .IsOptional();

            Property(p => p.PCT0190013)
                .HasColumnName("PCT0190013")
                .HasColumnOrder(17)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190013")
                .IsOptional();

            Property(p => p.PCT0190014)
                .HasColumnName("PCT0190014")
                .HasColumnOrder(18)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190014")
                .IsOptional();

            Property(p => p.PCT0190015)
                .HasColumnName("PCT0190015")
                .HasColumnOrder(19)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190015")
                .IsOptional();

            Property(p => p.PCT0190016)
                .HasColumnName("PCT0190016")
                .HasColumnOrder(20)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190016")
                .IsOptional();

            Property(p => p.PCT0190017)
                .HasColumnName("PCT0190017")
                .HasColumnOrder(21)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190017")
                .IsOptional();

            Property(p => p.PCT0190018)
                .HasColumnName("PCT0190018")
                .HasColumnOrder(22)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190018")
                .IsOptional();

            Property(p => p.PCT0190019)
                .HasColumnName("PCT0190019")
                .HasColumnOrder(23)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190019")
                .IsOptional();

            Property(p => p.PCT0190020)
                .HasColumnName("PCT0190020")
                .HasColumnOrder(24)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190020")
                .IsOptional();

            Property(p => p.PCT0190021)
                .HasColumnName("PCT0190021")
                .HasColumnOrder(25)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190021")
                .IsOptional();

            Property(p => p.PCT0190022)
                .HasColumnName("PCT0190022")
                .HasColumnOrder(26)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190022")
                .IsOptional();

            Property(p => p.PCT0190023)
                .HasColumnName("PCT0190023")
                .HasColumnOrder(27)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190023")
                .IsOptional();

            Property(p => p.PCT0190024)
                .HasColumnName("PCT0190024")
                .HasColumnOrder(28)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190024")
                .IsOptional();

            Property(p => p.PCT0190025)
                .HasColumnName("PCT0190025")
                .HasColumnOrder(29)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190025")
                .IsOptional();

            Property(p => p.PCT0190026)
                .HasColumnName("PCT0190026")
                .HasColumnOrder(30)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190026")
                .IsOptional();

            Property(p => p.PCT0190027)
                .HasColumnName("PCT0190027")
                .HasColumnOrder(31)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190027")
                .IsOptional();

            Property(p => p.PCT0190028)
                .HasColumnName("PCT0190028")
                .HasColumnOrder(32)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190028")
                .IsOptional();

            Property(p => p.PCT0190029)
                .HasColumnName("PCT0190029")
                .HasColumnOrder(33)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190029")
                .IsOptional();

            Property(p => p.PCT0190030)
                .HasColumnName("PCT0190030")
                .HasColumnOrder(34)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190030")
                .IsOptional();

            Property(p => p.PCT0190031)
                .HasColumnName("PCT0190031")
                .HasColumnOrder(35)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190031")
                .IsOptional();

            Property(p => p.PCT0190032)
                .HasColumnName("PCT0190032")
                .HasColumnOrder(36)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190032")
                .IsOptional();

            Property(p => p.PCT0190033)
                .HasColumnName("PCT0190033")
                .HasColumnOrder(37)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190033")
                .IsOptional();

            Property(p => p.PCT0190034)
                .HasColumnName("PCT0190034")
                .HasColumnOrder(38)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0190034")
                .IsOptional();

            Property(p => p.PCT0200001)
                .HasColumnName("PCT0200001")
                .HasColumnOrder(39)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0200001")
                .IsOptional();

            Property(p => p.PCT0200002)
                .HasColumnName("PCT0200002")
                .HasColumnOrder(40)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0200002")
                .IsOptional();

            Property(p => p.PCT0200003)
                .HasColumnName("PCT0200003")
                .HasColumnOrder(41)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0200003")
                .IsOptional();

            Property(p => p.PCT0200004)
                .HasColumnName("PCT0200004")
                .HasColumnOrder(42)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0200004")
                .IsOptional();

            Property(p => p.PCT0200005)
                .HasColumnName("PCT0200005")
                .HasColumnOrder(43)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0200005")
                .IsOptional();

            Property(p => p.PCT0200006)
                .HasColumnName("PCT0200006")
                .HasColumnOrder(44)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0200006")
                .IsOptional();

            Property(p => p.PCT0200007)
                .HasColumnName("PCT0200007")
                .HasColumnOrder(45)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0200007")
                .IsOptional();

            Property(p => p.PCT0200008)
                .HasColumnName("PCT0200008")
                .HasColumnOrder(46)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0200008")
                .IsOptional();

            Property(p => p.PCT0200009)
                .HasColumnName("PCT0200009")
                .HasColumnOrder(47)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0200009")
                .IsOptional();

            Property(p => p.PCT0200010)
                .HasColumnName("PCT0200010")
                .HasColumnOrder(48)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0200010")
                .IsOptional();

            Property(p => p.PCT0200011)
                .HasColumnName("PCT0200011")
                .HasColumnOrder(49)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0200011")
                .IsOptional();

            Property(p => p.PCT0200012)
                .HasColumnName("PCT0200012")
                .HasColumnOrder(50)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0200012")
                .IsOptional();

            Property(p => p.PCT0200013)
                .HasColumnName("PCT0200013")
                .HasColumnOrder(51)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0200013")
                .IsOptional();

            Property(p => p.PCT0200014)
                .HasColumnName("PCT0200014")
                .HasColumnOrder(52)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0200014")
                .IsOptional();

            Property(p => p.PCT0200015)
                .HasColumnName("PCT0200015")
                .HasColumnOrder(53)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0200015")
                .IsOptional();

            Property(p => p.PCT0200016)
                .HasColumnName("PCT0200016")
                .HasColumnOrder(54)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0200016")
                .IsOptional();

            Property(p => p.PCT0210001)
                .HasColumnName("PCT0210001")
                .HasColumnOrder(55)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0210001")
                .IsOptional();

            Property(p => p.PCT0210002)
                .HasColumnName("PCT0210002")
                .HasColumnOrder(56)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0210002")
                .IsOptional();

            Property(p => p.PCT0210003)
                .HasColumnName("PCT0210003")
                .HasColumnOrder(57)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0210003")
                .IsOptional();

            Property(p => p.PCT0210004)
                .HasColumnName("PCT0210004")
                .HasColumnOrder(58)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0210004")
                .IsOptional();

            Property(p => p.PCT0210005)
                .HasColumnName("PCT0210005")
                .HasColumnOrder(59)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0210005")
                .IsOptional();

            Property(p => p.PCT0210006)
                .HasColumnName("PCT0210006")
                .HasColumnOrder(60)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0210006")
                .IsOptional();

            Property(p => p.PCT0210007)
                .HasColumnName("PCT0210007")
                .HasColumnOrder(61)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0210007")
                .IsOptional();

            Property(p => p.PCT0210008)
                .HasColumnName("PCT0210008")
                .HasColumnOrder(62)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0210008")
                .IsOptional();

            Property(p => p.PCT0210009)
                .HasColumnName("PCT0210009")
                .HasColumnOrder(63)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0210009")
                .IsOptional();

            Property(p => p.PCT0210010)
                .HasColumnName("PCT0210010")
                .HasColumnOrder(64)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0210010")
                .IsOptional();

            Property(p => p.PCT0210011)
                .HasColumnName("PCT0210011")
                .HasColumnOrder(65)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0210011")
                .IsOptional();

            Property(p => p.PCT0210012)
                .HasColumnName("PCT0210012")
                .HasColumnOrder(66)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0210012")
                .IsOptional();

            Property(p => p.PCT0210013)
                .HasColumnName("PCT0210013")
                .HasColumnOrder(67)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0210013")
                .IsOptional();

            Property(p => p.PCT0210014)
                .HasColumnName("PCT0210014")
                .HasColumnOrder(68)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0210014")
                .IsOptional();

            Property(p => p.PCT0210015)
                .HasColumnName("PCT0210015")
                .HasColumnOrder(69)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0210015")
                .IsOptional();

            Property(p => p.PCT0210016)
                .HasColumnName("PCT0210016")
                .HasColumnOrder(70)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0210016")
                .IsOptional();

            Property(p => p.PCT0210017)
                .HasColumnName("PCT0210017")
                .HasColumnOrder(71)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0210017")
                .IsOptional();

            Property(p => p.PCT0210018)
                .HasColumnName("PCT0210018")
                .HasColumnOrder(72)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0210018")
                .IsOptional();

            Property(p => p.PCT0210019)
                .HasColumnName("PCT0210019")
                .HasColumnOrder(73)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0210019")
                .IsOptional();

            Property(p => p.PCT0210020)
                .HasColumnName("PCT0210020")
                .HasColumnOrder(74)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0210020")
                .IsOptional();

            Property(p => p.PCT0210021)
                .HasColumnName("PCT0210021")
                .HasColumnOrder(75)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0210021")
                .IsOptional();

            Property(p => p.PCT0210022)
                .HasColumnName("PCT0210022")
                .HasColumnOrder(76)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0210022")
                .IsOptional();

            Property(p => p.PCT0210023)
                .HasColumnName("PCT0210023")
                .HasColumnOrder(77)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0210023")
                .IsOptional();

            Property(p => p.PCT0210024)
                .HasColumnName("PCT0210024")
                .HasColumnOrder(78)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0210024")
                .IsOptional();

            Property(p => p.PCT0210025)
                .HasColumnName("PCT0210025")
                .HasColumnOrder(79)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0210025")
                .IsOptional();

            Property(p => p.PCT0210026)
                .HasColumnName("PCT0210026")
                .HasColumnOrder(80)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0210026")
                .IsOptional();

            Property(p => p.PCT0220001)
                .HasColumnName("PCT0220001")
                .HasColumnOrder(81)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220001")
                .IsOptional();

            Property(p => p.PCT0220002)
                .HasColumnName("PCT0220002")
                .HasColumnOrder(82)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220002")
                .IsOptional();

            Property(p => p.PCT0220003)
                .HasColumnName("PCT0220003")
                .HasColumnOrder(83)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220003")
                .IsOptional();

            Property(p => p.PCT0220004)
                .HasColumnName("PCT0220004")
                .HasColumnOrder(84)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220004")
                .IsOptional();

            Property(p => p.PCT0220005)
                .HasColumnName("PCT0220005")
                .HasColumnOrder(85)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220005")
                .IsOptional();

            Property(p => p.PCT0220006)
                .HasColumnName("PCT0220006")
                .HasColumnOrder(86)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220006")
                .IsOptional();

            Property(p => p.PCT0220007)
                .HasColumnName("PCT0220007")
                .HasColumnOrder(87)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220007")
                .IsOptional();

            Property(p => p.PCT0220008)
                .HasColumnName("PCT0220008")
                .HasColumnOrder(88)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220008")
                .IsOptional();

            Property(p => p.PCT0220009)
                .HasColumnName("PCT0220009")
                .HasColumnOrder(89)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220009")
                .IsOptional();

            Property(p => p.PCT0220010)
                .HasColumnName("PCT0220010")
                .HasColumnOrder(90)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220010")
                .IsOptional();

            Property(p => p.PCT0220011)
                .HasColumnName("PCT0220011")
                .HasColumnOrder(91)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220011")
                .IsOptional();

            Property(p => p.PCT0220012)
                .HasColumnName("PCT0220012")
                .HasColumnOrder(92)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220012")
                .IsOptional();

            Property(p => p.PCT0220013)
                .HasColumnName("PCT0220013")
                .HasColumnOrder(93)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220013")
                .IsOptional();

            Property(p => p.PCT0220014)
                .HasColumnName("PCT0220014")
                .HasColumnOrder(94)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220014")
                .IsOptional();

            Property(p => p.PCT0220015)
                .HasColumnName("PCT0220015")
                .HasColumnOrder(95)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220015")
                .IsOptional();

            Property(p => p.PCT0220016)
                .HasColumnName("PCT0220016")
                .HasColumnOrder(96)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220016")
                .IsOptional();

            Property(p => p.PCT0220017)
                .HasColumnName("PCT0220017")
                .HasColumnOrder(97)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220017")
                .IsOptional();

            Property(p => p.PCT0220018)
                .HasColumnName("PCT0220018")
                .HasColumnOrder(98)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220018")
                .IsOptional();

            Property(p => p.PCT0220019)
                .HasColumnName("PCT0220019")
                .HasColumnOrder(99)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220019")
                .IsOptional();

            Property(p => p.PCT0220020)
                .HasColumnName("PCT0220020")
                .HasColumnOrder(100)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220020")
                .IsOptional();

            Property(p => p.PCT0220021)
                .HasColumnName("PCT0220021")
                .HasColumnOrder(101)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220021")
                .IsOptional();

            Property(p => p.PCT0220022)
                .HasColumnName("PCT0220022")
                .HasColumnOrder(102)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220022")
                .IsOptional();

            Property(p => p.PCT0220023)
                .HasColumnName("PCT0220023")
                .HasColumnOrder(103)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220023")
                .IsOptional();

            Property(p => p.PCT0220024)
                .HasColumnName("PCT0220024")
                .HasColumnOrder(104)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220024")
                .IsOptional();

            Property(p => p.PCT0220025)
                .HasColumnName("PCT0220025")
                .HasColumnOrder(105)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220025")
                .IsOptional();

            Property(p => p.PCT0220026)
                .HasColumnName("PCT0220026")
                .HasColumnOrder(106)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220026")
                .IsOptional();

            Property(p => p.PCT0220027)
                .HasColumnName("PCT0220027")
                .HasColumnOrder(107)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220027")
                .IsOptional();

            Property(p => p.PCT0220028)
                .HasColumnName("PCT0220028")
                .HasColumnOrder(108)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0220028")
                .IsOptional();

            Property(p => p.PCT0230001)
                .HasColumnName("PCT0230001")
                .HasColumnOrder(109)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0230001")
                .IsOptional();

            Property(p => p.PCT0230002)
                .HasColumnName("PCT0230002")
                .HasColumnOrder(110)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0230002")
                .IsOptional();

            Property(p => p.PCT0230003)
                .HasColumnName("PCT0230003")
                .HasColumnOrder(111)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0230003")
                .IsOptional();

            Property(p => p.PCT0230004)
                .HasColumnName("PCT0230004")
                .HasColumnOrder(112)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0230004")
                .IsOptional();

            Property(p => p.PCT0230005)
                .HasColumnName("PCT0230005")
                .HasColumnOrder(113)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0230005")
                .IsOptional();

            Property(p => p.PCT0230006)
                .HasColumnName("PCT0230006")
                .HasColumnOrder(114)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0230006")
                .IsOptional();

            Property(p => p.PCT0230007)
                .HasColumnName("PCT0230007")
                .HasColumnOrder(115)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0230007")
                .IsOptional();

            Property(p => p.PCT0230008)
                .HasColumnName("PCT0230008")
                .HasColumnOrder(116)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0230008")
                .IsOptional();

            Property(p => p.PCT0230009)
                .HasColumnName("PCT0230009")
                .HasColumnOrder(117)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0230009")
                .IsOptional();

            Property(p => p.PCT0230010)
                .HasColumnName("PCT0230010")
                .HasColumnOrder(118)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0230010")
                .IsOptional();

            Property(p => p.PCT0230011)
                .HasColumnName("PCT0230011")
                .HasColumnOrder(119)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0230011")
                .IsOptional();

            Property(p => p.PCT0230012)
                .HasColumnName("PCT0230012")
                .HasColumnOrder(120)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0230012")
                .IsOptional();

            Property(p => p.PCT0230013)
                .HasColumnName("PCT0230013")
                .HasColumnOrder(121)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0230013")
                .IsOptional();

            Property(p => p.PCT0240001)
                .HasColumnName("PCT0240001")
                .HasColumnOrder(122)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0240001")
                .IsOptional();

            Property(p => p.PCT0240002)
                .HasColumnName("PCT0240002")
                .HasColumnOrder(123)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0240002")
                .IsOptional();

            Property(p => p.PCT0240003)
                .HasColumnName("PCT0240003")
                .HasColumnOrder(124)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0240003")
                .IsOptional();

            Property(p => p.PCT0240004)
                .HasColumnName("PCT0240004")
                .HasColumnOrder(125)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0240004")
                .IsOptional();

            Property(p => p.PCT0240005)
                .HasColumnName("PCT0240005")
                .HasColumnOrder(126)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0240005")
                .IsOptional();

            Property(p => p.PCT0240006)
                .HasColumnName("PCT0240006")
                .HasColumnOrder(127)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0240006")
                .IsOptional();

            Property(p => p.PCT0240007)
                .HasColumnName("PCT0240007")
                .HasColumnOrder(128)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0240007")
                .IsOptional();

            Property(p => p.PCT0240008)
                .HasColumnName("PCT0240008")
                .HasColumnOrder(129)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0240008")
                .IsOptional();

            Property(p => p.PCT0240009)
                .HasColumnName("PCT0240009")
                .HasColumnOrder(130)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0240009")
                .IsOptional();

            Property(p => p.PCT0240010)
                .HasColumnName("PCT0240010")
                .HasColumnOrder(131)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0240010")
                .IsOptional();

            Property(p => p.PCT0240011)
                .HasColumnName("PCT0240011")
                .HasColumnOrder(132)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0240011")
                .IsOptional();

            Property(p => p.PCT0240012)
                .HasColumnName("PCT0240012")
                .HasColumnOrder(133)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0240012")
                .IsOptional();

            Property(p => p.PCT0240013)
                .HasColumnName("PCT0240013")
                .HasColumnOrder(134)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0240013")
                .IsOptional();

            Property(p => p.PCT0240014)
                .HasColumnName("PCT0240014")
                .HasColumnOrder(135)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0240014")
                .IsOptional();

            Property(p => p.PCT0240015)
                .HasColumnName("PCT0240015")
                .HasColumnOrder(136)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0240015")
                .IsOptional();

            Property(p => p.PCT0240016)
                .HasColumnName("PCT0240016")
                .HasColumnOrder(137)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0240016")
                .IsOptional();

            Property(p => p.PCT0250001)
                .HasColumnName("PCT0250001")
                .HasColumnOrder(138)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250001")
                .IsOptional();

            Property(p => p.PCT0250002)
                .HasColumnName("PCT0250002")
                .HasColumnOrder(139)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250002")
                .IsOptional();

            Property(p => p.PCT0250003)
                .HasColumnName("PCT0250003")
                .HasColumnOrder(140)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250003")
                .IsOptional();

            Property(p => p.PCT0250004)
                .HasColumnName("PCT0250004")
                .HasColumnOrder(141)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250004")
                .IsOptional();

            Property(p => p.PCT0250005)
                .HasColumnName("PCT0250005")
                .HasColumnOrder(142)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250005")
                .IsOptional();

            Property(p => p.PCT0250006)
                .HasColumnName("PCT0250006")
                .HasColumnOrder(143)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250006")
                .IsOptional();

            Property(p => p.PCT0250007)
                .HasColumnName("PCT0250007")
                .HasColumnOrder(144)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250007")
                .IsOptional();

            Property(p => p.PCT0250008)
                .HasColumnName("PCT0250008")
                .HasColumnOrder(145)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250008")
                .IsOptional();

            Property(p => p.PCT0250009)
                .HasColumnName("PCT0250009")
                .HasColumnOrder(146)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250009")
                .IsOptional();

            Property(p => p.PCT0250010)
                .HasColumnName("PCT0250010")
                .HasColumnOrder(147)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250010")
                .IsOptional();

            Property(p => p.PCT0250011)
                .HasColumnName("PCT0250011")
                .HasColumnOrder(148)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250011")
                .IsOptional();

            Property(p => p.PCT0250012)
                .HasColumnName("PCT0250012")
                .HasColumnOrder(149)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250012")
                .IsOptional();

            Property(p => p.PCT0250013)
                .HasColumnName("PCT0250013")
                .HasColumnOrder(150)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250013")
                .IsOptional();

            Property(p => p.PCT0250014)
                .HasColumnName("PCT0250014")
                .HasColumnOrder(151)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250014")
                .IsOptional();

            Property(p => p.PCT0250015)
                .HasColumnName("PCT0250015")
                .HasColumnOrder(152)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250015")
                .IsOptional();

            Property(p => p.PCT0250016)
                .HasColumnName("PCT0250016")
                .HasColumnOrder(153)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250016")
                .IsOptional();

            Property(p => p.PCT0250017)
                .HasColumnName("PCT0250017")
                .HasColumnOrder(154)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250017")
                .IsOptional();

            Property(p => p.PCT0250018)
                .HasColumnName("PCT0250018")
                .HasColumnOrder(155)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250018")
                .IsOptional();

            Property(p => p.PCT0250019)
                .HasColumnName("PCT0250019")
                .HasColumnOrder(156)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250019")
                .IsOptional();

            Property(p => p.PCT0250020)
                .HasColumnName("PCT0250020")
                .HasColumnOrder(157)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250020")
                .IsOptional();

            Property(p => p.PCT0250021)
                .HasColumnName("PCT0250021")
                .HasColumnOrder(158)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250021")
                .IsOptional();

            Property(p => p.PCT0250022)
                .HasColumnName("PCT0250022")
                .HasColumnOrder(159)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250022")
                .IsOptional();

            Property(p => p.PCT0250023)
                .HasColumnName("PCT0250023")
                .HasColumnOrder(160)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250023")
                .IsOptional();

            Property(p => p.PCT0250024)
                .HasColumnName("PCT0250024")
                .HasColumnOrder(161)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250024")
                .IsOptional();

            Property(p => p.PCT0250025)
                .HasColumnName("PCT0250025")
                .HasColumnOrder(162)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250025")
                .IsOptional();

            Property(p => p.PCT0250026)
                .HasColumnName("PCT0250026")
                .HasColumnOrder(163)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250026")
                .IsOptional();

            Property(p => p.PCT0250027)
                .HasColumnName("PCT0250027")
                .HasColumnOrder(164)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250027")
                .IsOptional();

            Property(p => p.PCT0250028)
                .HasColumnName("PCT0250028")
                .HasColumnOrder(165)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250028")
                .IsOptional();

            Property(p => p.PCT0250029)
                .HasColumnName("PCT0250029")
                .HasColumnOrder(166)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250029")
                .IsOptional();

            Property(p => p.PCT0250030)
                .HasColumnName("PCT0250030")
                .HasColumnOrder(167)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250030")
                .IsOptional();

            Property(p => p.PCT0250031)
                .HasColumnName("PCT0250031")
                .HasColumnOrder(168)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250031")
                .IsOptional();

            Property(p => p.PCT0250032)
                .HasColumnName("PCT0250032")
                .HasColumnOrder(169)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250032")
                .IsOptional();

            Property(p => p.PCT0250033)
                .HasColumnName("PCT0250033")
                .HasColumnOrder(170)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250033")
                .IsOptional();

            Property(p => p.PCT0250034)
                .HasColumnName("PCT0250034")
                .HasColumnOrder(171)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250034")
                .IsOptional();

            Property(p => p.PCT0250035)
                .HasColumnName("PCT0250035")
                .HasColumnOrder(172)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250035")
                .IsOptional();

            Property(p => p.PCT0250036)
                .HasColumnName("PCT0250036")
                .HasColumnOrder(173)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250036")
                .IsOptional();

            Property(p => p.PCT0250037)
                .HasColumnName("PCT0250037")
                .HasColumnOrder(174)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250037")
                .IsOptional();

            Property(p => p.PCT0250038)
                .HasColumnName("PCT0250038")
                .HasColumnOrder(175)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250038")
                .IsOptional();

            Property(p => p.PCT0250039)
                .HasColumnName("PCT0250039")
                .HasColumnOrder(176)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250039")
                .IsOptional();

            Property(p => p.PCT0250040)
                .HasColumnName("PCT0250040")
                .HasColumnOrder(177)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250040")
                .IsOptional();

            Property(p => p.PCT0250041)
                .HasColumnName("PCT0250041")
                .HasColumnOrder(178)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250041")
                .IsOptional();

            Property(p => p.PCT0250042)
                .HasColumnName("PCT0250042")
                .HasColumnOrder(179)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250042")
                .IsOptional();

            Property(p => p.PCT0250043)
                .HasColumnName("PCT0250043")
                .HasColumnOrder(180)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250043")
                .IsOptional();

            Property(p => p.PCT0250044)
                .HasColumnName("PCT0250044")
                .HasColumnOrder(181)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250044")
                .IsOptional();

            Property(p => p.PCT0250045)
                .HasColumnName("PCT0250045")
                .HasColumnOrder(182)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0250045")
                .IsOptional();

            Property(p => p.PCT0260001)
                .HasColumnName("PCT0260001")
                .HasColumnOrder(183)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0260001")
                .IsOptional();

            Property(p => p.PCT0260002)
                .HasColumnName("PCT0260002")
                .HasColumnOrder(184)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0260002")
                .IsOptional();

            Property(p => p.PCT0260003)
                .HasColumnName("PCT0260003")
                .HasColumnOrder(185)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0260003")
                .IsOptional();

            Property(p => p.PCT0260004)
                .HasColumnName("PCT0260004")
                .HasColumnOrder(186)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0260004")
                .IsOptional();

            Property(p => p.PCT0260005)
                .HasColumnName("PCT0260005")
                .HasColumnOrder(187)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0260005")
                .IsOptional();

            Property(p => p.PCT0260006)
                .HasColumnName("PCT0260006")
                .HasColumnOrder(188)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0260006")
                .IsOptional();

            Property(p => p.PCT0260007)
                .HasColumnName("PCT0260007")
                .HasColumnOrder(189)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0260007")
                .IsOptional();

            Property(p => p.PCT0270001)
                .HasColumnName("PCT0270001")
                .HasColumnOrder(190)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0270001")
                .IsOptional();

            Property(p => p.PCT0270002)
                .HasColumnName("PCT0270002")
                .HasColumnOrder(191)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0270002")
                .IsOptional();

            Property(p => p.PCT0270003)
                .HasColumnName("PCT0270003")
                .HasColumnOrder(192)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0270003")
                .IsOptional();

            Property(p => p.PCT0270004)
                .HasColumnName("PCT0270004")
                .HasColumnOrder(193)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0270004")
                .IsOptional();

            Property(p => p.PCT0270005)
                .HasColumnName("PCT0270005")
                .HasColumnOrder(194)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0270005")
                .IsOptional();

            Property(p => p.PCT0270006)
                .HasColumnName("PCT0270006")
                .HasColumnOrder(195)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0270006")
                .IsOptional();

            Property(p => p.PCT0270007)
                .HasColumnName("PCT0270007")
                .HasColumnOrder(196)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0270007")
                .IsOptional();

            Property(p => p.PCT0270008)
                .HasColumnName("PCT0270008")
                .HasColumnOrder(197)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0270008")
                .IsOptional();

            Property(p => p.PCT0270009)
                .HasColumnName("PCT0270009")
                .HasColumnOrder(198)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0270009")
                .IsOptional();

            Property(p => p.PCT0270010)
                .HasColumnName("PCT0270010")
                .HasColumnOrder(199)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0270010")
                .IsOptional();

            Property(p => p.PCT0270011)
                .HasColumnName("PCT0270011")
                .HasColumnOrder(200)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0270011")
                .IsOptional();

            Property(p => p.PCT0270012)
                .HasColumnName("PCT0270012")
                .HasColumnOrder(201)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0270012")
                .IsOptional();

            Property(p => p.PCT0270013)
                .HasColumnName("PCT0270013")
                .HasColumnOrder(202)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0270013")
                .IsOptional();

            Property(p => p.PCT0270014)
                .HasColumnName("PCT0270014")
                .HasColumnOrder(203)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0270014")
                .IsOptional();

            Property(p => p.PCT0270015)
                .HasColumnName("PCT0270015")
                .HasColumnOrder(204)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0270015")
                .IsOptional();

            Property(p => p.PCT0270016)
                .HasColumnName("PCT0270016")
                .HasColumnOrder(205)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0270016")
                .IsOptional();

            Property(p => p.PCT0270017)
                .HasColumnName("PCT0270017")
                .HasColumnOrder(206)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0270017")
                .IsOptional();

            Property(p => p.PCT0270018)
                .HasColumnName("PCT0270018")
                .HasColumnOrder(207)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0270018")
                .IsOptional();

            Property(p => p.PCT0280001)
                .HasColumnName("PCT0280001")
                .HasColumnOrder(208)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0280001")
                .IsOptional();

            Property(p => p.PCT0280002)
                .HasColumnName("PCT0280002")
                .HasColumnOrder(209)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0280002")
                .IsOptional();

            Property(p => p.PCT0280003)
                .HasColumnName("PCT0280003")
                .HasColumnOrder(210)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0280003")
                .IsOptional();

            Property(p => p.PCT0280004)
                .HasColumnName("PCT0280004")
                .HasColumnOrder(211)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0280004")
                .IsOptional();

            Property(p => p.PCT0280005)
                .HasColumnName("PCT0280005")
                .HasColumnOrder(212)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0280005")
                .IsOptional();

            Property(p => p.PCT0280006)
                .HasColumnName("PCT0280006")
                .HasColumnOrder(213)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0280006")
                .IsOptional();

            Property(p => p.PCT0280007)
                .HasColumnName("PCT0280007")
                .HasColumnOrder(214)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0280007")
                .IsOptional();

            Property(p => p.PCT0280008)
                .HasColumnName("PCT0280008")
                .HasColumnOrder(215)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0280008")
                .IsOptional();

            Property(p => p.PCT0280009)
                .HasColumnName("PCT0280009")
                .HasColumnOrder(216)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0280009")
                .IsOptional();

            Property(p => p.PCT0280010)
                .HasColumnName("PCT0280010")
                .HasColumnOrder(217)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0280010")
                .IsOptional();

            Property(p => p.PCT0280011)
                .HasColumnName("PCT0280011")
                .HasColumnOrder(218)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0280011")
                .IsOptional();

            Property(p => p.PCT0280012)
                .HasColumnName("PCT0280012")
                .HasColumnOrder(219)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0280012")
                .IsOptional();

            Property(p => p.PCT0280013)
                .HasColumnName("PCT0280013")
                .HasColumnOrder(220)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0280013")
                .IsOptional();

            Property(p => p.PCT0280014)
                .HasColumnName("PCT0280014")
                .HasColumnOrder(221)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0280014")
                .IsOptional();

            Property(p => p.PCT0280015)
                .HasColumnName("PCT0280015")
                .HasColumnOrder(222)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0280015")
                .IsOptional();

            Property(p => p.PCT0280016)
                .HasColumnName("PCT0280016")
                .HasColumnOrder(223)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0280016")
                .IsOptional();

            Property(p => p.PCT0280017)
                .HasColumnName("PCT0280017")
                .HasColumnOrder(224)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0280017")
                .IsOptional();

            Property(p => p.PCT0280018)
                .HasColumnName("PCT0280018")
                .HasColumnOrder(225)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0280018")
                .IsOptional();

            Property(p => p.PCT0280019)
                .HasColumnName("PCT0280019")
                .HasColumnOrder(226)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0280019")
                .IsOptional();

            Property(p => p.PCT0280020)
                .HasColumnName("PCT0280020")
                .HasColumnOrder(227)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0280020")
                .IsOptional();

            Property(p => p.PCT0280021)
                .HasColumnName("PCT0280021")
                .HasColumnOrder(228)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0280021")
                .IsOptional();

            Property(p => p.PCT0280022)
                .HasColumnName("PCT0280022")
                .HasColumnOrder(229)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0280022")
                .IsOptional();

            Property(p => p.PCT0280023)
                .HasColumnName("PCT0280023")
                .HasColumnOrder(230)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0280023")
                .IsOptional();

            Property(p => p.PCT0290001)
                .HasColumnName("PCT0290001")
                .HasColumnOrder(231)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0290001")
                .IsOptional();

            Property(p => p.PCT0300001)
                .HasColumnName("PCT0300001")
                .HasColumnOrder(232)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0300001")
                .IsOptional();

            Property(p => p.PCT0300002)
                .HasColumnName("PCT0300002")
                .HasColumnOrder(233)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0300002")
                .IsOptional();

            Property(p => p.PCT0300003)
                .HasColumnName("PCT0300003")
                .HasColumnOrder(234)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0300003")
                .IsOptional();

            Property(p => p.PCT0310001)
                .HasColumnName("PCT0310001")
                .HasColumnOrder(235)
                .HasColumnType("DECIMAL")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0310001")
                .IsOptional();

            Property(p => p.PCT0310002)
                .HasColumnName("PCT0310002")
                .HasColumnOrder(236)
                .HasColumnType("DECIMAL")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0310002")
                .IsOptional();

            Property(p => p.PCT0310003)
                .HasColumnName("PCT0310003")
                .HasColumnOrder(237)
                .HasColumnType("DECIMAL")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0310003")
                .IsOptional();
        }
    }
}
