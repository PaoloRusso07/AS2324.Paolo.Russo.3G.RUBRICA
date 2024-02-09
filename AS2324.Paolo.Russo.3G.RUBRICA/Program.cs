namespace AS2324.Paolo.Russo._3G.RUBRICA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int scelta;
            string[] nome = new string[100];
            string[] cognome = new string[100];
            string[] nickname = new string[100];
            string[] email = new string[100];
            int[] anno = new int[100];
            int[] simpatia = new int[100];
            int cont = 0;
            Console.WriteLine("benvenuto nella rubrica di paolo russo\n");
            do
            {
                Console.WriteLine("1) inserimento completo dei nominativi\n 2) elenco dei nominativi inseriti \n3) ricerca di un nominativo in base al nickname \n4)inserire 0 per uscire");
                scelta = Convert.ToInt32(Console.ReadLine());
                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("inserire il nome");
                        nome[cont] = Console.ReadLine();
                        Console.WriteLine("inserire il cognome");
                        cognome[cont] = Console.ReadLine();
                        Console.WriteLine("inserire il nickname");
                        nickname[cont] = Console.ReadLine();
                        Console.WriteLine("inserire l'email");
                        email[cont] = Console.ReadLine();
                        Console.WriteLine("inserire l'anno di nascita");
                        anno[cont] = Convert.ToInt32(Console.ReadLine());

                        do
                        {
                            Console.WriteLine("inserire la simpatia");
                            simpatia[cont] = Convert.ToInt32(Console.ReadLine());

                        } while (simpatia[cont] >= 1 || simpatia[cont] <= 5);
                        cont++;
                        break;
                    case 2:
                        for (int i = 0; i < cont; i++)
                        {
                            Console.WriteLine($"nome:{nome[cont]} cognome:{cognome[cont]} nickname {nickname[cont]} email:{email[cont]} anno{anno[cont]} simaptia{simpatia[cont]}   ");
                        }
                            break;
                }

            } while (scelta != 0);
        }
    }
}