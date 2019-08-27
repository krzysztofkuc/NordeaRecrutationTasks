using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;
using Task1.Model;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            #region IOC initialization

            var builder = new ContainerBuilder();
            builder.RegisterType<DataSource>().As<IDataSource>();
            var container = builder.Build();
            var source =  container.Resolve<IDataSource>();

            #endregion IOC initialization

            var calc = new Calculation(source);

            //ToArray() because has fastest iteration
            var corelation = calc.GetProductWithPosition().ToArray();

            //Sb to save time for concatenation string
            StringBuilder sb = new StringBuilder();

            for (int i=0; i< corelation.Count(); i++ )
            {
                string str = $"{i}. Date: {corelation[i].Position.Date}, Price: {corelation[i].Price.Value}, Market Value {corelation[i].MarketValue} ";
                sb.AppendLine(str);
            }

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
