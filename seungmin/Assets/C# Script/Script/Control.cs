using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{

    //- ������ ���� ��Ģ

    // ������ �̸��� ��ҹ��ڸ� �����մϴ�.
    // ������ �̸����� ������ ����� �� �����ϴ�.
    // ������ �̸��� ���ڷ� ������ �� �����ϴ�.
    // ������ �̸��� ������ ���Ե� �� �����ϴ�.
    // ������ �̸����� Ư�����ڴ� "_" �� "$"�� ����� �� �ֽ��ϴ�.

    // ����? �Ǽ� ���ڿ�? ����?
    // ���α׷��� ����Ǵ� ������ ������ �Ʒ��� ����˴ϴ�.

    // ������ ����

    // hp�� ������ �̸��Դϴ�.
    // 4 byte ũ���� �޸� ������ �����˴ϴ�.

    // hp��� �޸� ������ ���� �����ؾ� �մϴ�.
    // ������ ���� �������� �ʰ� ���� �ϰ� �Ǹ� �⺻������ �⺻������ 0�� ���ϴ�.

    // ���ڿ� : ���ڰ� ���� �� ����Ǿ� �ִ� �����Դϴ�.
    // name�̶�� �޸� ������ �����˴ϴ�.

    int hp = 100;

    // ���ڿ��� �ڷ����� int�� ������ �� 
    public string name = "Jung Seung Min";

    public float height = 175.6f;

    public char bloodType = 'O';

    // Start : ������ ����Ǿ��� �� �� �ѹ��� ȣ��Ǵ� �Լ��Դϴ�.
    void Start()
    {
        hp = 300;

        // ���� ������Ʈ�� �Ӽ��� �ʱ�ȭ�� �� ����մϴ�.
        print(hp);
        print(name);
        print(height);
        print(bloodType);
    }

    // Update : ������ ����Ǿ��� �� �� �����Ӹ��� ȣ��Ǵ� �Լ��Դϴ�.
    void Update()
    {
        // ���� ������Ʈ�� �Է��̳� ��ġ �̵��� �� �� ����մϴ�.
    }
}