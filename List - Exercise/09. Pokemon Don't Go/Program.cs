List<int> pokemons = Console.ReadLine()!
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

int pokemonSum = 0;
int caughtPokemon = 0;
while (pokemons.Count != 0)
{
    int index = int.Parse(Console.ReadLine()!);

    if (index < 0)
    {
        index= 0;
        caughtPokemon = pokemons[index];
        pokemonSum += caughtPokemon;
        pokemons[0] = pokemons[pokemons.Count - 1];
        ChangePokemons(pokemons, index);
    }

    else if (index >= pokemons.Count)
    {
        index = pokemons.Count - 1;
        caughtPokemon = pokemons[index];
        pokemonSum += caughtPokemon;
        pokemons[pokemons.Count - 1] = pokemons[0];
        ChangePokemons(pokemons, index);
    }

    else
    {
        caughtPokemon = pokemons[index];
        pokemonSum += caughtPokemon;
        pokemons.RemoveAt(index);
        ChangePokemons(pokemons, index);
    }
}

Console.WriteLine(pokemonSum);

void ChangePokemons(List<int> pokemons, int index)
{
    for (int i = 0; i < pokemons.Count; i++)
    {
        if (pokemons[i] <= caughtPokemon)
        {
            pokemons[i] += caughtPokemon;
        }
        else
        {
            pokemons[i] -= caughtPokemon;
        }
    }
}