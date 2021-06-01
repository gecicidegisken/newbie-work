#include <stdio.h>
int main()
{
	int Number1, Number2, Sub;
	printf("\t\t Substraction Of Two Numbers \n \n");
	
	printf("Enter Number One: \n");
	scanf ("%d", &Number1);
	printf("Enter Number Two: \n");
	scanf ("%d", &Number2);

	Sub=Number1-Number2;
	
	printf("Answer = %d", Sub);
	getch();
	return 0;
}
