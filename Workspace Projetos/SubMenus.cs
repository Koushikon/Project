using System;
using System.IO;
using System.Text;
using System.Threading;

namespace Workspace_Projetos
{
    public static class SubMenus
    {
        #region MenuInvestidor()
        public static bool MenuInvestidor(Investidor investidor)
        {
            Console.Clear();
            Console.WriteLine("MENU INVESTIDOR:\n");
            Console.WriteLine("1. Depositar.");
            Console.WriteLine("2. Comprar Moeda.");
            Console.WriteLine("3. Vender Moeda.");
            Console.WriteLine("4. Mostrar Portfolio.");
            Console.WriteLine("5. Mostrar Cambio.");
            Console.WriteLine("6. Sair.");
            Console.Write("\r\nSelecione uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    double totalDepositado = investidor.Depositar();
                    Console.WriteLine($"Depositou {totalDepositado}. Tem agora: {investidor.EurosDepositados}");
                    
                    Thread.Sleep(5000);

                    return true;
                case "2":
                    double totalComprado = investidor.ComprarMoeda();
                    Console.WriteLine($"Comprou {totalComprado}. Tem agora: {investidor.EurosDepositados}");
                    
                    Thread.Sleep(5000);

                    return true;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Opção selecionada 3");
                    return true;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Opção selecionada 4");
                    return true;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Opção selecionada 5");
                    return true;
                case "6":
                    return false;
                default:
                    return true;
            }
        }
        #endregion

        #region MenuAdministrador
        public static bool MenuAdministrador()
        {
            Console.Clear();
            Console.WriteLine("MENU ADMINISTRADOR:\n");
            Console.WriteLine("1 Adicionar Moeda");
            Console.WriteLine("2 Remover Moeda");
            Console.WriteLine("3 Ver Relatorio Comissoes");
            Console.WriteLine("4 Sair");
            Console.Write("\r\nSelecione uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("\r\nInserir Moeda - TUGA, CHOW, GALLO, DOCE.");
                    //AddCoin(Console.ReadLine());
                    return true;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Opção selecionada 2.");
                    return true;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Opção selecionada 3.");
                    return true;
                case "4":
                    return false;
                default:
                    return true;
            }
        }
        #endregion

        #region Moeda MenuTipoMoeda
        public static Moeda MenuTipoMoeda()
        {
            Console.WriteLine("ESCOLHA A MOEDA:\n");
            Console.WriteLine("1. TUGA.");
            Console.WriteLine("2. CHOW.");
            Console.WriteLine("3. GALLO.");
            Console.WriteLine("4. DOCE.");
            Console.Write("\r\nSelecione uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    return Moeda.TUGA;
                case "2":
                    return Moeda.CHOW;
                case "3":
                    return Moeda.GALO;
                case "4":
                    return Moeda.DOCE;
                default:
                    Console.WriteLine("Escolha uma opção válida.");
                    return Moeda.UNKNOWN;
            }
        }
        #endregion
    }
}