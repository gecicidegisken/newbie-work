#include <stdio.h>

struct card {       //card ad�nda bir structure kurdur

    char *face;   //memberlar atad�k
    char *suit;

};


int main()
{

    struct card aCard;  // struct card tipinde, aCard ad�nda bir de�i�ken
    struct card *cardPtr; // struct card' a bir pointer


    aCard.face="Ace";   // aCard de�iskeninin face ve suit i�in de�erlerini atad�k
    aCard.suit="Spades";

    cardPtr=&aCard;  // aCard'�n adresini cardPtr'ye atad�k



    printf("%s of %s\n",aCard.face,aCard.suit);  // dot operat�r�yle struct memberlara ula�t�k

    printf("%s of %s\n",cardPtr->face,cardPtr->suit); //ptr kullanarak memberlara ula�t�k

    printf("%s of %s",(*cardPtr).face,(*cardPtr).suit); // garip bi �ey kullanarak memberlara ula�t�k
}
