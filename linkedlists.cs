
//Challenge continuation
ListNode<int> removeKFromList(ListNode<int> l, int k) {
    if (l == null) {
        return l;
    }
    
    ListNode<int> trav = l;
    
    while(trav.next != null) {
       Console.WriteLine(trav.value); 
       trav = trav.next;
    }
    Console.WriteLine(trav.value);    
    return l;
}
