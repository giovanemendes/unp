/*
 * Classe base para ser usada em pelo os problemas de busca em geral
 *
 *  @author Jackson & Giovane 
 */

package net.tcdaepdp.control;

import java.util.List;
import java1.uac.Grafo;
import java1.uac.LimiteException;
import net.tcdaepdp.business.DijkstraBusinessLogic;

public abstract class AlgoritmoComplexo {
    
    protected DijkstraBusinessLogic dijkstraBusinessLogic;
    protected int totalDeVertices;
    protected int custoDoArco[][];        //valoração de um ponto/vertice a outro
    protected List<String> resultado;     //Separa o resultado por linha
    
    
    /**
     *  Define a valoração de cada arco/aresta da matriz que foi passada
     *  no construtor e armazena os valores na váriavel 'custoDoArco' do
     *  objeto.
     */
    protected int[][] formularMatrizDeIncidenciaEValoracao(Grafo<Integer> grafo) throws LimiteException {
        int t = grafo.ordenGrafo();
        custoDoArco = new int[t][t];
        for (int i = 0; i < t; i++) {
            for (int j = 0; j < t; j++) {
                custoDoArco[i][j] = grafo.costoArco(i, j);
            }
        }
        return custoDoArco;
    } // Fim do metódo

    public List<String> getResultado() {
        return resultado;
    }

    public void setResultado(List<String> resultado) {
        this.resultado = resultado;
    }
    
}
