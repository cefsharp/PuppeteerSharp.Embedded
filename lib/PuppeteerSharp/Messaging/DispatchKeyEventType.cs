using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CefSharp.Dom.Messaging
{
    [JsonConverter(typeof(StringEnumConverter))]
    internal enum DispatchKeyEventType
    {
        [EnumMember(Value = "keyDown")]
        KeyDown,
        [EnumMember(Value = "rawKeyDown")]
        RawKeyDown,
        [EnumMember(Value = "keyUp")]
        KeyUp,
    }
}
