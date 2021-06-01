#include <stdio.h>
#include <stdlib.h>

int main()
{
    int a,*p;

    a=10;
    p=&a;

    printf("*p: %d\n",*p);
    *p=20;        // p pointerýnýn gösterdiði yerdeki deðeri; yani a deðerini deðiþtirmiþ olduk.
    printf("a: %d",a);


}

