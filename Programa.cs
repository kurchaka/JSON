using System.Text.Json;
using JsonProject.Modeliai;

// Nuskaitome users.json
string userFile = "vartotojai.json";

if (File.Exists(userFile))
{
    string json = File.ReadAllText(userFile);
    var vartotojai = JsonSerializer.Deserialize<List<User>>(json);

    Console.WriteLine("Vartotojai");

    foreach (var user in vartotojai)
    {
        Console.WriteLine($"ID: {vartotojai.Id}, Vardas: {vartotojai.Name}, Email: {vartotojai.Email}");
    }

    // Pridedame nauja vartotoja
    vartotojai.Add(new User
    {
        Id = 3,
        Name = "Domas",
        Email = "domas@example.com"
    });

    string updatedJson = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
    File.WriteAllText(userFile, updatedJson);
}

// Nuskaitome VartotojuTipai.json
string typesFile = "VartotojuTipai.json";

if (File.Exists(typesFile))
{
    string json = File.ReadAllText(typesFile);
    var VartotojuTipai = JsonSerializer.Deserialize<List<UserType>>(json);

    Console.WriteLine("\nVartotojų tipai");

    foreach (var user in VartotojuTipai)
    {
        Console.WriteLine($"ID: {vartotojai.Id}, Vardas: {vartotojai.Name}, Role: {vartotojai.Role}");
    }
}