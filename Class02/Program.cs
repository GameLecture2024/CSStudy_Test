namespace _2024CSStudyKDH
{
    using System.Collections;

    internal class Program
    {
        object newobject;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Example myex = new Example();

            myex.Mymethod();

            Test();

            BoxingTest(3, 'c');         // 3과 'c' 데이터 타입이 object 매개 변수로 넘겨지면서 박싱이 발생한다.
        }

        static void BoxingTest(params object[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] is int)
                {
                    int n = (int)args[i];                     // object 타입을 기본 데이터 타입에 초기화하면서 언박싱이 발생한다.
                    Console.WriteLine($"{n} is int");
                }
                else if (args[i] is char)
                {
                    char c = (char)args[i];
                    Console.WriteLine($"{c} is char");
                }
            }
        }

        static void Exmaple2Method()
        {
            Example myex2 = new Example();
        }

        static void Test()
        {
            var a = 3; 
            var b = "한글";
            var c = 'd';
            var d = 0.1f;

            // 박싱이 발생 하는 object 형식으로 지정하면 12배의 성능상의 손실을 발생시킨다.

            object aa = 3;    // aa 참조 타입.   3은 int 데이터 타입입니다.
            object bb = "영어";
            object cc = 'f';
            object dd = 0.2f;

            // unboxing  object타입에 있는 것을 데이터 타입으로 변환을 해주고. 데이터 타입에 초기화 해주는 것을 말한다.
            // 올바른 데이터 끼리 넣는 방식에 비해서 4배 정도의 성능상의 손실을 발생한다.

            // object 타입을 쓰는 이유가 있습니다.
            // object 타입을 상속을 받는다.
            // object 타입은 모든 타입을 사용할 수 있다.

            // 자료구조 가변배열, 연결 리스트, 해시 맵 -> Class로 제공을 해줍니다.
            // 메소드 들이 사용하는 매개 변수가 전부 Object 타입으로 지정이 되있습니다.

            
            ArrayList arraylist = new ArrayList();
            arraylist.Add(aa);

            Console.WriteLine($"a의 값 : {a} ");
            Console.WriteLine($"aa의 값 : {aa}");
        }

    }


    class Example
    {
        public void Mymethod()
        {
            int a = 10;
        }
    }
}
