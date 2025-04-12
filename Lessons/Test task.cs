class Solution {
    public int solution(string P, string Q) {
        char[] ArrP = new char[P.Length];
        char[] ArrQ = new char[P.Length];
        char[] ArrS = new char[P.Length];
        int [] DistLetter = new int[P.Length];
        bool onlyZero = DistLetter.All(el=> el == 0);
        int Counter = 0;
        foreach(char i in P)
        {
            foreach(char j in Q)
            {
                ArrQ[Counter] = j;    

            }
            ArrP[Counter] = i;
            Counter+=1;
        }
        Counter = 0;
        while(ArrQ.Length != 0){
            if(ArrQ.Contains(ArrP[Counter]))
            {
                DistLetter[Counter]+=1;
                ArrQ = ArrQ.Where(val => val != ArrP[Counter]).ToArray();
            }
            else {Counter+=1;}
        }
        Array.Sort(DistLetter);
        Array.Reverse(DistLetter);
        int rep = P.Length;
        Counter = 0;
        while(rep > 0){
            rep-= DistLetter[Counter];
            Counter+=1;
        }
        return Counter;
    }
}
static void Main(string[] args){
    Solution S1 = new Solution;
    Console.Write(S1.solution("aaa","bab"));
}