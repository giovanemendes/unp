/*
 * Classe responsável por trazer os resultados solicitado pela a aplicação,
 * concentrando todas as possíveis solicitações requisitadas pelo o usuário 
 *  @author Jackson & Giovane 
 */

package net.tcdaepdp.facade;

import java1.uac.LimiteException;
import net.tcdaepdp.control.AlgoritmoComplexo;
import net.tcdaepdp.factory.AlgoritmoFactory;

public class TrabalhoFrankGrafosFacade {
    
    
    public String exibirTodosOsResultados(int origem, String opcoesDeGrafos) throws LimiteException{
        String retorno = exibirResultadoDijkstra(origem, opcoesDeGrafos);
        retorno += exibirResultadoKruskal(opcoesDeGrafos);
        retorno += exibirResultadoPrim(origem, opcoesDeGrafos);
        return retorno;
    }
    
    
    public String exibirResultadoDijkstra(int origem,String opcoesDeGrafos) throws LimiteException {
        String retorno = "** Resultado do algoritmo de Dijkstra para o " + opcoesDeGrafos + ": **\n\n";
        AlgoritmoComplexo dijkstra =  AlgoritmoFactory.instanciarAlgoritmo("Dijkstra", origem, opcoesDeGrafos);
        dijkstra.getResultado();
        for (String valor : dijkstra.getResultado()){
            retorno += valor;
        }
        retorno += "\n";
        return retorno;
    }
    
    
    public String exibirResultadoKruskal(String opcoesDeGrafos) throws LimiteException{
        String retorno = "** Resultado do algoritmo de Kruskal para o " + opcoesDeGrafos + ": **\n\n";
        AlgoritmoComplexo arvoreKruskal =  AlgoritmoFactory.instanciarAlgoritmo("Kruskal", 0,opcoesDeGrafos);
        for (String valor : arvoreKruskal.getResultado()){
            retorno += valor;
        }
        retorno += "\n";
        return retorno;
    }
    
    public String exibirResultadoPrim(int origem, String opcoesDeGrafos) throws LimiteException{
        String retorno = "** Resultado do algoritmo de Prim para o " + opcoesDeGrafos + ": **\n\n";
        AlgoritmoComplexo arvorePrim =  AlgoritmoFactory.instanciarAlgoritmo("Prim", origem, opcoesDeGrafos);
        for (String valor : arvorePrim.getResultado()){
            retorno += valor;
        }
        return retorno + "\n";
    }
    
}
