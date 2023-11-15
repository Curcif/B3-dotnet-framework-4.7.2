using B3.Entidades;

namespace B3.Interfaces
{
    public interface IInvestimentoServices
    {
        InvestidorEntity CalcularInvestimento(InvestidorEntity dadosInvestidor);
    }
}
