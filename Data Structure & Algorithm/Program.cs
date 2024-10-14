using Data_Structure___Algorithm.Structures.StructureArray;
using Data_Structure___Algorithm.Structures.StructureLinkedList;
using Data_Structure___Algorithm.Structures.StructureLinkedList.Circular;
using Data_Structure___Algorithm.Structures.StructureLinkedList.Circular.OperationCircularLinkedList;
using Data_Structure___Algorithm.Structures.StructureLinkedList.CircularDoubly;
using Data_Structure___Algorithm.Structures.StructureLinkedList.CircularDoubly.OperationCircularDoublyLinkedList;
using Data_Structure___Algorithm.Structures.StructureLinkedList.Doubly;
using Data_Structure___Algorithm.Structures.StructureLinkedList.Doubly.Operations;
using Data_Structure___Algorithm.Structures.StructureLinkedList.Singly;
using Data_Structure___Algorithm.Structures.StructureLinkedList.Singly.Operations;
using Data_Structure___Algorithm.Structures.StructureQueue.Circular;
using Data_Structure___Algorithm.Structures.StructureQueue.DoubleEnded.InputRestricted;
using Data_Structure___Algorithm.Structures.StructureQueue.DoubleEnded.NonRestricted;
using Data_Structure___Algorithm.Structures.StructureQueue.DoubleEnded.OutputRestricted;
using Data_Structure___Algorithm.Structures.StructureQueue.Simple;
using Data_Structure___Algorithm.Structures.StructureStack;
using System.Xml.Linq;

/// array

//BasicArray basicArray = new();
//basicArray.InitializeHelper();
//basicArray.ShowDynamic();

//ArrayOperation arrayOperation = new();
//arrayOperation.Traverse();
//arrayOperation.InsertElement(arrayOperation.GetFixedSizedArray(), arrayOperation.GetFixedSizedArray().Length, 10, 2);
//arrayOperation.FindElement(arrayOperation.GetFixedSizedArray(), 10);
//arrayOperation.Deletion(arrayOperation.GetFixedSizedArray(), 10);

//DimensionalArray dimensionalArray = new DimensionalArray();
//dimensionalArray.GetDimensionalArray();


/// linked list

//singly linked list:
//SinlglyNode head = new(1);
//head.next = new(2);
//head.next.next = new(3);

//ShowLinkedList.ShowSingly(head, "Linked list traverse.");

//// insert at front:
//head = SinglyInsert.InsertAtFront(node: head, data: 0);
//// print after insert:
//ShowLinkedList.ShowSingly(head, "After insert at front");

////Node head2 = null;
//SinlglyNode head2 = new(10);
//// insert at end:
//head2 = SinglyInsert.InsertAtEnd(node: head2, data: 5);
//head2 = SinglyInsert.InsertAtEnd(node: head2, data: 6);
//head2 = SinglyInsert.InsertAtEnd(node: head2, data: 7);
////ShowLinkedList.ShowSingly(head2);
////head2 = SinglyInsert.InsertAtSpecific(node: head2, data: 1, key: 7);
//head2 = SinglyInsert.InsertAtGivenNode(node: head2, data: 1, key: 10);
//// insert at a specific point:
////ShowLinkedList.ShowSingly(head2);
//head2 = SinglyInsert.InsertAtSpecificPosition(node: head2, data: 8, position: 3);
//ShowLinkedList.ShowSingly(head2, "After insert at specific position:");


//// delete at front:
//head2 = SinglyDelete.DeleteAtFront(node: head2);
//ShowLinkedList.ShowSingly(head2, "After delete from front");

//// delete at end:
//head2 = SinglyDelete.DeleteAtEnd(node: head2);
//ShowLinkedList.ShowSingly(head2, "After delete from end");

//// delete at position:
//ShowLinkedList.ShowSingly(SinglyDelete.DeleteAtPostion(node: head2, position: 2), "After delete at position: 2");

//// search:
//SinglySearch.Get(head2, 5);


// doubly linked list:

//DoublyNode node1 = new(data: 1);
//DoublyNode node2 = new(data: 2);
//DoublyNode node3 = new(data: 3);

//node1.next = node2;
//node2.next = node3;

//node3.previous = node2;
//node2.previous = node1;

////ShowLinkedList.ShowDoubly(node: node1, "Show doubly linked list forward and backward");
//// insert at front:
//node1 = DoublyInsert.InsertAtFront(node: node1, 4);
////ShowLinkedList.ShowDoubly(node: node1, "After insert at front:");

//// insert at end:
//node1 = DoublyInsert.InsertAtEnd(node: node1, 5);
////ShowLinkedList.ShowDoubly(node: node1, "After insert at end:");

//// insert at specific position:
//node1 = DoublyInsert.InsertAtSpecificPosition(node: node1, position: 3, 6);
//ShowLinkedList.ShowDoubly(node: node1, "After insert at position:");

//// delete at fornt:
//node1 = DoublyDelete.DeleteAtFront(node: node1);
//ShowLinkedList.ShowDoubly(node: node1, "After delete at front:");
////node1 = DoublyDelete.DeleteAtFront(node: node1);
////ShowLinkedList.ShowDoubly(node: node1, "After delete at front:");
////node1 = DoublyDelete.DeleteAtFront(node: node1);
////ShowLinkedList.ShowDoubly(node: node1, "After delete at front:");
////node1 = DoublyDelete.DeleteAtFront(node: node1);
////ShowLinkedList.ShowDoubly(node: node1, "After delete at front:");
////node1 = DoublyDelete.DeleteAtFront(node: node1);
////ShowLinkedList.ShowDoubly(node: node1, "After delete at front:");
////node1 = DoublyDelete.DeleteAtFront(node: node1);
////ShowLinkedList.ShowDoubly(node: node1, "After delete at front:");
////node1 = DoublyDelete.DeleteAtFront(node: node1);
////ShowLinkedList.ShowDoubly(node: node1, "After delete at front:");

//// delete at end:
//node1 = DoublyDelete.DeleteAtEnd(node: node1);
//ShowLinkedList.ShowDoubly(node: node1, "After delete at end:");
////node1 = DoublyDelete.DeleteAtEnd(node: node1);
////ShowLinkedList.ShowDoubly(node: node1, "After delete at end:");
////node1 = DoublyDelete.DeleteAtEnd(node: node1);
////ShowLinkedList.ShowDoubly(node: node1, "After delete at end:");
////node1 = DoublyDelete.DeleteAtEnd(node: node1);
////ShowLinkedList.ShowDoubly(node: node1, "After delete at end:");
////node1 = DoublyDelete.DeleteAtEnd(node: node1);
////ShowLinkedList.ShowDoubly(node: node1, "After delete at end:");
////node1 = DoublyDelete.DeleteAtEnd(node: node1);
////ShowLinkedList.ShowDoubly(node: node1, "After delete at end:");

//// delete after a given node:
//node1 = DoublyDelete.DeleteAfterAGivenNode(node: node1, key: 6);
//ShowLinkedList.ShowDoubly(node: node1, "After delete after a given node 6:");

//// delete before a given node:
//node1 = DoublyDelete.DeleteBeforeAGivenNode(node: node1, key: 3);
//ShowLinkedList.ShowDoubly(node: node1, "After delete before a given node 3:");

//// delete at a specific position:
//node1 = DoublyDelete.DeleteAtSpecificPosition(node: node1, position: 2);
//ShowLinkedList.ShowDoubly(node: node1, "After delete at a specific position 2:");

//// search:
//DoublySearch.get(node: node1, position: 3);
//node1 = DoublyInsert.InsertAtEnd(node: node1, 20);
//node1 = DoublyInsert.InsertAtEnd(node: node1, 30);
//node1 = DoublyInsert.InsertAtEnd(node: node1, 40);
//ShowLinkedList.ShowDoubly(node: node1, "After adding some element");
//DoublySearch.get(node: node1, position: 3);


// circular linked list:

//CircularNode node1 = new(1);
//node1.next = new(2);
//node1.next.next = new(3);
//CircularNode last1 = node1.next.next;
//last1.next = node1;

//ShowLinkedList.ShowCircular(last1, "Print circular linked list");
//last1 = CircularInsert.InsertInEmptyList(last1,1);
//CircularNode node2 = null!;

//// insert in an empty list:
//node2 = CircularInsert.InsertInEmptyList(node2, 2);

//// insert in at front:
//node2 = CircularInsert.InsertArFront(node2, 1);
//node2 = CircularInsert.InsertInEmptyList(node2, 2);

//// insert at end:
//node2 = CircularInsert.InsertAtEnd(node2, 3);

//// insert at specific position:
//node2 = CircularInsert.InsertAtSpecificPosition(node2, 4, 2);

//node2 = CircularInsert.InsertAtEnd(node2, 7);
//node2 = CircularInsert.InsertAtEnd(node2, 6);
//node2 = CircularInsert.InsertAtEnd(node2, 9);
//node2 = CircularInsert.InsertAtEnd(node2, 8);

// delete at front:
//node2 = CircularDelete.DeleteAtFront(node2);
//node2 = CircularDelete.DeleteAtFront(node2);
//node2 = CircularDelete.DeleteAtFront(node2);
//node2 = CircularDelete.DeleteAtFront(node2);
//node2 = CircularDelete.DeleteAtFront(node2);
//node2 = CircularDelete.DeleteAtFront(node2);

//CircularNode nullCheckNode = CircularDelete.DeleteAtFront(node2);
//ShowLinkedList.ShowCircular(nullCheckNode, "null check node");
//ShowLinkedList.ShowCircular(node2, "node2 check");

// delete at end:
//node2 = CircularDelete.DeleteAtEnd(node2);
//node2 = CircularDelete.DeleteAtEnd(node2);
//node2 = CircularDelete.DeleteAtEnd(node2);
//node2 = CircularDelete.DeleteAtEnd(node2);
//node2 = CircularDelete.DeleteAtEnd(node2);
//node2 = CircularDelete.DeleteAtEnd(node2);

// delete at specific position:
//node2 = CircularDelete.DeleteAtSpecificPosition(node2, 4);
//node2 = CircularDelete.DeleteAtSpecificPosition(node2, 3);
//node2 = CircularDelete.DeleteAtSpecificPosition(node2, 1);
//node2 = CircularDelete.DeleteAtSpecificPosition(node2, 2);
//node2 = CircularDelete.DeleteAtSpecificPosition(node2, 2);
//node2 = CircularDelete.DeleteAtSpecificPosition(node2, 50);
//node2 = CircularDelete.DeleteAtSpecificPosition(node2, 1);
//node2 = CircularDelete.DeleteAtSpecificPosition(node2, 1);
//node2 = CircularDelete.DeleteAtSpecificPosition(node2, 5);
//node2 = CircularDelete.DeleteAtSpecificPosition(node2, 10);

// search based on position:
//CircularSearch.BasedOnPosition(node2, 1);
//CircularSearch.BasedOnPosition(node2, 2);
//CircularSearch.BasedOnPosition(node2, 3);
//CircularSearch.BasedOnPosition(node2, 4);
//CircularSearch.BasedOnPosition(node2, 5);

// search based on value:
//CircularSearch.BasedOnValue(node2, 10);

// circular doubly linked list:

// insert at front:
//CircularDoublyNode node = CircularDoublyInsert.InsertAtFront(null!, 3);
//node = CircularDoublyInsert.InsertAtFront(node, 2);
//node = CircularDoublyInsert.InsertAtFront(node, 1);

//// insert at end:
////CircularDoublyNode node = CircularDoublyInsert.InsertAtEnd(null!, 3);
//node = CircularDoublyInsert.InsertAtEnd(node, 4);

//// insert after node:
////node = CircularDoublyInsert.InsertAfterNode(node, 5, 10);
//node = CircularDoublyInsert.InsertAfterNode(node, 5, 4);

//// insert before node:
////node = CircularDoublyInsert.InsertBeforeNode(node, 7, 10);
//node = CircularDoublyInsert.InsertBeforeNode(node, 7, 5);

//// insert at specific position:
////node = CircularDoublyInsert.InsertAtSpecificPosition(node, 6, 10);
//node = CircularDoublyInsert.InsertAtSpecificPosition(node, 6, 2);

// delete at fornt:
//node = CircularDoublyDelete.DeleteAtFront(node);
//node = CircularDoublyDelete.DeleteAtFront(node);
//node = CircularDoublyDelete.DeleteAtFront(node);
//node = CircularDoublyDelete.DeleteAtFront(node);
//node = CircularDoublyDelete.DeleteAtFront(node);
//node = CircularDoublyDelete.DeleteAtFront(node);
//node = CircularDoublyDelete.DeleteAtFront(node);
//node = CircularDoublyDelete.DeleteAtFront(node);
//node = CircularDoublyDelete.DeleteAtFront(node);

// delete at end:
//node = CircularDoublyDelete.DeleteAtEnd(node);
//node = CircularDoublyDelete.DeleteAtEnd(node);
//node = CircularDoublyDelete.DeleteAtEnd(node);
//node = CircularDoublyDelete.DeleteAtEnd(node);
//node = CircularDoublyDelete.DeleteAtEnd(node);
//node = CircularDoublyDelete.DeleteAtEnd(node);
//node = CircularDoublyDelete.DeleteAtEnd(node);
//node = CircularDoublyDelete.DeleteAtEnd(node);

// delete after node:
//node = CircularDoublyDelete.DeleteAfterNode(node, 3);
//node = CircularDoublyDelete.DeleteAfterNode(node, 6);
//node = CircularDoublyDelete.DeleteAfterNode(node, 3);
//node = CircularDoublyDelete.DeleteAfterNode(node, 6);
//node = CircularDoublyDelete.DeleteAtFront(node);
//node = CircularDoublyDelete.DeleteAfterNode(node, 6);

// delete before node:
//node = CircularDoublyDelete.DeleteBeforeNode(node, 1);
//node = CircularDoublyDelete.DeleteBeforeNode(node, 2);
//node = CircularDoublyDelete.DeleteBeforeNode(node, 5);
//node = CircularDoublyDelete.DeleteBeforeNode(node, 4);
//node = CircularDoublyDelete.DeleteBeforeNode(node, 4);
//node = CircularDoublyDelete.DeleteBeforeNode(node, 4);
//node = CircularDoublyDelete.DeleteBeforeNode(node, 5);
//node = CircularDoublyDelete.DeleteBeforeNode(node, 5);
//node = CircularDoublyDelete.DeleteBeforeNode(node, 100);

// delete specific node:
//node = CircularDoublyDelete.DeleteSpecificNode(node, 6);
//node = CircularDoublyDelete.DeleteSpecificNode(node, 1);
//node = CircularDoublyDelete.DeleteSpecificNode(node, 5);
//node = CircularDoublyDelete.DeleteSpecificNode(node, 4);
//node = CircularDoublyDelete.DeleteSpecificNode(node, 2);
//node = CircularDoublyDelete.DeleteSpecificNode(node, 3);
//node = CircularDoublyDelete.DeleteSpecificNode(node, 100);
//node = CircularDoublyDelete.DeleteSpecificNode(node, 7);
//node = CircularDoublyDelete.DeleteSpecificNode(node, 7);

// delete at specific index:
//node = CircularDoublyDelete.DeleteAtSpecificIndex(node, 4);
//node = CircularDoublyDelete.DeleteAtSpecificIndex(node, 1);
//node = CircularDoublyDelete.DeleteAtSpecificIndex(node, 7);
//node = CircularDoublyDelete.DeleteAtSpecificIndex(node, 4);
//node = CircularDoublyDelete.DeleteAtSpecificIndex(node, 4);
//node = CircularDoublyDelete.DeleteAtSpecificIndex(node, 1);
//node = CircularDoublyDelete.DeleteAtSpecificIndex(node, 2);
//node = CircularDoublyDelete.DeleteAtSpecificIndex(node, 2);
//node = CircularDoublyDelete.DeleteAtSpecificIndex(node, 1);
//node = CircularDoublyDelete.DeleteAtSpecificIndex(node, 10);

// show circular doubly linked list node:
//CircularDoublySearch.ShowSpecificNode(node, 6);

// show circular doubly linked list node at specific index:
//CircularDoublySearch.ShowNodeAtIndex(node, 20);
//CircularDoublySearch.ShowNodeAtIndex(node, 7);


/// stack

// fixed size statck:
//FixedSizedStack fixedSizedStack = new(5);

//// check is empty:
//fixedSizedStack.IsEmpty();

//// push:
//fixedSizedStack.Push(0);
//fixedSizedStack.Push(1);
//fixedSizedStack.Push(2);
//fixedSizedStack.Push(3);

//// pop:
//fixedSizedStack.Pop();
//fixedSizedStack.Push(3);

//// top:
//fixedSizedStack.Top();

//// check is full:
//fixedSizedStack.IsFull();
//fixedSizedStack.Push(4);
//fixedSizedStack.IsFull();
//fixedSizedStack.Push(5);


// dynamic stack:
//DynamicStack dynamicStack = new();

//// push:
//dynamicStack.Push(1);
//dynamicStack.Push(2);
//dynamicStack.Push(3);
//dynamicStack.Push(4);
//dynamicStack.Push(5);
//dynamicStack.Push(4);
////dynamicStack.Push(5);
////dynamicStack.Push(6);
////dynamicStack.Push(7);
////dynamicStack.Push(8);
////dynamicStack.Push(9);
////dynamicStack.Push(10);

//// pop:
//dynamicStack.Pop();

//// top:
//dynamicStack.Top();
//dynamicStack.Pop();
//dynamicStack.Top();

// linked list stack (another dynamic):
//LinkedListAsStack linkedListAsStack = new();

//// push:
//linkedListAsStack.Show();
//linkedListAsStack.Push(1);
//linkedListAsStack.Push(2);
//linkedListAsStack.Push(3);

//// pop:
//linkedListAsStack.Pop();
////linkedListAsStack.Pop();
////linkedListAsStack.Pop();

//// top:
//linkedListAsStack.Top();


/// queue

// array based fixed size queue (simple queue):
//SimpleArrayBasedQueue simpleArrayBasedQueue = new(5);

// enqueue
//simpleArrayBasedQueue.Enqueue(2);
//simpleArrayBasedQueue.Enqueue(3);
//simpleArrayBasedQueue.Enqueue(4);
//simpleArrayBasedQueue.Enqueue(5);
//simpleArrayBasedQueue.Enqueue(1);
//simpleArrayBasedQueue.Enqueue(9);

// dequeue:
//simpleArrayBasedQueue.Dequeue();
//simpleArrayBasedQueue.Enqueue(9);
//simpleArrayBasedQueue.Dequeue();
//simpleArrayBasedQueue.Dequeue();
//simpleArrayBasedQueue.Dequeue();
//simpleArrayBasedQueue.Dequeue();
//simpleArrayBasedQueue.Dequeue();
//simpleArrayBasedQueue.Dequeue();

// front:
//simpleArrayBasedQueue.Front();

// rear:
//simpleArrayBasedQueue.Rear();

// is empty:
//simpleArrayBasedQueue.IsEmpty();

// is full:
//simpleArrayBasedQueue.IsFull();

// linked list based dynamic queue (simple queuea):
//SimpleLinkedListBasedQueue simpleLinkedListBasedQueue = new();

//// enqueue:
//simpleLinkedListBasedQueue.Enqueue(1);
//simpleLinkedListBasedQueue.Enqueue(2);
////simpleLinkedListBasedQueue.Enqueue(3);
////simpleLinkedListBasedQueue.Enqueue(4);

//// dequeue:
//simpleLinkedListBasedQueue.Dequeue();
//simpleLinkedListBasedQueue.Dequeue();
//simpleLinkedListBasedQueue.Dequeue();
////simpleLinkedListBasedQueue.Dequeue();
////simpleLinkedListBasedQueue.Dequeue();

//// front:
////simpleLinkedListBasedQueue.Front();

//// rear:
////simpleLinkedListBasedQueue.Rear();

//// is empty:
//simpleLinkedListBasedQueue.IsEmpty();

// double ended queue:
// nonrestricted:
//NonRestrictedDeque nonRestrictedDeque = new(5);

// enqueue from front:
//nonRestrictedDeque.EnqueueFront(2);
//nonRestrictedDeque.EnqueueFront(1);
//nonRestrictedDeque.EnqueueFront(3);
//nonRestrictedDeque.EnqueueFront(4);
//nonRestrictedDeque.EnqueueFront(5);
//nonRestrictedDeque.EnqueueFront(6);

// enqueue from rear:
//nonRestrictedDeque.EnqueueRear(3);
//nonRestrictedDeque.EnqueueRear(4);
//nonRestrictedDeque.EnqueueRear(5);
//nonRestrictedDeque.EnqueueRear(6);
//nonRestrictedDeque.EnqueueRear(7);

//// dequeue from front:
//nonRestrictedDeque.DequeueFront();
//nonRestrictedDeque.EnqueueFront(1);
//nonRestrictedDeque.EnqueueRear(7);
//nonRestrictedDeque.DequeueFront();
//nonRestrictedDeque.DequeueFront();
//nonRestrictedDeque.EnqueueFront(1);
//nonRestrictedDeque.EnqueueFront(1);
//nonRestrictedDeque.EnqueueRear(7);
//nonRestrictedDeque.EnqueueFront(3);
//nonRestrictedDeque.EnqueueFront(4);
//nonRestrictedDeque.EnqueueFront(4);
//nonRestrictedDeque.DequeueFront();
//nonRestrictedDeque.DequeueFront();
//nonRestrictedDeque.DequeueFront();

// dequeue from rear:
//nonRestrictedDeque.EnqueueRear(3);
//nonRestrictedDeque.EnqueueRear(4);
//nonRestrictedDeque.DequeueRear();
//nonRestrictedDeque.EnqueueRear(3);
//nonRestrictedDeque.EnqueueRear(4);
//nonRestrictedDeque.DequeueRear();
//nonRestrictedDeque.EnqueueRear(3);
//nonRestrictedDeque.EnqueueRear(4);
//nonRestrictedDeque.DequeueRear();
//nonRestrictedDeque.DequeueFront();
//nonRestrictedDeque.DequeueRear();
//nonRestrictedDeque.DequeueFront();
//nonRestrictedDeque.DequeueFront();
//nonRestrictedDeque.DequeueRear();
//nonRestrictedDeque.DequeueFront();
//nonRestrictedDeque.DequeueRear();
//nonRestrictedDeque.DequeueFront();
//nonRestrictedDeque.EnqueueRear(3);
//nonRestrictedDeque.EnqueueFront(1);
//nonRestrictedDeque.EnqueueRear(4);
//nonRestrictedDeque.EnqueueFront(2);
//nonRestrictedDeque.EnqueueFront(2);
//nonRestrictedDeque.EnqueueRear(4);
//nonRestrictedDeque.EnqueueRear(4);

// front:
//nonRestrictedDeque.GetFront();

// rear:
//nonRestrictedDeque.GetRear();

// status:
//nonRestrictedDeque.Status();
//nonRestrictedDeque.DequeueFront();
//nonRestrictedDeque.Status();
//nonRestrictedDeque.DequeueFront();
//nonRestrictedDeque.DequeueFront();
//nonRestrictedDeque.DequeueRear();
//nonRestrictedDeque.DequeueRear();
//nonRestrictedDeque.Status();


// input restricted deque:
//InputRestrictedDeque inputRestrictedDeque = new(5);

// enqueue:
//inputRestrictedDeque.Enqueue(5);
//inputRestrictedDeque.Enqueue(4);
//inputRestrictedDeque.Enqueue(3);
//inputRestrictedDeque.Enqueue(2);
//inputRestrictedDeque.Enqueue(1);
//inputRestrictedDeque.Enqueue(6);

// dequeue from front:
//inputRestrictedDeque.DequeueFront();
//inputRestrictedDeque.Enqueue(7);
//inputRestrictedDeque.DequeueFront();
//inputRestrictedDeque.DequeueFront();
//inputRestrictedDeque.DequeueFront();
//inputRestrictedDeque.DequeueFront();
//inputRestrictedDeque.DequeueFront();
//inputRestrictedDeque.DequeueFront();
//inputRestrictedDeque.DequeueFront();

// dequeue from rear:
//inputRestrictedDeque.DequeueRear();
//inputRestrictedDeque.Enqueue(6);
//inputRestrictedDeque.DequeueRear();
//inputRestrictedDeque.DequeueFront();
//inputRestrictedDeque.DequeueFront();
//inputRestrictedDeque.DequeueRear();
//inputRestrictedDeque.DequeueFront();
//inputRestrictedDeque.DequeueRear();
//inputRestrictedDeque.DequeueRear();
//inputRestrictedDeque.DequeueRear();
//inputRestrictedDeque.DequeueRear();


// output restricted deque:
//OutputRestrictedDeque outputRestrictedDeque = new(5);

// enqueue from front:
//outputRestrictedDeque.EnqueueFront(3);
//outputRestrictedDeque.EnqueueFront(2);

// enqueue form rear:
//outputRestrictedDeque.EnqueueRear(4);
//outputRestrictedDeque.EnqueueFront(1);
//outputRestrictedDeque.EnqueueRear(5);

// dequeue from rear:
//outputRestrictedDeque.DequeueRear();
//outputRestrictedDeque.DequeueRear();
//outputRestrictedDeque.DequeueRear();
//outputRestrictedDeque.DequeueRear();
//outputRestrictedDeque.DequeueRear();
//outputRestrictedDeque.DequeueRear();
//outputRestrictedDeque.EnqueueFront(4);
//outputRestrictedDeque.EnqueueRear(3);
//outputRestrictedDeque.EnqueueFront(2);
//outputRestrictedDeque.DequeueRear();
//outputRestrictedDeque.DequeueRear();
//outputRestrictedDeque.DequeueRear();
//outputRestrictedDeque.DequeueRear();


// circular queue:
CircularQueue circularQueue = new(5);

// enqueue:
circularQueue.Enqueue(1);
circularQueue.Enqueue(2);
circularQueue.Enqueue(3);
circularQueue.Enqueue(4);
circularQueue.Enqueue(5);
circularQueue.Enqueue(6);

// dequeue:
circularQueue.Dequeue();
circularQueue.Enqueue(2);
circularQueue.Enqueue(3);
circularQueue.Dequeue();
circularQueue.Dequeue();
circularQueue.Dequeue();
circularQueue.Dequeue();
circularQueue.Dequeue();
circularQueue.Dequeue();
circularQueue.Enqueue(1);
circularQueue.Dequeue();
circularQueue.Dequeue();
circularQueue.Enqueue(2);
circularQueue.Enqueue(3);
circularQueue.Dequeue();
circularQueue.Enqueue(4);
circularQueue.Enqueue(5);