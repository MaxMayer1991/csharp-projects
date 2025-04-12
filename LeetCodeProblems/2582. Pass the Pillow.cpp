#include <iostream>
using namespace std;
int passThePillow(int n, int time) {
        int holder = 1;
        while(time != 0){
            if(holder != n){
                for(int i = 1; i < time; i++){
                    holder++;
                    time--;
                }
            }
            else if(holder = n){
               for(int i = time; i > 1; i--){
                    holder--;
                    time--;
                } 
            }
            
        }
        return holder;
}
int main(){
    cout << passThePillow(5, 4);
}