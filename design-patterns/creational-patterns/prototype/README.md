# Prototype Pattern

![prototype-pattern](https://github.com/luisdelarosaminaya/design-patterns/blob/master/images/UML/prototype.png)

# Description

The Prototype pattern is a [creational pattern](https://github.com/luisdelarosaminaya/design-patterns#creational-patterns). Its objective is to create a clone or copy of a previously instantiated object.

I found this real world analogy on [refactoring.guru](https://refactoring.guru/design-patterns/prototype):
</br>

>![mitotic-cell-division](https://refactoring.guru/images/patterns/content/prototype/prototype-comic-3-en.png)
>
>Since industrial prototypes don’t really copy themselves, a much closer analogy to the pattern is the process of mitotic cell division (biology, remember?). After mitotic division, a pair of identical cells is formed. The original cell acts as a prototype and takes an active role in creating the copy.

You can create a clone of an object simply by copying its fields to another object (same class obviously). But in case there are fields that cannot be accessed externally, how would we copy those fields to the new object?

Fortunately, most languages ​​allow you, from within a class, to access the private fields of an instance of the same class. The prototype pattern optimizes the object cloning process, thanks to this ability.

If the constructor of a class executes very expensive tasks for the initialization of an object, and later several objects of this type will be required, implementing the prototype pattern, you would not have to repeat those tasks.

## References
* [refactoring.guru](https://refactoring.guru/design-patterns/prototype)
* [tutorialspoint.com](https://www.tutorialspoint.com/design_pattern/prototype_pattern.htm)
* [sourcemaking.com](https://sourcemaking.com/design_patterns/prototype)
* [springframework.guru](https://springframework.guru/gang-of-four-design-patterns/prototype-pattern/)
