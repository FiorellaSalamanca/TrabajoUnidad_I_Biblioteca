using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca_Dominio.Entidades;
using Biblioteca_Infraestructura.Repositorio;

namespace Biblioteca_PruebasUnitarias
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void CrearAutor()
        {
             var autorcito = ClsAutor.RegistrarAutor("upt", "Perez");
             var reposit = new Repositorio_Infraestructura();
            reposit.Adicionar<ClsAutor>(autorcito);
            reposit.GuardarCambios();
            Assert.IsNotNull(autorcito);
            Assert.IsTrue(autorcito.nom_autor == "upt");
        }

        [TestMethod]
        public void CrearLibro()
        {
            var librito = ClsLibro.RegistrarLibro(1, 1, 1, 1, "Harry Potter", "Caliza de Fuego", "Ingles", 520, 3);
            var reposit = new Repositorio_Infraestructura();
            reposit.Adicionar<ClsLibro>(librito);
            reposit.GuardarCambios();
            Assert.IsNotNull(librito);
            Assert.IsTrue(librito.id_autor == 1);
        }
    }
}
