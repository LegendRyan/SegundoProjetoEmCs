class Podcast
{
    private List<Episodio> episodios = new();
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");
        foreach (Episodio ep in episodios.OrderBy(e => e.Ordem))  
        {
            Console.WriteLine(ep.Resumo);
        }
        Console.WriteLine($"\n\nEste podcast possui {TotalEpisodios} episódios.");
    }
}
