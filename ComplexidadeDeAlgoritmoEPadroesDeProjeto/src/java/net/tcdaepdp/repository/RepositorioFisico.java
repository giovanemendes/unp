/*
 * 
 */
package net.tcdaepdp.repository;

import java1.uac.Grafo;
import java1.uac.LimiteException;

public class RepositorioFisico extends Repositorio {

    private static RepositorioFisico instancia = null;
    
    private RepositorioFisico() {}

    public static RepositorioFisico getInstancia(){
        if (instancia == null){
            instancia = new RepositorioFisico();
        }
        return instancia;
    }
    
    @Override
    public Grafo<Integer> obterGrafo(String condicao) throws LimiteException {
        return implementador.criarGrafo(condicao);
    }

    
}
