using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacherControl : MonoBehaviour
{
    bool condition;
    public float speed;

    Rigidbody rigid;
    Vector3 direction;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        if(Input.GetKeyDown(KeyCode.Space) && condition == true)
        {
            // AddForce : 오브젝트에 일정한 힘을 가하는 함수입니다.
            rigid.AddForce(new Vector3(0, 200, 0));
            condition = false;
        }
    }
    private void FixedUpdate()
    {
        rigid.MovePosition(rigid.position + direction.normalized * speed * Time.deltaTime);
    }



    private void OnCollisionEnter(Collision collision)
    {
        condition = true;
    }

    // OnCollisionStay : 물리적인 충동을 하고 있을 때 호출됩니다.
    private void OnCollisionStay(Collision collision)
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    // OnCollisionExit : 물리적인 충돌을 벗어났을 때 호출됩니다.
    private void OnCollisionExit(Collision collision)
    {
        condition = false;
        transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }
}
