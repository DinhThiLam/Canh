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
            // Tìm chỉ số (index) của đỉnh đầu và đỉnh đích trong danh sách đỉnh
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


        public void RandomCanh(Graph graph , int canh)

        {
                Random random = new Random();  // 
            for (int i = 0; i < sldinh; i++)  // Số cạnh ngẫu nhiên
            {
                int dinhDau = random.Next(graph.sldinh);  // Lựa chọn ngẫu nhiên một đỉnh đầu
                int dinhDen = random.Next(graph.sldinh); // Lựa chọn ngẫu nhiên một đỉnh đích
                int trongSo = random.Next(1, 11);       // Trọng số ngẫu nhiên từ 1 đến 10
                graph.AddEdge(dinhDau, dinhDen, trongSo);
            }

        }

        
        public void UpdateCanh(int dinhdau, int dinhden, int trongsomoi)
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
            if(dinhDauIndex != -1 && dinhDenIndex != -1)
            {
                adjacencyMatrix[dinhDauIndex, dinhDenIndex] = trongsomoi;
            }
            else
            {
                Console.WriteLine("Dinh nguon hoac dinh dich khong hop le.");
            }
        }

        
        public void RemoveEdge(int dinhdau, int dinhden)
        {
            int dinhDauIndex = -1;
            int dinhDenIndex = -1;
            // Tìm chỉ số (index) của đỉnh đầu và đỉnh đích trong danh sách đỉnh
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
                adjacencyMatrix[dinhDauIndex, dinhDenIndex] = 0;
                // adjacencyMatrix[dinhDenIndex, dinhDauIndex] = trongso; // Đối xứng cho đồ thị vô hướng
            }
            else
            {
                Console.WriteLine("Dinh nguon hoac dinh dich khong hop le.");
            }
           
        }


        
        public void DisplayMatrix()
        {
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
