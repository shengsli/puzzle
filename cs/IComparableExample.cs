using System;
using System.Collections.Generic;

namespace StudentApplication
{
    class Student : IComparable<Student>
    {
        //提供有参构造方法，为属性赋值
        public Student(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        //学号
        public int id { get; set; }
        //姓名
        public string name { get; set; }
        //年龄
        public int age { get; set; }
        //重写ToString 方法
        public override string ToString()
        {
            return id + "：" + name + "：" + age;
        }
        //定义比较方法，按照学生的年龄比较
        public int CompareTo(Student other)
        {
            if (this.age > other.age)
            {
                return -1;
            }
            return 1;
        }

        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            list.Add(new Student(1, "ming", 20));
            list.Add(new Student(2, "li", 21));
            list.Add(new Student(3, "zhao", 22));
            list.Sort();
            foreach (Student stu in list)
            {
                Console.WriteLine(stu);
            }
        }
    }
}