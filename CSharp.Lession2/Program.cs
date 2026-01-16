namespace CSharp.Lesson2;

class Program
{
    public class Student
    {
        // Instance Variables - Biến dùng để lưu trữ INFO của 1 OBJECT
        // Age, Name, Gender
        
        //Trong C# thuật ngữ Instance Variables
            // - Được gọi tên là Backed-Field, Data Field
            // - Biến dùng để lưu INFO của 1 OBJECT
            
        // Nếu mà mình ko ghi public thì mặc định sẽ là private
        // Access Modifier: public - private - protected - default
        // string _id = "36";
        // int b = 36;
        // double c = 3.6;
        
        // Nếu mà mình ko bỏ giá trị khởi tạo, thì sẽ được mang các giá trị mặc định
        // int: 0
        // bool: false
        // Datetime: 01/01/0001 00:00:00
        // string: null
        // class: null
        // array: null
        // struct: 0

        // public string name;
        
        // Constructor - hàm khởi tạo, phễu
        // 1 Class có thể có nhiều constructor đc ko ? Yes I do
        // 1 Class thì ko có 1 đoạn code nào về contructor đc không | Yes I do
            // 1 Empty Constructor sẽ được khởi tạo mặc định, ngay cả khi chúng ta không khai báo luôn
        // Khi có nhiều constructor trong class thì nó được gọi là - Constructor Overloading
        // public string name;
        // public int age;
        //
        // public Student(string name, int age)
        // {
        //     this.name = name;
        //     this.age = age;
        // }
        //
        // public Student()
        // {
        //     this.name = "Hào";
        //     this.age = 10;
        // }

        //Mục tiêu, hiểu được | public string Name {get; set;}
        // In the old time: Ngày xửa ngày xưa, khi cần get và set giá trị cho 1 field
            // Thì ta cần getter va setter
            
        private string _name;
        
        public string GetName()
        {
            return _name;
        }
        
        public void SetName(string name)
        {
            this._name = name;
        }
        
        // Expression Body, nếu như 1 hàm chỉ xử lý 1 và chỉ 1 logic đơn giản  
        // thì mình có thể thay thế {} bằng =>
        
        private string _age;
        public string GetAge() => _age;
        public void SetAge(string age) => this._age = age;
        
        // Property - thuộc tính | Đại diện cho Backed-Field
        private string _gender;

        public string Gender
        {
            set {_gender = value;}
            get {return _gender;}
        }
        
        //
        
        private string _boyFriendName;
        //Full-Property
        public string BoyFriendName
        {
            set => _boyFriendName = value;
            get => _boyFriendName;
        }

        //xào nấu bên trong 1 tí
        private string _money;
        public string Money
        {
            set => _money = value;
            get => _money + "VND";
        }
        
        public string House { set; get; }
    }

    public class Person
    {
        public static int Age { get; set; } //nằm ở vùng nhớ riêng ko chơi heap và stack
        public string Name { get; set; }
        public string Gender { get; set; }

        public Person(int age, string name, string gender)
        {
            Age = age;
            Name = name;
            Gender = gender;
        }

        public string GetAge()
        {
            return Age.ToString();
        }
    }
    
    //Static là 1 vùng nhớ riêng, không chơi chung với mấy thằng còn lại
    public abstract class Shape
    {
        public string Name;
        public abstract double Area();
    }

    // class: Parent Class, Interface1, Interface2
    // 1 class trong C# chỉ có kế thừa 1 cha | Diamond 
    // tại sao 1 class chỉ có thể có 1 cha trong C# ? 
    
    public class Rectangle : Shape
    {
        public override double Area()
        {
            throw new NotImplementedException();
        }
    }
    
    static void Main(string[] args)
    {
        // Student s1 = new Student();
        // Console.WriteLine("Id: ", s1._id);
        // Student s2 = new Student("Hien", 18);
        // Console.WriteLine("Name: ", s1.name); //null nên ko in ra 
        
        // Demo getter/setter
        // Student s1 = new Student();
        // s1.SetName("Binh");
        // Console.WriteLine("Name: " + s1.GetName());
        //
        // s1.Gender = "Female";
        // Console.WriteLine("Gender: " + s1.Gender);
        //
        // s1.BoyFriendName = "Diep";
        // Console.WriteLine("BoyFriendName: " + s1.BoyFriendName);
        
        Person p1 = new Person(10, "Tan", "Male");
        Person p2 = new Person(20, "Binh", "Male");
        // // p1.Age = 123; //nằm ở vùng nhớ khác, giá trị của age đc khởi tạo, 3 thằng này ở 3 vùng nhớ khác nhau,
        // ko dùng chấm cái gì(có gì đâu mà chấm)
        // //cham gi
        Console.WriteLine("p1: " + p1.GetAge()); //20
        Console.WriteLine("p2: " + p2.GetAge()); 
    }
}