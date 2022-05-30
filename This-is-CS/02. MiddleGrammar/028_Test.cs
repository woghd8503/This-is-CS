﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test
{
    // 인터페이스와 클래스가 다른 점은 무엇입니까?

    // 인터페이스는 클래스와 달리 내부에 메서드(함수)와 프로퍼티, 인테서만 선언 가능하며, new 키워드를 통해
    // 인스턴스화 할 수 없다. 또한 접근 지정자가 기본적으로 public으로 설정되어 있다. 따라서 해당 인터페이스를
    // 상속받는 클래스를 만들어, 업 캐스팅 형식의 참조를 통해 인터페이스를 활용해야 한다.

    // 나는 인터페이스를 약속이라고 생각한다. 인터페이스를 상속받는 모든 파생 클래스들은 인터페이스에 선언되어 있는 함수를
    // 무조건 정의해야 한다. 따라서 어떤 프로그래머가 해당 클래스가 어떤 인터페이스를 상속 받고 있는지만 알고 있어도, 해당 클래스가
    // 어떤 기능을 하는지 유추할 수 있다.

    // 인터페이스와 추상 클래스가 다른 점은 무엇입니까?

    class MainApp
    {
        static void Main(string[] args)
        {

        }
    }

}


