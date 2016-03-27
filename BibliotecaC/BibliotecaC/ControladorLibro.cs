using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BibliotecaC
{
    class ControladorLibro
    {
        private List<Libro> libros = null;
        private static readonly ControladorLibro instancia = new ControladorLibro();
        public static ControladorLibro getInstancia()
        {
            return instancia;
        }
        private ControladorLibro() { libros = new List<Libro>(); }
        public void Agregar(Libro l) { libros.Add(l); }
        public List<Libro> listar() { return libros; }
        public void eliminar(int id)
        {
            foreach (Libro l in libros)
            {
                if(l.idLibro==id){
                    libros.Remove(l);
                    break;
                }
            }
        }
        public void serializar()
        {
            FileStream archivo = new FileStream(@"../../BaseDeDatos/db2.jc", FileMode.Create);
            BinaryFormatter formato = new BinaryFormatter();
            formato.Serialize(archivo, libros);
            archivo.Close();
        }
        public List<Libro> deserializar()
        {
            FileStream archivo = null;
            BinaryFormatter formato = new BinaryFormatter();
            try
            {
                archivo = new FileStream(@"../../BaseDeDatos/db2.jc", FileMode.Open);
                libros = formato.Deserialize(archivo) as List<Libro>;
                archivo.Close();
            }
            catch (Exception e)
            {

            }
            return libros;
        }
    }
}
