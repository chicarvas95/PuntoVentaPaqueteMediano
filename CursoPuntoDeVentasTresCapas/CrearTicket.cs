using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;


namespace CursoPuntoDeVentasTresCapas
{
    //Esta es la clase para crear el ticket de venta. Creamos varios metodos aqui.
    public class CrearTicket
    {
        //Creamos un objeto de la clase StringBuilder,en este objeto agregamos las lineas del ticket
        StringBuilder linea = new StringBuilder();
        //Creamos una variable para almacenar el numero maximo de caracteres que permitiremos en el ticket
        int maxCar = 40, cortar;//Para una impresora ticketera que imprime a 40 columnas. la variable cortar cortara el texto cuando rebase el limite.
        //Creamos el primer metodo, este dibujara lineas guion.
        public string lineasGuion()
        {
            string lineasGuion = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasGuion += "-";//Agregara un guion hasta llegar el numero maximo de caracteres.
            }
            return linea.AppendLine(lineasGuion).ToString(); //Devolvemos la lineaGuion
        }
        //Metodo para dibujar una linea con asteriscos
        public string lineasAstericos()
        {
            string lineasAsterisco = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasAsterisco += "*";//Agregara un guion hasta llegar el numero maximo de caracteres.
            }
            return linea.AppendLine(lineasAsterisco).ToString();//Devolvemos los asteriscos.
        }
        //Realizamos el mismo procedimiento para dibujar una lineas con el signo igual
        public string lineasIgual()
        {
            string lineasIgual = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasIgual += "=";//Agregara un igual hasta llegar el numero maximo de caracteres
            }
            return linea.AppendLine(lineasIgual).ToString();//Devolvemos las lineas con iguales
        }
        //Creamos el encabezado para los articulos
        public void EncabezadoVenta()
        {
            //Escribimos los espacios para mostrar el articulo. En total tiene que ser 40 caracteres
            linea.AppendLine("ARTICULO            |CANT|PRECIO|IMPORTE");

        }
        //Creamos un metodo para poner el texto a la izquierda
        public void TextoIzquierda(string texto)
        {
            //Si la longitud del texto es mayor al numero maximo de caracteres permitidos, realizar el siguiente procedimiento.
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;//Nos indicara en que caracter se quedo al bajar el texto a la siguiente linea
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    //Agregamos el primer fragmento del texto
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }
                //agregamos el fragmento restante
                linea.AppendLine(texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                //Si no es mayor solo agregarlo.
                linea.AppendLine(texto);
            }
        }
        //Creamos un metodo para poner texto a la derecha
        public void TextoDerecho(string texto)
        {
            //Si la longitud del texto es mayor al numero maximo de caracteres permitidos, realizar el siguiente procedimiento.
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;//Nos indicara en que caracter se quedo al bajar el texto a la siguiente linea
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    //Agregamos el primer fragmento del texto
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }
                //Variable para poner espacios restantes
                string espacios = "";
                //Obtenemos la longitud del texto restante.
                for (int i = 0; i < (maxCar - texto.Substring(caracterActual, texto.Length - caracterActual).Length); i++)
                {
                    espacios += " ";//Agregamos espacios para alinear a la derecha
                }
                //agregamos el fragmento restante
                linea.AppendLine(espacios + texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                //Variable para poner espacios restantes
                string espacios = "";
                //Obtenemos la longitud del texto restante.
                for (int i = 0; i < (maxCar - texto.Length); i++)
                {
                    espacios += " ";//Agregamos espacios para alinear a la derecha
                }
                //Si no es mayor solo agregarlo.
                linea.AppendLine(espacios + texto);
            }
        }
        public void TextoCentro(string texto)
        {
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;//Nos indicara en que caracter se quedo al bajar el texto a la siguiente linea
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    //Agregamos el primer fragmento del texto
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }
                //Variable para poner espacios restantes
                string espacios = "";
                //sacamos la cantidad de espacios libres y el resultado lo dividimos entre dos
                int centrar = (maxCar - texto.Substring(caracterActual, texto.Length - caracterActual).Length) / 2;
                //Obtenemos la longitud del texto restante.
                for (int i = 0; i < centrar; i++)
                {
                    espacios += " ";//Agregamos espacios para centrar
                }

                //agregamos el fragmento restante
                linea.AppendLine(espacios + texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                string espacios = "";

                int centrar = (maxCar - texto.Length) / 2;
                for (int i = 0; i < centrar; i++)
                {
                    espacios += " ";
                }

                linea.AppendLine(espacios + texto);
            }
        }
        public void TextoExtremos(string textoIzquierdo)//Anteriormente string textoDerecho
        {
            string textoIzq, textoDer, textoCompleto = "", espacios = "";

            //Si el texto
            if (textoIzquierdo.Length > 18)
            {
                cortar = textoIzquierdo.Length - 18;
                textoIzq = textoIzquierdo.Remove(18, cortar);
            }
            else
            {
                textoIzq = textoIzquierdo;
            }

            textoCompleto = textoIzq;

            //if (textoDerecho.Length > 20)
            //{
            //    cortar = textoDerecho.Length - 20;
            //    textoDer = textoDerecho.Remove(20, cortar);
            //}
            //else
            //{
            //    textoDer = textoDerecho;
            //}

            //int nroEspacios = maxCar - (textoIzq.Length + textoDer.Length);
            //for (int i = 0; i < nroEspacios; i++)
            //{
            //    espacios += " ";
            //}
            //textoCompleto += espacios + textoDerecho;
            linea.AppendLine(textoCompleto);
        }
        //Metodo para agregar los totales de la venta
        public void AgregarTotales(string texto, decimal total)
        {
            string resumen, valor, textoCompleto, espacios = "";
            if (texto.Length > 25)
            {
                cortar = texto.Length - 25;
                resumen = texto.Remove(25, cortar);
            }
            else
            {
                resumen = texto;
            }
            textoCompleto = resumen;
            valor = total.ToString("#,#.00");//Agregamos el total previo formateo

            //Obtenemos el numero de espacios restantes para alinearlos a la derecha
            int nroEspacios = maxCar - (resumen.Length + valor.Length);
            //agregamos los espacios
            for (int i = 0; i < nroEspacios; i++)
            {
                espacios += " ";
            }
            textoCompleto += espacios + valor;
            linea.AppendLine(textoCompleto);
        }

        //Metodo para agregar articulos al ticket de venta
        public void AgregarArticulo(string articulo, int cant, decimal precio, decimal importe) 
        {
            //Valida que cant precio e importe esten dentro del rango.
            if (cant.ToString().Length <= 5 && precio.ToString().Length <= 7 && importe.ToString().Length <= 8)
            {
                string elemento = "", espacios = "";
                bool bandera = false;// Indicara si es la primer linea que se escribe cuando bajemos a la segunda si el nombre del articulo no entra en la primera linea
                int nroEspacios = 0;

                //Si el nombre descripcion del articulo es mayor a 20, bajar  a la siguiente linea
                if (articulo.Length > 20)
                {
                    //Colocar la cantidad a la derecha
                    nroEspacios = (5 - cant.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";//Generamos los espacios necesarios para alinear a la derecha
                    }
                    elemento += espacios + cant.ToString();//Agregamos la cantidad con los espacios 

                    //Colocar el precio a la derecha.
                    nroEspacios = (7 - precio.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += "";//Genera los espacios
                    }
                    
                    elemento += espacios + precio.ToString();//Agregamos el precio a la variable elemento

                    //Colocar el importe a la derecha
                    nroEspacios = (8 - importe.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + importe.ToString();

                    int caracterActual = 0;
                    for (int longitudTexto = articulo.Length; longitudTexto > 20; longitudTexto -= 20)
                    {
                        if (bandera == false)
                        {
                            linea.AppendLine(articulo.Substring(caracterActual, 20));
                        }
                        else
                            linea.AppendLine(articulo.Substring(caracterActual, 20));
                        caracterActual += 20;
                    }

                    linea.AppendLine(articulo.Substring(caracterActual, articulo.Length - caracterActual));
                }
                else
                {
                    for (int i = 0; i < (20 - articulo.Length); i++)
                    {
                        espacios += " ";
                    }
                    elemento = articulo + espacios;

                    nroEspacios = (5 - cant.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + cant.ToString();

                    nroEspacios = (7 - precio.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + precio.ToString();
                   
                    nroEspacios = (8 - importe.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + importe.ToString();
                    linea.AppendLine(elemento);
                }
            }
            else
            {
                linea.AppendLine("Los valores ingresados para esta fila");
                linea.AppendLine("Superan las columnas soportadas por este.");
                throw new Exception("Los valores ingresados para algunas filas del ticket\nsuperan las columnas soportadas por este.");
            }
        }

        public void CortaTicket() 
        {
            linea.AppendLine("\x1B" + "m");
            linea.AppendLine("\x1B" + "d" + "\x09");
        }

        public void AbreCajon() 
        {
            linea.AppendLine("\x1B" + "p" + "\x00" + "\x0F" + "\x96");
        }

        public void ImprimirTicket(string impresora) 
        {
            RawPrinterHelper.SendStringToPrinter(impresora, linea.ToString());
            linea.Clear();
        }

        //Clase para mandar a imprimir texto plano a la impresora
        public class RawPrinterHelper
        {
            // Structure and API declarions:
            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
            public class DOCINFOA
            {
                [MarshalAs(UnmanagedType.LPStr)]
                public string pDocName;
                [MarshalAs(UnmanagedType.LPStr)]
                public string pOutputFile;
                [MarshalAs(UnmanagedType.LPStr)]
                public string pDataType;
            }
            [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

            [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool ClosePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

            [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool EndDocPrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool StartPagePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool EndPagePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

            // SendBytesToPrinter()
            // When the function is given a printer name and an unmanaged array
            // of bytes, the function sends those bytes to the print queue.
            // Returns true on success, false on failure.
            public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
            {
                Int32 dwError = 0, dwWritten = 0;
                IntPtr hPrinter = new IntPtr(0);
                DOCINFOA di = new DOCINFOA();
                bool bSuccess = false; // Assume failure unless you specifically succeed.

                di.pDocName = "Ticket de Venta";//Este es el nombre con el que guarda el archivo en caso de no imprimir a la impresora fisica.
                di.pDataType = "RAW";//de tipo texto plano

                // Open the printer.
                if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
                {
                    // Start a document.
                    if (StartDocPrinter(hPrinter, 1, di))
                    {
                        // Start a page.
                        if (StartPagePrinter(hPrinter))
                        {
                            // Write your bytes.
                            bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                            EndPagePrinter(hPrinter);
                        }
                        EndDocPrinter(hPrinter);
                    }
                    ClosePrinter(hPrinter);
                }
                // If you did not succeed, GetLastError may give more information
                // about why not.
                if (bSuccess == false)
                {
                    dwError = Marshal.GetLastWin32Error();
                }
                return bSuccess;
            }

            public static bool SendStringToPrinter(string szPrinterName, string szString)
            {
                IntPtr pBytes;
                Int32 dwCount;
                // How many characters are in the string?
                dwCount = szString.Length;
                // Assume that the printer is expecting ANSI text, and then convert
                // the string to ANSI text.
                pBytes = Marshal.StringToCoTaskMemAnsi(szString);
                // Send the converted ANSI string to the printer.
                SendBytesToPrinter(szPrinterName, pBytes, dwCount);
                Marshal.FreeCoTaskMem(pBytes);
                return true;
            }
        }
    }
}
