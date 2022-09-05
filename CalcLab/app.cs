using System;

class App{

            //variaveis 

        //variavel para escolha de calculadora
        int selecaoCalculadora = 0;

        //Escolha regulador
        int escRegulador = 0;
        
        //corrente leds
        double correnteLeds=0;

    static void Main(){

        menu();
        

        //Console.WriteLine(selecaoCalculadora);

        switch(selecaoCalculadora){
            case 1:
                //Console.Clear();
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("----------------      Reguladores         ---------------");
                Console.WriteLine("---------------------------------------------------------\n\n");
                Console.WriteLine("LM317 ====== [1]");
                Console.WriteLine("Digite o número do regulador: ");
                escRegulador = int.Parse(Console.ReadLine());

                if(escRegulador == 1){
                    Console.WriteLine("                LM317                                         ");
                    Console.WriteLine("             ---------     R1         LD1   LD2  LD3          ");
                    Console.WriteLine("       -----|         |----[  ]---.---|>----|>----|>---       ");
                    Console.WriteLine("      |      ---------            |                    |      ");
                    Console.WriteLine("     ___          |_______________|                    |      ");
                    Console.WriteLine("      -                                                |      ");
                    Console.WriteLine("     ___                                               |      ");
                    Console.WriteLine("      -                                                |      ");
                    Console.WriteLine("      |                                                |      ");
                    Console.WriteLine("       ------------------------------------------------       ");
                    Console.WriteLine("                                                              ");

                    //calculo basíco == (V / R = Iout)
                    // (V   = Iout * R)
                    // (V / Iout = R)
                    // ajuste formula == (R = V / Iout)
                    //Tensão consumida pelo regulador 1,25volts
                    Console.WriteLine("Digite o valor da corrente(I) necessária para os leds: ");
                    //correnteLeds = float.Parse(Console.ReadLine());
                    correnteLeds = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine(correnteLeds);
             
                    //queda tensão no regulador
                    const float ltRegulador = 1.25f;
                    Console.WriteLine(ltRegulador);
                    
                    //calculo do valor do resistor
                    double valorResistor = (ltRegulador)/correnteLeds;

                     Console.WriteLine(valorResistor);
                    
                    Console.WriteLine("O valor do resistor necessário é: {0:F}", valorResistor);


                
                }

                break;
            case 2:
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("----------------      Resistores          ---------------");
                Console.WriteLine("---------------------------------------------------------\n\n");
                break;
            case 3: 
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("----------------      CalcLab v0.0.1      ---------------");
                Console.WriteLine("---------------------------------------------------------\n\n");
                break;
        }


        //retornar ao menu principal
        Console.WriteLine("Deseja retoranar ao menu principal?");
        Console.WriteLine("Sim(s) ou  Não(n)");
        String retornoMenu = Console.ReadLine();

        if(retornoMenu == "s"){
            menu();
        }


        
    }

       static void menu(){

            Console.Clear();
            //menu príncipal
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("----------------      CalcLab v0.0.1      ---------------");
            Console.WriteLine("---------------------------------------------------------\n\n");

            Console.WriteLine("Reguladores ====== [1]");
            Console.WriteLine("Resistores  ====== [2]");
            Console.WriteLine("Capacitores ====== [3]");


            //escolha de calculadora
            Console.WriteLine("\nDigite o número da calculadora desejada: ");
            selecaoCalculadora = int.Parse(Console.ReadLine());
        }

        

}