#include <stdio.h>
#include <stdlib.h>

int main()
{
    int a,*p;

    a=10;
    p=&a;

    printf("*p: %d\n",*p);
    *p=20;        // p pointer�n�n g�sterdi�i yerdeki de�eri; yani a de�erini de�i�tirmi� olduk.
    printf("a: %d",a);


}

