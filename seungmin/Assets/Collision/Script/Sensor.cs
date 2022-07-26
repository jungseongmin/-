using UnityEngine;
using UnityEngine.Video;

public class Sensor : MonoBehaviour
{
    private VideoPlayer video;

    void Start()
    {
        video = GetComponent<VideoPlayer>();
    }

    // OnTriggerEnter : 물리적인 연산을 수행하지 않고 충돌을 했을 때 감지하는 함수입니다.
    private void OnTriggerEnter(Collider other)
    {
        video.Play();
    }

    // OnTriggerStay : 물리적인 연산을 수행하지 않고 충돌 중일 때 감지하는 함수입니다.
    private void OnTriggerStay(Collider other)
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    // OnTriggerExit : 물리적인 연산을 수행하지 않고 충돌을 벗어났을 때 감지하는 함수입니다.
    private void OnTriggerExit(Collider other)
    {
        video.Stop();
        transform.localScale = new Vector3(1f, 1f, 1f);
    }
}
