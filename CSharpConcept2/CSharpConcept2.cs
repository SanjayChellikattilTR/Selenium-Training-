using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThomsonReuters.Formulae;

namespace CSharpConcept2
{
    public class CSharpConcept2
    {
        static void Main(string[] args)
        {


            int radius = 10;
            double a = 3.14;
            double area = a * radius * radius;
            Console.WriteLine(area);
        }


        String name = Area.GetAuthorName();
        Area obj = new Area();
        double output = obj.areaOfTriangle(10,2);
        Console.Writeline(output);



    }
}
