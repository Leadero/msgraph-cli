// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Security {
    public class KubernetesPodEvidence : AlertEvidence, IParsable {
        /// <summary>The list of pod containers which are not init or ephemeral containers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ContainerEvidence>? Containers { get; set; }
#nullable restore
#else
        public List<ContainerEvidence> Containers { get; set; }
#endif
        /// <summary>The pod controller.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KubernetesControllerEvidence? Controller { get; set; }
#nullable restore
#else
        public KubernetesControllerEvidence Controller { get; set; }
#endif
        /// <summary>The list of pod ephemeral containers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ContainerEvidence>? EphemeralContainers { get; set; }
#nullable restore
#else
        public List<ContainerEvidence> EphemeralContainers { get; set; }
#endif
        /// <summary>The list of pod init containers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ContainerEvidence>? InitContainers { get; set; }
#nullable restore
#else
        public List<ContainerEvidence> InitContainers { get; set; }
#endif
        /// <summary>The pod labels.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Dictionary? Labels { get; set; }
#nullable restore
#else
        public Dictionary Labels { get; set; }
#endif
        /// <summary>The pod name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The pod namespace.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KubernetesNamespaceEvidence? Namespace { get; set; }
#nullable restore
#else
        public KubernetesNamespaceEvidence Namespace { get; set; }
#endif
        /// <summary>The pod IP.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IpEvidence? PodIp { get; set; }
#nullable restore
#else
        public IpEvidence PodIp { get; set; }
#endif
        /// <summary>The pod service account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KubernetesServiceAccountEvidence? ServiceAccount { get; set; }
#nullable restore
#else
        public KubernetesServiceAccountEvidence ServiceAccount { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="KubernetesPodEvidence"/> and sets the default values.
        /// </summary>
        public KubernetesPodEvidence() : base() {
            OdataType = "#microsoft.graph.security.kubernetesPodEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <cref="KubernetesPodEvidence"></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new KubernetesPodEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KubernetesPodEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A <cref="IDictionary<string, Action<IParseNode>>"></returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"containers", n => { Containers = n.GetCollectionOfObjectValues<ContainerEvidence>(ContainerEvidence.CreateFromDiscriminatorValue)?.ToList(); } },
                {"controller", n => { Controller = n.GetObjectValue<KubernetesControllerEvidence>(KubernetesControllerEvidence.CreateFromDiscriminatorValue); } },
                {"ephemeralContainers", n => { EphemeralContainers = n.GetCollectionOfObjectValues<ContainerEvidence>(ContainerEvidence.CreateFromDiscriminatorValue)?.ToList(); } },
                {"initContainers", n => { InitContainers = n.GetCollectionOfObjectValues<ContainerEvidence>(ContainerEvidence.CreateFromDiscriminatorValue)?.ToList(); } },
                {"labels", n => { Labels = n.GetObjectValue<Dictionary>(Dictionary.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"namespace", n => { Namespace = n.GetObjectValue<KubernetesNamespaceEvidence>(KubernetesNamespaceEvidence.CreateFromDiscriminatorValue); } },
                {"podIp", n => { PodIp = n.GetObjectValue<IpEvidence>(IpEvidence.CreateFromDiscriminatorValue); } },
                {"serviceAccount", n => { ServiceAccount = n.GetObjectValue<KubernetesServiceAccountEvidence>(KubernetesServiceAccountEvidence.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ContainerEvidence>("containers", Containers);
            writer.WriteObjectValue<KubernetesControllerEvidence>("controller", Controller);
            writer.WriteCollectionOfObjectValues<ContainerEvidence>("ephemeralContainers", EphemeralContainers);
            writer.WriteCollectionOfObjectValues<ContainerEvidence>("initContainers", InitContainers);
            writer.WriteObjectValue<Dictionary>("labels", Labels);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<KubernetesNamespaceEvidence>("namespace", Namespace);
            writer.WriteObjectValue<IpEvidence>("podIp", PodIp);
            writer.WriteObjectValue<KubernetesServiceAccountEvidence>("serviceAccount", ServiceAccount);
        }
    }
}
