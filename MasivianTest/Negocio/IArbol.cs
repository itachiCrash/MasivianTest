using MasivianTest.Models;

namespace MasivianTest.Negocio
{
    public interface IArbol
    {
        ArbolBinario CrearArbol(int[] valores);
        int EncontrarAncestroComunMasBajo(ArbolBinario arbol, int nodo1, int nodo2);
    }
}
