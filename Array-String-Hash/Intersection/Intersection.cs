public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        
        //are the arrays ordened?
        
        //entao preciso criar um vetor que contem os numeros que tem nos dois arrays

        //crio uma tabela hash1
        //pego o vetor 1 e coloco todos os valores dele na tabela 1
        //crio uma tabela hash2
        //crio um laco de repeticao
        //comparo se a hash2 ja tem o valor atual do vetor2 e se a hash1 tbm tem
            //se nao tiver e o outro tiver eu add
            //se nao eu continuo
        //crio um vetor
        //passo tudo da hash2 para o vetor

        HashSet<int> table1 = new HashSet<int>();

        for(int i=0;i<nums1.Length;i++){
            if(!table1.Contains(nums1[i])){
                table1.Add(nums1[i]);
            }
        }

        HashSet<int> table2 = new HashSet<int>();

        for(int j = 0 ;j<nums2.Length;j++){
            if(table1.Contains(nums2[j]) && !table2.Contains(nums2[j])){
                table2.Add(nums2[j]);
            }
        }

        int[] finalVet = new int[table2.Count];
        table2.CopyTo(finalVet);

        return finalVet;
    }
}
