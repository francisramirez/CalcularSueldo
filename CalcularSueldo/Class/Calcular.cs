namespace CalcularSueldo.Class
{
    public class Calcular
    {


        public void CalcularSueldo()
        {
            //Declarar la variable horasTrabajadas, costoHoras, sueldo
            int horasTrabajadas = 0;
            int costoHoras = 0;
            decimal sueldo = 0;
            decimal impuesto = 0.18m;
            decimal valorImpuesto = 0;


            try
            {
                Console.WriteLine("Digite las horas trabajadas: ");
                horasTrabajadas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el costo de las horas: ");
                costoHoras = int.Parse(Console.ReadLine());


                sueldo = (horasTrabajadas * costoHoras);
                Console.WriteLine($"El sueldo antes de impuesto: {sueldo}");

                if (sueldo > 3000)
                {
                    // Calcular el impuesto //
                    valorImpuesto = (sueldo * impuesto);
                    sueldo = (sueldo - valorImpuesto);

                    Console.WriteLine($"El valor del impuesto es: {valorImpuesto}");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine($"El sueldo después de impuesto = {sueldo}");
                }
                else if(sueldo >= 5000) 
                {
                    // Realzar x operacion //
                }
                else
                {
                    Console.WriteLine($"El sueldo es: {sueldo}");
                }


               
            }
            catch (Exception ex)
            {
                // Guardar en un log y enviar la notificacion //
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message} calculando el sueldo.");
            }

        }

        public void CalcularMayorNumero()
        {
            int num1 = 0;
            int num2 = 0;

            try
            {
                Console.WriteLine("Digite el num 1: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el num 2: ");
                num2 = Convert.ToInt32(Console.ReadLine());


                if (num1 > num2)
                {
                    Console.WriteLine($"El num 1: { num1 } es mayor");
                }
                else
                {
                    Console.WriteLine($"El num 2: { num2 } es mayor");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error validando cual es mayor. { ex.Message }");
            }

        }
    }
}
