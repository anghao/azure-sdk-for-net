// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ExpiryOptionType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExpiryOptionType
    {
        [EnumMember(Value = "NeverExpire")]
        NeverExpire,
        [EnumMember(Value = "RelativeToNow")]
        RelativeToNow,
        [EnumMember(Value = "RelativeToCreationDate")]
        RelativeToCreationDate,
        [EnumMember(Value = "Absolute")]
        Absolute
    }
}
