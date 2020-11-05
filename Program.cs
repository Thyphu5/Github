using System;

namespace Github
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Test();
        }

        static void Test()
        {
            Console.WriteLine("Test ausgabe, awesome");
            // fertig
        }


        /* 1. Repository aus Projekt erstellen
         * 2. Branch erzeugen
         * 3. Änderungen erstellen
         * 4. Änderungen Comitten
         * 5. Wenn Branch abgeschlossen (definitionssache) dann Pull Request
         * 6. Projekt verantwortlicher prüft Pull Request
         * 7. Annahme oder Rückgabe des Pull Request
         * 8. Branch wird in GitHub gemerged
         * 9. Done!
        */
    }
}
