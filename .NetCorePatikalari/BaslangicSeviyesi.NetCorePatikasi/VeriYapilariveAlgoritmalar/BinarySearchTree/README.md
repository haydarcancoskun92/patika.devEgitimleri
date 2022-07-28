

# Binary Search Tree Projesi
Patika.dev Başlangıç Seviyesi .Net Core Patikasında bulunan Veri Yapıları ve Algoritmaları dersi kapsamında [Binary Search Tree](https://app.patika.dev/courses/veri-yapilari-ve-algoritmalar/binary-search-tree-proje) projesi için oluşturduğum dosyadır.

# Proje
**[7, 5, 1, 8, 3, 6, 0, 9, 4, 2]** dizisinin Binary-Search-Tree aşamalarını yazınız.

**Örnek:** root x'dir. root'un sağından y bulunur. Solunda z bulunur vb.

# Çözüm
## Binary Search Tree Aşamaları

1. Root 7'dir. 

[**7**, 5, 1, 8, 3, 6, 0, 9, 4, 2]

```
                7
```
2. 5, 7'den küçük olduğu için sol tarafta bulunur. 

[7, **5**, 1, 8, 3, 6, 0, 9, 4, 2]

```
                7
            /
        5
```
3. 1, 7'den küçük olduğu için 7'nin sol tarafında bulunur. Sonra 5 ile karşılşatırması yapılır ve 5'ten küçük olduğu için tekrar sol tarafa yazılır.  

[7, 5, **1**, 8, 3, 6, 0, 9, 4, 2]

```
                    7
                /
            5
        /
    1
```
4. 8, 7'den büyük olduğu için sağ tarafa yazılır.

[7, 5, 1, **8**, 3, 6, 0, 9, 4, 2]

```
                    7
                /       \
            5               8
        /
    1
```
5. 3, 7'den küçük olduğu için 7'nin sol tarafında bulunur. Sonra 5 ile karşılşatırması yapılır ve 5'ten küçük olduğu için tekrar sol tarafa yazılır. Sonra 1 ile karşılaştırılması yapılır. 1'den büyük olduğu için sağ tarafa yazılır. 

[7, 5, 1, 8, **3**, 6, 0, 9, 4, 2]

```
                        7
                    /       \
                5               8
            /
        1
            \
                3
```
6. 6, 7'den küçük olduğu için 7'nin sol tarafında bulunur. Sonra 5 ile karşılşatırması yapılır ve 5'ten büyük olduğu için sağ tarafa yazılır.

[7, 5, 1, 8, 3, **6**, 0, 9, 4, 2]

```
                        7
                    /       \
                5               8
            /       \
        1               6
            \
                3
```
7.0, 7'den küçük olduğu için 7'nin sol tarafında bulunur. Sonra 5 ile karşılşatırması yapılır ve 5'ten küçük olduğu için tekrar sol tarafa yazılır. Sonra 1 ile karşılaştırılması yapılır. 1'den küçük  olduğu için sol tarafa yazılır. 

[7, 5, 1, 8, 3, 6, **0**, 9, 4, 2]

```
                            7
                        /       \
                    5               8
                /
            1
        /       \
    0               3
```
8.9, 7'den büyük olduğu için 7'nin sağ tarafında bulunur. Sonra 8 ile karşılşatırması yapılır ve 8'den büyük olduğu için tekrar sağ tarafa yazılır. 

[7, 5, 1, 8, 3, 6, 0, **9**, 4, 2]


```
                            7
                        /       \
                    5               8
                /                       \
            1                               9
        /       \
    0               3
```
9. 4, 7'den küçük olduğu için 7'nin sol tarafında bulunur. Sonra 5 ile karşılşatırması yapılır ve 5'ten küçük olduğu için tekrar sol tarafa yazılır. Sonra 1 ile karşılaştırılması yapılır. 1'den büyük olduğu için sağ tarafa yazılır. 3 ile karşılaştırılması yapılır ve büyük olduğu için sağa tarafa yazılır. 

[7, 5, 1, 8, 3, 6, 0, 9, **4**, 2]

```
                            7
                        /       \
                    5               8
                /                       \
            1                               9
        /       \
    0               3
                        \
                            4
```
9. 2, 7'den küçük olduğu için 7'nin sol tarafında bulunur. Sonra 5 ile karşılşatırması yapılır ve 5'ten küçük olduğu için tekrar sol tarafa yazılır. Sonra 1 ile karşılaştırılması yapılır. 1'den büyük olduğu için sağ tarafa yazılır. 3 ile karşılaştırılması yapılır ve küçük olduğu için sol tarafa yazılır. 

[7, 5, 1, 8, 3, 6, 0, 9, 4, **2**]
```
                            7
                        /       \
                    5               8
                /                       \
            1                               9
        /       \
    0               3
                /       \
            2               4
```
