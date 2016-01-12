#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/06/2016 4:41 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: ObjectExtensions.cs
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

namespace CensusDataParser.Extensions
{
	#region Using Directives
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.Reflection;
	using Attributes;
	#endregion

	public static class ObjectExtensions
	{
		public const BindingFlags BindFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;

		public static PropertyInfo GetProperty(this object source, string name)
		{
			return source?.GetType()
						  .GetProperty(name, BindFlags);
		}

		public static object GetPropertyValue(this object source, string name) { return source?.GetPropertyValue(source.GetProperty(name)); }

		public static object GetPropertyValue(this object source, PropertyInfo property) { return property?.GetValue(source); }

		public static void SetPropertyValue(this object source, string name, object value)
		{
			PropertyInfo property = source?.GetProperty(name);
			property?.SetValue(source, value);
		}

		public static DisplayAttribute GetDisplayAttribute<T>(this T source, string name)
		{
			if (source == null)
			{
				return null;
			}

			Type type = typeof(T);
			FieldInfo field = type.GetField(name, BindFlags);
			PropertyInfo property = type.GetProperty(name, BindFlags);
			return field?.GetCustomAttribute<DisplayAttribute>()
					   ?? property?.GetCustomAttribute<DisplayAttribute>();
		}

		public static string GetDescription<T>(this T source, string name)
		{
			DisplayAttribute attribute = source?.GetDisplayAttribute(name);
			return attribute?.Description;
		}
		
		public static string GetName<T>(this T source, string name)
		{
			DisplayAttribute attribute = source?.GetDisplayAttribute(name);
			return attribute?.Name;
		}

		public static int? GetOrder<T>(this T source, string name)
		{
			DisplayAttribute attribute = source?.GetDisplayAttribute(name);
			return attribute?.Order;
		}

		public static string GetGroupName<T>(this T source, string name)
		{
			DisplayAttribute attribute = source?.GetDisplayAttribute(name);
			return attribute?.GroupName;
		}

		public static HiddenAttribute GetHiddenAttribute<T>(this T source, string name)
		{
			Type type = typeof(T);
			FieldInfo field = type.GetField(name, BindFlags);
			PropertyInfo property = type.GetProperty(name, BindFlags);
			return field?.GetCustomAttribute<HiddenAttribute>()
					?? property?.GetCustomAttribute<HiddenAttribute>();
		}
		public static string GetPrompt<T>(this T source, string name)
		{
			DisplayAttribute attribute = source.GetDisplayAttribute(name);
			return attribute?.Prompt;
		}

		public static string GetShortName<T>(this T source, string name)
		{
			DisplayAttribute attribute = source.GetDisplayAttribute(name);
			return attribute?.ShortName;
		}

		public static bool IsHidden<T>(this T source, string name)
		{
			HiddenAttribute attribute = source.GetHiddenAttribute(name);
			return attribute != null && attribute.IsHidden;
		}
		public static T SetDescription<T>(this T source, string name, string value)
		{
			DisplayAttribute attribute = source.GetDisplayAttribute(name);
			attribute.Description = value;
			return source;
		}

		public static T SetGroupName<T>(this T source, string name, string value)
		{
			DisplayAttribute attribute = source.GetDisplayAttribute(name);
			attribute.GroupName = value;
			return source;
		}

		public static T SetName<T>(this T source, string name, string value)
		{
			DisplayAttribute attribute = source.GetDisplayAttribute(name);
			attribute.Name = value;
			return source;
		}

		public static T SetOrder<T>(this T source, string name, int value)
		{
			DisplayAttribute attribute = source.GetDisplayAttribute(name);
			attribute.Order = value;
			return source;
		}

		public static T SetPrompt<T>(this T source, string name, string value)
		{
			DisplayAttribute attribute = source.GetDisplayAttribute(name);
			attribute.Prompt = value;
			return source;
		}

		public static T SetShortName<T>(this T source, string name, string value)
		{
			DisplayAttribute attribute = source.GetDisplayAttribute(name);
			attribute.ShortName = value;
			return source;
		}

	}
}
