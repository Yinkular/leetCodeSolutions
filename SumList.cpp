/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
class Solution {
public:
    ListNode* addTwoNumbers(ListNode* l1, ListNode* l2) {
        
        int number1 = getDigits(l1);
        int number2 = getDigits(l2);
        
        int answer = number1+ number2;
        
        ListNode *Result,*RnextNode;
      
        Result= RnextNode = new ListNode(answer%10);

        answer=answer/10;
        while (answer!=0)
        {
            RnextNode->next = new ListNode(answer%10);
            RnextNode->next->next=NULL;
            RnextNode = RnextNode->next;
            answer = answer/10;
        }
        
        return Result;
    }
    
    int getDigits(ListNode *l)
    {
        int value =0;
        while(l != NULL)
        {
            value = value * 10 + l->val;
            l = l->next;
        }
        
        return value;
    }
    
 
};