using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    protected int health; // public : �ܺο����� �����Ͽ� ����� �� �ֽ��ϴ�.
    protected int attack; // private : �� �ڽŸ� �����Ͽ� ����� �� �ֽ��ϴ�.
    public string name; // protected : �� �ڽŰ� ����ϰ� �ִ� Ŭ���������� �����Ͽ� ����� �� �ֽ��ϴ�.

    public void Information()
    {
        print(health);
        print(attack);
        print(name);
    }
}

public class Memory : Monster
{
    // �ڵ� ���� : ���α׷��� ����Ǵ� �ڵ���� ����Ǵ� �����Դϴ�.
    // ������ ���� : ���� ������ ���� ������ ����Ǵ� �����Դϴ�.
    // �� ���� : �������� ������ �޸𸮸� �����ϴ� �����Դϴ�.
    // ���� ���� : ���� ������ �Լ��� �Ű� ������ ����Ǵ� �����Դϴ�.

    public int value = 100;

    void Start()
    {
        health = 100;
        attack = 100;
        Information();


        int value = 250; // <- ���� ����
        int area = 500; // �Լ� �ȿ��� �����Ǹ�, �Լ� ����� �Ҹ��ϴ� �����Դϴ�.
    }

    private void Update()
    {
        Move();
        //Calculator(34, 50);
        print(Add(10,10));
    }

    private void Move() // <- ������Ʈ�� �̵���Ű�� �Լ�
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

    // void : �ڷ����� �������� �ʴ´�.


}
