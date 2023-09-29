Episodio Ep1 = new(1, "Programando em c#", 45);
Ep1.AdicionarConvidados("Ryan");
Ep1.AdicionarConvidados("Michelli");


Episodio Ep2 = new(3, "Programando em c#2", 70);
Ep2.AdicionarConvidados("Ryan");
Ep2.AdicionarConvidados("Michelli");


Episodio Ep3 = new(2, "Programando em c#3", 91);
Ep3.AdicionarConvidados("Ryan");
Ep3.AdicionarConvidados("Michelli");


Podcast podcast = new("Ryan", "Programando em C#");
podcast.AdicionarEpisodio(Ep1);
podcast.AdicionarEpisodio(Ep2);
podcast.AdicionarEpisodio(Ep3);
podcast.ExibirDetalhes();
