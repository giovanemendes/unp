/*
 * @author Jackson Roberio
 */
package net.tcdaepdp.bean;

import java.util.ArrayList;
import java.util.List;
import java1.uac.LimiteException;
import javax.annotation.PostConstruct;
import javax.faces.bean.ManagedBean;
import javax.faces.bean.SessionScoped;
import net.tcdaepdp.facade.TrabalhoFrankGrafosFacade;
import net.tcdaepdp.util.OpcoesDeAlgoritmos;
import net.tcdaepdp.util.OpcoesDeGrafos;

@ManagedBean
@SessionScoped
public class CalculosMBean {

    private TrabalhoFrankGrafosFacade trabalhoFrankGrafosFacade;

    private List<String> grafos;
    private List<String> algoritmos;

    private String grafo;
    private String algoritmo;
    private String resposta; //texto que é apresentado ao ser solicitado um algoritmo
    private String imagem;  //Usada apenas para mostrar a imgem no xhtml, não precisa ser usado no MBean

    private int origem;
    private int linhasExibidas; //Linhas a serem exibidas de acordo com a seleção do algoritmo

    private boolean mostrarResultado;

    /**
     * Constructor principal
     */
    public CalculosMBean() {
        trabalhoFrankGrafosFacade = new TrabalhoFrankGrafosFacade();
    }

    /**
     * Função invocada no momento que carregar a tela 'algoritmos.xhtml'
     */
    @PostConstruct
    public void init() {
        grafos = new ArrayList<>();
        algoritmos = new ArrayList<>();

        /**
         * Popula o <select> de grafos com os dados do enum 'OpçõesDeGrafos'
         */
        for (OpcoesDeGrafos o : OpcoesDeGrafos.values()) {
            grafos.add(o.toString());
        }

        /**
         * Popula o <select> de algoritmo com os dados do enum
         * 'OpçõesDeAlgoritmos'
         */
        algoritmos.add("Todos");    //Necessário colocar todos pois nao existe no enum
        for (OpcoesDeAlgoritmos o : OpcoesDeAlgoritmos.values()) {
            algoritmos.add(o.toString());
        }
    }//Fim do metódo 'init()'

    /**
     * Metodo que solicita a resposta de acordo com os dados inseridos nos
     * campos de entrada. (tipo do grafo e tipo de algoritmo)
     */
    public void obterResultado() throws LimiteException {
        switch (algoritmo) {
            case "Dijkstra":
                resposta = trabalhoFrankGrafosFacade.exibirResultadoDijkstra(origem, grafo);
                linhasExibidas = 15;
                break;
            case "Kruskal":
                resposta = trabalhoFrankGrafosFacade.exibirResultadoKruskal(grafo);
                linhasExibidas = 15;
                break;
            case "Prim":
                resposta = trabalhoFrankGrafosFacade.exibirResultadoPrim(origem, grafo);
                linhasExibidas = 15;
                break;
            case "Todos":
                resposta = trabalhoFrankGrafosFacade.exibirTodosOsResultados(origem, grafo);
                linhasExibidas = 40;
                break;
        }
        mostrarResultado = true;
    }

    /*  Getters e Setters   */
    public String getAlgoritmo() {
        return algoritmo;
    }

    public void setAlgoritmo(String algoritmo) {
        this.algoritmo = algoritmo;
    }

    public List<String> getGrafos() {
        return grafos;
    }

    public void setGrafos(List<String> grafos) {
        this.grafos = grafos;
    }

    public String getGrafo() {
        return grafo;
    }

    public void setGrafo(String grafo) {
        this.grafo = grafo;
    }

    public List<String> getAlgoritmos() {
        return algoritmos;
    }

    public void setAlgoritmos(List<String> algoritmos) {
        this.algoritmos = algoritmos;
    }

    public int getOrigem() {
        return origem;
    }

    public void setOrigem(int origem) {
        this.origem = origem;
    }

    public boolean isMostrarResultado() {
        return mostrarResultado;
    }

    public void setMostrarResultado(boolean mostrarResultado) {
        this.mostrarResultado = mostrarResultado;
    }

    public String getResposta() {
        return resposta;
    }

    /*Alterado o comportamento natural do get*/
    public String getImagem() {
        return grafo + ".jpg";
    }

    public int getLinhasExibidas() {
        return linhasExibidas;
    }

}
