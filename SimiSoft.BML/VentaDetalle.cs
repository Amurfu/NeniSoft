using Dapper;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{
   public class VentaDetalle
    {

        private DataAccess dataAccess = DataAccess.Instance();
        public int idVentaDetalle { get; set; }
        public int idVenta { get; set; }
        public int idProducto { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }
        public decimal importe { get; set; }
        public decimal dc { get; set; }
        public decimal dv { get; set; }
        public decimal dv2 { get; set; }
        public decimal descuento { get; set; }
        public decimal total { get; set; }

        public VentaDetalle()
        {
        }

        public int Add( )
        {
           var parametros = new DynamicParameters();
            parametros.Add("@idProducto", this.idProducto);
            parametros.Add("@idVenta", this.idVenta);
            parametros.Add("@cantidad", this.cantidad);
            parametros.Add("@precio", this.precio);
            parametros.Add("@total", this.total);
            return dataAccess.Execute("stp_ventasdetalle_add",parametros);
        }
    }
}

