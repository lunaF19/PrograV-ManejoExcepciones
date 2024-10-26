// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//* Excepciones Aninadas
Console.WriteLine("******************************************");
Console.WriteLine("********** Excepciones Aninadas **********");
try
    {
    Random randomValue = new Random();
    int value1 = randomValue.Next(10);
    int value2 = randomValue.Next(10);   


    Console.WriteLine("Dividiendo " + value1.ToString() + "/"+ value2.ToString());
    decimal result = value1 / value1;
    Console.WriteLine("Resultado" + result);
}
catch(DivideByZeroException)
{
    Console.WriteLine("NO se puede dividor por 0");
}
catch (Exception ex)
{
    Console.WriteLine("Error al realizar la operación: " + ex.Message);
}
Console.WriteLine("********** Excepciones Aninadas **********");
Console.WriteLine("******************************************");
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("\n");

//* Excepciones Personalizadas
Console.WriteLine("****************************************");
Console.WriteLine("****** Excepciones Personalizadas ******");
try
{ 
    Random randomValue = new Random();
    int value1 = randomValue.Next(10);

    Console.WriteLine("Valor generado: " +value1);
    if (value1 > 5)
    {
        throw new Exception("El valor es mayor a 5");
    }

    if (value1 < 5)
    {
        throw new Exception("El valor es menor a 5 ");
    }

    Console.WriteLine("Valor es 5");
}
catch (Exception ex)
{
    Console.WriteLine("Error al realizar la operación: " + ex.Message);
}
Console.WriteLine("****** Excepciones Personalizadas ******");
Console.WriteLine("****************************************");
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("\n");