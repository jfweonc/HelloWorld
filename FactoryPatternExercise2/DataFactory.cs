using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class DataFactory
    {
        public static IDataAccess CreatDatabase()
        {
            if (Console.ReadLine() == "Type1")
            {
                return new DataType1(); 
            } else if (Console.ReadLine() == "Type2")
            {
                return new DataType2(); 
            } else { return new DataType2(); }
        }
    }
}
