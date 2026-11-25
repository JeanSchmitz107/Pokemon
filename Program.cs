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
        bool view_player = true, Pokédex = false;


        string[] Pokémons = ["Pikachu", "Dracaufeu", "Tortank", "Florizarre", "Ectoplasma", "Ronflex"];
        
        while(view_player = true)
        {
            Console.WriteLine("Voullez vous regarder votre Pokédex ?");
            if(Pokédex = true)
            {
                Pokedex(Pokémons);
                Pokédex = false;
            }
        }
        
        
        
    }


    static void Pokedex(string[] Pokémons)
    {
        Console.Write("\n");

        for (int i = 0; i < Pokémons.Length; i++)
        {
            Console.WriteLine((i + 1) + " : " + Pokémons[i] + "\n");
        }
        Console.WriteLine("Il y a " + Pokémons.Length + " Pokémons !");
    }
}