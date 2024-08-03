namespace fatec_rent.API
{
    public class Veiculo
    {
        public Guid Id { get; set; }
        public string? Categoria { get; set; }
        public string? Modelo { get; set; }
        public int CapacidadePassageiros { get; set; }
        public string? Combustivel { get; set; }
        public Decimal Preco { get; set; }
    }
}
