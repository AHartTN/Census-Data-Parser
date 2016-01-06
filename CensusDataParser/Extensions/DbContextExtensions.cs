namespace CensusDataParser.Extensions
{
	using System;
	using System.Data.Entity;
	using System.Linq;
	using System.Reflection;

	public static class DbContextExtensions
	{
		public static object Test(this DbContext context)
		{
			Type contextType = context.GetType();
			Assembly assembly = contextType.Assembly;
			Type[] assemblyTypes = assembly.GetTypes();
			return null;
		}
	}
}
