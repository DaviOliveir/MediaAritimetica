double numero1, numero2, numero3, media;
Console.WriteLine("media aritimetica... ");

Console.Write("Digite o Primeiro Numero... ");
numero1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o Segundo Numero... ");
numero2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o Terceiro Numero... ");
numero3 = Convert.ToDouble(Console.ReadLine());

media = (numero1 + numero2 + numero3) / 3;

Console.WriteLine($"n/media : {media:N1}");

