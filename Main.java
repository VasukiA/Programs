class Base {
    Base() {
        System.out.println("Base Class Constructor");
    }
}
class Derived extends Base {
    Derived() {
        super();
    }
}
public class Main{

     public static void main(String []args){
        Derived derivedObj=new Derived();
     }
}
