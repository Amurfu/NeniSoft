using Dapper;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{
    public class Venta
    {

        private DataAccess dataAccess = DataAccess.Instance();
        public int idVenta { get; set; }
        public int idCliente { get; set; }
        public DateTime fecha { get; set; }
        public int cantidad { get; set; }
        public decimal importe { get; set; }
        public string tipoEnvio { get; set; }
        public string status { get; set; }

        public decimal total { get; set; }
        

        public Venta()
        {
        }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@fecha", fecha);
            parametros.Add("@total", total);
            parametros.Add("@tipoEnvio", tipoEnvio);
            parametros.Add("@idCliente", idCliente);
            parametros.Add("@cantidad", cantidad);
            return dataAccess.Execute("stp_ventas_add", parametros);
            

        }

        public void cargarId()
        {
            List<int> lst = new List<int>();
            lst = dataAccess.Query<int>("stp_ventas_getlastid");
            this.idVenta = lst[0];
        }

        public List<Venta> GetAll()
        {
            return dataAccess.Query<Venta>("stp_ventas_getall").ToList();
        }
    }
}
