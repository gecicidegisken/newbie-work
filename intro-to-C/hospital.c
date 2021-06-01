#include <stdio.h>

int main()
{
	float vtbi, mowti,rate;
	printf("Volume to be infused (ml):  ");
	scanf ("%f", &vtbi);
	printf("Minutes over which to infuse: ");
    scanf ("%f", &mowti);
  
    rate=(60/mowti)*vtbi;
 
    printf("  \n\n\n VTBI: %.2f ml \n", vtbi);
    printf(" Rate: %.2f ml/hr", rate);

return 0;
}

