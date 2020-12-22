using System;
using System.Collections.Generic;

namespace Produtos.Classes
{
    public class Produto
    {
        protected int Codigo { get; set; }

        protected string NomeProduto { get; set; }

        protected float Preco { get; set; }

        public DateTime DataCadastro { get; set; }
        public object Usuario { get; set; }

        public Marca Marca = new Marca();


        public Usuario CadastradoPor = new Usuario();

        public List<Produto> ListaDeProdutos = new List<Produto>();

        public void Cadastrar(){

            Produto novoproduto = new Produto();
            System.Console.WriteLine("Digite o código do produto: ");
            novoproduto.Codigo = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o nome do produto: ");
            novoproduto.NomeProduto = Console.ReadLine();

            System.Console.WriteLine("Digite o preço do produto: ");
            novoproduto.Preco = float.Parse(Console.ReadLine());

            DataCadastro = DateTime.UtcNow;

            novoproduto.CadastradoPor=new Usuario();

            novoproduto.Marca = Marca.Cadastrar();

            ListaDeProdutos.Add(novoproduto);

        }

        public void Listar(){

            Console.ForegroundColor =  ConsoleColor.Green;

            foreach (Produto item in ListaDeProdutos)
            {
                System.Console.WriteLine($"Codigo: {item.Codigo}");
                System.Console.WriteLine($"Produto: {item.NomeProduto}");
                System.Console.WriteLine($"Preço: R${item.Preco}");
                System.Console.WriteLine($"Data do Cadastro: {item.DataCadastro}");
                System.Console.WriteLine($"Marca: {item.Marca.NomeMarca}");
                System.Console.WriteLine($"Cadastrado por: {item.CadastradoPor.Nome}");
            }

            Console.ResetColor();

        }

        public void Deletar(int cod){

            Produto prodDelete = ListaDeProdutos.Find(x=>x.Codigo == cod);
            ListaDeProdutos.Remove(prodDelete);

            
        }
        
        
        
        
    }
}