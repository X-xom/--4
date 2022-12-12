//В матрице А размера 7 × 5 удалить строку с максимальной суммой положительных элементов строки.

using System;
class HelloWorld {
  static void Main() {
    int[,] a = new int[4, 2];
    for (int i = 0; i < 4; i++){
        for (int j = 0; j < 2; j++){
            string s = Console.ReadLine();
            a[i, j] = int.Parse(s);
    }}
    int max = -99999999;
    int maxind = 0;
    int[] b = new int[4];
    for (int i = 0; i<4; i++){
        int s = 0;
        for (int j = 0; j<2; j++){
            if (a[i, j]>0){
                if (j==1){
                    s += a[i, j];
                    b[i] = s;
                    if (s>max){
                        max = a[i, j];
                        maxind = i;
                    }}
                else{
                    s += a[i, j];
                    b[i] = s;
                }}}}
    for (int i = maxind; i < 3; i++)
        for (int j = 0; j < 2; j++)
            a[i, j] = a[i + 1, j];
    Console.WriteLine();
    for (int i = 0; i < 3; i++){
        for (int j = 0; j < 2; j++)
            Console.Write("{0:d}  ", a[i, j]);
        Console.WriteLine();
    }}}
