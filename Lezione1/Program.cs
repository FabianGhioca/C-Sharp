namespace Lezione1
{
    class Program
    {
        
        // somma
        static int SommaValori(int val1, int val2) {
            return val1 + val2;
        }

        // Sottrazione
        static int SottrazioneValori(int val1, int val2) {
            return val1 - val2;
        }

        // Moltiplicazione
        static int MoltiplicazioneValori(int val1, int val2) {
            return val1 * val2;
        }

        // Divisione
        static int DivisioneValori(int val1, int val2) {
            return val1 / val2;
        }

        static void Main(string[] args)
        {
            // Somma e moltiplicazione
            
            //int x = 15;
            //int y = 20;
            //int addendo1 = 3;
            //int addendo2 = 4;

            //int somma = SommaValori(x, y);
            //int moltiplicazione = x * y;

            //Console.WriteLine("Somma: " + somma);
            //Console.WriteLine("Moltiplicazione: " + moltiplicazione);

            //somma = SommaValori(addendo1, addendo2);
            //Console.WriteLine("Somma: " + somma);




            // definire l'area del cerchio

            // int raggio = 0;
            // while(raggio != -1)
            // {
            // Console.WriteLine("Digita il raggio del cerchio e premi il pulsante invio: ");
            // int.TryParse(Console.ReadLine(), out raggio);
            // double areaCerchio = AreaCerchio(raggio);
            // Console.WriteLine("L'area del cerchio misura:" + areaCerchio);
            // }




            // ciclo for

            // for(int i = 0; i < 10; i++){
            //     Console.Write(i + ",");
            // }



            // costrutto condizionale if

            // int raggio = 0;
            // while (raggio != -1){
            //     Console.WriteLine("Digita il raggio del cerchio e premi il pulsante invio: ");
            //     int.TryParse(Console.ReadLine(), out raggio);

            //     if(raggio > 0){
            //         double areaCerchio = AreaCerchio(raggio);
            //         Console.WriteLine("L'area del cerchio misura:" + areaCerchio);  

            //     } else if(raggio == -1) {
            //         Console.WriteLine("Hai scelto di terminare il programma");  

            //     } else {
            //         Console.WriteLine("Hai inserito un valore non valido");
            //     } int.TryParse(Console.ReadLine(), out val1);
            //         Console.WriteLine("Lunedi");
            //         break;
            //     case 2:
            //         Console.WriteLine("Martedi");
            //         break;
            //     case 3:
            //         Console.WriteLine("Mercoledi");
            //         break;
            //     default:
            //         Console.WriteLine("Valore non compreso all'interno delle casistiche specificate");
            //         break;
            // }


            // Esercizio 1
            // Realizzare il codice che permetta la scelta di un'operazione matematica, 
            // a seguito richieda l'inserimento di due valori numerici 
            // ed esegua l'operazione scelta in precedenza


            int operazioni = 5;
            while (operazioni > 4) {
            Console.WriteLine("1 = Somma," + " 2 = Sottrazione," + " 3 = Moltiplicazione," + " 4 = Divisione");
            int.TryParse(Console.ReadLine(),out operazioni);
            int val1;
            int val2;

            if (operazioni > 4) {
                Console.WriteLine("Valore non compreso all'interno delle casistiche specificate");
            }
            
            switch(operazioni){
                case 1:
                    Console.WriteLine("Inserisci il primo valore: ");
                    int.TryParse(Console.ReadLine(), out val1);

                    Console.WriteLine("Inserisci il secondo valore: ");
                    int.TryParse(Console.ReadLine(), out val2);

                    int somma = SommaValori(val1, val2);
                    Console.WriteLine("Somma: " + somma);
                    break;

                case 2:

                    Console.WriteLine("Inserisci il primo valore: ");
                    int.TryParse(Console.ReadLine(), out val1);

                    Console.WriteLine("Inserisci il secondo valore: ");
                    int.TryParse(Console.ReadLine(), out val2);
                    
                    if(val1 >= val2) {
                    int Sottrazione = SottrazioneValori(val1, val2);
                    Console.WriteLine("Sottrazione: " + Sottrazione);
                    } else {
                        Console.WriteLine("I valori non sono validi");
                    }
                    break;
                
                case 3:

                    Console.WriteLine("Inserisci il primo valore: ");
                    int.TryParse(Console.ReadLine(), out val1);

                    Console.WriteLine("Inserisci il secondo valore: ");
                    int.TryParse(Console.ReadLine(), out val2);

                    int moltiplicazione = MoltiplicazioneValori(val1, val2);
                    Console.WriteLine("Moltiplicazione: " + moltiplicazione);
                    break;

                case 4:
                    Console.WriteLine("Inserisci il primo valore: ");
                    int.TryParse(Console.ReadLine(), out val1);

                    Console.WriteLine("Inserisci il secondo valore: ");
                    int.TryParse(Console.ReadLine(), out val2);

                    if (val1 >= val2) {
                    int divisione = DivisioneValori(val1, val2);
                    Console.WriteLine("Divisione: " + divisione);
                    } else {
                        Console.WriteLine("I valori inseriti non sono validi");
                    }
                    break;
           }    }               
        }
    }
}