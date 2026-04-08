namespace Person;
    public class Person
    {
        private string name;
        private string gender;
        private int age;
        public Person(string newName, string newGender,
            int newAge)
        {
            name = newName;
            gender = newGender;
            age = newAge;
        }

        public void Salute()
        {
            Console.WriteLine($"Hi, my name is {name}, and I am {age} years old.");
        }
    }public class Student:Person
    {
        private string major;
        private int currentSemester;
        public Student(
            string newName,
            string newGender,
            int newAge,
            string newMajor,
            int newSemester
        ) : base(newName, newGender, newAge)
        {
            major = newMajor;
            currentSemester = newSemester;
        }
        public void AttendClass()
        {
            Console.WriteLine($"I am attending to a class in the {major} major.");
        }
        public void DoHomework()
        {
            Console.WriteLine($"I am doing homework.");
        }
    
    }
