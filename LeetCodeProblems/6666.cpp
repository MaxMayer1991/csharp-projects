#include <string>
#include <vector>
#include <sstream>

class Solution {
public:
    bool isPalindrome(int x) {
        string Str = to_string(x);
        string copyStr = Str;
        reverse(Str.begin(), Str.end());
        
        if(Str == copyStr){
            return true;
        }
        else{
            return false;
        }
    }
};