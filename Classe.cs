  internal class PetShop
    {
        public string diaSemana;
        public int quant_pequnos;
        public int quant_grande;

        public PetShop(string diaSemana, int quant_pequnos, int quant_grande)
        {
            this.diaSemana = diaSemana;
            this.quant_pequnos = quant_pequnos;
            this.quant_grande = quant_grande;
        }
        public string DiaSemana
        {
            get { return diaSemana; }
            set { diaSemana = value; }
        }

        public int Quant_pequenos
        {
            get { return quant_pequnos; }
            set { quant_pequnos = value; }
        }

        public int Quant_grande
        {
            get { return quant_grande; }
            set { quant_grande = value; }
        }
        // Pet Shop Meu Cantinho Feliz
        public double Preco_BanhoMCF(double preco_final)
        {
            double precoGrande = 0, precoPequeno = 0;

            if (DiaSemana == "Segunda-feira" || DiaSemana == "Terça-feira" || DiaSemana == "Quarta-feira" || DiaSemana == "Quinta-feira" || DiaSemana == "Sexta-feira")
            {
                for (int i = 0; i < Quant_pequenos; i++)
                {
                    precoPequeno += 20.00;

                }
                for (int i = 0; i < Quant_grande; i++)
                {
                    precoGrande += 40.00;

                }
                preco_final = precoPequeno + precoGrande;

            }
            // final de semana
            else if (DiaSemana == "Sabado" || DiaSemana == "Domingo")
            {
                precoPequeno = 20.00;
                precoGrande = 40.00;
                double somaP = 0, somaG = 0;
                for (int i = 0; i < Quant_pequenos; i++)
                {
                    somaP = precoPequeno * 1.2;
                }
                for (int i = 0; i < Quant_grande; i++)
                {
                    somaG = precoGrande * 1.2;
                }
                preco_final = somaP + somaG;
            }
            else
            {
                Console.WriteLine("Erro ao digitar o dia.");
            }
            // retorno
            return preco_final;

        }
        // Pet Shop Vai Rex
        public double Preco_BanhoVR(double preco_final)
        {
            double precoGrande = 0, precoPequeno = 0;
            if (DiaSemana == "Segunda-feira" || DiaSemana == "Terça-feira" || DiaSemana == "Quarta-feira" || DiaSemana == "Quinta-feira" || DiaSemana == "Sexta-feira")
            {

                for (int i = 0; i < Quant_pequenos; i++)
                {
                    precoPequeno += 15.00;

                }
                for (int i = 0; i < Quant_grande; i++)
                {
                    precoGrande += 50.00;

                }
                preco_final = precoPequeno + precoGrande;
            }
            // final de semana
            else if (DiaSemana == "Sabado" || DiaSemana == "Domingo")
            {
                for (int i = 0; i < Quant_pequenos; i++)
                {
                    precoPequeno += 20.00;

                }
                for (int i = 0; i < Quant_grande; i++)
                {
                    precoGrande += 55.00;

                }
                preco_final = precoPequeno + precoGrande;

            }
            else
            {
                Console.WriteLine("Erro ao digitar o dia.");
            }
            // retorno
            return preco_final;
        }
        // Pet Shop ChowChawgas
        public double Preco_BanhoCC(double preco_final)
        {
            double precoGrande = 0, precoPequeno = 0;
            if (DiaSemana == "Segunda-feira" || DiaSemana == "Terça-feira" || DiaSemana == "Quarta-feira" || DiaSemana == "Quinta-feira" || DiaSemana == "Sexta-feira")
            {

                precoPequeno = 0; precoGrande = 0;
                for (int i = 0; i < Quant_pequenos; i++)
                {
                    precoPequeno += 30.00;

                }
                for (int i = 0; i < Quant_grande; i++)
                {
                    precoGrande += 45.00;

                }
                preco_final = precoPequeno + precoGrande;
            } // final de semana
            else if (DiaSemana == "Sabado" || DiaSemana == "Domingo")
            {
                for (int i = 0; i < Quant_pequenos; i++)
                {
                    precoPequeno += 30.00;

                }
                for (int i = 0; i < Quant_grande; i++)
                {
                    precoGrande += 45.00;

                }
                preco_final = precoPequeno + precoGrande;

            }
            else
            {
                Console.WriteLine("Erro ao digitar o dia.");
            }
            // retorno
            return preco_final;
        }


    }
