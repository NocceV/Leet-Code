# Intuition
//Create a dictionary with the strings in the array and boolean values
       //Create the int array with the results
       //Create a variable start that will save the start point
       //Create a variable length 
       //Create a looping that will cont and add the start points

# Approach
Criamos um Dictionary<string, int> (wordMap) que armazena a contagem de cada palavra em words.
Percorremos a string s em diferentes posições de deslocamento (de 0 até wordLength - 1).
Usamos a técnica de janela deslizante:
Expandimos a janela (right), adicionando palavras à contagem (windowMap).
Quando encontramos todas as palavras em qualquer ordem, adicionamos left ao resultado.
Se a janela ficar maior do que o necessário, removemos palavras da esquerda (left).
Se encontrarmos uma palavra inválida, reiniciamos a janela.

# Complexity
- Time complexity: O(n*m)

- Space complexity: O(n)

# Code
```csharp []
public class Solution {
    public IList<int> FindSubstring(string s, string[] words) {

       //Can the array be empt?
       //can the string be null?
       //Can the string contain special caracters?
       //Can the string can have space and uppercase latters?
       //Do the array contains repeated values?

       //So i want to find all the start points in the string that is all strings in the array are concatenated

       //Create a dictionary with the strings in the array and boolean values
       //Create the int array with the results
       //Create a variable start that will save the start point
       //Create a variable length 
       //Create a looping that will cont and add the start points

       //return the array result
        if (s == null || words.Length == 0) return new List<int>();

        int wordLength = words[0].Length;
        int wordCount = words.Length;
        int totalLength = wordLength * wordCount;
        int sLength = s.Length;
        
        List<int> result = new List<int>();
        Dictionary<string, int> wordMap = new Dictionary<string, int>();

        // Criamos um dicionário com a contagem das palavras
        foreach (var word in words) {
            if (wordMap.ContainsKey(word))
                wordMap[word]++;
            else
                wordMap[word] = 1;
        }

        // Percorremos cada posição possível
        for (int i = 0; i < wordLength; i++) {
            int left = i, right = i;
            Dictionary<string, int> windowMap = new Dictionary<string, int>();
            int matchedWords = 0;

            while (right + wordLength <= sLength) {
                string word = s.Substring(right, wordLength);
                right += wordLength;

                if (wordMap.ContainsKey(word)) {
                    if (!windowMap.ContainsKey(word)) 
                        windowMap[word] = 0;

                    windowMap[word]++;
                    if (windowMap[word] <= wordMap[word]) 
                        matchedWords++;

                    // Quando a janela excede o tamanho necessário, ajustamos
                    while (right - left > totalLength) {
                        string leftWord = s.Substring(left, wordLength);
                        left += wordLength;

                        if (windowMap.ContainsKey(leftWord)) {
                            if (windowMap[leftWord] <= wordMap[leftWord]) 
                                matchedWords--;
                            windowMap[leftWord]--;
                        }
                    }

                    if (matchedWords == wordCount) 
                        result.Add(left);
                } else {
                    // Resetamos a janela quando encontramos uma palavra inválida
                    windowMap.Clear();
                    matchedWords = 0;
                    left = right;
                }
            }
        }

        return result;
    }
}
```
