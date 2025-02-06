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
    public ListNode DeleteDuplicates(ListNode head) {
        
        //Can the list be null?
        //Does the list have only intergers postive numbers?
        

        //I want to remove duplicates in the list and return the list

        //Create a result variable, that will save the start point of the list
        //Create a pointer vartiable that will run in the list
        //Create a while that will end when the list.next = null
            //Inside the while we will compare the values
                //If they are equal we will skip the actual value
                //If they are diferent we just update the list
        //In the end we return the result

        if(head == null){
            return null;
        }

        ListNode result = head;
        ListNode temp = result.next;

        while(temp != null){

            if(temp.val != result.val){
                result.next = temp;
                result = result.next;
            }

            temp = temp.next;
        }
        
        result.next = null;
        return head;
    }
}
