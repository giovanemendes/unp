/*
 * Classe usada para ser a lógica básica da bíblioteca Grafo.jar
 * onde a mesma da um ponto de partida e um de chegada (vertices)
 * e dentre eles tem um valor (valoração)
 *  @ref tcdapdp = Trabalho Complexidade De Algoritmo & Padrões De Projeto
 *  @author Jackson & Giovane 
 */

package net.tcdaepdp.util;

public class GrafoBase implements Comparable<GrafoBase>{

    public int origem;
    public int destino;
    public int valoracao;

    public GrafoBase(){}
    
    public GrafoBase(int o, int d, int v){
        this.origem     = o;
        this.destino    = d;
        this.valoracao  = v;
    }
    
    @Override
    public int compareTo(GrafoBase grafo) {
        
        if(this.valoracao < grafo.valoracao){
            return -1;
        }
        else {
            return 1;
        }
    }
}
