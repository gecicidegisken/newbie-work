#include <stdio.h>
#include <stdlib.h>

int facto(int *);

int main()
{
  // find the factorial of a given number using pointers
  int sayi;
 printf("Enter a nummmber: ");
 scanf("%d",&sayi);
  facto(&sayi);
	return 0;
}

int facto(int *a){
int i,factt;

for(i=1; i<=*a; i++){
	factt=factt*i;
}
return factt;
}
