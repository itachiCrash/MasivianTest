using MasivianTest.Models;

namespace MasivianTest.Negocio
{
    public class Arbol : IArbol
    {
        public ArbolBinario CrearArbol(int[] valores)
        {
            return new ArbolBinario(valores);
        }

        public int EncontrarAncestroComunMasBajo(ArbolBinario arbol, int nodo1, int nodo2)
        {
            if (arbol == null)
                return -1;

            if (arbol.ValorNodo == nodo1 || arbol.ValorNodo == nodo2)
                return arbol.ValorNodo;

            int valorPorIzquierda = EncontrarAncestroComunMasBajo(arbol.ArbolIzquierdo, nodo1, nodo2);
            int valorPorDerecha = EncontrarAncestroComunMasBajo(arbol.ArbolDerecho, nodo1, nodo2);

            if (valorPorIzquierda != -1 && valorPorDerecha != -1)
                return arbol.ValorNodo;

            if (valorPorIzquierda != -1)
                return valorPorIzquierda;
            else
                return valorPorDerecha;
        }
    }
}