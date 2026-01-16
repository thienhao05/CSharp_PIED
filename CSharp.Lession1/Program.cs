namespace CSharp.Lession1;

class Program
{
    static void Main(string[] args)
    {
        // ValueType và Reference Type
        
        // ValueType 
        
            // Số nguyên
            // short
            // ushort
            // int
            // uint - int ko âm
            // long
            // ulong
            
            // Số thực
            // float
            // double
            // decimal
            
            // Khác
            // char
            // bool
            
            // struct: value Type còn class là reference type
        
        // Reference Type
            // class: mọi class mà bạn định nghĩa 
            // array
            // string
            // object
        
        // Về vùng nhớ
        // int a = 2; //thì a này sẽ được lưu ở vùng nhớ
        // Value Type đc khai báo ra thì sẽ có một vùng nhớ được sử dụng (Stack - Ram)
        
        // Anh có 1 class Student 
        // Sau đó anh new mới Student s = new Student()
        // 2 vùng nhớ stack và heap và sau đó vùng nhớ stack đó sẽ tham chiếu s tham chiếu đến vùng nhớ đc tạo mới trong heap
        // Khi mà gõ câu lệnh này thì sẽ có 2 vùng nhớ đc sử dụng (Stack và Heap)
            // keyword s (biến tham chiếu) sẽ sử dụng vùng nhớ Stack
                // và tham chiếu đến object vừa đc tạo ra trong HEAP
                // thì làm sao để tham chiếu đc, nó lưu lại địa chỉ của thằng tạo ra trong HEAP
        
        // Student s1 = new Student()
        // Student s2 = s1
        // s1 và s2 sẽ được tạo ra trên Stack 
        // 1 object Student sẽ đc tạo ra trên HEAP
        // lúc này s1 và s2 sẽ cùng tham chiếu đến đối tượng được tạo ra trên HEAP
        
        // những biến hoặc hàm được khai báo static thì nó sẽ nằm ở vùng nhớ riêng, và tồn tại
            // suốt vòng đời của app/chương trình (Bài OOP sẽ demo 1 thứ căng thẳng)
                
        // Các kiều in ra màn hình

        // int a = 1;
        // int b = 2;
        
        // Traditional Style
        // Console.WriteLine("Number a= " + a);
        // Console.WriteLine("Number b= " + b);
        
        // Modern Style - PlaceHolder: thay thế
        // Console.WriteLine("PlaceHolder - Number a = {0}", a);
        // Console.WriteLine("PlaceHolder - Number b = {0}", b);
        // Console.WriteLine("PlaceHolder - Number a and b = {0}, {1}", a, b);
        
        // Modern Style - Interpolation
        // Console.WriteLine($"Interpolation - Number a = {a}");
        // Console.WriteLine($"Interpolation - Number b = {b}");
        // Console.WriteLine($"Interpolation - Number a and b = {a}, {b}");
        
        // Implicit declaration
        // tự suy luận kiểu dữ liệu dựa tên input mình truyền vào
        // Tại sao nên dùng var ?
        var i = "";
        // Console.WriteLine(i);
        // Console.WriteLine(i.GetType());
        
        // Function - Method
        // Pass By Value
        // static void InSoRaManHinh(int a)
        // {
        //     Console.WriteLine(a);
        // }
        //
        // InSoRaManHinh(36);
        
        // C# nó ra đời 2 cái món mới, độc lạ là out và ref
        // Thì hàm này sẽ nhận tham số là 1 con trỏ
        // thằng này gọi là Pass By Reference

        int m = 3;

        static void PassByReference(ref int a)
        {
            a = 36;
        }
        
        // Console.WriteLine("Before Number m = " + m);
        // PassByReference(ref m);
        // Console.WriteLine("After Number m = " + m);
        
        // Ref này là bth rồi, out nè
        // Khi chơi với out là phải bắt buộc sửa lại biến tham số, độ lại value cho tham số
        // Out này có nghĩa rằng là, tao hứa sẽ OUT cho mày một giá trị
        // Out này không cần phải khai báo giá biến bên ngoài, chuyền vô luôn

        static void PassByReferenceV2(out int b)
        {
            // int b;
            b = 36; //tính hiệu đấm lộn
            Console.WriteLine("Number b = " + b);
            //return b;
        }

        // int n = 3636;
        // Console.WriteLine("Before Number n = " + n);
        // PassByReferenceV2(out n);
        // Console.WriteLine("After Number n = " + n);
        
        // int g;
        // PassByReferenceV2(out g);
        // Console.WriteLine("After Number g = " + g);
        
        // Console.WriteLine("Before Number n = " + n);
        //viết theo kiểu này khi xài out
        // PassByReferenceV2(out int l);
        // Console.WriteLine("After Number l = " + l);
        
        // Viết hàm nhận vào n va tính tổng từ 0 -> n trả ra sum không cần return luôn
            // return là gà

        // static void SumInt(int n, out int result)
        // {
        //     result = 0;
        //     for (int i = 0; i < n; i++)
        //     {
        //         result += i;
        //     }
        // }
        //
        // SumInt(10,  out int result);
        // Console.WriteLine("Result result = " + result);
        
        // Point p1 = new Point(){x = 1, y = 2};
        
        //Struct và class khác nhau ở đâu
        //Struct là value type, nhỏ gọn hơn so với class, ko có kế thừa, method, như là class
        Student s1 = new Student(){Age = 10};
        Student s2 = s1;
        s2.Age = 20;
        // Console.WriteLine("Age s1 = " + s1.Age);
        // Console.WriteLine("Age s2 = " + s2.Age);
        
        Point p1 = new Point(){x = 1, y = 2};
        Point p2 = p1;
        p2.x = 2;
        Console.WriteLine("Point p1 = " + p1.x);
        Console.WriteLine("Point p2 = " + p2.x);


    }

    class Student
    {
        public int Age {get;set;}
        //method
        //kế thừa
    }
    
    struct Point
    {
        //truyền giá trị vô thì dùng struct đi nha
        public int x;
        public int y;
    }
    
}