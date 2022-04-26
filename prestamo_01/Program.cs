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
            try 
            {
                Parametros parametros = new Parametros();        
                //Ingrese los siguientes datos
                
                decimal valor = 987.654m;
                Console.WriteLine(valor.ToString("C2"));

                
                Console.Write("Introduce el monto del prestamo: ");

                parametros.Monto_del_prestamo = Convert.ToDecimal(Console.ReadLine());
                
                Console.Write("Introduce la tasa de interes anual: ");
                parametros.Tasa_interes_anual = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Introduce el plazo en meses: ");
                parametros.Plazo = Convert.ToDecimal(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

                //Calculo del interes mensual
             /*   Tasa_interes_mensual = (tasa_interes_anual / 100) / 12;


                //Calculo de la cuota mensual
                pago = Tasa_interes_mensual + 1;
                pago = (decimal)Math.Pow(pago, Plazo);
                pago = pago - 1;
                pago = Tasa_interes_mensual / pago;
                pago = Tasa_interes_mensual + pago;
                pago = Monto_del_prestamo * pago;


            
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
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t{0}", Monto_del_prestamo);


                for (i = 1; i <= Plazo; i++)
                {

                
                    Console.Write("\t{0}\t\t", fila);

                
                    Console.Write("{0}\t",pago);

                
                    Interes_pagado = Tasa_interes_mensual * Monto_del_prestamo;
                    Console.Write("{0}\t\t",Interes_pagado);

                
                    Capital_pagado = pago - Interes_pagado;
                    Console.Write("\t{0}\t",Capital_pagado);

                
                    Monto_del_prestamo = Monto_del_prestamo - Capital_pagado;
                    Console.Write("\t{0}\t",Monto_del_prestamo);

                    fila = fila + 1;
                    Console.WriteLine();
                
                }*/
                Console.ReadLine();
            }
    }
}
             