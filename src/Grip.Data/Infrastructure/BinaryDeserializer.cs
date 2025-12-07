using System;
using System.Runtime.InteropServices;

namespace Grip.Data.Infrastructure;

public static class BinaryDeserializer
{
    public static T Deserialize<T>(byte[] span)
        where T : struct
    {
        var handle = GCHandle.Alloc(span, GCHandleType.Pinned);
        try
        {
            return Marshal.PtrToStructure<T>(handle.AddrOfPinnedObject());
        }
        finally
        {
            handle.Free();
        }
    }
}
