#include<stdio.h>

void printBoard (char board[7][7]);

int main(){
	
	char board[7][7]={{' ',' ',1,1,1,' ',' '},{' ',' ',1,1,1,' ',' '},{1,1,1,1,1,1,1},{1,1,1,0,1,1,1},{1,1,1,1,1,1,1},{' ',' ',1,1,1,' ',' '},{' ',' ',1,1,1,' ',' '}};
    int py,px,pxarti1=0,pxeksi1=0,pyeksi1=0,pyarti1=0,hy,hx,pyeksi2,pyarti2,pxeksi2,pxarti2;
    int a=1;
    int pinCounter=32;
   	
   	printf("                                    --- PEG SOLITAIRE ---                 \n\n");
   	printf("--> How to play?\nSelect a pin from the given coordinates. Select the column first and then row. Put comma (,) between your selection and press enter.\nThen select a hole to move the pin with same way.Don't forget to put comma between them.\n->If there are no legal moves, enter '-1' for all choices. \nGood luck! :)\n\n"); 
	printf("--> [TR] SOLO TEST NASIL OYNANIR?\nVerilen koordinatlara gore bir tas secin. Ilk once sutunu,ardindan satiri girmelisiniz. Iki secim arasina virgul (,) koyun ve 'enter'a basin.\nAyni sekilde tasi haraket ettirmek uzere bir delik secin.\n->Sectiginiz tas ve delik arasinda baska bir tas olmali ve onu yemelisiniz.\n->Eger yapilacak baska hamle kalmadiysa tum secimlere '-1' girin.  Bol sans! :) \n\n\n");
	printBoard(board);	//oyun tahtasi
	
	while(a>0){ //oyun dongusu
    printf("\nSelect a pin [column],[row]:\n");   //Pin secimi
	scanf("%d,%d",&py,&px);
	
	printf("\nSelect a hole [column],[row]:\n");    // Delik secimi
	scanf("%d,%d",&hy,&hx);
	printf("\n\n");
	
	pxarti1=px+1;
	pxeksi1=px-1;
	pyarti1=py+1;
	pyeksi1=py-1;
	pyeksi2=py-2;
	pyarti2=py+2;
	pxeksi2=px-2;
	pxarti2=px+2;

	if(board[py][px]==1 && board[pyarti1][px]==1 && board[hy][hx]==0 && hy==pyarti2 &&hx==px) //asagi yonde tas yeme
	{
		board[py][px]=0;
		board[pyarti1][px]=0;
	    board[hy][hx]=1;
	    pinCounter--;
	     printBoard(board); //tahtanin yeni hali
	}	 
	 else if(board[py][px]==1 && board[pyeksi1][px]==1 && board[hy][hx]==0 && hy==pyeksi2 && hx==px) //yukari yonde tas yeme
	{
		board[py][px]=0;
		board[pyeksi1][px]=0;
	    board[hy][hx]=1; 
	    pinCounter--;
	     printBoard(board); //tahtanin yeni hali
	}	
	else if(board[py][px]==1 && board[py][pxarti1]==1 && board[hy][hx]==0 && hx==pxarti2 && hy==py) //saga dogru tas yeme
	{ 	board[py][px]=0;
		board[py][pxarti1]=0;
		board[hy][hx]=1;
		pinCounter--;
		 printBoard(board); //tahtanin yeni hali
	}
	 else if(board[py][px]==1 && board[py][pxeksi1]==1 && board[hy][hx]==0 && hx==pxeksi2 && hy==py ) // sola dogru tas yeme
	 { board[py][px]=0;
	   board[py][pxeksi1]=0;
	   board[hy][hx]=1;
	   pinCounter--;
	    printBoard(board); //tahtanin yeni hali
	 }
	 else if(py==-1 && px==-1 && hy==-1 &&hx==-1) // Oyun biterken girilen koordinatlar
			{ 	a=0;
			 	printf("--Game Over.--- \n Pins left: %d\n",pinCounter);
			 	if(pinCounter>25)
			 	printf("Read the instructions again.\n");
			 	else if(pinCounter<25 && pinCounter>15)
			 	printf("You have to work more.\n");
			 	else if(pinCounter<15 && pinCounter>9)
			 	printf("Don't give up!\n");
			 	else if(pinCounter<9 && pinCounter>5)
			 	printf("You are doing good.\n");
			 	else if(pinCounter<5 && pinCounter>2)
			 	printf("Smart moves! You are really good at this game.\n");
			 	else if(pinCounter==1)
			 	printf("YOU WIN! GENIUS:)\n");
			 	else
			 	printf("There may be something wrong.\n");
			 	a=0;
	}
	 else
	 {printf("<--You can not do this move. Try again.-->.\n\n");  //hatali hamle
	 printBoard(board); //tahtanin yeni hali
}
	 printf("\n");
	 	 } // while sonu
	} // main sonu


void printBoard(char board[7][7]){
int i,j,k,l;
printf(" ");
		for(k=0; k<7; k++)
		{printf("  %d   ",k);}
		printf("\n");
	{for (i=0; i<7; i++){
		printf("%d",i);
		for (j=0; j<7; j++){
			if(board[i][j]==1){	
	        	printf("  +   ");}
			else if (board[i][j]==0)
			printf("  o   ");
		else 
		printf("  %c   ",board[i][j]);}
		printf("\n");}
	}} //fonksiyon sonu
