﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReceitasAPI.Models
{
    public partial class Recipe
    {
        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("secao")]
        public List<Secao> Secao { get; set; }
    }

    public partial class Secao
    {
        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("conteudo")]
        public List<string> Conteudo { get; set; }
    }
}
