
using System.Security.Cryptography;

Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

Console.WriteLine("Rolagem de Dado.");
Console.WriteLine();

Console.Write("Quantas faces vai ter o dado? ");

int faces = Convert.ToInt32(Console.Read());
int rolar = RandomNumberGenerator.GetInt32(1, faces);
Console.WriteLine();

Console.WriteLine($"A rolagem do dado resultou em {rolar}");
Console.WriteLine("-----------------------------------------------------------------");