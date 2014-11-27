/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package net.tcdaepdp.entity;

import java.io.Serializable;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.Table;
import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author Balrog
 */
@Entity
@Table(name = "grafoentity")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Grafoentity.findAll", query = "SELECT g FROM Grafoentity g"),
    @NamedQuery(name = "Grafoentity.findById", query = "SELECT g FROM Grafoentity g WHERE g.id = :id"),
    @NamedQuery(name = "Grafoentity.findByGrafo", query = "SELECT g FROM Grafoentity g WHERE g.grafo = :grafo"),
    @NamedQuery(name = "Grafoentity.findByOrigem", query = "SELECT g FROM Grafoentity g WHERE g.origem = :origem"),
    @NamedQuery(name = "Grafoentity.findByDestino", query = "SELECT g FROM Grafoentity g WHERE g.destino = :destino"),
    @NamedQuery(name = "Grafoentity.findByValoracao", query = "SELECT g FROM Grafoentity g WHERE g.valoracao = :valoracao")})
public class Grafoentity implements Serializable {
    private static final long serialVersionUID = 1L;
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Basic(optional = false)
    @Column(name = "id")
    private Integer id;
    @Basic(optional = false)
    @Column(name = "grafo")
    private String grafo;
    @Basic(optional = false)
    @Column(name = "origem")
    private int origem;
    @Basic(optional = false)
    @Column(name = "destino")
    private int destino;
    @Column(name = "valoracao")
    private Integer valoracao;

    public Grafoentity() {
    }

    public Grafoentity(Integer id) {
        this.id = id;
    }

    public Grafoentity(Integer id, String grafo, int origem, int destino) {
        this.id = id;
        this.grafo = grafo;
        this.origem = origem;
        this.destino = destino;
    }

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public String getGrafo() {
        return grafo;
    }

    public void setGrafo(String grafo) {
        this.grafo = grafo;
    }

    public int getOrigem() {
        return origem;
    }

    public void setOrigem(int origem) {
        this.origem = origem;
    }

    public int getDestino() {
        return destino;
    }

    public void setDestino(int destino) {
        this.destino = destino;
    }

    public Integer getValoracao() {
        return valoracao;
    }

    public void setValoracao(Integer valoracao) {
        this.valoracao = valoracao;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (id != null ? id.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Grafoentity)) {
            return false;
        }
        Grafoentity other = (Grafoentity) object;
        if ((this.id == null && other.id != null) || (this.id != null && !this.id.equals(other.id))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "net.tcdaepdp.entity.Grafoentity[ id=" + id + " ]";
    }
    
}
