namespace BLL
{
    public class ArchivosTXT
    {
        public ArchivosTXT() { }
        public List<Compra> Leer(string rutaArchivo)
        {
            List<Compra> compras = new List<Compra>();

            StreamReader sr = new StreamReader(rutaArchivo);

            while( sr.EndOfStream )
            {
                string[] strDatosCompras = sr.ReadLine().Split(";");

                if(strDatosCompras.Length == 6)
                {
                    try 
                    {
                        Compra compra = new Compra()
                        {
                            Identificacion = strDatosCompras[0],
                            Nombre = strDatosCompras[1],
                            Apellido = strDatosCompras[2],
                            Provincia = strDatosCompras[3],
                            Email = strDatosCompras[4],
                            Monto = Convert.ToDecimal(strDatosCompras[5])
                        };

                        compras.Add(compra);
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }

            return compras;
        }
    }
}