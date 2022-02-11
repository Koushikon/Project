using System;
using System.IO; //InheritanceObject → File
using System.Text;

namespace Workspace_Projetos
{
    public class Investidor
    {
        public double EurosDepositados { get; set; }
        public int TotalCHOW { get; set; }
        public int TotalDOCE { get; set; }
        public int TotalGALO { get; set; }
        public int TotalTUGA { get; set; }

        public Investidor()
        {
            EurosDepositados = 0;
            TotalCHOW = 0;
            TotalDOCE = 0;
            TotalGALO = 0;
            TotalTUGA = 0;
        }

        private void SaveInvestidor()
        {
            //métodos estáticos para gravar um texto num arquivo; abre e fecha o arquivo automaticamente
            File.WriteAllText("investidor.txt", $"{EurosDepositados}");
        }

        //TODO
        ////In here the first thing to do show be the amount available at the moment the user access
        public double Depositar()
        {
            //This is the deposit part
            double totalDepositar;            
                        
            Console.OutputEncoding = Encoding.UTF8; //Shows € symbol
            Console.WriteLine($"\r\nSelecione o montante a depositar, em Euros/€."); //"Select the amount to deposit in €"
            if (!double.TryParse(Console.ReadLine(), out totalDepositar))
            {
                Console.WriteLine("Por favor insira um valor válido."); //"Please insert a valid amount"
            }

            this.EurosDepositados += totalDepositar;
            SaveInvestidor();

            return totalDepositar;
        }

        //This is the buy coin part
        public int ComprarMoeda()
        {
            int totalComprar;

            //chamar de entre a lista de Moedas enumeradas na classe eNum
            Moeda tipomoedaSelecionada = SubMenus.MenuTipoMoeda();
            if(tipomoedaSelecionada == Moeda.UNKNOWN) return 0;

            Console.WriteLine($"\r\nSelecione o montante a comprar de {tipomoedaSelecionada}: ");
            if(!int.TryParse(Console.ReadLine(), out totalComprar))
            {
                Console.WriteLine($"Por favor insira unidades válidas de {tipomoedaSelecionada} a comprar:");
            }

            //TODO
            ////validar se há suficiente numero de moedas no mercado e descontar valores em caixa consoante o preço na simulação
            ///Show if there's enough amount of coins in investor's account e discount the value in the total amount regarding the price in DefinePriceUpdateInSeconds
            switch(tipomoedaSelecionada){
                 case Moeda.CHOW:
                    this.TotalCHOW += totalComprar;
                    break;
                case Moeda.DOCE:
                    this.TotalDOCE += totalComprar;
                    break;
                case Moeda.GALO:
                    this.TotalGALO += totalComprar;
                    break;
                case Moeda.TUGA:
                    this.TotalTUGA += totalComprar;
                    break;
            }

            return totalComprar;
        }

        //Here is the SellCoin Part (which user Investor can only sell coins that he has availabe
        //Not working yet
        public int VenderMoeda()
        {
            int totalVender;
            
            Moeda tipomoedaSelecionada = SubMenus.MenuTipoMoeda();
            if (tipomoedaSelecionada == Moeda.UNKNOWN) return 0;

            Console.WriteLine($"\r\nSelecione o montante a vender de {tipomoedaSelecionada}:");
            if (!int.TryParse(Console.ReadLine(), out totalVender))
            {
                Console.WriteLine($"Por favor insira unidades válidas de {tipomoedaSelecionada} a vender:");
            }
                        
            switch (tipomoedaSelecionada)
            {
                case Moeda.CHOW:
                    this.TotalCHOW += totalVender;
                    break;
                case Moeda.DOCE:
                    this.TotalDOCE += totalVender;
                    break;
                case Moeda.GALO:
                    this.TotalGALO += totalVender;
                    break;
                case Moeda.TUGA:
                    this.TotalTUGA += totalVender;
                    break;
            }

            return totalVender;
        }
    }
}