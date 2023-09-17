using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanhDT
{
    class Program
    {

        // theem canh trong so
        /*  graph.AddEdgeWeight(1, 4, 5);
          Console.WriteLine("\n Ma tran trong so:");
          graph.DisplayWeightMatrix();
          Console.ReadLine();
        */
        /* Console.WriteLine("Nhap vao dinh dau: ");
            int dinhdau =  int.Parse(Console.ReadLine());
            int dinhcuoi = int.Parse(Console.ReadLine());
            int trongso =  int.Parse(Console.ReadLine());
            //graph.AddEdge(dinhdau, dinhdau, trongso);
           */
        /* graph.RemoveEdge(0, 1);
          Console.WriteLine("\n Ma tran ke sau khi xoa canh:");
          graph.DisplayMatrix();
         Console.ReadLine();
           */


        static void Main(string[] args)
        {
            int vertices = 5;  
            Graph graph = new Graph(vertices);
            graph.vertices.Add(0);
            graph.vertices.Add(1);
            graph.vertices.Add(4);
            graph.vertices.Add(5);
            graph.vertices.Add(6);
            Console.WriteLine("Ma tran ke ban dau:");
            graph.DisplayMatrix();

        /*----------------    // Thêm cạnh    --------------*/
           
            graph.AddEdge(0, 5, 3);
            graph.AddEdge(0, 4, 3);
            graph.AddEdge(1, 5, 3);
            graph.AddEdge(1, 4, 5);
            graph.AddEdge(5, 6, 3);
            Console.WriteLine("\n Ma tran ke sau khi them canh:");
            graph.DisplayMatrix();

        /*---------------------   // Sua trong so   -------------------*/

            graph.UpdateCanh(1, 4, 7);
            Console.WriteLine("\n Ma tran sau khi Update trong so");
            graph.DisplayMatrix();
            Console.ReadLine();


        /*----------------    // Thêm cạnh random vao đồ thị    --------------*/

            graph.RandomCanh(graph, 2);
            Console.WriteLine("\n Ma tran ke sau khi Random canh:");
            graph.DisplayMatrix();
            Console.ReadLine();

        /*---------------- // Xoa -----------------------*/

            graph.RemoveEdge(0, 1);
            Console.WriteLine("\n Ma tran ke sau khi xoa canh:");
            graph.DisplayMatrix();
            Console.ReadLine();

        }
    }
}
  
