﻿
using Data_Structure___Algorithm.Structures.StructureArray;
using Data_Structure___Algorithm.Structures.StructureLinkedList;
using Data_Structure___Algorithm.Structures.StructureLinkedList.Doubly;
using Data_Structure___Algorithm.Structures.StructureLinkedList.Doubly.Operations;
using Data_Structure___Algorithm.Structures.StructureLinkedList.Singly;
using Data_Structure___Algorithm.Structures.StructureLinkedList.Singly.Operations;

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

// singly linked list:

//Node head = new(1);
//head.next = new(2);
//head.next.next = new(3);

//ShowLinkedList.ShowSingly(head);

//// insert at front:
//head = SinglyInsert.InsertAtFront(node: head, data: 0);
//// print after insert:
//ShowLinkedList.ShowSingly(head);

//Node head2 = null;
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

DoublyNode node1 = new(data: 1);
DoublyNode node2 = new(data: 2);
DoublyNode node3 = new(data: 3);

node1.next = node2;
node2.next = node3;

node3.previous = node2;
node2.previous = node1;

//ShowLinkedList.ShowDoubly(node: node1, "Show doubly linked list forward and backward");
// insert at front:
node1 = DoublyInsert.InsertAtFront(node: node1, 4);
//ShowLinkedList.ShowDoubly(node: node1, "After insert at front:");
node1 = DoublyInsert.InsertAtEnd(node: node1, 5);
//ShowLinkedList.ShowDoubly(node: node1, "After insert at end:");
node1 = DoublyInsert.InsertAtSpecificPosition(node: node1, position: 3, 6);
ShowLinkedList.ShowDoubly(node: node1, "After insert at position:");
node1 = DoublyDelete.DeleteAtFront(node: node1);
ShowLinkedList.ShowDoubly(node: node1, "After delete at front:");
