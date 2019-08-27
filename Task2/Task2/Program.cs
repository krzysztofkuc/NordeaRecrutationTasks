using System;
using System.Linq;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        #region GetPrices Methods

        static private async Task<Price[]> GetPricesFromWebService1()
        {
            await Task.Delay(5000);

            var p = new Price() { Date =  DateTime.Now.Date, ProductKey =  "0", Value = 2.0 };

            return new Price[] { p };
        }
        static public async Task<Price[]> GetPricesFromWebService2()
        {
            await Task.Delay(7000);

            var p = new Price() { Date = DateTime.Now.Date.AddDays(1).Date, ProductKey = "0-1-2-3", Value = 11.0 };

            return new Price[] { p };
        }

        static public async Task<Price[]> GetPricesFromWebService3()
        {
            await Task.Delay(10000);

            var p = new Price() { Date = DateTime.Now.Date.AddDays(1).Date, ProductKey = "0-1-2-3", Value = 12.0 };

            return new Price[] { p };
        }

        #endregion GetPrices Methods


        static void Main(string[] args)
        {
            Task t = MainAsync(args);
            t.Wait();
        }

        static async Task MainAsync(string[] args)
        {
            var tasks = await Task.WhenAll(Task.Run(() => GetPricesFromWebService1()),
                                            Task.Run(() => GetPricesFromWebService2()),
                                            Task.Run(() => GetPricesFromWebService3()));

            var result = tasks.SelectMany(r => r).Distinct().ToArray();

            //Result should contains 2 Prices objects instead of 3
            foreach (var item in result)
            {
                Console.WriteLine($"Date: {item.Date}, ProductKey: {item.ProductKey}, Value: {item.Value}");
            }

            Console.ReadKey();

        }
    }
}
