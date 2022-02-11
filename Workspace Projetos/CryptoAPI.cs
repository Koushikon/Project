using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace Workspace_Projetos
{    
    public class CyptoAPI
    //esta classe estará sempre pública para que possa ser chamada e usada sempre que precisarmos; assim como será a conexão para todo o restante desenvolvimento das acções pretendidas
    {
        public CyptoAPI()
        {

        }

        //Permite adicionar uma nova criptomoeda no sistema da corretora;
        public void AddCoin(string coin)
        {            
            Console.WriteLine("Implementação em curso!!!!");
            Thread.Sleep(10000);
        }

        //devolde lista de todas as moedas geridas pela corretora;
        public void GetCoin()
        {            
            Console.WriteLine("Implementação em curso!!!!");
            Thread.Sleep(10000);            
        }

        //Retira criptomoeda do sistema de cotações
        public void RemoveCoin(string coin)
        {
            Console.WriteLine("Implementação em curso!!!!");
            Thread.Sleep(10000);
        }

        public void GetPrices(out decimal[] prices, out string[] coins)
        {
            prices = null;
            coins = null;
            Console.WriteLine("Implementação em curso!!!!");
            Thread.Sleep(10000);
        }

        public void DefinePriceUpdateInSeconds(int seconds)
        {
            Console.WriteLine("Implementação em curso!!!!");
            Thread.Sleep(10000);
        }

        public int GetPriceUpdateInSeconds()
        {
            Console.WriteLine("Implementação em curso!!!!");
            Thread.Sleep(10000);
            return default(int);
        }

        public void Save()
        {
            Console.WriteLine("Implementação em curso!!!!");
            Thread.Sleep(10000);
        }

        public void Read()
        {
            Console.WriteLine("Implementação em curso!!!!");
            Thread.Sleep(10000);
        }    
    }
}