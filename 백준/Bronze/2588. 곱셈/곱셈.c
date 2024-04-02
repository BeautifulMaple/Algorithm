#include <stdio.h>

int main(void){
    int n1,n2;
    scanf("%d %d", &n1,&n2);
    int out3,out4,out5;
    out3 = n1 * ((n2%100)%10);
    out4 = n1 * ((n2%100)/10);
    out5 = n1 * (n2 / 100);
    
    printf("%d\n",out3);
    printf("%d\n",out4);
    printf("%d\n",out5);
    printf("%d\n", n1 * n2);
    return(0);
}