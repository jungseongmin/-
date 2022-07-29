using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observe : MonoBehaviour
{
    public GameObject target;

    public void Update()
    {
        // �ڱ� ��ġ�� target�� ��ġ�� 5���� ������ ����� �ٶ󺸵��� �մϴ�.
        if (Vector3.Distance(transform.position, target.transform.position) <= 5)
        {
            transform.LookAt(target.transform);
        }
        else // �׷��� �ʴٸ� ȸ�� ���� 15, 90, 0 ���� �����մϴ�.
        {
            transform.rotation = Quaternion.Euler(15, 90, 0);
        }
    }


}