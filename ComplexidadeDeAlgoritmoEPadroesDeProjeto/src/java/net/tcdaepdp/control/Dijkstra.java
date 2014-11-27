/*
 * Classe encarregada por gerar os resultados dos grafos
 * Dando os melhores caminhos a partir do ponto de partida.
 *
 *  @author Jackson & Giovane 
 */
package net.tcdaepdp.control;

import java.util.ArrayList;
import java1.uac.Grafo;
import java1.uac.LimiteException;
import net.tcdaepdp.business.DijkstraBusinessLogic;

public class Dijkstra extends AlgoritmoComplexo {
    
    private int ultimo [];
    private int menorDistancia [];      //distancias minimas para exibir no resultado
    private boolean verticeVisitado[];  //controle dos vertices visitados
    private int origem;
    
    /*
    *   O modelo a ser passando deve ser escholhido a partir do enum 'OpcoesDijkstra'
    */
    public Dijkstra(int start, String modeloDoGrafo) throws LimiteException {
        resultado = new ArrayList<>();
        dijkstraBusinessLogic =  DijkstraBusinessLogic.getInstancia();
        Grafo<Integer> grafoLogico = dijkstraBusinessLogic.criarGrafo(modeloDoGrafo);
        totalDeVertices = grafoLogico.ordenGrafo();  //Calcula o total de vértices do grafo
        this.origem = start;                         //Armazena o porto de partida na váriavel da do objeto
        custoDoArco = formularMatrizDeIncidenciaEValoracao(grafoLogico);
        ultimo = new int[totalDeVertices];
        menorDistancia = new int[totalDeVertices];
        verticeVisitado = new boolean[totalDeVertices];
        encontrarMenorDistancia();
        exibirResultado();
    }//Fim do método construtor
    
    
    
    private void encontrarMenorDistancia(){
    /*
    *   Limpa toda a referencia, marca todos como não visitados, 
    *   marca os valores dos viznhos da origem, marca como vertice atual o
    *    vertice de origem.
    */
        for (int i = 0; i < totalDeVertices; i++) 
        {
            verticeVisitado[i] = false;
            menorDistancia[i] = custoDoArco[origem][i]; 
            ultimo[i] = origem;
        }
        
        verticeVisitado[origem] = true;
        menorDistancia[origem] = 0;
        
        for (int i = 0; i < totalDeVertices; i++) {
            int v = minimo(); 
            verticeVisitado[v] = true;
            
            // atualiza as distancias dos vértices no menorDistancia
            for (int w = 0; w < totalDeVertices; w++) {
                if (!verticeVisitado[w]) {
                    if ((menorDistancia[v] + custoDoArco[v][w]) < menorDistancia[w]) 
                    {
                        menorDistancia[w] = menorDistancia[v] + custoDoArco[v][w];
                        ultimo[w] = v;
                    }
                }//Fim do 'IF'
            }
        }//Fim do 'FOR' completo
    }// Fim do metódo
    
    private int minimo() {
        int mx = Grafo.inf;
        int v = 1;
        for (int j = 0; j < totalDeVertices; j++) {
            if (!verticeVisitado[j] && (menorDistancia[j] <= mx)) {
                mx = menorDistancia[j];
                v = j;
            }
        }
        return v;
    }// Fim do metódo
    
    /*
    *   Popula a lista de resultado com todas as possíveis rotas(melhores) e
    *   seus valores (distancia de um ponto a outra extremidade)
    */
    public void exibirResultado(){
        //Imprime o ponto de origem
        //System.out.println("Caminho [" + origem + "], distancia 0");
        getResultado().add("Caminho [" + origem + "], distância 0 \n");
        
        //Imprime demais caminhos a partir da origem
        for (int i = 0; i < totalDeVertices; i++) 
        {
            if (i != origem){
                String ePossivel = melhorCaminhoDoVertice(i);
                if (ePossivel != ""){
                    getResultado().add("Caminho [" + origem + melhorCaminhoDoVertice(i) 
                            + "], distancia " +  menorDistancia[i] + "\n" );
                }
                //System.out.print("Caminho [" + origem);
                //System.out.print("], distancia " +  menorDistancia[i] + "\n");
            }
        }
    }//Fim do método
    
    /*
    *   Encontra o caminho de um ponto até uma extremidade (se necessario)
    */
    private String melhorCaminhoDoVertice(int vertice){
        String retorno = "";
        if(vertice!=origem){
            String complemento = melhorCaminhoDoVertice(ultimo[vertice]);
            //Avalia se existe caminho possível até o vertice (Grafo.inf = infinito)
            if(menorDistancia[vertice] != Grafo.inf)
               retorno = complemento + ", " + vertice; // Se der errado é só mudar a posição do complemento
        }
        return retorno;
    }//Fim do método
}
