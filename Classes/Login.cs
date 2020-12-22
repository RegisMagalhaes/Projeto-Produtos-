using System;


namespace Produtos.Classes
{
    public class Login 
    {
        public Login(){
            Logar();

            if (Logado == true)
            {
                gerarMenu();
            }
        }

        public void gerarMenu(){

            Produto produto = new Produto();
            Marca marca = new Marca();

            string opcao = "n";

            do
            {
                Console.WriteLine("Escolha uma das opções abaixo: ");
                Console.WriteLine("1 - Cadastrar Marcas");
                Console.WriteLine("2 - Litar Marcas ");
                Console.WriteLine("3 - Excluir Marcas");
                Console.WriteLine("4 - Cadastrar Produtos");
                Console.WriteLine("5 - Excluir Produtos ");
                Console.WriteLine("0 - Sair da Aplicação");

                opcao  = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                    marca.Cadastrar();
                        break;

                    case "2":
                    marca.Listar();
                        break;

                    case "3":
                    Console.WriteLine("Digite um codigo para excluir a marca:");
                    int codigo = int.Parse(Console.ReadLine());
                    marca.Deletar(codigo);
                        break;

                    case "4":
                    produto.Cadastrar();
                        break;

                    case "5":
                    produto.Listar();
                        break;
                    case "0":
                    Console.WriteLine("Digite um codigo para excluir a marca:");
                    int codigoProduto = int.Parse(Console.ReadLine());
                    produto.Deletar(codigoProduto);
                        break;  

                    default:
                        break;
                }
                

            } while (opcao != "0");

        }
        protected bool Logado { get; set; }


        public void Logar(){

            Usuario user = new Usuario();
            System.Console.WriteLine("Digite seu E-mail");
            string emailLogin = Console.ReadLine();

            System.Console.WriteLine("Digite sua Senha: ");
            string senhaLogin = Console.ReadLine();

            if (emailLogin == user.Email && senhaLogin == user.Senha)
            {
                Logado = true;
                System.Console.WriteLine("Login efetuado com sucesso");
            }else{
                System.Console.WriteLine("Tente novamente");
            }
        }

        public void Deslogar(){

        }

    }





    


}    