public struct Node
{
    public Node(Letter value, int reta, int weight)
    {
        this.value = value;
        this.reta = reta;
        this.marked = false;
        this.weight = weight;
    }
    
    public Letter value { get; set; }
    public int reta { get; set; }
    public int weight { get; set; }
    public bool marked { get; set; }
    public enum Letter : int{A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z}
}