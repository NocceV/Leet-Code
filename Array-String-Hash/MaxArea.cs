public class Solution {
    public int MaxArea(int[] height) {

        int esquerda = 0;                // Ponteiro para o início
        int direita = height.Length - 1; // Ponteiro para o final
        int areaMaxima = 0;            // Variável para armazenar a área máxima

        while (esquerda < direita)
        {
            // Calcula a área considerando os ponteiros atual e a altura mínima entre eles
            int areaAtual = Math.Min(height[esquerda], height[direita]) * (direita - esquerda);
            areaMaxima = Math.Max(areaMaxima, areaAtual);

            // Move o ponteiro que está no lado com menor altura
            if (height[esquerda] < height[direita])
                esquerda++;
            else
                direita--;
        }

        return areaMaxima;
    }
}
