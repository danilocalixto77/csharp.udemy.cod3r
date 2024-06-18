using System;
using System.IO;

namespace CursoCSharp.Api {
    class Diretorios {
        public static void Executar() {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastarCSharpDestino".ParseHome();
            var dirProjeto = @"D:/Tmp/Documentos";

            if (Directory.Exists(novoDir)) { 
                Directory.Delete(novoDir, true);
            }

            if (Directory.Exists(novoDirDestino)) {
                Directory.Delete(novoDirDestino, true);
            }


            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("========PASTAS===============");
            var pasta = Directory.GetDirectories(dirProjeto);

            foreach (var pastaFile in pasta) {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n\n== Arquivos==========================");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach(var arquivoFile in arquivos) {
                Console.WriteLine(arquivoFile);
            }

            Console.WriteLine("\n\n== Raiz ==========================");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            Directory.Move(novoDir, novoDirDestino);



        }
    }
}
