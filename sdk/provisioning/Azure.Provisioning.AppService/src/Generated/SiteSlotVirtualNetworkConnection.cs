// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// SiteSlotVirtualNetworkConnection.
/// </summary>
public partial class SiteSlotVirtualNetworkConnection : Resource
{
    /// <summary>
    /// Name of an existing Virtual Network.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// A certificate file (.cer) blob containing the public key of the private
    /// key used to authenticate a             Point-To-Site VPN connection.
    /// </summary>
    public BicepValue<string> CertBlob { get => _certBlob; set => _certBlob.Assign(value); }
    private readonly BicepValue<string> _certBlob;

    /// <summary>
    /// DNS servers to be used by this Virtual Network. This should be a
    /// comma-separated list of IP addresses.
    /// </summary>
    public BicepValue<string> DnsServers { get => _dnsServers; set => _dnsServers.Assign(value); }
    private readonly BicepValue<string> _dnsServers;

    /// <summary>
    /// Flag that is used to denote if this is VNET injection.
    /// </summary>
    public BicepValue<bool> IsSwift { get => _isSwift; set => _isSwift.Assign(value); }
    private readonly BicepValue<bool> _isSwift;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<string> _kind;

    /// <summary>
    /// The Virtual Network&apos;s resource ID.
    /// </summary>
    public BicepValue<ResourceIdentifier> VnetResourceId { get => _vnetResourceId; set => _vnetResourceId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _vnetResourceId;

    /// <summary>
    /// The client certificate thumbprint.
    /// </summary>
    public BicepValue<string> CertThumbprintString { get => _certThumbprintString; }
    private readonly BicepValue<string> _certThumbprintString;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; if a resync is required; otherwise,
    /// &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsResyncRequired { get => _isResyncRequired; }
    private readonly BicepValue<bool> _isResyncRequired;

    /// <summary>
    /// The routes that this Virtual Network connection uses.
    /// </summary>
    public BicepList<AppServiceVirtualNetworkRoute> Routes { get => _routes; }
    private readonly BicepList<AppServiceVirtualNetworkRoute> _routes;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent WebSiteSlot.
    /// </summary>
    public WebSiteSlot? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<WebSiteSlot> _parent;

    /// <summary>
    /// Creates a new SiteSlotVirtualNetworkConnection.
    /// </summary>
    /// <param name="resourceName">Name of the SiteSlotVirtualNetworkConnection.</param>
    /// <param name="resourceVersion">Version of the SiteSlotVirtualNetworkConnection.</param>
    public SiteSlotVirtualNetworkConnection(string resourceName, string? resourceVersion = default)
        : base(resourceName, "Microsoft.Web/sites/slots/virtualNetworkConnections", resourceVersion ?? "2024-04-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _certBlob = BicepValue<string>.DefineProperty(this, "CertBlob", ["properties", "certBlob"]);
        _dnsServers = BicepValue<string>.DefineProperty(this, "DnsServers", ["properties", "dnsServers"]);
        _isSwift = BicepValue<bool>.DefineProperty(this, "IsSwift", ["properties", "isSwift"]);
        _kind = BicepValue<string>.DefineProperty(this, "Kind", ["kind"]);
        _vnetResourceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "VnetResourceId", ["properties", "vnetResourceId"]);
        _certThumbprintString = BicepValue<string>.DefineProperty(this, "CertThumbprintString", ["properties", "certThumbprint"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _isResyncRequired = BicepValue<bool>.DefineProperty(this, "IsResyncRequired", ["properties", "resyncRequired"], isOutput: true);
        _routes = BicepList<AppServiceVirtualNetworkRoute>.DefineProperty(this, "Routes", ["properties", "routes"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<WebSiteSlot>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported SiteSlotVirtualNetworkConnection resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-04-01.
        /// </summary>
        public static readonly string V2024_04_01 = "2024-04-01";

        /// <summary>
        /// 2023-12-01.
        /// </summary>
        public static readonly string V2023_12_01 = "2023-12-01";

        /// <summary>
        /// 2023-01-01.
        /// </summary>
        public static readonly string V2023_01_01 = "2023-01-01";

        /// <summary>
        /// 2022-09-01.
        /// </summary>
        public static readonly string V2022_09_01 = "2022-09-01";

        /// <summary>
        /// 2022-03-01.
        /// </summary>
        public static readonly string V2022_03_01 = "2022-03-01";

        /// <summary>
        /// 2021-03-01.
        /// </summary>
        public static readonly string V2021_03_01 = "2021-03-01";

        /// <summary>
        /// 2021-02-01.
        /// </summary>
        public static readonly string V2021_02_01 = "2021-02-01";

        /// <summary>
        /// 2021-01-15.
        /// </summary>
        public static readonly string V2021_01_15 = "2021-01-15";

        /// <summary>
        /// 2021-01-01.
        /// </summary>
        public static readonly string V2021_01_01 = "2021-01-01";

        /// <summary>
        /// 2020-12-01.
        /// </summary>
        public static readonly string V2020_12_01 = "2020-12-01";

        /// <summary>
        /// 2020-10-01.
        /// </summary>
        public static readonly string V2020_10_01 = "2020-10-01";

        /// <summary>
        /// 2020-09-01.
        /// </summary>
        public static readonly string V2020_09_01 = "2020-09-01";

        /// <summary>
        /// 2020-06-01.
        /// </summary>
        public static readonly string V2020_06_01 = "2020-06-01";

        /// <summary>
        /// 2019-08-01.
        /// </summary>
        public static readonly string V2019_08_01 = "2019-08-01";

        /// <summary>
        /// 2018-11-01.
        /// </summary>
        public static readonly string V2018_11_01 = "2018-11-01";

        /// <summary>
        /// 2018-02-01.
        /// </summary>
        public static readonly string V2018_02_01 = "2018-02-01";

        /// <summary>
        /// 2017-08-01.
        /// </summary>
        public static readonly string V2017_08_01 = "2017-08-01";

        /// <summary>
        /// 2016-09-01.
        /// </summary>
        public static readonly string V2016_09_01 = "2016-09-01";

        /// <summary>
        /// 2016-08-01.
        /// </summary>
        public static readonly string V2016_08_01 = "2016-08-01";

        /// <summary>
        /// 2016-03-01.
        /// </summary>
        public static readonly string V2016_03_01 = "2016-03-01";

        /// <summary>
        /// 2015-11-01.
        /// </summary>
        public static readonly string V2015_11_01 = "2015-11-01";

        /// <summary>
        /// 2015-08-01.
        /// </summary>
        public static readonly string V2015_08_01 = "2015-08-01";

        /// <summary>
        /// 2015-07-01.
        /// </summary>
        public static readonly string V2015_07_01 = "2015-07-01";

        /// <summary>
        /// 2015-06-01.
        /// </summary>
        public static readonly string V2015_06_01 = "2015-06-01";

        /// <summary>
        /// 2015-05-01.
        /// </summary>
        public static readonly string V2015_05_01 = "2015-05-01";

        /// <summary>
        /// 2015-04-01.
        /// </summary>
        public static readonly string V2015_04_01 = "2015-04-01";

        /// <summary>
        /// 2015-02-01.
        /// </summary>
        public static readonly string V2015_02_01 = "2015-02-01";

        /// <summary>
        /// 2015-01-01.
        /// </summary>
        public static readonly string V2015_01_01 = "2015-01-01";

        /// <summary>
        /// 2014-11-01.
        /// </summary>
        public static readonly string V2014_11_01 = "2014-11-01";

        /// <summary>
        /// 2014-06-01.
        /// </summary>
        public static readonly string V2014_06_01 = "2014-06-01";

        /// <summary>
        /// 2014-04-01.
        /// </summary>
        public static readonly string V2014_04_01 = "2014-04-01";
    }

    /// <summary>
    /// Creates a reference to an existing SiteSlotVirtualNetworkConnection.
    /// </summary>
    /// <param name="resourceName">Name of the SiteSlotVirtualNetworkConnection.</param>
    /// <param name="resourceVersion">Version of the SiteSlotVirtualNetworkConnection.</param>
    /// <returns>The existing SiteSlotVirtualNetworkConnection resource.</returns>
    public static SiteSlotVirtualNetworkConnection FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
