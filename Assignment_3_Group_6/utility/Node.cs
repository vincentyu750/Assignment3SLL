namespace Assignment_3_Group_6
{
    public class Node
    {
        public object Data { get; set; }
        public Node Next { get; set; }
        public Node(object data)
        {
            Data = data;
            Next = null;
        }
    }
}