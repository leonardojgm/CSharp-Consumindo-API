using Livros;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://github.com/ArthurOcFernandes/Exerc-cios-C-/raw/curso-4-aula-2/Jsons/Livros.json");
       
        var livros = JsonSerializer.Deserialize<List<Livro>>(resposta);
        
        foreach(var livro in livros)
        {
            Console.WriteLine(livro.FichaTecnica);
        }

        List<Livro> livros2 = new List<Livro>
        {
            new Livro { Titulo = "Aprendendo LINQ", Autor = "João Silva", Ano = 2005 },
            new Livro { Titulo = "Programação em C#", Autor = "Ana Oliveira", Ano = 2010 },
            new Livro { Titulo = "Algoritmos e Estruturas de Dados", Autor = "Carlos Santos", Ano = 1998 },
            new Livro { Titulo = "Introdução à Inteligência Artificial", Autor = "Mariana Costa", Ano = 2021 },
            new Livro { Titulo = "Design Patterns", Autor = "Paulo Rocha", Ano = 2002 }
        };

        var titulosLivros = livros2
            .Where(l => l.Ano > 2000)
            .OrderBy(l => l.Titulo)
            .Select(l => l.Titulo);

        Console.WriteLine("Títulos de livros publicados após 2000, ordenados alfabeticamente:");

        foreach (var titulo in titulosLivros)
        {
            Console.WriteLine(titulo);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}