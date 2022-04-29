using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola_Tabla_de_amortizacion
{
    class Program  
    { 
    
        static void Main(string[] args)
        {    
            Parametros parametros = new Parametros(); 
            /*try
            {    */  
                //Ingrese los siguientes datos
                

                
                Console.Write("Introduce el monto del prestamo: ");
                parametros.Monto_del_prestamo = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Introduce la tasa de interes anual: ");
                parametros.Tasa_interes_anual = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Introduce el plazo en meses: ");
                parametros.Plazo = Convert.ToDecimal(Console.ReadLine());
                
            /*}
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }*/

                //
                decimal Interes_pagado = 0;
                decimal Capital_pagado = 0;
                decimal Plazo = 0;
                int fila = 0;

                            
                Console.WriteLine();
                fila = 0;
                Console.WriteLine();
                Console.WriteLine();
                Console.Write(" Numero de pago \t");
                Console.Write("Pago \t\t");
                Console.Write("Intereses Pagados \t\t");
                Console.Write("Capital Pagado \t\t");
                Console.Write("Monto del prestamo \t");
                Console.Write("fecha a pagar el prestamo \t\t");
                Console.WriteLine();
                Console.Write("\t0");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t{0}", parametros.Monto_del_prestamo);

                for (int i = 1; i <= Plazo; i++)
                {
                    //Tasa_interes_mensual = Math.Round((parametros.Interes_pagados * Capital_pagado), 2);
                    //Capital_pagado = Math.Round(Capital_pagado + parametros.Tasa_interes_mensual, 2);

                    //Amortizacion Totales y Principales

                    Console.Write("\t{0}\t\t", fila);
                
                    Console.Write("{0}\t",parametros.Calcular_pago(parametros.Tasa_interes_mensual, parametros.Plazo, parametros.Monto_del_prestamo));
                
                    Interes_pagado = parametros.Tasa_interes_mensual * parametros.Monto_del_prestamo;
                    Console.Write("{0}\t\t",Interes_pagado);
                
                    Capital_pagado = parametros.Calcular_pago (parametros.Tasa_interes_mensual, parametros.Plazo, parametros.Monto_del_prestamo);
                    Console.Write("\t{0}\t",Capital_pagado);
                
                    parametros.Monto_del_prestamo = parametros.Monto_del_prestamo - Capital_pagado;
                    Console.Write("\t{0}\t",parametros.Monto_del_prestamo);
                    fila = fila + 1;
                    Console.WriteLine();
                
                }
                Console.ReadLine();
            }
       }
}       
             