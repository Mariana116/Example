class listas{


    public void listaSinRepetidos(){
        int[] vector = new int[5];
        Random r = new Random();

        for(int i=0; i< vector.Length;i++){
            vector[i]=r.Next(0,100);
        }

        // lista mostrando los que no son repetidos
        List<int> numeros_unicos = new List<int>();
        for (int i = 0; i < vector.Length; i++)
        {
            bool esRepetido = false;
            for (int j = 0; j < i; j++)
            {
                if (vector[i] == vector[j])
                {
                    esRepetido = true;
                    break;
                }
            }
            if (!esRepetido)
            {
                numeros_unicos.Add(vector[i]);
            }
        }
        Console.WriteLine("\nsin repetidos");
        foreach (int ind in numeros_unicos)
        {
            Console.Write("-" + ind);
        }
    }

    public void diccionariorepetido(){
        int[] vector = new int[5];
        Random r = new Random();

        for(int i=0; i< vector.Length;i++){
            vector[i]=r.Next(0,100);
        }

        Dictionary<int, int> frecuencia = new Dictionary<int, int>();
        int longitud = vector.Length;
        // Contar la cantidad de elementos únicos
        for (int i = 0; i < longitud; i++)
        {
            // Si la clave ya está presente en el diccionario, incrementa su valor
            if (frecuencia.ContainsKey(vector[i]))
            {
                frecuencia[vector[i]]++;
            }
            else // Si la clave no está presente, agrega una nueva entrada al diccionario
            {
                frecuencia.Add(vector[i], 1);
            }
        }
        Console.WriteLine("");
        // Imprimir los resultados
        foreach (var kvp in frecuencia)
        {
            Console.WriteLine("Número {0}: {1} veces", kvp.Key, kvp.Value);
        }
    }
}