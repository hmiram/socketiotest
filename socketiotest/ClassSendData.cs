﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace socketiotest
{
    class ClassSendData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        
        
    }
}
