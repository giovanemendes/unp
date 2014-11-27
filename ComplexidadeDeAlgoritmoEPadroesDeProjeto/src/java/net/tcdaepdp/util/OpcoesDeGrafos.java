/*
 * tcdapdp = Trabalho Complexidade De Algoritmo & Padrões De Projeto
 * @author Jackson & Giovane 
 */
package net.tcdaepdp.util;

public enum OpcoesDeGrafos {

    GRAFO01("GRAFO01"),
    GRAFO02("GRAFO02"),
    GRAFO03("GRAFO03");

    private String nome;

    OpcoesDeGrafos(String nome) {
        this.nome = nome;
    }

    @Override
    public String toString() {
        return nome;
    }
    
    

}
