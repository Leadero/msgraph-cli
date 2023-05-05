using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// Entity which represents a connection to Mobile Threat Defense partner.
    /// </summary>
    public class MobileThreatDefenseConnector : Entity, IParsable {
        /// <summary>When TRUE, indicates the Mobile Threat Defense partner may collect metadata about installed applications from Intune for IOS devices. When FALSE, indicates the Mobile Threat Defense partner may not collect metadata about installed applications from Intune for IOS devices. Default value is FALSE.</summary>
        public bool? AllowPartnerToCollectIOSApplicationMetadata { get; set; }
        /// <summary>When TRUE, indicates the Mobile Threat Defense partner may collect metadata about personally installed applications from Intune for IOS devices. When FALSE, indicates the Mobile Threat Defense partner may not collect metadata about personally installed applications from Intune for IOS devices. Default value is FALSE.</summary>
        public bool? AllowPartnerToCollectIOSPersonalApplicationMetadata { get; set; }
        /// <summary>For Android, set whether Intune must receive data from the Mobile Threat Defense partner prior to marking a device compliant</summary>
        public bool? AndroidDeviceBlockedOnMissingPartnerData { get; set; }
        /// <summary>For Android, set whether data from the Mobile Threat Defense partner should be used during compliance evaluations</summary>
        public bool? AndroidEnabled { get; set; }
        /// <summary>When TRUE, inidicates that data from the Mobile Threat Defense partner can be used during Mobile Application Management (MAM) evaluations for Android devices. When FALSE, inidicates that data from the Mobile Threat Defense partner should not be used during Mobile Application Management (MAM) evaluations for Android devices. Only one partner per platform may be enabled for Mobile Application Management (MAM) evaluation. Default value is FALSE.</summary>
        public bool? AndroidMobileApplicationManagementEnabled { get; set; }
        /// <summary>For IOS, set whether Intune must receive data from the Mobile Threat Defense partner prior to marking a device compliant</summary>
        public bool? IosDeviceBlockedOnMissingPartnerData { get; set; }
        /// <summary>For IOS, get or set whether data from the Mobile Threat Defense partner should be used during compliance evaluations</summary>
        public bool? IosEnabled { get; set; }
        /// <summary>When TRUE, inidicates that data from the Mobile Threat Defense partner can be used during Mobile Application Management (MAM) evaluations for IOS devices. When FALSE, inidicates that data from the Mobile Threat Defense partner should not be used during Mobile Application Management (MAM) evaluations for IOS devices. Only one partner per platform may be enabled for Mobile Application Management (MAM) evaluation. Default value is FALSE.</summary>
        public bool? IosMobileApplicationManagementEnabled { get; set; }
        /// <summary>DateTime of last Heartbeat recieved from the Mobile Threat Defense partner</summary>
        public DateTimeOffset? LastHeartbeatDateTime { get; set; }
        /// <summary>When TRUE, inidicates that configuration profile management via Microsoft Defender for Endpoint is enabled. When FALSE, inidicates that configuration profile management via Microsoft Defender for Endpoint is disabled. Default value is FALSE.</summary>
        public bool? MicrosoftDefenderForEndpointAttachEnabled { get; set; }
        /// <summary>Partner state of this tenant.</summary>
        public MobileThreatPartnerTenantState? PartnerState { get; set; }
        /// <summary>Get or Set days the per tenant tolerance to unresponsiveness for this partner integration</summary>
        public int? PartnerUnresponsivenessThresholdInDays { get; set; }
        /// <summary>Get or set whether to block devices on the enabled platforms that do not meet the minimum version requirements of the Mobile Threat Defense partner</summary>
        public bool? PartnerUnsupportedOsVersionBlocked { get; set; }
        /// <summary>When TRUE, inidicates that Intune must receive data from the Mobile Threat Defense partner prior to marking a device compliant for Windows. When FALSE, inidicates that Intune may make a device compliant without receiving data from the Mobile Threat Defense partner for Windows. Default value is FALSE.</summary>
        public bool? WindowsDeviceBlockedOnMissingPartnerData { get; set; }
        /// <summary>When TRUE, inidicates that data from the Mobile Threat Defense partner can be used during compliance evaluations for Windows. When FALSE, inidicates that data from the Mobile Threat Defense partner should not be used during compliance evaluations for Windows. Default value is FALSE.</summary>
        public bool? WindowsEnabled { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MobileThreatDefenseConnector CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileThreatDefenseConnector();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowPartnerToCollectIOSApplicationMetadata", n => { AllowPartnerToCollectIOSApplicationMetadata = n.GetBoolValue(); } },
                {"allowPartnerToCollectIOSPersonalApplicationMetadata", n => { AllowPartnerToCollectIOSPersonalApplicationMetadata = n.GetBoolValue(); } },
                {"androidDeviceBlockedOnMissingPartnerData", n => { AndroidDeviceBlockedOnMissingPartnerData = n.GetBoolValue(); } },
                {"androidEnabled", n => { AndroidEnabled = n.GetBoolValue(); } },
                {"androidMobileApplicationManagementEnabled", n => { AndroidMobileApplicationManagementEnabled = n.GetBoolValue(); } },
                {"iosDeviceBlockedOnMissingPartnerData", n => { IosDeviceBlockedOnMissingPartnerData = n.GetBoolValue(); } },
                {"iosEnabled", n => { IosEnabled = n.GetBoolValue(); } },
                {"iosMobileApplicationManagementEnabled", n => { IosMobileApplicationManagementEnabled = n.GetBoolValue(); } },
                {"lastHeartbeatDateTime", n => { LastHeartbeatDateTime = n.GetDateTimeOffsetValue(); } },
                {"microsoftDefenderForEndpointAttachEnabled", n => { MicrosoftDefenderForEndpointAttachEnabled = n.GetBoolValue(); } },
                {"partnerState", n => { PartnerState = n.GetEnumValue<MobileThreatPartnerTenantState>(); } },
                {"partnerUnresponsivenessThresholdInDays", n => { PartnerUnresponsivenessThresholdInDays = n.GetIntValue(); } },
                {"partnerUnsupportedOsVersionBlocked", n => { PartnerUnsupportedOsVersionBlocked = n.GetBoolValue(); } },
                {"windowsDeviceBlockedOnMissingPartnerData", n => { WindowsDeviceBlockedOnMissingPartnerData = n.GetBoolValue(); } },
                {"windowsEnabled", n => { WindowsEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowPartnerToCollectIOSApplicationMetadata", AllowPartnerToCollectIOSApplicationMetadata);
            writer.WriteBoolValue("allowPartnerToCollectIOSPersonalApplicationMetadata", AllowPartnerToCollectIOSPersonalApplicationMetadata);
            writer.WriteBoolValue("androidDeviceBlockedOnMissingPartnerData", AndroidDeviceBlockedOnMissingPartnerData);
            writer.WriteBoolValue("androidEnabled", AndroidEnabled);
            writer.WriteBoolValue("androidMobileApplicationManagementEnabled", AndroidMobileApplicationManagementEnabled);
            writer.WriteBoolValue("iosDeviceBlockedOnMissingPartnerData", IosDeviceBlockedOnMissingPartnerData);
            writer.WriteBoolValue("iosEnabled", IosEnabled);
            writer.WriteBoolValue("iosMobileApplicationManagementEnabled", IosMobileApplicationManagementEnabled);
            writer.WriteDateTimeOffsetValue("lastHeartbeatDateTime", LastHeartbeatDateTime);
            writer.WriteBoolValue("microsoftDefenderForEndpointAttachEnabled", MicrosoftDefenderForEndpointAttachEnabled);
            writer.WriteEnumValue<MobileThreatPartnerTenantState>("partnerState", PartnerState);
            writer.WriteIntValue("partnerUnresponsivenessThresholdInDays", PartnerUnresponsivenessThresholdInDays);
            writer.WriteBoolValue("partnerUnsupportedOsVersionBlocked", PartnerUnsupportedOsVersionBlocked);
            writer.WriteBoolValue("windowsDeviceBlockedOnMissingPartnerData", WindowsDeviceBlockedOnMissingPartnerData);
            writer.WriteBoolValue("windowsEnabled", WindowsEnabled);
        }
    }
}
