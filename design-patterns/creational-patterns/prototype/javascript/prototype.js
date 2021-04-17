class Dog{
    
    constructor(name, age){
        this.name = name;
        this.age = age;        
    }

    Bark(){
        return "woof-woof";
    }

    Clone(){
        return new Dog(this.name, this.age);
    }
}

export default Dog;