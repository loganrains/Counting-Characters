using System.Diagnostics.Contracts;
string readText = File.ReadAllText("./String.txt").ToUpper();

Dictionary<char, int> counterDictionary = [];
foreach (char letter in readText)
{
    if (Char.IsLetter(letter))
    {
        if (counterDictionary.ContainsKey(letter))
    {
        counterDictionary[letter]++;
    }
    else
    {
        counterDictionary.Add(letter, 1);
    };
    };
};

foreach (KeyValuePair<char, int> obj in counterDictionary)
{
    Console.WriteLine(obj.Key + ", " + obj.Value);
};
