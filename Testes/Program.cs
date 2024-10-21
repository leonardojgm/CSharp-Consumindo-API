try
{
    Console.Write("Digite o numerador: ");
    
    int numerador = int.Parse(Console.ReadLine());

    Console.Write("\nDigite o denominador: ");

    int denominador = int.Parse(Console.ReadLine());

    int resultado = numerador / denominador;

    Console.WriteLine($"\nResultado: {resultado}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"\nErro: na matemática não é permitida a divisão por 0.");
}

try
{
    List<int> numeros = new List<int> { 1, 2, 3 };
    
    Console.WriteLine($"\nElemento no índice 5: {numeros[5]}");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"\nErro: {ex.Message}");
}

try
{
    MinhaClasse objetoNulo = null;
    objetoNulo.Meumetodo();
}
catch (NullReferenceException ex)
{
    Console.WriteLine($"\nErro: {ex.Message}");
}

List<int> numeros1 = new List<int> { 1, 2, 3, 2, 4, 5, 3, 6, 7, 8, 9, 1 };

var numerosUnicos = numeros1.Distinct();

Console.WriteLine("\nNúmeros únicos na lista:");

foreach (var numero in numerosUnicos)
{
    Console.Write(numero + " ");
}

List<int> lista1 = new List<int> { 1, 2, 3, 4, 5 };
List<int> lista2 = new List<int> { 3, 4, 5, 6, 7 };

var numerosComuns = lista1.Intersect(lista2);

Console.WriteLine("\n\nNúmeros presentes em ambas as listas:");

foreach (var numero in numerosComuns)
{
    Console.Write(numero + " ");
}

List<string> palavras = new List<string> { "cachorro", "gato", "elefante", "leão", "cobra" };

var palavrasFiltradas = palavras.Where(p => p.Length > 3).OrderBy(p => p.Length);

Console.WriteLine("\n\nPalavras com mais de 3 caracteres, ordenadas por comprimento:");

foreach (var palavra in palavrasFiltradas)
{
    Console.Write(palavra + " ");
}

List<int> numeros2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var numerosPares = numeros2.Where(x => x % 2 == 0);

Console.WriteLine("\n\nNúmeros Pares:");

foreach (var numero in numerosPares)
{
    Console.Write(numero + " ");
}