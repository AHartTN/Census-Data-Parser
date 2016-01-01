#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/31/2015 2:56 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: EnumExtensions.cs
// 
// Anthony Hart ("ANTHONY") CONFIDENTIAL
// 
// Unpublished Copyright (c) 1985-2015 Anthony Hart, All Rights Reserved.
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
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Reflection;
    using Attributes;
    #endregion

    public static class EnumExtensions
    {
        public static string GetDescription<T>(this T source) where T : struct, IComparable, IConvertible, IFormattable
        {
            DisplayAttribute attribute = GetDisplayAttribute(source);
            return attribute?.Description;
        }

        public static DisplayAttribute GetDisplayAttribute<T>(this T source)
        {
            if (source == null)
            {
                return null;
            }

            Type type = typeof (T);
            FieldInfo field = type.GetField(source.ToString());
            return field != null
                       ? field.GetCustomAttribute<DisplayAttribute>()
                       : type.GetCustomAttribute<DisplayAttribute>();
        }

        public static IEnumerable<T> GetEnums<T>(this T source, bool includeHidden = false)
        {
            Type type = typeof (T);

            if (!type.IsEnum)
            {
                return null;
            }

            IEnumerable<T> output = Enum.GetValues(type)
                                        .Cast<T>();
            return includeHidden
                       ? output
                       : output.Where(w => IsHidden(w) == false);
        }

        public static string GetGroupName<T>(this T source) where T : struct, IComparable, IConvertible, IFormattable
        {
            DisplayAttribute attribute = GetDisplayAttribute(source);
            return attribute?.GroupName;
        }

        public static HiddenAttribute GetHiddenAttribute<T>(this T source)
        {
            Type type = typeof (T);
            FieldInfo field = type.GetField(source.ToString());
            return field.GetCustomAttribute<HiddenAttribute>();
        }

        public static string GetName<T>(this T source) where T : struct, IComparable, IConvertible, IFormattable { return Enum.GetName(typeof (T), source); }

        public static int GetOrder<T>(this T source) where T : struct, IComparable, IConvertible, IFormattable
        {
            DisplayAttribute attribute = GetDisplayAttribute(source);
            int? order = attribute?.GetOrder();

            return order != null && order >= 0
                       ? (int)order
                       : int.MaxValue;
        }

        public static string GetPrompt<T>(this T source) where T : struct, IComparable, IConvertible, IFormattable
        {
            DisplayAttribute attribute = GetDisplayAttribute(source);
            return attribute?.Prompt;
        }

        public static string GetShortName<T>(this T source) where T : struct, IComparable, IConvertible, IFormattable
        {
            DisplayAttribute attribute = GetDisplayAttribute(source);
            return attribute?.ShortName;
        }

        public static bool IsHidden<T>(this T source)
        {
            HiddenAttribute attribute = GetHiddenAttribute(source);
            return attribute != null && attribute.IsHidden;
        }

        public static T SetDescription<T>(this T source, string value) where T : struct, IComparable, IConvertible, IFormattable
        {
            DisplayAttribute attribute = GetDisplayAttribute(source);
            attribute.Description = value;
            return source;
        }

        public static T SetGroupName<T>(this T source, string value) where T : struct, IComparable, IConvertible, IFormattable
        {
            DisplayAttribute attribute = GetDisplayAttribute(source);
            attribute.GroupName = value;
            return source;
        }

        public static T SetName<T>(this T source, string value) where T : struct, IComparable, IConvertible, IFormattable
        {
            DisplayAttribute attribute = GetDisplayAttribute(source);
            attribute.Name = value;
            return source;
        }

        public static T SetOrder<T>(this T source, int value) where T : struct, IComparable, IConvertible, IFormattable
        {
            DisplayAttribute attribute = GetDisplayAttribute(source);
            attribute.Order = value;
            return source;
        }

        public static T SetPrompt<T>(this T source, string value) where T : struct, IComparable, IConvertible, IFormattable
        {
            DisplayAttribute attribute = GetDisplayAttribute(source);
            attribute.Prompt = value;
            return source;
        }

        public static T SetShortName<T>(this T source, string value) where T : struct, IComparable, IConvertible, IFormattable
        {
            DisplayAttribute attribute = GetDisplayAttribute(source);
            attribute.ShortName = value;
            return source;
        }
    }
}
