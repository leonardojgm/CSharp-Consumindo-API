using System.Text.Json;

namespace ScreenSound_04.Modelos;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> listaDeMusicasFavoritas { get; }
    
    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        listaDeMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicaFavorita(Musica musica)
    {
        listaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");

        foreach (Musica musica in listaDeMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }

        Console.WriteLine();
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = listaDeMusicasFavoritas
        });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);

        Console.WriteLine($"O arquivo JSON foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }

    public void GerarDocumentoTXTComAsMusicasFavoritas()
{
    string nomeDoArquivo = $"musicas-favoritas-{Nome}.txt";
    using (StreamWriter arquivo = new StreamWriter(nomeDoArquivo))
    {
        arquivo.WriteLine($"Músicas favoritas do {Nome}\n");
        
        foreach (var musica in listaDeMusicasFavoritas)
        {
            arquivo.WriteLine($"- {musica.Nome}");
        }
    }
    Console.WriteLine("O arquiv TXT gerado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
}
}