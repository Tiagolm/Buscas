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

            Node A = new Node(Letter.A, 223, 0);
            Node B = new Node(Letter.B, 222, 0);
            Node C = new Node(Letter.C, 166, 0);
            Node D = new Node(Letter.D, 192, 0);
            Node E = new Node(Letter.E, 165, 0);
            Node F = new Node(Letter.F, 136, 0);
            Node G = new Node(Letter.G, 122, 0);
            Node H = new Node(Letter.H, 111, 0);
            Node I = new Node(Letter.I, 100, 0);
            Node J = new Node(Letter.J, 60, 0);
            Node K = new Node(Letter.K, 32, 0);
            Node L = new Node(Letter.L, 102, 0);
            Node M = new Node(Letter.M, 0, 0);

            Node AB = new Node(Letter.B, 222, 36);
            Node AC = new Node(Letter.C, 166, 61);
            Node BD = new Node(Letter.D, 192, 31);
            Node CD = new Node(Letter.D, 192, 32);
            Node CF = new Node(Letter.F, 136, 31);
            Node CL = new Node(Letter.L, 102, 80);
            Node DE = new Node(Letter.E, 165, 52);
            Node EG = new Node(Letter.G, 122, 43);
            Node FJ = new Node(Letter.J, 60, 122);
            Node FK = new Node(Letter.K, 32, 112);
            Node GH = new Node(Letter.H, 111, 20);
            Node HI = new Node(Letter.I, 100, 40);
            Node IJ = new Node(Letter.J, 100, 45);
            Node JK = new Node(Letter.K, 32, 36);
            Node KM = new Node(Letter.M, 0, 32);
            Node LM = new Node(Letter.M, 0, 102);

            Node BA = new Node(Letter.A, 223, 36);
            Node CA = new Node(Letter.A, 223, 61);
            Node DB = new Node(Letter.B, 222, 31);
            Node DC = new Node(Letter.C, 166, 32);
            Node FC = new Node(Letter.C, 166, 31);
            Node LC = new Node(Letter.C, 166, 80);
            Node ED = new Node(Letter.D, 192, 52);
            Node GE = new Node(Letter.E, 165, 43);
            Node JF = new Node(Letter.F, 136, 122);
            Node KF = new Node(Letter.F, 136, 112);
            Node HG = new Node(Letter.G, 122, 20);
            Node IH = new Node(Letter.H, 111, 40);
            Node JI = new Node(Letter.I, 100, 45);
            Node KJ = new Node(Letter.J, 60, 36);
            Node MK = new Node(Letter.K, 32, 32);
            Node ML = new Node(Letter.L, 102, 102);
            
            List<Node> nodes = new(){A, B, C, D, E, F, G, H, I, J, K, L, M};
            grafo.AddNodes(nodes);
            grafo.AddEdges(A ,new List<Node>{ AB, AC });
            grafo.AddEdges(B, new List<Node>{ BA, BD });
            grafo.AddEdges(C, new List<Node>{ CA, CD, CF, CL });
            grafo.AddEdges(D, new List<Node>{ DB, DC, DE });
            grafo.AddEdges(E, new List<Node>{ ED, EG });
            grafo.AddEdges(F, new List<Node>{ FC, FK, FJ });
            grafo.AddEdges(G, new List<Node>{ GE, GH });
            grafo.AddEdges(H, new List<Node>{ HG, HI });
            grafo.AddEdges(I, new List<Node>{ IH, IJ });
            grafo.AddEdges(J, new List<Node>{ JF, JI, JK });
            grafo.AddEdges(K, new List<Node>{ KF, KJ, KM });
            grafo.AddEdges(L, new List<Node>{ LC, LM });
            grafo.AddEdges(M, new List<Node>{ MK, ML });

            grafo.PrintGraph();
            // grafo.PrintGraph();
            // grafo.DFS(A, F);
            // grafo.DFS(A);
            // grafo.PrintGraph();

            // Console.WriteLine(".--------- Escolha uma Opcao ---------.");
            // Console.WriteLine("| [1] Imprimir grafo                  |");
            // Console.WriteLine("| [2] Inserir vertice                 |");
            // Console.WriteLine("| [3] Inserir aresta                  |");
            // Console.WriteLine("| [4] É euleriano                     |");
            // Console.WriteLine("| [5] Possui caminho euleriano        |");
            // Console.WriteLine("| [6] Minimo de cores necessárias     |");
            // Console.WriteLine("| [9] Sair                            |");
            // Console.WriteLine("'-------------------------------------'\n");

            
        }
    }
}
