using Aplicacion.Administradores;
using Dominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Pruebas.Pruebas_Unitarias.Administradores
{
    [TestClass]
    public class AdministradorDeModelosTest
    {
        //public IDesempaquetador _desempaquetador = Desempaquetador.Instance;
        //[TestMethod]
        //public void BuscarModelosPorSKUValido()
        //{
        //    // Establecer Condiciones / Definicion de datos
        //    AdministradorModelos admin = AdministradorModelos.InstanceTesteo;
        //    admin.IniciarDBTesteo();
        //    string codigoSKU = "07GD33VP";
        //    string descripcionBuscada = "Garden";

        //    //Ejecutar el metodo / Ejecucion
        //    List<PaqueteMultipleMixto> resultadobusqueda = admin.BuscarModelosPorSKU(codigoSKU);
        //    Modelo resultado = new Modelo();
        //    foreach (var item in resultadobusqueda)
        //    {
        //        resultado = _desempaquetador.DesempaquetarModelo(item);
        //    }
            
        //    //Comparar Resultados / Comprobacion
        //    Assert.AreEqual(resultado.Descripcion, descripcionBuscada, $"Se esperaba recibir: {descripcionBuscada} , Se Obtuvo recibio: {resultado.Descripcion}");
        //}

        //[TestMethod]
        //public void BuscarModelosPorSKUInexistente()
        //{
        //    // Establecer Condiciones / Definicion de datos
        //    AdministradorModelos admin = AdministradorModelos.InstanceTesteo;
        //    admin.IniciarDBTesteo();
        //    string codigoSKU = "07GD3300";

        //    //Ejecutar el metodo / Ejecucion
        //    List<PaqueteMultipleMixto> resultadobusqueda = admin.BuscarModelosPorSKU(codigoSKU);
        //    Modelo resultado = new Modelo();
        //    foreach (var item in resultadobusqueda)
        //    {
        //       resultado = _desempaquetador.DesempaquetarModelo(item);
        //    }
            
        //    //Comparar Resultados / Comprobacion
        //    Assert.IsNull(resultado.Descripcion, $"Se esperaba recibir: {null} , Se Obtuvo recibio: {resultado.Descripcion}");
        //}

    }
}
