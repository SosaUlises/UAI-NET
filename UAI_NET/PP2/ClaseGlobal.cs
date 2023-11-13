using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PP2
{
    public static class ClaseGlobal
    {

       public static List<Producto> Lista = new List<Producto>(); // Lista de Objetos

       public class Producto  // Creacion Objeto Producto
        {
            public string nombre;
            public string descripcion;
            public string categoria;
            public int precio;
            public int stock;
            public string proveedor;

            public Producto(string no, string de, string ca, int pre, int sto, string pro)
            {
                nombre = no;
                descripcion = de;
                categoria = ca;
                precio = pre;
                stock = sto;
                proveedor = pro;
            }

            public string getNombre()
            {
                return nombre;
            }
            public string getDescripcion()
            {
                return descripcion;
            }
            public string getCategoria()
            {
                return categoria;
            }

            public int getPrecio()
            {
                return precio;
            }
            public int getStock()
            {
                return stock;
            }
            public string getProveedor()
            {
                return proveedor;
            }

            public void setNombre(string nom)
            {
                nombre = nom;
            }
            public void setDescripcion(string descrip)
            {
                descripcion = descrip;
            }
            public void setCategoria(string cate)
            {
                categoria = cate;
            }
            public void setPrecio(int prec)
            {
                precio = prec;
            }
            public void setStock(int stoc)
            {
                stock = stoc;
            }
            public void setProveedor(string provee)
            {
                proveedor = provee;
            }
        }


    }
}
