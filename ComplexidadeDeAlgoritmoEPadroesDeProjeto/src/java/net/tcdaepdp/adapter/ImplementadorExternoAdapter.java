/*
 * 
 */
package net.tcdaepdp.repository;

import java.util.ArrayList;
import java.util.List;
import java1.uac.Grafo;
import java1.uac.GrafoCol;
import java1.uac.LimiteException;
import net.tcdaepdp.entity.Grafoentity;


public class AdapterImplementadorExterno extends Implementador {

    private static AdapterImplementadorExterno instancia = null;
    private static ImplementadorExterno implementadorExterno;
    
    private AdapterImplementadorExterno(){}
    
    public static AdapterImplementadorExterno getInstancia(){
        if (instancia == null){
            instancia = new AdapterImplementadorExterno();
            implementadorExterno = new ImplementadorExterno();
        }
        return instancia;
    }
    
    @Override
    public Grafo<Integer> criarGrafo(String condicao) throws LimiteException {
        List<Grafoentity> entidadeGrafo = implementadorExterno.findGrafo(condicao);
        Grafo<Integer> grafo = new GrafoCol<>();
        List<Integer> vertices = new ArrayList<>();
        
        /*marca todos os vertices contidos no grafo*/
        for (int x=0; x < entidadeGrafo.size(); x++){
            if (!vertices.contains(entidadeGrafo.get(x).getOrigem())){
                grafo.insVertice(entidadeGrafo.get(x).getOrigem());
                vertices.add(entidadeGrafo.get(x).getOrigem());
            }
        }
        
        
        /*define todas as ligações*/
        for (int x=0; x < entidadeGrafo.size(); x++){
            grafo.insArco(entidadeGrafo.get(x).getOrigem(), 
                            entidadeGrafo.get(x).getDestino(),
                            entidadeGrafo.get(x).getValoracao());
        }
        
        return grafo;
    }
    
}
