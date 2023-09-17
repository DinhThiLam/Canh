using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanhDT
{
    class Program
    {
        


        static void Main(string[] args)
        {
            int vertices = 5; // Số lượng đỉnh trong đồ thị
            Graph graph = new Graph(vertices);

            graph.vertices.Add(0);
            graph.vertices.Add(1);
            graph.vertices.Add(4);
            graph.vertices.Add(5);
            graph.vertices.Add(6);
            Console.WriteLine("Ma tran ke ban dau:");
            graph.DisplayMatrix();

            // theem canh trong so
            /*  graph.AddEdgeWeight(1, 4, 5);
              Console.WriteLine("\n Ma tran trong so:");
              graph.DisplayWeightMatrix();
              Console.ReadLine();
            */
            // Thêm cạnh
           /* Console.WriteLine("Nhap vao dinh dau: ");
            int dinhdau =  int.Parse(Console.ReadLine());
            int dinhcuoi = int.Parse(Console.ReadLine());
            int trongso =  int.Parse(Console.ReadLine());
            //graph.AddEdge(dinhdau, dinhdau, trongso);
           */
            graph.AddEdge(0, 2, 3);
            graph.AddEdge(0, 4, 3);
            graph.AddEdge(1, 5, 3);
            graph.AddEdge(1, 4, 5);
            graph.AddEdge(5, 6, 3);
            Console.WriteLine("\n Ma tran ke sau khi them canh:");
            graph.DisplayMatrix();

            // Xóa cạnh giữa đỉnh 0 và 1
            graph.RemoveEdge(0, 1);

            Console.WriteLine("\n Ma tran ke sau khi xoa canh:");
            graph.DisplayMatrix();
            Console.ReadLine();
            // theem canh trong so
           
        }
    }
}
  
