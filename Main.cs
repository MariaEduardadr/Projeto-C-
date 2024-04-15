  static void Main(string[] args)
        {
            string data, nomec1 = "Meu Cantinho Feliz", nomec2 = "Vai Rex", nomec3 = "ChowChawgas";
            double MeuCantinhoFeliz, VaiRex, ChowChawgas, preco_final = 0;
            double distanciac1 = 2, distanciac2 = 1.7, distanciac3 = 800;
            int quant_pequnos, quant_grande;

            Console.WriteLine("Digite o dia para marcar o banho do seu pet (segunda a domingo):");
            data = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de raças pequenas:");
            quant_pequnos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de raças grandes:");
            quant_grande = int.Parse(Console.ReadLine());

            PetShop c1 = new PetShop(data, quant_pequnos, quant_grande);
            PetShop c2 = new PetShop(data, quant_pequnos, quant_grande);
            PetShop c3 = new PetShop(data, quant_pequnos, quant_grande);

            MeuCantinhoFeliz = c1.Preco_BanhoMCF(preco_final);
            VaiRex = c2.Preco_BanhoVR(preco_final);
            ChowChawgas = c3.Preco_BanhoCC(preco_final);

            if (MeuCantinhoFeliz <= VaiRex && MeuCantinhoFeliz <= ChowChawgas)
            {
                Console.WriteLine($"O melhor PetShop para o canil é o {nomec1} localizado a {distanciac1}km com preço R${MeuCantinhoFeliz}");
            }
            else if (VaiRex <= MeuCantinhoFeliz && VaiRex <= ChowChawgas)
            {
                Console.WriteLine($"O melhor PetShop para o canil é o {nomec2} localizado a {distanciac2}km com preço R${VaiRex}");
            }
            else if (ChowChawgas <= VaiRex && ChowChawgas <= MeuCantinhoFeliz)
            {
                Console.WriteLine($"O melhor PetShop para o canil é o {nomec3} localizado a {distanciac3}km com preço R${ChowChawgas}");
            }
            // empate
            else
            {
                if (MeuCantinhoFeliz == VaiRex && distanciac1 <= distanciac2 && distanciac1 <= distanciac3)
                {
                    Console.WriteLine("Empate!!");
                    Console.WriteLine($"O melhor PetShop para o canil é o {nomec1} localizado a {distanciac1}km com preço R${MeuCantinhoFeliz}");
                }
                else if (VaiRex == ChowChawgas && distanciac2 <= distanciac1 && distanciac2 <= distanciac3)
                {
                    Console.WriteLine("Empate!!");
                    Console.WriteLine($"O melhor PetShop para o canil é o {nomec2} localizado a {distanciac2}km com preço R${VaiRex}");
                }
                else if (ChowChawgas == MeuCantinhoFeliz && distanciac3 <= distanciac1 && distanciac3 <= distanciac2)
                {
                    Console.WriteLine("Empate!!");
                    Console.WriteLine($"O melhor PetShop para o canil é o {nomec3} localizado a {distanciac3}km com preço R${ChowChawgas}");
                }
                else
                {
                    Console.WriteLine("Empate!!");
                    Console.WriteLine($"O melhor PetShop para o canil é o {nomec1} localizado a {distanciac1}km com preço R${MeuCantinhoFeliz}");
                }

            }



            Console.ReadLine();
        }
