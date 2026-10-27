using OOP5_prak_4;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

Console.OutputEncoding = System.Text.Encoding.UTF8;

User user = new()
{
    Id = 1,
    Username = "admin",
    PasswordHash = "SecretHash123"
};

var options = new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping};
string json = JsonSerializer.Serialize(user, options);

Console.WriteLine("Результат серіалізації (властивість PasswordHash ігнорується):");
Console.WriteLine(json);