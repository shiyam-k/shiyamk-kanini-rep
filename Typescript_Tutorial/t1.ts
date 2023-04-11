var count ="";
console.log(typeof(count))
class c{
    constructor(id:number, name:string){
        this.id = this.setId(id);
        this.name = name;
    }
    public id : number;
    public name : string;
    public get(w:string) : number;
    public get(w:string) : string;
    public get(w:string){
        if(w === "num") {
            return this.id;
        }
        else{
            return this.name;
        }
    }
    public setId(id:number) : number{
        return id;
    }
    
    public setName(name:string) : string{
        return name;
    }
}
class d extends c{
    constructor(id:number, name:string){
        super(id,name);
    }
    
}
let cObj = new c(25,"Me");
let dObj = new d(5,"new me");
console.log(dObj.get("num"))
