using System;

namespace NotaFiscal
{
    public class NotaFiscalClass
    {
        public event EventHandler OnEmitir;

        public void Emitir()
        {
            // teste commit
            // teste get 4.1
            if (OnEmitir != null)
            {
                OnEmitir(this, new EventArgs());
            }
        }

    }
}
