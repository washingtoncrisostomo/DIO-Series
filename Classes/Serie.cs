namespace DIO.Series
{
    public class Series : EntidadeBase
    {
        // Atributos

        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private nint Ano { get; set; }
    }
}