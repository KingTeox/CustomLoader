using System.Diagnostics;

namespace Program
{
    class Load
    {
        static void Main(string[] args)
        {
            string strCmdText;
            bool Exist = File.Exists("index.js");
            Console.Title = "Multi Loader...";
            if (Exist) {
                Console.Write("Atualizar pacotes ?\n");
                Console.Write("Digite: ");
#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
                string Valor = Console.ReadLine();
#pragma warning restore CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.

                if (Valor == "" || Valor == null || Valor == "null") { Valor = "Nada"; };

                Console.Clear();

                if (Valor.ToLower() == "sim" || Valor.ToLower() == "yes")
                {
                    strCmdText = "'/C npm update --save && node index.js";
                    Process.Start("CMD.exe", strCmdText);
                } else
                {
                    strCmdText = "'/C node index.js";
                    Process.Start("CMD.exe", strCmdText);
                };
            } else {
                strCmdText = "'/C echo Arquivo index.js nao existe && pause";
                Process.Start("CMD.exe", strCmdText);
            };
        }
    }
}
