namespace Pokemon;
/*
    CONSIGNES
    1. Déclarer un tableau contenant les six Pokémon suivants :
       - Pikachu
       - Dracaufeu
       - Tortank
       - Florizarre
       - Ectoplasma
       - Ronflex
    2. Utiliser une boucle for pour parcourir le tableau.
    3. Afficher chaque Pokémon avec sa position dans l'équipe.
    4. Afficher le nombre total de Pokémon.
*/
class Program
{
    static void Main(string[] args)
    {
        Pokedex();
    }


    static void Pokedex()
    {
        string[] Pokémon = ["Pikachu", "Dracaufeu", "Tortank", "Florizarre", "Ectoplasma", "Ronflex"];


        Console.WriteLine("\n");

        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine((i + 1) + " : " + Pokémon[i]);
            Console.WriteLine("\n");
        }
        Console.WriteLine("Il y a " + Pokémon.Length + " Pokémon !");
    }
}