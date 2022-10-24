using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace DotaCounterPicker.Client;

public partial class DotaClient
{
    public Task PrepareRequestAsync(HttpClient? client, HttpRequestMessage? message, StringBuilder? url, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public Task PrepareRequestAsync(HttpClient? client, HttpRequestMessage? message, string url, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public Task ProcessResponseAsync(HttpClient? client, HttpResponseMessage? message, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    } 
}
