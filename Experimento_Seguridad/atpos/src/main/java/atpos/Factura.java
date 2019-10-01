package atpos;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the factura database table.
 * 
 */
@Entity
@NamedQuery(name="Factura.findAll", query="SELECT f FROM Factura f")
public class Factura implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy=GenerationType.AUTO)
	private int idfactura;

	private String cantidad;

	private String concepto;

	private String fechacreacion;

	private String fechamodificacion;

	private String iva;

	private String nofactura;

	private String valortotal;

	//bi-directional many-to-one association to Producto
	@ManyToOne
	@JoinColumn(name="idproducto")
	private Producto producto;

	public Factura() {
	}

	public int getIdfactura() {
		return this.idfactura;
	}

	public void setIdfactura(int idfactura) {
		this.idfactura = idfactura;
	}

	public String getCantidad() {
		return this.cantidad;
	}

	public void setCantidad(String cantidad) {
		this.cantidad = cantidad;
	}

	public String getConcepto() {
		return this.concepto;
	}

	public void setConcepto(String concepto) {
		this.concepto = concepto;
	}

	public String getFechacreacion() {
		return this.fechacreacion;
	}

	public void setFechacreacion(String fechacreacion) {
		this.fechacreacion = fechacreacion;
	}

	public String getFechamodificacion() {
		return this.fechamodificacion;
	}

	public void setFechamodificacion(String fechamodificacion) {
		this.fechamodificacion = fechamodificacion;
	}

	public String getIva() {
		return this.iva;
	}

	public void setIva(String iva) {
		this.iva = iva;
	}

	public String getNofactura() {
		return this.nofactura;
	}

	public void setNofactura(String nofactura) {
		this.nofactura = nofactura;
	}

	public String getValortotal() {
		return this.valortotal;
	}

	public void setValortotal(String valortotal) {
		this.valortotal = valortotal;
	}

	public Producto getProducto() {
		return this.producto;
	}

	public void setProducto(Producto producto) {
		this.producto = producto;
	}

}