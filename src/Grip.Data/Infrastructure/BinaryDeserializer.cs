using System;
using System.Runtime.InteropServices;

namespace Grip.Data.Infrastructure;

public static class BinaryDeserializer
{
    public static T Deserialize<T>(ReadOnlySpan<byte> span)
        where T : struct
    {
        var handle = GCHandle.Alloc(span.GetPinnableReference(), GCHandleType.Pinned);
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
