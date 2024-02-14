// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class CommunicationsIdentitySet : IdentitySet, IParsable {
        /// <summary>The application instance associated with this action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Identity? ApplicationInstance { get; set; }
#nullable restore
#else
        public Identity ApplicationInstance { get; set; }
#endif
        /// <summary>An identity the participant would like to present itself as to the other participants in the call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Identity? AssertedIdentity { get; set; }
#nullable restore
#else
        public Identity AssertedIdentity { get; set; }
#endif
        /// <summary>The Azure Communication Services user associated with this action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Identity? AzureCommunicationServicesUser { get; set; }
#nullable restore
#else
        public Identity AzureCommunicationServicesUser { get; set; }
#endif
        /// <summary>The encrypted user associated with this action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Identity? Encrypted { get; set; }
#nullable restore
#else
        public Identity Encrypted { get; set; }
#endif
        /// <summary>Type of endpoint that the participant uses. Possible values are: default, voicemail, skypeForBusiness, skypeForBusinessVoipPhone, unknownFutureValue.</summary>
        public ApiSdk.Models.EndpointType? EndpointType { get; set; }
        /// <summary>The guest user associated with this action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Identity? Guest { get; set; }
#nullable restore
#else
        public Identity Guest { get; set; }
#endif
        /// <summary>The Skype for Business on-premises user associated with this action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Identity? OnPremises { get; set; }
#nullable restore
#else
        public Identity OnPremises { get; set; }
#endif
        /// <summary>The phone user associated with this action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Identity? Phone { get; set; }
#nullable restore
#else
        public Identity Phone { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="CommunicationsIdentitySet"/> and sets the default values.
        /// </summary>
        public CommunicationsIdentitySet() : base() {
            OdataType = "#microsoft.graph.communicationsIdentitySet";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <cref="CommunicationsIdentitySet"></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CommunicationsIdentitySet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CommunicationsIdentitySet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A <cref="IDictionary<string, Action<IParseNode>>"></returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicationInstance", n => { ApplicationInstance = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"assertedIdentity", n => { AssertedIdentity = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"azureCommunicationServicesUser", n => { AzureCommunicationServicesUser = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"encrypted", n => { Encrypted = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"endpointType", n => { EndpointType = n.GetEnumValue<EndpointType>(); } },
                {"guest", n => { Guest = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"onPremises", n => { OnPremises = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"phone", n => { Phone = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Identity>("applicationInstance", ApplicationInstance);
            writer.WriteObjectValue<Identity>("assertedIdentity", AssertedIdentity);
            writer.WriteObjectValue<Identity>("azureCommunicationServicesUser", AzureCommunicationServicesUser);
            writer.WriteObjectValue<Identity>("encrypted", Encrypted);
            writer.WriteEnumValue<EndpointType>("endpointType", EndpointType);
            writer.WriteObjectValue<Identity>("guest", Guest);
            writer.WriteObjectValue<Identity>("onPremises", OnPremises);
            writer.WriteObjectValue<Identity>("phone", Phone);
        }
    }
}
