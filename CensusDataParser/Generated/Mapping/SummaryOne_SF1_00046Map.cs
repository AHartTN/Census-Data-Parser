#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/31/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SummaryOne_SF1_00046Map.cs
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

    public class SummaryOne_SF1_00046Map : EntityTypeConfiguration<SummaryOne_SF1_00046>
    {
        public SummaryOne_SF1_00046Map()
        {
            ToTable("SF1_00046", "SummaryOne");

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

            Property(p => p.H017D0001)
                .HasColumnName("H017D0001")
                .HasColumnOrder(5)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017D0001")
                .IsOptional();

            Property(p => p.H017D0002)
                .HasColumnName("H017D0002")
                .HasColumnOrder(6)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017D0002")
                .IsOptional();

            Property(p => p.H017D0003)
                .HasColumnName("H017D0003")
                .HasColumnOrder(7)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017D0003")
                .IsOptional();

            Property(p => p.H017D0004)
                .HasColumnName("H017D0004")
                .HasColumnOrder(8)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017D0004")
                .IsOptional();

            Property(p => p.H017D0005)
                .HasColumnName("H017D0005")
                .HasColumnOrder(9)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017D0005")
                .IsOptional();

            Property(p => p.H017D0006)
                .HasColumnName("H017D0006")
                .HasColumnOrder(10)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017D0006")
                .IsOptional();

            Property(p => p.H017D0007)
                .HasColumnName("H017D0007")
                .HasColumnOrder(11)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017D0007")
                .IsOptional();

            Property(p => p.H017D0008)
                .HasColumnName("H017D0008")
                .HasColumnOrder(12)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017D0008")
                .IsOptional();

            Property(p => p.H017D0009)
                .HasColumnName("H017D0009")
                .HasColumnOrder(13)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017D0009")
                .IsOptional();

            Property(p => p.H017D0010)
                .HasColumnName("H017D0010")
                .HasColumnOrder(14)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017D0010")
                .IsOptional();

            Property(p => p.H017D0011)
                .HasColumnName("H017D0011")
                .HasColumnOrder(15)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017D0011")
                .IsOptional();

            Property(p => p.H017D0012)
                .HasColumnName("H017D0012")
                .HasColumnOrder(16)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017D0012")
                .IsOptional();

            Property(p => p.H017D0013)
                .HasColumnName("H017D0013")
                .HasColumnOrder(17)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017D0013")
                .IsOptional();

            Property(p => p.H017D0014)
                .HasColumnName("H017D0014")
                .HasColumnOrder(18)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017D0014")
                .IsOptional();

            Property(p => p.H017D0015)
                .HasColumnName("H017D0015")
                .HasColumnOrder(19)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017D0015")
                .IsOptional();

            Property(p => p.H017D0016)
                .HasColumnName("H017D0016")
                .HasColumnOrder(20)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017D0016")
                .IsOptional();

            Property(p => p.H017D0017)
                .HasColumnName("H017D0017")
                .HasColumnOrder(21)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017D0017")
                .IsOptional();

            Property(p => p.H017D0018)
                .HasColumnName("H017D0018")
                .HasColumnOrder(22)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017D0018")
                .IsOptional();

            Property(p => p.H017D0019)
                .HasColumnName("H017D0019")
                .HasColumnOrder(23)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017D0019")
                .IsOptional();

            Property(p => p.H017D0020)
                .HasColumnName("H017D0020")
                .HasColumnOrder(24)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017D0020")
                .IsOptional();

            Property(p => p.H017D0021)
                .HasColumnName("H017D0021")
                .HasColumnOrder(25)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017D0021")
                .IsOptional();

            Property(p => p.H017E0001)
                .HasColumnName("H017E0001")
                .HasColumnOrder(26)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017E0001")
                .IsOptional();

            Property(p => p.H017E0002)
                .HasColumnName("H017E0002")
                .HasColumnOrder(27)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017E0002")
                .IsOptional();

            Property(p => p.H017E0003)
                .HasColumnName("H017E0003")
                .HasColumnOrder(28)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017E0003")
                .IsOptional();

            Property(p => p.H017E0004)
                .HasColumnName("H017E0004")
                .HasColumnOrder(29)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017E0004")
                .IsOptional();

            Property(p => p.H017E0005)
                .HasColumnName("H017E0005")
                .HasColumnOrder(30)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017E0005")
                .IsOptional();

            Property(p => p.H017E0006)
                .HasColumnName("H017E0006")
                .HasColumnOrder(31)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017E0006")
                .IsOptional();

            Property(p => p.H017E0007)
                .HasColumnName("H017E0007")
                .HasColumnOrder(32)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017E0007")
                .IsOptional();

            Property(p => p.H017E0008)
                .HasColumnName("H017E0008")
                .HasColumnOrder(33)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017E0008")
                .IsOptional();

            Property(p => p.H017E0009)
                .HasColumnName("H017E0009")
                .HasColumnOrder(34)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017E0009")
                .IsOptional();

            Property(p => p.H017E0010)
                .HasColumnName("H017E0010")
                .HasColumnOrder(35)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017E0010")
                .IsOptional();

            Property(p => p.H017E0011)
                .HasColumnName("H017E0011")
                .HasColumnOrder(36)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017E0011")
                .IsOptional();

            Property(p => p.H017E0012)
                .HasColumnName("H017E0012")
                .HasColumnOrder(37)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017E0012")
                .IsOptional();

            Property(p => p.H017E0013)
                .HasColumnName("H017E0013")
                .HasColumnOrder(38)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017E0013")
                .IsOptional();

            Property(p => p.H017E0014)
                .HasColumnName("H017E0014")
                .HasColumnOrder(39)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017E0014")
                .IsOptional();

            Property(p => p.H017E0015)
                .HasColumnName("H017E0015")
                .HasColumnOrder(40)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017E0015")
                .IsOptional();

            Property(p => p.H017E0016)
                .HasColumnName("H017E0016")
                .HasColumnOrder(41)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017E0016")
                .IsOptional();

            Property(p => p.H017E0017)
                .HasColumnName("H017E0017")
                .HasColumnOrder(42)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017E0017")
                .IsOptional();

            Property(p => p.H017E0018)
                .HasColumnName("H017E0018")
                .HasColumnOrder(43)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017E0018")
                .IsOptional();

            Property(p => p.H017E0019)
                .HasColumnName("H017E0019")
                .HasColumnOrder(44)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017E0019")
                .IsOptional();

            Property(p => p.H017E0020)
                .HasColumnName("H017E0020")
                .HasColumnOrder(45)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017E0020")
                .IsOptional();

            Property(p => p.H017E0021)
                .HasColumnName("H017E0021")
                .HasColumnOrder(46)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017E0021")
                .IsOptional();

            Property(p => p.H017F0001)
                .HasColumnName("H017F0001")
                .HasColumnOrder(47)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017F0001")
                .IsOptional();

            Property(p => p.H017F0002)
                .HasColumnName("H017F0002")
                .HasColumnOrder(48)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017F0002")
                .IsOptional();

            Property(p => p.H017F0003)
                .HasColumnName("H017F0003")
                .HasColumnOrder(49)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017F0003")
                .IsOptional();

            Property(p => p.H017F0004)
                .HasColumnName("H017F0004")
                .HasColumnOrder(50)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017F0004")
                .IsOptional();

            Property(p => p.H017F0005)
                .HasColumnName("H017F0005")
                .HasColumnOrder(51)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017F0005")
                .IsOptional();

            Property(p => p.H017F0006)
                .HasColumnName("H017F0006")
                .HasColumnOrder(52)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017F0006")
                .IsOptional();

            Property(p => p.H017F0007)
                .HasColumnName("H017F0007")
                .HasColumnOrder(53)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017F0007")
                .IsOptional();

            Property(p => p.H017F0008)
                .HasColumnName("H017F0008")
                .HasColumnOrder(54)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017F0008")
                .IsOptional();

            Property(p => p.H017F0009)
                .HasColumnName("H017F0009")
                .HasColumnOrder(55)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017F0009")
                .IsOptional();

            Property(p => p.H017F0010)
                .HasColumnName("H017F0010")
                .HasColumnOrder(56)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017F0010")
                .IsOptional();

            Property(p => p.H017F0011)
                .HasColumnName("H017F0011")
                .HasColumnOrder(57)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017F0011")
                .IsOptional();

            Property(p => p.H017F0012)
                .HasColumnName("H017F0012")
                .HasColumnOrder(58)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017F0012")
                .IsOptional();

            Property(p => p.H017F0013)
                .HasColumnName("H017F0013")
                .HasColumnOrder(59)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017F0013")
                .IsOptional();

            Property(p => p.H017F0014)
                .HasColumnName("H017F0014")
                .HasColumnOrder(60)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017F0014")
                .IsOptional();

            Property(p => p.H017F0015)
                .HasColumnName("H017F0015")
                .HasColumnOrder(61)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017F0015")
                .IsOptional();

            Property(p => p.H017F0016)
                .HasColumnName("H017F0016")
                .HasColumnOrder(62)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017F0016")
                .IsOptional();

            Property(p => p.H017F0017)
                .HasColumnName("H017F0017")
                .HasColumnOrder(63)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017F0017")
                .IsOptional();

            Property(p => p.H017F0018)
                .HasColumnName("H017F0018")
                .HasColumnOrder(64)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017F0018")
                .IsOptional();

            Property(p => p.H017F0019)
                .HasColumnName("H017F0019")
                .HasColumnOrder(65)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017F0019")
                .IsOptional();

            Property(p => p.H017F0020)
                .HasColumnName("H017F0020")
                .HasColumnOrder(66)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017F0020")
                .IsOptional();

            Property(p => p.H017F0021)
                .HasColumnName("H017F0021")
                .HasColumnOrder(67)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017F0021")
                .IsOptional();

            Property(p => p.H017G0001)
                .HasColumnName("H017G0001")
                .HasColumnOrder(68)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017G0001")
                .IsOptional();

            Property(p => p.H017G0002)
                .HasColumnName("H017G0002")
                .HasColumnOrder(69)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017G0002")
                .IsOptional();

            Property(p => p.H017G0003)
                .HasColumnName("H017G0003")
                .HasColumnOrder(70)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017G0003")
                .IsOptional();

            Property(p => p.H017G0004)
                .HasColumnName("H017G0004")
                .HasColumnOrder(71)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017G0004")
                .IsOptional();

            Property(p => p.H017G0005)
                .HasColumnName("H017G0005")
                .HasColumnOrder(72)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017G0005")
                .IsOptional();

            Property(p => p.H017G0006)
                .HasColumnName("H017G0006")
                .HasColumnOrder(73)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017G0006")
                .IsOptional();

            Property(p => p.H017G0007)
                .HasColumnName("H017G0007")
                .HasColumnOrder(74)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017G0007")
                .IsOptional();

            Property(p => p.H017G0008)
                .HasColumnName("H017G0008")
                .HasColumnOrder(75)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017G0008")
                .IsOptional();

            Property(p => p.H017G0009)
                .HasColumnName("H017G0009")
                .HasColumnOrder(76)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017G0009")
                .IsOptional();

            Property(p => p.H017G0010)
                .HasColumnName("H017G0010")
                .HasColumnOrder(77)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017G0010")
                .IsOptional();

            Property(p => p.H017G0011)
                .HasColumnName("H017G0011")
                .HasColumnOrder(78)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017G0011")
                .IsOptional();

            Property(p => p.H017G0012)
                .HasColumnName("H017G0012")
                .HasColumnOrder(79)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017G0012")
                .IsOptional();

            Property(p => p.H017G0013)
                .HasColumnName("H017G0013")
                .HasColumnOrder(80)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017G0013")
                .IsOptional();

            Property(p => p.H017G0014)
                .HasColumnName("H017G0014")
                .HasColumnOrder(81)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017G0014")
                .IsOptional();

            Property(p => p.H017G0015)
                .HasColumnName("H017G0015")
                .HasColumnOrder(82)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017G0015")
                .IsOptional();

            Property(p => p.H017G0016)
                .HasColumnName("H017G0016")
                .HasColumnOrder(83)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017G0016")
                .IsOptional();

            Property(p => p.H017G0017)
                .HasColumnName("H017G0017")
                .HasColumnOrder(84)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017G0017")
                .IsOptional();

            Property(p => p.H017G0018)
                .HasColumnName("H017G0018")
                .HasColumnOrder(85)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017G0018")
                .IsOptional();

            Property(p => p.H017G0019)
                .HasColumnName("H017G0019")
                .HasColumnOrder(86)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017G0019")
                .IsOptional();

            Property(p => p.H017G0020)
                .HasColumnName("H017G0020")
                .HasColumnOrder(87)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017G0020")
                .IsOptional();

            Property(p => p.H017G0021)
                .HasColumnName("H017G0021")
                .HasColumnOrder(88)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017G0021")
                .IsOptional();

            Property(p => p.H017H0001)
                .HasColumnName("H017H0001")
                .HasColumnOrder(89)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017H0001")
                .IsOptional();

            Property(p => p.H017H0002)
                .HasColumnName("H017H0002")
                .HasColumnOrder(90)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017H0002")
                .IsOptional();

            Property(p => p.H017H0003)
                .HasColumnName("H017H0003")
                .HasColumnOrder(91)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017H0003")
                .IsOptional();

            Property(p => p.H017H0004)
                .HasColumnName("H017H0004")
                .HasColumnOrder(92)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017H0004")
                .IsOptional();

            Property(p => p.H017H0005)
                .HasColumnName("H017H0005")
                .HasColumnOrder(93)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017H0005")
                .IsOptional();

            Property(p => p.H017H0006)
                .HasColumnName("H017H0006")
                .HasColumnOrder(94)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017H0006")
                .IsOptional();

            Property(p => p.H017H0007)
                .HasColumnName("H017H0007")
                .HasColumnOrder(95)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017H0007")
                .IsOptional();

            Property(p => p.H017H0008)
                .HasColumnName("H017H0008")
                .HasColumnOrder(96)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017H0008")
                .IsOptional();

            Property(p => p.H017H0009)
                .HasColumnName("H017H0009")
                .HasColumnOrder(97)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017H0009")
                .IsOptional();

            Property(p => p.H017H0010)
                .HasColumnName("H017H0010")
                .HasColumnOrder(98)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017H0010")
                .IsOptional();

            Property(p => p.H017H0011)
                .HasColumnName("H017H0011")
                .HasColumnOrder(99)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017H0011")
                .IsOptional();

            Property(p => p.H017H0012)
                .HasColumnName("H017H0012")
                .HasColumnOrder(100)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017H0012")
                .IsOptional();

            Property(p => p.H017H0013)
                .HasColumnName("H017H0013")
                .HasColumnOrder(101)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017H0013")
                .IsOptional();

            Property(p => p.H017H0014)
                .HasColumnName("H017H0014")
                .HasColumnOrder(102)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017H0014")
                .IsOptional();

            Property(p => p.H017H0015)
                .HasColumnName("H017H0015")
                .HasColumnOrder(103)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017H0015")
                .IsOptional();

            Property(p => p.H017H0016)
                .HasColumnName("H017H0016")
                .HasColumnOrder(104)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017H0016")
                .IsOptional();

            Property(p => p.H017H0017)
                .HasColumnName("H017H0017")
                .HasColumnOrder(105)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017H0017")
                .IsOptional();

            Property(p => p.H017H0018)
                .HasColumnName("H017H0018")
                .HasColumnOrder(106)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017H0018")
                .IsOptional();

            Property(p => p.H017H0019)
                .HasColumnName("H017H0019")
                .HasColumnOrder(107)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017H0019")
                .IsOptional();

            Property(p => p.H017H0020)
                .HasColumnName("H017H0020")
                .HasColumnOrder(108)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017H0020")
                .IsOptional();

            Property(p => p.H017H0021)
                .HasColumnName("H017H0021")
                .HasColumnOrder(109)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017H0021")
                .IsOptional();

            Property(p => p.H017I0001)
                .HasColumnName("H017I0001")
                .HasColumnOrder(110)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017I0001")
                .IsOptional();

            Property(p => p.H017I0002)
                .HasColumnName("H017I0002")
                .HasColumnOrder(111)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017I0002")
                .IsOptional();

            Property(p => p.H017I0003)
                .HasColumnName("H017I0003")
                .HasColumnOrder(112)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017I0003")
                .IsOptional();

            Property(p => p.H017I0004)
                .HasColumnName("H017I0004")
                .HasColumnOrder(113)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017I0004")
                .IsOptional();

            Property(p => p.H017I0005)
                .HasColumnName("H017I0005")
                .HasColumnOrder(114)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017I0005")
                .IsOptional();

            Property(p => p.H017I0006)
                .HasColumnName("H017I0006")
                .HasColumnOrder(115)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017I0006")
                .IsOptional();

            Property(p => p.H017I0007)
                .HasColumnName("H017I0007")
                .HasColumnOrder(116)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017I0007")
                .IsOptional();

            Property(p => p.H017I0008)
                .HasColumnName("H017I0008")
                .HasColumnOrder(117)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017I0008")
                .IsOptional();

            Property(p => p.H017I0009)
                .HasColumnName("H017I0009")
                .HasColumnOrder(118)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017I0009")
                .IsOptional();

            Property(p => p.H017I0010)
                .HasColumnName("H017I0010")
                .HasColumnOrder(119)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017I0010")
                .IsOptional();

            Property(p => p.H017I0011)
                .HasColumnName("H017I0011")
                .HasColumnOrder(120)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017I0011")
                .IsOptional();

            Property(p => p.H017I0012)
                .HasColumnName("H017I0012")
                .HasColumnOrder(121)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017I0012")
                .IsOptional();

            Property(p => p.H017I0013)
                .HasColumnName("H017I0013")
                .HasColumnOrder(122)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017I0013")
                .IsOptional();

            Property(p => p.H017I0014)
                .HasColumnName("H017I0014")
                .HasColumnOrder(123)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017I0014")
                .IsOptional();

            Property(p => p.H017I0015)
                .HasColumnName("H017I0015")
                .HasColumnOrder(124)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017I0015")
                .IsOptional();

            Property(p => p.H017I0016)
                .HasColumnName("H017I0016")
                .HasColumnOrder(125)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017I0016")
                .IsOptional();

            Property(p => p.H017I0017)
                .HasColumnName("H017I0017")
                .HasColumnOrder(126)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017I0017")
                .IsOptional();

            Property(p => p.H017I0018)
                .HasColumnName("H017I0018")
                .HasColumnOrder(127)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017I0018")
                .IsOptional();

            Property(p => p.H017I0019)
                .HasColumnName("H017I0019")
                .HasColumnOrder(128)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017I0019")
                .IsOptional();

            Property(p => p.H017I0020)
                .HasColumnName("H017I0020")
                .HasColumnOrder(129)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017I0020")
                .IsOptional();

            Property(p => p.H017I0021)
                .HasColumnName("H017I0021")
                .HasColumnOrder(130)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H017I0021")
                .IsOptional();
        }
    }
}
