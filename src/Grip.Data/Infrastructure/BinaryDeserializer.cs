using System;
using System.Runtime.InteropServices;

namespace Grip.Data.Infrastructure;

public static class BinaryDeserializer
{
    public static T Deserialize<T>(byte[] buffer)
        where T : struct
    {
        ArgumentNullException.ThrowIfNull(buffer);

        var handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
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
