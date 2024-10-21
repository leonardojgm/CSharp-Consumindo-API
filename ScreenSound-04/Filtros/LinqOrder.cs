using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        List<string?> artistasOrdenados = musicas.OrderBy(m => m.Artista).Select(m => m.Artista).Distinct().ToList();

        Console.WriteLine("Lista de artistas ordenados:");

        foreach (string? artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}