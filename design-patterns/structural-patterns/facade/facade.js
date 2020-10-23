class PhotoEditorFacade{
    constructor(photo){
        this.photo = photo;
        this.editor = new PhotoEditor();        
    }

    crop(width, height){
        // omitted...        
    }

    effects(){
        // omitted...        
    }

    filters(){
        // omitted...        
    }
}

class PhotoEditor{
    // Complex class
}

export default PhotoEditorFacade;