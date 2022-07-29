using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observe : MonoBehaviour
{
    public GameObject target;

    public void Update()
    {
        // 자기 위치와 target의 위치가 5보다 작으면 대상을 바라보도록 합니다.
        if (Vector3.Distance(transform.position, target.transform.position) <= 5)
        {
            transform.LookAt(target.transform);
        }
        else // 그렇지 않다면 회전 값은 15, 90, 0 으로 설정합니다.
        {
            transform.rotation = Quaternion.Euler(15, 90, 0);
        }
    }


}
