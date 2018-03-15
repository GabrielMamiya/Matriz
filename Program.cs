using System;

namespace matriz
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int n;
            int[,] matriz;

            string[] dimensoesDaMatriz = Console.ReadLine().Split(' ');

            matriz = new int[int.Parse(dimensoesDaMatriz[0]), int.Parse(dimensoesDaMatriz[1])];

            for (int i = 0; i < int.Parse(dimensoesDaMatriz[0]); i++)
            {
                string[] vetorDeLinhas = Console.ReadLine().Split(' ');
                for (int j = 0; j < int.Parse(dimensoesDaMatriz[1]); j++){
                    matriz[i, j] = int.Parse(vetorDeLinhas[j]);
                }
            }

            Console.WriteLine();
            n = int.Parse(Console.ReadLine());

            for (int k = 0; k < int.Parse(dimensoesDaMatriz[0]); k++){
                for (int z = 0; z < int.Parse(dimensoesDaMatriz[1]); z++){
                    if(matriz[k,z] == n){
                        if(z > 0){
                        Console.WriteLine("Numero da esquerda: " + matriz[k, z - 1]);
                    }
                        if(k > 0) {
                            
                            Console.WriteLine("Numero acima: " + matriz[k - 1, z]);
                        }
                        if(z < int.Parse(dimensoesDaMatriz[1]) - 1){
                            Console.WriteLine("Numero da direita: " + matriz[k, z + 1]);
                        }
                        if(k < int.Parse(dimensoesDaMatriz[0]) - 1){
                            Console.WriteLine("Numero abaixo: " + matriz[k + 1, z]);
                                        
                        }
                }


            }
        }




















            //int n;
            //int[,] matriz;

            //n = int.Parse(Console.ReadLine());
            //matriz = new int[n, n];

            //for (int i = 0; i < n; i++){
            //    string[] vet = Console.ReadLine().Split(' ');
            //    for (int j = 0; j < n; j++){
            //        matriz[i, j] = int.Parse(vet[j]);
            //    }
            //}

            //Console.WriteLine("Diagonal principal:");
            //for (int x = 0; x < n; x++){
            //    Console.WriteLine(matriz[x,x] + " ");
            //}

            //int count = 0;

            //Console.WriteLine();
            //for (int a = 0; a < n; a++ ){
            //    for (int b = 0; b < n; b++){
            //        if(matriz[a,b] < 0){
            //            count++;
            //        }
            //    }
            //}

            //Console.WriteLine(count);

        }
    }
}
