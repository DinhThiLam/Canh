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

            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 4);

            Console.WriteLine("Ma tran ke ban dau:");
            graph.DisplayMatrix();
            // Thêm cạnh
            graph.AddEdge(3, 4);

            Console.WriteLine("\n Ma tran ke sau khi them canh:");
            graph.DisplayMatrix();

            // Xóa cạnh giữa đỉnh 0 và 1
            graph.RemoveEdge(0, 1);

            Console.WriteLine("\n Ma tran ke sau khi xoa canh:");
            graph.DisplayMatrix();
            Console.ReadLine();
        }
    }
}
  
