/*
 *  Definição do conteúdo (grafo) a ser trabalho pelo o controlador
 *  @ref tcdapdp = Trabalho Complexidade De Algoritmo & Padrões De Projeto
 *  @author Jackson & Giovane 
 */
package net.tcdaepdp.repository;

import java1.uac.Grafo;
import java1.uac.LimiteException;

public class RepositorioLogico extends Repositorio {
    
    private static RepositorioLogico instancia = null;
    
    /*  Garante o singleton (constructor privado)   */
    private RepositorioLogico(){}
    
    /*  Singleton   */
    public static RepositorioLogico getInstancia(){
        if (instancia == null){
            instancia = new RepositorioLogico();
        }
        return instancia;
    }
    
    @Override
    public Grafo<Integer> obterGrafo(String condicao) throws LimiteException {
        return implementador.criarGrafo(condicao);
    }
     
     
}
