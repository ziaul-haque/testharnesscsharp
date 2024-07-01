public class LinkedListNode {
    public int? value;
    public LinkedListNode(int x) {
        value = x;
    }

    public LinkedListNode? next;
}

public class Solution {
    // LinkedListNode RemoveNthFromEnd (LinkedListNode head, int n) {
    //     LinkedListNode dummy = new LinkedListNode (0);
    //     dummy.next = head;

    //     LinkedListNode first = dummy;
    //     LinkedListNode second = dummy;

    //     for (int i=0; i<=n; i++) {
    //         first = first.next;
    //     }
    //     while (first != null) {
    //         first = first.next;
    //         second = second.next;
    //     }
    //     second.next = second?.next?.next;
    //     return dummy;
    // }
    // void TraverseLinkedList(LinkedListNode node) {
    //     while (node != null) {
    //         Console.Write(node.value + (node.next != null ? "->" : "\n"));
    //         node = node.next;
    //     }
    // }

    // public void Test (){
    //     LinkedListNode head = new LinkedListNode(1) { next = new LinkedListNode(2) { next = new LinkedListNode(3) { next = new LinkedListNode(4) { next = new LinkedListNode(5) } } } };
    //     int n = 2;
    //     TraverseLinkedList(head);
    //     LinkedListNode temp = RemoveNthFromEnd(head, n);
    //     TraverseLinkedList(temp);
    // }

}

