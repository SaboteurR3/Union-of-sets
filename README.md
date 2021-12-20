# Union-of-sets
{ Union of sets } C# code;


I created a generic type class Set <T> in which I stored T-type sets.
 
In Set class I used several methods:
 
1)Set() - default constructor.
 
2)Set(List<T> e - A constructor that fills in the transmitted data With elements.
 
3)public static Set<T> operator +(Set<T> lhs, Set<T> rhs) - must return the set With elements that are placed in one set.
 
4)public bool Add(T item) - The method must add items to the set. It returns true if The item was not in abundance and was added, otherwise - false.
 
5)public bool Remove(T item) - The method must remove the item from the set. It returns true if the Item is found and deleted, otherwise false.
 
6)public bool Contains(T item) - The method returns true only if the item is found, otherwise false.
 
  
Fields: 
 
1)public int Count 
 
2)public bool IsEmpty
