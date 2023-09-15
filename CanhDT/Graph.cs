using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanhDT
{
    class Graph
    {
        public  int sldinh { get; private set; }
        private int[,] adjacencyMatrix;

        public Graph(int sldinh)
        {
            this.sldinh = sldinh;
            adjacencyMatrix = new int[sldinh, sldinh];
        }

        public void AddEdge(int dinhdau, int dinhden)
        {
            if (dinhdau >= 0 && dinhdau < sldinh && dinhden >= 0 && dinhden < sldinh)
            {
                adjacencyMatrix[dinhdau, dinhden] = 1;
                adjacencyMatrix[dinhden, dinhdau] = 1; // Đối xứng cho đồ thị vô hướng
            }
            else
            {
                Console.WriteLine("Dinh nguon hoac dinh dich khong hop le.");
            }
        }
        public void RemoveEdge(int dinhdau, int dinhden)
        {
            adjacencyMatrix[dinhdau, dinhden] = 0;
            adjacencyMatrix[dinhden, dinhdau] = 0; // Đối với đồ thị vô hướng
        }

        public void DisplayMatrix()
        {
            Console.WriteLine("Ma tran ke:");
            for (int i = 0; i < sldinh; i++)
            {
                for (int j = 0; j < sldinh; j++)
                {
                    Console.Write(adjacencyMatrix[i, j] + "\t");
                    
                }
                Console.WriteLine();
            }
        }
    }

}
