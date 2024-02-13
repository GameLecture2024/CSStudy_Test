using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024CSStudyKDH._2024CSStudy
{
    // 2강. C# 데이터 영역
    // (1) 데이터 타입 
    // 기본 타입과 참조 타입

    // C#의 데이터 영역
    // 코드 영역, 데이터 영역, 힙, 스택

    // C#은 힙 영역을 관리해준다. 관리되는 힙을 managed Heap이라고 부르며
    // 이 힙은 GC이 관리한다.

    // (2) 가비지 콜랙션 (Garbage Collection)
    // 가비지 콜랙션은 C#의 사용하지 않는 힙 메모리를 쓰레기(Garabage)로 인식하여 자동으로 정리해주는 기능이며, 
    // 해당 기능을 수행하는 자동 메모리 관리 시스템을 Garbage Collector라 부릅니다.

    // Garbage로 인식하는 방법
    // 참조할 수 없는 힙에 할당된 데이터를 가비지 콜렉터가 수집하여 일정 시간 후에 자동으로 메모리를 해제해준다.

    // 세대별 가비지 콜랙션
    // 메모리를 해제해주기 위해서 GC는 1,2,3 세대별로 나누어서 Garbage Colletion을 실행한다.
    // 3세대 GC가 발생할 때 컴퓨터를 잠시 멈추고 메모리를 해제해주기 때문에 3세대 GC이 최대한 적게 발생하기 위해서 노력해야 한다.

    internal class Data
    {
        void MyMethod()
        {
            int a = 10;
        }
    }
}
