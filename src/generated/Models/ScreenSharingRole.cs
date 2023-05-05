using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ScreenSharingRole {
        [EnumMember(Value = "viewer")]
        Viewer,
        [EnumMember(Value = "sharer")]
        Sharer,
    }
}
