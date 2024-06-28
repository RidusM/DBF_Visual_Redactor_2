using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBF_Visual_Redactor.DataClasses
{
    internal class RecordsList
    {
        [JsonProperty("VALUE")]
        public string VALUE { get; set; }
        [JsonProperty("NAME")]
        public string NAME { get; set; }
    }
}
