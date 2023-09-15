using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanhDT
{
    class Graph
    {
        private int numVertices;
        private int[,] adjacencyMatrix;

        public Graph(int numVertices)
        {
            this.numVertices = numVertices;
            adjacencyMatrix = new int[numVertices, numVertices];
        }

        public void AddEdge(int source, int destination)
        {
            if (source >= 0 && source < numVertices && destination >= 0 && destination < numVertices)
            {
                adjacencyMatrix[source, destination] = 1;
                adjacencyMatrix[destination, source] = 1; // Đối xứng cho đồ thị vô hướng
            }
            else
            {
                Console.WriteLine("Dinh nguon hoac dinh dich khong hop le.");
            }
        }

        public void DisplayMatrix()
        {
            Console.WriteLine("Ma tran ke:");
            for (int i = 0; i < numVertices; i++)
            {
                for (int j = 0; j < numVertices; j++)
                {
                    Console.Write(adjacencyMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}
