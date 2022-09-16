using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class DataType1: IDataAccess
    {
        public void ProvideData()
        {
            Console.WriteLine("Data type 1 is here.");
        }
    }
}
