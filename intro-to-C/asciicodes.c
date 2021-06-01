#include <stdio.h>

int main()
{
char letter;  //We have created a varible named letter.

printf("\t\t\t\t   FIND THE ASCII VALUE OF A CHARACTER \n"); // This is the heading

printf("Input a character: \n"); //Ask the user for a character
scanf("%c",&letter); //Read the character | DON'T FORGET to put & before variable when using scanf !!

printf("ASCII code of %c is --> %d",letter, letter); // %c is used for char variables and %d is used for integers. DON'T FORGET to write 'letter' twice; both for %c and %d !!

getch();
return 0;
}
