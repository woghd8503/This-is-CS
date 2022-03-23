﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

// 메소드 오버로딩 vs 선택적 매개변수
// 선택적 인수는 유용한 기능임에 틀림없지만, 메소드 오버로딩과 함께 사용될 때 혼란을 야기할 수도 있습니다. 예를 들어 다음과 같이 두개의 MyMethod()메소드를 오버로딩해봅시다.

namespace _01.BasicGrammar
{
    class LoacalFuction
    {
        static string ToLowerString(string input)
        {
            var arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
            }

            char ToLowerChar(int i)
            {
                if (arr[i] < 65 || arr[i] > 90) // A ~ Z의 ASCII 값 : 65 ~ 90
                    return arr[i];
                else // a ~ z의 ASCII 값 : 97 ~ 122
                    return (char)(arr[i] + 32);
            }

            return new string(arr);
        }



        static void Main(string[] args)
        {
            PrintProfile("중근");
            PrintProfile("관순", "010-123-1234");
            PrintProfile(name: "봉길");
            PrintProfile(name: "동주", phone: "010-789-7890");
        }
    }
}