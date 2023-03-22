using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkesOppgave2
{
    internal class Student
    {
        private string _name;
        private int _age;
        private string _course;
    
        public Student(string name, int age, string course) {
            _name = name;
            _age = age;
            _course = course;
        }
        public void ShowName() {
            Console.WriteLine(this._name);
        }
        public void ShowAge() {
            Console.WriteLine(this._age);
        }
        public void ShowCourse() {
            Console.WriteLine(this._course);
        }
        public void ShowAll() {
            Console.WriteLine(this._name);
            Console.WriteLine(this._age);
            Console.WriteLine(this._course);
        }
        public bool IsParticapent(string course) {
            if (course == this._course) { return true; }
            else { return false; }
        }


    }
}
