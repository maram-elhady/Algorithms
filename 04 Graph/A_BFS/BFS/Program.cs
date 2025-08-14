using System;
using System.Collections.Generic;

public class Node
{
    public char Data { get; set; }

    public Node(char data)
    {
        Data = data;
    }
}

public class Graph
{
    private List<Node> nodes;
    private int[,] matrix;

    public Graph(int size)
    {
        nodes = new List<Node>();
        matrix = new int[size, size];
    }

    public void AddNode(Node node)
    {
        nodes.Add(node);
    }

    public void AddEdge(int src, int dst)
    {
        matrix[src, dst] = 1;
    }

    public bool CheckEdge(int src, int dst)
    {
        return matrix[src, dst] == 1;
    }

    public void Print()
    {
        Console.Write("  ");
        foreach (Node node in nodes)
        {
            Console.Write(node.Data + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write(nodes[i].Data + " ");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public void BreadthFirstSearch(int src)
    {
        Queue<int> queue = new Queue<int>();
        bool[] visited = new bool[matrix.GetLength(0)];

        queue.Enqueue(src);
        visited[src] = true;

        while (queue.Count != 0)
        {
            src = queue.Dequeue();
            Console.WriteLine(nodes[src].Data + " = visited");

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (matrix[src, i] == 1 && !visited[i])
                {
                    queue.Enqueue(i);
                    visited[i] = true;
                }
            }
        }
    }
}

public class Program
{
    public static void Main()
    {
        // Breadth FS = Traverse a graph level by level
        //              Utilizes a Queue
        //              Better if destination is on average close to start
        //              Siblings are visited before children

        // Depth FS   = Traverse a graph branch by branch
        //              Utilizes a Stack
        //              Better if destination is on average far from the start
        //              Children are visited before siblings
        //              More popular for games/puzzles

        Graph graph = new Graph(5);

        graph.AddNode(new Node('A'));
        graph.AddNode(new Node('B'));
        graph.AddNode(new Node('C'));
        graph.AddNode(new Node('D'));
        graph.AddNode(new Node('E'));

        graph.AddEdge(0, 1);
        graph.AddEdge(1, 2);
        graph.AddEdge(1, 4);
        graph.AddEdge(2, 3);
        graph.AddEdge(2, 4);
        graph.AddEdge(4, 0);
        graph.AddEdge(4, 2);

        graph.Print();

        graph.BreadthFirstSearch(2);
    }
}
