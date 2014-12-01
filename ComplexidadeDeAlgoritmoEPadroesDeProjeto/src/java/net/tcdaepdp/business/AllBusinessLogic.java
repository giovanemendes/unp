/*
 *  @author Jackson & Giovane 
 */
package net.tcdaepdp.business;

import java1.uac.Grafo;
import java1.uac.GrafoCol;
import java1.uac.LimiteException;
import net.tcdaepdp.repository.AdapterImplementadorExterno;
import net.tcdaepdp.repository.Implementador;
import net.tcdaepdp.repository.ImplementadorLocal;
import net.tcdaepdp.repository.Repositorio;
import net.tcdaepdp.repository.RepositorioLogico;
import net.tcdaepdp.util.OpcoesDeGrafos;

/*O nome da classe não é o mais indicado, mas acabou ficando esse mesmo*/
public class DijkstraBusinessLogic {
       
    //private RepositorioLogico repositoryDijkstra;
    Repositorio repositorio;
    Implementador implementador;
    private static DijkstraBusinessLogic instancia = null;
    
    /*  Garante o singleton (construtor privado) */
    private DijkstraBusinessLogic(){}

    /*  Inicialização tardia - Lazy Load - */
    public static DijkstraBusinessLogic getInstancia() {
        if (instancia == null){
            instancia = new DijkstraBusinessLogic();
        }
        return instancia;
    }
    
    
    public Grafo<Integer> criarGrafo(String modeloDoGrafo) throws LimiteException{
        Grafo<Integer> resultado = new GrafoCol<>();
        
        /*Mudar a instancia caso queira trabalhar com repositorioFisico*/
        repositorio = RepositorioLogico.getInstancia();
        
        /*Mudar o implementador caso queira trabalhar com outro tipo de implementação*/
        //implementador = ImplementadorLocal.getInstancia();
        implementador = AdapterImplementadorExterno.getInstancia();
        
        /*Importante definir um implementador para o repositorio*/
        repositorio.setImplementador(implementador);
        resultado = repositorio.obterGrafo(modeloDoGrafo);

        return resultado;
    }
    
}
