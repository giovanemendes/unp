/*
 *  Árvore geradora de peso mínimo. Seguindo a lógica de Kruskal,
 *  a qual solicita que seja feita uma lista todos os arcos (no meu caso
 *  foi evitado duplicidade em caso de ligação), e ir anulando os vértices
 *  visitados, até obter o valor minimo possível para percorrer todas as vértices
 *  sem fazer circulo.
 *  @author Jackson & Giovane   
 */
package net.tcdaepdp.control;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java1.uac.Grafo;
import java1.uac.LimiteException;
import net.tcdaepdp.business.DijkstraBusinessLogic;
import net.tcdaepdp.util.GrafoBase;


public class ArvoreKruskal extends AlgoritmoComplexo {
    
    private List<GrafoBase> ordenacaoCrescente; 
    private List<Integer> visitados;
    private int valorTotalDoMelhorCaminho;
    
    public ArvoreKruskal(String modeloDoGrafo) throws LimiteException{
        resultado = new ArrayList<>();
        dijkstraBusinessLogic =  DijkstraBusinessLogic.getInstancia();
        Grafo<Integer> grafoLogico = dijkstraBusinessLogic.criarGrafo(modeloDoGrafo);
        custoDoArco = formularMatrizDeIncidenciaEValoracao(grafoLogico);
        ordenar(grafoLogico);
    }
    
    /*  Método usado apenas na função 'ordenar', essa função serve para não 
     *  ter duplicidade em cado do adjacente seja uma ligação ao invés de arco
    */
    private boolean procurarExistenciaNaOrdencao(int origem, int destino){
        for (int i=0; i < ordenacaoCrescente.size(); i++){
            if ((ordenacaoCrescente.get(i).destino == origem && ordenacaoCrescente.get(i).origem == destino) 
              || (ordenacaoCrescente.get(i).origem == origem && ordenacaoCrescente.get(i).destino == destino)){
                return true;
            }
        }
        return false;
    }//Fim do método 'procurarExistenciaNaOrdenação'
    
    private void ordenar(Grafo<Integer> grafo){
        int t = grafo.ordenGrafo();
        ordenacaoCrescente = new ArrayList<>();
        for (int i = 0; i < t; i++) {
            for (int j = 0; j < t; j++) {
                if (custoDoArco[i][j] != Grafo.inf && custoDoArco[i][j] != 0){
                    //Só acrescenta um único arco (evitando redundância)
                    if (!procurarExistenciaNaOrdencao(i, j)){
                      ordenacaoCrescente.add(new GrafoBase(i, j, custoDoArco[i][j]));  
                    }
                }//Final do 'IF' principal
            }//Final do 'FOR' secundário (j)
        }//Final do 'For' principal (i)
        
        Collections.sort(ordenacaoCrescente); //Ordena por ordem crescente a lista
        
        /*  Imprimi a lista ordenada dos arcos/ligações sem redundância   */
        resultado.add("Lista com todas as ligações evitando redudancia (nem todos os caminhos serão utilizados):\n");
        for(GrafoBase b : ordenacaoCrescente){
            //System.out.println(b.origem + " -> " + b.destino + " = " + b.valoracao);
            resultado.add(b.origem + " -> " + b.destino + " = " + b.valoracao + "\n");
        }
        
        /*
        *       Avaliar depois para ver se lógica está correta.
        */
        visitados = new ArrayList<>();
        /* fazer o menor caminho total  - Em desenvolvimento -*/
        for (int x =0; x < ordenacaoCrescente.size(); x++){
            GrafoBase temp = ordenacaoCrescente.get(x);
            if (!visitados.contains(temp.destino) || !visitados.contains(temp.origem)){
                valorTotalDoMelhorCaminho += temp.valoracao;
                /******************************************************************
                 *  Para fazer lista do melhor caminho é só acrescentar o valor   *
                 *  nas condições abaixo (depois de criado a lista de caminhos    *
                 *  é claro)                                                      *
                 ******************************************************************/
                if (visitados.size() == 0){
                    visitados.add(temp.origem);
                    visitados.add(temp.destino);
                } else {
                    if (!visitados.contains(temp.destino))
                        visitados.add(temp.destino);
                    else
                        visitados.add(temp.origem);
                }
                   /*TODO: A parte de cima deu muito trabalho pra ser solucionada,
                    tenho que textar com outro grafo sem ser o 3*/ 
                
            }//Fim do 'IF' principal
        }//Fim do 'FOR'
    }//Fim do método 'ordenar'

    @Override
    public List<String> getResultado() {
        //return super.getResultado(); //To change body of generated methods, choose Tools | Templates.
        resultado.add("\n" + "Total da melhor rota é -> " + valorTotalDoMelhorCaminho + "\n");
        return resultado;
    }
    
    
    
}
