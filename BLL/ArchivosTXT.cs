using System;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading;

namespace BLL
{
    public class ArchivosTXT
    {
        public ArchivosTXT() { }
        public List<Compra> Leer(string rutaArchivo)
        {
            // Compra
            //Compra compra = new Compra();

            // Lista de compras
            List<Compra> compras = new List<Compra>();

            // Aqui voy a almacenar cada linea del archivo
            string linea;

            try
            { 
                // Intentamos leer el archivo con la ruta dada
                StreamReader sr = new StreamReader(rutaArchivo);

                // Mientras que el archivo tenga lineas que leer
                while ((linea = sr.ReadLine()) != null)
                {
                    // Dividimos la linea en partes
                    var strDatosCompras = linea.Split(";");

                    // Iniciamos asumiendo que todos los datos son correctos
                    bool datosCompletos = true;

                    foreach (string item in strDatosCompras)
                    {
                        if(item.Length < 1)
                        {
                            datosCompletos = false;
                        }
                    }

                    if (strDatosCompras.Length == 6 && datosCompletos)
                    {
                        try
                        {
                            // Creamos un objeto de clase Compra con los valores del split
                            Compra compra = new Compra()
                            {
                                Identificacion = strDatosCompras[0],
                                Nombre = strDatosCompras[1],
                                Apellido = strDatosCompras[2],
                                Provincia = strDatosCompras[3],
                                Email = strDatosCompras[4],
                                Monto = Convert.ToDecimal(strDatosCompras[5].Replace(".", ","))
                            };

                            // Agregamos la compra a la lista de compras
                            compras.Add(compra);
                        }
                        catch
                        {

                        }
                    } 
                }
            }
            catch 
            {
                Console.WriteLine("error en la clase");
            }

            return compras;
        }
    }
}