#include <stdio.h>
#include <stdlib.h>

int main()
{
    int a,*p;

    a=10;
    p=&a;

    printf("*p: %d\n",*p);
    *p=20;
    printf("a: %d",a);


}
