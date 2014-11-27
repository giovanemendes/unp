/*
 * .
 */
package net.tcdaepdp.repository;

import java1.uac.Grafo;
import java1.uac.LimiteException;

public abstract class Implementador {
    public abstract Grafo<Integer> criarGrafo(String condicao) throws LimiteException;
}
