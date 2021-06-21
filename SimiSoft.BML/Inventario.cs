using Dapper;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{
    public class Inventario
    {
        private static DataAccess dataAccess = DataAccess.Instance();
        public int idProducto { get; set; }
        public string descripcion { get; set; }
        public string unidadMedida { get; set; }
        public string codigo { get; set; }
        public decimal precio { get; set; }
        public int stock { get; set; }
        public string marca { get; set; }
        public bool activo { get; set; }

        public int cantidad { get; set; }

        public Inventario()
        {
            
        }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@descripcion", descripcion);
            parametros.Add("@unidadMedida", unidadMedida);
            parametros.Add("@codigo", codigo);
            parametros.Add("@precio", precio);
            parametros.Add("@stock", stock);
            parametros.Add("@marca", marca);
            return dataAccess.Execute("stp_productos_add", parametros);
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idProducto", idProducto);
            return dataAccess.Execute("stp_productos_delete", parametros);
        }

        public List<Inventario> GetAll()
        {
            return dataAccess.Query<Inventario>("stp_productos_getall");
        }

        public Inventario GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idProducto", idProducto);
            return dataAccess.QuerySingleOrDefault<Inventario>("stp_productos_getbyid", parametros);
        }
        public static Inventario GetById(int codigo)
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idProducto", codigo);
            return dataAccess.QuerySingleOrDefault<Inventario>("stp_productos_getbyid", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idProducto", idProducto);
            parametros.Add("@descripcion", descripcion);
            parametros.Add("@unidadMedida", unidadMedida);
            parametros.Add("@codigo", codigo);
            parametros.Add("@precio", precio);
            parametros.Add("@stock", stock);
            parametros.Add("@marca", marca);
            return dataAccess.Execute("stp_productos_update", parametros);
        }
    }
}
