using System;
using System.Threading.Tasks;

namespace UnisaAula1
{
    class Carro
    {
        public string marca;
        public string modelo;
        public int ano;

        //calculando valor de vendas
        public double valorVenda(double custo, double p)
        {
            double lucro;
            lucro = custo * p / 100;
            return (lucro + custo);
        }

        //obtendo total de vendas
        public double total(double venda, int quant)
        {
            return (venda* quant);
        }

    }
    
}
