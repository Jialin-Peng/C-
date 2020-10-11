using System;

namespace ConsoleApp3
{
    class Person
    {
        protected string name;
        protected int age;
        protected string sex;

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        } 
        public void setAge(int age)
        {
            this.age = age;
        }
        public int getAge()
        {
            return age;
        }
        public void setSex(string sex)
        {
            this.sex = sex;
        }
        public string getSex()
        {
            return sex;
        }
    }

    class Student : Person
    {
        protected double Chinese;
        protected double Math;
        protected double English;
        protected double History;
        protected double Politics;

        public Student(string name,int age,string sex,double chinese, double math, double english, double history, double politics)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
            Chinese = chinese;
            Math = math;
            English = english;
            History = history;
            Politics = politics;
        }

        public double averageScores()
        {
            return (Chinese + Math + English + History + Politics) / 5;
        }
        public double getChinese()
        {
            return Chinese;
        }
        public void setChinese(double chinese)
        {
            Chinese = chinese;
        }
        public double getMath()
        {
            return Math;
        }
        public void setMath(double math)
        {
            Math = math;
        }
        public double getEnglish()
        {
            return English;
        }
        public void setEnglish(double english)
        {
            English = english;
        }
        public double getHistory()
        {
            return History;
        }
        public void setHistory(double history)
        {
            History = history;
        }
        public double getPolitics()
        {
            return Politics;
        }
        public void setPolitics(double politics)
        {
            Politics = politics;
        }
    }

    class Test
    {
        public static void Main(String[] args)
        {
            Student student = new Student("张山",21,"男",70, 80, 75, 74, 89);
            Console.WriteLine("该学生的姓名为：" + student.getName() +
                               "\n该学生的年龄为："+student.getAge()+
                               "\n该学生的性别为："+student.getSex()+
                               "\n该学生的语文成绩为：" + student.getChinese() +
                               "\n该学生的数学成绩为：" + student.getMath() +
                               "\n该学生的英语成绩为：" + student.getEnglish() +
                               "\n该学生的历史成绩为：" + student.getHistory() +
                               "\n该学生的政治成绩为：" + student.getPolitics()+
                               "\n该学生五科平均成绩为：" + student.averageScores());
        }
    }

}
