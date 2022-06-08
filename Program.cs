using System.Diagnostics;
using DiscordRPC;

#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.

namespace Program
{

    class Load
    {

        private static RichPresence presence = new RichPresence()
        {
            Details = "Teox Loader",
            State = "Running a .js File",
            Buttons = new Button[]
            {
                new Button() { 
                    Label = "Loader", Url = "https://github.com/KingTeox/CustomLoader" 
                }
            }
        };

        static void Main()
        {
            bool Exist = File.Exists("index.js");
            Console.Title = "Multi Loader...";
            
            if (Exist)
            {

                Console.WriteLine("Loading This..");

                var client = new DiscordRpcClient("958530608756310126", pipe: -1)
                {
                    //Logger = new DiscordRPC.Logging.ConsoleLogger(DiscordRPC.Logging.LogLevel.Trace, true)
                };

                // Initialize
                client.Initialize();
                client.SetPresence(presence);

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
                    while (client != null)
                    {
                        Thread.Sleep(25);

                        client.SetPresence(presence);
                    } return;
                }; Process.Start("CMD.exe", "'/C " + starter);
                while (client != null)
                {
                    Thread.Sleep(25);

                    client.SetPresence(presence);
                }   return;
            }
            else
            {
                Process.Start("CMD.exe", "'/C echo Arquivo index.js nao existe && pause");
                return;
            };
        }
    };
}
