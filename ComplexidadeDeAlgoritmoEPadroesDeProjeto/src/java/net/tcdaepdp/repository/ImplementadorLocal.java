/*
 * 
 */
package net.tcdaepdp.repository;

import java1.uac.Grafo;
import java1.uac.GrafoCol;
import java1.uac.LimiteException;

public class ImplementadorLocal extends Implementador {

    private Grafo<Integer> grafo;

    private static ImplementadorLocal instancia = null;
    
    private ImplementadorLocal() {}
    
    public static ImplementadorLocal getInstancia(){
        if (instancia == null){
            instancia = new ImplementadorLocal();
        }
        return instancia;
    }
    
    @Override
    public Grafo<Integer> criarGrafo(String condicao) throws LimiteException {
        Grafo<Integer> grafoRetorno = null;
        switch (condicao) {
            case "GRAFO01":
                grafoRetorno = criarGrafo01();
                break;
            case "GRAFO02":
                grafoRetorno = criarGrafo02();
                break;
            case "GRAFO03":
                grafoRetorno = criarGrafo03();
                break;
        }
        return grafoRetorno;
    }

    /*  Exemplo da internet     */
    private Grafo<Integer> criarGrafo01() throws LimiteException {
        grafo = new GrafoCol<>();

        grafo.insVertice(0);
        grafo.insVertice(1);
        grafo.insVertice(2);
        grafo.insVertice(3);
        grafo.insVertice(4);

        grafo.insArco(0, 1, 55);
        grafo.insArco(0, 2, 110);
        grafo.insArco(0, 3, 79);

        grafo.insArco(1, 0, 55);
        grafo.insArco(1, 3, 70);

        grafo.insArco(2, 0, 110);
        grafo.insArco(2, 3, 89);
        grafo.insArco(2, 4, 180);

        grafo.insArco(3, 0, 79);
        grafo.insArco(3, 1, 70);
        grafo.insArco(3, 2, 89);
        grafo.insArco(3, 4, 105);

        grafo.insArco(4, 2, 180);
        grafo.insArco(4, 3, 105);

        return grafo;
    }

    /**
     * Grafo criado a partir do exemplo do slide de 'Dijkstra' Desenvolvido por
     * Prof. José Frank Viana (o slide), com alguma modificações
     *
     * @return grafo;
     */
    private Grafo<Integer> criarGrafo02() throws LimiteException {
        grafo = new GrafoCol<>();

        grafo.insVertice(0);
        grafo.insVertice(1);
        grafo.insVertice(2);
        grafo.insVertice(3);
        grafo.insVertice(4);
        grafo.insVertice(5);
        grafo.insVertice(6);

        grafo.insArco(0, 1, 7);
        grafo.insArco(0, 2, 5);
        grafo.insArco(0, 3, 3);

        grafo.insArco(1, 0, 7);
        grafo.insArco(1, 3, 5);
        grafo.insArco(1, 6, 6);

        grafo.insArco(2, 0, 5);
        grafo.insArco(2, 3, 8);
        grafo.insArco(2, 4, 6);

        grafo.insArco(3, 0, 3);
        grafo.insArco(3, 1, 5);
        grafo.insArco(3, 2, 8);
        grafo.insArco(3, 4, 10);
        grafo.insArco(3, 5, 7);

        grafo.insArco(4, 2, 6);
        grafo.insArco(4, 3, 10);
        grafo.insArco(4, 5, 7);

        grafo.insArco(5, 3, 7);
        grafo.insArco(5, 4, 7);
        grafo.insArco(5, 6, 9);

        grafo.insArco(6, 1, 6);
        grafo.insArco(6, 5, 9);

        return grafo;
    }

    /**
     * Exemplo da Arvore geradora de peso mínimo, criado a partir do slide de
     * exemplo disponibilizado por Prof. José Frank Viana
     */
    private Grafo<Integer> criarGrafo03() throws LimiteException {
        grafo = new GrafoCol<>();
        // Verticed (0) equivale a letra 'A' do exemplo
        grafo.insVertice(0);
        // Verticed (1) equivale a letra 'B' do exemplo
        grafo.insVertice(1);
        // Verticed (2) equivale a letra 'C' do exemplo
        grafo.insVertice(2);
        // Verticed (3) equivale a letra 'D' do exemplo
        grafo.insVertice(3);
        // Verticed (4) equivale a letra 'E' do exemplo
        grafo.insVertice(4);
        // Verticed (5) equivale a letra 'F' do exemplo
        grafo.insVertice(5);

        grafo.insArco(0, 1, 4); //A->B = 4
        grafo.insArco(0, 3, 3); //A->D = 3
        grafo.insArco(0, 4, 4); //A->E = 4

        grafo.insArco(1, 0, 4); //B->A = 4
        grafo.insArco(1, 2, 8); //B->C = 8
        grafo.insArco(1, 4, 9); //B->E = 9
        grafo.insArco(1, 5, 5); //B->F = 5

        grafo.insArco(2, 1, 8); //C->B = 8
        grafo.insArco(2, 3, 9); //C->D = 9
        grafo.insArco(2, 5, 2); //C->F = 2

        grafo.insArco(3, 0, 3); //D->A = 3
        grafo.insArco(3, 2, 9); //D->C = 9
        grafo.insArco(3, 5, 7); //D->F = 2

        grafo.insArco(4, 0, 4); //E->A = 4
        grafo.insArco(4, 1, 9); //E->B = 9
        grafo.insArco(4, 5, 2); //E->F = 2

        grafo.insArco(5, 1, 5); //F->B = 5
        grafo.insArco(5, 2, 2); //F->C = 2
        grafo.insArco(5, 3, 7); //F->D = 7
        grafo.insArco(5, 4, 2); //F->E = 2

        return grafo;
    }
}
