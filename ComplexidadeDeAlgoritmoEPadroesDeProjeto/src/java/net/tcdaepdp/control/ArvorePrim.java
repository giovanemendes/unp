/*
 * Árvore geradora de peso mínimo, bem simlitar a lógica de "Kruskal", mudando
 * algumas particularidades. Se baseia a escolher um ponto aleatório qualquer
 * e por esse ponto seguir na próximidade a qual tenha o menor peso, fazendo 
 * assim um caminho que não pode ser fechado.
 * @author Jackson & Giovane
 */
package net.tcdaepdp.control;

import java.util.ArrayList;
import java.util.List;
import java1.uac.Grafo;
import java1.uac.GrafoCol;
import java1.uac.LimiteException;
import net.tcdaepdp.business.DijkstraBusinessLogic;
import net.tcdaepdp.util.GrafoBase;

/*  Estou trabalhando nessa lógica  */
public class ArvorePrim extends AlgoritmoComplexo {

    private List<Integer> visitados;
    private int valorTotalDoMelhorCaminho;
    private int origem;
    private int proximoVertice;
    private List<GrafoBase> subGrafoArvore;
    
    public ArvorePrim(String modeloDoGrafo, int origem) throws LimiteException {
        resultado = new ArrayList<>();
        visitados = new ArrayList<>();
        subGrafoArvore = new ArrayList<>();
        dijkstraBusinessLogic = DijkstraBusinessLogic.getInstancia();
        Grafo<Integer> grafoLogico = dijkstraBusinessLogic.criarGrafo(modeloDoGrafo);
        custoDoArco = formularMatrizDeIncidenciaEValoracao(grafoLogico);
        obterMelhorCaminho(grafoLogico);
        obterStringParaResultado();
    }

    private void obterStringParaResultado(){
        resultado.add("Ligações da árvore mínima\n");
        for (int x=0; x<subGrafoArvore.size(); x++){
            resultado.add("(" + String.valueOf(subGrafoArvore.get(x).origem) + " -> "
            + String.valueOf(subGrafoArvore.get(x).destino) + ")" + " = " 
            + String.valueOf(subGrafoArvore.get(x).valoracao) + "\n");
        }
        resultado.add("Melhor caminho: " + valorTotalDoMelhorCaminho);
    }
    
    private void obterMelhorCaminho(Grafo<Integer> grafo) throws LimiteException {
        int t = grafo.ordenGrafo();
        for (int i = 0; i < (t-1); i++) {
            acharProximoPonto(grafo);
        }
    }

    private void acharProximoPonto(Grafo<Integer> grafo) throws LimiteException {
        int menorArco;
        if (visitados.isEmpty()) {
            
            List<Integer> arvoreInicial;
            arvoreInicial = new ArrayList<>();
            arvoreInicial = grafo.sucesores(origem);
            menorArco = grafo.costoArco(origem, arvoreInicial.get(0));
            proximoVertice = arvoreInicial.get(0);
            for (int x = 1; x < arvoreInicial.size(); x++) {
                if (grafo.costoArco(origem, arvoreInicial.get(x)) < menorArco) {
                    menorArco = grafo.costoArco(origem, arvoreInicial.get(x));
                    proximoVertice = arvoreInicial.get(x);
                }
            }
            visitados.add(origem);
            visitados.add(proximoVertice);
            subGrafoArvore.add(new GrafoBase(origem, proximoVertice, menorArco));
            valorTotalDoMelhorCaminho += menorArco;
            
        } else {
            
            /*acha um arco aleiatorio qualquer que não esteja visitado*/
            List<Integer> vizinhaca = grafo.sucesores(proximoVertice);
            vizinhaca.removeAll(visitados);
            menorArco = grafo.costoArco(proximoVertice, vizinhaca.get(0));
            boolean mudouArco = false;
            
            /*acha o menor próximo caminho*/
            for(int x=0; x<visitados.size();x++){
                List<Integer> vizinhoAux = grafo.sucesores(visitados.get(x));
                vizinhoAux.removeAll(visitados);
                for(int j=0; j< vizinhoAux.size(); j++){
                    if(grafo.costoArco(visitados.get(x), vizinhoAux.get(j)) < menorArco){
                        menorArco = grafo.costoArco(visitados.get(x), vizinhoAux.get(j));
                        proximoVertice = vizinhoAux.get(j);
                        subGrafoArvore.add(new GrafoBase(visitados.get(x), vizinhoAux.get(j), menorArco));
                        mudouArco = true;
                    }
                }
            }
            
            /*Olha se o arco aleiatorio é a melhor opção ou não*/
            if(mudouArco){
                visitados.add(proximoVertice);
            } else {
                visitados.add(vizinhaca.get(0));
                subGrafoArvore.add(new GrafoBase(proximoVertice, vizinhaca.get(0), menorArco));
                proximoVertice = vizinhaca.get(0);
            }
            valorTotalDoMelhorCaminho += menorArco;
            
        }
    }
}
