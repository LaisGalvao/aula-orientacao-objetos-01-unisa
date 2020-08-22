using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnisaAula1
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancia de classe
            Carro c = new Carro();
            double custo, porc;
            double venda;
            int qtd;
            string marca = c.marca;
            string modelo = c.modelo;
            int ano = c.ano;
            
            //informações de venda, marca, modelo e ano do carro

            //obtendo marca
            Console.Write("digite a marca do carro: ");
            marca = Console.ReadLine();
            //obtendo modelo
            Console.Write("digite a modelo do carro: ");
            modelo = Console.ReadLine();
            //obtendo ano
            Console.Write("digite o ano do carro: ");
            ano = Convert.ToInt32(Console.ReadLine());
            //obtendo custo e lucro
            Console.Write("Digite o valor de custo do carro: R$ ");
            custo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o % de lucro do carro: R$ ");
            porc = Convert.ToDouble(Console.ReadLine());
            //obtendo quantidade e valor de vendas
            Console.Write("Digite a quantidade de carros vendidos: R$ ");
            qtd = Convert.ToInt32(Console.ReadLine());

            //escrevendo meus valores e obtendo total de vendas
            Console.WriteLine("\n - Marca: "+ marca +"\n - Modelo: "+ modelo + "\n - Ano: " + ano);
            Console.WriteLine("\n Valor de venda: R$ "+c.valorVenda(custo, porc));
            venda = c.valorVenda(custo, porc) + qtd;
            Console.WriteLine("total de vendas: "+c.total(venda, qtd));
            Console.WriteLine("\nPressione enter para finalizar..");
            Console.ReadKey();
        }
    }
}
