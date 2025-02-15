// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Create protection container input. </summary>
    public partial class ProtectionContainerCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of ProtectionContainerCreateOrUpdateContent. </summary>
        public ProtectionContainerCreateOrUpdateContent()
        {
        }

        /// <summary> Create protection container input properties. </summary>
        internal CreateProtectionContainerInputProperties Properties { get; set; }
        /// <summary>
        /// Provider specific inputs for container creation.
        /// Please note <see cref="ReplicationProviderSpecificContainerCreationInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2AContainerCreationInput"/>, <see cref="A2ACrossClusterMigrationContainerCreationInput"/> and <see cref="VMwareCbtContainerCreationInput"/>.
        /// Please note <see cref="ReplicationProviderSpecificContainerCreationInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2AContainerCreationInput"/>, <see cref="A2ACrossClusterMigrationContainerCreationInput"/> and <see cref="VMwareCbtContainerCreationInput"/>.
        /// </summary>
        public IList<ReplicationProviderSpecificContainerCreationInput> ProviderSpecificInput
        {
            get
            {
                if (Properties is null)
                    Properties = new CreateProtectionContainerInputProperties();
                return Properties.ProviderSpecificInput;
            }
        }
    }
}
