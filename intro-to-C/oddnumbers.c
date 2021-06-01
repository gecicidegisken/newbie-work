
#include <stdio.h>
int main()
{
	int i=1;
	int n;
	int sum=0;
	
	printf("Enter n: ");
	scanf("%d",&n);
	
	while (i<=n)
		
	{
		 printf("%d\n",i);
		 sum=sum+i;
		 i=i+2;
	
	}
	
printf("Sum= %d",sum);

return 0;
	
}
