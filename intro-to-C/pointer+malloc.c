#include <stdio.h>
#include <stdlib.h>

int main()
{
	// malloc ile dizi tan�mla, element say�s�n� ve elementleri kullan�c� girsin. (DERS NOTU G�RME UYGULAMASI)
	
	/* 
	 -> pointerlar i�lerinde de�er olarak ADRES tutarlar.
	 -> int *ptr; diyerek bir pointer tan�mlar�z.
	 --> a isminde bir de�i�kenimiz olsa; (a=5 diyelim)
		 ptr= &a; diyerek ptr pointer�na a de�i�keninin 'adresini' atam�� oluruz. Burda & �nemli.
		 
	--> printf kullanarak de�erleri yazmak istesek;
	a : 5  (a'n�n de�eri)
	*ptr: 5  ( ptr'nin tuttu�u adresteki de�er == a'n�n de�eri)
	ptr: abc12  ( a'n�n adresi = ptr'nin de�eri)
	&a: abc12 (a'n�n adresi)
	&ptr: 12edf (ptr'nin adresi <di�erleinden ba��m�s�z>)
	
   
   
 	D�Z� - POINTER �L��K�S�
 	
	diziler ve pointerlar birbiriyle senkron �al���r.
		ptr diye bi de�i�kenimiz ve dizi diye dizimiz olsa;
		int *ptr; int dizi[];
		
		ptr=&dizi[0]  komutu ptr'yi dizinin 0. (ilk) eleman� olarak atar.
		ayn� �eyi �u �ekilde de yapabiliriz:
		"   ptr=dizi   "     ---->> dizinin ilk eleman�= ptr i�inde
		
	*/
	
	int boyut,i,sum=0,avg=0;
	int *ptr;   // ptr isminde bi  pointer atad�k
	
	ptr= malloc(boyut*sizeof(int));   /* malloc haf�zada istedi�imiz kadar yer ay�r�r. ptr'yi dizi gibi kullan�caz �imdi.
	
     	boyut dedi�imiz �ey dizideki element say�s�.
     	malloctan bize girdi�imiz boyut kadar yer ay�rmas�n� istiyoruz. 
     	her int haf�zada 4 byte yer tutar. (buna sonra gelicez)
     	Diyelim ki boyut= 10 olsayd� ve biz bunu bilseydik ��yle yazard�k:
     	
     	ptr= malloc(10*4);  // 10 boyuttan geliyor, 4 ise kaplanan byte.
     	
     	ama 10'un de�i�tirilebilir olmas�n� istiyoruz. Yoksa zaten direkt dizi[10] diye tan�mlard�k. o y�zden 10 yerine boyut diye bi de�i�ken yaz�yoruz.
     	sizeof(int) de �u demek: bir integer haf�zada 4 byte yer tutar dedik ama bu i�lemciye ba�l�d�r. 64 ve 32 bit aras�nda farkl�l�k olabilir.
     	riske atmak yerine int'in boyutu anlam�nda sizeof(int) kullan�yoruz
     	Ve sonu�ta ;
     	boyutunu kendimiz belirleyece�imiz bir array olu�turmu� oluyoruz. (dynamic memory allocation- haf�zay� y�nettirdim yani size)
     	
	 */
	
	printf("Enter the number of students: "); // bunun ne oldu�unu bilmeyen de....
	scanf("%d",&boyut);
	
	for(i=0; i<boyut; i++){
		printf("%d. student: ",i+1);   // ��renci indeksi
		scanf("%d",&ptr[i]);  // dizinin i. eleman�n� user'dan alm�� oluyoruz.
		
		/*gerisi �ok basit matematik i�lemi arkada�lar.. gayet s�radan ufak bir matematik yani..*/
		sum = sum + ptr[i];
		avg= sum/(boyut);
	}
	printf("The avarage of the class: %d",avg);
	//�al��t�r�n
}

