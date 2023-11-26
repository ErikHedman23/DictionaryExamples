//Dictionaries

//A dictionary is a collection of unique key/value pairs where a key is used to access the corresponding value.  Dictionaries are used in database indexing, cache implementations, and so on.

/* 
 Dictionary<K, V> class requires all key/value pairs to be of the same type K, V.  Duplicate keys are not permitted to ensure that every key/value pair is unique.

Dictionary<K, V> properties include:

Count - Gets the number of key/value pairs contained in the dictionary.

Item[K key] - Gets the value associated with the specified key in the dictionary. Item is the indexer and is not required when accessing an element. You only need to use the brackets [] and key value.

Keys - Gets an indexed collection containing only the keys contained in the dictionary.
 
 
 Dictionary<K, V> methods include:

Add(K key, V value) - Adds the key, value pair to the dictionary.

Remove(K key) - Removes the key/value pair related to the specified key from the dictionary.


Here are the additional Dictionary<K, V> properties and methods:

Values - Gets an indexed collection containing only the values in the dictionary.

Clear() - Removes all the key/value pairs from the dictionary.

ContainsKey(K key) - Returns true if the specified key is present in the dictionary.

ContainsValue(V value) - Returns true if the specified value is present in the dictionary.
 */

//Example

Dictionary<string, int> d = new Dictionary<string, int>();
d.Add("Uno", 1);
d.Add("One", 1);
d.Add("Dos", 2);
d.Add("Deux", 2);
d.Remove("One");  // Remove key-value pair One, 1
d.Remove("Dos");  // Remove key-value pair Dos, 2

Console.WriteLine("Dictionary: ");
foreach (string s in d.Keys)
{
    Console.WriteLine(s + ": " + d[s]);  // Uno: 1  Deux: 2

}
Console.WriteLine("\nCount: {0}", d.Count); // 2 


/*
HashSet<T>  

A hash set is a set of unique values where duplicates are not allowed.

C# includes the HashSet<T> class in the generic collections namespace. All HashSet<T> elements are required to be of the same type T. 

Hash sets are different from other collections because they are simply a set of values. They do not have index positions and elements cannot be ordered.

The HashSet<T> class provides high-performance set operations. HashSets allow fast lookup, addition, and removal of items, and can be used to implement either dynamic sets of items or lookup tables that allow finding an item by its key (e.g., finding the phone number of a person by the last name).

HashSet<T> properties include:

Count - Returns the number of values in the hash set.

And methods include:

Add(T t)  - Adds a value (t) to the hash set.

IsSubsetOf(ICollection c)  - Returns true if the hash set is a subset of the specified collection (c).

Here are additional HashSet<T> methods:

Remove(T t)  - Removes the value (t) from the hash set.

Clear()  - Removes all the elements form the hash set.

Contains(T t) - Returns true when a value (t) is present in the hash set.

ToString() - Creates a string from the hash set.

IsSupersetOf(ICollection c) - Returns true if the hash set is a superset of the specified collection.

UnionWith(ICollection c) - Applies set union operation on the hash set and the specified collection (c).

IntersectWith(ICollection c) Applies set intersection operation on the hash set and the specified collection (c).

ExceptWith(ICollection c) - Applies set difference operation on the hash set and the specified collection (c).

 */

//Example

HashSet<int> hs = new HashSet<int>();

hs.Add(5);
hs.Add(10);
hs.Add(15);
hs.Add(20);
Console.Write("\nHashSet: ");
foreach (int i in hs)
{
    Console.Write(i + " ");  // 5  10  15  20  *elements may be in any order
}
Console.Write("\nCount: " + hs.Count);  // 4

HashSet<int> hs2 = new HashSet<int>();
hs2.Add(15);
hs2.Add(20);
Console.Write("\n{15, 20} is a subset of {5, 10, 15, 20}: " + hs2.IsSubsetOf(hs)); // True


//Example 2

HashSet<string> candidates = new HashSet<string>();

candidates.Add("John");
candidates.Add("Amelie");
candidates.Add("Tom");
candidates.Add("Richard");
candidates.Add("Barbara");
candidates.Add("Susan");
candidates.Add("Charles");
candidates.Add("Daniel");
candidates.Add("Tamara");
candidates.Add("Donald");

HashSet<string> hiring = new HashSet<string>();

while (hiring.Count < 3)
{
    string hire = Console.ReadLine();
    //add the names to hiring hash set

    hiring.Add(hire);

}
//your code goes here
if (hiring.IsSubsetOf(candidates))
{
    Console.WriteLine("Starting hiring process");
}
else
{
    Console.WriteLine("Something is wrong");
}


//Example 2 for Dictionaries

double discount = Convert.ToInt32(Console.ReadLine());

Dictionary<string, double> coffee = new Dictionary<string, double>();
coffee.Add("Americano", 50);
coffee.Add("Latte", 70);
coffee.Add("Flat White", 60);
coffee.Add("Espresso", 60);
coffee.Add("Cappuccino", 80);
coffee.Add("Mocha", 90);

var keys = coffee.Keys.ToArray(); //Create another variation of the dictionary as an array in order to alter the array while you loop through it in the foreach loop instead of trying to loop and iterate through the dictionary alone in the foreach loop
//your code goes here
foreach (string k in keys)
{
    double discountedPrice = coffee[k] - (coffee[k] * discount / 100);
    coffee[k] = discountedPrice;
    coffee.Keys.ToArray();
    Console.WriteLine(k + ": " + coffee[k]);
}