#include <stdio.h>
#include <stdlib.h>

int main()
{
	// malloc ile dizi tanýmla, element sayýsýný ve elementleri kullanýcý girsin. (DERS NOTU GÝRME UYGULAMASI)
	
	/* 
	 -> pointerlar içlerinde deðer olarak ADRES tutarlar.
	 -> int *ptr; diyerek bir pointer tanýmlarýz.
	 --> a isminde bir deðiþkenimiz olsa; (a=5 diyelim)
		 ptr= &a; diyerek ptr pointerýna a deðiþkeninin 'adresini' atamýþ oluruz. Burda & önemli.
		 
	--> printf kullanarak deðerleri yazmak istesek;
	a : 5  (a'nýn deðeri)
	*ptr: 5  ( ptr'nin tuttuðu adresteki deðer == a'nýn deðeri)
	ptr: abc12  ( a'nýn adresi = ptr'nin deðeri)
	&a: abc12 (a'nýn adresi)
	&ptr: 12edf (ptr'nin adresi <diðerleinden baðýmýsýz>)
	
   
   
 	DÝZÝ - POINTER ÝLÝÞKÝSÝ
 	
	diziler ve pointerlar birbiriyle senkron çalýþýr.
		ptr diye bi deðiþkenimiz ve dizi diye dizimiz olsa;
		int *ptr; int dizi[];
		
		ptr=&dizi[0]  komutu ptr'yi dizinin 0. (ilk) elemaný olarak atar.
		ayný þeyi þu þekilde de yapabiliriz:
		"   ptr=dizi   "     ---->> dizinin ilk elemaný= ptr içinde
		
	*/
	
	int boyut,i,sum=0,avg=0;
	int *ptr;   // ptr isminde bi  pointer atadýk
	
	ptr= malloc(boyut*sizeof(int));   /* malloc hafýzada istediðimiz kadar yer ayýrýr. ptr'yi dizi gibi kullanýcaz þimdi.
	
     	boyut dediðimiz þey dizideki element sayýsý.
     	malloctan bize girdiðimiz boyut kadar yer ayýrmasýný istiyoruz. 
     	her int hafýzada 4 byte yer tutar. (buna sonra gelicez)
     	Diyelim ki boyut= 10 olsaydý ve biz bunu bilseydik þöyle yazardýk:
     	
     	ptr= malloc(10*4);  // 10 boyuttan geliyor, 4 ise kaplanan byte.
     	
     	ama 10'un deðiþtirilebilir olmasýný istiyoruz. Yoksa zaten direkt dizi[10] diye tanýmlardýk. o yüzden 10 yerine boyut diye bi deðiþken yazýyoruz.
     	sizeof(int) de þu demek: bir integer hafýzada 4 byte yer tutar dedik ama bu iþlemciye baðlýdýr. 64 ve 32 bit arasýnda farklýlýk olabilir.
     	riske atmak yerine int'in boyutu anlamýnda sizeof(int) kullanýyoruz
     	Ve sonuçta ;
     	boyutunu kendimiz belirleyeceðimiz bir array oluþturmuþ oluyoruz. (dynamic memory allocation- hafýzayý yönettirdim yani size)
     	
	 */
	
	printf("Enter the number of students: "); // bunun ne olduðunu bilmeyen de....
	scanf("%d",&boyut);
	
	for(i=0; i<boyut; i++){
		printf("%d. student: ",i+1);   // öðrenci indeksi
		scanf("%d",&ptr[i]);  // dizinin i. elemanýný user'dan almýþ oluyoruz.
		
		/*gerisi çok basit matematik iþlemi arkadaþlar.. gayet sýradan ufak bir matematik yani..*/
		sum = sum + ptr[i];
		avg= sum/(boyut);
	}
	printf("The avarage of the class: %d",avg);
	//çalýþtýrýn
}

