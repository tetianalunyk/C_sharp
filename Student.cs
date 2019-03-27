using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        private Person _person;
        private Education _osvita;
        private int _group;
        private Exam[] _sesia;
        public Student()
        {
            Person _new = new Person();
            _person = _new;
            _osvita = Education.Bachelor;
            _group = 0;
            _sesia = new Exam[0];
        }

        public Student(Person osoba, Education osv, int gr)
        {
            _person = osoba;
            _osvita = osv;
            _group = gr;
            _sesia = new Exam[0];
        }

        public Education _educ
        {
            get { return _osvita; }
            set { _osvita = value; }
        }

        public int group
        {
            get { return _group; }
            set { _group = value; }
        }

        public Exam[] _Exam
        {
            get { return _sesia; }
            set { _sesia = value; }
        }

        public double GetEverage()
        {
            if (_sesia.Length == 0) return 0;
            int sum = 0;
            for (int i = 0; i < _sesia.Length; i++)
                sum += _sesia[i].mark;
            return sum / _sesia.Length;
        }

        public bool this[Education value]
        {
            get
            {
                if (_osvita == value) return true;
                else return false;
            }
        }

        public void AddExams(Exam[] exams)
        {
            Exam[] nov;
            nov = new Exam[_sesia.Length + exams.Length];
            for (int i = 0; i < _sesia.Length; i++)
            {
                nov[i] = _sesia[i];
            }
            int j = 0;
            for (int i = _sesia.Length; i < _sesia.Length + exams.Length; i++)
            {
                nov[i] = exams[j++];
            }
            _sesia = nov;
        }

        public override string ToString()
        {
            string temp = "";
            for (int i = 0; i < _sesia.Length; i++) temp += _sesia[i].ToString() + "\r\n";
            return "Education: " + _osvita + "\n Group: " + _group + "\n Exams: " + temp;
        }

        public virtual string ToShortString()
        {
            return $"Education: {_osvita} Group: {_group} Marks: {GetEverage()}";
        }

    }
}
