namespace CSharp.Lesson2;

class Program
{
    //tại sao struct là Value Type ?
    //struct khác gì với Reference Type ?
    struct Point
    {
        //truyền giá trị vô thì dùng struct
        public int x;
        public int y;
        //value type chỉ liên quan tới giá trị thôi
    }

    class Student
    {
        public int Age{get;set;}
        //method
        //kế thừa
    }
    

    static void Main(string[] args)
    {
        //Struct và class khác nhau ở đâu
        //class
        Student s1 = new Student(){Age = 20};
        Student s2 = s1; //3 vùng nhớ đc tạo ra thì s2 cũng sẽ tham chiếu đến s1
        // đến vùng nhớ HEAP lưu địa chỉ của s1
        s2.Age = 30;
        //tại vì 2 thằng này tham chiếu tới nhau
        Console.WriteLine("Demo class - Age s1 = " + s1.Age);//30
        Console.WriteLine("Demo class - Age s2 = " + s2.Age);//30
        
        //struct
        Point p1 = new Point{x = 1, y = 2};
        Point p2 = p1;
        p2.x = 20;
        Console.WriteLine("Demo struct - Point p1 = " + p1.x);//1
        Console.WriteLine("Demo struct - Point p2 = " + p2.x);//20
        //p1 và p2 thì x của nó vẫn ko thay đổi
        //càng làm khẳng định struct nó chính là value type
        //thì nó sẽ chơi những thứ liên quan tới value
        //còn reference type là class thì nó là những thứ như là địa chỉ, vùng nhớ
    }
}