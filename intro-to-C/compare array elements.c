#include <stdio.h>

int main()
{
	int	dizi[5]={7,8,9,10,11};
	
	int largest1, largest2, largest3, i,temp;
	
	largest1=dizi[0];
	largest2=dizi[1];
	
	if (largest1<largest2)
		{
			temp = largest1;
		    largest1 = largest2;
	     	largest2 = temp;
		}
		
 	for(i=2; i<5; i++){
	 
		if (dizi[i]>largest2)
			{	
				largest2=dizi[i];
			}	
		else 
			continue;	
		
	}
		printf("Largest number is %d\n",largest2);
		printf("Second largest number is %d",;
	return 0 ;
}
