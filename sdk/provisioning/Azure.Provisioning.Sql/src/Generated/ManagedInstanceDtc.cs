// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// ManagedInstanceDtc.
/// </summary>
public partial class ManagedInstanceDtc : Resource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Active status of managed instance DTC.
    /// </summary>
    public BicepValue<bool> DtcEnabled { get => _dtcEnabled; set => _dtcEnabled.Assign(value); }
    private readonly BicepValue<bool> _dtcEnabled;

    /// <summary>
    /// External dns suffix search list of managed instance DTC.
    /// </summary>
    public BicepList<string> ExternalDnsSuffixSearchList { get => _externalDnsSuffixSearchList; set => _externalDnsSuffixSearchList.Assign(value); }
    private readonly BicepList<string> _externalDnsSuffixSearchList;

    /// <summary>
    /// Security settings of managed instance DTC.
    /// </summary>
    public BicepValue<ManagedInstanceDtcSecuritySettings> SecuritySettings { get => _securitySettings; set => _securitySettings.Assign(value); }
    private readonly BicepValue<ManagedInstanceDtcSecuritySettings> _securitySettings;

    /// <summary>
    /// Host name dns suffix of managed instance DTC.
    /// </summary>
    public BicepValue<string> DtcHostNameDnsSuffix { get => _dtcHostNameDnsSuffix; }
    private readonly BicepValue<string> _dtcHostNameDnsSuffix;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Provisioning state of managed instance DTC.
    /// </summary>
    public BicepValue<JobExecutionProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<JobExecutionProvisioningState> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent ManagedInstance.
    /// </summary>
    public ManagedInstance? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<ManagedInstance> _parent;

    /// <summary>
    /// Creates a new ManagedInstanceDtc.
    /// </summary>
    /// <param name="resourceName">Name of the ManagedInstanceDtc.</param>
    /// <param name="resourceVersion">Version of the ManagedInstanceDtc.</param>
    public ManagedInstanceDtc(string resourceName, string? resourceVersion = default)
        : base(resourceName, "Microsoft.Sql/managedInstances/dtc", resourceVersion ?? "2021-11-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _dtcEnabled = BicepValue<bool>.DefineProperty(this, "DtcEnabled", ["properties", "dtcEnabled"]);
        _externalDnsSuffixSearchList = BicepList<string>.DefineProperty(this, "ExternalDnsSuffixSearchList", ["properties", "externalDnsSuffixSearchList"]);
        _securitySettings = BicepValue<ManagedInstanceDtcSecuritySettings>.DefineProperty(this, "SecuritySettings", ["properties", "securitySettings"]);
        _dtcHostNameDnsSuffix = BicepValue<string>.DefineProperty(this, "DtcHostNameDnsSuffix", ["properties", "dtcHostNameDnsSuffix"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _provisioningState = BicepValue<JobExecutionProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<ManagedInstance>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported ManagedInstanceDtc resource versions.
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
    /// Creates a reference to an existing ManagedInstanceDtc.
    /// </summary>
    /// <param name="resourceName">Name of the ManagedInstanceDtc.</param>
    /// <param name="resourceVersion">Version of the ManagedInstanceDtc.</param>
    /// <returns>The existing ManagedInstanceDtc resource.</returns>
    public static ManagedInstanceDtc FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
