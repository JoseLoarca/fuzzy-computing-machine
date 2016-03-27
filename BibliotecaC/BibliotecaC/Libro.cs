using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC
{
    [Serializable]
    class Libro
    {
        public int idLibro { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public string editorial { get; set; }
        public Libro() { }
        public Libro(int idLibro, string titulo, string autor, string editorial)
        {
            this.idLibro = idLibro;
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
        }
    }
}
