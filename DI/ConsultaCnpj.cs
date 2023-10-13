using Newtonsoft.Json;


namespace Sistema_vendas.DI
{
    public class ConsultaCnpj
    {

        [JsonProperty(PropertyName = "razao_social")]
        public string Nome { get; set; }

        public Estabelecimento estabelecimento { get; set; }

    }


    public class Estabelecimento
    {
        [JsonProperty(PropertyName = "logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty(PropertyName = "bairro")]
        public string Bairro { get; set; }

        [JsonProperty(PropertyName = "cep")]
        public string CEP { get; set; }

        [JsonProperty(PropertyName = "ddd1")]
        public string DDD { get; set; }

        [JsonProperty(PropertyName = "telefone1")]
        public string Telefone { get; set; }

        [JsonProperty(PropertyName = "numero")]
        public string Complemento { get; set; }

        public Estado estado = new Estado();

        public Cidade cidade = new Cidade();

    }
    public class Estado
    {
        [JsonProperty(PropertyName = "sigla")]
        public string Sigla { get; set; }
    }

    public class Cidade
    {
        [JsonProperty(PropertyName = "nome")]
        public string Nome_cidade { get; set; }
    }

}























/*
 












        [JsonProperty(PropertyName = "nome")]
        public string Cidade { get; set; }

        Estado estado { get; set; }


*/