using System.Globalization;

class vectores{

    
    public void llenarVector(){

        int[] Vector = new int[5];
        Random r = new Random();

        for(int i=0; i< Vector.Length;i++){
            Vector[i]=r.Next(0,100);
        }

        // mostrar elementos del vector
        foreach(int vt in Vector){
            Console.WriteLine("-" + vt);
        }
    }

    public void segundoMayor(){
        int[] vector = new int[5];
        Random r = new Random();

        for(int i=0; i< vector.Length;i++){
            vector[i]=r.Next(0,100);
        }

        int primero=0;
        int segundo=0;

        for(int i=0;i<vector.Length;i++){
            if(vector[i]>primero){
                segundo=primero;
                primero=vector[i];
            }else if(vector[i]>segundo && vector[i] != primero){
                segundo=vector[i];
            }
        }
         Console.WriteLine("primer mayor= "+ primero+" segundo mayor " + segundo);
    }

    public void eliminarRepetido(){
        int[] vector = new int[5];
        Random r = new Random();

        for(int i=0; i< vector.Length;i++){
            vector[i]=r.Next(0,100);
        }

        int tamaño= vector.Length;
        int contador=0;

        for(int i=0; i < tamaño;i++){
            bool repetido=false;
            for(int j=0; j<i;j++){
                if(vector[i]== vector[j]){
                    repetido=true;
                    break;
                }
            }
            if(!repetido){
                contador++;
            }
        }

        // elementos unicos
        int[]repetidos= new int[contador];
        int index=0;
        for(int i=0;i<tamaño;i++){
            bool repetido=false;
            for(int j=0; j<i; j++){
                if(vector[i]== vector[j]){
                    repetido=true;
                    break;
                }
            }
            if(!repetido){
                repetidos[index]= vector[i];
                index++;
            }
        }

    }


}
