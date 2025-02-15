// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    internal static partial class FactoryDayOfWeekExtensions
    {
        public static string ToSerialString(this FactoryDayOfWeek value) => value switch
        {
            FactoryDayOfWeek.Sunday => "Sunday",
            FactoryDayOfWeek.Monday => "Monday",
            FactoryDayOfWeek.Tuesday => "Tuesday",
            FactoryDayOfWeek.Wednesday => "Wednesday",
            FactoryDayOfWeek.Thursday => "Thursday",
            FactoryDayOfWeek.Friday => "Friday",
            FactoryDayOfWeek.Saturday => "Saturday",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FactoryDayOfWeek value.")
        };

        public static FactoryDayOfWeek ToFactoryDayOfWeek(this string value)
        {
            if (string.Equals(value, "Sunday", StringComparison.InvariantCultureIgnoreCase)) return FactoryDayOfWeek.Sunday;
            if (string.Equals(value, "Monday", StringComparison.InvariantCultureIgnoreCase)) return FactoryDayOfWeek.Monday;
            if (string.Equals(value, "Tuesday", StringComparison.InvariantCultureIgnoreCase)) return FactoryDayOfWeek.Tuesday;
            if (string.Equals(value, "Wednesday", StringComparison.InvariantCultureIgnoreCase)) return FactoryDayOfWeek.Wednesday;
            if (string.Equals(value, "Thursday", StringComparison.InvariantCultureIgnoreCase)) return FactoryDayOfWeek.Thursday;
            if (string.Equals(value, "Friday", StringComparison.InvariantCultureIgnoreCase)) return FactoryDayOfWeek.Friday;
            if (string.Equals(value, "Saturday", StringComparison.InvariantCultureIgnoreCase)) return FactoryDayOfWeek.Saturday;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FactoryDayOfWeek value.");
        }
    }
}
