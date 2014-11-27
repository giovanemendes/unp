/*
 * @author Jackson & Giovane 
 */
package net.tcdaepdp.util;

public enum OpcoesDeAlgoritmos {
    
    DIJKSTRA("Dijkstra"),
    KRUSKAL("Kruskal"),
    PRIM("Prim");
    
    private String nome;

    OpcoesDeAlgoritmos(String nome) {
        this.nome = nome;
    }

    @Override
    public String toString() {
        return nome;
    }
    
    
}
