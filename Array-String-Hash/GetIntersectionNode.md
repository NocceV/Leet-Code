# Intuition
 primeiro eu comparo o fim das duas listas
 se forem diferentes eu retorno null
 se foram iguais eu prossigo
 crio dois pon teiros para cada lista
 crio uma variavel de ultimo valor
crio um laco while que ira comparar cada valor
 eu comparo se os valores atuais sao iguais e seus valores dentro deles tambem
se sim ei prossigo
 se nao eu retorno o ultimo valor que era igual

# Approach
Dois ponteiros para iterar pelas listas

# Complexity
- Time complexity: O(n)

- Space complexity: O(n)

# Code
```csharp []
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        
        //a lista pode ser null?
        //a lista pode conter valores double??
        
        //entao  eu preciso achar o ponto de conversção de ambas as listas

        //primeiro eu comparo o fim das duas listas
            //se forem diferentes eu retorno null
            //se foram iguais eu prossigo
        //crio dois pon teiros para cada lista
        //crio uma variavel de ultimo valor
        //crio um laco while que ira comparar cada valor
        //eu comparo se os valores atuais sao iguais e seus valores dentro deles tambem
            //se sim ei prossigo
            //se nao eu retorno o ultimo valor que era igual


        //criar um laço while que vai ate o fim comparando as posicoes atuais dos doias nodos
        //se foram de iferentes prossegue
        //se forem iguais retorno o valor
        //se cjhegar no fim retorno null

        // int a = 0;
        // int b = 0;
        // ListNode atualA = headA;  
        // ListNode atualB = headB; 
        // ListNode fim = null;

        // while(atualA.next==null && atualB.next==null){
        //     if(atualA.val == atualB.val){
        //         fim = atualA;
        //         return fim;
        //     }
        //     else{
        //         atualA = atualA.next;
        //         atualB = atualB.next;
        //     }
        // }

        // return fim;     

        ListNode atualA = headA;
        ListNode atualB = headB;

        // Use dois ponteiros para iterar pelas listas
        while (atualA != atualB) {
            // Avance para o próximo nó ou inicie na cabeça da outra lista
            if(atualA != null){
                atualA= atualA.next;
            }
            else{
                atualA= headB;
            }
            
            if(atualB != null){
                atualB= atualB.next;
            }
            else{
                atualB= headA;
            }
        }

        // Quando os ponteiros se encontrarem ou ambos forem null
        return atualA;
    }
}
```
