//Challenge continuation
//
ListNode<int> removeKFromList(ListNode<int> l, int k) {
if (l == null) {
    return l;
}
    l.next = removeKFromList(l.next, k);
    if (l.value == k) {
        return l.next;
    }
return l;

}
