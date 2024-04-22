//faça um programa que leia um vetor de caracteres de 10 posições e converta as vogais de minusculo para maiusculo.

char[] vogais = new char[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Informe a {i + 1}ª vogal: ");
    vogais[i] = char.Parse(Console.ReadLine());

}
for (int i = 0; i < 10; i++)
{
    if (vogais[i] == 'a')
        Console.Write(" A ");
    if (vogais[i] == 'e')
        Console.Write(" E ");
    if (vogais[i] == 'i')
        Console.Write(" I ");
    if (vogais[i] == 'o')
        Console.Write(" O ");
    if (vogais[i] == 'u')
        Console.Write(" U ");
 }

