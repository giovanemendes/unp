/*
 * 
 */
package net.tcdaepdp.repository;

import java1.uac.Grafo;
import java1.uac.LimiteException;

public abstract class Repositorio {

    protected Implementador implementador;

    public abstract Grafo<Integer> obterGrafo(String condicao) throws LimiteException;

    public Implementador getImplementador() {
        return implementador;
    }

    public void setImplementador(Implementador implementador) {
        this.implementador = implementador;
    }

}
