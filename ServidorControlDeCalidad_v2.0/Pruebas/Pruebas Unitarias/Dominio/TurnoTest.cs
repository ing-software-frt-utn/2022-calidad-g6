using Dominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Pruebas.Pruebas_Unitarias
{
    [TestClass]
    public class TurnoTest
    {
        // probar XUnit e investigar sobre mocks. 

        [DataTestMethod]
        [DataRow(1, 6, 12, "Mañana", true)]
        [DataRow(2, 23, 05, "Madrugada", false)]
        public void TurnoIniciaYTerminaElMismoDia(int id, int horaInicio, int horaFin, string descripcion, bool resultadoEsperado)
        {
            // Establecer Condiciones / Definicion de datos
            Turno turno = new Turno();
            turno.TurnoId = id;
            turno.HoraInicio = horaInicio;
            turno.HoraFin = horaFin;
            turno.Descripcion = descripcion;

            //Ejecutar el metodo / Ejecucion
            bool resultado = turno.EsDuranteElDia();

            //Comparar Resultados / Comprobacion
            Assert.AreEqual(resultadoEsperado, resultado, $"Se esperaba un: {resultadoEsperado} , Se Obtuvo un: {resultado}");


        }


        [DataTestMethod]
        [DataRow(1, 12, 18, "Tarde", 18, 0)]
        [DataRow(2, 18, 00, "Noche", 20, -99)]
        [DataRow(3, 8, 12, "Mañana", 10, 2)]
        public void ObtenerCuentaDeHorasDisponiblesParaTrabajar(int id, int horaInicio, int horaFin, string descripcion, int horaActual, int resultadoEsperado)
        {
            // Establecer Condiciones / Definicion de datos
            Turno turno = new Turno();
            turno.TurnoId = id;
            turno.HoraInicio = horaInicio;
            turno.HoraFin = horaFin;
            turno.Descripcion = descripcion;

            //Ejecutar el metodo / Ejecucion
            int resultado = turno.ObtenerTotalDeHoras(horaActual);

            //Comparar Resultados / Comprobacion
            Assert.AreEqual(resultadoEsperado, resultado, $"Se esperaba un: {resultadoEsperado} , Se Obtuvo un: {resultado}");

        }


        [DataTestMethod]
        [DataRow(3, 12, 18, "Tarde", 18,new int[0] { })]
        [DataRow(3, 12, 18, "Tarde", 14,new int[] {14,15,16,17 })]
        [DataRow(1, 8, 12, "Mañana", 10,new int[] {10,11 })]
        public void HorasParaTrabajar(int id, int horaInicio, int horaFin, string descripcion, int horaActual, int[] resultadoEsperado)
        {
            // Establecer Condiciones / Definicion de datos
            Turno turno = new Turno();
            turno.TurnoId = id;
            turno.HoraInicio = horaInicio;
            turno.HoraFin = horaFin;
            turno.Descripcion = descripcion;

            //Ejecutar el metodo / Ejecucion
            int[] vectorResultado = turno.ObtenerHorasDesdeHoraActual(horaActual);

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
