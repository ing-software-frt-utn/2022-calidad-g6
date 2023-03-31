using Dominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace Pruebas.Pruebas_Unitarias.Dominio
{
    [TestClass]
    public class OrdenDeProduccionTest
    {

        [DataTestMethod]
        [DataRow(1)]
        [DataRow(5)]
        [DataRow(0)]
        public void AgregarJornadaLaboral(int cantidadAgregada)
        {

            // Establecer Condiciones / Definicion de datos
            OrdenDeProduccion ordenTest = new OrdenDeProduccion();
            ordenTest.JornadasLaborales = new List<JornadaLaboral>();
            var mockUsuario = new Mock<Usuario>();
            var mockTurno = new Mock<Turno>();

            //Ejecutar el metodo / Ejecucion
            for (int i = 0; i < cantidadAgregada; i++)
            {
                ordenTest.AgregarJornadaLaboral(mockUsuario.Object, mockTurno.Object);
            }

            //Comparar Resultados / Comprobacion
            Assert.AreEqual(cantidadAgregada, ordenTest.JornadasLaborales.Count, $"Se esperaba tener : {cantidadAgregada} , Se obtuvo: {ordenTest.JornadasLaborales.Count}");
        }


    }
}
