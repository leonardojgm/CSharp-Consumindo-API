using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        List<string?> todosOsGenerosMusicais = musicas.Select(m => m.Genero).Distinct().ToList();

        Console.WriteLine("Generos musicais:");

        foreach (string? genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }
    
    public static void FiltrarArtistasPorGenerosMusicais(List<Musica> musicas, string genero)
    {
        List<string?> artistasPorGeneroMusical = musicas.Where(m => m.Genero!.Contains(genero)).Select(m => m.Artista).Distinct().ToList();

        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}:");

        foreach (string? artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }
    
    public static void FiltrarMusicasDeUmArtistas(List<Musica> musicas, string nomeDoArtista)
    {
        List<Musica> musicasDoArtista = musicas.Where(m => m.Artista!.Equals(nomeDoArtista)).ToList();

        Console.WriteLine(nomeDoArtista);

        foreach (Musica musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarMusicasPeloAno(List<Musica> musicas, int ano)
    {
        var musicasDoAno = musicas.Where(musica => musica.Ano == ano)
            .OrderBy(musicas => musicas.Nome) // ordena as músicas pelo nome
            .Select(musicas => musicas.Nome) // seleciona apenas o nome das músicas
            .Distinct() // remove as duplicidades
            .ToList(); // converte o resultado em uma lista

        Console.WriteLine($"Músicas de {ano}");
        
        foreach (var musica in musicasDoAno)
        {
            Console.WriteLine($"- {musica}");
        }
    }

    internal static void FiltrarMusicasEmCSharp(List<Musica> musicas)
    {
        var musicasEmCSharp = musicas.Where(musica => musica.Tonalidade.Equals("C#"))
            .Select(musicas => musicas.Nome) // seleciona apenas o nome das músicas
            .ToList(); // converte o resultado em uma lista

        Console.WriteLine($"Músicas com C#:");
        
        foreach (var musica in musicasEmCSharp)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}