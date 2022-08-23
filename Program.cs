using System.Diagnostics;

#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.

namespace Program
{

    class Load
    {

        static string FileEXEC = "";
        static Process Processo = new Process();

        static void Main()
        {
            bool FileIndexJS = File.Exists("index.js"); 
            bool FileAppJS = File.Exists("app.js");
            bool FileMainJS = File.Exists("main.js");
            bool FileMainPY = File.Exists("main.py"); 
            bool FileTestPY = File.Exists("test.py");

            if (FileIndexJS) { Load.FileEXEC = "node index.js"; };
            if (FileAppJS) { Load.FileEXEC = "node app.js"; };
            if (FileMainJS) { Load.FileEXEC = "node main.js"; };
            if (FileMainPY) { Load.FileEXEC = "python main.py"; };
            if (FileTestPY) { Load.FileEXEC = "python test.py"; };

            Console.Title = "Teox";

            if (Load.FileEXEC != "")
            {

                Load.Processo.StartInfo.UseShellExecute = false;
                Load.Processo.StartInfo.RedirectStandardInput = true;
                //Load.Processo.StartInfo.RedirectStandardOutput = true;
                //Load.Processo.StartInfo.RedirectStandardError = true;
                Load.Processo.StartInfo.FileName = "CMD.exe";
                Load.Processo.StartInfo.Arguments = "'/C " + Load.FileEXEC;
                Load.Processo.Start();
                Load.Processo.WaitForExit();
                Console.WriteLine("===============>{System crashed}<===============");
                Console.ReadKey();
            } else {
                Process.Start("CMD.exe", "'/C echo Nenhum arquivo valido && pause");
            };
        }
    };
}
