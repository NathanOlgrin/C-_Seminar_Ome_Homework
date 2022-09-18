﻿// Напишите программу, которая заполнит спирально массив 4 на 4.


Console.WriteLine("Hello, World!");
int[,] array = new int[4,4];

int i=0, j, k = 0, p=1;
 
while (i < 16) /*Цикл по номеру витка*/
 {
    k++;
    for (j=k-1;j<4-k+1;j++)
    {
        array[k-1,j]=p++;
        i++;
    }          
       /*Определение значений верхнего гор столбца*/ 
    for (j=k;j<4-k+1;j++)
    {
        array[j,4-k]=p++;
        i++;
    }   /* --//-- По правому вертикальному столбцу*/
 
    for (j=4-k-1;j>=k-1;j--)
    {
        array[4-k,j]=p++;
        i++;
    }   /* --//-- по нижнему горизонтальному столбцу*/ 
 
    for (j=4-k-1;j>=k;j--)
    {
        array[j,k-1]=p++;
        i++;
    }   /* --//-- по левому вертикальному столбцу*/
  }
for(i=0;i<4;i++)
{
    for(j=0;j<4;j++)
    {
        if(array[i,j]<10)
        {
            Console.Write($"0{array[i,j]} ");
        }
        else
        {
            Console.Write($"{array[i,j]} ");
        }        
    }
    Console.WriteLine();
}