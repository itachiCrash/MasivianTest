using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;

namespace MasivianTest.Models
{

    public class ArbolBinario //: IEnumerable
    {
        public int ValorNodo { get; set; }
        public ArbolBinario ArbolIzquierdo { get; set; }
        public ArbolBinario ArbolDerecho { get; set; }


        public ArbolBinario(int[] valores, int indice = 0)
        {
            if (valores == null)
                return;
            ConstruirArbolBinario(this, valores, indice);
        }



        private void ConstruirArbolBinario(ArbolBinario arbolBinario, int[] valores, int indice)
        {
            arbolBinario.ValorNodo = valores[indice];
            if (indice * 2 + 1 < valores.Length)
            {
                arbolBinario.ArbolIzquierdo = new ArbolBinario(valores, indice * 2 + 1);
            }
            if (indice * 2 + 2 < valores.Length)
            {
                arbolBinario.ArbolDerecho = new ArbolBinario(valores, indice * 2 + 2);
            }
        }

    }
}