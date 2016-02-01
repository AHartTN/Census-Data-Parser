#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/31/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SummaryOne_SF1_00005Map.cs
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

    public class SummaryOne_SF1_00005Map : EntityTypeConfiguration<SummaryOne_SF1_00005>
    {
        public SummaryOne_SF1_00005Map()
        {
            ToTable("SF1_00005", "SummaryOne");

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

            Property(p => p.P0150001)
                .HasColumnName("P0150001")
                .HasColumnOrder(5)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0150001")
                .IsOptional();

            Property(p => p.P0150002)
                .HasColumnName("P0150002")
                .HasColumnOrder(6)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0150002")
                .IsOptional();

            Property(p => p.P0150003)
                .HasColumnName("P0150003")
                .HasColumnOrder(7)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0150003")
                .IsOptional();

            Property(p => p.P0150004)
                .HasColumnName("P0150004")
                .HasColumnOrder(8)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0150004")
                .IsOptional();

            Property(p => p.P0150005)
                .HasColumnName("P0150005")
                .HasColumnOrder(9)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0150005")
                .IsOptional();

            Property(p => p.P0150006)
                .HasColumnName("P0150006")
                .HasColumnOrder(10)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0150006")
                .IsOptional();

            Property(p => p.P0150007)
                .HasColumnName("P0150007")
                .HasColumnOrder(11)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0150007")
                .IsOptional();

            Property(p => p.P0150008)
                .HasColumnName("P0150008")
                .HasColumnOrder(12)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0150008")
                .IsOptional();

            Property(p => p.P0150009)
                .HasColumnName("P0150009")
                .HasColumnOrder(13)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0150009")
                .IsOptional();

            Property(p => p.P0150010)
                .HasColumnName("P0150010")
                .HasColumnOrder(14)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0150010")
                .IsOptional();

            Property(p => p.P0150011)
                .HasColumnName("P0150011")
                .HasColumnOrder(15)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0150011")
                .IsOptional();

            Property(p => p.P0150012)
                .HasColumnName("P0150012")
                .HasColumnOrder(16)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0150012")
                .IsOptional();

            Property(p => p.P0150013)
                .HasColumnName("P0150013")
                .HasColumnOrder(17)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0150013")
                .IsOptional();

            Property(p => p.P0150014)
                .HasColumnName("P0150014")
                .HasColumnOrder(18)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0150014")
                .IsOptional();

            Property(p => p.P0150015)
                .HasColumnName("P0150015")
                .HasColumnOrder(19)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0150015")
                .IsOptional();

            Property(p => p.P0150016)
                .HasColumnName("P0150016")
                .HasColumnOrder(20)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0150016")
                .IsOptional();

            Property(p => p.P0150017)
                .HasColumnName("P0150017")
                .HasColumnOrder(21)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0150017")
                .IsOptional();

            Property(p => p.P0160001)
                .HasColumnName("P0160001")
                .HasColumnOrder(22)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0160001")
                .IsOptional();

            Property(p => p.P0160002)
                .HasColumnName("P0160002")
                .HasColumnOrder(23)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0160002")
                .IsOptional();

            Property(p => p.P0160003)
                .HasColumnName("P0160003")
                .HasColumnOrder(24)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0160003")
                .IsOptional();

            Property(p => p.P0170001)
                .HasColumnName("P0170001")
                .HasColumnOrder(25)
                .HasColumnType("DECIMAL")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0170001")
                .IsOptional();

            Property(p => p.P0170002)
                .HasColumnName("P0170002")
                .HasColumnOrder(26)
                .HasColumnType("DECIMAL")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0170002")
                .IsOptional();

            Property(p => p.P0170003)
                .HasColumnName("P0170003")
                .HasColumnOrder(27)
                .HasColumnType("DECIMAL")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0170003")
                .IsOptional();

            Property(p => p.P0180001)
                .HasColumnName("P0180001")
                .HasColumnOrder(28)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0180001")
                .IsOptional();

            Property(p => p.P0180002)
                .HasColumnName("P0180002")
                .HasColumnOrder(29)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0180002")
                .IsOptional();

            Property(p => p.P0180003)
                .HasColumnName("P0180003")
                .HasColumnOrder(30)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0180003")
                .IsOptional();

            Property(p => p.P0180004)
                .HasColumnName("P0180004")
                .HasColumnOrder(31)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0180004")
                .IsOptional();

            Property(p => p.P0180005)
                .HasColumnName("P0180005")
                .HasColumnOrder(32)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0180005")
                .IsOptional();

            Property(p => p.P0180006)
                .HasColumnName("P0180006")
                .HasColumnOrder(33)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0180006")
                .IsOptional();

            Property(p => p.P0180007)
                .HasColumnName("P0180007")
                .HasColumnOrder(34)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0180007")
                .IsOptional();

            Property(p => p.P0180008)
                .HasColumnName("P0180008")
                .HasColumnOrder(35)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0180008")
                .IsOptional();

            Property(p => p.P0180009)
                .HasColumnName("P0180009")
                .HasColumnOrder(36)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0180009")
                .IsOptional();

            Property(p => p.P0190001)
                .HasColumnName("P0190001")
                .HasColumnOrder(37)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0190001")
                .IsOptional();

            Property(p => p.P0190002)
                .HasColumnName("P0190002")
                .HasColumnOrder(38)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0190002")
                .IsOptional();

            Property(p => p.P0190003)
                .HasColumnName("P0190003")
                .HasColumnOrder(39)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0190003")
                .IsOptional();

            Property(p => p.P0190004)
                .HasColumnName("P0190004")
                .HasColumnOrder(40)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0190004")
                .IsOptional();

            Property(p => p.P0190005)
                .HasColumnName("P0190005")
                .HasColumnOrder(41)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0190005")
                .IsOptional();

            Property(p => p.P0190006)
                .HasColumnName("P0190006")
                .HasColumnOrder(42)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0190006")
                .IsOptional();

            Property(p => p.P0190007)
                .HasColumnName("P0190007")
                .HasColumnOrder(43)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0190007")
                .IsOptional();

            Property(p => p.P0190008)
                .HasColumnName("P0190008")
                .HasColumnOrder(44)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0190008")
                .IsOptional();

            Property(p => p.P0190009)
                .HasColumnName("P0190009")
                .HasColumnOrder(45)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0190009")
                .IsOptional();

            Property(p => p.P0190010)
                .HasColumnName("P0190010")
                .HasColumnOrder(46)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0190010")
                .IsOptional();

            Property(p => p.P0190011)
                .HasColumnName("P0190011")
                .HasColumnOrder(47)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0190011")
                .IsOptional();

            Property(p => p.P0190012)
                .HasColumnName("P0190012")
                .HasColumnOrder(48)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0190012")
                .IsOptional();

            Property(p => p.P0190013)
                .HasColumnName("P0190013")
                .HasColumnOrder(49)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0190013")
                .IsOptional();

            Property(p => p.P0190014)
                .HasColumnName("P0190014")
                .HasColumnOrder(50)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0190014")
                .IsOptional();

            Property(p => p.P0190015)
                .HasColumnName("P0190015")
                .HasColumnOrder(51)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0190015")
                .IsOptional();

            Property(p => p.P0190016)
                .HasColumnName("P0190016")
                .HasColumnOrder(52)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0190016")
                .IsOptional();

            Property(p => p.P0190017)
                .HasColumnName("P0190017")
                .HasColumnOrder(53)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0190017")
                .IsOptional();

            Property(p => p.P0190018)
                .HasColumnName("P0190018")
                .HasColumnOrder(54)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0190018")
                .IsOptional();

            Property(p => p.P0190019)
                .HasColumnName("P0190019")
                .HasColumnOrder(55)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0190019")
                .IsOptional();

            Property(p => p.P0200001)
                .HasColumnName("P0200001")
                .HasColumnOrder(56)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200001")
                .IsOptional();

            Property(p => p.P0200002)
                .HasColumnName("P0200002")
                .HasColumnOrder(57)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200002")
                .IsOptional();

            Property(p => p.P0200003)
                .HasColumnName("P0200003")
                .HasColumnOrder(58)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200003")
                .IsOptional();

            Property(p => p.P0200004)
                .HasColumnName("P0200004")
                .HasColumnOrder(59)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200004")
                .IsOptional();

            Property(p => p.P0200005)
                .HasColumnName("P0200005")
                .HasColumnOrder(60)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200005")
                .IsOptional();

            Property(p => p.P0200006)
                .HasColumnName("P0200006")
                .HasColumnOrder(61)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200006")
                .IsOptional();

            Property(p => p.P0200007)
                .HasColumnName("P0200007")
                .HasColumnOrder(62)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200007")
                .IsOptional();

            Property(p => p.P0200008)
                .HasColumnName("P0200008")
                .HasColumnOrder(63)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200008")
                .IsOptional();

            Property(p => p.P0200009)
                .HasColumnName("P0200009")
                .HasColumnOrder(64)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200009")
                .IsOptional();

            Property(p => p.P0200010)
                .HasColumnName("P0200010")
                .HasColumnOrder(65)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200010")
                .IsOptional();

            Property(p => p.P0200011)
                .HasColumnName("P0200011")
                .HasColumnOrder(66)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200011")
                .IsOptional();

            Property(p => p.P0200012)
                .HasColumnName("P0200012")
                .HasColumnOrder(67)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200012")
                .IsOptional();

            Property(p => p.P0200013)
                .HasColumnName("P0200013")
                .HasColumnOrder(68)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200013")
                .IsOptional();

            Property(p => p.P0200014)
                .HasColumnName("P0200014")
                .HasColumnOrder(69)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200014")
                .IsOptional();

            Property(p => p.P0200015)
                .HasColumnName("P0200015")
                .HasColumnOrder(70)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200015")
                .IsOptional();

            Property(p => p.P0200016)
                .HasColumnName("P0200016")
                .HasColumnOrder(71)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200016")
                .IsOptional();

            Property(p => p.P0200017)
                .HasColumnName("P0200017")
                .HasColumnOrder(72)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200017")
                .IsOptional();

            Property(p => p.P0200018)
                .HasColumnName("P0200018")
                .HasColumnOrder(73)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200018")
                .IsOptional();

            Property(p => p.P0200019)
                .HasColumnName("P0200019")
                .HasColumnOrder(74)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200019")
                .IsOptional();

            Property(p => p.P0200020)
                .HasColumnName("P0200020")
                .HasColumnOrder(75)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200020")
                .IsOptional();

            Property(p => p.P0200021)
                .HasColumnName("P0200021")
                .HasColumnOrder(76)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200021")
                .IsOptional();

            Property(p => p.P0200022)
                .HasColumnName("P0200022")
                .HasColumnOrder(77)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200022")
                .IsOptional();

            Property(p => p.P0200023)
                .HasColumnName("P0200023")
                .HasColumnOrder(78)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200023")
                .IsOptional();

            Property(p => p.P0200024)
                .HasColumnName("P0200024")
                .HasColumnOrder(79)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200024")
                .IsOptional();

            Property(p => p.P0200025)
                .HasColumnName("P0200025")
                .HasColumnOrder(80)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200025")
                .IsOptional();

            Property(p => p.P0200026)
                .HasColumnName("P0200026")
                .HasColumnOrder(81)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200026")
                .IsOptional();

            Property(p => p.P0200027)
                .HasColumnName("P0200027")
                .HasColumnOrder(82)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200027")
                .IsOptional();

            Property(p => p.P0200028)
                .HasColumnName("P0200028")
                .HasColumnOrder(83)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200028")
                .IsOptional();

            Property(p => p.P0200029)
                .HasColumnName("P0200029")
                .HasColumnOrder(84)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200029")
                .IsOptional();

            Property(p => p.P0200030)
                .HasColumnName("P0200030")
                .HasColumnOrder(85)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200030")
                .IsOptional();

            Property(p => p.P0200031)
                .HasColumnName("P0200031")
                .HasColumnOrder(86)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200031")
                .IsOptional();

            Property(p => p.P0200032)
                .HasColumnName("P0200032")
                .HasColumnOrder(87)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200032")
                .IsOptional();

            Property(p => p.P0200033)
                .HasColumnName("P0200033")
                .HasColumnOrder(88)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200033")
                .IsOptional();

            Property(p => p.P0200034)
                .HasColumnName("P0200034")
                .HasColumnOrder(89)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0200034")
                .IsOptional();

            Property(p => p.P0210001)
                .HasColumnName("P0210001")
                .HasColumnOrder(90)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210001")
                .IsOptional();

            Property(p => p.P0210002)
                .HasColumnName("P0210002")
                .HasColumnOrder(91)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210002")
                .IsOptional();

            Property(p => p.P0210003)
                .HasColumnName("P0210003")
                .HasColumnOrder(92)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210003")
                .IsOptional();

            Property(p => p.P0210004)
                .HasColumnName("P0210004")
                .HasColumnOrder(93)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210004")
                .IsOptional();

            Property(p => p.P0210005)
                .HasColumnName("P0210005")
                .HasColumnOrder(94)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210005")
                .IsOptional();

            Property(p => p.P0210006)
                .HasColumnName("P0210006")
                .HasColumnOrder(95)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210006")
                .IsOptional();

            Property(p => p.P0210007)
                .HasColumnName("P0210007")
                .HasColumnOrder(96)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210007")
                .IsOptional();

            Property(p => p.P0210008)
                .HasColumnName("P0210008")
                .HasColumnOrder(97)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210008")
                .IsOptional();

            Property(p => p.P0210009)
                .HasColumnName("P0210009")
                .HasColumnOrder(98)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210009")
                .IsOptional();

            Property(p => p.P0210010)
                .HasColumnName("P0210010")
                .HasColumnOrder(99)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210010")
                .IsOptional();

            Property(p => p.P0210011)
                .HasColumnName("P0210011")
                .HasColumnOrder(100)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210011")
                .IsOptional();

            Property(p => p.P0210012)
                .HasColumnName("P0210012")
                .HasColumnOrder(101)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210012")
                .IsOptional();

            Property(p => p.P0210013)
                .HasColumnName("P0210013")
                .HasColumnOrder(102)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210013")
                .IsOptional();

            Property(p => p.P0210014)
                .HasColumnName("P0210014")
                .HasColumnOrder(103)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210014")
                .IsOptional();

            Property(p => p.P0210015)
                .HasColumnName("P0210015")
                .HasColumnOrder(104)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210015")
                .IsOptional();

            Property(p => p.P0210016)
                .HasColumnName("P0210016")
                .HasColumnOrder(105)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210016")
                .IsOptional();

            Property(p => p.P0210017)
                .HasColumnName("P0210017")
                .HasColumnOrder(106)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210017")
                .IsOptional();

            Property(p => p.P0210018)
                .HasColumnName("P0210018")
                .HasColumnOrder(107)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210018")
                .IsOptional();

            Property(p => p.P0210019)
                .HasColumnName("P0210019")
                .HasColumnOrder(108)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210019")
                .IsOptional();

            Property(p => p.P0210020)
                .HasColumnName("P0210020")
                .HasColumnOrder(109)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210020")
                .IsOptional();

            Property(p => p.P0210021)
                .HasColumnName("P0210021")
                .HasColumnOrder(110)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210021")
                .IsOptional();

            Property(p => p.P0210022)
                .HasColumnName("P0210022")
                .HasColumnOrder(111)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210022")
                .IsOptional();

            Property(p => p.P0210023)
                .HasColumnName("P0210023")
                .HasColumnOrder(112)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210023")
                .IsOptional();

            Property(p => p.P0210024)
                .HasColumnName("P0210024")
                .HasColumnOrder(113)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210024")
                .IsOptional();

            Property(p => p.P0210025)
                .HasColumnName("P0210025")
                .HasColumnOrder(114)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210025")
                .IsOptional();

            Property(p => p.P0210026)
                .HasColumnName("P0210026")
                .HasColumnOrder(115)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210026")
                .IsOptional();

            Property(p => p.P0210027)
                .HasColumnName("P0210027")
                .HasColumnOrder(116)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210027")
                .IsOptional();

            Property(p => p.P0210028)
                .HasColumnName("P0210028")
                .HasColumnOrder(117)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210028")
                .IsOptional();

            Property(p => p.P0210029)
                .HasColumnName("P0210029")
                .HasColumnOrder(118)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210029")
                .IsOptional();

            Property(p => p.P0210030)
                .HasColumnName("P0210030")
                .HasColumnOrder(119)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210030")
                .IsOptional();

            Property(p => p.P0210031)
                .HasColumnName("P0210031")
                .HasColumnOrder(120)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0210031")
                .IsOptional();

            Property(p => p.P0220001)
                .HasColumnName("P0220001")
                .HasColumnOrder(121)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0220001")
                .IsOptional();

            Property(p => p.P0220002)
                .HasColumnName("P0220002")
                .HasColumnOrder(122)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0220002")
                .IsOptional();

            Property(p => p.P0220003)
                .HasColumnName("P0220003")
                .HasColumnOrder(123)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0220003")
                .IsOptional();

            Property(p => p.P0220004)
                .HasColumnName("P0220004")
                .HasColumnOrder(124)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0220004")
                .IsOptional();

            Property(p => p.P0220005)
                .HasColumnName("P0220005")
                .HasColumnOrder(125)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0220005")
                .IsOptional();

            Property(p => p.P0220006)
                .HasColumnName("P0220006")
                .HasColumnOrder(126)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0220006")
                .IsOptional();

            Property(p => p.P0220007)
                .HasColumnName("P0220007")
                .HasColumnOrder(127)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0220007")
                .IsOptional();

            Property(p => p.P0220008)
                .HasColumnName("P0220008")
                .HasColumnOrder(128)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0220008")
                .IsOptional();

            Property(p => p.P0220009)
                .HasColumnName("P0220009")
                .HasColumnOrder(129)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0220009")
                .IsOptional();

            Property(p => p.P0220010)
                .HasColumnName("P0220010")
                .HasColumnOrder(130)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0220010")
                .IsOptional();

            Property(p => p.P0220011)
                .HasColumnName("P0220011")
                .HasColumnOrder(131)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0220011")
                .IsOptional();

            Property(p => p.P0220012)
                .HasColumnName("P0220012")
                .HasColumnOrder(132)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0220012")
                .IsOptional();

            Property(p => p.P0220013)
                .HasColumnName("P0220013")
                .HasColumnOrder(133)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0220013")
                .IsOptional();

            Property(p => p.P0220014)
                .HasColumnName("P0220014")
                .HasColumnOrder(134)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0220014")
                .IsOptional();

            Property(p => p.P0220015)
                .HasColumnName("P0220015")
                .HasColumnOrder(135)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0220015")
                .IsOptional();

            Property(p => p.P0220016)
                .HasColumnName("P0220016")
                .HasColumnOrder(136)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0220016")
                .IsOptional();

            Property(p => p.P0220017)
                .HasColumnName("P0220017")
                .HasColumnOrder(137)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0220017")
                .IsOptional();

            Property(p => p.P0220018)
                .HasColumnName("P0220018")
                .HasColumnOrder(138)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0220018")
                .IsOptional();

            Property(p => p.P0220019)
                .HasColumnName("P0220019")
                .HasColumnOrder(139)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0220019")
                .IsOptional();

            Property(p => p.P0220020)
                .HasColumnName("P0220020")
                .HasColumnOrder(140)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0220020")
                .IsOptional();

            Property(p => p.P0220021)
                .HasColumnName("P0220021")
                .HasColumnOrder(141)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0220021")
                .IsOptional();

            Property(p => p.P0230001)
                .HasColumnName("P0230001")
                .HasColumnOrder(142)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0230001")
                .IsOptional();

            Property(p => p.P0230002)
                .HasColumnName("P0230002")
                .HasColumnOrder(143)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0230002")
                .IsOptional();

            Property(p => p.P0230003)
                .HasColumnName("P0230003")
                .HasColumnOrder(144)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0230003")
                .IsOptional();

            Property(p => p.P0230004)
                .HasColumnName("P0230004")
                .HasColumnOrder(145)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0230004")
                .IsOptional();

            Property(p => p.P0230005)
                .HasColumnName("P0230005")
                .HasColumnOrder(146)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0230005")
                .IsOptional();

            Property(p => p.P0230006)
                .HasColumnName("P0230006")
                .HasColumnOrder(147)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0230006")
                .IsOptional();

            Property(p => p.P0230007)
                .HasColumnName("P0230007")
                .HasColumnOrder(148)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0230007")
                .IsOptional();

            Property(p => p.P0230008)
                .HasColumnName("P0230008")
                .HasColumnOrder(149)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0230008")
                .IsOptional();

            Property(p => p.P0230009)
                .HasColumnName("P0230009")
                .HasColumnOrder(150)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0230009")
                .IsOptional();

            Property(p => p.P0230010)
                .HasColumnName("P0230010")
                .HasColumnOrder(151)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0230010")
                .IsOptional();

            Property(p => p.P0230011)
                .HasColumnName("P0230011")
                .HasColumnOrder(152)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0230011")
                .IsOptional();

            Property(p => p.P0230012)
                .HasColumnName("P0230012")
                .HasColumnOrder(153)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0230012")
                .IsOptional();

            Property(p => p.P0230013)
                .HasColumnName("P0230013")
                .HasColumnOrder(154)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0230013")
                .IsOptional();

            Property(p => p.P0230014)
                .HasColumnName("P0230014")
                .HasColumnOrder(155)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0230014")
                .IsOptional();

            Property(p => p.P0230015)
                .HasColumnName("P0230015")
                .HasColumnOrder(156)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0230015")
                .IsOptional();

            Property(p => p.P0240001)
                .HasColumnName("P0240001")
                .HasColumnOrder(157)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0240001")
                .IsOptional();

            Property(p => p.P0240002)
                .HasColumnName("P0240002")
                .HasColumnOrder(158)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0240002")
                .IsOptional();

            Property(p => p.P0240003)
                .HasColumnName("P0240003")
                .HasColumnOrder(159)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0240003")
                .IsOptional();

            Property(p => p.P0240004)
                .HasColumnName("P0240004")
                .HasColumnOrder(160)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0240004")
                .IsOptional();

            Property(p => p.P0240005)
                .HasColumnName("P0240005")
                .HasColumnOrder(161)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0240005")
                .IsOptional();

            Property(p => p.P0240006)
                .HasColumnName("P0240006")
                .HasColumnOrder(162)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0240006")
                .IsOptional();

            Property(p => p.P0240007)
                .HasColumnName("P0240007")
                .HasColumnOrder(163)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0240007")
                .IsOptional();

            Property(p => p.P0240008)
                .HasColumnName("P0240008")
                .HasColumnOrder(164)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0240008")
                .IsOptional();

            Property(p => p.P0240009)
                .HasColumnName("P0240009")
                .HasColumnOrder(165)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0240009")
                .IsOptional();

            Property(p => p.P0240010)
                .HasColumnName("P0240010")
                .HasColumnOrder(166)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0240010")
                .IsOptional();

            Property(p => p.P0240011)
                .HasColumnName("P0240011")
                .HasColumnOrder(167)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0240011")
                .IsOptional();

            Property(p => p.P0250001)
                .HasColumnName("P0250001")
                .HasColumnOrder(168)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0250001")
                .IsOptional();

            Property(p => p.P0250002)
                .HasColumnName("P0250002")
                .HasColumnOrder(169)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0250002")
                .IsOptional();

            Property(p => p.P0250003)
                .HasColumnName("P0250003")
                .HasColumnOrder(170)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0250003")
                .IsOptional();

            Property(p => p.P0250004)
                .HasColumnName("P0250004")
                .HasColumnOrder(171)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0250004")
                .IsOptional();

            Property(p => p.P0250005)
                .HasColumnName("P0250005")
                .HasColumnOrder(172)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0250005")
                .IsOptional();

            Property(p => p.P0250006)
                .HasColumnName("P0250006")
                .HasColumnOrder(173)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0250006")
                .IsOptional();

            Property(p => p.P0250007)
                .HasColumnName("P0250007")
                .HasColumnOrder(174)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0250007")
                .IsOptional();

            Property(p => p.P0250008)
                .HasColumnName("P0250008")
                .HasColumnOrder(175)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0250008")
                .IsOptional();

            Property(p => p.P0250009)
                .HasColumnName("P0250009")
                .HasColumnOrder(176)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0250009")
                .IsOptional();

            Property(p => p.P0250010)
                .HasColumnName("P0250010")
                .HasColumnOrder(177)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0250010")
                .IsOptional();

            Property(p => p.P0250011)
                .HasColumnName("P0250011")
                .HasColumnOrder(178)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0250011")
                .IsOptional();

            Property(p => p.P0260001)
                .HasColumnName("P0260001")
                .HasColumnOrder(179)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0260001")
                .IsOptional();

            Property(p => p.P0260002)
                .HasColumnName("P0260002")
                .HasColumnOrder(180)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0260002")
                .IsOptional();

            Property(p => p.P0260003)
                .HasColumnName("P0260003")
                .HasColumnOrder(181)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0260003")
                .IsOptional();

            Property(p => p.P0260004)
                .HasColumnName("P0260004")
                .HasColumnOrder(182)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0260004")
                .IsOptional();

            Property(p => p.P0260005)
                .HasColumnName("P0260005")
                .HasColumnOrder(183)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0260005")
                .IsOptional();

            Property(p => p.P0260006)
                .HasColumnName("P0260006")
                .HasColumnOrder(184)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0260006")
                .IsOptional();

            Property(p => p.P0260007)
                .HasColumnName("P0260007")
                .HasColumnOrder(185)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0260007")
                .IsOptional();

            Property(p => p.P0260008)
                .HasColumnName("P0260008")
                .HasColumnOrder(186)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0260008")
                .IsOptional();

            Property(p => p.P0260009)
                .HasColumnName("P0260009")
                .HasColumnOrder(187)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0260009")
                .IsOptional();

            Property(p => p.P0260010)
                .HasColumnName("P0260010")
                .HasColumnOrder(188)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0260010")
                .IsOptional();

            Property(p => p.P0260011)
                .HasColumnName("P0260011")
                .HasColumnOrder(189)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0260011")
                .IsOptional();

            Property(p => p.P0270001)
                .HasColumnName("P0270001")
                .HasColumnOrder(190)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0270001")
                .IsOptional();

            Property(p => p.P0270002)
                .HasColumnName("P0270002")
                .HasColumnOrder(191)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0270002")
                .IsOptional();

            Property(p => p.P0270003)
                .HasColumnName("P0270003")
                .HasColumnOrder(192)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0270003")
                .IsOptional();

            Property(p => p.P0280001)
                .HasColumnName("P0280001")
                .HasColumnOrder(193)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0280001")
                .IsOptional();

            Property(p => p.P0280002)
                .HasColumnName("P0280002")
                .HasColumnOrder(194)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0280002")
                .IsOptional();

            Property(p => p.P0280003)
                .HasColumnName("P0280003")
                .HasColumnOrder(195)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0280003")
                .IsOptional();

            Property(p => p.P0280004)
                .HasColumnName("P0280004")
                .HasColumnOrder(196)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0280004")
                .IsOptional();

            Property(p => p.P0280005)
                .HasColumnName("P0280005")
                .HasColumnOrder(197)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0280005")
                .IsOptional();

            Property(p => p.P0280006)
                .HasColumnName("P0280006")
                .HasColumnOrder(198)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0280006")
                .IsOptional();

            Property(p => p.P0280007)
                .HasColumnName("P0280007")
                .HasColumnOrder(199)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0280007")
                .IsOptional();

            Property(p => p.P0280008)
                .HasColumnName("P0280008")
                .HasColumnOrder(200)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0280008")
                .IsOptional();

            Property(p => p.P0280009)
                .HasColumnName("P0280009")
                .HasColumnOrder(201)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0280009")
                .IsOptional();

            Property(p => p.P0280010)
                .HasColumnName("P0280010")
                .HasColumnOrder(202)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0280010")
                .IsOptional();

            Property(p => p.P0280011)
                .HasColumnName("P0280011")
                .HasColumnOrder(203)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0280011")
                .IsOptional();

            Property(p => p.P0280012)
                .HasColumnName("P0280012")
                .HasColumnOrder(204)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0280012")
                .IsOptional();

            Property(p => p.P0280013)
                .HasColumnName("P0280013")
                .HasColumnOrder(205)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0280013")
                .IsOptional();

            Property(p => p.P0280014)
                .HasColumnName("P0280014")
                .HasColumnOrder(206)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0280014")
                .IsOptional();

            Property(p => p.P0280015)
                .HasColumnName("P0280015")
                .HasColumnOrder(207)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0280015")
                .IsOptional();

            Property(p => p.P0280016)
                .HasColumnName("P0280016")
                .HasColumnOrder(208)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0280016")
                .IsOptional();

            Property(p => p.P0290001)
                .HasColumnName("P0290001")
                .HasColumnOrder(209)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290001")
                .IsOptional();

            Property(p => p.P0290002)
                .HasColumnName("P0290002")
                .HasColumnOrder(210)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290002")
                .IsOptional();

            Property(p => p.P0290003)
                .HasColumnName("P0290003")
                .HasColumnOrder(211)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290003")
                .IsOptional();

            Property(p => p.P0290004)
                .HasColumnName("P0290004")
                .HasColumnOrder(212)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290004")
                .IsOptional();

            Property(p => p.P0290005)
                .HasColumnName("P0290005")
                .HasColumnOrder(213)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290005")
                .IsOptional();

            Property(p => p.P0290006)
                .HasColumnName("P0290006")
                .HasColumnOrder(214)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290006")
                .IsOptional();

            Property(p => p.P0290007)
                .HasColumnName("P0290007")
                .HasColumnOrder(215)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290007")
                .IsOptional();

            Property(p => p.P0290008)
                .HasColumnName("P0290008")
                .HasColumnOrder(216)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290008")
                .IsOptional();

            Property(p => p.P0290009)
                .HasColumnName("P0290009")
                .HasColumnOrder(217)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290009")
                .IsOptional();

            Property(p => p.P0290010)
                .HasColumnName("P0290010")
                .HasColumnOrder(218)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290010")
                .IsOptional();

            Property(p => p.P0290011)
                .HasColumnName("P0290011")
                .HasColumnOrder(219)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290011")
                .IsOptional();

            Property(p => p.P0290012)
                .HasColumnName("P0290012")
                .HasColumnOrder(220)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290012")
                .IsOptional();

            Property(p => p.P0290013)
                .HasColumnName("P0290013")
                .HasColumnOrder(221)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290013")
                .IsOptional();

            Property(p => p.P0290014)
                .HasColumnName("P0290014")
                .HasColumnOrder(222)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290014")
                .IsOptional();

            Property(p => p.P0290015)
                .HasColumnName("P0290015")
                .HasColumnOrder(223)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290015")
                .IsOptional();

            Property(p => p.P0290016)
                .HasColumnName("P0290016")
                .HasColumnOrder(224)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290016")
                .IsOptional();

            Property(p => p.P0290017)
                .HasColumnName("P0290017")
                .HasColumnOrder(225)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290017")
                .IsOptional();

            Property(p => p.P0290018)
                .HasColumnName("P0290018")
                .HasColumnOrder(226)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290018")
                .IsOptional();

            Property(p => p.P0290019)
                .HasColumnName("P0290019")
                .HasColumnOrder(227)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290019")
                .IsOptional();

            Property(p => p.P0290020)
                .HasColumnName("P0290020")
                .HasColumnOrder(228)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290020")
                .IsOptional();

            Property(p => p.P0290021)
                .HasColumnName("P0290021")
                .HasColumnOrder(229)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290021")
                .IsOptional();

            Property(p => p.P0290022)
                .HasColumnName("P0290022")
                .HasColumnOrder(230)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290022")
                .IsOptional();

            Property(p => p.P0290023)
                .HasColumnName("P0290023")
                .HasColumnOrder(231)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290023")
                .IsOptional();

            Property(p => p.P0290024)
                .HasColumnName("P0290024")
                .HasColumnOrder(232)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290024")
                .IsOptional();

            Property(p => p.P0290025)
                .HasColumnName("P0290025")
                .HasColumnOrder(233)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290025")
                .IsOptional();

            Property(p => p.P0290026)
                .HasColumnName("P0290026")
                .HasColumnOrder(234)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290026")
                .IsOptional();

            Property(p => p.P0290027)
                .HasColumnName("P0290027")
                .HasColumnOrder(235)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290027")
                .IsOptional();

            Property(p => p.P0290028)
                .HasColumnName("P0290028")
                .HasColumnOrder(236)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0290028")
                .IsOptional();

            Property(p => p.P0300001)
                .HasColumnName("P0300001")
                .HasColumnOrder(237)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0300001")
                .IsOptional();

            Property(p => p.P0300002)
                .HasColumnName("P0300002")
                .HasColumnOrder(238)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0300002")
                .IsOptional();

            Property(p => p.P0300003)
                .HasColumnName("P0300003")
                .HasColumnOrder(239)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0300003")
                .IsOptional();

            Property(p => p.P0300004)
                .HasColumnName("P0300004")
                .HasColumnOrder(240)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0300004")
                .IsOptional();

            Property(p => p.P0300005)
                .HasColumnName("P0300005")
                .HasColumnOrder(241)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0300005")
                .IsOptional();

            Property(p => p.P0300006)
                .HasColumnName("P0300006")
                .HasColumnOrder(242)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0300006")
                .IsOptional();

            Property(p => p.P0300007)
                .HasColumnName("P0300007")
                .HasColumnOrder(243)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0300007")
                .IsOptional();

            Property(p => p.P0300008)
                .HasColumnName("P0300008")
                .HasColumnOrder(244)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0300008")
                .IsOptional();

            Property(p => p.P0300009)
                .HasColumnName("P0300009")
                .HasColumnOrder(245)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0300009")
                .IsOptional();

            Property(p => p.P0300010)
                .HasColumnName("P0300010")
                .HasColumnOrder(246)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0300010")
                .IsOptional();

            Property(p => p.P0300011)
                .HasColumnName("P0300011")
                .HasColumnOrder(247)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0300011")
                .IsOptional();

            Property(p => p.P0300012)
                .HasColumnName("P0300012")
                .HasColumnOrder(248)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0300012")
                .IsOptional();

            Property(p => p.P0300013)
                .HasColumnName("P0300013")
                .HasColumnOrder(249)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("P0300013")
                .IsOptional();
        }
    }
}
