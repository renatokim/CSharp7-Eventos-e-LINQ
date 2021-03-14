using System;

namespace NotaFiscal
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 16; i++)
            {
                var randon = new Random().Next(8);
                Console.WriteLine(randon);
            }




            var nf = new NotaFiscalClass();

            nf.OnEmitir += EnviarEmail;
            nf.OnEmitir += EmitirSinal;
            nf.OnEmitir += EmitirSinal;

            nf.Emitir();

            //nf.OnEmitir();






        }

        public static void EnviarEmail(object sender, EventArgs args)
        {
            Console.WriteLine("Enviando email....");
        }

        public static void EmitirSinal(object sender, EventArgs args)
        {
            Console.WriteLine("Emitindo sinal....");
        }
    }
}
