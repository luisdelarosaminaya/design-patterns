# :warning: Singleton pattern

![singleton-pattern](https://github.com/luisdelarosaminaya/design-patterns/blob/master/images/UML/singleton.png)

# Description

Singleton pattern is a [creational pattern](https://github.com/luisdelarosaminaya/design-patterns#creational-patterns). Its objective is to always provide the same object when instantiating a class.

A commonly used example is a database connection: to avoid the cost of creating a new connection object for each interaction with the database, the implementation of the singleton pattern would be an option to consider.

However, the assumption that only one class instance is required is probably false, and the inflexibility of this pattern in such a scenario, may result in the conclusion that it is an anti-pattern rather than a pattern.

In addition to the aforementioned, there are other related aspects, such as thread-safety bugs and the difficulty to perform tests.
\
\
\
**Note**: Any pattern implemented in the wrong context would make it an "anti-pattern". :point_left:

## References
* [Michael Safyan](https://www.michaelsafyan.com/tech/design/patterns/singleton)
* [geeksforgeeks.org](https://www.geeksforgeeks.org/singleton-design-pattern/)
