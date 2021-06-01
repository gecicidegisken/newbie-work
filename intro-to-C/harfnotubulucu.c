#include <stdio.h>
#include <stdlib.h>

int main()
{

    int not;


    printf("Notu giriniz : ");
    scanf("%d",&not);

    if(not>=90)
    {
        printf("Harf Notu : A\n");
        printf("Tebrikler.\n");
    }
    else if(not>=80)
        printf("Harf Notu : B\n");
    else if(not>=70)
        printf("Harf Notu : C\n");
    else if(not>=60)
        printf("Harf Notu : D\n");
    else if(not<60)
    {
        printf("Harf Notu : F\n");
        printf("Kaldiniz.");
        printf("Daha fazla calismalisin.");
    }

    printf("program bitti");


    return 0;
}
