public class Solution {
    public string DefangIPaddr(string address) {
        string newIp = "";

        for (int i = 0; i < address.Length; i++)
        {
            newIp += address[i].ToString().Replace(".", "[.]"); 
        }

        return newIp;
    }
}