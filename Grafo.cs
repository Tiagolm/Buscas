using System;
using System.Collections.Generic;
using System.Linq;

public class Grafo : Dictionary<Node, List<Node>>
{   
    public void PrintGraph(){
        this.Select(i => $"{i.Key.value}: {ReturnAdjacents(i.Value)}").ToList().ForEach(Console.WriteLine);
    }

    string ReturnAdjacents (List<Node> lista){
        if (lista is null)
            return "NULL";

        string valores = "";
        foreach (var nodo in lista)
            valores += $"{nodo.value}({nodo.weight}) --> ";
        return valores + "NULL";
    }
    
    public void AddNode(Node node){
        this.Add(node, new List<Node>());
    }

    public void AddNodes(List<Node> nodes){
        foreach (var node in nodes)
            this.AddNode(node);
    }

    public void AddEdge(Node node, Node adjacent){
        this[node].Add(adjacent);
    }

    public void AddEdges(Node node, List<Node> adjacents){
        this[node].AddRange(adjacents);
    }

    Node GetNode(int value){
        foreach (var nodo in this.Keys)
            if ((int)nodo.value == value)
                return nodo;
        Console.WriteLine("Nodo não existe");
        return default(Node);
    }

    Node GetEdge(Node scr, Node target){
        foreach (var adjacent in GetAdjacents(scr))
            if (adjacent.value == target.value)
                return adjacent;

        Console.WriteLine("Aresta não existe");
        return(default(Node));
    }

    List<Node> GetAdjacents(Node nodo){
        List<Node> adjacents = new();
        foreach (var adjacent in this[nodo])
            adjacents.Add(adjacent);
        return adjacents;
    }

    int GetWeight(List<Node> theWay){
        int weight = 0;
        foreach (var node in theWay)
            weight += node.weight;
        return weight;
    }

    public void DFS(Node current, Node target, int weight){
        Console.Write($"{current.value} {weight} -> ");
        
        if ((current.marked) || (current.Equals(target)))
            return;

        Mark(current);
        foreach (var adjacent in GetAdjacents(GetNode((int)current.value)))
            if (!GetNode((int)adjacent.value).marked)
                DFS(GetNode((int)adjacent.value), target, adjacent.weight+weight);
    }

    public void DFS(Node current, Node target){
        Stack<Node> visitados = new();  // let S be a stack
        visitados.Push(current);     // S.push(v)
        while(visitados.Any()){         // while S is not empty do
        current = visitados.Pop();  // v = S.pop()
            if(!current.marked)        // if v is not labeled as discovered then
                Console.Write($"{current.value} -> ");Mark(GetNode((int)current.value));// label v as discovered
                    if (current.Equals(target))
                        break;
            foreach (var item in GetAdjacents(GetNode((int)current.value)))// for all edges from v to w in G.adjacentEdges(v) do
                if (!GetNode((int)item.value).marked && !visitados.Contains(GetNode((int)item.value)))
                    visitados.Push(GetNode((int)item.value));// S.push(w)
        }
    }

    void Mark(Node nodo){
        Node novo = new(nodo.value, nodo.reta, nodo.weight);
        novo.marked = true;
        ChangeKey(nodo, novo);
    }

    bool ChangeKey(Node oldKey, Node newKey)
    {
        List<Node> adjacents = GetAdjacents(oldKey); 
        if (!this.Remove(oldKey))
            return false;

        this.AddNode(newKey);
        this.AddEdges(newKey, adjacents);
        return true;
    }

    // void DFSUtil(Node node, bool[] visited, int weight) 
    // { 
    //     Node current = GetNode((int)node.value);
    //     weight += node.weight;
    //     // Mark the current node as visited 
    //     // and print it
    //     visited[(int)current.value] = true; 
    //     Console.Write($"{current.value}({weight}) -> ");
  
    //     // Recur for all the vertices  
    //     // adjacent to this vertex
        
    //     List<Node> vList = GetAdjacents(current); 
    //     foreach (var n in vList) 
    //     { 
    //         if (!visited[(int)n.value]) 
    //             DFSUtil(n, visited, weight); 
    //     } 
    // } 
  
    // The function to do DFS traversal.  
    // It uses recursive DFSUtil()  
    // public void DFS(Node node) 
    // { 
    //     // Mark all the vertices as not visited 
    //     // (set as false by default in c#)  
    //     bool[] visited = new bool[this.Count]; 
  
    //     // Call the recursive helper function  
    //     // to print DFS traversal  
    //     DFSUtil(node, visited, 0); 
    // } 
    // private void DFSHelper(Node src, Node target, bool[] visited, bool flag, int custo){
    //     visited[(int)src.value] = true;
    //     if (!flag)
    //         Console.Write(src.value + $" {custo} -> ");

    //     if (this[src] != null){
    //         foreach(var item in this){
    //             if (item.Key.value == target.value)
    //                 flag = true;
    //             if (!visited[(int)item.Key.value] == true){
    //                 custo += item.Value[0].weight;
    //                 DFSHelper(item.Key, target, visited, flag, custo);
    //             }
    //         }
    //     }
    // }

    // public void DFS(Node src, Node target){
    //     bool[] visited = new bool[this.Count + 1];
    //     DFSHelper(src, target, visited, false, 0);
    //     Console.Write(target.value);
    // }
}