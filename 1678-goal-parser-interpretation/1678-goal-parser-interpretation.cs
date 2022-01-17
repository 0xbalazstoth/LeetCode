public class Solution {
    public string Interpret(string command) {
        char?[] characters = new char?[command.Length + 1];
        string result = "";
        for (int i = 0; i < command.Length; i++) {
            char c = command[i];
            
            int aIdx = -1;
            int lIdx = -1;
            int gIdx = -1;
            int oIdx = -1;
            
            if (c == 'a') {
                aIdx = i;
                
                if (command[i + 1] == 'l') {
                    lIdx = i + 1;
                }
            } else if (c == 'G') {
                gIdx = i;
            } else if (c == '(') {
                if (command[i + 1] == ')') {
                    characters[i] = 'o';
                }
            }
            
            if (aIdx != -1) {
                characters[aIdx] = 'a';
                characters[aIdx - 1] = '_';
            }
            
            if (lIdx != -1) {
                characters[lIdx] = 'l';
                characters[lIdx + 1] = '_';
            }
            
            if (gIdx != -1) {
                characters[gIdx] = 'G';
            }
        }
        
        for (int i = 0; i < characters.Length; i++) {
            if (characters[i] != '_' && characters[i] != null) {
                result += characters[i];
            }
        }
        
        return result;
    }
}