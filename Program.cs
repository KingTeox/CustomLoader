using System.Diagnostics;

#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.

namespace Program
{
    class Load
    {
        static void Main()
        {
            bool Exist = File.Exists("index.js");
            Console.Title = "Multi Loader...";
            if (Exist) {
                Console.Write("Atualizar pacotes ?\n");
                Console.Write("Digite: ");
                string Valor = Console.ReadLine();


                if (Valor == "" || Valor == null || Valor == "null") { Valor = "Nao"; };

                Console.Clear();

                Console.Write("Iniciar com nodemon ?\n");
                Console.Write("Digite: ");

                string nodemon = Console.ReadLine();
                string starter = "node index.js && pause";

                Console.Clear();

                if (nodemon == "" || nodemon == null || nodemon == "null") { nodemon = "Nao"; };
                if (nodemon.ToLower() == "sim" || nodemon.ToLower() == "yes")
                {
                    starter = "nodemon index.js && pause";
                };

                if (Valor.ToLower() == "sim" || Valor.ToLower() == "yes")
                {
                    Process.Start("CMD.exe", "'/C npm update --save && " + starter);
                    return;
                };  Process.Start("CMD.exe", "'/C " + starter);
            } else {
                Process.Start("CMD.exe", "'/C echo Arquivo index.js nao existe && pause");
            };
        }
    }
}
