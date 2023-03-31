using Dominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;

namespace Pruebas.Pruebas_Unitarias.Dominio
{
    [TestClass]
    public class JornadaLaboralTest
    {
        [DataTestMethod]
        [DataRow(6, 12, new int[] {6,7,8,9,10,11})]
        [DataRow(9, 12, new int[] { 9, 10, 11 })]
        [DataRow(19, 0, new int[] { 19, 20, 21, 22, 23 })]
        public void CargarListadoDeHorasTrabajadas(int horaInicio,int HoraFinalizacion, int[] resultadoEsperado)
        {
            // Establecer Condiciones / Definicion de datos
            var mockOP = new Mock<OrdenDeProduccion>();
            var mockUsuario = new Mock<Usuario>();
            var mockTurno = new Mock<Turno>();
            JornadaLaboral jornada = new JornadaLaboral(mockOP.Object,System.DateTime.MaxValue.Date,mockTurno.Object,mockUsuario.Object);
            jornada.HoraInicio = horaInicio;
            jornada.HoraFin = HoraFinalizacion;
            int[] vectorResultado;

            //Ejecutar el metodo / Ejecucion
            jornada.CargarListaDeHorasTrabajadas();
            vectorResultado = jornada.Horas;

            //Comparar Resultados / Comprobacion
            Assert.AreEqual(resultadoEsperado.Length, vectorResultado.Length, $"Se esperaba un vector de longitud: {resultadoEsperado.Length} , Se Obtuvo un vector de longitud: {vectorResultado.Length}");
            for (int i = 0; i < vectorResultado.Length; i++)
            {
                Assert.AreEqual(resultadoEsperado[i], vectorResultado[i], $"Se esperaba : {IntArrayToString(resultadoEsperado)} , Se obtuvo: {IntArrayToString(vectorResultado)}");

            }

        }


        private string IntArrayToString(int[] array)
        {
            if (array.Length > 0)
            {
                return (array == null) ? null : array.Skip(1).Aggregate(array[0].ToString(), (s, i) => s + "," + i.ToString());
            }

            return string.Empty;
        }

    }
}
