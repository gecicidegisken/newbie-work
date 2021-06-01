#include <stdio.h>

int main()
{
    float radius=0, area=0, circumference=0, pi=3.14;

    printf("Enter the radius (cm): ");
    scanf("%f", &radius);

    area=pi*radius*radius;

    circumference= 2*pi*radius;

    printf("Area is %.2f cm, and circumference is %.2f cm.\n", area ,circumference);
    printf("%f",radius);
}
