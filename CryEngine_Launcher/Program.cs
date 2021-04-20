using System;
using System.IO;
using System.Collections.Generic;

namespace CryEngine_Launcher
{
    class Program
    {
        static void Main(string[] args)
        {
            //on passe en paramètre le chemin du répertoire "Data"
            if (args.Length != 1)
            {
                Console.WriteLine("Il faut passer en paramètre le chemin du répertoire 'Data'");
                Console.ReadLine();
                return;
            }

            string path_to_scan = args[0] + @"\";
            List<string> liste_extensions = new List<string>();
            liste_extensions.Add(".cga");
            liste_extensions.Add(".cgf");
            liste_extensions.Add(".chr");
            liste_extensions.Add(".skin");

            List<string> liste_fichiers = Recherche_Fichiers(path_to_scan, liste_extensions);
            Console.WriteLine(liste_fichiers.Count + " fichiers à traiter");
#if DEBUG
            Console.ReadLine();
#endif
            liste_fichiers.Add("-tif");
            liste_fichiers.Add("-noconflict");
            liste_fichiers.Add("-objectdir");
            liste_fichiers.Add(path_to_scan);

            CgfConverterConsole.Program.Main(liste_fichiers.ToArray());

        }

        static List<string> Recherche_Fichiers(string sDir, List<string> liste_extensions)
        {
            List<string> liste_fichiers = new List<string>();
            try
            {
                Console.WriteLine(sDir);

                foreach (string f in Directory.GetFiles(sDir))
                {
                    if (!f.Contains(@"Objects\Spaceships"))
                    {
                        continue;
                    }
                    //Console.WriteLine(f);
                    FileInfo fileInfo = new FileInfo(f);
                    if (liste_extensions.Contains(fileInfo.Extension))
                    {
                        liste_fichiers.Add(f);
                    }
                }

                foreach (string d in Directory.GetDirectories(sDir))
                {
                    liste_fichiers.AddRange(Recherche_Fichiers(d,liste_extensions));
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
            return liste_fichiers;
        }
    }
}
