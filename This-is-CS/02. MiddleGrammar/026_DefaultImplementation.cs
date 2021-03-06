using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// 지금까지는 인터페이스에 선언하는 메소드에 구현부가 없었죠? 인터페이스가 선언하는 메소드는 파생될 클래스가 무엇을 구현해야
// 할지를 정의하는 역할만 하면 됐기 때문입니다. 기본 구현 메소드는 이름처럼 구현부를 가지는 메소드인데요. 인터페이스의 다른
// 메소드와는 역할이 약간 다릅니다. 기본 구현 메소드를 자세히 설명하기 전에, 다음 코드를 같이 보시죠.


// interface ILogger
//{
//   void WriteLog(string message);
//}

// class ConsoleLogger : ILogger
//{
//     public void WriteLog(string message)
//     {
//          Console.WriteLine( $"{DateTime.Now.ToLocalTime()}, {message}");
//     }
//}

// ILogger는 평범한 인터페이스이며, ConsoleLogger는 ILogger를 상속하는 평범한 클래스입니다. ILogger에는 WriteLog()라는
// 메소드가 선언되어 있기 때문에 ILogger를 상속하는 ConsoleLogger는 이 메소드를 오버라이딩해야 합니다. 여기까지는 우리가
// 잘 이해하고 있는 내용입니다. 이제 이 코드에 무구한 역사가 더해져 ConsoleLogger도 업그레이드되었을 뿐 아니라, FileLogger와
// 같은 ILogger의 파생 클래스가 수없이 생겼다고 가정해보죠. 이런 코드를 레거시 ( Legacy : 유산 )라고 하는데요. 레거시 코드는
// 업그레이드에 각별한 주의가 필요합니다.
// 이와 같은 상황에서 초기 버전을 설계할 때 놓친 메소드를 인터페이스에 안전하게 추가할 수 있을까요? 다음과 같이 무작정 ILobber에
// 새 메소드를 추가한다고 해보죠.

// interface ILogger
//{
//      void WriteLog(string message);
//      void WriteError(stringh error);  // 새로운 메소드 추가
//}

// 그 결과, ConsoleLogger를 비롯해서 ILogger를 상속하는 모든 클래스에 대해 다음과 같은 컴파일 에러가 발생합니다. 파생 클래스는
// 인터페이스의 모든 메소드를 구현하는 것이 기본 규칙이니까요.

namespace DefaultImplementation
{
    interface ILogger
    {
        void WriteLog(string message); 

        void WriteError(string error) // 새로운 메소드 추가
        {
            WriteLog($"Error: {error}");
        }
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()}, {message}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.WriteLog("System Up");
            logger.WriteError("System Fail");

            ConsoleLogger clogger = new ConsoleLogger();
            clogger.WriteLog("System Up");  // OK
            // clogger.WriteError("System Fail"); // 컴파일 에러
        }
    }

}

