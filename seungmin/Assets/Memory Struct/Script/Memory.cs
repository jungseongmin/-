using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    protected int health; // public : 외부에서도 접근하여 사용할 수 있습니다.
    protected int attack; // private : 나 자신만 접근하여 사용할 수 있습니다.
    public string name; // protected : 나 자신과 상속하고 있는 클래스까지만 접근하여 사용할 수 있습니다.

    public void Information()
    {
        print(health);
        print(attack);
        print(name);
    }
}

public class Memory : Monster
{
    // 코드 영역 : 프로그램이 실행되는 코드들이 저장되는 영역입니다.
    // 데이터 영역 : 전역 변수와 정적 변수가 저장되는 영역입니다.
    // 힙 영역 : 동적으로 생성한 메모리를 관리하는 영역입니다.
    // 스택 영역 : 지역 변수와 함수의 매개 변수가 저장되는 영역입니다.

    public int value = 100;

    void Start()
    {
        health = 100;
        attack = 100;
        Information();


        int value = 250; // <- 지역 변수
        int area = 500; // 함수 안에서 생성되며, 함수 벗어나면 소멸하는 변수입니다.
    }

    private void Update()
    {
        Move();
        //Calculator(34, 50);
        print(Add(10,10));
    }

    private void Move() // <- 오브젝트를 이동시키는 함수
    {
        transform.position += new Vector3(1, 1, 0) * Time.deltaTime;
    }

    private void Calculator(int x, int y)
    {
        int temp = y + x;
        print(temp);
    }

    private int Add(int x, int y)
    {
        return x + y;
    }

    // void : 자료형이 존재하지 않는다.


}
