using System;
using System.IO; //InheritanceObject → File
using System.Text;

namespace Workspace_Projetos
{
    class Program
    {
        private static readonly Investidor _investidor = new Investidor();

        static void Main(string[] args)
        {          
            string pathFileInvestidor = "investidor.txt"; //ficheiro txt criado para a class Investidor 

            if(File.Exists(pathFileInvestidor))
            {
                string fileContent = File.ReadAllText(pathFileInvestidor);
                double valueFromFile;
                if (double.TryParse(fileContent, out valueFromFile))
                {
                    _investidor.EurosDepositados = valueFromFile;
                }
            }

            //TODO iniciar a simulação
            /*
            verificar se já há ficheiro de cambios
            verificar se já há ficheiro com informação do investidor
            Acho q o Admin tb terá q ter um fich com valores das comissões

            Não havendo info persistida a simulação deverá começar com:
            Investidor - 0 em caixa e 0 moedas
            Admin - 0 comissões
            Mercado - todas as moedas deverão iniciar com cotação 1 EUR
                    - nenhuma moeda no mercado pois o Admin é que adiciona e remove moedas
            
            de n em n segundos sao atualizados os preços com uma iteração maxima de +/-0.5%
             */

            //TODO start the simulation
            /*
            check if there is already an exchange file
            check if there is already a file with investor information
            I think the Admin will also have to have a file with commission values

            If there is no persisted info, the simulation should start with:
            Investor - 0 in cash and 0 coins
            Admin - 0 commissions
            Market - all currencies must start with a quote of 1 EUR
                    - no coins on the market as the Admin adds and removes coins
            
            every n seconds the prices are updated with a maximum iteration of +/-0.5%
             */

            //#region - visa diminuir visualmente o código e deixá-lo agrupado por tipo de execução, por exemplo: Eventos, Funções e Métodos, Construtores, Enumeradores, Variáveis, etc. Para programas que possui inúmeras linhas de códigos dentro de classes, este recurso ajuda a melhor dividir o código. Deve começar com #region e terminar com #endregion


            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        #region MainMenu();
        public static bool MainMenu()
        {
            bool showMenuInvestidor = false;
            bool showMenuAdministrador = false; 
            Console.Clear();
            Console.WriteLine("A. Sou Investidor.");
            Console.WriteLine("B. Sou Administrador.");
            Console.WriteLine("C. Sair.");
            Console.Write("\r\nSelecione uma opção: ");
            

            switch (Console.ReadLine())
            {
                case "A":
                    Console.Clear();
                    showMenuInvestidor = true;
                    while(showMenuInvestidor)
                    {
                        showMenuInvestidor = SubMenus.MenuInvestidor(_investidor);
                    }
                    return true;
                case "B":
                    Console.Clear();
                    showMenuAdministrador = true;
                    while(showMenuInvestidor)
                    {
                        showMenuAdministrador = SubMenus.MenuAdministrador();
                    }
                    return true;
                case "C":
                    return false;                    
                default:
                    return true;                    
            }            
        }        
        #endregion
    }    
}
