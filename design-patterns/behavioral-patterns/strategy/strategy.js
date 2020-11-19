class Boxer{    

    constructor(punch){
        this._punch = punch;
    }

    set punching(punch){
        // Omitted...
        this._punch = punch;
    }

    punch(){
        // Omitted...
        this._punch();
    }
}

function jab(){
    console.log('jab punch!!');
}

function cross(){
    console.log('cross punch!!');
}

function hook(){
    console.log('hook punch!!');
}

function uppercut(){
    console.log('uppercut punch!!');
}

export { Boxer, jab, cross, hook, uppercut };