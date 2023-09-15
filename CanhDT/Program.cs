using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanhDT
{
    class Program
    {
        class Graph
        {
            private int V; // Số lượng đỉnh trong đồ thị
            private int[,] adjacencyMatrix; // Ma trận kề
            private List<int> vertices;
            private List<Tuple<int, int>> edges;
            public Graph(int v)
            {
                V = v;
                adjacencyMatrix = new int[v, v];
                vertices = new List<int>();
                edges = new List<Tuple<int, int>>();
                for (int i = 0; i < V; i++)
                {
                    for (int j = 0; j < V; j++)
                    {
                        adjacencyMatrix[i, j] = 0;
                    }
                }
            }
           public Graph()
            {

                vertices = new List<int>();
                edges = new List<Tuple<int, int>>();
            }
          

            // Thêm đỉnh vào đồ thị
            public void AddVertex(int vertex)
            {
                if (!vertices.Contains(vertex))
                {
                    vertices.Add(vertex);
                }
            }

            // Thêm cạnh vào đồ thị
         /*   public void AddEdge(int source, int target)
            {
                if (!vertices.Contains(source) || !vertices.Contains(target))
                {
                    throw new InvalidOperationException("Đỉnh và cạnh không có trong đồ thị");
                }

                edges.Add(new Tuple<int, int>(source, target));
            } */

            // In danh sách đỉnh và cạnh trong đồ thị
            public void PrintGraph()
            {
                Console.WriteLine("Danh sách dinh:");
                foreach (var vertex in vertices)
                {
                    Console.Write(vertex + " ");
                }
                Console.WriteLine("\nDanh sách canh:");
                foreach (var edge in edges)
                {
                    Console.WriteLine(edge.Item1 + " -> " + edge.Item2);
                }
                Console.WriteLine("\n Ma tran ke:");
                {
                    for (int i = 0; i < V; i++)
                    {
                        for (int j = 0; j < V; j++)
                        {
                            Console.Write(adjacencyMatrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            // Thêm cạnh vào đồ thị
            public void AddEdge(int source, int target)
            {
                if (!vertices.Contains(source) || !vertices.Contains(target))
                {
                    throw new InvalidOperationException("Đỉnh và cạnh không có trong đồ thị");
                }

                edges.Add(new Tuple<int, int>(source, target));

                // Cập nhật ma trận kề
                adjacencyMatrix[source, target] = 1;
                // adjacencyMatrix[target, source] = 1; // Đối xứng cho đồ thị vô hướng
            }


        }


        static void Main(string[] args)
        {
           
            // Tạo một đồ thị
            Graph graph = new Graph();
            // Thêm đỉnh vào đồ thị
            graph.AddVertex(3);
            graph.AddVertex(5);
            graph.AddVertex(2);

            // Thêm cạnh vào đồ thị
            graph.AddEdge(3, 2);
            graph.AddEdge(5, 3);
            graph.AddEdge(2, 5);

            // In danh sách đỉnh và cạnh
            graph.PrintGraph();
            Console.ReadLine();

         
        }
    }
}
  
