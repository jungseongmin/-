using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{

    //- 변수의 명명 규칙

    // 변수의 이름은 대소문자를 구분합니다.
    // 변수의 이름으로 예약어로 사용할 수 없습니다.
    // 변수의 이름을 숫자로 시작할 수 없습니다.
    // 변수의 이름에 공백이 포함될 수 없습니다.
    // 변수의 이름으로 특수문자는 "_" 와 "$"만 사용할 수 있습니다.

    // 정수? 실수 문자열? 문자?
    // 프로그램이 실행되는 순서는 위에서 아래로 실행됩니다.

    // 변수의 설명

    // hp는 변수의 이름입니다.
    // 4 byte 크기의 메모리 공간이 생성됩니다.

    // hp라는 메모리 공간에 값을 저장해야 합니다.
    // 변수에 값을 저장하지 않고 선언만 하게 되면 기본적으로 기본값으로 0이 들어갑니다.

    // 문자열 : 문자가 여러 개 연결되어 있는 문자입니다.
    // name이라는 메모리 공간이 생성됩니다.

    int hp = 100;

    // 문자열은 자료형을 int로 저장할 수 
    public string name = "Jung Seung Min";

    public float height = 175.6f;

    public char bloodType = 'O';

    // Start : 게임이 실행되었을 때 단 한번만 호출되는 함수입니다.
    void Start()
    {
        hp = 300;

        // 게임 오브젝트의 속성을 초기화할 때 사용합니다.
        print(hp);
        print(name);
        print(height);
        print(bloodType);
    }

    // Update : 게임이 실행되었을 때 매 프레임마다 호출되는 함수입니다.
    void Update()
    {
        // 게임 오브젝트의 입력이나 위치 이동을 할 때 사용합니다.
    }
}
