using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yt_JsonInCsharp
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Post>(myJsonResponse);
    
        // Notera att JsonProperty har id med gement i, medan C# har ett versalt I i sitt Id, därför måste Json Property användas
        // samma för title - Title
        public class Post
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }
        }
}

