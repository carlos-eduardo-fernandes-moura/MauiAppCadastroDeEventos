using MauiAppCadastroDeEventos.Models;

namespace MauiAppCadastroDeEventos
{
    public partial class App : Application
    {
        public List<Local> locaisDisponiveis = new List<Local>
        {
            new Local()
            {
                nome = "Boate Galand",
                descricao = "Uma boate com ótimo acabamento e iluminação, com uma vast aárea de 850m²",
                capacidadeMaxima = 200,
                endereco = "Rua Jequitibas, Vila Madalena - São Paulo",
                valorDiaria = 700
            },

            new Local()
            {
                nome = "Jardim La Flore",
                descricao = "Um jardim muito bem cuidado com flores de verão e uma vasta área ao ar livre de 400m²",
                capacidadeMaxima = 100,
                endereco = "Rua da Vitória, Centro - São Paulo",
                valorDiaria = 350
            },

            new Local()
            {
                nome = "canto do Churrasco",
                descricao = "Uma pequena área verde descoberta de 100m² com gramado, piscina e churrasqueira",
                capacidadeMaxima = 40,
                endereco = "Aveinda São Bento, Jardim Marajás - São Paulo",
                valorDiaria = 80
            }
        };

        public List<string> opcoesBebidasAlcolicas = new List<string>
        {
            "Sim",
            "Não"
        };

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
