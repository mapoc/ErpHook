using MarketAmerica.ErpHook.ConsoleProgram.ErpService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAmerica.ErpHook.ConsoleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ErpHookClient();


            var xmlMessage = @"<invoice>
                <carton>
                    <lineItemList>
                        <lotNumber>1</lotNumber>
                        <pickedUser>shafeekv</pickedUser>
                        <quantity>10</quantity>
                    </lineItemList>
                    <lineItemList>
                        <lotNumber>2</lotNumber>
                        <pickedUser>michael.zhang</pickedUser>
                        <quantity>3</quantity>
                    </lineItemList>
                </carton>
                </invoice>";



            var response = client.setErpData(xmlMessage);

            Console.WriteLine("Response Status: " + response.status);
            Console.ReadLine();
        }
    }
}
