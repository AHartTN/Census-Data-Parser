#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2016 12:06 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1CongressionalDistricts113_SF1_00016Map.cs
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

    public class SF1CongressionalDistricts113_SF1_00016Map : EntityTypeConfiguration<SF1CongressionalDistricts113_SF1_00016>
    {
        public SF1CongressionalDistricts113_SF1_00016Map()
        {
            ToTable("SF1_00016", "SF1CongressionalDistricts113");

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

            Property(p => p.PCT0090001)
                .HasColumnName("PCT0090001")
                .HasColumnOrder(5)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0090001")
                .IsOptional();

            Property(p => p.PCT0090002)
                .HasColumnName("PCT0090002")
                .HasColumnOrder(6)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0090002")
                .IsOptional();

            Property(p => p.PCT0090003)
                .HasColumnName("PCT0090003")
                .HasColumnOrder(7)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0090003")
                .IsOptional();

            Property(p => p.PCT0090004)
                .HasColumnName("PCT0090004")
                .HasColumnOrder(8)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0090004")
                .IsOptional();

            Property(p => p.PCT0090005)
                .HasColumnName("PCT0090005")
                .HasColumnOrder(9)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0090005")
                .IsOptional();

            Property(p => p.PCT0090006)
                .HasColumnName("PCT0090006")
                .HasColumnOrder(10)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0090006")
                .IsOptional();

            Property(p => p.PCT0090007)
                .HasColumnName("PCT0090007")
                .HasColumnOrder(11)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0090007")
                .IsOptional();

            Property(p => p.PCT0090008)
                .HasColumnName("PCT0090008")
                .HasColumnOrder(12)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0090008")
                .IsOptional();

            Property(p => p.PCT0090009)
                .HasColumnName("PCT0090009")
                .HasColumnOrder(13)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0090009")
                .IsOptional();

            Property(p => p.PCT0090010)
                .HasColumnName("PCT0090010")
                .HasColumnOrder(14)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0090010")
                .IsOptional();

            Property(p => p.PCT0090011)
                .HasColumnName("PCT0090011")
                .HasColumnOrder(15)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0090011")
                .IsOptional();

            Property(p => p.PCT0090012)
                .HasColumnName("PCT0090012")
                .HasColumnOrder(16)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0090012")
                .IsOptional();

            Property(p => p.PCT0090013)
                .HasColumnName("PCT0090013")
                .HasColumnOrder(17)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0090013")
                .IsOptional();

            Property(p => p.PCT0090014)
                .HasColumnName("PCT0090014")
                .HasColumnOrder(18)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0090014")
                .IsOptional();

            Property(p => p.PCT0100001)
                .HasColumnName("PCT0100001")
                .HasColumnOrder(19)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0100001")
                .IsOptional();

            Property(p => p.PCT0100002)
                .HasColumnName("PCT0100002")
                .HasColumnOrder(20)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0100002")
                .IsOptional();

            Property(p => p.PCT0100003)
                .HasColumnName("PCT0100003")
                .HasColumnOrder(21)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0100003")
                .IsOptional();

            Property(p => p.PCT0100004)
                .HasColumnName("PCT0100004")
                .HasColumnOrder(22)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0100004")
                .IsOptional();

            Property(p => p.PCT0100005)
                .HasColumnName("PCT0100005")
                .HasColumnOrder(23)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0100005")
                .IsOptional();

            Property(p => p.PCT0100006)
                .HasColumnName("PCT0100006")
                .HasColumnOrder(24)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0100006")
                .IsOptional();

            Property(p => p.PCT0100007)
                .HasColumnName("PCT0100007")
                .HasColumnOrder(25)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0100007")
                .IsOptional();

            Property(p => p.PCT0100008)
                .HasColumnName("PCT0100008")
                .HasColumnOrder(26)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0100008")
                .IsOptional();

            Property(p => p.PCT0100009)
                .HasColumnName("PCT0100009")
                .HasColumnOrder(27)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0100009")
                .IsOptional();

            Property(p => p.PCT0100010)
                .HasColumnName("PCT0100010")
                .HasColumnOrder(28)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0100010")
                .IsOptional();

            Property(p => p.PCT0100011)
                .HasColumnName("PCT0100011")
                .HasColumnOrder(29)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0100011")
                .IsOptional();

            Property(p => p.PCT0100012)
                .HasColumnName("PCT0100012")
                .HasColumnOrder(30)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0100012")
                .IsOptional();

            Property(p => p.PCT0100013)
                .HasColumnName("PCT0100013")
                .HasColumnOrder(31)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0100013")
                .IsOptional();

            Property(p => p.PCT0100014)
                .HasColumnName("PCT0100014")
                .HasColumnOrder(32)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0100014")
                .IsOptional();

            Property(p => p.PCT0110001)
                .HasColumnName("PCT0110001")
                .HasColumnOrder(33)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110001")
                .IsOptional();

            Property(p => p.PCT0110002)
                .HasColumnName("PCT0110002")
                .HasColumnOrder(34)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110002")
                .IsOptional();

            Property(p => p.PCT0110003)
                .HasColumnName("PCT0110003")
                .HasColumnOrder(35)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110003")
                .IsOptional();

            Property(p => p.PCT0110004)
                .HasColumnName("PCT0110004")
                .HasColumnOrder(36)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110004")
                .IsOptional();

            Property(p => p.PCT0110005)
                .HasColumnName("PCT0110005")
                .HasColumnOrder(37)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110005")
                .IsOptional();

            Property(p => p.PCT0110006)
                .HasColumnName("PCT0110006")
                .HasColumnOrder(38)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110006")
                .IsOptional();

            Property(p => p.PCT0110007)
                .HasColumnName("PCT0110007")
                .HasColumnOrder(39)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110007")
                .IsOptional();

            Property(p => p.PCT0110008)
                .HasColumnName("PCT0110008")
                .HasColumnOrder(40)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110008")
                .IsOptional();

            Property(p => p.PCT0110009)
                .HasColumnName("PCT0110009")
                .HasColumnOrder(41)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110009")
                .IsOptional();

            Property(p => p.PCT0110010)
                .HasColumnName("PCT0110010")
                .HasColumnOrder(42)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110010")
                .IsOptional();

            Property(p => p.PCT0110011)
                .HasColumnName("PCT0110011")
                .HasColumnOrder(43)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110011")
                .IsOptional();

            Property(p => p.PCT0110012)
                .HasColumnName("PCT0110012")
                .HasColumnOrder(44)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110012")
                .IsOptional();

            Property(p => p.PCT0110013)
                .HasColumnName("PCT0110013")
                .HasColumnOrder(45)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110013")
                .IsOptional();

            Property(p => p.PCT0110014)
                .HasColumnName("PCT0110014")
                .HasColumnOrder(46)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110014")
                .IsOptional();

            Property(p => p.PCT0110015)
                .HasColumnName("PCT0110015")
                .HasColumnOrder(47)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110015")
                .IsOptional();

            Property(p => p.PCT0110016)
                .HasColumnName("PCT0110016")
                .HasColumnOrder(48)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110016")
                .IsOptional();

            Property(p => p.PCT0110017)
                .HasColumnName("PCT0110017")
                .HasColumnOrder(49)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110017")
                .IsOptional();

            Property(p => p.PCT0110018)
                .HasColumnName("PCT0110018")
                .HasColumnOrder(50)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110018")
                .IsOptional();

            Property(p => p.PCT0110019)
                .HasColumnName("PCT0110019")
                .HasColumnOrder(51)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110019")
                .IsOptional();

            Property(p => p.PCT0110020)
                .HasColumnName("PCT0110020")
                .HasColumnOrder(52)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110020")
                .IsOptional();

            Property(p => p.PCT0110021)
                .HasColumnName("PCT0110021")
                .HasColumnOrder(53)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110021")
                .IsOptional();

            Property(p => p.PCT0110022)
                .HasColumnName("PCT0110022")
                .HasColumnOrder(54)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110022")
                .IsOptional();

            Property(p => p.PCT0110023)
                .HasColumnName("PCT0110023")
                .HasColumnOrder(55)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110023")
                .IsOptional();

            Property(p => p.PCT0110024)
                .HasColumnName("PCT0110024")
                .HasColumnOrder(56)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110024")
                .IsOptional();

            Property(p => p.PCT0110025)
                .HasColumnName("PCT0110025")
                .HasColumnOrder(57)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110025")
                .IsOptional();

            Property(p => p.PCT0110026)
                .HasColumnName("PCT0110026")
                .HasColumnOrder(58)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110026")
                .IsOptional();

            Property(p => p.PCT0110027)
                .HasColumnName("PCT0110027")
                .HasColumnOrder(59)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110027")
                .IsOptional();

            Property(p => p.PCT0110028)
                .HasColumnName("PCT0110028")
                .HasColumnOrder(60)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110028")
                .IsOptional();

            Property(p => p.PCT0110029)
                .HasColumnName("PCT0110029")
                .HasColumnOrder(61)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110029")
                .IsOptional();

            Property(p => p.PCT0110030)
                .HasColumnName("PCT0110030")
                .HasColumnOrder(62)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110030")
                .IsOptional();

            Property(p => p.PCT0110031)
                .HasColumnName("PCT0110031")
                .HasColumnOrder(63)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasParameterName("PCT0110031")
                .IsOptional();
        }
    }
}
