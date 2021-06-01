#include <stdio.h>

struct card {       //card adýnda bir structure kurdur

    char *face;   //memberlar atadýk
    char *suit;

};


int main()
{

    struct card aCard;  // struct card tipinde, aCard adýnda bir deðiþken
    struct card *cardPtr; // struct card' a bir pointer


    aCard.face="Ace";   // aCard deðiskeninin face ve suit için deðerlerini atadýk
    aCard.suit="Spades";

    cardPtr=&aCard;  // aCard'ýn adresini cardPtr'ye atadýk



    printf("%s of %s\n",aCard.face,aCard.suit);  // dot operatörüyle struct memberlara ulaþtýk

    printf("%s of %s\n",cardPtr->face,cardPtr->suit); //ptr kullanarak memberlara ulaþtýk

    printf("%s of %s",(*cardPtr).face,(*cardPtr).suit); // garip bi þey kullanarak memberlara ulaþtýk
}
