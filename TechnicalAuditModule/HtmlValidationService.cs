using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace TechnicalAuditModule
{
    public  class HtmlValidationService
    {
        private ILogger _logger;
        private IConfigurationService _config;

        internal HtmlValidationService(ILogger logger, IConfigurationService config)
        {
            _logger = logger;
            _config = config;

        }
            public  async Task<string> HtmlCheckAsync(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.UserAgent = ".NET Framework Test Client";
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}
