using System;

namespace jeu_de_maths
{
    internal class Program
    {
        static bool PoserQuestion(int min, int max)
        {
            Random rand = new Random();
            int responseIntUser = 0;
            while (true) {

                int NB_QUESTION ;
                int a = rand.Next(min, max + 1);
                int b = rand.Next(min, max + 1); 
                //int c = a + b;
              //  bool verif = true;

                Console.WriteLine($" {a} + {b} = ");
                string reponse = Console.ReadLine();

                try
                {
                    responseIntUser = int.Parse(reponse);
                    if(responseIntUser == a + b ) 
                    {
                        return true;
                       // Console.WriteLine("Bonne reponse");
                    }
                      return false;
                }
                catch 
                {
                    Console.WriteLine("ERREUR : Vous devez rentrer un nombre ");
                
                }   
            
            }
        }

        static void Main(string[] args)
        {
            //5 + 2= 7
            //Bonne reponse / mauvaise réponse 
            //a + b 
            //min et max 

            // 1 - Définir MIN ET MAX 
            // 2 - Nombres aléatoires pour a et b 
            // 3 - Calculer a + b == responseInt
            // 4 - return true/false 
            // 5 - true -> bonne reponse / mauvaise reponse

             
            const int NOMBRE_MIN = 1; 
            const int NOMBRE_MAX = 10;
            const int NB_QUESTION = 3;
           
            for(int i = 0; i< NB_QUESTION; i++)
            {
                Console.WriteLine("Question n° "+(i+1));

                bool bonneReponse = PoserQuestion(NOMBRE_MIN, NOMBRE_MAX);

                if (bonneReponse)
                {
                    Console.WriteLine("Bonne réponse");
                }
                else
                {
                    Console.WriteLine("Mauvaise réponse");
                }
            }
                        
        }
    }
}
