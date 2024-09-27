// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// CosmosDBSqlClientEncryptionKey.
/// </summary>
public partial class CosmosDBSqlClientEncryptionKey : Resource
{
    /// <summary>
    /// Cosmos DB ClientEncryptionKey name.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The standard JSON format of a ClientEncryptionKey.
    /// </summary>
    public BicepValue<CosmosDBSqlClientEncryptionKeyResourceInfo> Resource { get => _resource; set => _resource.Assign(value); }
    private readonly BicepValue<CosmosDBSqlClientEncryptionKeyResourceInfo> _resource;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent CosmosDBSqlDatabase.
    /// </summary>
    public CosmosDBSqlDatabase? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<CosmosDBSqlDatabase> _parent;

    /// <summary>
    /// Creates a new CosmosDBSqlClientEncryptionKey.
    /// </summary>
    /// <param name="resourceName">Name of the CosmosDBSqlClientEncryptionKey.</param>
    /// <param name="resourceVersion">Version of the CosmosDBSqlClientEncryptionKey.</param>
    public CosmosDBSqlClientEncryptionKey(string resourceName, string? resourceVersion = default)
        : base(resourceName, "Microsoft.DocumentDB/databaseAccounts/sqlDatabases/clientEncryptionKeys", resourceVersion ?? "2024-08-15")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _resource = BicepValue<CosmosDBSqlClientEncryptionKeyResourceInfo>.DefineProperty(this, "Resource", ["properties", "resource"], isRequired: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<CosmosDBSqlDatabase>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported CosmosDBSqlClientEncryptionKey resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-09-01-preview.
        /// </summary>
        public static readonly string V2024_09_01_preview = "2024-09-01-preview";

        /// <summary>
        /// 2024-08-15.
        /// </summary>
        public static readonly string V2024_08_15 = "2024-08-15";

        /// <summary>
        /// 2024-05-15.
        /// </summary>
        public static readonly string V2024_05_15 = "2024-05-15";

        /// <summary>
        /// 2023-11-15.
        /// </summary>
        public static readonly string V2023_11_15 = "2023-11-15";

        /// <summary>
        /// 2023-09-15.
        /// </summary>
        public static readonly string V2023_09_15 = "2023-09-15";

        /// <summary>
        /// 2023-04-15.
        /// </summary>
        public static readonly string V2023_04_15 = "2023-04-15";

        /// <summary>
        /// 2023-03-15.
        /// </summary>
        public static readonly string V2023_03_15 = "2023-03-15";

        /// <summary>
        /// 2022-11-15.
        /// </summary>
        public static readonly string V2022_11_15 = "2022-11-15";

        /// <summary>
        /// 2022-08-15.
        /// </summary>
        public static readonly string V2022_08_15 = "2022-08-15";

        /// <summary>
        /// 2022-05-15.
        /// </summary>
        public static readonly string V2022_05_15 = "2022-05-15";

        /// <summary>
        /// 2021-10-15.
        /// </summary>
        public static readonly string V2021_10_15 = "2021-10-15";

        /// <summary>
        /// 2021-06-15.
        /// </summary>
        public static readonly string V2021_06_15 = "2021-06-15";

        /// <summary>
        /// 2021-05-15.
        /// </summary>
        public static readonly string V2021_05_15 = "2021-05-15";

        /// <summary>
        /// 2021-04-15.
        /// </summary>
        public static readonly string V2021_04_15 = "2021-04-15";

        /// <summary>
        /// 2021-03-15.
        /// </summary>
        public static readonly string V2021_03_15 = "2021-03-15";

        /// <summary>
        /// 2021-01-15.
        /// </summary>
        public static readonly string V2021_01_15 = "2021-01-15";

        /// <summary>
        /// 2020-09-01.
        /// </summary>
        public static readonly string V2020_09_01 = "2020-09-01";

        /// <summary>
        /// 2020-04-01.
        /// </summary>
        public static readonly string V2020_04_01 = "2020-04-01";

        /// <summary>
        /// 2020-03-01.
        /// </summary>
        public static readonly string V2020_03_01 = "2020-03-01";

        /// <summary>
        /// 2019-12-12.
        /// </summary>
        public static readonly string V2019_12_12 = "2019-12-12";

        /// <summary>
        /// 2019-08-01.
        /// </summary>
        public static readonly string V2019_08_01 = "2019-08-01";

        /// <summary>
        /// 2016-03-31.
        /// </summary>
        public static readonly string V2016_03_31 = "2016-03-31";

        /// <summary>
        /// 2016-03-19.
        /// </summary>
        public static readonly string V2016_03_19 = "2016-03-19";

        /// <summary>
        /// 2015-11-06.
        /// </summary>
        public static readonly string V2015_11_06 = "2015-11-06";

        /// <summary>
        /// 2015-04-08.
        /// </summary>
        public static readonly string V2015_04_08 = "2015-04-08";

        /// <summary>
        /// 2014-04-01.
        /// </summary>
        public static readonly string V2014_04_01 = "2014-04-01";
    }

    /// <summary>
    /// Creates a reference to an existing CosmosDBSqlClientEncryptionKey.
    /// </summary>
    /// <param name="resourceName">Name of the CosmosDBSqlClientEncryptionKey.</param>
    /// <param name="resourceVersion">Version of the CosmosDBSqlClientEncryptionKey.</param>
    /// <returns>The existing CosmosDBSqlClientEncryptionKey resource.</returns>
    public static CosmosDBSqlClientEncryptionKey FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
