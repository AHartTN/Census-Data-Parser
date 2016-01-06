#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/06/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: Redistricting_PL_Geo_HeaderMap.cs
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

	public class Redistricting_PL_Geo_HeaderMap : EntityTypeConfiguration<Redistricting_PL_Geo_Header>
	{
		public Redistricting_PL_Geo_HeaderMap()
		{
			ToTable("PL_Geo_Header", "Redistricting");

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
				.HasMaxLength(6)
				.HasParameterName("FILEID")
				.IsRequired();

			Property(p => p.STUSAB)
				.HasColumnName("STUSAB")
				.HasColumnOrder(1)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("STUSAB")
				.IsRequired();

			Property(p => p.SUMLEV)
				.HasColumnName("SUMLEV")
				.HasColumnOrder(2)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(3)
				.HasParameterName("SUMLEV")
				.IsOptional();

			Property(p => p.GEOCOMP)
				.HasColumnName("GEOCOMP")
				.HasColumnOrder(3)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("GEOCOMP")
				.IsOptional();

			Property(p => p.CHARITER)
				.HasColumnName("CHARITER")
				.HasColumnOrder(4)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(3)
				.HasParameterName("CHARITER")
				.IsRequired();

			Property(p => p.CIFSN)
				.HasColumnName("CIFSN")
				.HasColumnOrder(5)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("CIFSN")
				.IsRequired();

			Property(p => p.LOGRECNO)
				.HasColumnName("LOGRECNO")
				.HasColumnOrder(6)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(7)
				.HasParameterName("LOGRECNO")
				.IsRequired();

			Property(p => p.REGION)
				.HasColumnName("REGION")
				.HasColumnOrder(7)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(1)
				.HasParameterName("REGION")
				.IsOptional();

			Property(p => p.DIVISION)
				.HasColumnName("DIVISION")
				.HasColumnOrder(8)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(1)
				.HasParameterName("DIVISION")
				.IsOptional();

			Property(p => p.STATE)
				.HasColumnName("STATE")
				.HasColumnOrder(9)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("STATE")
				.IsOptional();

			Property(p => p.COUNTY)
				.HasColumnName("COUNTY")
				.HasColumnOrder(10)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(3)
				.HasParameterName("COUNTY")
				.IsOptional();

			Property(p => p.COUNTYCC)
				.HasColumnName("COUNTYCC")
				.HasColumnOrder(11)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("COUNTYCC")
				.IsOptional();

			Property(p => p.COUNTYSC)
				.HasColumnName("COUNTYSC")
				.HasColumnOrder(12)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("COUNTYSC")
				.IsOptional();

			Property(p => p.COUSUB)
				.HasColumnName("COUSUB")
				.HasColumnOrder(13)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(5)
				.HasParameterName("COUSUB")
				.IsOptional();

			Property(p => p.COUSUBCC)
				.HasColumnName("COUSUBCC")
				.HasColumnOrder(14)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("COUSUBCC")
				.IsOptional();

			Property(p => p.COUSUBSC)
				.HasColumnName("COUSUBSC")
				.HasColumnOrder(15)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("COUSUBSC")
				.IsOptional();

			Property(p => p.PLACE)
				.HasColumnName("PLACE")
				.HasColumnOrder(16)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(5)
				.HasParameterName("PLACE")
				.IsOptional();

			Property(p => p.PLACECC)
				.HasColumnName("PLACECC")
				.HasColumnOrder(17)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("PLACECC")
				.IsOptional();

			Property(p => p.PLACESC)
				.HasColumnName("PLACESC")
				.HasColumnOrder(18)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("PLACESC")
				.IsOptional();

			Property(p => p.TRACT)
				.HasColumnName("TRACT")
				.HasColumnOrder(19)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(6)
				.HasParameterName("TRACT")
				.IsOptional();

			Property(p => p.BLKGRP)
				.HasColumnName("BLKGRP")
				.HasColumnOrder(20)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(1)
				.HasParameterName("BLKGRP")
				.IsOptional();

			Property(p => p.BLOCK)
				.HasColumnName("BLOCK")
				.HasColumnOrder(21)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(4)
				.HasParameterName("BLOCK")
				.IsOptional();

			Property(p => p.IUC)
				.HasColumnName("IUC")
				.HasColumnOrder(22)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("IUC")
				.IsOptional();

			Property(p => p.CONCIT)
				.HasColumnName("CONCIT")
				.HasColumnOrder(23)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(5)
				.HasParameterName("CONCIT")
				.IsOptional();

			Property(p => p.CONCITCC)
				.HasColumnName("CONCITCC")
				.HasColumnOrder(24)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("CONCITCC")
				.IsOptional();

			Property(p => p.CONCITSC)
				.HasColumnName("CONCITSC")
				.HasColumnOrder(25)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("CONCITSC")
				.IsOptional();

			Property(p => p.AIANHH)
				.HasColumnName("AIANHH")
				.HasColumnOrder(26)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(4)
				.HasParameterName("AIANHH")
				.IsOptional();

			Property(p => p.AIANHHFP)
				.HasColumnName("AIANHHFP")
				.HasColumnOrder(27)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(5)
				.HasParameterName("AIANHHFP")
				.IsOptional();

			Property(p => p.AIANHHCC)
				.HasColumnName("AIANHHCC")
				.HasColumnOrder(28)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("AIANHHCC")
				.IsOptional();

			Property(p => p.AIHHTLI)
				.HasColumnName("AIHHTLI")
				.HasColumnOrder(29)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(1)
				.HasParameterName("AIHHTLI")
				.IsOptional();

			Property(p => p.AITSCE)
				.HasColumnName("AITSCE")
				.HasColumnOrder(30)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(3)
				.HasParameterName("AITSCE")
				.IsOptional();

			Property(p => p.AITS)
				.HasColumnName("AITS")
				.HasColumnOrder(31)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(5)
				.HasParameterName("AITS")
				.IsOptional();

			Property(p => p.AITSCC)
				.HasColumnName("AITSCC")
				.HasColumnOrder(32)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("AITSCC")
				.IsOptional();

			Property(p => p.TTRACT)
				.HasColumnName("TTRACT")
				.HasColumnOrder(33)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(6)
				.HasParameterName("TTRACT")
				.IsOptional();

			Property(p => p.TBLKGRP)
				.HasColumnName("TBLKGRP")
				.HasColumnOrder(34)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(1)
				.HasParameterName("TBLKGRP")
				.IsOptional();

			Property(p => p.ANRC)
				.HasColumnName("ANRC")
				.HasColumnOrder(35)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(5)
				.HasParameterName("ANRC")
				.IsOptional();

			Property(p => p.ANRCCC)
				.HasColumnName("ANRCCC")
				.HasColumnOrder(36)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("ANRCCC")
				.IsOptional();

			Property(p => p.CBSA)
				.HasColumnName("CBSA")
				.HasColumnOrder(37)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(5)
				.HasParameterName("CBSA")
				.IsOptional();

			Property(p => p.CBSASC)
				.HasColumnName("CBSASC")
				.HasColumnOrder(38)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("CBSASC")
				.IsOptional();

			Property(p => p.METDIV)
				.HasColumnName("METDIV")
				.HasColumnOrder(39)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(5)
				.HasParameterName("METDIV")
				.IsOptional();

			Property(p => p.CSA)
				.HasColumnName("CSA")
				.HasColumnOrder(40)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(3)
				.HasParameterName("CSA")
				.IsOptional();

			Property(p => p.NECTA)
				.HasColumnName("NECTA")
				.HasColumnOrder(41)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(5)
				.HasParameterName("NECTA")
				.IsOptional();

			Property(p => p.NECTASC)
				.HasColumnName("NECTASC")
				.HasColumnOrder(42)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("NECTASC")
				.IsOptional();

			Property(p => p.NECTADIV)
				.HasColumnName("NECTADIV")
				.HasColumnOrder(43)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(5)
				.HasParameterName("NECTADIV")
				.IsOptional();

			Property(p => p.CNECTA)
				.HasColumnName("CNECTA")
				.HasColumnOrder(44)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(3)
				.HasParameterName("CNECTA")
				.IsOptional();

			Property(p => p.CBSAPCI)
				.HasColumnName("CBSAPCI")
				.HasColumnOrder(45)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(1)
				.HasParameterName("CBSAPCI")
				.IsOptional();

			Property(p => p.NECTAPCI)
				.HasColumnName("NECTAPCI")
				.HasColumnOrder(46)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(1)
				.HasParameterName("NECTAPCI")
				.IsOptional();

			Property(p => p.UA)
				.HasColumnName("UA")
				.HasColumnOrder(47)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(5)
				.HasParameterName("UA")
				.IsOptional();

			Property(p => p.UASC)
				.HasColumnName("UASC")
				.HasColumnOrder(48)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("UASC")
				.IsOptional();

			Property(p => p.UATYPE)
				.HasColumnName("UATYPE")
				.HasColumnOrder(49)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(1)
				.HasParameterName("UATYPE")
				.IsOptional();

			Property(p => p.UR)
				.HasColumnName("UR")
				.HasColumnOrder(50)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(1)
				.HasParameterName("UR")
				.IsOptional();

			Property(p => p.CD)
				.HasColumnName("CD")
				.HasColumnOrder(51)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("CD")
				.IsOptional();

			Property(p => p.SLDU)
				.HasColumnName("SLDU")
				.HasColumnOrder(52)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(3)
				.HasParameterName("SLDU")
				.IsOptional();

			Property(p => p.SLDL)
				.HasColumnName("SLDL")
				.HasColumnOrder(53)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(3)
				.HasParameterName("SLDL")
				.IsOptional();

			Property(p => p.VTD)
				.HasColumnName("VTD")
				.HasColumnOrder(54)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(6)
				.HasParameterName("VTD")
				.IsOptional();

			Property(p => p.VTDI)
				.HasColumnName("VTDI")
				.HasColumnOrder(55)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(1)
				.HasParameterName("VTDI")
				.IsOptional();

			Property(p => p.RESERVE2)
				.HasColumnName("RESERVE2")
				.HasColumnOrder(56)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(3)
				.HasParameterName("RESERVE2")
				.IsOptional();

			Property(p => p.ZCTA5)
				.HasColumnName("ZCTA5")
				.HasColumnOrder(57)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(5)
				.HasParameterName("ZCTA5")
				.IsOptional();

			Property(p => p.SUBMCD)
				.HasColumnName("SUBMCD")
				.HasColumnOrder(58)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(5)
				.HasParameterName("SUBMCD")
				.IsOptional();

			Property(p => p.SUBMCDCC)
				.HasColumnName("SUBMCDCC")
				.HasColumnOrder(59)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("SUBMCDCC")
				.IsOptional();

			Property(p => p.SDELM)
				.HasColumnName("SDELM")
				.HasColumnOrder(60)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(5)
				.HasParameterName("SDELM")
				.IsOptional();

			Property(p => p.SDSEC)
				.HasColumnName("SDSEC")
				.HasColumnOrder(61)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(5)
				.HasParameterName("SDSEC")
				.IsOptional();

			Property(p => p.SDUNI)
				.HasColumnName("SDUNI")
				.HasColumnOrder(62)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(5)
				.HasParameterName("SDUNI")
				.IsOptional();

			Property(p => p.AREALAND)
				.HasColumnName("AREALAND")
				.HasColumnOrder(63)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(14)
				.HasParameterName("AREALAND")
				.IsOptional();

			Property(p => p.AREAWATR)
				.HasColumnName("AREAWATR")
				.HasColumnOrder(64)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(14)
				.HasParameterName("AREAWATR")
				.IsOptional();

			Property(p => p.NAME)
				.HasColumnName("NAME")
				.HasColumnOrder(65)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(90)
				.HasParameterName("NAME")
				.IsOptional();

			Property(p => p.FUNCSTAT)
				.HasColumnName("FUNCSTAT")
				.HasColumnOrder(66)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(1)
				.HasParameterName("FUNCSTAT")
				.IsOptional();

			Property(p => p.GCUNI)
				.HasColumnName("GCUNI")
				.HasColumnOrder(67)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(1)
				.HasParameterName("GCUNI")
				.IsOptional();

			Property(p => p.POP100)
				.HasColumnName("POP100")
				.HasColumnOrder(68)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(9)
				.HasParameterName("POP100")
				.IsOptional();

			Property(p => p.HU100)
				.HasColumnName("HU100")
				.HasColumnOrder(69)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(9)
				.HasParameterName("HU100")
				.IsOptional();

			Property(p => p.INTPTLAT)
				.HasColumnName("INTPTLAT")
				.HasColumnOrder(70)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(11)
				.HasParameterName("INTPTLAT")
				.IsOptional();

			Property(p => p.INTPTLON)
				.HasColumnName("INTPTLON")
				.HasColumnOrder(71)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(12)
				.HasParameterName("INTPTLON")
				.IsOptional();

			Property(p => p.LSADC)
				.HasColumnName("LSADC")
				.HasColumnOrder(72)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("LSADC")
				.IsOptional();

			Property(p => p.PARTFLAG)
				.HasColumnName("PARTFLAG")
				.HasColumnOrder(73)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(1)
				.HasParameterName("PARTFLAG")
				.IsOptional();

			Property(p => p.RESERVE3)
				.HasColumnName("RESERVE3")
				.HasColumnOrder(74)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(6)
				.HasParameterName("RESERVE3")
				.IsOptional();

			Property(p => p.UGA)
				.HasColumnName("UGA")
				.HasColumnOrder(75)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(5)
				.HasParameterName("UGA")
				.IsOptional();

			Property(p => p.STATENS)
				.HasColumnName("STATENS")
				.HasColumnOrder(76)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(8)
				.HasParameterName("STATENS")
				.IsOptional();

			Property(p => p.COUNTYNS)
				.HasColumnName("COUNTYNS")
				.HasColumnOrder(77)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(8)
				.HasParameterName("COUNTYNS")
				.IsOptional();

			Property(p => p.COUSUBNS)
				.HasColumnName("COUSUBNS")
				.HasColumnOrder(78)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(8)
				.HasParameterName("COUSUBNS")
				.IsOptional();

			Property(p => p.PLACENS)
				.HasColumnName("PLACENS")
				.HasColumnOrder(79)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(8)
				.HasParameterName("PLACENS")
				.IsOptional();

			Property(p => p.CONCITNS)
				.HasColumnName("CONCITNS")
				.HasColumnOrder(80)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(8)
				.HasParameterName("CONCITNS")
				.IsOptional();

			Property(p => p.AIANHHNS)
				.HasColumnName("AIANHHNS")
				.HasColumnOrder(81)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(8)
				.HasParameterName("AIANHHNS")
				.IsOptional();

			Property(p => p.AITSNS)
				.HasColumnName("AITSNS")
				.HasColumnOrder(82)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(8)
				.HasParameterName("AITSNS")
				.IsOptional();

			Property(p => p.ANRCNS)
				.HasColumnName("ANRCNS")
				.HasColumnOrder(83)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(8)
				.HasParameterName("ANRCNS")
				.IsOptional();

			Property(p => p.SUBMCDNS)
				.HasColumnName("SUBMCDNS")
				.HasColumnOrder(84)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(8)
				.HasParameterName("SUBMCDNS")
				.IsOptional();

			Property(p => p.CD113)
				.HasColumnName("CD113")
				.HasColumnOrder(85)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("CD113")
				.IsOptional();

			Property(p => p.CD114)
				.HasColumnName("CD114")
				.HasColumnOrder(86)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("CD114")
				.IsOptional();

			Property(p => p.CD115)
				.HasColumnName("CD115")
				.HasColumnOrder(87)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("CD115")
				.IsOptional();

			Property(p => p.SLDU2)
				.HasColumnName("SLDU2")
				.HasColumnOrder(88)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(3)
				.HasParameterName("SLDU2")
				.IsOptional();

			Property(p => p.SLDU3)
				.HasColumnName("SLDU3")
				.HasColumnOrder(89)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(3)
				.HasParameterName("SLDU3")
				.IsOptional();

			Property(p => p.SLDU4)
				.HasColumnName("SLDU4")
				.HasColumnOrder(90)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(3)
				.HasParameterName("SLDU4")
				.IsOptional();

			Property(p => p.SLDL2)
				.HasColumnName("SLDL2")
				.HasColumnOrder(91)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(3)
				.HasParameterName("SLDL2")
				.IsOptional();

			Property(p => p.SLDL3)
				.HasColumnName("SLDL3")
				.HasColumnOrder(92)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(3)
				.HasParameterName("SLDL3")
				.IsOptional();

			Property(p => p.SLDL4)
				.HasColumnName("SLDL4")
				.HasColumnOrder(93)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(3)
				.HasParameterName("SLDL4")
				.IsOptional();

			Property(p => p.AIANHHSC)
				.HasColumnName("AIANHHSC")
				.HasColumnOrder(94)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("AIANHHSC")
				.IsOptional();

			Property(p => p.CSASC)
				.HasColumnName("CSASC")
				.HasColumnOrder(95)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("CSASC")
				.IsOptional();

			Property(p => p.CNECTASC)
				.HasColumnName("CNECTASC")
				.HasColumnOrder(96)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("CNECTASC")
				.IsOptional();

			Property(p => p.MEMI)
				.HasColumnName("MEMI")
				.HasColumnOrder(97)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(1)
				.HasParameterName("MEMI")
				.IsOptional();

			Property(p => p.NMEMI)
				.HasColumnName("NMEMI")
				.HasColumnOrder(98)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(1)
				.HasParameterName("NMEMI")
				.IsOptional();

			Property(p => p.PUMA)
				.HasColumnName("PUMA")
				.HasColumnOrder(99)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(5)
				.HasParameterName("PUMA")
				.IsOptional();

			Property(p => p.RESERVED)
				.HasColumnName("RESERVED")
				.HasColumnOrder(100)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(18)
				.HasParameterName("RESERVED")
				.IsOptional();
		}
	}
}
