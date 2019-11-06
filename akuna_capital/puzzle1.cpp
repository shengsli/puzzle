SinglyLinkedListNode* removeNodes(SinglyLinkedListNode* listHead, int x) {
    SinglyLinkedListNode* curNode = listHead;
    SinglyLinkedListNode* prevNode = nullptr;
    
    while (curNode != nullptr && curNode->data > x) {
        listHead = curNode->next;
        delete curNode;
        curNode = listHead;
    }
    
    while (curNode != nullptr) {
        while (curNode != nullptr && curNode->data <= x) {
            prevNode = curNode;
            curNode = prevNode->next;
        }
        if (curNode == nullptr) {
            return listHead;
        }
        prevNode->next = curNode->next;
        delete curNode;
        curNode = prevNode->next;
    }
    return listHead;
}
