using Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsWPF;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solutions
{
    public class BasicGraphImplementation
    {
        public void Execute()
        {
            //BFS();

            DFS();
        }

        private void DFS()
        {
            int v = 7;

            ArrayList[] graph = new ArrayList[v];

            CreateGraph(graph);

            bool[] visited = new bool[v];

            PerformDFS(graph, visited, 0);

            // https://youtu.be/59fUtYYz7ZU?si=gQ1KdWTDmfgbEVxx&t=5830
        }

        private void BFS()
        {
            int v = 7;

            ArrayList[] graph = new ArrayList[v];

            CreateGraph(graph);

            bool[] visited = new bool[v];

            for (int i = 0; i < v; i++)
            {
                if (visited[i] == false)
                {
                    PerformBFS(graph, v, visited, i);
                }
            }
        }

        private void PerformDFS(ArrayList[] graph, bool[] visited, int currentNode)
        {
            if (visited[currentNode] == false)
            {
                Console.Write($"{currentNode} ");

                visited[currentNode] = true;

                for (int i = 0; i < graph[currentNode].Count; i++)
                {
                    var edge = (Edge)graph[currentNode][i];
                    PerformDFS(graph, visited, edge.Destinattion);
                }
            }
        }

        private void PerformBFS(ArrayList[] graph, int v, bool[] visited, int start)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(start);

            while (queue.Count != 0)
            {
                var currentNode = queue.Dequeue();

                if (visited[currentNode] == false)
                {
                    //1. Print the node 2. mark visited as true 3. Enqueue the neighbours

                    Console.Write($"{currentNode} "); //1
                    visited[currentNode] = true; // 2

                    // 3
                    for (int i = 0; i < graph[currentNode].Count; i++)
                    {
                        Edge e = (Edge)graph[currentNode][i];

                        queue.Enqueue(e.Destinattion);
                    }
                }
            }
        }

        public void CreateGraph(ArrayList[] graph)
        {
            for (int i = 0; i < graph.Length; i++)
            {
                graph[i] = new ArrayList();
            }

            graph[0].Add(new Edge(0, 1));
            graph[0].Add(new Edge(0, 2));
            graph[1].Add(new Edge(1, 0));
            graph[1].Add(new Edge(1, 3));
            graph[2].Add(new Edge(2, 0));
            graph[2].Add(new Edge(2, 4));
            graph[3].Add(new Edge(3, 1));
            graph[3].Add(new Edge(3, 4));
            graph[3].Add(new Edge(3, 5));
            graph[4].Add(new Edge(4, 2));
            graph[4].Add(new Edge(4, 5));
            graph[5].Add(new Edge(5, 3));
            graph[5].Add(new Edge(5, 4));
            graph[5].Add(new Edge(5, 6));
            graph[6].Add(new Edge(6, 5));
        }
    }

    class Edge
    {
        public int Source { get; set; }
        public int Destinattion { get; set; }

        public Edge(int _source, int _destination)
        {
            Source = _source;
            Destinattion = _destination;
        }
    }
}
