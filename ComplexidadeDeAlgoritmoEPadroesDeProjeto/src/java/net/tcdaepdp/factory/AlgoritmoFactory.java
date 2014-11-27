/*
 * 
 */
package net.tcdaepdp.factory;

import java1.uac.LimiteException;
import net.tcdaepdp.control.AlgoritmoComplexo;
import net.tcdaepdp.control.ArvoreKruskal;
import net.tcdaepdp.control.ArvorePrim;
import net.tcdaepdp.control.Dijkstra;

public class AlgoritmoFactory {

    public static AlgoritmoComplexo instanciarAlgoritmo(String classe, int origem, String grafo) throws LimiteException {
        AlgoritmoComplexo retorno;
        switch (classe) {
            case "Dijkstra":
                retorno = new Dijkstra(origem, grafo);
                break;
            case "Kruskal":
                retorno = new ArvoreKruskal(grafo);
                break;
            case "Prim":
                retorno = new ArvorePrim(grafo, origem);
                break;
            default:
                retorno = null;
        }
        return retorno;
    }
}
