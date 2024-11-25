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

Note:
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

Advantages:
1. A large amount of data can be managed efficiently with ease.
2. Operations such as insertion and deletion can be performed with ease as it follows the first in first out rule.
3. Queues are useful when a perticular service is used by multiple consumers.
4. Queues are fast in speed for data inter-process communication.
5. Queues can be used in the implementation of other data structures.

Disadvantages:
1. The operations such as insertion and deletion of elements from the middle are time consuming.
2. searching an element takes O(n) time.

Uses:
1. CPU scheduling and disk scheduling.
2. handling website traffic.
3. playlist in media players.
4. print documents in a serial.<br><br>

**Tree:** (non-linear data structure) is a data structure that store data in hierarchical manner.

Note:
1. easy to navigate and search.
2. it is a collection of nodes that are connected by edges and has hierarchical relationship between the nodes.
3. **basic terminologies:**
    - **parent node:** the node which is a predecessor of a node is called the parent node of that node.
    - **child node:** the node which is the immediate successor of a node is called the child node of that node.
    - **root node:** the topmost node of a tree or the node which does not have any parent node is called the root node.
    - **leaf node or external node:** the node which do not have any child nodes are called leaf nodes.
    - **ancestor of a node:** any predecessor nodes on the path of the root to that node are called ancestors of theat node.
    - **descendant:** a node x is a descendant of another node y if and only if y is an ancestor of x.
    - **sibling:** children of the same parend node are called siblings.
    - **level of a node:** the count of edges on the path from the root node to that node.
    - **internal node:** a node with at least one child is called internal node.
    - **neighbour of a node:** parent or child nodes of that node are called neighbours of that node.
    - **subtree:** any node of tha tree along with its descendant.
    - **depth of node:** the depth of node x can be defined as the length of the path from the root to the node x.
    - **height of node:** the height of node x can be defined as the longest path from the node x to the leaf node.
4. A non-empty tree must contain exactly one root node and exactly one path from the root to all other nodes of the tree.
5. the root node has level 0.
6. the root node has 0 depth.
7. tree is also known as a recursive data structure.
8. tree provides moderate access/search (quicked than linked list and slower than arrays).
9. insertion/deletion (quicker than arrays and slower than unordered linked lists).
10. like linked list and unlike arrays, trees don't have any upper limit on the number of nodes as nodes are linked using pointers.

Type:
1. **binary tree:** it is a non-linear data structure in which each node can have at most two children which are referred to as the left child and the right child.
    - each node in a binary tree has 3 part: 
        - data.
        - pointer to the left child.
        - pointer to the right child.
    - level start from 0 and the maximum number of nodes at level L of a binary tree is 2 to the power L. for level 0 2 to the power 0 = 1, for 1 its 2, for 2 its 4 and so on.
    - the maximum number of nodes in a binary tree of height H is (2 to the power H) - 1.
    - total number of leaf nodes in a binary tree = total number of nodes with 2 children + 1.
    - in a binary tree with N nodes, the minimum possible height or the minimum number of levels in Log2(N+1).
    - A binary tree with L leaves has at least | Log2L | + 1 levels.
    - Type of binary tree:
        - on the basis of number of children: 
            1. **full binary tree:** a full binary tree is a binary tree with either 0 or two child for each node.
            2. **degenerate binary tree:** every non-leaf node has just one child in a binary tree known as a degenerate binary tree. the tree effectively transforms into a linked list as a result, with each node linking to its single child.
                - Type:
                    - **left-skewed tree:** if all nodes in the degenerate tree have only a left child.
                    - **right-skewed tree:** if al the nodes in the degenerate tree have only a right child.
        - on the basis of completion of levels:  
            1. **complete binary tree:** a complete binary tree is a tree in which all the nodes are completely filled except the last level. in the last level all the nodes must be as left as possible. in a complete binary tree, the nodes should be added from the left.
            2. **perfect binary tree:** a perfect binary tree is a special type of binary tree in which all the leaf nodes are at the same depth, and all non-leaf nodes have two children. this means that all leaf nodes are at the maximum depth of the tree, and the tree is completely filled with no gaps.
                - a tree with only the root node is also a perfect binary tree.
            
            3. **balanced binary tree:** the balanced binary tree is a tree in which both the left and right trees differ by atmost 1.

                       4
                      / \
                     2   5
                    / \   \
                   1   3   6

                here height of 1 is 0 and of 3 is 0. height of 2 = 1 + max(1, 3) = 1 + max(0,0) = 1. again height of 6 is 0 height of 5 = 1 + max(-1, 0) = 1 + 0 = 1. difference between 2 and 5 is 0. so it is a balanced tree.
        - on the basis of node values:
            1. **binary search tree:** a binary search tree is a data structure used in computer science for organizing and storing data in sorted manner. Each node in a binary search tree has at most two children, a left child and a right child, with the left child containing values less than the parent node and the right child containing values greater than the parent node.
            
                Note:
                1. in BST, we can use two popular methods to delete a node:
                    - The right child's leftmost (minimum) node (known as the in-order successor).
                    - The left child's rightmost (maximum) node (known as the in-order predecessor).

                    we can implement it using both recursive and iterative technique.