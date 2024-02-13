using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024CSStudyKDH._2024CSStudy
{
    namespace KDHWorkSpace
    {
        #region var와 object
        // 1. var Type과 object 타입의 비교
        // (1) var 키워드
        // 사용 방법: var 변수명 = 초기화 값;
        // 컴파일러가 초기화된 값을 참조하여 변수의 데이터를 지정해줍니다.
        // 따라서 선언과 동시에 초기화를 하지 않으면 컴파일 에러가 발생합니다.
        // 타입이 지정되어 있지 않기 때문에 var를 암시적 타입 지역변수(implicitly typed local variable)라 부릅니다.

        // (2) object 타입
        // Var와 유사하게 모든 데이터 타입으로 초기화 할 수 있는 타입입니다.
        // object타입은 참조 타입으로 지정되어 있으며 모든 데이터 타입을 상속해줍니다.
        // 따라서 모든 타입은 object 타입으로 형변환이 가능합니다.

        #endregion
        // 2. 박싱과 언박싱을 사용하는 이유?

        internal class VarDataType
        {
            void Test()
            {             
                var a = 3;
                var b = "한글";
                var c = 'd';
                var d = 0.1f;

                object aa = 3;
                object bb = "영어";
                object cc = 'f';
                object dd = 0.2f;

                Console.WriteLine($"a의 값 : {a} ");
                Console.WriteLine($"aa의 값 : {aa}");
            }
        } 
    }
}
