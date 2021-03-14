using System;

namespace NotaFiscal
{
    public class NotaFiscalClass
    {
        public event EventHandler OnEmitir;

        public void Emitir()
        {
            if (OnEmitir != null)
            {
                OnEmitir(this, new EventArgs());
            }
        }

    }
}
