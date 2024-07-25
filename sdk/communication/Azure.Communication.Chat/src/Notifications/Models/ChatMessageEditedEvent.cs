﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Text;
using System.Threading;

namespace Azure.Communication.Chat.Notifications.Models
{
    /// <summary>
    /// Property
    /// </summary>
    public class ChatMessageEditedEvent : ChatUserEvent
    {
        internal ChatMessageEditedEvent(bool isRunningSynchronously, CancellationToken cancellationToken = default) : base(isRunningSynchronously, cancellationToken)
        {
        }

        /// <summary>
        /// Property
        /// </summary>
        public string Content { get; }

        /// <summary>
        /// Property
        /// </summary>
        public DateTimeOffset EditedOn { get; }

        /// <summary>
        /// Property
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Property
        /// </summary>
        public string SenderDisplayName { get; }

        /// <summary>
        /// Property
        /// </summary>
        public DateTimeOffset CreatedOn { get; }

        /// <summary>
        /// Property
        /// </summary>
        public string Version { get; }

        /// <summary>
        /// Property
        /// </summary>
        public IReadOnlyDictionary<string, string> Metadata { get; }

        /// <summary>
        /// Property
        /// </summary>
        public ChatMessageType Type { get; }
    }
}
