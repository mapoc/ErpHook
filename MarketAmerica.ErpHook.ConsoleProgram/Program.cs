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
            erpHookRequest request = new erpHookRequest()
            {
                invoice = new invoice()
                {
                    carton = new carton()
                    {
                        cartonNumber = "01",
                        lineItemList = new lineItem[] 
                                        { 
                                            new lineItem()
                                            {
                                                quantity = 10
                                            },
                                            new lineItem()
                                            {
                                                pickedUser = "001"
                                            }
                                        }
                    }


                }
            };

            var response = client.setErpData(request);

            Console.WriteLine("Response Status: " + response.status);
            Console.ReadLine();
        }
    }
}
