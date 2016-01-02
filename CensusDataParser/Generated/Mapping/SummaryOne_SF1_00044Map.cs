#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2016 12:31 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SummaryOne_SF1_00044Map.cs
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

    public class SummaryOne_SF1_00044Map : EntityTypeConfiguration<SummaryOne_SF1_00044>
    {
        public SummaryOne_SF1_00044Map()
        {
            ToTable("SF1_00044", "SummaryOne");

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

            Property(p => p.H0030001)
                .HasColumnName("H0030001")
                .HasColumnOrder(5)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0030001")
                .IsOptional();

            Property(p => p.H0030002)
                .HasColumnName("H0030002")
                .HasColumnOrder(6)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0030002")
                .IsOptional();

            Property(p => p.H0030003)
                .HasColumnName("H0030003")
                .HasColumnOrder(7)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0030003")
                .IsOptional();

            Property(p => p.H0040001)
                .HasColumnName("H0040001")
                .HasColumnOrder(8)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0040001")
                .IsOptional();

            Property(p => p.H0040002)
                .HasColumnName("H0040002")
                .HasColumnOrder(9)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0040002")
                .IsOptional();

            Property(p => p.H0040003)
                .HasColumnName("H0040003")
                .HasColumnOrder(10)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0040003")
                .IsOptional();

            Property(p => p.H0040004)
                .HasColumnName("H0040004")
                .HasColumnOrder(11)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0040004")
                .IsOptional();

            Property(p => p.H0050001)
                .HasColumnName("H0050001")
                .HasColumnOrder(12)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0050001")
                .IsOptional();

            Property(p => p.H0050002)
                .HasColumnName("H0050002")
                .HasColumnOrder(13)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0050002")
                .IsOptional();

            Property(p => p.H0050003)
                .HasColumnName("H0050003")
                .HasColumnOrder(14)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0050003")
                .IsOptional();

            Property(p => p.H0050004)
                .HasColumnName("H0050004")
                .HasColumnOrder(15)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0050004")
                .IsOptional();

            Property(p => p.H0050005)
                .HasColumnName("H0050005")
                .HasColumnOrder(16)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0050005")
                .IsOptional();

            Property(p => p.H0050006)
                .HasColumnName("H0050006")
                .HasColumnOrder(17)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0050006")
                .IsOptional();

            Property(p => p.H0050007)
                .HasColumnName("H0050007")
                .HasColumnOrder(18)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0050007")
                .IsOptional();

            Property(p => p.H0050008)
                .HasColumnName("H0050008")
                .HasColumnOrder(19)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0050008")
                .IsOptional();

            Property(p => p.H0060001)
                .HasColumnName("H0060001")
                .HasColumnOrder(20)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0060001")
                .IsOptional();

            Property(p => p.H0060002)
                .HasColumnName("H0060002")
                .HasColumnOrder(21)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0060002")
                .IsOptional();

            Property(p => p.H0060003)
                .HasColumnName("H0060003")
                .HasColumnOrder(22)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0060003")
                .IsOptional();

            Property(p => p.H0060004)
                .HasColumnName("H0060004")
                .HasColumnOrder(23)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0060004")
                .IsOptional();

            Property(p => p.H0060005)
                .HasColumnName("H0060005")
                .HasColumnOrder(24)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0060005")
                .IsOptional();

            Property(p => p.H0060006)
                .HasColumnName("H0060006")
                .HasColumnOrder(25)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0060006")
                .IsOptional();

            Property(p => p.H0060007)
                .HasColumnName("H0060007")
                .HasColumnOrder(26)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0060007")
                .IsOptional();

            Property(p => p.H0060008)
                .HasColumnName("H0060008")
                .HasColumnOrder(27)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0060008")
                .IsOptional();

            Property(p => p.H0070001)
                .HasColumnName("H0070001")
                .HasColumnOrder(28)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0070001")
                .IsOptional();

            Property(p => p.H0070002)
                .HasColumnName("H0070002")
                .HasColumnOrder(29)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0070002")
                .IsOptional();

            Property(p => p.H0070003)
                .HasColumnName("H0070003")
                .HasColumnOrder(30)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0070003")
                .IsOptional();

            Property(p => p.H0070004)
                .HasColumnName("H0070004")
                .HasColumnOrder(31)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0070004")
                .IsOptional();

            Property(p => p.H0070005)
                .HasColumnName("H0070005")
                .HasColumnOrder(32)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0070005")
                .IsOptional();

            Property(p => p.H0070006)
                .HasColumnName("H0070006")
                .HasColumnOrder(33)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0070006")
                .IsOptional();

            Property(p => p.H0070007)
                .HasColumnName("H0070007")
                .HasColumnOrder(34)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0070007")
                .IsOptional();

            Property(p => p.H0070008)
                .HasColumnName("H0070008")
                .HasColumnOrder(35)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0070008")
                .IsOptional();

            Property(p => p.H0070009)
                .HasColumnName("H0070009")
                .HasColumnOrder(36)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0070009")
                .IsOptional();

            Property(p => p.H0070010)
                .HasColumnName("H0070010")
                .HasColumnOrder(37)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0070010")
                .IsOptional();

            Property(p => p.H0070011)
                .HasColumnName("H0070011")
                .HasColumnOrder(38)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0070011")
                .IsOptional();

            Property(p => p.H0070012)
                .HasColumnName("H0070012")
                .HasColumnOrder(39)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0070012")
                .IsOptional();

            Property(p => p.H0070013)
                .HasColumnName("H0070013")
                .HasColumnOrder(40)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0070013")
                .IsOptional();

            Property(p => p.H0070014)
                .HasColumnName("H0070014")
                .HasColumnOrder(41)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0070014")
                .IsOptional();

            Property(p => p.H0070015)
                .HasColumnName("H0070015")
                .HasColumnOrder(42)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0070015")
                .IsOptional();

            Property(p => p.H0070016)
                .HasColumnName("H0070016")
                .HasColumnOrder(43)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0070016")
                .IsOptional();

            Property(p => p.H0070017)
                .HasColumnName("H0070017")
                .HasColumnOrder(44)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0070017")
                .IsOptional();

            Property(p => p.H0080001)
                .HasColumnName("H0080001")
                .HasColumnOrder(45)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0080001")
                .IsOptional();

            Property(p => p.H0080002)
                .HasColumnName("H0080002")
                .HasColumnOrder(46)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0080002")
                .IsOptional();

            Property(p => p.H0080003)
                .HasColumnName("H0080003")
                .HasColumnOrder(47)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0080003")
                .IsOptional();

            Property(p => p.H0080004)
                .HasColumnName("H0080004")
                .HasColumnOrder(48)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0080004")
                .IsOptional();

            Property(p => p.H0080005)
                .HasColumnName("H0080005")
                .HasColumnOrder(49)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0080005")
                .IsOptional();

            Property(p => p.H0080006)
                .HasColumnName("H0080006")
                .HasColumnOrder(50)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0080006")
                .IsOptional();

            Property(p => p.H0080007)
                .HasColumnName("H0080007")
                .HasColumnOrder(51)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0080007")
                .IsOptional();

            Property(p => p.H0090001)
                .HasColumnName("H0090001")
                .HasColumnOrder(52)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0090001")
                .IsOptional();

            Property(p => p.H0090002)
                .HasColumnName("H0090002")
                .HasColumnOrder(53)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0090002")
                .IsOptional();

            Property(p => p.H0090003)
                .HasColumnName("H0090003")
                .HasColumnOrder(54)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0090003")
                .IsOptional();

            Property(p => p.H0090004)
                .HasColumnName("H0090004")
                .HasColumnOrder(55)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0090004")
                .IsOptional();

            Property(p => p.H0090005)
                .HasColumnName("H0090005")
                .HasColumnOrder(56)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0090005")
                .IsOptional();

            Property(p => p.H0090006)
                .HasColumnName("H0090006")
                .HasColumnOrder(57)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0090006")
                .IsOptional();

            Property(p => p.H0090007)
                .HasColumnName("H0090007")
                .HasColumnOrder(58)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0090007")
                .IsOptional();

            Property(p => p.H0090008)
                .HasColumnName("H0090008")
                .HasColumnOrder(59)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0090008")
                .IsOptional();

            Property(p => p.H0090009)
                .HasColumnName("H0090009")
                .HasColumnOrder(60)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0090009")
                .IsOptional();

            Property(p => p.H0090010)
                .HasColumnName("H0090010")
                .HasColumnOrder(61)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0090010")
                .IsOptional();

            Property(p => p.H0090011)
                .HasColumnName("H0090011")
                .HasColumnOrder(62)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0090011")
                .IsOptional();

            Property(p => p.H0090012)
                .HasColumnName("H0090012")
                .HasColumnOrder(63)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0090012")
                .IsOptional();

            Property(p => p.H0090013)
                .HasColumnName("H0090013")
                .HasColumnOrder(64)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0090013")
                .IsOptional();

            Property(p => p.H0090014)
                .HasColumnName("H0090014")
                .HasColumnOrder(65)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0090014")
                .IsOptional();

            Property(p => p.H0090015)
                .HasColumnName("H0090015")
                .HasColumnOrder(66)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0090015")
                .IsOptional();

            Property(p => p.H0100001)
                .HasColumnName("H0100001")
                .HasColumnOrder(67)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0100001")
                .IsOptional();

            Property(p => p.H0110001)
                .HasColumnName("H0110001")
                .HasColumnOrder(68)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0110001")
                .IsOptional();

            Property(p => p.H0110002)
                .HasColumnName("H0110002")
                .HasColumnOrder(69)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0110002")
                .IsOptional();

            Property(p => p.H0110003)
                .HasColumnName("H0110003")
                .HasColumnOrder(70)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0110003")
                .IsOptional();

            Property(p => p.H0110004)
                .HasColumnName("H0110004")
                .HasColumnOrder(71)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0110004")
                .IsOptional();

            Property(p => p.H0120001)
                .HasColumnName("H0120001")
                .HasColumnOrder(72)
                .HasColumnType("DOUBLE")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0120001")
                .IsOptional();

            Property(p => p.H0120002)
                .HasColumnName("H0120002")
                .HasColumnOrder(73)
                .HasColumnType("DOUBLE")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0120002")
                .IsOptional();

            Property(p => p.H0120003)
                .HasColumnName("H0120003")
                .HasColumnOrder(74)
                .HasColumnType("DOUBLE")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0120003")
                .IsOptional();

            Property(p => p.H0130001)
                .HasColumnName("H0130001")
                .HasColumnOrder(75)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0130001")
                .IsOptional();

            Property(p => p.H0130002)
                .HasColumnName("H0130002")
                .HasColumnOrder(76)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0130002")
                .IsOptional();

            Property(p => p.H0130003)
                .HasColumnName("H0130003")
                .HasColumnOrder(77)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0130003")
                .IsOptional();

            Property(p => p.H0130004)
                .HasColumnName("H0130004")
                .HasColumnOrder(78)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0130004")
                .IsOptional();

            Property(p => p.H0130005)
                .HasColumnName("H0130005")
                .HasColumnOrder(79)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0130005")
                .IsOptional();

            Property(p => p.H0130006)
                .HasColumnName("H0130006")
                .HasColumnOrder(80)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0130006")
                .IsOptional();

            Property(p => p.H0130007)
                .HasColumnName("H0130007")
                .HasColumnOrder(81)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0130007")
                .IsOptional();

            Property(p => p.H0130008)
                .HasColumnName("H0130008")
                .HasColumnOrder(82)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0130008")
                .IsOptional();

            Property(p => p.H0140001)
                .HasColumnName("H0140001")
                .HasColumnOrder(83)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0140001")
                .IsOptional();

            Property(p => p.H0140002)
                .HasColumnName("H0140002")
                .HasColumnOrder(84)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0140002")
                .IsOptional();

            Property(p => p.H0140003)
                .HasColumnName("H0140003")
                .HasColumnOrder(85)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0140003")
                .IsOptional();

            Property(p => p.H0140004)
                .HasColumnName("H0140004")
                .HasColumnOrder(86)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0140004")
                .IsOptional();

            Property(p => p.H0140005)
                .HasColumnName("H0140005")
                .HasColumnOrder(87)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0140005")
                .IsOptional();

            Property(p => p.H0140006)
                .HasColumnName("H0140006")
                .HasColumnOrder(88)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0140006")
                .IsOptional();

            Property(p => p.H0140007)
                .HasColumnName("H0140007")
                .HasColumnOrder(89)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0140007")
                .IsOptional();

            Property(p => p.H0140008)
                .HasColumnName("H0140008")
                .HasColumnOrder(90)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0140008")
                .IsOptional();

            Property(p => p.H0140009)
                .HasColumnName("H0140009")
                .HasColumnOrder(91)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0140009")
                .IsOptional();

            Property(p => p.H0140010)
                .HasColumnName("H0140010")
                .HasColumnOrder(92)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0140010")
                .IsOptional();

            Property(p => p.H0140011)
                .HasColumnName("H0140011")
                .HasColumnOrder(93)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0140011")
                .IsOptional();

            Property(p => p.H0140012)
                .HasColumnName("H0140012")
                .HasColumnOrder(94)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0140012")
                .IsOptional();

            Property(p => p.H0140013)
                .HasColumnName("H0140013")
                .HasColumnOrder(95)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0140013")
                .IsOptional();

            Property(p => p.H0140014)
                .HasColumnName("H0140014")
                .HasColumnOrder(96)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0140014")
                .IsOptional();

            Property(p => p.H0140015)
                .HasColumnName("H0140015")
                .HasColumnOrder(97)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0140015")
                .IsOptional();

            Property(p => p.H0140016)
                .HasColumnName("H0140016")
                .HasColumnOrder(98)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0140016")
                .IsOptional();

            Property(p => p.H0140017)
                .HasColumnName("H0140017")
                .HasColumnOrder(99)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0140017")
                .IsOptional();

            Property(p => p.H0150001)
                .HasColumnName("H0150001")
                .HasColumnOrder(100)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0150001")
                .IsOptional();

            Property(p => p.H0150002)
                .HasColumnName("H0150002")
                .HasColumnOrder(101)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0150002")
                .IsOptional();

            Property(p => p.H0150003)
                .HasColumnName("H0150003")
                .HasColumnOrder(102)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0150003")
                .IsOptional();

            Property(p => p.H0150004)
                .HasColumnName("H0150004")
                .HasColumnOrder(103)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0150004")
                .IsOptional();

            Property(p => p.H0150005)
                .HasColumnName("H0150005")
                .HasColumnOrder(104)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0150005")
                .IsOptional();

            Property(p => p.H0150006)
                .HasColumnName("H0150006")
                .HasColumnOrder(105)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0150006")
                .IsOptional();

            Property(p => p.H0150007)
                .HasColumnName("H0150007")
                .HasColumnOrder(106)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0150007")
                .IsOptional();

            Property(p => p.H0160001)
                .HasColumnName("H0160001")
                .HasColumnOrder(107)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0160001")
                .IsOptional();

            Property(p => p.H0160002)
                .HasColumnName("H0160002")
                .HasColumnOrder(108)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0160002")
                .IsOptional();

            Property(p => p.H0160003)
                .HasColumnName("H0160003")
                .HasColumnOrder(109)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0160003")
                .IsOptional();

            Property(p => p.H0160004)
                .HasColumnName("H0160004")
                .HasColumnOrder(110)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0160004")
                .IsOptional();

            Property(p => p.H0160005)
                .HasColumnName("H0160005")
                .HasColumnOrder(111)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0160005")
                .IsOptional();

            Property(p => p.H0160006)
                .HasColumnName("H0160006")
                .HasColumnOrder(112)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0160006")
                .IsOptional();

            Property(p => p.H0160007)
                .HasColumnName("H0160007")
                .HasColumnOrder(113)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0160007")
                .IsOptional();

            Property(p => p.H0160008)
                .HasColumnName("H0160008")
                .HasColumnOrder(114)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0160008")
                .IsOptional();

            Property(p => p.H0160009)
                .HasColumnName("H0160009")
                .HasColumnOrder(115)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0160009")
                .IsOptional();

            Property(p => p.H0160010)
                .HasColumnName("H0160010")
                .HasColumnOrder(116)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0160010")
                .IsOptional();

            Property(p => p.H0160011)
                .HasColumnName("H0160011")
                .HasColumnOrder(117)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0160011")
                .IsOptional();

            Property(p => p.H0160012)
                .HasColumnName("H0160012")
                .HasColumnOrder(118)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0160012")
                .IsOptional();

            Property(p => p.H0160013)
                .HasColumnName("H0160013")
                .HasColumnOrder(119)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0160013")
                .IsOptional();

            Property(p => p.H0160014)
                .HasColumnName("H0160014")
                .HasColumnOrder(120)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0160014")
                .IsOptional();

            Property(p => p.H0160015)
                .HasColumnName("H0160015")
                .HasColumnOrder(121)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0160015")
                .IsOptional();

            Property(p => p.H0160016)
                .HasColumnName("H0160016")
                .HasColumnOrder(122)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0160016")
                .IsOptional();

            Property(p => p.H0160017)
                .HasColumnName("H0160017")
                .HasColumnOrder(123)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0160017")
                .IsOptional();

            Property(p => p.H0170001)
                .HasColumnName("H0170001")
                .HasColumnOrder(124)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0170001")
                .IsOptional();

            Property(p => p.H0170002)
                .HasColumnName("H0170002")
                .HasColumnOrder(125)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0170002")
                .IsOptional();

            Property(p => p.H0170003)
                .HasColumnName("H0170003")
                .HasColumnOrder(126)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0170003")
                .IsOptional();

            Property(p => p.H0170004)
                .HasColumnName("H0170004")
                .HasColumnOrder(127)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0170004")
                .IsOptional();

            Property(p => p.H0170005)
                .HasColumnName("H0170005")
                .HasColumnOrder(128)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0170005")
                .IsOptional();

            Property(p => p.H0170006)
                .HasColumnName("H0170006")
                .HasColumnOrder(129)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0170006")
                .IsOptional();

            Property(p => p.H0170007)
                .HasColumnName("H0170007")
                .HasColumnOrder(130)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0170007")
                .IsOptional();

            Property(p => p.H0170008)
                .HasColumnName("H0170008")
                .HasColumnOrder(131)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0170008")
                .IsOptional();

            Property(p => p.H0170009)
                .HasColumnName("H0170009")
                .HasColumnOrder(132)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0170009")
                .IsOptional();

            Property(p => p.H0170010)
                .HasColumnName("H0170010")
                .HasColumnOrder(133)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0170010")
                .IsOptional();

            Property(p => p.H0170011)
                .HasColumnName("H0170011")
                .HasColumnOrder(134)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0170011")
                .IsOptional();

            Property(p => p.H0170012)
                .HasColumnName("H0170012")
                .HasColumnOrder(135)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0170012")
                .IsOptional();

            Property(p => p.H0170013)
                .HasColumnName("H0170013")
                .HasColumnOrder(136)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0170013")
                .IsOptional();

            Property(p => p.H0170014)
                .HasColumnName("H0170014")
                .HasColumnOrder(137)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0170014")
                .IsOptional();

            Property(p => p.H0170015)
                .HasColumnName("H0170015")
                .HasColumnOrder(138)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0170015")
                .IsOptional();

            Property(p => p.H0170016)
                .HasColumnName("H0170016")
                .HasColumnOrder(139)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0170016")
                .IsOptional();

            Property(p => p.H0170017)
                .HasColumnName("H0170017")
                .HasColumnOrder(140)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0170017")
                .IsOptional();

            Property(p => p.H0170018)
                .HasColumnName("H0170018")
                .HasColumnOrder(141)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0170018")
                .IsOptional();

            Property(p => p.H0170019)
                .HasColumnName("H0170019")
                .HasColumnOrder(142)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0170019")
                .IsOptional();

            Property(p => p.H0170020)
                .HasColumnName("H0170020")
                .HasColumnOrder(143)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0170020")
                .IsOptional();

            Property(p => p.H0170021)
                .HasColumnName("H0170021")
                .HasColumnOrder(144)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0170021")
                .IsOptional();

            Property(p => p.H0180001)
                .HasColumnName("H0180001")
                .HasColumnOrder(145)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180001")
                .IsOptional();

            Property(p => p.H0180002)
                .HasColumnName("H0180002")
                .HasColumnOrder(146)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180002")
                .IsOptional();

            Property(p => p.H0180003)
                .HasColumnName("H0180003")
                .HasColumnOrder(147)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180003")
                .IsOptional();

            Property(p => p.H0180004)
                .HasColumnName("H0180004")
                .HasColumnOrder(148)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180004")
                .IsOptional();

            Property(p => p.H0180005)
                .HasColumnName("H0180005")
                .HasColumnOrder(149)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180005")
                .IsOptional();

            Property(p => p.H0180006)
                .HasColumnName("H0180006")
                .HasColumnOrder(150)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180006")
                .IsOptional();

            Property(p => p.H0180007)
                .HasColumnName("H0180007")
                .HasColumnOrder(151)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180007")
                .IsOptional();

            Property(p => p.H0180008)
                .HasColumnName("H0180008")
                .HasColumnOrder(152)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180008")
                .IsOptional();

            Property(p => p.H0180009)
                .HasColumnName("H0180009")
                .HasColumnOrder(153)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180009")
                .IsOptional();

            Property(p => p.H0180010)
                .HasColumnName("H0180010")
                .HasColumnOrder(154)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180010")
                .IsOptional();

            Property(p => p.H0180011)
                .HasColumnName("H0180011")
                .HasColumnOrder(155)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180011")
                .IsOptional();

            Property(p => p.H0180012)
                .HasColumnName("H0180012")
                .HasColumnOrder(156)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180012")
                .IsOptional();

            Property(p => p.H0180013)
                .HasColumnName("H0180013")
                .HasColumnOrder(157)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180013")
                .IsOptional();

            Property(p => p.H0180014)
                .HasColumnName("H0180014")
                .HasColumnOrder(158)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180014")
                .IsOptional();

            Property(p => p.H0180015)
                .HasColumnName("H0180015")
                .HasColumnOrder(159)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180015")
                .IsOptional();

            Property(p => p.H0180016)
                .HasColumnName("H0180016")
                .HasColumnOrder(160)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180016")
                .IsOptional();

            Property(p => p.H0180017)
                .HasColumnName("H0180017")
                .HasColumnOrder(161)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180017")
                .IsOptional();

            Property(p => p.H0180018)
                .HasColumnName("H0180018")
                .HasColumnOrder(162)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180018")
                .IsOptional();

            Property(p => p.H0180019)
                .HasColumnName("H0180019")
                .HasColumnOrder(163)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180019")
                .IsOptional();

            Property(p => p.H0180020)
                .HasColumnName("H0180020")
                .HasColumnOrder(164)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180020")
                .IsOptional();

            Property(p => p.H0180021)
                .HasColumnName("H0180021")
                .HasColumnOrder(165)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180021")
                .IsOptional();

            Property(p => p.H0180022)
                .HasColumnName("H0180022")
                .HasColumnOrder(166)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180022")
                .IsOptional();

            Property(p => p.H0180023)
                .HasColumnName("H0180023")
                .HasColumnOrder(167)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180023")
                .IsOptional();

            Property(p => p.H0180024)
                .HasColumnName("H0180024")
                .HasColumnOrder(168)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180024")
                .IsOptional();

            Property(p => p.H0180025)
                .HasColumnName("H0180025")
                .HasColumnOrder(169)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180025")
                .IsOptional();

            Property(p => p.H0180026)
                .HasColumnName("H0180026")
                .HasColumnOrder(170)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180026")
                .IsOptional();

            Property(p => p.H0180027)
                .HasColumnName("H0180027")
                .HasColumnOrder(171)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180027")
                .IsOptional();

            Property(p => p.H0180028)
                .HasColumnName("H0180028")
                .HasColumnOrder(172)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180028")
                .IsOptional();

            Property(p => p.H0180029)
                .HasColumnName("H0180029")
                .HasColumnOrder(173)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180029")
                .IsOptional();

            Property(p => p.H0180030)
                .HasColumnName("H0180030")
                .HasColumnOrder(174)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180030")
                .IsOptional();

            Property(p => p.H0180031)
                .HasColumnName("H0180031")
                .HasColumnOrder(175)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180031")
                .IsOptional();

            Property(p => p.H0180032)
                .HasColumnName("H0180032")
                .HasColumnOrder(176)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180032")
                .IsOptional();

            Property(p => p.H0180033)
                .HasColumnName("H0180033")
                .HasColumnOrder(177)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180033")
                .IsOptional();

            Property(p => p.H0180034)
                .HasColumnName("H0180034")
                .HasColumnOrder(178)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180034")
                .IsOptional();

            Property(p => p.H0180035)
                .HasColumnName("H0180035")
                .HasColumnOrder(179)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180035")
                .IsOptional();

            Property(p => p.H0180036)
                .HasColumnName("H0180036")
                .HasColumnOrder(180)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180036")
                .IsOptional();

            Property(p => p.H0180037)
                .HasColumnName("H0180037")
                .HasColumnOrder(181)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180037")
                .IsOptional();

            Property(p => p.H0180038)
                .HasColumnName("H0180038")
                .HasColumnOrder(182)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180038")
                .IsOptional();

            Property(p => p.H0180039)
                .HasColumnName("H0180039")
                .HasColumnOrder(183)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180039")
                .IsOptional();

            Property(p => p.H0180040)
                .HasColumnName("H0180040")
                .HasColumnOrder(184)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180040")
                .IsOptional();

            Property(p => p.H0180041)
                .HasColumnName("H0180041")
                .HasColumnOrder(185)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180041")
                .IsOptional();

            Property(p => p.H0180042)
                .HasColumnName("H0180042")
                .HasColumnOrder(186)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180042")
                .IsOptional();

            Property(p => p.H0180043)
                .HasColumnName("H0180043")
                .HasColumnOrder(187)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180043")
                .IsOptional();

            Property(p => p.H0180044)
                .HasColumnName("H0180044")
                .HasColumnOrder(188)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180044")
                .IsOptional();

            Property(p => p.H0180045)
                .HasColumnName("H0180045")
                .HasColumnOrder(189)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180045")
                .IsOptional();

            Property(p => p.H0180046)
                .HasColumnName("H0180046")
                .HasColumnOrder(190)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180046")
                .IsOptional();

            Property(p => p.H0180047)
                .HasColumnName("H0180047")
                .HasColumnOrder(191)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180047")
                .IsOptional();

            Property(p => p.H0180048)
                .HasColumnName("H0180048")
                .HasColumnOrder(192)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180048")
                .IsOptional();

            Property(p => p.H0180049)
                .HasColumnName("H0180049")
                .HasColumnOrder(193)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180049")
                .IsOptional();

            Property(p => p.H0180050)
                .HasColumnName("H0180050")
                .HasColumnOrder(194)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180050")
                .IsOptional();

            Property(p => p.H0180051)
                .HasColumnName("H0180051")
                .HasColumnOrder(195)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180051")
                .IsOptional();

            Property(p => p.H0180052)
                .HasColumnName("H0180052")
                .HasColumnOrder(196)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180052")
                .IsOptional();

            Property(p => p.H0180053)
                .HasColumnName("H0180053")
                .HasColumnOrder(197)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180053")
                .IsOptional();

            Property(p => p.H0180054)
                .HasColumnName("H0180054")
                .HasColumnOrder(198)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180054")
                .IsOptional();

            Property(p => p.H0180055)
                .HasColumnName("H0180055")
                .HasColumnOrder(199)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180055")
                .IsOptional();

            Property(p => p.H0180056)
                .HasColumnName("H0180056")
                .HasColumnOrder(200)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180056")
                .IsOptional();

            Property(p => p.H0180057)
                .HasColumnName("H0180057")
                .HasColumnOrder(201)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180057")
                .IsOptional();

            Property(p => p.H0180058)
                .HasColumnName("H0180058")
                .HasColumnOrder(202)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180058")
                .IsOptional();

            Property(p => p.H0180059)
                .HasColumnName("H0180059")
                .HasColumnOrder(203)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180059")
                .IsOptional();

            Property(p => p.H0180060)
                .HasColumnName("H0180060")
                .HasColumnOrder(204)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180060")
                .IsOptional();

            Property(p => p.H0180061)
                .HasColumnName("H0180061")
                .HasColumnOrder(205)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180061")
                .IsOptional();

            Property(p => p.H0180062)
                .HasColumnName("H0180062")
                .HasColumnOrder(206)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180062")
                .IsOptional();

            Property(p => p.H0180063)
                .HasColumnName("H0180063")
                .HasColumnOrder(207)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180063")
                .IsOptional();

            Property(p => p.H0180064)
                .HasColumnName("H0180064")
                .HasColumnOrder(208)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180064")
                .IsOptional();

            Property(p => p.H0180065)
                .HasColumnName("H0180065")
                .HasColumnOrder(209)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180065")
                .IsOptional();

            Property(p => p.H0180066)
                .HasColumnName("H0180066")
                .HasColumnOrder(210)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180066")
                .IsOptional();

            Property(p => p.H0180067)
                .HasColumnName("H0180067")
                .HasColumnOrder(211)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180067")
                .IsOptional();

            Property(p => p.H0180068)
                .HasColumnName("H0180068")
                .HasColumnOrder(212)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180068")
                .IsOptional();

            Property(p => p.H0180069)
                .HasColumnName("H0180069")
                .HasColumnOrder(213)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0180069")
                .IsOptional();

            Property(p => p.H0190001)
                .HasColumnName("H0190001")
                .HasColumnOrder(214)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0190001")
                .IsOptional();

            Property(p => p.H0190002)
                .HasColumnName("H0190002")
                .HasColumnOrder(215)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0190002")
                .IsOptional();

            Property(p => p.H0190003)
                .HasColumnName("H0190003")
                .HasColumnOrder(216)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0190003")
                .IsOptional();

            Property(p => p.H0190004)
                .HasColumnName("H0190004")
                .HasColumnOrder(217)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0190004")
                .IsOptional();

            Property(p => p.H0190005)
                .HasColumnName("H0190005")
                .HasColumnOrder(218)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0190005")
                .IsOptional();

            Property(p => p.H0190006)
                .HasColumnName("H0190006")
                .HasColumnOrder(219)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0190006")
                .IsOptional();

            Property(p => p.H0190007)
                .HasColumnName("H0190007")
                .HasColumnOrder(220)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0190007")
                .IsOptional();

            Property(p => p.H0200001)
                .HasColumnName("H0200001")
                .HasColumnOrder(221)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0200001")
                .IsOptional();

            Property(p => p.H0200002)
                .HasColumnName("H0200002")
                .HasColumnOrder(222)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0200002")
                .IsOptional();

            Property(p => p.H0200003)
                .HasColumnName("H0200003")
                .HasColumnOrder(223)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0200003")
                .IsOptional();

            Property(p => p.H0210001)
                .HasColumnName("H0210001")
                .HasColumnOrder(224)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0210001")
                .IsOptional();

            Property(p => p.H0210002)
                .HasColumnName("H0210002")
                .HasColumnOrder(225)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0210002")
                .IsOptional();

            Property(p => p.H0210003)
                .HasColumnName("H0210003")
                .HasColumnOrder(226)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0210003")
                .IsOptional();

            Property(p => p.H0220001)
                .HasColumnName("H0220001")
                .HasColumnOrder(227)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0220001")
                .IsOptional();

            Property(p => p.H0220002)
                .HasColumnName("H0220002")
                .HasColumnOrder(228)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0220002")
                .IsOptional();

            Property(p => p.H0220003)
                .HasColumnName("H0220003")
                .HasColumnOrder(229)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H0220003")
                .IsOptional();

            Property(p => p.H011A0001)
                .HasColumnName("H011A0001")
                .HasColumnOrder(230)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H011A0001")
                .IsOptional();

            Property(p => p.H011A0002)
                .HasColumnName("H011A0002")
                .HasColumnOrder(231)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H011A0002")
                .IsOptional();

            Property(p => p.H011A0003)
                .HasColumnName("H011A0003")
                .HasColumnOrder(232)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H011A0003")
                .IsOptional();

            Property(p => p.H011A0004)
                .HasColumnName("H011A0004")
                .HasColumnOrder(233)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H011A0004")
                .IsOptional();

            Property(p => p.H011B0001)
                .HasColumnName("H011B0001")
                .HasColumnOrder(234)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H011B0001")
                .IsOptional();

            Property(p => p.H011B0002)
                .HasColumnName("H011B0002")
                .HasColumnOrder(235)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H011B0002")
                .IsOptional();

            Property(p => p.H011B0003)
                .HasColumnName("H011B0003")
                .HasColumnOrder(236)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H011B0003")
                .IsOptional();

            Property(p => p.H011B0004)
                .HasColumnName("H011B0004")
                .HasColumnOrder(237)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H011B0004")
                .IsOptional();

            Property(p => p.H011C0001)
                .HasColumnName("H011C0001")
                .HasColumnOrder(238)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H011C0001")
                .IsOptional();

            Property(p => p.H011C0002)
                .HasColumnName("H011C0002")
                .HasColumnOrder(239)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H011C0002")
                .IsOptional();

            Property(p => p.H011C0003)
                .HasColumnName("H011C0003")
                .HasColumnOrder(240)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H011C0003")
                .IsOptional();

            Property(p => p.H011C0004)
                .HasColumnName("H011C0004")
                .HasColumnOrder(241)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H011C0004")
                .IsOptional();

            Property(p => p.H011D0001)
                .HasColumnName("H011D0001")
                .HasColumnOrder(242)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H011D0001")
                .IsOptional();

            Property(p => p.H011D0002)
                .HasColumnName("H011D0002")
                .HasColumnOrder(243)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H011D0002")
                .IsOptional();

            Property(p => p.H011D0003)
                .HasColumnName("H011D0003")
                .HasColumnOrder(244)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H011D0003")
                .IsOptional();

            Property(p => p.H011D0004)
                .HasColumnName("H011D0004")
                .HasColumnOrder(245)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H011D0004")
                .IsOptional();

            Property(p => p.H011E0001)
                .HasColumnName("H011E0001")
                .HasColumnOrder(246)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H011E0001")
                .IsOptional();

            Property(p => p.H011E0002)
                .HasColumnName("H011E0002")
                .HasColumnOrder(247)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H011E0002")
                .IsOptional();

            Property(p => p.H011E0003)
                .HasColumnName("H011E0003")
                .HasColumnOrder(248)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H011E0003")
                .IsOptional();

            Property(p => p.H011E0004)
                .HasColumnName("H011E0004")
                .HasColumnOrder(249)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H011E0004")
                .IsOptional();

            Property(p => p.H011F0001)
                .HasColumnName("H011F0001")
                .HasColumnOrder(250)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H011F0001")
                .IsOptional();

            Property(p => p.H011F0002)
                .HasColumnName("H011F0002")
                .HasColumnOrder(251)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H011F0002")
                .IsOptional();

            Property(p => p.H011F0003)
                .HasColumnName("H011F0003")
                .HasColumnOrder(252)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H011F0003")
                .IsOptional();

            Property(p => p.H011F0004)
                .HasColumnName("H011F0004")
                .HasColumnOrder(253)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("H011F0004")
                .IsOptional();
        }
    }
}
