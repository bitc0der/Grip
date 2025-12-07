using System;
using System.Threading;
using System.Threading.Tasks;

namespace Grip.Data;

public abstract class DataLogger
{
    public ValueTask LogDataAsync(ReadOnlySpan<byte> data, CancellationToken cancellationToken = default)
    {
        return ValueTask.CompletedTask;
    }
}
