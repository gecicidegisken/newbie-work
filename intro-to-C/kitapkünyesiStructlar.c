#include <stdio.h>
#include <stdlib.h>

//struct myStruct *struct_ptr;
//defines a pointer to the myStruct structure.

//struct_ptr = &struct_var;
//stores the address of the structure variable struct_var in the pointer struct_ptr.

//struct_ptr -> struct_mem;
//accesses the value of the structure member struct_mem.


//typedef struct {
//  char name[50];
//  int number;
//  int age;
//}student;
//int main()
//{
//
//
//// Struct pointer as a function parameter
//void showStudentData(student *st) {
//  printf("\nStudent:\n");
//  printf("Name: %s\n", st->name);
//  printf("Number: %d\n", st->number);
//  printf("Age: %d\n", st->age);
//}
// student st1 = {"Karizma", 5, 21};
// student st2= {"Hayalet",2,13};
//showStudentData(&st1);
//showStudentData(&st2);
//}


typedef struct {

    char ad[30];
    char yazar[35];
    int basimYili;

}KitapKunyesi;

void KitabiGoster(KitapKunyesi *kitap);

int main()
{
    KitapKunyesi kitap1={"Denemeler","Montaigne",2008};
    KitapKunyesi kitap2={"Harry Potter","J.K. Rowling",2003};
    KitapKunyesi kitap3={"Dogal Maden Suyu","Sirma ",2020};

    KitabiGoster(&kitap1);
    KitabiGoster(&kitap2);
    KitabiGoster(&kitap3);
}

void KitabiGoster(KitapKunyesi *kitap)
{
    printf("Kitabin adi: %s\n", kitap->ad);
    printf("Kitabin yazari: %s\n", kitap->yazar);
    printf("Kitabin basim yili: %d\n\n", kitap->basimYili);
}
