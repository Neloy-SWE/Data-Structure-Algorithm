using Data_Structure___Algorithm.Structures.StructureArray;
using Data_Structure___Algorithm.Structures.StructureLinkedList;
using Data_Structure___Algorithm.Structures.StructureLinkedList.Circular;
using Data_Structure___Algorithm.Structures.StructureLinkedList.Circular.OperationCircularLinkedList;
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
CircularNode node2 = null!;

// insert in an empty list:
node2 = CircularInsert.InsertInEmptyList(node2, 2);

// insert in at front:
node2 = CircularInsert.InsertArFront(node2, 1);
node2 = CircularInsert.InsertInEmptyList(node2, 2);

// insert at end:
node2 = CircularInsert.InsertAtEnd(node2, 3);