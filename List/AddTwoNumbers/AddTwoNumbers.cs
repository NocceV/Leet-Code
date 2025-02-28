/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        
        ListNode dummyHead = new ListNode(0); // Nó fictício para facilitar a construção
        ListNode current = dummyHead;
        int carry = 0; // Vai um (carry)

        while (l1 != null || l2 != null || carry != 0) {
            int val1 = (l1 != null) ? l1.val : 0;
            int val2 = (l2 != null) ? l2.val : 0;
            int sum = val1 + val2 + carry;
            
            carry = sum / 10; // Obtém o "vai um"
            current.next = new ListNode(sum % 10); // Armazena apenas o último dígito
            
            // Avança os ponteiros
            current = current.next;
            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
        }

        return dummyHead.next; // Retorna a lista sem o nó fictício
    }
}
