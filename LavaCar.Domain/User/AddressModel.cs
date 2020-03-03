using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LavaCar.Domain.User
{
    public class AddressModel
    {
        public long AddressModelId { get; set; }

        [JsonProperty("cep")]
        public string ZipCode { get; set; }

        [JsonProperty("logradouro")]
        public string Street { get; set; }

        [JsonProperty("complemento")]
        public string Complement { get; set; }

        [JsonProperty("bairro")]
        public string Neighborhood { get; set; }

        [JsonProperty("localidade")]
        public string City { get; set; }

        [JsonProperty("uf")]
        public string StateInitials { get; set; }

        [JsonProperty("unidade")]
        public string Unit { get; set; }

        [JsonProperty("ibge")]
        public string IBGECode { get; set; }

        [JsonProperty("gia")]
        public string GiaCode { get; set; }
    }
}
