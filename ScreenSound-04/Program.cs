using System.Text.Json;
using ScreenSound_04.Filtros;
using ScreenSound_04.Modelos;

using (HttpClient client = new())
{
    try 
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        List<Musica>? musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
        
        // Console.WriteLine(musicas?.Count);
        
        // musicas?[0].ExibirDetalhesDaMusica(); 
        // musicas?[1].ExibirDetalhesDaMusica();        
        // musicas?[1998].ExibirDetalhesDaMusica();

        if (musicas != null)
        {
        //     LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //     LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //     LinqFilter.FiltrarArtistasPorGenerosMusicais(musicas, "pop");
        //     LinqFilter.FiltrarMusicasDeUmArtistas(musicas, "U2");
        //     LinqFilter.FiltrarMusicasPeloAno(musicas, 2000);
            LinqFilter.FiltrarMusicasEmCSharp(musicas);    
        }

        // MusicasPreferidas musicasPreferidasDoDaniel = new("Daniel");

        // musicasPreferidasDoDaniel.AdicionarMusicaFavorita(musicas![1]);
        // musicasPreferidasDoDaniel.AdicionarMusicaFavorita(musicas![377]);
        // musicasPreferidasDoDaniel.AdicionarMusicaFavorita(musicas![4]);
        // musicasPreferidasDoDaniel.AdicionarMusicaFavorita(musicas![6]);
        // musicasPreferidasDoDaniel.AdicionarMusicaFavorita(musicas![1467]);
        // musicasPreferidasDoDaniel.ExibirMusicasFavoritas();

        
        // MusicasPreferidas musicasPreferidasEmilly = new("Emy");

        // musicasPreferidasEmilly.AdicionarMusicaFavorita(musicas![500]);
        // musicasPreferidasEmilly.AdicionarMusicaFavorita(musicas![637]);
        // musicasPreferidasEmilly.AdicionarMusicaFavorita(musicas![428]);
        // musicasPreferidasEmilly.AdicionarMusicaFavorita(musicas![13]);
        // musicasPreferidasEmilly.AdicionarMusicaFavorita(musicas![71]);
        // musicasPreferidasEmilly.ExibirMusicasFavoritas();
        // musicasPreferidasEmilly.GerarArquivoJson();
        // musicasPreferidasEmilly.GerarDocumentoTXTComAsMusicasFavoritas();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}