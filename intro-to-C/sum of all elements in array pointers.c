#include <stdio.h>
#include <stdlib.h>

int main(){

  //compute the sum of all elements in an array using pointers	

int *ptr;
int boyut,i,sum=0;

ptr= malloc(boyut*sizeof(int));


printf("Enter the size of array:");
scanf("%d",&boyut);

for(i=0; i<=boyut-1; i++)
{
	printf("%d. element: ",i);
	scanf("%d",&ptr[i]);
	sum=sum+ ptr[i];
}
printf("\nSum of the elements in array: %d",sum);




}
