#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/31/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1CongressionalDistricts113_SF1_00017Map.cs
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

    public class SF1CongressionalDistricts113_SF1_00017Map : EntityTypeConfiguration<SF1CongressionalDistricts113_SF1_00017>
    {
        public SF1CongressionalDistricts113_SF1_00017Map()
        {
            ToTable("SF1_00017", "SF1CongressionalDistricts113");

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

            Property(p => p.PCT0120001)
                .HasColumnName("PCT0120001")
                .HasColumnOrder(5)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120001")
                .IsOptional();

            Property(p => p.PCT0120002)
                .HasColumnName("PCT0120002")
                .HasColumnOrder(6)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120002")
                .IsOptional();

            Property(p => p.PCT0120003)
                .HasColumnName("PCT0120003")
                .HasColumnOrder(7)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120003")
                .IsOptional();

            Property(p => p.PCT0120004)
                .HasColumnName("PCT0120004")
                .HasColumnOrder(8)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120004")
                .IsOptional();

            Property(p => p.PCT0120005)
                .HasColumnName("PCT0120005")
                .HasColumnOrder(9)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120005")
                .IsOptional();

            Property(p => p.PCT0120006)
                .HasColumnName("PCT0120006")
                .HasColumnOrder(10)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120006")
                .IsOptional();

            Property(p => p.PCT0120007)
                .HasColumnName("PCT0120007")
                .HasColumnOrder(11)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120007")
                .IsOptional();

            Property(p => p.PCT0120008)
                .HasColumnName("PCT0120008")
                .HasColumnOrder(12)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120008")
                .IsOptional();

            Property(p => p.PCT0120009)
                .HasColumnName("PCT0120009")
                .HasColumnOrder(13)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120009")
                .IsOptional();

            Property(p => p.PCT0120010)
                .HasColumnName("PCT0120010")
                .HasColumnOrder(14)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120010")
                .IsOptional();

            Property(p => p.PCT0120011)
                .HasColumnName("PCT0120011")
                .HasColumnOrder(15)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120011")
                .IsOptional();

            Property(p => p.PCT0120012)
                .HasColumnName("PCT0120012")
                .HasColumnOrder(16)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120012")
                .IsOptional();

            Property(p => p.PCT0120013)
                .HasColumnName("PCT0120013")
                .HasColumnOrder(17)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120013")
                .IsOptional();

            Property(p => p.PCT0120014)
                .HasColumnName("PCT0120014")
                .HasColumnOrder(18)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120014")
                .IsOptional();

            Property(p => p.PCT0120015)
                .HasColumnName("PCT0120015")
                .HasColumnOrder(19)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120015")
                .IsOptional();

            Property(p => p.PCT0120016)
                .HasColumnName("PCT0120016")
                .HasColumnOrder(20)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120016")
                .IsOptional();

            Property(p => p.PCT0120017)
                .HasColumnName("PCT0120017")
                .HasColumnOrder(21)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120017")
                .IsOptional();

            Property(p => p.PCT0120018)
                .HasColumnName("PCT0120018")
                .HasColumnOrder(22)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120018")
                .IsOptional();

            Property(p => p.PCT0120019)
                .HasColumnName("PCT0120019")
                .HasColumnOrder(23)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120019")
                .IsOptional();

            Property(p => p.PCT0120020)
                .HasColumnName("PCT0120020")
                .HasColumnOrder(24)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120020")
                .IsOptional();

            Property(p => p.PCT0120021)
                .HasColumnName("PCT0120021")
                .HasColumnOrder(25)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120021")
                .IsOptional();

            Property(p => p.PCT0120022)
                .HasColumnName("PCT0120022")
                .HasColumnOrder(26)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120022")
                .IsOptional();

            Property(p => p.PCT0120023)
                .HasColumnName("PCT0120023")
                .HasColumnOrder(27)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120023")
                .IsOptional();

            Property(p => p.PCT0120024)
                .HasColumnName("PCT0120024")
                .HasColumnOrder(28)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120024")
                .IsOptional();

            Property(p => p.PCT0120025)
                .HasColumnName("PCT0120025")
                .HasColumnOrder(29)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120025")
                .IsOptional();

            Property(p => p.PCT0120026)
                .HasColumnName("PCT0120026")
                .HasColumnOrder(30)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120026")
                .IsOptional();

            Property(p => p.PCT0120027)
                .HasColumnName("PCT0120027")
                .HasColumnOrder(31)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120027")
                .IsOptional();

            Property(p => p.PCT0120028)
                .HasColumnName("PCT0120028")
                .HasColumnOrder(32)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120028")
                .IsOptional();

            Property(p => p.PCT0120029)
                .HasColumnName("PCT0120029")
                .HasColumnOrder(33)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120029")
                .IsOptional();

            Property(p => p.PCT0120030)
                .HasColumnName("PCT0120030")
                .HasColumnOrder(34)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120030")
                .IsOptional();

            Property(p => p.PCT0120031)
                .HasColumnName("PCT0120031")
                .HasColumnOrder(35)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120031")
                .IsOptional();

            Property(p => p.PCT0120032)
                .HasColumnName("PCT0120032")
                .HasColumnOrder(36)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120032")
                .IsOptional();

            Property(p => p.PCT0120033)
                .HasColumnName("PCT0120033")
                .HasColumnOrder(37)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120033")
                .IsOptional();

            Property(p => p.PCT0120034)
                .HasColumnName("PCT0120034")
                .HasColumnOrder(38)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120034")
                .IsOptional();

            Property(p => p.PCT0120035)
                .HasColumnName("PCT0120035")
                .HasColumnOrder(39)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120035")
                .IsOptional();

            Property(p => p.PCT0120036)
                .HasColumnName("PCT0120036")
                .HasColumnOrder(40)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120036")
                .IsOptional();

            Property(p => p.PCT0120037)
                .HasColumnName("PCT0120037")
                .HasColumnOrder(41)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120037")
                .IsOptional();

            Property(p => p.PCT0120038)
                .HasColumnName("PCT0120038")
                .HasColumnOrder(42)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120038")
                .IsOptional();

            Property(p => p.PCT0120039)
                .HasColumnName("PCT0120039")
                .HasColumnOrder(43)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120039")
                .IsOptional();

            Property(p => p.PCT0120040)
                .HasColumnName("PCT0120040")
                .HasColumnOrder(44)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120040")
                .IsOptional();

            Property(p => p.PCT0120041)
                .HasColumnName("PCT0120041")
                .HasColumnOrder(45)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120041")
                .IsOptional();

            Property(p => p.PCT0120042)
                .HasColumnName("PCT0120042")
                .HasColumnOrder(46)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120042")
                .IsOptional();

            Property(p => p.PCT0120043)
                .HasColumnName("PCT0120043")
                .HasColumnOrder(47)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120043")
                .IsOptional();

            Property(p => p.PCT0120044)
                .HasColumnName("PCT0120044")
                .HasColumnOrder(48)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120044")
                .IsOptional();

            Property(p => p.PCT0120045)
                .HasColumnName("PCT0120045")
                .HasColumnOrder(49)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120045")
                .IsOptional();

            Property(p => p.PCT0120046)
                .HasColumnName("PCT0120046")
                .HasColumnOrder(50)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120046")
                .IsOptional();

            Property(p => p.PCT0120047)
                .HasColumnName("PCT0120047")
                .HasColumnOrder(51)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120047")
                .IsOptional();

            Property(p => p.PCT0120048)
                .HasColumnName("PCT0120048")
                .HasColumnOrder(52)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120048")
                .IsOptional();

            Property(p => p.PCT0120049)
                .HasColumnName("PCT0120049")
                .HasColumnOrder(53)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120049")
                .IsOptional();

            Property(p => p.PCT0120050)
                .HasColumnName("PCT0120050")
                .HasColumnOrder(54)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120050")
                .IsOptional();

            Property(p => p.PCT0120051)
                .HasColumnName("PCT0120051")
                .HasColumnOrder(55)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120051")
                .IsOptional();

            Property(p => p.PCT0120052)
                .HasColumnName("PCT0120052")
                .HasColumnOrder(56)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120052")
                .IsOptional();

            Property(p => p.PCT0120053)
                .HasColumnName("PCT0120053")
                .HasColumnOrder(57)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120053")
                .IsOptional();

            Property(p => p.PCT0120054)
                .HasColumnName("PCT0120054")
                .HasColumnOrder(58)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120054")
                .IsOptional();

            Property(p => p.PCT0120055)
                .HasColumnName("PCT0120055")
                .HasColumnOrder(59)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120055")
                .IsOptional();

            Property(p => p.PCT0120056)
                .HasColumnName("PCT0120056")
                .HasColumnOrder(60)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120056")
                .IsOptional();

            Property(p => p.PCT0120057)
                .HasColumnName("PCT0120057")
                .HasColumnOrder(61)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120057")
                .IsOptional();

            Property(p => p.PCT0120058)
                .HasColumnName("PCT0120058")
                .HasColumnOrder(62)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120058")
                .IsOptional();

            Property(p => p.PCT0120059)
                .HasColumnName("PCT0120059")
                .HasColumnOrder(63)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120059")
                .IsOptional();

            Property(p => p.PCT0120060)
                .HasColumnName("PCT0120060")
                .HasColumnOrder(64)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120060")
                .IsOptional();

            Property(p => p.PCT0120061)
                .HasColumnName("PCT0120061")
                .HasColumnOrder(65)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120061")
                .IsOptional();

            Property(p => p.PCT0120062)
                .HasColumnName("PCT0120062")
                .HasColumnOrder(66)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120062")
                .IsOptional();

            Property(p => p.PCT0120063)
                .HasColumnName("PCT0120063")
                .HasColumnOrder(67)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120063")
                .IsOptional();

            Property(p => p.PCT0120064)
                .HasColumnName("PCT0120064")
                .HasColumnOrder(68)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120064")
                .IsOptional();

            Property(p => p.PCT0120065)
                .HasColumnName("PCT0120065")
                .HasColumnOrder(69)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120065")
                .IsOptional();

            Property(p => p.PCT0120066)
                .HasColumnName("PCT0120066")
                .HasColumnOrder(70)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120066")
                .IsOptional();

            Property(p => p.PCT0120067)
                .HasColumnName("PCT0120067")
                .HasColumnOrder(71)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120067")
                .IsOptional();

            Property(p => p.PCT0120068)
                .HasColumnName("PCT0120068")
                .HasColumnOrder(72)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120068")
                .IsOptional();

            Property(p => p.PCT0120069)
                .HasColumnName("PCT0120069")
                .HasColumnOrder(73)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120069")
                .IsOptional();

            Property(p => p.PCT0120070)
                .HasColumnName("PCT0120070")
                .HasColumnOrder(74)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120070")
                .IsOptional();

            Property(p => p.PCT0120071)
                .HasColumnName("PCT0120071")
                .HasColumnOrder(75)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120071")
                .IsOptional();

            Property(p => p.PCT0120072)
                .HasColumnName("PCT0120072")
                .HasColumnOrder(76)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120072")
                .IsOptional();

            Property(p => p.PCT0120073)
                .HasColumnName("PCT0120073")
                .HasColumnOrder(77)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120073")
                .IsOptional();

            Property(p => p.PCT0120074)
                .HasColumnName("PCT0120074")
                .HasColumnOrder(78)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120074")
                .IsOptional();

            Property(p => p.PCT0120075)
                .HasColumnName("PCT0120075")
                .HasColumnOrder(79)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120075")
                .IsOptional();

            Property(p => p.PCT0120076)
                .HasColumnName("PCT0120076")
                .HasColumnOrder(80)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120076")
                .IsOptional();

            Property(p => p.PCT0120077)
                .HasColumnName("PCT0120077")
                .HasColumnOrder(81)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120077")
                .IsOptional();

            Property(p => p.PCT0120078)
                .HasColumnName("PCT0120078")
                .HasColumnOrder(82)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120078")
                .IsOptional();

            Property(p => p.PCT0120079)
                .HasColumnName("PCT0120079")
                .HasColumnOrder(83)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120079")
                .IsOptional();

            Property(p => p.PCT0120080)
                .HasColumnName("PCT0120080")
                .HasColumnOrder(84)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120080")
                .IsOptional();

            Property(p => p.PCT0120081)
                .HasColumnName("PCT0120081")
                .HasColumnOrder(85)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120081")
                .IsOptional();

            Property(p => p.PCT0120082)
                .HasColumnName("PCT0120082")
                .HasColumnOrder(86)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120082")
                .IsOptional();

            Property(p => p.PCT0120083)
                .HasColumnName("PCT0120083")
                .HasColumnOrder(87)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120083")
                .IsOptional();

            Property(p => p.PCT0120084)
                .HasColumnName("PCT0120084")
                .HasColumnOrder(88)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120084")
                .IsOptional();

            Property(p => p.PCT0120085)
                .HasColumnName("PCT0120085")
                .HasColumnOrder(89)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120085")
                .IsOptional();

            Property(p => p.PCT0120086)
                .HasColumnName("PCT0120086")
                .HasColumnOrder(90)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120086")
                .IsOptional();

            Property(p => p.PCT0120087)
                .HasColumnName("PCT0120087")
                .HasColumnOrder(91)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120087")
                .IsOptional();

            Property(p => p.PCT0120088)
                .HasColumnName("PCT0120088")
                .HasColumnOrder(92)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120088")
                .IsOptional();

            Property(p => p.PCT0120089)
                .HasColumnName("PCT0120089")
                .HasColumnOrder(93)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120089")
                .IsOptional();

            Property(p => p.PCT0120090)
                .HasColumnName("PCT0120090")
                .HasColumnOrder(94)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120090")
                .IsOptional();

            Property(p => p.PCT0120091)
                .HasColumnName("PCT0120091")
                .HasColumnOrder(95)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120091")
                .IsOptional();

            Property(p => p.PCT0120092)
                .HasColumnName("PCT0120092")
                .HasColumnOrder(96)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120092")
                .IsOptional();

            Property(p => p.PCT0120093)
                .HasColumnName("PCT0120093")
                .HasColumnOrder(97)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120093")
                .IsOptional();

            Property(p => p.PCT0120094)
                .HasColumnName("PCT0120094")
                .HasColumnOrder(98)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120094")
                .IsOptional();

            Property(p => p.PCT0120095)
                .HasColumnName("PCT0120095")
                .HasColumnOrder(99)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120095")
                .IsOptional();

            Property(p => p.PCT0120096)
                .HasColumnName("PCT0120096")
                .HasColumnOrder(100)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120096")
                .IsOptional();

            Property(p => p.PCT0120097)
                .HasColumnName("PCT0120097")
                .HasColumnOrder(101)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120097")
                .IsOptional();

            Property(p => p.PCT0120098)
                .HasColumnName("PCT0120098")
                .HasColumnOrder(102)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120098")
                .IsOptional();

            Property(p => p.PCT0120099)
                .HasColumnName("PCT0120099")
                .HasColumnOrder(103)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120099")
                .IsOptional();

            Property(p => p.PCT0120100)
                .HasColumnName("PCT0120100")
                .HasColumnOrder(104)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120100")
                .IsOptional();

            Property(p => p.PCT0120101)
                .HasColumnName("PCT0120101")
                .HasColumnOrder(105)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120101")
                .IsOptional();

            Property(p => p.PCT0120102)
                .HasColumnName("PCT0120102")
                .HasColumnOrder(106)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120102")
                .IsOptional();

            Property(p => p.PCT0120103)
                .HasColumnName("PCT0120103")
                .HasColumnOrder(107)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120103")
                .IsOptional();

            Property(p => p.PCT0120104)
                .HasColumnName("PCT0120104")
                .HasColumnOrder(108)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120104")
                .IsOptional();

            Property(p => p.PCT0120105)
                .HasColumnName("PCT0120105")
                .HasColumnOrder(109)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120105")
                .IsOptional();

            Property(p => p.PCT0120106)
                .HasColumnName("PCT0120106")
                .HasColumnOrder(110)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120106")
                .IsOptional();

            Property(p => p.PCT0120107)
                .HasColumnName("PCT0120107")
                .HasColumnOrder(111)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120107")
                .IsOptional();

            Property(p => p.PCT0120108)
                .HasColumnName("PCT0120108")
                .HasColumnOrder(112)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120108")
                .IsOptional();

            Property(p => p.PCT0120109)
                .HasColumnName("PCT0120109")
                .HasColumnOrder(113)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120109")
                .IsOptional();

            Property(p => p.PCT0120110)
                .HasColumnName("PCT0120110")
                .HasColumnOrder(114)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120110")
                .IsOptional();

            Property(p => p.PCT0120111)
                .HasColumnName("PCT0120111")
                .HasColumnOrder(115)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120111")
                .IsOptional();

            Property(p => p.PCT0120112)
                .HasColumnName("PCT0120112")
                .HasColumnOrder(116)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120112")
                .IsOptional();

            Property(p => p.PCT0120113)
                .HasColumnName("PCT0120113")
                .HasColumnOrder(117)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120113")
                .IsOptional();

            Property(p => p.PCT0120114)
                .HasColumnName("PCT0120114")
                .HasColumnOrder(118)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120114")
                .IsOptional();

            Property(p => p.PCT0120115)
                .HasColumnName("PCT0120115")
                .HasColumnOrder(119)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120115")
                .IsOptional();

            Property(p => p.PCT0120116)
                .HasColumnName("PCT0120116")
                .HasColumnOrder(120)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120116")
                .IsOptional();

            Property(p => p.PCT0120117)
                .HasColumnName("PCT0120117")
                .HasColumnOrder(121)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120117")
                .IsOptional();

            Property(p => p.PCT0120118)
                .HasColumnName("PCT0120118")
                .HasColumnOrder(122)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120118")
                .IsOptional();

            Property(p => p.PCT0120119)
                .HasColumnName("PCT0120119")
                .HasColumnOrder(123)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120119")
                .IsOptional();

            Property(p => p.PCT0120120)
                .HasColumnName("PCT0120120")
                .HasColumnOrder(124)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120120")
                .IsOptional();

            Property(p => p.PCT0120121)
                .HasColumnName("PCT0120121")
                .HasColumnOrder(125)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120121")
                .IsOptional();

            Property(p => p.PCT0120122)
                .HasColumnName("PCT0120122")
                .HasColumnOrder(126)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120122")
                .IsOptional();

            Property(p => p.PCT0120123)
                .HasColumnName("PCT0120123")
                .HasColumnOrder(127)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120123")
                .IsOptional();

            Property(p => p.PCT0120124)
                .HasColumnName("PCT0120124")
                .HasColumnOrder(128)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120124")
                .IsOptional();

            Property(p => p.PCT0120125)
                .HasColumnName("PCT0120125")
                .HasColumnOrder(129)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120125")
                .IsOptional();

            Property(p => p.PCT0120126)
                .HasColumnName("PCT0120126")
                .HasColumnOrder(130)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120126")
                .IsOptional();

            Property(p => p.PCT0120127)
                .HasColumnName("PCT0120127")
                .HasColumnOrder(131)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120127")
                .IsOptional();

            Property(p => p.PCT0120128)
                .HasColumnName("PCT0120128")
                .HasColumnOrder(132)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120128")
                .IsOptional();

            Property(p => p.PCT0120129)
                .HasColumnName("PCT0120129")
                .HasColumnOrder(133)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120129")
                .IsOptional();

            Property(p => p.PCT0120130)
                .HasColumnName("PCT0120130")
                .HasColumnOrder(134)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120130")
                .IsOptional();

            Property(p => p.PCT0120131)
                .HasColumnName("PCT0120131")
                .HasColumnOrder(135)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120131")
                .IsOptional();

            Property(p => p.PCT0120132)
                .HasColumnName("PCT0120132")
                .HasColumnOrder(136)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120132")
                .IsOptional();

            Property(p => p.PCT0120133)
                .HasColumnName("PCT0120133")
                .HasColumnOrder(137)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120133")
                .IsOptional();

            Property(p => p.PCT0120134)
                .HasColumnName("PCT0120134")
                .HasColumnOrder(138)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120134")
                .IsOptional();

            Property(p => p.PCT0120135)
                .HasColumnName("PCT0120135")
                .HasColumnOrder(139)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120135")
                .IsOptional();

            Property(p => p.PCT0120136)
                .HasColumnName("PCT0120136")
                .HasColumnOrder(140)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120136")
                .IsOptional();

            Property(p => p.PCT0120137)
                .HasColumnName("PCT0120137")
                .HasColumnOrder(141)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120137")
                .IsOptional();

            Property(p => p.PCT0120138)
                .HasColumnName("PCT0120138")
                .HasColumnOrder(142)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120138")
                .IsOptional();

            Property(p => p.PCT0120139)
                .HasColumnName("PCT0120139")
                .HasColumnOrder(143)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120139")
                .IsOptional();

            Property(p => p.PCT0120140)
                .HasColumnName("PCT0120140")
                .HasColumnOrder(144)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120140")
                .IsOptional();

            Property(p => p.PCT0120141)
                .HasColumnName("PCT0120141")
                .HasColumnOrder(145)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120141")
                .IsOptional();

            Property(p => p.PCT0120142)
                .HasColumnName("PCT0120142")
                .HasColumnOrder(146)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120142")
                .IsOptional();

            Property(p => p.PCT0120143)
                .HasColumnName("PCT0120143")
                .HasColumnOrder(147)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120143")
                .IsOptional();

            Property(p => p.PCT0120144)
                .HasColumnName("PCT0120144")
                .HasColumnOrder(148)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120144")
                .IsOptional();

            Property(p => p.PCT0120145)
                .HasColumnName("PCT0120145")
                .HasColumnOrder(149)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120145")
                .IsOptional();

            Property(p => p.PCT0120146)
                .HasColumnName("PCT0120146")
                .HasColumnOrder(150)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120146")
                .IsOptional();

            Property(p => p.PCT0120147)
                .HasColumnName("PCT0120147")
                .HasColumnOrder(151)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120147")
                .IsOptional();

            Property(p => p.PCT0120148)
                .HasColumnName("PCT0120148")
                .HasColumnOrder(152)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120148")
                .IsOptional();

            Property(p => p.PCT0120149)
                .HasColumnName("PCT0120149")
                .HasColumnOrder(153)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120149")
                .IsOptional();

            Property(p => p.PCT0120150)
                .HasColumnName("PCT0120150")
                .HasColumnOrder(154)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120150")
                .IsOptional();

            Property(p => p.PCT0120151)
                .HasColumnName("PCT0120151")
                .HasColumnOrder(155)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120151")
                .IsOptional();

            Property(p => p.PCT0120152)
                .HasColumnName("PCT0120152")
                .HasColumnOrder(156)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120152")
                .IsOptional();

            Property(p => p.PCT0120153)
                .HasColumnName("PCT0120153")
                .HasColumnOrder(157)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120153")
                .IsOptional();

            Property(p => p.PCT0120154)
                .HasColumnName("PCT0120154")
                .HasColumnOrder(158)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120154")
                .IsOptional();

            Property(p => p.PCT0120155)
                .HasColumnName("PCT0120155")
                .HasColumnOrder(159)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120155")
                .IsOptional();

            Property(p => p.PCT0120156)
                .HasColumnName("PCT0120156")
                .HasColumnOrder(160)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120156")
                .IsOptional();

            Property(p => p.PCT0120157)
                .HasColumnName("PCT0120157")
                .HasColumnOrder(161)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120157")
                .IsOptional();

            Property(p => p.PCT0120158)
                .HasColumnName("PCT0120158")
                .HasColumnOrder(162)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120158")
                .IsOptional();

            Property(p => p.PCT0120159)
                .HasColumnName("PCT0120159")
                .HasColumnOrder(163)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120159")
                .IsOptional();

            Property(p => p.PCT0120160)
                .HasColumnName("PCT0120160")
                .HasColumnOrder(164)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120160")
                .IsOptional();

            Property(p => p.PCT0120161)
                .HasColumnName("PCT0120161")
                .HasColumnOrder(165)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120161")
                .IsOptional();

            Property(p => p.PCT0120162)
                .HasColumnName("PCT0120162")
                .HasColumnOrder(166)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120162")
                .IsOptional();

            Property(p => p.PCT0120163)
                .HasColumnName("PCT0120163")
                .HasColumnOrder(167)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120163")
                .IsOptional();

            Property(p => p.PCT0120164)
                .HasColumnName("PCT0120164")
                .HasColumnOrder(168)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120164")
                .IsOptional();

            Property(p => p.PCT0120165)
                .HasColumnName("PCT0120165")
                .HasColumnOrder(169)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120165")
                .IsOptional();

            Property(p => p.PCT0120166)
                .HasColumnName("PCT0120166")
                .HasColumnOrder(170)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120166")
                .IsOptional();

            Property(p => p.PCT0120167)
                .HasColumnName("PCT0120167")
                .HasColumnOrder(171)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120167")
                .IsOptional();

            Property(p => p.PCT0120168)
                .HasColumnName("PCT0120168")
                .HasColumnOrder(172)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120168")
                .IsOptional();

            Property(p => p.PCT0120169)
                .HasColumnName("PCT0120169")
                .HasColumnOrder(173)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120169")
                .IsOptional();

            Property(p => p.PCT0120170)
                .HasColumnName("PCT0120170")
                .HasColumnOrder(174)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120170")
                .IsOptional();

            Property(p => p.PCT0120171)
                .HasColumnName("PCT0120171")
                .HasColumnOrder(175)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120171")
                .IsOptional();

            Property(p => p.PCT0120172)
                .HasColumnName("PCT0120172")
                .HasColumnOrder(176)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120172")
                .IsOptional();

            Property(p => p.PCT0120173)
                .HasColumnName("PCT0120173")
                .HasColumnOrder(177)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120173")
                .IsOptional();

            Property(p => p.PCT0120174)
                .HasColumnName("PCT0120174")
                .HasColumnOrder(178)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120174")
                .IsOptional();

            Property(p => p.PCT0120175)
                .HasColumnName("PCT0120175")
                .HasColumnOrder(179)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120175")
                .IsOptional();

            Property(p => p.PCT0120176)
                .HasColumnName("PCT0120176")
                .HasColumnOrder(180)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120176")
                .IsOptional();

            Property(p => p.PCT0120177)
                .HasColumnName("PCT0120177")
                .HasColumnOrder(181)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120177")
                .IsOptional();

            Property(p => p.PCT0120178)
                .HasColumnName("PCT0120178")
                .HasColumnOrder(182)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120178")
                .IsOptional();

            Property(p => p.PCT0120179)
                .HasColumnName("PCT0120179")
                .HasColumnOrder(183)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120179")
                .IsOptional();

            Property(p => p.PCT0120180)
                .HasColumnName("PCT0120180")
                .HasColumnOrder(184)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120180")
                .IsOptional();

            Property(p => p.PCT0120181)
                .HasColumnName("PCT0120181")
                .HasColumnOrder(185)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120181")
                .IsOptional();

            Property(p => p.PCT0120182)
                .HasColumnName("PCT0120182")
                .HasColumnOrder(186)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120182")
                .IsOptional();

            Property(p => p.PCT0120183)
                .HasColumnName("PCT0120183")
                .HasColumnOrder(187)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120183")
                .IsOptional();

            Property(p => p.PCT0120184)
                .HasColumnName("PCT0120184")
                .HasColumnOrder(188)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120184")
                .IsOptional();

            Property(p => p.PCT0120185)
                .HasColumnName("PCT0120185")
                .HasColumnOrder(189)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120185")
                .IsOptional();

            Property(p => p.PCT0120186)
                .HasColumnName("PCT0120186")
                .HasColumnOrder(190)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120186")
                .IsOptional();

            Property(p => p.PCT0120187)
                .HasColumnName("PCT0120187")
                .HasColumnOrder(191)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120187")
                .IsOptional();

            Property(p => p.PCT0120188)
                .HasColumnName("PCT0120188")
                .HasColumnOrder(192)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120188")
                .IsOptional();

            Property(p => p.PCT0120189)
                .HasColumnName("PCT0120189")
                .HasColumnOrder(193)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120189")
                .IsOptional();

            Property(p => p.PCT0120190)
                .HasColumnName("PCT0120190")
                .HasColumnOrder(194)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120190")
                .IsOptional();

            Property(p => p.PCT0120191)
                .HasColumnName("PCT0120191")
                .HasColumnOrder(195)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120191")
                .IsOptional();

            Property(p => p.PCT0120192)
                .HasColumnName("PCT0120192")
                .HasColumnOrder(196)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120192")
                .IsOptional();

            Property(p => p.PCT0120193)
                .HasColumnName("PCT0120193")
                .HasColumnOrder(197)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120193")
                .IsOptional();

            Property(p => p.PCT0120194)
                .HasColumnName("PCT0120194")
                .HasColumnOrder(198)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120194")
                .IsOptional();

            Property(p => p.PCT0120195)
                .HasColumnName("PCT0120195")
                .HasColumnOrder(199)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120195")
                .IsOptional();

            Property(p => p.PCT0120196)
                .HasColumnName("PCT0120196")
                .HasColumnOrder(200)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120196")
                .IsOptional();

            Property(p => p.PCT0120197)
                .HasColumnName("PCT0120197")
                .HasColumnOrder(201)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120197")
                .IsOptional();

            Property(p => p.PCT0120198)
                .HasColumnName("PCT0120198")
                .HasColumnOrder(202)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120198")
                .IsOptional();

            Property(p => p.PCT0120199)
                .HasColumnName("PCT0120199")
                .HasColumnOrder(203)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120199")
                .IsOptional();

            Property(p => p.PCT0120200)
                .HasColumnName("PCT0120200")
                .HasColumnOrder(204)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120200")
                .IsOptional();

            Property(p => p.PCT0120201)
                .HasColumnName("PCT0120201")
                .HasColumnOrder(205)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120201")
                .IsOptional();

            Property(p => p.PCT0120202)
                .HasColumnName("PCT0120202")
                .HasColumnOrder(206)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120202")
                .IsOptional();

            Property(p => p.PCT0120203)
                .HasColumnName("PCT0120203")
                .HasColumnOrder(207)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120203")
                .IsOptional();

            Property(p => p.PCT0120204)
                .HasColumnName("PCT0120204")
                .HasColumnOrder(208)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120204")
                .IsOptional();

            Property(p => p.PCT0120205)
                .HasColumnName("PCT0120205")
                .HasColumnOrder(209)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120205")
                .IsOptional();

            Property(p => p.PCT0120206)
                .HasColumnName("PCT0120206")
                .HasColumnOrder(210)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120206")
                .IsOptional();

            Property(p => p.PCT0120207)
                .HasColumnName("PCT0120207")
                .HasColumnOrder(211)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120207")
                .IsOptional();

            Property(p => p.PCT0120208)
                .HasColumnName("PCT0120208")
                .HasColumnOrder(212)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120208")
                .IsOptional();

            Property(p => p.PCT0120209)
                .HasColumnName("PCT0120209")
                .HasColumnOrder(213)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0120209")
                .IsOptional();
        }
    }
}
