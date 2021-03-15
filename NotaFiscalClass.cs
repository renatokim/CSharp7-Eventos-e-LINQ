﻿using System;

namespace NotaFiscal
{
    public class NotaFiscalClass
    {
        public event EventHandler OnEmitir;

        public void Emitir()
        {
            // teste commit
            if (OnEmitir != null)
            {
                OnEmitir(this, new EventArgs());
            }
        }

    }
}
