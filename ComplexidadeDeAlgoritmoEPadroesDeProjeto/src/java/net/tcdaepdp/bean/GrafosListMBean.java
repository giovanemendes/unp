/*
 * @author Jackson & Giovane
 */
package net.tcdaepdp.bean;

import java.util.ArrayList;
import java.util.List;
import javax.annotation.PostConstruct;
import javax.faces.bean.ManagedBean;
import javax.faces.bean.RequestScoped;
import net.tcdaepdp.util.OpcoesDeGrafos;

@ManagedBean
@RequestScoped
public class GrafosListMBean {
    
    private List<String> images;
    
    public GrafosListMBean() {
    }
         
    @PostConstruct
    public void init() {
        images = new ArrayList<String>();
         /**
         * Popula a lista de imagens com os de grafos já com extensão,
         * com os dados do enum 'OpçõesDeGrafos'
         */
        for (OpcoesDeGrafos o : OpcoesDeGrafos.values()) {
            images.add(o.toString() + ".jpg");
        }
    }
 
    public List<String> getImages() {
        return images;
    }
}
