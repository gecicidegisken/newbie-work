#include <stdio.h>
int main()
{
	
    char name[25], hometown[15]; // It means we've created an array of characters. Name is an array which contains 25 letters. | We are gonna read them with gets function.  
	int age;  // we've created  an integer variable. 

printf("What\'s your name: \n" );   //  Ask user the name
gets(name);                        // Read the input 
printf("Where are you from: \n");   // Ask user hometown
gets(hometown);                     //Read the input 
printf("How old are  you: \n");
scanf("%d", &age);
printf("Welcome to %d club, %s from %s! ",age, name, hometown); // This will show you a sentence including your inputs ( name, hometown and age)


getch(); // wants us to click a button before closing the program

return 0; // returns the value of 0 if program worked and ended successfully
}
