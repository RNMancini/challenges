
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
    //Remove function test 1
    list.Remove(k);
    Console.WriteLine(l);
    foreach (var k in list) {
        Console.WriteLine(l);
    }
    return l;
    }
 }