# Insertion Sort Projesi

Patika.dev Başlangıç Seviyesi .Net Core Patikasında bulunan Veri Yapıları ve Algoritmaları dersi kapsamında [Insertion Sort Projesi](https://app.patika.dev/courses/veri-yapilari-ve-algoritmalar/insertion-sort-proje) için oluşturduğum dosyadır.

# Proje
**\[22,27,16,2,18,6\]** -> Insertion Sort
1.  Yukarı verilen dizinin sort türüne göre aşamalarını yazınız.
2.  Big-O gösterimini yazınız.
3.  Time Complexity: Average case: Aradığımız sayının ortada olması,Worst case: Aradığımız sayının sonda olması, Best case: Aradığımız sayının dizinin en başında olması.
4.  Dizi sıralandıktan sonra 18 sayısı hangi case kapsamına girer? Yazınız.

# Çözüm

## Insertion Sort Aşamaları
1.  Dizinin ilk iki elemanı 22 ve 27 kontrol edilir. 22, 27'den küçük olduğu için sıralama doğrudur.

    **\[22,27,16,2,18,6\]**  
2. 27 ile 16 kontrol edilir. 16 küçük olan terim olduğu için sola alınır.

    **\[22,16,27,2,18,6\]**  
    
    16 ile 22 karşılaştırıldığında, 16 yine küçük olan terim olduğu için tekrar sola alınır.
    
    **\[16,22,27,2,18,6\]**  
3. 2 ile 27 karşılaştırılır. 2, 27'den küçük olduğu için sola alınır. 

    **\[16,22,2,27,18,6\]**  
    
    2 ile 22 karşılaştılır. 2, 22'den küçük olduğu için sola alınır. 
    
    **\[16,2,22,27,18,6\]**  
    
    2 ile 16 karşılaştılır. 2, 16'dan küçük olduğu için sola alınır. 
        
    **\[2,16,22,27,18,6\]**  
4. 27 ile 18 karşılaştılır. 18, 27'den küçük olduğu için sola alınır. 

    **\[2,16,22,18,27,6\]**  
    
    22 ile 18 karşılaştılır. 18, 22'den küçük olduğu için sola alınır. 
    
    **\[2,16,18,22,27,6\]**  
    
    16 ile 18 karşılaştılır. 18, 16'dan büyük olduğu için sağda kalır. 

5. 27 ile 6 karşılaştılır. 6, 27'den küçük olduğu için sola alınır. 

    **\[2,16,18,22,6,27\]**  
    
    22 ile 6 karşılaştılır. 6, 22'den küçük olduğu için sola alınır. 
    
    **\[2,16,18,6,22,27\]** 
    
    18 ile 6 karşılaştılır. 6, 18'den küçük olduğu için sola alınır. 
    
    **\[2,16,6,18,22,27\]** 
    
    16 ile 6 karşılaştılır. 6, 16'dan küçük olduğu için sola alınır. 
    
    **\[2,6,16,18,22,27\]** 
    
    2 ile 6 karşılaştılır. 6, 2'den büyük olduğu için sağda kalır.

## Big-O Notation
Insertion sort iki loop kullanması nedeniyle O(n²) gösterimine sahiptir.

### Pseudocode
```
algorithm insertion_sort(Array) is
  for i ← 1 to length(Array) do
    currentIndex ← i
    while currentIndex > 0 and Array[currentIndex - 1] > Array[currentIndex] do
      temp ← Array[currentIndex]
      Array[currentIndex] ← Array[currentIndex - 1]
      Array[currentIndex - 1] ← temp
      currentIndex ← currentIndex - 1
    end while
    i ← i + 1
  end for
end function
```
## Time Complexity
| Best Case     | Average Case  | Worst Case | 
|:-------------:|:-------------:|:-------------:|
| O(n)          | O(n²)         | O(n²)      |
|[2,6,16,18,22,27]| O(n²)         |[27,22,18,16,6,2]  

## Soru
Dizi sıralandıktan sonra 18 sayısı hangi case kapsamına girer?

- 18 değeri dizinin ortasında yer alır 
- Dizilim yaparken O(n²) kompleksliğine sahiptir.
- Worst case senaryosuna uymaz. 

Bu şartları sağlayan tek senaryo Average Case'dir.

## Soru
[7,3,5,8,2,9,4,15,6] dizisinin Insertion Sort'a göre ilk 4 adımını yazınız.

1. [**3**,7,5,8,2,9,4,15,6]

2. [3,**5**,7,8,2,9,4,15,6]

3. [3,5,7,**8**,2,9,4,15,6]

4. [3,5,7,**2**,8,9,4,15,6]

    [3,5,**2**,7,8,9,4,15,6]

    [3,**2**,5,7,8,9,4,15,6]    

    [**2**,3,5,7,8,9,4,15,6]
