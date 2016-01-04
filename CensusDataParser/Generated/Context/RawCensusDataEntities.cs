namespace CensusDataParser.Generated.Context
{
	#region Using Directives
	using System;
	using System.Data.Entity;
	using Binding;
	using Mapping;
	#endregion Using Directives

	public class RawCensusDataEntities : DbContext
	{
		public RawCensusDataEntities() : base("name=DefaultConnection") { }

		public static bool CreateDatabase()
		{
			try
			{
				using (RawCensusDataEntities db = new RawCensusDataEntities())
				{
					return db.Database.Exists() || db.Database.CreateIfNotExists();
				}
			}
			catch (Exception ex)
			{
				throw new InvalidOperationException("The database could not be initialized!", ex);
			}
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			#region Redistricting
			modelBuilder.Configurations.Add(new Redistricting_headerMap());
			modelBuilder.Configurations.Add(new Redistricting_PL_Geo_HeaderMap());
			modelBuilder.Configurations.Add(new Redistricting_PLMap());
			modelBuilder.Configurations.Add(new Redistricting_TableMap());
			#endregion Redistricting

			#region DemographicProfile
			modelBuilder.Configurations.Add(new DemographicProfile_Geo_HeaderMap());
			modelBuilder.Configurations.Add(new DemographicProfile_HeaderMap());
			modelBuilder.Configurations.Add(new DemographicProfile_Part1Map());
			modelBuilder.Configurations.Add(new DemographicProfile_TableMap());
			#endregion DemographicProfile

			#region SummaryOne
			modelBuilder.Configurations.Add(new SummaryOne_DATA_FIELD_DESCRIPTORSMap());
			modelBuilder.Configurations.Add(new SummaryOne_GEO_HEADER_SF1Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00001Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00002Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00003Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00004Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00005Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00006Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00007Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00008Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00009Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00010Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00011Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00012Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00013Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00014Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00015Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00016Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00017Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00018Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00019Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00020Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00021Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00022Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00023Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00024Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00025Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00026Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00027Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00028Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00029Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00030Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00031Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00032Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00033Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00034Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00035Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00036Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00037Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00038Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00039Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00040Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00041Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00042Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00043Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00044Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00045Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00046Map());
			modelBuilder.Configurations.Add(new SummaryOne_SF1_00047Map());
			#endregion SummaryOne

			#region SummaryTwo
			modelBuilder.Configurations.Add(new SummaryTwo_Table_NamesMap());
			modelBuilder.Configurations.Add(new SummaryTwo_DataDictionaryMap());
			modelBuilder.Configurations.Add(new SummaryTwo_DataDictionary_NOTESMap());
			modelBuilder.Configurations.Add(new SummaryTwo_GeoHeader_SpecificationsMap());
			modelBuilder.Configurations.Add(new SummaryTwo_Iterations_ListMap());
			modelBuilder.Configurations.Add(new SummaryTwo_Iterations_NOTESMap());
			modelBuilder.Configurations.Add(new SummaryTwo_SF2_GeoHeaderMap());
			modelBuilder.Configurations.Add(new SummaryTwo_SF2_Segment_01Map());
			modelBuilder.Configurations.Add(new SummaryTwo_SF2_Segment_02Map());
			modelBuilder.Configurations.Add(new SummaryTwo_SF2_Segment_03Map());
			modelBuilder.Configurations.Add(new SummaryTwo_SF2_Segment_04Map());
			modelBuilder.Configurations.Add(new SummaryTwo_SF2_Segment_05Map());
			modelBuilder.Configurations.Add(new SummaryTwo_SF2_Segment_06Map());
			modelBuilder.Configurations.Add(new SummaryTwo_SF2_Segment_07Map());
			modelBuilder.Configurations.Add(new SummaryTwo_SF2_Segment_08Map());
			modelBuilder.Configurations.Add(new SummaryTwo_SF2_Segment_09Map());
			modelBuilder.Configurations.Add(new SummaryTwo_SF2_Segment_10Map());
			modelBuilder.Configurations.Add(new SummaryTwo_SF2_Segment_11Map());
			#endregion SummaryTwo

			#region SF1CongressionalDistricts113
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_DATA_FIELD_DESCRIPTORSMap());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_GEO_HEADER_SF1Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00001Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00002Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00003Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00004Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00005Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00006Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00007Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00008Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00009Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00010Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00011Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00012Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00013Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00014Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00015Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00016Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00017Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00018Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00019Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00020Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00021Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00022Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00023Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00024Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00025Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00026Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00027Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00028Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00029Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00030Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00031Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00032Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00033Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00034Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00035Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00036Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00037Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00038Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00039Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00040Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00041Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00042Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00043Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00044Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00045Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00046Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00047Map());
			modelBuilder.Configurations.Add(new SF1CongressionalDistricts113_SF1_00048Map());
			#endregion SF1CongressionalDistricts113
		}

		#region Redistricting
		public virtual DbSet<Redistricting_header> Redistricting_headerRecords { get; set; }
		public virtual DbSet<Redistricting_PL_Geo_Header> Redistricting_PL_Geo_HeaderRecords { get; set; }
		public virtual DbSet<Redistricting_PL> Redistricting_PLRecords { get; set; }
		public virtual DbSet<Redistricting_Table> Redistricting_TableRecords { get; set; }
		#endregion Redistricting

		#region DemographicProfile
		public virtual DbSet<DemographicProfile_Geo_Header> DemographicProfile_Geo_HeaderRecords { get; set; }
		public virtual DbSet<DemographicProfile_Header> DemographicProfile_HeaderRecords { get; set; }
		public virtual DbSet<DemographicProfile_Part1> DemographicProfile_Part1Records { get; set; }
		public virtual DbSet<DemographicProfile_Table> DemographicProfile_TableRecords { get; set; }
		#endregion DemographicProfile

		#region SummaryOne
		public virtual DbSet<SummaryOne_DATA_FIELD_DESCRIPTORS> SummaryOne_DATA_FIELD_DESCRIPTORSRecords { get; set; }
		public virtual DbSet<SummaryOne_GEO_HEADER_SF1> SummaryOne_GEO_HEADER_SF1Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00001> SummaryOne_SF1_00001Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00002> SummaryOne_SF1_00002Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00003> SummaryOne_SF1_00003Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00004> SummaryOne_SF1_00004Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00005> SummaryOne_SF1_00005Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00006> SummaryOne_SF1_00006Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00007> SummaryOne_SF1_00007Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00008> SummaryOne_SF1_00008Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00009> SummaryOne_SF1_00009Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00010> SummaryOne_SF1_00010Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00011> SummaryOne_SF1_00011Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00012> SummaryOne_SF1_00012Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00013> SummaryOne_SF1_00013Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00014> SummaryOne_SF1_00014Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00015> SummaryOne_SF1_00015Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00016> SummaryOne_SF1_00016Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00017> SummaryOne_SF1_00017Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00018> SummaryOne_SF1_00018Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00019> SummaryOne_SF1_00019Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00020> SummaryOne_SF1_00020Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00021> SummaryOne_SF1_00021Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00022> SummaryOne_SF1_00022Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00023> SummaryOne_SF1_00023Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00024> SummaryOne_SF1_00024Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00025> SummaryOne_SF1_00025Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00026> SummaryOne_SF1_00026Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00027> SummaryOne_SF1_00027Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00028> SummaryOne_SF1_00028Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00029> SummaryOne_SF1_00029Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00030> SummaryOne_SF1_00030Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00031> SummaryOne_SF1_00031Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00032> SummaryOne_SF1_00032Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00033> SummaryOne_SF1_00033Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00034> SummaryOne_SF1_00034Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00035> SummaryOne_SF1_00035Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00036> SummaryOne_SF1_00036Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00037> SummaryOne_SF1_00037Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00038> SummaryOne_SF1_00038Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00039> SummaryOne_SF1_00039Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00040> SummaryOne_SF1_00040Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00041> SummaryOne_SF1_00041Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00042> SummaryOne_SF1_00042Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00043> SummaryOne_SF1_00043Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00044> SummaryOne_SF1_00044Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00045> SummaryOne_SF1_00045Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00046> SummaryOne_SF1_00046Records { get; set; }
		public virtual DbSet<SummaryOne_SF1_00047> SummaryOne_SF1_00047Records { get; set; }
		#endregion SummaryOne

		#region SummaryTwo
		public virtual DbSet<SummaryTwo_Table_Names> SummaryTwo_Table_NamesRecords { get; set; }
		public virtual DbSet<SummaryTwo_DataDictionary> SummaryTwo_DataDictionaryRecords { get; set; }
		public virtual DbSet<SummaryTwo_DataDictionary_NOTES> SummaryTwo_DataDictionary_NOTESRecords { get; set; }
		public virtual DbSet<SummaryTwo_GeoHeader_Specifications> SummaryTwo_GeoHeader_SpecificationsRecords { get; set; }
		public virtual DbSet<SummaryTwo_Iterations_List> SummaryTwo_Iterations_ListRecords { get; set; }
		public virtual DbSet<SummaryTwo_Iterations_NOTES> SummaryTwo_Iterations_NOTESRecords { get; set; }
		public virtual DbSet<SummaryTwo_SF2_GeoHeader> SummaryTwo_SF2_GeoHeaderRecords { get; set; }
		public virtual DbSet<SummaryTwo_SF2_Segment_01> SummaryTwo_SF2_Segment_01Records { get; set; }
		public virtual DbSet<SummaryTwo_SF2_Segment_02> SummaryTwo_SF2_Segment_02Records { get; set; }
		public virtual DbSet<SummaryTwo_SF2_Segment_03> SummaryTwo_SF2_Segment_03Records { get; set; }
		public virtual DbSet<SummaryTwo_SF2_Segment_04> SummaryTwo_SF2_Segment_04Records { get; set; }
		public virtual DbSet<SummaryTwo_SF2_Segment_05> SummaryTwo_SF2_Segment_05Records { get; set; }
		public virtual DbSet<SummaryTwo_SF2_Segment_06> SummaryTwo_SF2_Segment_06Records { get; set; }
		public virtual DbSet<SummaryTwo_SF2_Segment_07> SummaryTwo_SF2_Segment_07Records { get; set; }
		public virtual DbSet<SummaryTwo_SF2_Segment_08> SummaryTwo_SF2_Segment_08Records { get; set; }
		public virtual DbSet<SummaryTwo_SF2_Segment_09> SummaryTwo_SF2_Segment_09Records { get; set; }
		public virtual DbSet<SummaryTwo_SF2_Segment_10> SummaryTwo_SF2_Segment_10Records { get; set; }
		public virtual DbSet<SummaryTwo_SF2_Segment_11> SummaryTwo_SF2_Segment_11Records { get; set; }
		#endregion SummaryTwo

		#region SF1CongressionalDistricts113
		public virtual DbSet<SF1CongressionalDistricts113_DATA_FIELD_DESCRIPTORS> SF1CongressionalDistricts113_DATA_FIELD_DESCRIPTORSRecords { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_GEO_HEADER_SF1> SF1CongressionalDistricts113_GEO_HEADER_SF1Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00001> SF1CongressionalDistricts113_SF1_00001Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00002> SF1CongressionalDistricts113_SF1_00002Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00003> SF1CongressionalDistricts113_SF1_00003Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00004> SF1CongressionalDistricts113_SF1_00004Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00005> SF1CongressionalDistricts113_SF1_00005Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00006> SF1CongressionalDistricts113_SF1_00006Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00007> SF1CongressionalDistricts113_SF1_00007Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00008> SF1CongressionalDistricts113_SF1_00008Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00009> SF1CongressionalDistricts113_SF1_00009Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00010> SF1CongressionalDistricts113_SF1_00010Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00011> SF1CongressionalDistricts113_SF1_00011Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00012> SF1CongressionalDistricts113_SF1_00012Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00013> SF1CongressionalDistricts113_SF1_00013Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00014> SF1CongressionalDistricts113_SF1_00014Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00015> SF1CongressionalDistricts113_SF1_00015Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00016> SF1CongressionalDistricts113_SF1_00016Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00017> SF1CongressionalDistricts113_SF1_00017Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00018> SF1CongressionalDistricts113_SF1_00018Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00019> SF1CongressionalDistricts113_SF1_00019Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00020> SF1CongressionalDistricts113_SF1_00020Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00021> SF1CongressionalDistricts113_SF1_00021Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00022> SF1CongressionalDistricts113_SF1_00022Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00023> SF1CongressionalDistricts113_SF1_00023Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00024> SF1CongressionalDistricts113_SF1_00024Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00025> SF1CongressionalDistricts113_SF1_00025Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00026> SF1CongressionalDistricts113_SF1_00026Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00027> SF1CongressionalDistricts113_SF1_00027Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00028> SF1CongressionalDistricts113_SF1_00028Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00029> SF1CongressionalDistricts113_SF1_00029Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00030> SF1CongressionalDistricts113_SF1_00030Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00031> SF1CongressionalDistricts113_SF1_00031Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00032> SF1CongressionalDistricts113_SF1_00032Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00033> SF1CongressionalDistricts113_SF1_00033Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00034> SF1CongressionalDistricts113_SF1_00034Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00035> SF1CongressionalDistricts113_SF1_00035Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00036> SF1CongressionalDistricts113_SF1_00036Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00037> SF1CongressionalDistricts113_SF1_00037Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00038> SF1CongressionalDistricts113_SF1_00038Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00039> SF1CongressionalDistricts113_SF1_00039Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00040> SF1CongressionalDistricts113_SF1_00040Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00041> SF1CongressionalDistricts113_SF1_00041Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00042> SF1CongressionalDistricts113_SF1_00042Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00043> SF1CongressionalDistricts113_SF1_00043Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00044> SF1CongressionalDistricts113_SF1_00044Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00045> SF1CongressionalDistricts113_SF1_00045Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00046> SF1CongressionalDistricts113_SF1_00046Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00047> SF1CongressionalDistricts113_SF1_00047Records { get; set; }
		public virtual DbSet<SF1CongressionalDistricts113_SF1_00048> SF1CongressionalDistricts113_SF1_00048Records { get; set; }
		#endregion SF1CongressionalDistricts113
	}
}
