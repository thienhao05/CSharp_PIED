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
        //     this.age = 20;
        // }

        // Mục tiêu, hiểu được | public string Name {get; set;}
        // In the old time: khi cần set và get 
        // thì mình cần getter và setter
        private string _name;

        public string GetName()
        {
            return _name;
        }
        
        public void SetName(string name)
        {
            this._name = name;
        }
        
        // Expression Body, nếu như 1 hàm chỉ xử lý 1 và chỉ 1 logic 
        // thì mình có thể thay thế {} bằng =>

        private string _age;
        public string GetAge() => _age;
        public void SetAge(string age) => this._age = age;
        
        // Property - thuộc tính | Đại diện cho Backed-Field
        private string _gender;

        public string Gender
        {
            set { _gender = value; }
            // thì cái này đại diện cho 1 Backed-Field, 
            // Backed-Field nó là biến dùng để lưu trữ info của 1 cái object
            get { return _gender; }
        }

        private string _boyFriendName;
        //Full - Property
        public string BoyFriendName
        {
            set => _boyFriendName = value;
            get => _boyFriendName;
        }
        
        /*
         * Backed-Field là những thuộc tính để mô tả những trạng thái của 1 object thì
         * thay vì sài getter / setter như ngày xưa thì mình phải getName, setName thì nếu
         * mà xài Property thì ở đây cái ngôn ngữ lập trình của mình sẽ tự biên dịch ra luôn
         */
        
        public string House { set; get; } //professor hơn
        // .NET sẽ ngầm tạo một field nằm trong này luôn, lúc này anh chỉ viết mỗi thằng này thôi
        
        // => get mà trả ra gì thì tùy thuộc vào mình 
        private string _money;

        public string Money
        {
            set => _money = value;
            get => _money + "VND";
        }
    }


    static void Main(string[] args)
    {
        //Demo getter / setter
        Student s1 = new Student();
        s1.SetName("John");
        Console.WriteLine("Name: " +s1.GetName());
        
        s1.Gender = "Male";
        Console.WriteLine("Gender: " + s1.Gender);//Male
        //chỉ có .Gender thôi (set và get) nó đều là Gender
        /*
         * Thì .NET nó đẻ ra thuật ngữ này để làm, cho cách sài get và set cho nó tự nhiên
         * sài get và set này 1 cách tự nhiên hơn, => nhanh hơn 1 xíu thì mình sẽ có
         * public string Gender {get; set; }
         */

        s1.BoyFriendName = "Diep";
        Console.WriteLine("BoyFriendName: " + s1.BoyFriendName);
    }
}