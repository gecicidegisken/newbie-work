#include <stdio.h>

int main(){

int mevcut, index=1;
float avg, note, sum=0.0;
char name[20];

printf("Enter sinif mevcudu: \n");
scanf("%d",&mevcut);

while (index<=mevcut)
{
 printf("\nEnter %d. student's name: ",index);
 scanf("%s", &name);
 printf("\nGrade: ");
 scanf("%f",&note);
  index++;
  sum=sum+note;
}


avg= sum/mevcut;

printf("\n\nAvarage of the class: %.2f.  ",avg);
if (avg>=90)
{printf("Rank: A!\n");
}
else if (avg>=80)
printf("Rank: B!\n");
else if (avg>=70)
printf("Rank: C!\n");
else if (avg>=60)
printf("Rank D!");
else {
printf("Rank: F!");
}


fd


return 0;
}

