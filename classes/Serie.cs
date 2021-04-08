namespace DIO.Series
{
    public class Series : Entidadebase
    {
        // Atributos

        private Genero Genero { get; set; }

        private string Titulo { get; set; }

        private string Descricao { get; set; }

        private int Ano { get; set; }

        // Métodos

        public Serie(int id, Genero genero, string Titulo, string Descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = Titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public override string Tostring()
        {
            // Environment.Newline Https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore+3.1
            string retorno = " ";
            retorno += "Gênero: " + this.Genero + Environment.Newline;            retorno
            retorno += "Titulo: " + this.Titulo + Environment.Newline;
            retorno += "Descrição: " + this.Descricao + Environment.Newline;
            retorno += "Ano de Inicio" + this.Ano;
            return retorno;
        }
        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

    }
}