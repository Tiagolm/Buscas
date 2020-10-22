using System;
using System.Collections.Generic;
using static Node;

namespace Buscas
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            Grafo grafo = new();
            Node A = new(Letter.A, 223, 0);
            Node B = new(Letter.B, 222, 0);
            Node C = new(Letter.C, 166, 0);
            Node D = new(Letter.D, 192, 0);
            Node E = new(Letter.E, 165, 0);
            Node F = new(Letter.F, 136, 0);
            Node G = new(Letter.G, 122, 0);
            Node H = new(Letter.H, 111, 0);
            Node I = new(Letter.I, 100, 0);
            Node J = new(Letter.J, 60, 0);
            Node K = new(Letter.K, 32, 0);
            Node L = new(Letter.L, 102, 0);
            Node M = new(Letter.M, 0, 0);

            List<Node> nodes = new(){A, B, C, D, E, F, G, H, I, J, K, L, M};
            grafo.AddNodes(nodes);
            
            grafo.AddUndirectedEdge(A, B, 36);
            grafo.AddUndirectedEdge(A, C, 61);
            grafo.AddUndirectedEdge(B, D, 31);
            grafo.AddUndirectedEdge(C, D, 32);
            grafo.AddUndirectedEdge(C, F, 31);
            grafo.AddUndirectedEdge(C, L, 80);
            grafo.AddUndirectedEdge(D, E, 52);
            grafo.AddUndirectedEdge(E, G, 43);
            grafo.AddUndirectedEdge(F, J, 122);
            grafo.AddUndirectedEdge(F, K, 112);
            grafo.AddUndirectedEdge(G, H, 20);
            grafo.AddUndirectedEdge(H, I, 40);
            grafo.AddUndirectedEdge(I, J, 45);
            grafo.AddUndirectedEdge(J, K, 36);
            grafo.AddUndirectedEdge(K, M, 32);
            grafo.AddUndirectedEdge(L, M, 102);
            
            grafo.PrintGraph();

            grafo.DFS(B, H);
            // grafo.BFS(B, H);
        }
    }
}
