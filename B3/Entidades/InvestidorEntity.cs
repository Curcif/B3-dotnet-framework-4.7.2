namespace B3.Entidades
{
    public class InvestidorEntity
    {
        public decimal ValorAplicado { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorLiquido { get; set; }
        public decimal Rendimento { get; set; }
        public decimal Imposto { get; set; }
        public int QtdMesesInvestidos { get; set; }
    }
}
