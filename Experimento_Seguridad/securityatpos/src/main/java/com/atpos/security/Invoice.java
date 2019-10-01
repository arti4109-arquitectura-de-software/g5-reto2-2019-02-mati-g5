package com.atpos.security;

import javax.persistence.*;

@Entity
public class Invoice {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private long id;
    @Column
    private String cliente;
    @Column
    private String producto;
    @Column
    private Double valorTotal;
    @Column
    private int cantidad;
    @Column
    private Double valorUnitario;

    public Invoice(String cliente, String producto, Double valorTotal, int cantidad, Double valorUnitario) {
        this.cliente = cliente;
        this.producto = producto;
        this.valorTotal = valorTotal;
        this.cantidad = cantidad;
        this.valorUnitario = valorUnitario;
    }

    protected Invoice(){}

    public long getId() {
        return id;
    }

    public void setId(long id) {
        this.id = id;
    }

    public String getCliente() {
        return cliente;
    }

    public void setCliente(String cliente) {
        this.cliente = cliente;
    }

    public String getProducto() {
        return producto;
    }

    public void setProducto(String producto) {
        this.producto = producto;
    }

    public Double getValorTotal() {
        return valorTotal;
    }

    public void setValorTotal(Double valorTotal) {
        this.valorTotal = valorTotal;
    }

    public int getCantidad() {
        return cantidad;
    }

    public void setCantidad(int cantidad) {
        this.cantidad = cantidad;
    }

    public Double getValorUnitario() {
        return valorUnitario;
    }

    public void setValorUnitario(Double valorUnitario) {
        this.valorUnitario = valorUnitario;
    }
}
