using System;
using System.Collections.Generic;
//* atividae 1
/* namespace atividade2_PBE
{

     class program
     {
        static void Main(string[] args)
        {
            string opcao = "";

            // Declarar a lista de produtos antes do loop
            List<produto> armazenDeProdutos = new List<produto>();

            while (opcao != "3")
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("       SISTEMA DE CADASTRO DE PRODUTOS       ");
                Console.WriteLine("========================================");
                Console.WriteLine("1 - Cadastrar Produto");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.Clear();
                    produto novoProduto = new produto();

                    Console.Write("Nome do produto: ");
                    novoProduto.Nome = Console.ReadLine();

                    Console.Write("Categoria: ");
                    novoProduto.Categoria = Console.ReadLine();

                    Console.Write("Preço: ");
                    novoProduto.Preco = double.Parse(Console.ReadLine());

                    Console.Write("Quantidade: ");
                    novoProduto.Quantidade = int.Parse(Console.ReadLine());

                    // Adicionar o novo produto à coleção
                    armazenDeProdutos.Add(novoProduto);

                    Console.WriteLine();
                    Console.ReadKey();
                }
                else if (opcao == "2")
                {
                    Console.Clear();
                    Console.WriteLine("========================================");
                    Console.WriteLine("          PRODUTOS NO ARMAZEN          ");
                    Console.WriteLine("========================================");

                    double valorTotalGeral = 0;

                    foreach (produto p in armazenDeProdutos)
                    {
                        p.MostrarProduto(); 
                        valorTotalGeral += p.CalcularTotalEstoque();
                    }

                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine($"Valor total de todo o estoque: R$ {valorTotalGeral:F2}");
                    Console.WriteLine("========================================");
                    Console.ReadKey();
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }
     }
}*/




//* atividee 2

/*namespace atividade2_PBE
{

    class livros
    {
        static void Main(string[] args)
        {
            string opcao = "";

            // Declarar a lista de produtos antes do loop
            List<livro> armazenDeProdutos = new List<livro>();

            while (opcao != "3")
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("       SISTEMA DE CADASTRO DE LIVROS       ");
                Console.WriteLine("========================================");
                Console.WriteLine("1 - Cadastrar Livro");
                Console.WriteLine("2 - Listar Livros");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.Clear();
                    livro novolivro = new livro();

                    Console.Write("Título: ");
                    novolivro.Título = Console.ReadLine();

                    Console.Write("Autor: ");
                    novolivro.Autor = Console.ReadLine();

                    Console.Write("Ano: ");
                    novolivro.Ano = double.Parse(Console.ReadLine());

                    Console.Write("Categoria: ");
                    novolivro.Categoria = int.Parse(Console.ReadLine());

                    Console.Write("Disponível (true/false): ");
                    novolivro.Disponivel = bool.Parse(Console.ReadLine());

                    // Adicionar o novo livro à coleção
                    armazenDeProdutos.Add(novolivro);

                    Console.WriteLine();
                    Console.ReadKey();
                }
                else if (opcao == "2")
                {
                    Console.Clear();
                    Console.WriteLine("========================================");
                    Console.WriteLine("          LIVROS NO ARMAZEN          ");
                    Console.WriteLine("========================================");

                    if (armazenDeProdutos.Count == 0)
                    {
                        Console.WriteLine("Nenhum livro cadastrado ainda.");
                    }
                    else
                    {
                        foreach (livro livro in armazenDeProdutos)
                        {
                            livro.MostrarProduto();
                        }
                    }
                }

                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}*/




//* atividade 3

/* namespace atividade2_PBE
{

    class funcionarios
    {
        // propriedades de instância usadas no Main
        public string Nome;
        public int Idade;
        public string Cargo;
        public double Salario;
        public string Setor;

        // método chamado no loop de listagem
        public void MostrarProduto()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salário mensal: R$ {Salario:F2}");
            Console.WriteLine($"Setor: {Setor}");
        }

        // método chamado no loop para somar salário anual
        public double CalcularSalarioAnual()
        {
            return Salario * 12.0;
        }

        static void Main(string[] args)
        {
            string opcao = "";

            List<funcionarios> armazenDeProdutos = new List<funcionarios>();

            while (opcao != "3")
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("  SISTEMA DE CADASTRO  DE FUNCIONÁRIO");
                Console.WriteLine("========================================");
                Console.WriteLine("1 - Cadastrar Funcionário");
                Console.WriteLine("2 - Listar Funcionários");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.Clear();
                    funcionarios novoFuncionario = new funcionarios();
        
                    Console.Write("Nome do funcionário: ");
                    novoFuncionario.Nome = Console.ReadLine();

                    Console.Write("Idade: ");
                    novoFuncionario.Idade = int.Parse(Console.ReadLine());

                    Console.Write("Cargo: ");
                    novoFuncionario.Cargo = Console.ReadLine();

                    Console.Write("Salário mensal: ");
                    novoFuncionario.Salario = double.Parse(Console.ReadLine());

                    Console.Write("Setor: ");
                    novoFuncionario.Setor = Console.ReadLine();

                    armazenDeProdutos.Add(novoFuncionario);

                    Console.WriteLine();
                    Console.ReadKey();
                }
                else if (opcao == "2")
                {
                    Console.Clear();
                    Console.WriteLine("========================================");
                    Console.WriteLine("          FUNCIONÁRIOS NO ARMAZÉM          ");
                    Console.WriteLine("========================================");

                    double valorTotalGeral = 0;

                    foreach (funcionarios f in armazenDeProdutos)
                    {
                        f.MostrarProduto();
                        valorTotalGeral += f.CalcularSalarioAnual();
                    }

                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine($"Salário Anual Total: R$ {valorTotalGeral:F2}");
                    Console.WriteLine("========================================");
                    Console.ReadKey();
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}*/


//* atividade 4

/*  namespace atividade2_PBE
{

    class veiculos
    {
        // propriedades de instância usadas no Main
        public string Marca;
        public int Modelo;
        public string Ano;
        public string Cor;
        public string Placa;

        // método chamado no loop de listagem
        public void MostrarProduto()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Cor: {Cor:F2}");
            Console.WriteLine($"Placa: {Placa}");
        }

        static void Main(string[] args)
        {
            string opcao = "";

            List<veiculos> armazenDeProdutos = new List<veiculos>();

            while (opcao != "3")
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("  SISTEMA DE CADASTRO  DE VEÍCULOS");
                Console.WriteLine("========================================");
                Console.WriteLine("1 - Cadastrar Veículo");
                Console.WriteLine("2 - Listar Veículos");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.Clear();
                    veiculos novoVeiculo = new veiculos();

                    Console.Write("Marca do carro: ");
                    novoVeiculo.Marca = Console.ReadLine();

                    Console.Write("Modelo do carro: ");
                    novoVeiculo.Modelo = int.Parse(Console.ReadLine());

                    Console.Write("Ano do carro: ");
                    novoVeiculo.Ano = Console.ReadLine();

                    Console.Write("Cor do carro: ");
                    novoVeiculo.Cor = Console.ReadLine();

                    Console.Write("Placa do carro: ");
                    novoVeiculo.Placa = Console.ReadLine();

                    armazenDeProdutos.Add(novoVeiculo);

                    Console.WriteLine();
                    Console.ReadKey();
                }
                else if (opcao == "2")
                {
                    Console.Clear();
                    Console.WriteLine("========================================");
                    Console.WriteLine("          VEÍCULOS NO ARMAZÉM          ");
                    Console.WriteLine("========================================");

                    foreach (veiculos v in armazenDeProdutos)
                    {
                        v.MostrarProduto();
                    }
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}*/


// * atividade 5

/*  namespace atividade2_PBE
{

    class filmes
    {
        public string Titulo { get; private set; }
        public string Genero { get; private set; }
        public double Ano { get; private set; }
        public int Duracao { get; private set; }
        public int Nota { get; private set; }

        static void Main(string[] args)
        {
            string opcao = "";

            List<filmes> armazenDeProdutos = new List<filmes>();

            while (opcao != "3")
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("       SISTEMA DE CADASTRO DE FILMES      ");
                Console.WriteLine("========================================");
                Console.WriteLine("1 - Cadastrar Filme");
                Console.WriteLine("2 - Listar Filmes");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.Clear();
                    filmes novoFilme = new filmes();

                    Console.Write("Título do filme: ");
                    novoFilme.Titulo = Console.ReadLine();

                    Console.Write("Gênero: ");
                    novoFilme.Genero = Console.ReadLine();

                    Console.Write("Ano: ");
                    novoFilme.Ano = double.Parse(Console.ReadLine());

                    Console.Write("Duração: ");
                    novoFilme.Duracao = int.Parse(Console.ReadLine());

                    Console.Write("Nota: ");
                    novoFilme.Nota = int.Parse(Console.ReadLine());

                    armazenDeProdutos.Add(novoFilme);

                    Console.WriteLine();
                    Console.ReadKey();
                }
                else if (opcao == "2")
                {
                    Console.Clear();
                    Console.WriteLine("========================================");
                    Console.WriteLine("          FILMES NO ARMAZEN          ");
                    Console.WriteLine("========================================");

                    double valorTotalGeral = 0;

                    foreach (filmes f in armazenDeProdutos)
                    {
                        if (f.Nota >= 8)
                        {
                            valorTotalGeral += f.CalcularTotalEstoque();
                        }
                    }

                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine($"Valor total de todo o estoque: R$ {valorTotalGeral:F2}");
                    Console.WriteLine("========================================");
                    Console.ReadKey();
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }
     }
}*/

//* atividade 6


/*  namespace atividade2_PBE
{

    class program
    {
        static void Main(string[] args)
        {
            string opcao = "";

            // Declarar a lista de produtos antes do loop
            List<produto> armazenDeProdutos = new List<produto>();

            while (opcao != "3")
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("       SISTEMA DE CADASTRO DE CLIENTES      ");
                Console.WriteLine("========================================");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Listar Clientes");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.Clear();
                    cliente novocliente = new cliente();

                    Console.Write("Nome do cliente: ");
                    novocliente.Nome = Console.ReadLine();

                    Console.Write("Idade: ");
                    novocliente.idade = Console.ReadLine();

                    Console.Write("Cidade: ");
                    novocliente.cidade = Console.ReadLine();

                    Console.Write("Email: ");
                    novocliente.Email = int.Parse(Console.ReadLine());

                    Console.Write("Telefone: ");
                    novocliente.telefone = int.Parse(Console.ReadLine());

                    // Adicionar o novo cliente à coleção
                    armazenDeProdutos.Add(novocliente);

                    Console.WriteLine();
                    Console.ReadKey();
                }
                else if (opcao == "2")
                {
                    Console.Clear();
                    Console.WriteLine("========================================");
                    Console.WriteLine("          CLIENTES NO ARMAZEN          ");
                    Console.WriteLine("========================================");

                    double valorTotalGeral = 0;

                    foreach (cliente c in armazenDeProdutos)
                    {
                        c.MostrarCliente();
                    }
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}*/

//* atividade 7

/*   namespace atividade2_PBE
{

    class program
    {
        static void Main(string[] args)
        {
            string opcao = "";

            // Declarar a lista de cursos antes do loop
            List<curso> armazenDeCursos = new List<curso>();

            while (opcao != "3")
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("       SISTEMA DE CADASTRO DE CURSOS       ");
                Console.WriteLine("========================================");
                Console.WriteLine("1 - Cadastrar Curso");
                Console.WriteLine("2 - Listar Cursos");
                Console.WriteLine("3 - Sair");
                Console.WriteLine("4 - Cursos disponíveis");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.Clear();
                    curso novoCurso = new curso();

                    Console.Write("Nome do curso: ");
                    novoCurso.Nome = Console.ReadLine();

                    Console.Write("Carga Horária: ");
                    novoCurso.CargaHoraria = Console.ReadLine();

                    Console.Write("Professor: ");
                    novoCurso.Professor = double.Parse(Console.ReadLine());

                    Console.Write("Modalidade: ");
                    novoCurso.Modalidade = int.Parse(Console.ReadLine());

                    Console.Write("Quantidade de Vagas: ");
                    novoCurso.QuantidadeVagas = int.Parse(Console.ReadLine());

                    // Adicionar o novo curso à coleção
                    armazenDeCursos.Add(novoCurso);

                    Console.WriteLine();
                    Console.ReadKey();
                }
                else if (opcao == "2")
                {
                    Console.Clear();
                    Console.WriteLine("========================================");
                    Console.WriteLine("          CURSOS NO ARMAZEN          ");
                    Console.WriteLine("========================================");

                    double valorTotalGeral = 0;

                    foreach (curso c in armazenDeCursos)
                    {
                        c.MostrarProduto();
                    }
                }
                else if (opcao == "4")
                {
                    Console.Clear();
                    Console.WriteLine("========================================");
                    Console.WriteLine("          CURSOS DISPONÍVEIS          ");
                    Console.WriteLine("========================================");
                    foreach (curso c in armazenDeCursos)
                    {
                        if (c.QuantidadeVagas > 0)
                        {
                            c.MostrarProduto();
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}*/

//* atividade 8

/*  namespace atividade2_PBE
{

    class Pedidos
    {
        static void Main(string[] args)
        {
            string opcao = "";

            // Declarar a lista de produtos antes do loop
            List<pedido> armazenDePedidos = new List<pedido>();

            while (opcao != "3")
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("       SISTEMA DE CADASTRO DE PEDIDOS       ");
                Console.WriteLine("========================================");
                Console.WriteLine("1 - Cadastrar Pedido");
                Console.WriteLine("2 - Listar Pedidos");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.Clear();
                    pedido novoPedido = new pedido();

                    Console.Write("Número do pedido: ");
                    novoPedido.Numero = Console.ReadLine();

                    Console.Write("Cliente: ");
                    novoPedido.Cliente = Console.ReadLine();

                    Console.Write("Produto: ");
                    novoPedido.Produto = Console.ReadLine();

                    Console.Write("Quantidade: ");
                    novoPedido.Quantidade = int.Parse(Console.ReadLine());

                    Console.Write("Valor Unitário: ");
                    novoPedido.ValorUnitario = double.Parse(Console.ReadLine());

                    // Adicionar o novo pedido à coleção
                    armazenDePedidos.Add(novoPedido);

                    Console.WriteLine();
                    Console.ReadKey();
                }
                else if (opcao == "2")
                {
                    Console.Clear();
                    Console.WriteLine("========================================");
                    Console.WriteLine("          PEDIDOS NO ARMAZEN          ");
                    Console.WriteLine("========================================");

                    double valorTotalGeral = 0;

                    foreach (pedido p in armazenDePedidos)
                    {
                        p.MostrarProduto();
                        valorTotalGeral += p.CalcularTotalEstoque();
                    }

                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine($"Valor total de todo o estoque: R$ {valorTotalGeral:F2}");
                    Console.WriteLine("========================================");
                    Console.ReadKey();
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}*/


//* atividade 9

/*    namespace atividade2_PBE
{

    class eqiuipamentos
    {
        static void Main(string[] args)
        {
            string opcao = "";

            // Declarar a lista de produtos antes do loop
            List<equipamento> armazenDeEquipamentos = new List<equipamento>();

            while (opcao != "3")
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("       SISTEMA DE CADASTRO DE EQUIPAMENTOS       ");
                Console.WriteLine("========================================");
                Console.WriteLine("1 - Cadastrar Equipamento");
                Console.WriteLine("2 - Listar Equipamentos");
                Console.WriteLine("3 - Pesquisar Equipamentos");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.Clear();
                    equipamento novoEquipamento = new equipamento();

                    Console.Write("Patrimonio: ");
                    novoEquipamento.Patrimonio = Console.ReadLine();

                    Console.Write("Tipo: ");
                    novoEquipamento.Tipo = Console.ReadLine();

                    Console.Write("Marca: ");
                    novoEquipamento.Marcas = Console.ReadLine();

                    Console.Write("Modelo: ");
                    novoEquipamento.Modelo = int.Parse(Console.ReadLine());

                    Console.Write("Número de Série: ");
                    novoEquipamento.NumeroSerie = int.Parse(Console.ReadLine());

                    Console.Write("Status: ");
                    novoEquipamento.Status = int.Parse(Console.ReadLine());

                    // Adicionar o novo produto à coleção
                    armazenDeEquipamentos.Add(novoEquipamento);

                    Console.WriteLine();
                    Console.ReadKey();
                }
                else if (opcao == "2")
                {
                    Console.Clear();
                    Console.WriteLine("========================================");
                    Console.WriteLine("          EQUIPAMENTOS NO ARMAZEN          ");
                    Console.WriteLine("========================================");

                    double valorTotalGeral = 0;

                    foreach (equipamento e in armazenDeEquipamentos)
                    {
                        e.MostrarProduto();
                    }

                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine($"Valor total de todo o estoque: R$ {valorTotalGeral:F2}");
                    Console.WriteLine("========================================");
                    Console.ReadKey();
                }
                else if (opcao == "3")
                {
                    Console.Clear();
                    Console.WriteLine("========================================");
                    Console.WriteLine("          PESQUISAR EQUIPAMENTOS          ");
                    Console.WriteLine("========================================");
                    Console.Write("Digite o Patrimonio do equipamento que deseja pesquisar: ");
                    string patrimonioPesquisa = Console.ReadLine();
                    bool encontrado = false;
                    foreach (equipamento e in armazenDeEquipamentos)
                    {
                        if (e.Patrimonio.Equals(patrimonioPesquisa, StringComparison.OrdinalIgnoreCase))
                        {
                            e.MostrarProduto();
                            encontrado = true;
                            break;
                        }
                    }
                    if (!encontrado)
                    {
                        Console.WriteLine("Equipamento não encontrado.");
                    }
                    Console.ReadKey();
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}*/

//* atividade 10

namespace atividade2_PBE
{

    class shoop
    {
        static void Main(string[] args)
        {
            string opcao = "";

            // Declarar a lista de produtos antes do loop
            List<petshopp> BancoDeClientes = new List<petshopp>();

            while (opcao != "3")
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("       SISTEMA DE CADASTRO DE Clientes       ");
                Console.WriteLine("========================================");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Listar Clientes");
                Console.WriteLine("3 - Pesquisar Clientes");
                Console.WriteLine("4 - Alterar Cliente");
                Console.WriteLine("5 - Excluir Cliente");
                Console.WriteLine("6 - Relatório de Clientes");
                Console.WriteLine("7 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.Clear();
                    petshopp novoProduto = new petshopp();

                    Console.Write("Nome do cliente: ");
                    novoProduto.NomeCliente = Console.ReadLine();

                    Console.Write("Telefone: ");
                    novoProduto.Telefone = Console.ReadLine();

                    Console.Write("Email: ");
                    novoProduto.Email = Console.ReadLine();

                    Console.Write("Quantidade: ");
                    novoProduto.Quantidade = int.Parse(Console.ReadLine());

                    // Adicionar o novo produto à coleção
                    armazenDeProdutos.Add(novoProduto);

                    Console.WriteLine();
                    Console.ReadKey();
                }
                else if (opcao == "2")
                {
                    Console.Clear();
                    Console.WriteLine("========================================");
                    Console.WriteLine("          CLIENTES NO BANCO         ");
                    Console.WriteLine("========================================");

                    double valorTotalGeral = 0;

                    foreach (produto p in armazenDeProdutos)
                    {
                        p.MostrarProduto();
                        valorTotalGeral += p.CalcularTotalEstoque();
                    }
                }
                else if (opcao == "3")
                {
                    Console.Clear();
                    Console.WriteLine("========================================");
                    Console.WriteLine("          PESQUISAR CLIENTES          ");
                    Console.WriteLine("========================================");
                    Console.Write("Digite o nome do cliente que deseja pesquisar: ");
                    string nomePesquisa = Console.ReadLine();
                    bool encontrado = false;
                    foreach (petshopp p in BancoDeClientes)
                    {
                        if (p.NomeCliente.Equals(nomePesquisa, StringComparison.OrdinalIgnoreCase))
                        {
                            p.MostrarProduto();
                            encontrado = true;
                            break;
                        }
                    }
                    if (!encontrado)
                    {
                        Console.WriteLine("Cliente não encontrado.");
                    }
                    Console.ReadKey();
                }

                else if (opcao == "4")
                {
                    Console.Clear();
                    Console.WriteLine("========================================");
                    Console.WriteLine("          ALTERAR CLIENTES          ");
                    Console.WriteLine("========================================");
                    Console.Write("Digite o nome do cliente que deseja alterar: ");
                    string nomeAlterar = Console.ReadLine();
                    bool encontrado = false;
                    foreach (petshopp p in BancoDeClientes)
                    {
                        if (p.NomeCliente.Equals(nomeAlterar, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.Write("Novo telefone: ");
                            p.Telefone = Console.ReadLine();
                            Console.Write("Novo email: ");
                            p.Email = Console.ReadLine();
                            encontrado = true;
                            break;
                        }
                    }
                    if (!encontrado)
                    {
                        Console.WriteLine("Cliente não encontrado.");
                    }
                    else
                    {
                        Console.WriteLine("Cliente alterado com sucesso.");
                    }
                    Console.ReadKey();
                }

                else if (opcao == "5")
                {
                    Console.Clear();
                    Console.WriteLine("========================================");
                    Console.WriteLine("          EXCLUIR CLIENTES          ");
                    Console.WriteLine("========================================");
                    Console.Write("Digite o nome do cliente que deseja excluir: ");
                    string nomeExcluir = Console.ReadLine();
                    bool encontrado = false;
                    for (int i = 0; i < BancoDeClientes.Count; i++)
                    {
                        if (BancoDeClientes[i].NomeCliente.Equals(nomeExcluir, StringComparison.OrdinalIgnoreCase))
                        {
                            BancoDeClientes.RemoveAt(i);
                            encontrado = true;
                            break;
                        }
                    }
                    if (!encontrado)
                    {
                        Console.WriteLine("Cliente não encontrado.");
                    }
                    else
                    {
                        Console.WriteLine("Cliente excluído com sucesso.");
                    }
                    Console.ReadKey();
                }
                else if (opcao == "6")
                {
                    Console.Clear();
                    Console.WriteLine("========================================");
                    Console.WriteLine("          RELATÓRIO DE CLIENTES          ");
                    Console.WriteLine("========================================");
                    foreach (petshopp p in BancoDeClientes)
                    {
                        p.MostrarProduto();
                    }
                }

                else if (opcao == "7")
                {
                    Console.WriteLine("Saindo do sistema...");
                    break;
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}