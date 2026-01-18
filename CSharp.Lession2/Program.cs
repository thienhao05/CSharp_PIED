namespace CSharp.Lesson2;

class Program
{
    

    class Student
    {
       // Constructor - hàm khởi tạo, phễu
       // 1 Class có thể có nhiều constructor đc không ? Yes I do
       // 1 Class thì ko có 1 đoạn code nào về constructor đc không | Yes I do
            // 1 Empty Constructor sẽ được khởi tạo mặc định, ngay cả khi chúng ta không khai báo luôn
        // Khi có nhiều constructor trong class thì nó được gọi là - Constructor Overloading
        public string name;
        public int age;
        
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Student()
        {
            this.name = "Hào";
            this.age = 20;
        }

    }
    

    static void Main(string[] args)
    {
       
    }
}