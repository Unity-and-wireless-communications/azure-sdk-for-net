// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// EventGridNamespacePermissionBinding.
/// </summary>
public partial class EventGridNamespacePermissionBinding : Resource
{
    /// <summary>
    /// The permission binding name.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The name of the client group resource that the permission is bound to.
    /// The client group needs to be a resource under the same
    /// namespace the permission binding is a part of.
    /// </summary>
    public BicepValue<string> ClientGroupName { get => _clientGroupName; set => _clientGroupName.Assign(value); }
    private readonly BicepValue<string> _clientGroupName;

    /// <summary>
    /// Description for the Permission Binding resource.
    /// </summary>
    public BicepValue<string> Description { get => _description; set => _description.Assign(value); }
    private readonly BicepValue<string> _description;

    /// <summary>
    /// The allowed permission.
    /// </summary>
    public BicepValue<PermissionType> Permission { get => _permission; set => _permission.Assign(value); }
    private readonly BicepValue<PermissionType> _permission;

    /// <summary>
    /// The name of the Topic Space resource that the permission is bound to.
    /// The Topic space needs to be a resource under the same
    /// namespace the permission binding is a part of.
    /// </summary>
    public BicepValue<string> TopicSpaceName { get => _topicSpaceName; set => _topicSpaceName.Assign(value); }
    private readonly BicepValue<string> _topicSpaceName;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Provisioning state of the PermissionBinding resource.
    /// </summary>
    public BicepValue<PermissionBindingProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<PermissionBindingProvisioningState> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent EventGridNamespace.
    /// </summary>
    public EventGridNamespace? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<EventGridNamespace> _parent;

    /// <summary>
    /// Creates a new EventGridNamespacePermissionBinding.
    /// </summary>
    /// <param name="resourceName">Name of the EventGridNamespacePermissionBinding.</param>
    /// <param name="resourceVersion">Version of the EventGridNamespacePermissionBinding.</param>
    public EventGridNamespacePermissionBinding(string resourceName, string? resourceVersion = default)
        : base(resourceName, "Microsoft.EventGrid/namespaces/permissionBindings", resourceVersion ?? "2024-06-01-preview")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _clientGroupName = BicepValue<string>.DefineProperty(this, "ClientGroupName", ["properties", "clientGroupName"]);
        _description = BicepValue<string>.DefineProperty(this, "Description", ["properties", "description"]);
        _permission = BicepValue<PermissionType>.DefineProperty(this, "Permission", ["properties", "permission"]);
        _topicSpaceName = BicepValue<string>.DefineProperty(this, "TopicSpaceName", ["properties", "topicSpaceName"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _provisioningState = BicepValue<PermissionBindingProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<EventGridNamespace>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported EventGridNamespacePermissionBinding resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-06-01-preview.
        /// </summary>
        public static readonly string V2024_06_01_preview = "2024-06-01-preview";
    }

    /// <summary>
    /// Creates a reference to an existing EventGridNamespacePermissionBinding.
    /// </summary>
    /// <param name="resourceName">Name of the EventGridNamespacePermissionBinding.</param>
    /// <param name="resourceVersion">Version of the EventGridNamespacePermissionBinding.</param>
    /// <returns>The existing EventGridNamespacePermissionBinding resource.</returns>
    public static EventGridNamespacePermissionBinding FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
