#include<stdio.h>
long int fact(int n);
int main() {
    int n;
    printf("Enter a positive integer: ");
    scanf("%d",&n);
    printf("Factorial of %d = %ld", n, fact(n));
    return 0;
}
long int fact(int n) {
    if (n==0||n==1)
     return 1;
     else if (n<0)
     printf("negatif sayinin faktoriyeli olmaz.");
    else
	return n*fact(n-1);
    
       
}
