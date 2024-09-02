namespace Data_Structure___Algorithm.Structures.StructureLinkedList.Doubly
{
    internal class DoublyNode
    {
        public int data;
        public DoublyNode previous;
        public DoublyNode next;

        public DoublyNode(int data)
        {
            this.data = data;
            this.previous = null!;
            this.next = null!;
        }
    }
}
