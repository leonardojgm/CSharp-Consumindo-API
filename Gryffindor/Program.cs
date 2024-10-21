using (HttpClient client = new HttpClient())
{
    string json = await client.GetStringAsync("https://hp-api.onrender.com/api/characters/house/gryffindor");
    // código restante omitido…
}