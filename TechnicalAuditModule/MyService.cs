using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace TechnicalAuditModule
{
    public static class MyService
    {
        public static async Task<int> DownloadAndCountBytesAsync(string url, CancellationToken token = new CancellationToken())
        {
            await Task.Delay(TimeSpan.FromSeconds(3), token).ConfigureAwait(false);
            var client = new HttpClient();
            using (var response = await client.GetAsync(url, token).ConfigureAwait(false))
            {
                var data = await
                  response.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
                return data.Length;
            }
        }
    }
}
