// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// BackupShortTermRetentionPolicy.
/// </summary>
public partial class BackupShortTermRetentionPolicy : Resource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The differential backup interval in hours. This is how many interval
    /// hours between each differential backup will be supported. This is only
    /// applicable to live databases but not dropped databases.
    /// </summary>
    public BicepValue<int> DiffBackupIntervalInHours { get => _diffBackupIntervalInHours; set => _diffBackupIntervalInHours.Assign(value); }
    private readonly BicepValue<int> _diffBackupIntervalInHours;

    /// <summary>
    /// The backup retention period in days. This is how many days
    /// Point-in-Time Restore will be supported.
    /// </summary>
    public BicepValue<int> RetentionDays { get => _retentionDays; set => _retentionDays.Assign(value); }
    private readonly BicepValue<int> _retentionDays;

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
    /// Gets or sets a reference to the parent SqlDatabase.
    /// </summary>
    public SqlDatabase? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<SqlDatabase> _parent;

    /// <summary>
    /// Creates a new BackupShortTermRetentionPolicy.
    /// </summary>
    /// <param name="resourceName">Name of the BackupShortTermRetentionPolicy.</param>
    /// <param name="resourceVersion">Version of the BackupShortTermRetentionPolicy.</param>
    public BackupShortTermRetentionPolicy(string resourceName, string? resourceVersion = default)
        : base(resourceName, "Microsoft.Sql/servers/databases/backupShortTermRetentionPolicies", resourceVersion ?? "2021-11-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _diffBackupIntervalInHours = BicepValue<int>.DefineProperty(this, "DiffBackupIntervalInHours", ["properties", "diffBackupIntervalInHours"]);
        _retentionDays = BicepValue<int>.DefineProperty(this, "RetentionDays", ["properties", "retentionDays"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<SqlDatabase>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported BackupShortTermRetentionPolicy resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-05-01-preview.
        /// </summary>
        public static readonly string V2024_05_01_preview = "2024-05-01-preview";

        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";
    }

    /// <summary>
    /// Creates a reference to an existing BackupShortTermRetentionPolicy.
    /// </summary>
    /// <param name="resourceName">Name of the BackupShortTermRetentionPolicy.</param>
    /// <param name="resourceVersion">Version of the BackupShortTermRetentionPolicy.</param>
    /// <returns>The existing BackupShortTermRetentionPolicy resource.</returns>
    public static BackupShortTermRetentionPolicy FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
