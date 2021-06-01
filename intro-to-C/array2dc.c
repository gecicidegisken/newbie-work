#include <stdio.h>
#include <stdlib.h>

void diziYaz(int dizi[], int satir)
{
  for (int i = 0; i < satir; i++)
    printf("%d ", dizi[i]);
}

void diziYaz2B(int dizi[][4], int satir, int sutun)
{
  for (int i = 0; i < satir; i++) {
    for (int j = 0; j < sutun; j++)
      printf("%d ", dizi[i][j]);
    printf("\n");
  }
}

void ortalamaBul(int dizi[][4], int satir, int sutun)
{
  int toplam[4] = {0};
  float ortalama[4] = {0};
    printf("Dersler Toplami : ");
  for (int i = 0; i < sutun; i++)
  {
    for (int j = 0; j < satir; j++)
      toplam[i] += dizi[j][i];


    printf("%d ",toplam[i]);

  }

  printf("\nDersler Ortalamasi : ");
  for(int i=0;i<sutun;i++)
  {
      ortalama[i]=(float)toplam[i]/satir;
      printf("%.2f ",ortalama[i]);
  }

}

int main() {

  int i, j;

  int d1[3][4] = {{1,2,3,4},{5,6,7,8},{9,10,11,12}};
  int d3[3][4] = {{1,2,3,4},{5,6},{9}};
  int d2[3][4] = {1,2,3,4,5,6,7,8,9};
  int dizi[3] = {0};

  diziYaz2B(d1, 3, 4);
    ortalamaBul(d1,3,4);
  //diziYaz(dizi,3);

  return 0;
}
