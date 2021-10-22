using System;

namespace lab3
{
    //Task 1
    class Person
    {
        public string name { get; set; }
        int age;

        public int setAge
        {
            set { age = value; }
        }
        public int Greet
        {
            get { return age; }
        }

    }

    class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }

        public void ShowAge(int x)
        {
            Console.WriteLine($"My age is: {x} years old");
        }
    }

    class Professor : Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }

    class StudentProfessorTest
    {
        string name { get; set; }

        public StudentProfessorTest(string n)
        {
            this.name = n;
        }

        public void Main()
        {
            Console.WriteLine($"Добрий день, – сказала нова людина на iм'я {name}");
            Student s = new Student();
            s.name = "Микола";
            s.setAge = 19;
            Console.WriteLine($"Привiт студенте {s.name}");
            s.Study();
            s.ShowAge(s.Greet);
            Professor pf = new Professor();
            pf.name = "Степан";
            pf.setAge = 41;
            Console.WriteLine($"Привiт професоре {pf.name}, ваш вiк  - {pf.Greet}");
            pf.Explain();
        }
    }

    //Task 2
    class User
    {
        protected string name;
        protected int age;
        private string name_;
        public string setName
        {
            set { name = name_; }
        }

        public string getName
        {
            get { return name; }
        }

        public int setAge
        {
            set { age = value; }
        }

        public int getAge
        {
            get { return age; }
        }

        public User(int a, string n)
        {
            this.age = a;
            this.name = n;
        }
    }

    class Worker : User
    {
        private int salary;

        public int getSalary
        {
            get { return salary; }
        }

        public int setSalary
        {
            set { salary = value; }
        }

        public Worker(int a, string n, int s) : base(a, n)
        {
            this.salary = s;
        }
    }

    class Student2 : User
    {
        private int stipend;
        private int course;

        public int getStipend
        {
            get { return stipend; }
        }

        public int getCourse
        {
            get { return course; }
        }

        public Student2(int a, string n, int s, int c) : base(a, n)
        {
            this.stipend = s;
            this.course = c;
        }
    }

    class Driver : Worker
    {
        private int experience;
        private string category;

        public int getCategory
        {
            get { return experience; }
        }

        public string getExperience
        {
            get { return category; }
        }

        public Driver(int a, string n, int s, int st, string ca) : base(a, n, s)
        {
            this.experience = st;
            this.category = ca;
        }
    }

    //Task 3
    class Time
    {
        int hours { get; set; }
        int minutes { get; set; }
        int seconds { get; set; }

        public Time(int h, int m, int s)
        {
            this.hours = h;
            this.minutes = m;
            this.seconds = s;
        }

        public void Math()
        {
            Console.WriteLine($"Введений час – {hours}:{minutes}:{seconds}");
            double rez = (hours * 60) + minutes + (seconds / 60);
            Console.WriteLine($"Всього хвилин в зазначеному часу - {rez}");
            Console.WriteLine($"Пiсля збiльшення часу - {rez + 30}");
        }
    }

    class Timetable : Time
    {
        string name { get; set; }
        int room { get; set; }

        public Timetable(int h, int m, int s) : base(h, m, s){ }

        public void Lesson(string time)
        {
            switch(time){
                case "8:30":
                    name = "ООП";
                    room = 22;
                    Console.WriteLine($"1 пара - {name} в {room} ауд.");
                    break;
                case "10:15":
                    name = "ООП";
                    room = 22;
                    Console.WriteLine($"2 пара - {name} в {room} ауд.");
                    break;
                case "12:20":
                    name = "Алгоритми";
                    room = 28;
                    Console.WriteLine($"3 пара - {name} в {room} ауд.");
                    break;
                case "14:05":
                    name = "Алгоритми";
                    room = 12;
                    Console.WriteLine($"4 пара - {name} в {room} ауд.");
                    break;
                case "15:50":
                    name = "Програмування";
                    room = 27;
                    Console.WriteLine($"5 пара - {name} в {room} ауд.");
                    break;
                case "17:36":
                    name = "Дискретна математика";
                    room = 28;
                    Console.WriteLine($"6 пара - {name} в {room} ауд.");
                    break;
                default:
                    Console.WriteLine("Пар немає в зазаначеному часi!");
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StudentProfessorTest spt = new StudentProfessorTest("Олег");
            spt.Main();
            Console.WriteLine("");
            Worker obj = new Worker(25, "iван", 1000);
            Console.WriteLine($"iм'я - {obj.getName}, Вiк - {obj.getAge}, Зарплата - {obj.getSalary}");
            Worker obj2 = new Worker(26, "Вася", 2000);
            Console.WriteLine($"iм'я - {obj2.getName}, Вiк - {obj2.getAge}, Зарплата - {obj2.getSalary}");
            Console.WriteLine($"Суму зарплат - {obj.getSalary + obj2.getSalary}");
            Student2 obj3 = new Student2(18, "Павло", 980, 1);
            Console.WriteLine($"Студент - {obj3.getName}, Вiк - {obj3.getAge}, Стипендiя - {obj3.getStipend}, Курс - {obj3.getCourse}");
            Driver obj4 = new Driver(25, "Iван", 1000, 15, "A");
            Console.WriteLine($"iм'я - {obj4.getName}, Вiк - {obj4.getAge}, Зарплата - {obj4.getSalary}, Водiйський стаж - {obj4.getCategory}, Категорiя водiння  - {obj4.getExperience}");
            Console.Write("Введiть години: ");
            int h = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введiть хвилини: ");
            int m = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введiть секунди: ");
            int s = Convert.ToInt16(Console.ReadLine());
            Timetable tm = new Timetable(h, m, s);
            tm.Math();
            string x = $"{h}:{m}";
            Console.Write("Дисциплiна в зазначений час: ");
            tm.Lesson(x);
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
