
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Contexto
{

using System;
    using System.Collections.Generic;
    
public partial class Articulos
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Articulos()
    {

        this.Detalle_ventas = new HashSet<Detalle_ventas>();

        this.Proveedores = new HashSet<Proveedores>();

        this.Detalle_OrdenCom = new HashSet<Detalle_OrdenCom>();

    }


    public int Id { get; set; }

    public string nombre { get; set; }

    public string stock { get; set; }

    public string Precio { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Detalle_ventas> Detalle_ventas { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Proveedores> Proveedores { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Detalle_OrdenCom> Detalle_OrdenCom { get; set; }

}

}
