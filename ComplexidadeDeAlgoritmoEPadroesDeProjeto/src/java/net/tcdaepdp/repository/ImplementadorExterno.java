/*
 * 
 */
package net.tcdaepdp.repository;

import java.util.List;
import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.Query;
import net.tcdaepdp.entity.Grafoentity;

public class ImplementadorExterno {

    public List<Grafoentity> findGrafo(String grafo){
        EntityManagerFactory managerFactory = Persistence.createEntityManagerFactory("trabalhoComplexidadeDeAlgoritmoEPadroesDeProjetoPU");
        EntityManager em = managerFactory.createEntityManager();
        String comando = "select g from Grafoentity as g where g.grafo = :grafoEscolhido";
        Query query = em.createQuery(comando);
        query.setParameter("grafoEscolhido", grafo);
        List<Grafoentity> lista = query.getResultList();
        return lista;
    }
    
}
