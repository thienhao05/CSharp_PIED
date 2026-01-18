namespace CSharp.Lesson2;

class Program
{
    

    class Student
    {
       // Instance Variables - Biến dùng để lưu trữ INFO của 1 Object
       // Age, Name, Gender
       
       // Trong C# thuật ngữ  Instance Variables 
            // - Được gọi là Backed-Field, Data Field
            // - Biến dùng để lưu INFO của 1 Object
        // Nếu mà mình ko ghi public thì mặc định sẽ là private
        // Access Modifier: public - private - protected - default
        // string _id = "36";
        // int b = 36;
        // double c = 3.6;
        
        // Nếu mà mình ko bỏ giá trị khởi tạo, thì sẽ được mang các giá trị mặc định
        // int : 0
        // bool : false
        // Datetime: 01/01/0001 00:00:00
        // string : null
        // class : null
        // array : null
        // struct : 0
        
        // Lưu ý: cho mình dễ nhớ
        // Value Type: 0
        // Reference Type: null (ko có vùng nhớ)
        
        // >_< trả lời string: "", struct: null là sai !!!
        public string name;
        private int age;
    }
    

    static void Main(string[] args)
    {
        Student s1 = new Student();
        Console.WriteLine("Name: " + s1.name); //null nên ko in ra, chứ ko phải chuỗi rỗng nha
    }
}