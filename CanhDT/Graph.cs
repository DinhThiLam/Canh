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
        private int[,] weightMatrix; // Ma trận trọng số
        public List<int> vertices { get; private set; }


        public Graph(int sldinh)
        {
            this.sldinh = sldinh;
            adjacencyMatrix = new int[sldinh, sldinh];
            weightMatrix = new int[sldinh, sldinh];
            vertices = new List<int>();
        }
     /*   private bool IsVertext(int vertextName) // check trung
        {
            for (int i = 0; i < sldinh; i++)
            {
                if (vertices[i] == vertextName)
                    return true;

            }
            return false;
        }
        private int getIndexFromVertextName(int vertextName) // tra dia chi de biet noi canh
        {
            for (int i = 0; i < sldinh; i++)
                if (vertices[i] == vertextName) return i;
            return -1;

        }   */
        public void AddEdgeWeight(int dinhdau, int dinhden, int trongso)
        {
            if (dinhdau >= 0 && dinhdau < sldinh && dinhden >= 0 && dinhden < sldinh)
            {
                weightMatrix[dinhdau, dinhden] = trongso;
                weightMatrix[dinhden, dinhdau] = trongso; // Đối xứng cho đồ thị vô hướng
            }
            else
            {
                Console.WriteLine("Dinh nguon hoac dinh dich khong hop le.");
            }
        }
        
        public void AddEdge(int dinhdau, int dinhden, int trongso )
        {
            int dinhDauIndex = -1;
            int dinhDenIndex = -1;
            for (int i = 0; i < sldinh; i++)
            {
                if (vertices[i] == dinhdau)
                {
                    dinhDauIndex = i;
                }

                if (vertices[i] == dinhden)
                {
                    dinhDenIndex = i;
                }
            }
            if (dinhDauIndex != -1 && dinhDenIndex != -1)
            {
                adjacencyMatrix[dinhDauIndex, dinhDenIndex] = trongso;
               // adjacencyMatrix[dinhDenIndex, dinhDauIndex] = trongso; // Đối xứng cho đồ thị vô hướng
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
        
        public void DisplayWeightMatrix()
        {
            Console.WriteLine("Ma tran trong so:");
            for (int i = 0; i < sldinh; i++)
            {
                for (int j = 0; j < sldinh; j++)
                {
                    Console.Write(weightMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }

}
