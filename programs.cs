class Program
{
    static void Main(string[] args)
    {
        listas ls= new listas();
        procesos pcs= new procesos();
        vectores vct= new vectores();

        Console.WriteLine("===============Menu===============");
        Console.WriteLine("1. Lista sin repetidos");
        Console.WriteLine("2. diccionario de repetidos");
        Console.WriteLine("3. calcular descuentos");
        Console.WriteLine("4. adivinar numero");
        Console.WriteLine("5. llenar vector");
        Console.WriteLine("6. ");
        int clase = Console.Read();

        switch (clase)
        {
            case 1:
            ls.listaSinRepetidos();
            break;
            case 2:
            ls.diccionariorepetido();
            break;
            case 3:
            pcs.calcularDescuentos();
            break;
            case 4:
            pcs.juegoAdivinarNumero();
            break;
            case 5:
            vct.llenarVector();
            break;
        }
    }
}