using System.Collections.Generic;
using System.Threading;

namespace EventStore.Replicator.Shared {
    public interface IEventReader {
        IAsyncEnumerable<EventRead> ReadEvents(Position position, CancellationToken cancellationToken);
    }
}
