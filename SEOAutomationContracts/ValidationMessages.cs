using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEOAutomationContracts
{
    public class ValidationMessages
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("messages")]
        public List<MessageItem> Messages { get; set; }
    }

    public class MessageItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("subtype")]
        public string Subtype { get; set; }

        [JsonProperty("lastLine")]
        public int LastLine { get; set; }

        [JsonProperty("lastColumn")]
        public int LastColumn { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("extract")]
        public string Extract { get; set; }

        [JsonProperty("hiliteStart")]
        public int HiliteStart { get; set; }

        [JsonProperty("hiliteLength")]
        public int HiliteLength { get; set; }
    }
}
