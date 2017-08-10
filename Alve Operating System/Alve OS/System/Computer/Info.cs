﻿/*
* PROJECT:          Alve Operating System Development
* CONTENT:          Computer Information
* PROGRAMMERS:      Alexy DA CRUZ <dacruzalexy@gmail.com>
*/

using System.IO;
using System;
using Alve_OS.System.Translation;

namespace Alve_OS.System.Computer
{
    class Info
    {
        /// <summary>
        /// Méthode pour récupérer le nom de l'ordinateur.
        /// </summary>
        /// <returns></returns>
        public static string getComputerName()
        {
            if (File.Exists(@"0:\System\computer.nam"))
            {
                Kernel.ComputerName = File.ReadAllText(@"0:\System\computer.nam");
                return Kernel.ComputerName;
            }
            else
            {
                setComputerName("Alve-PC");
                return "Alve-PC";
            }
        }

        /// <summary>
        /// Méthode pour appliquer un nom pour l'ordinateur.
        /// </summary>
        /// <param name="name"></param>
        public static void setComputerName(string name)
        {
            if (File.Exists(@"0:\System\computer.nam"))
            {
                File.Delete(@"0:\System\computer.nam");
                File.Create(@"0:\System\computer.nam");
                File.WriteAllText(@"0:\System\computer.nam", name);
            }
            else
            {
                File.Create(@"0:\System\computer.nam");
                File.WriteAllText(@"0:\System\computer.nam", name);

            }
        }

        /// <summary>
        /// Méthode pour demander à l'utilisateur un nom pour l'ordinateur.
        /// </summary>
        public static void AskComputerName()
        {
            Console.WriteLine();
            Text.Display("askcomputername");
            Console.WriteLine();
            Text.Display("computernamename");
            var computername = Console.ReadLine();

            if((computername.Length >= 1) && (computername.Length <= 15)) //15 char max for NETBIOS name resolution (dns)
            {
                setComputerName(computername);
                Console.WriteLine();

                Text.Display("computernamesuccess");
                Console.WriteLine();
            }
            else
            {
                Text.Display("computernameincorrect");
                Console.WriteLine();
                AskComputerName();
            }

            
        }

        

    }
}
