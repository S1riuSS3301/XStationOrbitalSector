using System;
using Robust.Shared.Serialization;

namespace Content.Shared.ERP
{
    [Serializable, NetSerializable]
    public enum ERPStatus
    {
        Disabled,
        Enabled,
        Ask
    }
}
