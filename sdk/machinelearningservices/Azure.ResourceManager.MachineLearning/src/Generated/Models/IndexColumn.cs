// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> DTO object representing index column. </summary>
    public partial class IndexColumn
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IndexColumn"/>. </summary>
        public IndexColumn()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IndexColumn"/>. </summary>
        /// <param name="columnName"> Specifies the column name. </param>
        /// <param name="dataType"> Specifies the data type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IndexColumn(string columnName, FeatureDataType? dataType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ColumnName = columnName;
            DataType = dataType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies the column name. </summary>
        public string ColumnName { get; set; }
        /// <summary> Specifies the data type. </summary>
        public FeatureDataType? DataType { get; set; }
    }
}
