using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

public class ActualizadorStock
{
    private readonly ConcurrentQueue<Func<Task>> _colaDeTareas = new ConcurrentQueue<Func<Task>>();
    private readonly SemaphoreSlim _semaforo = new SemaphoreSlim(1);

    public async Task EncolarActualizacionStock(Func<Task> ActualizarStockTask)
    {
        _colaDeTareas.Enqueue(ActualizarStockTask);
        await ColaDeProcesos();
    }

    private async Task ColaDeProcesos()
    {
        if (_semaforo.CurrentCount == 0)
        {
            return;
        }

        await _semaforo.WaitAsync();
        try
        {
            while (_colaDeTareas.TryDequeue(out var task))
            {
                await task();
            }
        }
        finally
        {
            _ = _semaforo.Release();
        }
    }
}
