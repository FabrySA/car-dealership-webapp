//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoFinal.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Factura
    {
        public int IdFactura { get; set; }
        public int IdUsuario { get; set; }
        public int IdVehiculo { get; set; }
        public System.DateTime FechaEntrega { get; set; }
        public System.DateTime FechaFactura { get; set; }
        public decimal Total { get; set; }
    
        public virtual Usuario Usuario { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
    }
}
