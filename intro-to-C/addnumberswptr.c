#include <stdio.h>

// Write a program in C to add two numbers using pointers.

int main()
{  int num1,num2,sum;
	int *ptr1,*ptr2;
	printf("Enter the first number: \n");
	scanf("%d",&num1);
	printf("Enter the second number: \n");
	scanf("%d",&num2);
	
	ptr1=&num1;
	ptr2=&num2;

	sum= *ptr1 + *ptr2;
	
	printf("%d +%d= %d", num1,num2,sum);
	
return 0;

}
