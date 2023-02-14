using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class LibrarySystem
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public string Admin { get; set; }
        public string Password { get; set; }
        public string Cod { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public int ISBN { get; set; }
        public int Quantidade { get; set; }
        public int Stock { get; set; }
        public float Preco { get; set; }
        public float Total { get; set; }
        public float NovoTotal { get; set; }
        public float Iva { get; set; }
        public float NovoIva { get; set; }
        public string Opcao { get; set; }

        public LibrarySystem(int id, string cod, string titulo, string autor, string genero, int iSBN, int stock, float preco, float iva)
        {
            this.Id = id;
            this.Cod = cod;
            this.Titulo = titulo;
            this.Autor = autor;
            this.Genero = genero;
            this.ISBN = iSBN;
            this.Stock = stock;
            this.Preco = preco;
            this.Iva = iva;
        }

        public LibrarySystem(int iduser, string admin, string password)
        {
            this.IdUser = iduser;
            this.Admin = admin;
            this.Password = password;
        }

        public List<LibrarySystem> Utilizadores = new List<LibrarySystem>();
        public List<LibrarySystem> Livros = new List<LibrarySystem>();

        public LibrarySystem()
        {
            Utilizadores.Add(new LibrarySystem(IdUser = 1, Admin = "Gerente", Password = "gerente123"));
            Utilizadores.Add(new LibrarySystem(IdUser = 2, Admin = "Repositor", Password = "repositor123"));
            Utilizadores.Add(new LibrarySystem(IdUser = 3, Admin = "Caixa", Password = "caixa123"));

            Livros.Add(new LibrarySystem(1, "A44S", "Com o Humor Não se Brinca", "Nelson Nunes", "Comédia", 123456789, 22, (float)19.99, (float)0.23));
            Livros.Add(new LibrarySystem(2, "A55", "O Exorcista", "William Peter Blatty", "Terror", 987654321, 25, (float)9.99, (float)0.23));
            Livros.Add(new LibrarySystem(3, "B32", "Moby Dick", "Herman Melville", "Ação", 123454321, 20, (float)4.99, (float)0.06));
        }

        public void Opcoes()
        {
            Console.WriteLine("----------------ESCOLHA UMA OPÇÃO-------------------");
            Console.WriteLine();
            Console.WriteLine("1- Criar ou Remover Utilizadores");
            Console.WriteLine("2- Criar ou Remover Livro");
            Console.WriteLine("3- Atualizar Livro");
            Console.WriteLine("4- Consultar Utilizadores");
            Console.WriteLine("5- Consultar Livros");
            Console.WriteLine("6- Vender Livro");
            Console.WriteLine("7- Comprar Livro");
            Console.WriteLine("8- Consultar Livro por Género");
            Console.WriteLine("9- Consultar Livro por Autor");
            Console.WriteLine("10- Consultar Livro por Stock");
            Console.WriteLine("11- Consultar Livro por Código");
            Console.WriteLine("12- Consultar Livro por Título");
            Console.WriteLine("13- Consultar Total Livros Vendidos e Receita");
            Console.WriteLine("14- Mudar de Utilizador");
            Console.WriteLine("15- Sair");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
        }

        public void CriarRemoverUtilizador()
        {
            Console.WriteLine("Escolha uma opção (Criar ou Remover e Sair para encerrar): ");
            Opcao = Convert.ToString(Console.ReadLine());

            while (true)
            {
                if (Opcao == "Criar")
                {
                    LibrarySystem novoutilizador = new LibrarySystem();
                    Console.Write("Novo Id: ");
                    novoutilizador.IdUser = Convert.ToInt32(Console.ReadLine());
                    if (novoutilizador.IdUser == 0)
                    {
                        return;
                    }
                    Console.Write("Novo Admin: ");
                    novoutilizador.Admin = Convert.ToString(Console.ReadLine());
                    Console.Write("Nova Password: ");
                    novoutilizador.Password = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Utilizador criado com sucesso!");

                    Console.WriteLine("Admin: " + novoutilizador.Admin + " | " + "Password: " + novoutilizador.Password);

                    Utilizadores.Add(novoutilizador);
                }
                else if (Opcao == "Remover")
                {
                    Console.WriteLine("Insira o ID do utilizador que deseja remover: ");
                    int idRemover = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < Utilizadores.Count; i++)
                    {
                        if (Utilizadores[i].IdUser == idRemover)
                        {
                            Utilizadores.RemoveAt(i);
                            Console.WriteLine("Utilizador removido com sucesso!");
                            return;
                        }
                    }

                    Console.WriteLine("Utilizador não encontrado com esse ID.");
                }
                else if (Opcao == "Sair")
                {
                    break;
                }
            }
        }
        public void CriarRemoverLivro()
        {
            LibrarySystem novolivro = new LibrarySystem();
            Console.WriteLine("Escolha uma opção (Criar ou Remover e Sair para encerrar): ");
            Opcao = Convert.ToString(Console.ReadLine());

            while (true)
            {
                if (Opcao == "Criar")
                {
                    Console.WriteLine("Código: ");
                    novolivro.Cod = Convert.ToString(Console.ReadLine());
                    if (novolivro.Cod == "0")
                    {
                        break;
                    }
                    Console.Write("Id: ");
                    novolivro.Id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Título: ");
                    novolivro.Titulo = Convert.ToString(Console.ReadLine());
                    Console.Write("Autor: ");
                    novolivro.Autor = Convert.ToString(Console.ReadLine());
                    Console.Write("Género: ");
                    novolivro.Genero = Convert.ToString(Console.ReadLine());
                    Console.Write("ISBN: ");
                    novolivro.ISBN = (int)Convert.ToInt64(Console.ReadLine());
                    Console.Write("Stock: ");
                    novolivro.Stock = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Preço: ");
                    novolivro.Preco = float.Parse(Console.ReadLine());
                    Console.Write("Iva de 6% e 23%: ");
                    novolivro.Iva = float.Parse(Console.ReadLine());

                    Console.WriteLine("Livro criado com sucesso!");

                    Livros.Add(novolivro);
                }
                else if (Opcao == "Remover")
                {
                    Console.WriteLine("Insira o ID do livro que deseja remover (0 para encerrar): ");
                    int idLivroRemover = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < Livros.Count; i++)
                    {
                        if (Livros[i].Id == idLivroRemover)
                        {
                            Livros.RemoveAt(i);
                            Console.WriteLine("Livro removido com sucesso!");
                            return;
                        }
                    }
                    if (Id == 0)
                    {
                        break;
                    }

                    Console.WriteLine("Livro não encontrado com esse ID.");
                }
                else if (Opcao == "Sair")
                {
                    break;
                }
            }
        }
        public void AtualizarLivro()
        {
            while (true)
            {
                var id = 0;
                Console.Write("Qual é o id que deseja modificar? (0 para encerrar)");

                if (int.TryParse(Console.ReadLine(), out id))
                {
                    if (id == 0) break;
                    var Livro = Livros.Find(x => x.Id == id);

                    if (Livro != null)
                    {
                        Console.Write("Novo Código: ");
                        Livro.Cod = Convert.ToString(Console.ReadLine());
                        Console.Write("Novo Título: ");
                        Livro.Titulo = Convert.ToString(Console.ReadLine());
                        Console.Write("Novo Autor: ");
                        Livro.Autor = Convert.ToString(Console.ReadLine());
                        Console.Write("Novo Género: ");
                        Livro.Genero = Convert.ToString(Console.ReadLine());
                        Console.Write("Novo ISBN: ");
                        Livro.ISBN = (int)Convert.ToInt64(Console.ReadLine());
                        Console.Write("Novo Stock: ");
                        Livro.Stock = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Novo Preço: ");
                        Livro.Preco = float.Parse(Console.ReadLine());
                        Console.Write("Novo Iva: ");
                        Livro.Iva = float.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    Console.WriteLine("ID inválido!");
                }

            }

            foreach (LibrarySystem l in Livros)
            {
                Console.WriteLine("Código: " + l.Cod + " | " + "Título: " + l.Titulo + " | " + "Autor: " + l.Autor + " | " + "Género: " + l.Genero + " | " + "ISBN: " + l.ISBN + " | " + "Stock: " + l.Stock + " | " + "Preço: " + l.Preco + " | " + "Iva: " + l.Iva);
            }
        }

        public void ConsultarUtilizadores()
        { 
            foreach (LibrarySystem u in Utilizadores)
            {
                Console.WriteLine($"Id: " + u.IdUser + "| " + "Admin: " + u.Admin + " | " + "Password: " + u.Password);
            }
        }
        public void ConsultarLivros()
        {
            foreach (LibrarySystem l in Livros)
            {
                Console.WriteLine("Código: " + l.Cod + " | " + "Título: " + l.Titulo + " | " + "Autor: " + l.Autor + " | " + "Género: " + l.Genero + " | " + "ISBN: " + l.ISBN + " | " + "Stock: " + l.Stock + " | " + "Preço: " + l.Preco + " | " + "Iva: " + l.Iva);
            }
        }
        public void VenderLivro()
        {
            while (true)
            {
                Console.Write("Insira o Id do livro que deseja vender (0 para sair): ");
                int id = Convert.ToInt32(Console.ReadLine());

                if (id == 0)
                {
                    break;
                }
                var livro = Livros.Find(l => l.Id == id);

                if (livro == null)
                {
                    Console.WriteLine("Id inválido!");
                    continue;
                }

                Console.Write("Quantidade que deseja vender: ");
                livro.Quantidade = Convert.ToInt32(Console.ReadLine());

                if (livro.Quantidade >= 0 && livro.Quantidade <= livro.Stock)
                {
                    livro.Stock -= livro.Quantidade;
                    livro.Total = livro.Quantidade * livro.Preco;
                    Console.WriteLine($"Valor total: {Math.Round(livro.Total, 2)}");
                    if (livro.Total >= 50)
                    {
                        livro.NovoIva = (float)(livro.Total * 0.10);
                        Console.WriteLine($"Desconto de 10%: {Math.Round(livro.NovoIva, 2)}");
                        livro.NovoTotal = (float)(livro.Total - livro.NovoIva);
                        Console.WriteLine($"Total a pagar: {Math.Round(livro.NovoTotal, 2)}");
                    }

                    Console.WriteLine("Código: " + livro.Cod + " | " + "Título: " + livro.Titulo + " | " + "Autor: " + livro.Autor + " | " + "Género: " + livro.Genero + " | " + "ISBN: " + livro.ISBN + " | " + "Stock: " + livro.Stock + " | " + "Preço: " + livro.Preco + " | " + "Iva: " + livro.Iva);
                }
                else
                {
                    Console.WriteLine("Quantidade não disponível!");
                }
            }
        }
        public void ComprarLivro()
        {
            while (true)
            {
                Console.Write("Insira o Id do livro que deseja comprar (0 para sair): ");
                int id = Convert.ToInt32(Console.ReadLine());

                if (id == 0)
                {
                    break;
                }

                var livro = Livros.Find(l => l.Id == id);

                if (livro == null)
                {
                    Console.WriteLine("Id inválido!");
                    continue;
                }

                Console.Write("Quantidade que deseja comprar: ");
                livro.Quantidade = Convert.ToInt32(Console.ReadLine());

                livro.Stock += livro.Quantidade;

                Console.WriteLine("Código: " + livro.Cod + " | " + "Título: " + livro.Titulo + " | " + "Autor: " + livro.Autor + " | " + "Género: " + livro.Genero + " | " + "ISBN: " + livro.ISBN + " | " + "Stock: " + livro.Stock + " | " + "Preço: " + livro.Preco + " | " + "Iva: " + livro.Iva);
            }
        }

        public void ConsultarLivrosGenero()
        {
            while (true)
            {
                var genero = "";
                Console.Write("Insira o género que deseja consultar: (Sair para encerrar)");
                genero = Convert.ToString(Console.ReadLine());

                if (genero == "Sair")
                {
                    break;
                }

                var Livro = Livros.Find(x => x.Genero == genero);

                if (Livro != null)
                {
                    Console.WriteLine("Código: " + Livro.Cod + " | " + "Título: " + Livro.Titulo + " | " + "Autor: " + Livro.Autor + " | " + "Género: " + Livro.Genero + " | " + "ISBN: " + Livro.ISBN + " | " + "Stock: " + Livro.Stock + " | " + "Preço: " + Livro.Preco + " | " + "Iva: " + Livro.Iva);
                }
                else
                {
                    Console.WriteLine("Género inválido. Tente novamente!");
                }
            }
        }
        public void ConsultarLivroAutor()
        {
            while (true)
            {
                var autor = "";
                Console.Write("Insira o autor que deseja consultar: (Sair para encerrar)");
                autor = Convert.ToString(Console.ReadLine());


                if (autor == "Sair")
                {
                    break;
                }

                var Livro = Livros.Find(x => x.Autor == autor);

                if (Livro != null)
                {
                    Console.WriteLine("Código: " + Livro.Cod + " | " + "Título: " + Livro.Titulo + " | " + "Autor: " + Livro.Autor + " | " + "Género: " + Livro.Genero + " | " + "ISBN: " + Livro.ISBN + " | " + "Stock: " + Livro.Stock + " | " + "Preço: " + Livro.Preco + " | " + "Iva: " + Livro.Iva);
                }
                else
                {
                    Console.WriteLine("Autor inválido. Tente novamente!");
                }
            }

        }
        public void ConsultarStock()
        {
            while (true)
            {
                var id = 0;
                Console.Write("Qual é o id do livro que deseja consultar o stock? (0 para encerrar)");
                id = Convert.ToInt32(Console.ReadLine());

                if (id == 0)
                {
                    break;
                }

                var Livro = Livros.Find(x => x.Id == id);

                if (Livro != null)
                {
                    Console.WriteLine("Título: " + Livro.Titulo + " | " + "Stock: " + Livro.Stock);
                }
                else
                {
                    Console.WriteLine("Id inválido. Tente novamente!");
                }
            }
        }
        public void ConsultarLivrosCod()
        {
            while (true)
            {
                var cod = "";
                Console.Write("Insira o código do livro que deseja consultar: (Sair para encerrar)");
                cod = Convert.ToString(Console.ReadLine());

                if (cod == "Sair")
                {
                    break;
                }

                var Livro = Livros.Find(x => x.Cod == cod);

                if (Livro != null)
                {
                    Console.WriteLine("Código: " + Livro.Cod + " | " + "Título: " + Livro.Titulo + " | " + "Autor: " + Livro.Autor + " | " + "Género: " + Livro.Genero + " | " + "ISBN: " + Livro.ISBN + " | " + "Stock: " + Livro.Stock + " | " + "Preço: " + Livro.Preco + " | " + "Iva: " + Livro.Iva);
                }
                else
                {
                    Console.WriteLine("Código inválido. Tente novamente!");
                }
            }
        }
        public void ConsultarLivrosTitulo()
        {
            while (true)
            {
                var titulo = "";
                Console.Write("Insira o título do livro que deseja consultar: (Sair para encerrar)");
                titulo = Convert.ToString(Console.ReadLine());

                if (titulo == "Sair")
                {
                    break;
                }

                var Livro = Livros.Find(x => x.Titulo == titulo);

                if (Livro != null)
                {
                    Console.WriteLine("Código: " + Livro.Cod + " | " + "Título: " + Livro.Titulo + " | " + "Autor: " + Livro.Autor + " | " + "Género: " + Livro.Genero + " | " + "ISBN: " + Livro.ISBN + " | " + "Stock: " + Livro.Stock + " | " + "Preço: " + Livro.Preco + " | " + "Iva: " + Livro.Iva);
                }
                else
                {
                    Console.WriteLine("Título inválido. Tente novamente!");
                }
            }
        }
        public void ConsultarTotalVendidoEReceita()
        {
            while (true)
            {
                int id = 0;
                Console.Write("Insira o id que deseja consultar o total vendido e a sua receita: (0 para encerrar)");
                id = Convert.ToInt32(Console.ReadLine());

                if (id == 0)
                {
                    break;
                }

                var Livro = Livros.Find(x => x.Id == id);

                if (Livro != null)
                {
                    int totalLivrosVendidos = 0;

                    totalLivrosVendidos += Livro.Quantidade;
                    float TotalReceita = (float)Math.Round(Livro.Total, 2);

                    if (Livro.Total >= 50)
                    {
                        TotalReceita = (float)Math.Round(Livro.NovoTotal, 2);
                    }

                    Console.WriteLine("Total de livros vendidos: " + totalLivrosVendidos);
                    Console.WriteLine("Total de receita: " + TotalReceita);
                }
                else
                {
                    Console.WriteLine("Id inválido. Tente novamente!");
                }
            }
        }

        public void MudarUtilizador()
        {
            MostrarOpcoes();
        }

        public void MostrarOpcoes()
        {
            Console.WriteLine("------------------------LOGIN--------------------------");
            Console.WriteLine("Admin: ");
            Admin = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Password: ");
            Password = Convert.ToString(Console.ReadLine());

            int opcao = 0;
            do
            {
                if (Admin == "Gerente" && Password == "gerente123" || Admin == "Repositor" && Password == "repositor123" || Admin == "Caixa" && Password == "caixa123")
                {
                    try
                    {
                        Opcoes();
                        Console.Write("\n\nEscolha uma opção: ");
                        opcao = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Por favor insira apenas números!");
                    }
                }
                else
                {
                    Console.WriteLine("Admin ou Password incorretos. Tente novamente.");
                    Console.WriteLine("Admin: ");
                    Admin = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Password: ");
                    Password = Convert.ToString(Console.ReadLine());
                }

                if (opcao == 1)
                {
                    if (Admin == "Gerente" && Password == "gerente123")
                    {
                        CriarRemoverUtilizador(); 
                    }
                    else if (Admin == "Repositor" && Password == "repositor123" || Admin == "Caixa" && Password == "caixa123")
                    {
                        Console.WriteLine("Acesso negado!");
                    }
                    else
                    {
                        Console.WriteLine("Utilizador incorreto. Tente novamente.");
                    }
                }
                else if (opcao == 2)
                {
                    if (Admin == "Repositor" && Password == "repositor123")
                    {
                        CriarRemoverLivro(); 
                    }
                    else if (Admin == "Gerente" && Password == "gerente123" || Admin == "Caixa" && Password == "caixa123")
                    {
                        Console.WriteLine("Acesso negado!");
                    }
                    else
                    {
                        Console.WriteLine("Utilizador incorreto. Tente novamente.");
                    }
                }
                else if (opcao == 3)
                {
                    AtualizarLivro(); 
                }
                else if (opcao == 4)
                {
                    ConsultarUtilizadores();
                }
                else if (opcao == 5)
                {
                    ConsultarLivros(); 
                }
                else if (opcao == 6)
                {
                    if (Admin == "Caixa" && Password == "caixa123" || Admin == "Gerente" && Password == "gerente123")
                    {
                        VenderLivro(); 
                    }
                    else if (Admin == "Repositor" && Password == "repositor123")
                    {
                        Console.WriteLine("Acesso negado!");
                    }
                    else
                    {
                        Console.WriteLine("Utilizador incorreto. Tente novamente.");
                    }
                }
                else if (opcao == 7)
                {
                    ComprarLivro(); 
                }
                else if (opcao == 8)
                {
                    ConsultarLivrosGenero(); 
                }
                else if (opcao == 9)
                {
                    ConsultarLivroAutor(); 
                }
                else if (opcao == 10)
                {
                    ConsultarStock(); 
                }
                else if (opcao == 11)
                {
                    ConsultarLivrosCod(); 
                }
                else if (opcao == 12)
                {
                    ConsultarLivrosTitulo(); 
                }
                else if (opcao == 13)
                {
                    ConsultarTotalVendidoEReceita(); 
                }
                else if (opcao == 14)
                {
                    MudarUtilizador(); 
                }
                else if (opcao == 15)
                {
                    break; 
                }
                else
                {
                    opcao = 0;
                }
            }
            while (opcao != 15);
            Console.Clear();
            Console.WriteLine("Tenha um bom dia!");
        }
    }
}
