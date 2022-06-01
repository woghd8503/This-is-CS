﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// 프로퍼티는 데이터의 오염에 대해선 메소드처럼 안전하고, 데이터를 다룰 때는 필드처럼 간결합니다. 하지만, 많은 경우에 중복된 코드를 작성하고 있다는 기분이 들게 합니다.
// 다음 코드의 NameCard클래스를 보세요. Name과 PhoneNumber 프로퍼티는 단순히 name과 phoneNumber 필드를 읽고 쓰기만 합니다. 여기에는 아무 논리도 섞여 있지 않습니다. 
// 마이크로소프트의 C#팀은 이런 경우에 사용해서 코드를 

namespace Property
{
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }
        
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            birth.Name = "서현";
            birth.Birthday = new DateTime(1991, 6, 28);
            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");
        }
    }

}


