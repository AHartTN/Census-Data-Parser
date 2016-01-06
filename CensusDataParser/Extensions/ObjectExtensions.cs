namespace CensusDataParser
{
	using System.Reflection;

	public static class ObjectExtensions
	{
		public const BindingFlags BindFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;

		public static PropertyInfo GetProperty(this object source, string name)
		{
			return source?.GetType().GetProperty(name, BindFlags);
		}

		public static object GetPropertyValue(this object source, string name)
		{
			return source?.GetPropertyValue(source.GetProperty(name));
		}

		public static object GetPropertyValue(this object source, PropertyInfo property)
		{
			return property?.GetValue(source);
		}

		public static void SetPropertyValue(this object source, string name, object value)
		{
			PropertyInfo property = source?.GetProperty(name);
			property?.SetValue(source, value);
		}
	}
}