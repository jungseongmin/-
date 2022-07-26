using UnityEngine;
using UnityEngine.Video;

public class Sensor : MonoBehaviour
{
    private VideoPlayer video;

    void Start()
    {
        video = GetComponent<VideoPlayer>();
    }

    // OnTriggerEnter : �������� ������ �������� �ʰ� �浹�� ���� �� �����ϴ� �Լ��Դϴ�.
    private void OnTriggerEnter(Collider other)
    {
        video.Play();
    }

    // OnTriggerStay : �������� ������ �������� �ʰ� �浹 ���� �� �����ϴ� �Լ��Դϴ�.
    private void OnTriggerStay(Collider other)
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    // OnTriggerExit : �������� ������ �������� �ʰ� �浹�� ����� �� �����ϴ� �Լ��Դϴ�.
    private void OnTriggerExit(Collider other)
    {
        video.Stop();
        transform.localScale = new Vector3(1f, 1f, 1f);
    }
}
