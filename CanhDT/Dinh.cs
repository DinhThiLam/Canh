using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanhDT
{
    class Dinh
    {
        public int n { get; private set; }
        public int[,] weights { get; private set; }
        public List<int> vertices { get; private set; }


        public Dinh()
        {
            n = 0;
            weights = new int[n, n];
            vertices = new List<int>();
        }

        public Dinh(int n)
        {
            this.n = n;
            weights = new int[n, n];
            vertices = new List<int>();
        }

        public int this[int u, int v]
        {
            get { return weights[u, v]; }
            set { weights[u, v] = value; }
        }

        private int[,] IncreaseArraySize()
        {
            int[,] newArray = new int[n + 1, n + 1];

            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                    newArray[i, j] = weights[i, j];

            for (int i = 0; i < n + 1; ++i)
            {
                newArray[i, n] = 0;
                newArray[n, i] = 0;
            }

            return newArray;
        }

        public void AddVertex(int vertexName)
        {
            weights = IncreaseArraySize();

            vertices.Add(vertexName);
            ++n;
        }

        private bool IsVertext(int vertextName)
        {
            for (int i = 0; i < n; i++)
            {
                if (vertices[i] == vertextName)
                    return true;

            }
            return false;
        }
        private int getIndexFromVertextName(int vertextName)
        {
            for (int i = 0; i < n; i++)
                if (vertices[i] == vertextName) return i;
            return -1;

        }

        private int[,] ReduseArraySize(int index)
        {
            int[,] newArray = new int[n - 1, n - 1];
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - 1; j++)
                {
                    if (i < index && j >= index) newArray[i, j] = weights[i, j + 1];
                    else if (i >= index && j < index)
                        newArray[i, j] = weights[(i + 1), j];
                    else if (i >= index && j >= index) newArray[i, j] = weights[(i + 1), (j + 1)];
                    else newArray[i, j] = weights[i, j];
                }
            return newArray;
        }



        public void RemoveVertex(int vertexName)
        {
            // kiem tra xem ten dinh con ton tai khong
            if (!IsVertext(vertexName))
            {
                Console.Write("\n Verter khong ton tai!");
                return;
            }
            else
            {
                int index = getIndexFromVertextName(vertexName);
                if (index != -1)
                {
                    vertices.RemoveAt(index);
                    weights = ReduseArraySize(index);
                    n--;
                }
            }
        }




        public void DisplayMatrix()
        {
            Console.WriteLine("Ma tran");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(weights[i, j] + "\t");

                Console.WriteLine();
            }
        }

        public void DisplayVertices()
        {
            Console.WriteLine("Danh sach ten dinh");

            foreach (int i in vertices)
                Console.Write(i + "\t");

            Console.WriteLine();
        }



    }
}
