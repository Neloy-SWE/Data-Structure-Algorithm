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
3. use to make other data structures like stack, queue.

**Linked List:** (linear data structure) consists of a series of nodes connected by pointers or references. each node has has two parts: **data** and **next pointer**.

Note:<br>
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

**Stack:** (linear data structure) follows the **Last-In-First-Out (LIFO)** priciple in which the insertion of a new element and removal of an existing element takes places at the same end represented as the top of the stack.

Note:
1. we can access the element only on the top of the stack.

Type:
1. Fixed size.
2. Dynamic size.