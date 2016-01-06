namespace CensusDataParser
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Data.Entity.ModelConfiguration;

	public static class EntityTypeConfigurationExtensions
	{

		public static IEnumerable<Tuple<string, int?, int?>> GetColumnInfo<T>(this EntityTypeConfiguration<T> map) where T : class
		{
			object configuration = map.GetPropertyValue("Configuration");
			IEnumerable properties = configuration?.GetPropertyValue("PrimitivePropertyConfigurations") as IEnumerable;

			if (properties == null)
				yield break;
			foreach (object property in properties)
			{
				string propertyString = $"{property.GetPropertyValue("Key")}";
				int? columnIndex = property.GetPropertyValue("Value").GetPropertyValue("ColumnOrder") as int?;
				int? maxLength = property.GetPropertyValue("Value").GetPropertyValue("MaxLength") as int?;

				yield return new Tuple<string, int?, int?>(propertyString, columnIndex, maxLength);
			}
		}
	}
}