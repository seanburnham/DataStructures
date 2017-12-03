# DataStructures
IS 537 assignments and practice with Data Structures principles and other technical subjects.

Below are the following Assignments included in this repo and the instructions!



# Assignment: Arrays

Write a dynamic array class that has the following features:

1. Automatically allocate memory when items are added (in chunks).
1. Automatically deallocate memory when items are deleted (in chunks).
1. Track its own size using a class variable, independent of the actual memory allocated.
1. Initialize with 10 empty slots.
1. Increase or decrease the allocated memory slots by 5 at a time (i.e. chunk size is 5).

## Getting Started

I suggest that you create and test one method at a time as you work through `add`, `insert`, `set`, `get`, `delete`, and `swap`.  Test your array class in a separate file.  

For example, as your program the `insert` function, ensure it handles the following:

* Inserting when there are empty slots in the internal array.  Ensure all items above it are moved over one slot.
* Inserting when there are **no** empty slots in the internal array.  This results in a new internal array that has 5 additional slots (10 goes to 15, 15 goes to 20, etc.).  After inserting the new value, the internal array should have four empty slots.
* Inserting with an invalid index (< 0 or >= the current size).

Regarding this last point, your class should throw an exception when the index is out of bounds.  This exception will be caught in your main program.

## Printing the Structure

We need to be able to see the internal state of your array class.  Add a `debug_print` method to your class that prints the following line:

`11 of 15 >>> a, e, r, o, I, o, d, u, s, a, u, null, null, null, null`

In the line above:

* 11 is the current (logical) size of the array.
* 15 is the actual size of the allocated internal array.  This number should always be in multiples of 5 (chunk size).
* a, e, r, o, and so on are the values in the array slots.
* null is an empty slot.  This can be None, nil, null, or whatever word your language uses for null.

## The File of Instructions

The assignment comes with a CSV file named `data.csv`.  This file contains the instructions you should run on your Array class.  It will assist in grading your work.

In your `main` file, read `data.csv` and iterate through the commands.  You can either use a CSV library in your language, or you can simply split each line by comma (there are no commas in the values).  On each line, call the appropriate method in your Array class.   The commands are as follows:

* `CREATE` creates an instance of your array class.
* `DEBUG` prints the debug line to the console.
* `ADD` adds a value to the end of the array.
* `SET` sets a value at a given index in the array.
* `GET` retrieves a value at a given index in the array.  Your main program should print this value to the console.
* `DELETE` removes a value at the given index in the array.  Be sure to shift all elements down to fill the empty slot.
* `INSERT` inserts a value at the given index in the array.  Be sure to shift all elements up to make an empty slot.
* `SWAP` swaps two values at the given indices in the array.

Each time you run a command, print the zero-based file line number followed by the command, in this format:

`LineNum:FileLine`

Note that some commands in the file are meant to fail, such as trying to insert a value beyond the bounds of the array.  You need to wrap each call in a try/catch exception block and print the following when this occurs:

`Error: <msg from your class here>`

See the example output below for a comprehensive list of what your output should look like.

## Example

The `data_example.csv` file contains an example set of instructions you can work with.  I suggest you cut this file down to one or two instructions at a time as you develop rather than try to run the entire file at once.

I've included the output of my assignment in the `output_example.txt` file so you can see exactly how your output should look.  Note the following in the file:

* Line 1 shows an empty, initial array with 10 slots.  The size of this array is 0, even though there are 10 slots allocated.  The 0 value is kept in a class variable within your array class.
* Line 18 is a `GET`, so it has an 's' on the next line.
* Line 19 caused an error, so we see the exception text on the next line.



# Assignment: LinkedLists

Write a dynamic linked list class that has the following features:

1. Track its own size using a class variable, independent of the actual memory allocated.
1. Initialize with a null head.

## Getting Started

I suggest that you create and test one method at a time as you work through `add`, `insert`, `set`, `get`, `delete`, and `swap`.  Test your linked list class in a separate file.  

For example, as your program the `insert` function, ensure it handles the following:

* Inserting when your head is null.
* Inserting when your list has data.
* Inserting with an invalid index (< 0 or >= the current size).

Regarding this last point, your class should throw an exception when the index is out of bounds. This exception will be caught in your main program.

## Printing the Structure

Add a `debug_print` method to your class that prints the following line:

`11 >>> a, e, r, o, I, o, d, u, s, a, u`

In the line above:

* 11 is the current (logical) size of the linked list.
* a, e, r, o, and so on are the values in the linked list nodes.

## The File of Instructions

The assignment comes with a CSV file named `data.csv`.  This file contains the instructions you should run on your LinkedList class.

In your `main` file, read `data.csv` and interate through the commands.  You can either use a CSV library, or you can simply split each line by comma (there are no commas in the values).  On each line, call the appropriate method in your LinkedList class. The commands are as follows:

* `CREATE` creates an instance of your linked list class.
* `DEBUG` prints the debug line to the console.
* `ADD` adds a value to the end of the linked list.
* `SET` sets a value at a given index in the linked list.
* `GET` retrieves a value at a given index in the linked list.  Your main program should print this value to the console.
* `DELETE` removes a value at the given index in the linked list.  Be sure to shift all elements down to fill the empty slot.
* `INSERT` inserts a value at the given index in the linked list.  Be sure to shift all elements up to make an empty slot.
* `SWAP` swaps two values at the given indices in the linked list.

Each time you run a command, print the zero-based file line number followed by the command, in this format:

`LineNum:FileLine`

Note that some commands in the file are meant to fail, such as trying to insert a value beyond the bounds of the linked list.  You need to wrap each call in a try/catch exception block and print the following when this occurs:

`Error: <msg from your class here>`

See the example output below for a comprehensive list of what your output should look like.

## Example

The `data_example.csv` file contains an example set of instructions you can work with.

I've included the output of my assignment in the `output_example.txt` file so you can see exactly how your output should look.  Note the following in the file:

* Line 1 shows an empty, initial linked list with no nodes.
* Line 18 is a `GET`, so it has an 's' on the next line.
* Line 19 caused an error, so we see the exception text on the next line.



# Assignment: Restaurant

Create a new project and copy your linked list class to it.  Create the following additional classes for a total of five (5) data structure classes:

1. Circular Linked List
1. Doubly Linked List
1. Stack
1. Queue

Create five unit test classes (one for *each* list type).  Each unit test class should contain at least four methods.  You should be testing expected results as well as possible exceptions that may occur.

## Circular Linked List

This is a full, new class that extends object.  I suggest modifying a copy of your linked list class instead of starting from scratch. 

Compared to regular linked lists:

* The Node class in a circular list is the same.
* The circular list contains one additional method: `debug_cycle`, which prints the values (including cycling back to the front) for `count` number of iterations.
* Be careful not to loop infinitely through the list (it's circular :).
* Many methods are the same as linked list.  Small changes are needed in `add`, `delete`, `insert`, and `get` to deal with the circular nature.
* The `debug_print` method output is the same as linked list.

In a circular list, the `.next` field is never null.  When the size is 0, `head` is null.  When the size is 1, `head.next` points to `head`.

Throw an exception if operations are performed that are outside the size of the structure (such as inserting beyond the end of the list).

### Circular Linked List Iterator

Create a class that iterates infinitely over a circular linked list.  Define the following methods:

* has_next() - Whether additional items are available.
* next() - Retrieve the next item in the list (and move the iterator forward by one).

## Doubly-Linked List

This is a full, new class that extends object.   I suggest modifying a copy of your linked list class instead of starting from scratch. Your Node class should contain three fields: prev, next, and value.  Ensure the 

Compared to regular linked lists:

* The Node class in a doubly-linked list has three fields: `prev`, `next`, and `value`.
* The doubly-linked list has the same methods as a regular linked list.
* Always ensure that `prev` and `next` point to the previous and next nodes in the list.  This will require changes to `add`, `delete`, `insert`, `get`, and perhaps others of your methods.
* The `debug_print` method output is different than linked list.  The output should contain the list values in forward **and** reverse directions.  The format is count, forward print, reverse print.  Use the .prev and the .next fields to print the two directions.  For a list of three items, the output should be as follows:

        3 >>> a, b, c >>> c, b, a

In a doubly-linked list, the `.next` field is null for the tail item, and the `.prev` field is null for the head item.  

Throw an exception if operations are performed that are outside the size of the structure (such as inserting beyond the end of the list).

## Stack

Create a stack class that **extends** your linked list class.  The class should define two additional methods to those it inherits:

1. `push` - adds an item to the top of the stack (end of the list).
1. `pop` - removes and returns the item at the top of the stack (end of the list).

We are not using the `.peek` method, so you do not need to add it to the class.

Compared to regular linked lists:

* The stack inherits from linked list, so it has all the methods of linked list.
* The stack has two additional methods (defined above).  These methods should simply call the appropriate methods in the superclass.

Throw an exception if operations are performed that are outside the size of the structure (such as popping when empty).

## Queue

Using the composition pattern, create a queue class that **contains** a linked list field.  The queue class should extend `object`, **not** linked list.  Add the following methods to the class:

1. debug_print - prints the values, exactly the same as linked list (i.e. call the linked list method).
1. enqueue - adds an item to the end of the queue.
1. dequeue - removes and returns the first item in the list.

Throw an exception if operations are performed that are outside the size of the structure (such as dequeuing when empty).

## Getting Started

I suggest that you create and test one method at a time as you work through `add`, `insert`, `set`, `get`, `delete`, and `swap`.  Write your unit tests as you code.

For example, as your program the `insert` function, test the following:

* Inserting when your head is null.
* Inserting when your list has data.
* Inserting with an invalid index (< 0 or >= the current size).

## The File of Instructions

The assignment comes with a CSV file named `data.csv`.  This file contains the instructions you should run on your classes.  It will assist in grading your work.

In your `main` file, start by start by creating five structures. It will acts on these structures according to the instructions in `data.csv`.  

1. `callahead` holds customers who have called ahead for seating.  This should be a doubly-linked list.  When a party arrives that called ahead, they are placed up to five spots ahead of the end of the `waiting` line and removed from this list.
1. `waiting` holds customers who are present and waiting for a table.  This should be a doubly-linked list.
1. `appetizers` holds the appetizers that can be given to customers.  New appetizers are added to this queue periodically, and appetizers are given to waiting customers periodically.  This should be a queue.
1. `buzzers` holds the buzzers that are handed out to customers as they start waiting.  This should be a stack.  Push eight initial buzzers onto the stack before starting the data run.
1. `songs` holds the songs we play in the background.  This should be a circular list.  Add three initial songs: Song 1, Song 2, and Song 3.

Once the four lists are created, read `data.csv` and interate through the commands.  You can either use a CSV library, or you can simply split each line by comma (there are no commas in the values).  On each line, call the appropriate method in your data structures.   

Each time you run a command, print the zero-based file line number followed by the command, in this format:

`LineNum:FileLine`

Note that some commands in the file are meant to fail, such as trying to insert a value beyond the bounds of the linked list.  You need to wrap each call in a try/catch exception block and print the following when this occurs:

`Error: <msg from your class here>`


## Example

The `data_example.csv` file contains an example set of instructions you can work with.

I've included the output of my assignment in the `output_example.txt` file so you can see exactly how your output should look. 




# Assignment: Book of Mormon Words

Create a new project and program three sorting algorithms:

1. Bubble Sort
1. Insertion Sort
1. Selection Sort

Write a tester program to ensure each sorting algorithm sorts correctly.  You cannot, of course, use the built-in sorting functions of your language, but you **can** use built-in list functionality of your language.  You are not required to use the Array or LinkedList classes you programmed earlier in the course.  Your sorting functions should modify the list in-place rather than create a new list.

Be sure to include unit tests for each function in your program.

## File Analysis

Your assignment is to count the frequencies of each word used in the Book of Mormon.  The overall program should:

1. Analyze each individual book and print the results (> 2 percent).  Merge `master` and each list as you go.
1. Print the `master` list items (> 2 percent).
1. Print the `master` list items (word == 'christ').
1. Analyze the full text of the Book of Mormon and print the results (> 2 percent).

On Step 1 above, you'll analyze all 15 books, starting with `01-1 Nephi.txt`.  

When analyzing an individual file (Step 1 and 4 above), follow this process:

1. Read the text file into a string.  The first file to analyze is `01-1 Nephi.txt`.
1. Convert the string to lowercase so all words are lower. This allows the words `Behold` and `behold` to be counted together.
1. Split the string by any white space character.  Regular expressions are your friend here.  You should now have a list of individual words.
1. Convert each word to the longest run of alpha characters within that word.  If the word is empty after this step (i.e. doesn't contain any alpha), remove it from the list.  Words like `2` are skipped, and words like `pass,` are converted to `pass`.
1. Count the frequency of each word in the list.  This results in a list of WordData objects containing the book, word, count, and percent. Round all percentages to one decimal place: `3.1415 percent => 3.1 percent`.  You can use a library to count the frequencies, or you can roll your own code to do it.  The percent for a given word is calculated as `count / num words in list`, rounded to one decimal place.
1. Sort the words by highest percent, highest count, alpha order.  For each file, choose one of your sorting algorithms (Bubble Sort, Insertion Sort, Selection Sort).  Be sure each algorithm is used at least once.
1. Print the sorted WordData object data (one line per WordData) for all words with a percentage over 2%.  Follow each book printout with a blank line.  See `example_output.txt` for the exact format.

Do not modify the input files.  Your program should be written to deal with them as they are.

## Merging Lists

Throughout Step 1 of the assignment, keep a running `master` list of all WordData objects analyzed thus far.  The `master` list starts empty.  After analyzing an individual book, merge the current `master` list with the results from that book.  This should result in a new `master` list and the garbage collection of the old `master` list.  DO NOT just insert the items into the master list and then sort.  The sorting should occur as you insert the next item from one list or the other.  Order using highest percent, highest count, alpha order.

In other words, go through both lists at the same time.  At each item, insert the next WordData object from either list A or list B, depending on the their percent values.  If their percent values are the same, insert based on the count value.  If percent and count values are the same, insert based on the alpha order.

Merging two, sorted lists (or transaction sets) is a common problem done in data mining and business processing.  This part of the assignment is to give you experience coding the process.  It can be tricky to get right.

An iterator on each list is one way to code this algorithm.  Another hint is to `sleep` your code and print debug statements as it runs in human time.




# Assignment: Sort Analytics

Create a new project and copy your sorting classes into it (bubble sort, insertion sort, selection sorts).  Add one additional sort algorithm: quicksort. Test your new sorting algorithm with a few lists to ensure it works correctly.  Try lists of one item, already-sorted lists, fully-unsorted lists, etc.

Next, determine how your language sorts lists natively.  For example, if we have a Python list called `mylist` that holds integers, we'd call `mylist.sort()` to have Python sort the list for us.  Internally, Python uses a variation of quicksort to do the work.  What is the code to sort in your language?

Now that you have five sorting algorithms (four of your own making and one in your language), evaluate their relative speed.  Sort each list of numbers included with this assignment, and print the results.  If you want to go the extra mile and are using Python, try compiling your algorithms to machine code using the Cython library.  This should dramatically improve speed.

## Analytics Process

Loop through the number files in this assignment.  For each list of numbers, do the following:
 
1. Print the name of the list, or the filename if you don't know the name of the list.
1. For each of the six sorting algorithms, do the following:
    1. Read the list into a list/array.  Use the native data types in your language (not your array or linked list from earlier assignments).  Read the list fresh with each sorting algorithm so each has the same input sequence.
    1. Copy the list of numbers 1,000 times so you can sort more than once. 
    1. Save the current time in millis.
    1. In a for loop, sort each of the lists using the specific algorithm.  You should only sort each copy once (you have 1,000 copies).
    1. Calculate the current time in millis minus the start time.  Create a `Result` object for this result.
1. You should now have five result objects: one for each algorithm.  Determine which was the fastest, and calculate the relative increase in time of each algorithm.  The formula is: `100.0 * (algorithm time - fastest time) / fastest time`.  
1. Sort the five results from fastest to slowest.
1. Print the times to the console as shown in `example_output.txt`.  Please try to match this file exactly with your output.  The relative time is rounded to the nearest integer.  Note that the first 10 and last 10 numbers of each set are included in the printout.

Note that the portion we are timing above is as minimal as possible.  We are reading the list of numbers, generating the thousand copies, and printing outside of the timed part.  This is to make the time as reliable as possible.





# Assignment: Reflection

For this assignment, you'll need to know two principles.

* Reflection is a type of programming that investigates objects for fields and methods at runtime.  It allows all sorts of dynamic programming to be done.
* Serialization is converting an object to data so it can be stored or transferred.

For this assignment, use reflection to create a method that can serialize objects to JSON -- without knowing the fields beforehand.  You need to support these types of fields:

* null
* boolean
* float
* integer
* string
* user-defined objects (BirthDate, Person)

The to_json() method should print the JSON to the console.

## JSON Format

Be sure the check the rules of the JSON format.  Here are a couple of hints:

* JSON specifies the use of double-quotes, not single quotes.
* The last item in a given level should not have a comma after it.
* Be sure to escape double-quotes and backslashes in string values.  You are not required to support other special characters like backspace, newline, etc.
* null/None/nil is listed as `null` in JSON.
* Booleans are listed as `false` or `true` in JSON.
* You are not required to support lists or dictionaries as fields values (you *do* need to worry about embedded objects).
* You are not required to support circular references in objects.

Run your program and store the output to `output.json`.  It should match `sample_output.json`.

## Recursive Behavior

When your algorithm encounters a field value that is another object, store a dictionary of its values.  In other words, recursively call your serializer, setting the return value under that field.  Increase the tab spacing each time your recurse to a deeper level.




# Assignment: Binary Tree

Write a binary tree class that has the following methods:

1. `set(key, value)` stores a key=value pair to the tree in the appropriate spot.
1. `get(key)` returns the value stored with the given key.  If the key does not exist, null/None should be returned.
1. `remove(key)` removes the node with the given key from the tree.  If the key does not exist, it should simply return (no error).
1. `walk_dfs_inorder()` iterates through the nodes of the tree in depth-first-search "inorder" order.
1. `walk_dfs_preorder()` iterates through the nodes of the tree in depth-first-search "preorder" order.
1. `walk_dfs_postorder()` iterates through the nodes of the tree in depth-first-search "postorder" order.
1. `walk_bfs()` iterates through the nodes of the tree in breadth-first-search order.
1. `debug_print()` prints a graphical representation of the tree. See below for more information.

You can adjust the API of above methods if needed, but be sure to implement the behavior specified.

The tree has at least one field, `root`, that is the top node of the tree.

## Node

Each node of the binary tree should be an instance of your `Node` class.  Create this class with the following fields:

1. `key` - the key the item is stored under.  The placement of the node in the tree is based on this key.
1. `value` - the value being stored (string or object is fine).
1. `parent` - a reference to the parent of the node.
1. `left` - a reference to the left child of the node.
1. `right` - a reference to the right child of the node.

When the tree is modified (`set`, `remove`), be sure to update the `parent`, `left`, and `right` references.

I suggest you also create a `toString()` or `__str__()` or `description` property to make printing nodes easy.  My method prints the node key and parent with parentheses: `key(parentkey)`.

## Removing a Node

Arguably, the most difficult part of this assignment is removal of a key/value from the tree.  Since your node objects define the structure (references) of the tree, removal of a node creates a hole in the reference graph.  These way you handle a removal depends on the type of hole that is created:

* If the node has no children, it is a leaf node in the tree.  Just remove the node.
* If the node has one child, replace it with the child node.
* If the node has two children, things get a little more difficult.  You need to replace it with the next-closest node (closest by *key*).  Finding the next closest node can be done by 1) walking its left child tree and finding the largest key value, or 2) walking its right child tree and finding the smallest key value.  In either case, the replacement node will be a leaf node.  Move the leave node in place of the one that you are removing.

## Main Method

In your main code loop, perform the following operations:

1. Create the tree by storing following key=value pairs:
        c = C
        h = H
        a = A
        e = E
        f = F
        d = D
        b = B
        j = J
        g = G
        i = I
        k = K
1. Print the tree with `debug_print()`.
1. Print the value with key = `f`.
1. Print the value with key = `b`.
1. Print the value with key = `i`.
1. Walk the tree in `BFS` order and print each value.
1. Walk the tree in `DFS preorder` order and print each value.
1. Walk the tree in `DFS inorder` order and print each value.
1. Walk the tree in `DFS postorder` and print each value.
1. Remove the value with key = `b`.
1. Print the tree with `debug_print()`.
1. Remove the value with key = `f`.
1. Print the tree with `debug_print()`.
1. Remove the value with key = `h`.
1. Print the tree with `debug_print()`.

The initial tree will look as follows:

         c
    a              h
      b       e          j
            d   f      i   k
                  g

The `example_output.txt` file contains a printout of my code.  Please follow this format in creating your own `output.txt`.  It does not need to match my format exactly, but it should be close.  In particular, be sure to print the node key and parent key in the calls to `debug_print()`.



# Assignment: Hashtable

In this assignment, you'll create four primary classes: an abstract Hashtable superclass and three concrete subclasses of it.  The three subclasses define one additional method, `get_hash()`, which returns the hash key for the data type being supported.  You'll support three types of keys: strings, guids, and image bytes.  The three classes are as follows:

```
                Hashtable (abstract class)
                 /           |           \
                /            |            \
    StringHashtable    GuidHashtable    ImageHashtable
```

Our hashtable implementation only allows one value under a given key.  If a second value is added with an existing key, the previous value is removed.

## The Hash Function

Each of your subclasses will define the `get_hash()` method differently.  In all cases, it returns a number in the 0-9 range, which is the length of your bucket list (i.e. the index of the bucket the key will be assigned to).  In all cases, you do not have to process the entire contents of the keys -- just process enough to get a uniform distribution.

Your hash should be stable for a given key, meaning that repeated calls with the same key will always return the same hash index.

* The StringHashtable should compute the index based on the contents of the string.
* The GuidHashtable should compute the index based on the given guid.  Each guid is composed of 40 hex charaters: 0-15 is the millisecond the guid was created, 16-23 is a counter that resets at a random number at each change in millisecond, and 24-39 is the IP address where the guid was created.
* The ImageHashtable should compute the index based on the given image bytes.  The parameter will be sent in as the filename of the graphic, but your method needs to open the image, read (some of or all of) the bytes, and calculate the index based on the bytes of the image.

Try to implement a clever, fast, effective hash function that will load your list of buckets as uniformly as possible.  Do not use the built-in hash functionality of your language, and do not use the built-in `md5` or `sha` algorithms.  The logic needs to be your creation.

## Constructor

In your constructor, create an array of 10 buckets.  We're using a low number so debugging and printing is easier (even though it will load up fairly quickly).  Initialize each bucket as a BinaryTree from your last assignment.

In other words, your buckets do not start with `null` values.  They start with 10 empty binary trees.


## Methods

The methods you need to support are given below.  Note that the `get_hash()` method is abstract in the superclass.

```
Hashtable class:
    Constructor
    set(key, value)
    get(key)
    remove(key)
    get_hash(key)

StringHashtable class (Hashtable subclass):
    get_hash(key)

GuidHashtable class (Hashtable subclass):
    get_hash(key)

ImageHashtable class (Hashtable subclass):
    get_hash(key)

```

## Debug Printing

Create a `debug_print()` method for debugging.  This method should print the index followed by the values in each bucket.  An example is the following:

```
0: 00000158691797bd77464872000a0018001b000c, 00000158691797bd7746487c000a001800388ccf, 00000158691797bd77464886000a001800388ccf, 00000158691797bd77464890000a001991ef0003
1: 00000158691797bd77464873000a0018001b000c, 00000158691797bd7746487d000a001800388ccf, 00000158691797bd77464887000a001991ef0003, 00000158691797bd77464891000a001991ef0003
2: 00000158691797bd77464874000a0018001b000c, 00000158691797bd7746487e000a001800388ccf, 00000158691797bd77464888000a001991ef0003, 00000158691797bd77464892000a001991ef0003
3: 00000158691797bd77464875000a001800388ccf, 00000158691797bd7746487f000a001800388ccf, 00000158691797bd77464889000a001991ef0003, 00000158691797bd77464893000a001991ef0003
4: 00000158691797bd77464876000a001800388ccf, 00000158691797bd77464880000a001800388ccf, 00000158691797bd7746488a000a001991ef0003, 00000158691797bd77464894000a001991ef0003
5: 00000158691797bd77464877000a001800388ccf, 00000158691797bd77464881000a001800388ccf, 00000158691797bd7746488b000a001991ef0003, 00000158691797bd77464895000a001991ef0003
6: 00000158691797bd7746486e000a0018001b000c, 00000158691797bd77464878000a001800388ccf, 00000158691797bd77464882000a001800388ccf, 00000158691797bd7746488c000a001991ef0003
7: 00000158691797bd7746486f000a0018001b000c, 00000158691797bd77464879000a001800388ccf, 00000158691797bd77464883000a001800388ccf, 00000158691797bd7746488d000a001991ef0003
8: 00000158691797bd77464870000a0018001b000c, 00000158691797bd7746487a000a001800388ccf, 00000158691797bd77464884000a001800388ccf, 00000158691797bd7746488e000a001991ef0003
9: 00000158691797bd77464871000a0018001b000c, 00000158691797bd7746487b000a001800388ccf, 00000158691797bd77464885000a001800388ccf, 00000158691797bd7746488f000a001991ef0003
```

## Main Method

Your main method should do the following:

1. Create a StringHashtable.
1. Add each bug in `strings.txt` with the key being the lowercased string and the value being the normal (as-is) version.
1. Print the hashtable (debug_print)
1. Do two lookups with `get()`: 'indian meal moth' and 'orb-weaving spiders (banded garden spider)'.
1. Create a GuidHashtable.
1. Add each guid in `guids.txt` with the key being the lowercased string and the value being the normal (as-is) version. Note that your **key should be calculated from the number parts in the guid**, not simply from the string representation of the guid.
1. Print the hashtable (debug_print)
1. Do two lookups with `get()`: '00000158691797bd77464883000a001800388ccf' and '00000158691797bd7746488c000a001991ef0003'.
1. Create an ImageHashtable.
1. Add each image in `images.txt` with the key being the filename and the value being filename.  Note that your **key should be calculated from the bytes of the file**, not from the filename.
1. Print the hashtable (debug_print)
1. Do two lookups with `get()`: 'document.png' and 'security_keyandlock.png'.

Run your program and send the output to `output.txt`.
