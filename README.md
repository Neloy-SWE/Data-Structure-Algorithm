# Data Structure & Algorithm

## Definition of data structure:
A data structure is a storage that is used to store and organize data.

## Type of data structure:
1. **Primiteve data structure:** Can hold a single value. int, char, float, double, poiinter and other primitive data types.
2. **Non-Primiteve data structure:** Divided into two types:
- Linear data structure.
- Non-linear data structure.

### Linear data structure:
Data structure in which data elements are arranged sequentially or linearly, where each element is attached to its previous and next adjacent elements, is called a linear data structure. Linear structures are divided into two sub-type:
1. **Static data structure:** Static data structure has a fixed memory size. Example: array
2. **Dynamic Data Structure:** In daynamic data structure, the size is not fixed. Example: queue

### Non-Linear data structure:
Data structure where data elements are not placed sequentially or linearly are called non-linear data structures.


**Array:** (linear data structure)

Type:
1. on the basis of size: fixed size, dynamic size.
2. on the basis of dimensions: 1,2,3.. dimention.

Advantages of array:
1. allow random access to elemtns.
2. arrays have betters cache locality.
3. represent multiple data items of the same type using single variable.

Disadvantages of array:
1. fixed size, size cannot increased or decreased. impossible to store extra data if required.
2. allocating less memory than required to an array leads to loss of data.
3. an array is homogeneous in nature so, a single array cannot store values of different data types.
4. Arrays store data in contiguous memory locations, which makes deletion and insertion very difficult to implement. This problem is overcome by implementing linked list.

Uses:
1. good to use when need to work with ordered data.
2. useful when your app requires frequent and efficient access to individual elements.
3. use to make other data structures like stack, queue.<br><br>

**Linked List:** (linear data structure) consists of a series of nodes connected by pointers or references. each node has has two parts: **data** and **next pointer**.

Note:
1. it mainly allows efficient insertion and deletion operations compared to arrays.
2. linked list elements are not stored at a contiguous location.
3. use to implements other data structures like: stack, queue, deque.
4. it is a dynamic data structure.
5. avoids the wastage of memory.
6. we cannot access any elements in a linked list directly.

Type:
1. Singly.
2. Doubly.
3. Circular.
4. Circular doubly.
5. Header.

Advantages:
1. linked list are used for dynamic memory allocation.
2. size can grow or shrink dynimically according to requiremtns, which means effective memory utilization hence, no memory wastage.
3. insertion and deletion of nodes are easy.

Disadvantages:
1. random access not possible.
2. searching is constly and requires 0(n) time complexity.
3. reverse traverse is not possible for singly linked list.
4. more nodes, more pointer/object allocation, more memory.

Uses:
1. browser, image viewer next and previous button; delete, photoshop undo redo button.
2. linked list are used to implement other data structure like queue, stack, graph etc.<br><br>

**Stack:** (linear data structure) follows the **Last-In-First-Out (LIFO)** principle in which the insertion of a new element and removal of an existing element takes places at the same end represented as the top of the stack.

Note:
1. we can access the element only on the top of the stack.

Type:
1. Fixed size.
2. Dynamic size.

Advantages:
1. simple.
2. push pop operations on a stack can be performed in constant time 0(1).
3. stacks only need to store the element that have been pushed onto them, making them memory-efficent compared to other data structure.

Disadvantages:
1. limited access.
2. potential for overflow.
3. not suitable for random access.
4. limited capcity. not good for unknown amount of data.

Uses:
1. Undo function.
2. browser history.
3. stacks play a significant role in parsing. parsers in compilers use stacks to validate langugaes and process strings or syntaxes. compilers use stacks to process structures and validate code.<br><br>

**Queue:** (linear data structure) that follows the **First-In-First-Out (FIFO)** principle. It operates like a line where elements are added at one end (rear) and removed from the otder end(front).

Node:
1. all additions to the list are made at one end is called "rear"/"back".
2. all deletions from the list are made at the other end called "front".
3. The element which is first pushed into the order, the delete operation is fisrt performed on that.

Type:
1. Simple queue: insert at the rear, remove fron the front.
2. Double ended queue (Dequeue): insertion, deletion both can be performed from both front and rear.
    - Input restricted queue: input can be taken from only one end but deletion can be done from any of the ends.
    - Output restricted queue: input can be taken from both ends but deletion can be done from only one end.
3. Circular queue: last position is connected back to the first position. operations are performed in FIFO order.
4. Priority queue: elements are accessed based on the priority assigned to them.
    - Ascending priority queue: elements are arranged in increasing order of their priority values. elements with smallest priority value is popped first.
    - Descending priority queue: elements are arranged in decreasing order of their priority values. element with largest priority is popped first.