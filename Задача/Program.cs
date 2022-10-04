string[] name = { "Alex", "Lex", "Tom", "Andrey", "Yn", "Jo", "Jon", "Jony", "Tony"  };
string[] SymbolThree = new string [name.Length];

void SearchName(string[] name, string[] SymbolThree)
{
    int count = 0;
    for (int i = 0; i < name.Length; i++)
    {
        if (name[i].Length <= 3)
        {
            SymbolThree[count] = name[i];
            count++;
        }
    }
}