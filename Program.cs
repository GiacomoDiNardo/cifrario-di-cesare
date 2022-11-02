// See https://aka.ms/new-console-template for more information

string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};

string[] cripted = new string[alphabet.Length];

Console.WriteLine("Inserisci la chiave di cifratura");
int j = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < alphabet.Length; i++)
{
    if (i + j - 1 < alphabet.Length)
    {
        cripted[i] = alphabet[i + j - 1];
    } else
    {
        cripted[i] = alphabet[(i + j - 1) - alphabet.Length];
    }
}

Console.WriteLine("Inserisci il testo da cifrare");
string message = Console.ReadLine();
int letter;


for (int i = 0; i < cripted.Length; i++)
{
    if (message[i] != alphabet[i])
    {
        continue;
    }
    letter = i;
    break;
}
