using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Dominio.Repositorio;

namespace Biblioteca_Infraestructura.Repositorio
{
    public class Repositorio_Infraestructura : Repositorio_Interface
    {
        readonly BibliotecaContexto ioContexto;

        public Repositorio_Infraestructura()
        {
            ioContexto = new BibliotecaContexto();
        }

        public T ObtenerPorCodigo<T>(params object[] aoLLaves) where T : class
        {
            return ioContexto.Set<T>().Find(aoLLaves);
        }

        public IQueryable<T> Listar<T>(string asPropiedades = "") where T : class
        {
            return ioContexto.Set<T>();
        }

        public void Adicionar<T>(T aoEntidad) where T : class
        {
            ioContexto.Set<T>().Add(aoEntidad);
        }

        public void GuardarCambios()
        {
            ioContexto.SaveChanges();
        }
    }
}
