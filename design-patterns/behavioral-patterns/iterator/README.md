# Iterator pattern

![iterator-pattern](https://github.com/luixcode/design-patterns/blob/dev/images/UML/iterator.png)

# Description

Iterator pattern is a [behavioral pattern](https://github.com/luixcode/design-patterns#behavioral-patterns). Its objective is to facilitate the navigation through the elements of a collection (array, binary tree, linked list, hash table, etc.) without the need to interact directly with its underlying representation (read: the way the data is stored). 

The key idea is to delegate access and traversal of a collection to an object called Iterator. Collections provide different ways of accessing their elements: by defining a uniform Iterator interface for collections, you can decouple them from the algorithms that will interact with those collections.

## References
* [sourcemaking.com](https://sourcemaking.com/design_patterns/iterator)
* [refactoring.guru](https://refactoring.guru/design-patterns/iterator)
