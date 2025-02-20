// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> Collection of key vault keys. </summary>
    internal partial class IntegrationAccountKeyVaultKeyList
    {
        /// <summary> Initializes a new instance of IntegrationAccountKeyVaultKeyList. </summary>
        internal IntegrationAccountKeyVaultKeyList()
        {
            Value = new ChangeTrackingList<IntegrationAccountKeyVaultKey>();
        }

        /// <summary> Initializes a new instance of IntegrationAccountKeyVaultKeyList. </summary>
        /// <param name="value"> The key vault keys. </param>
        /// <param name="skipToken"> The skip token. </param>
        internal IntegrationAccountKeyVaultKeyList(IReadOnlyList<IntegrationAccountKeyVaultKey> value, string skipToken)
        {
            Value = value;
            SkipToken = skipToken;
        }

        /// <summary> The key vault keys. </summary>
        public IReadOnlyList<IntegrationAccountKeyVaultKey> Value { get; }
        /// <summary> The skip token. </summary>
        public string SkipToken { get; }
    }
}
