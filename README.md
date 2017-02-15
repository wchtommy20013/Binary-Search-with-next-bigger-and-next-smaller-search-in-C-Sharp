# Binary-Search-with-next-bigger-and-next-smaller-search-in-C-Sharp
Binary Search with next bigger and next smaller search in C-Sharp

##Usage
~~~
int[] arr = { 1, 3, 5, 7, 9 };

int exact = BinarySearch.Exact(5, arr, arr.Length);             //Exact position of '5' is 2
int bigger = BinarySearch.NextBigger(value, arr, arr.Length);   //Next bigger value is 7
int smaller = BinarySearch.NextSmaller(value, arr, arr.Length); //Next smaller value is 3

int _exact = BinarySearch.Exact(6, arr, arr.Length);            //Not found
int _bigger = BinarySearch.NextBigger(10, arr, arr.Length);     //Not found
int _smaller = BinarySearch.NextSmaller(0, arr, arr.Length);    //Not found
~~~
