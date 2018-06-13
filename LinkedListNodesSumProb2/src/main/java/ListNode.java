public class ListNode {
    int val;
    ListNode next;

    ListNode(int x) {
        val = x;
    }

    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {

        //Not modifying actual input
        ListNode firstParam = l1;
        int counter = 0;

        while (firstParam != null) {
            counter++;
            firstParam = firstParam.next;
        }

        int[] firstParamArr = new int[counter];
        int counterAgain = 0;
        while (l1 != null) {
            firstParamArr[counterAgain] = l1.val;
            counterAgain++;
            l1 = l1.next;
        }

        double firstParamAdded = 0;
        double firstParamMultiplier = Math.pow(10, firstParamArr.length - 1);
        for (int i = firstParamArr.length - 1; i >= 0; i--) {
            firstParamAdded += firstParamArr[i] * firstParamMultiplier;
            firstParamMultiplier = firstParamMultiplier / 10;
        }

        ListNode secondParam = l2;
        int counter2 = 0;

        while (secondParam != null) {
            counter2++;
            secondParam = secondParam.next;
        }

        int[] secondParamArr = new int[counter2];
        int counterAgain2 = 0;
        while (l2 != null) {
            secondParamArr[counterAgain2] = l2.val;
            counterAgain2++;
            l2 = l2.next;
        }

        double secondParamAdded = 0;
        double secondParamMultiplier = Math.pow(10, secondParamArr.length - 1);
        for (int i = secondParamArr.length - 1; i >= 0; i--) {
            secondParamAdded += secondParamArr[i] * secondParamMultiplier;
            secondParamMultiplier = secondParamMultiplier / 10;
        }

        double result = firstParamAdded + secondParamAdded;
        int finalResult = (int) result;
        int finalResultCopy = finalResult;

        int finalCounter = 0;
        while (finalResultCopy > 0){
            finalCounter++;
            int number = finalResultCopy % 10;
            finalResultCopy = finalResultCopy / 10;
        }

        int[] finalIntegrationArray = new int[finalCounter];
        for(int i = 0; i < finalIntegrationArray.length; i++){
            finalIntegrationArray[i] = finalResult % 10;
            finalResult = finalResult / 10;
        }

        ListNode baseNode = null;
        for(int i = 0; i < finalIntegrationArray.length; i++){
            if(baseNode == null){
                baseNode = new ListNode(finalIntegrationArray[i]);
            }
            else {
                //just a starting point
                ListNode lastNode = baseNode.next;

                while(lastNode != null){
                    lastNode = lastNode.next;
                }

                lastNode = new ListNode(finalIntegrationArray[i]);
                baseNode.next = lastNode;
            }
        }

        return new ListNode(2);
    }
}
