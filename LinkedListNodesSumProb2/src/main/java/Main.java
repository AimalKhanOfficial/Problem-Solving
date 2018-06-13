import java.util.List;

public class Main {
    public static void main(String[] args) {

        /*You are given two non-empty linked lists representing two non-negative integers.
        The digits are stored in reverse order and each of their nodes contain a single digit.
        Add the two numbers and return it as a linked list.

        You may assume the two numbers do not contain any leading zero, except the number 0 itself.

        Example

        Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        Output: 7 -> 0 -> 8
        Explanation: 342 + 465 = 807.*/

        //Must convert to 1 4
        ListNode four = new ListNode(2);
        ListNode one = new ListNode(4);
        ListNode one2 = new ListNode(3);
        four.next = one;
        one.next = one2;

        //Must convert to 2 3
        ListNode three = new ListNode(5);
        ListNode two = new ListNode(6);
        ListNode two2 = new ListNode(4);
        three.next = two;
        two.next = two2;

        ListNode listNode = four.addTwoNumbers(four, three);
        System.out.println(listNode.val);

    }
}
