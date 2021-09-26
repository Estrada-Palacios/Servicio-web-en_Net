using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CalculaAWS.Clases;

namespace CalculaAWS
{
    /// <summary>
    /// Descripción breve de CalculaAService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculaAService : System.Web.Services.WebService
    {

        [WebMethod]
        public string Calcular ()
        {
            return "Hola";
        }

        [WebMethod(Description = "Este metodo calcula el área de un Cuadrado")]
        public decimal AreaCuadrado(decimal LadoA, decimal LadoB)
        {
            Calcular calcula = new Calcular();
            calcula.Lado1 = LadoA;
            calcula.Lado2 = LadoB;
            return calcula.Cuadrado();

        }

        [WebMethod(Description = "Este metodo calcula el área de un Triangulo")]
        public decimal AreaTriangulo(decimal Base, decimal Altura)
        {
            Calcular calcula = new Calcular();
            return calcula.Triangulo(Base, Altura);

        }

        [WebMethod(Description = "Este metodo calcula el area de un circulo")]
        public double AreaCirculo(double Radio)
        {
            Calcular calcula = new Calcular();
            return calcula.Circulo(Radio);
        }
    }
}

