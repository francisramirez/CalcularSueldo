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

            Console.WriteLine("Digite las horas trabajadas: ");
            horasTrabajadas = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Digite el costo de las horas: ");
            costoHoras = int.Parse(Console.ReadLine());


            sueldo = (horasTrabajadas * costoHoras);

            Console.WriteLine($"El sueldo es: { sueldo }");

        }

        public void CalcularProductoSuma() 
        {

        }
    }
}
