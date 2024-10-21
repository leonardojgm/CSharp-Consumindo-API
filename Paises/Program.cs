using Paises;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        //Console.WriteLine(resposta);
        var paises = JsonSerializer.Deserialize<List<Pais>>(resposta);
        
        foreach (var pais in paises)
        {
            Console.WriteLine(pais.Informacoes);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}