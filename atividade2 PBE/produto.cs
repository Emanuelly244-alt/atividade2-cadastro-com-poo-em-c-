using System;
//* atividade 1


/*   namespace atividade2_PBE
{
    internal class produto
    {
      
            public string Nome { get; set; }
            public string Categoria { get; set; }
            public double Preco { get; set; }
            public int Quantidade { get; set; }

            public void MostrarProduto()
            {
            Console.WriteLine($"Produto: " + Nome);
            Console.WriteLine($"Categoria: " + Categoria);
            Console.WriteLine($"Preço: " + Preco); 
            Console.WriteLine($"Estoque: " + Quantidade);
            }

            public double CalcularTotalEstoque()
            {
                return Preco * Quantidade;
            }
    }

}*/



//* atividade 2

/*  namespace atividade2_PBE
{
    internal class livro
    {

        public string Título { get; set; }
        public string Autor { get; set; }
        public double Ano { get; set; }
        public int Categoria { get; set; }
        public bool Disponivel { get; set; }

        public void MostrarProduto()
        {

            string status = Disponivel ? "DISPONÍVEL" : "EMPRESTADO";

            Console.WriteLine($"Título: " + Título);
            Console.WriteLine($"Autor: " + Autor);
            Console.WriteLine($"Ano: " + Ano);
            Console.WriteLine($"Categoria: " + Categoria);
            Console.WriteLine($"Disponível: " + Disponivel);
        }
    
    }

}*/



//* atividade3

/*   namespace atividade2_PBE
{
    internal class produto
    {

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cargo { get; set; }
        public int Salario { get; set; }
        public double Setor { get; set; }
        

        public void MostrarProduto()
        {
            Console.WriteLine($"Produto: " + Nome);
            Console.WriteLine($"Idade: " + Idade);
            Console.WriteLine($"Cargo: " + Cargo);
            Console.WriteLine($"Salário: " + Salario);
            Console.WriteLine($"Setor: " + Setor);
        }

        public double CalcularSalarioAnual()
        {
            return Salario * 12;
        }
    }

}*/



//* atividade 4

/*namespace atividade2_PBE
{
    internal class carro
    {

        public string Marca { get; set; }
        public int Modelo { get; set; }
        public string Ano { get; set; }
        public double Cor { get; set; }
        public string Placa { get; set; }


        public void MostrarProduto()
        {
            Console.WriteLine($"Marca: " + Marca);
            Console.WriteLine($"Modelo: " + Modelo);
            Console.WriteLine($"Ano: " + Ano);
            Console.WriteLine($"Cor: " + Cor);
            Console.WriteLine($"Placa: " + Placa);
        }
    }

}*/


//* atividade 5

/*  namespace atividade2_PBE
{
    public class Filme
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int Ano { get; set; }
        public int Duracao { get; set; } // Em minutos
        public double Nota { get; set; }

        public void ExibirInformacoes()
        {
            string destaque = Nota >= 8 ? "[RECOMENDADO]" : "";
            Console.WriteLine($"Filme: {Titulo} | Gênero: {Genero} | Ano: {Ano} | Duração: {Duracao}min | Nota: {Nota:F1} {destaque}");
        }
    }
}*/


//* atividade 6

/*namespace atividade2_PBE
{
    internal class cliente
    {

        public string Nome { get; set; }
        public string idade { get; set; }
        public double cidade { get; set; }
        public int Email { get; set; }
        public int telefone { get; set; }

        public void MostrarProduto()
        {
            Console.WriteLine($"Produto: " + Nome);
            Console.WriteLine($"Idade: " + idade);
            Console.WriteLine($"Cidade: " + cidade);
            Console.WriteLine($"Email: " + Email);
            Console.WriteLine($"Telefone: " + telefone);
        }
    }

}*/

//* atividade 7

/*  namespace atividade2_PBE
{
    internal class curso
    {

        public string Nome { get; set; }
        public string CargaHoraria { get; set; }
        public double Professor { get; set; }
        public int Modalidade { get; set; }
        public int QuantidadeVagas { get; set; }

        public void MostrarProduto()
        {
            Console.WriteLine($"Curso: " + Nome);
            Console.WriteLine($"Carga Horária: " + CargaHoraria);
            Console.WriteLine($"Professor: " + Professor);
            Console.WriteLine($"Modalidade: " + Modalidade);
            Console.WriteLine($"Quantidade de Vagas: " + QuantidadeVagas);
        }
    }

} */


//* atividade 8


/*  namespace atividade2_PBE
{
    internal class pedido
    {
      
            public string Numero { get; set; }
            public string Cliente { get; set; }
            public double Produto { get; set; }
            public int Quantidade { get; set; }
            public double ValorUnitario { get; set; }

        public void MostrarProduto()
            {
            Console.WriteLine($"Número: " + Numero);
            Console.WriteLine($"Cliente: " + Cliente);
            Console.WriteLine($"Produto: " + Produto);
            Console.WriteLine($"Quantidade: " + Quantidade);
            Console.WriteLine($"Valor Unitário: " + ValorUnitario);
        }

            public double CalcularTotalEstoque()
            {
                return Quantidade * ValorUnitario;
            }
    }

}*/


//* atividade 9

/*  namespace atividade2_PBE
{
    internal class equipamento
    {

        public string Patrimonio { get; set; }
        public string Tipo { get; set; }
        public double Marca { get; set; }
        public int Modelo { get; set; }
        public int NumeroSerie { get; set; }
        public int Status { get; set; }

        public void MostrarProduto()
        {
            Console.WriteLine($"Produto: " + Patrimonio);
            Console.WriteLine($"Tipo: " + Tipo);
            Console.WriteLine($"Marca: " + Marca);
            Console.WriteLine($"Modelo: " + Modelo);
            Console.WriteLine($"Número de Série: " + NumeroSerie);
            Console.WriteLine($"Status: " + Status);
        }
    }

}*/


//* atividade 10


namespace atividade2_PBE
{
    internal class petshopp
    {

        public string NomeCliente { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Raca { get; set; }
        public double Idade { get; set; }

        public void MostrarProduto()
        {
            Console.WriteLine($"Cliente: " + NomeCliente);
            Console.WriteLine($"Telefone: " + Telefone);
            Console.WriteLine($"Email: " + Email);
            Console.WriteLine($"Raça: " + Raca);
            Console.WriteLine($"Idade: " + Idade);
        }
    }

}