using UnityEngine;

public class DoorController : MonoBehaviour
{
    public int requiredN = 5;

    private void OnTriggerEnter(Collider other)
    {
        // �����ł͂Ȃ��A�����ڐG�Ńu���b�N�����邽�� Trigger ��OFF��
        if (other.CompareTag("Player"))
        {
            PlayerController pc = other.GetComponent<PlayerController>();
            if (pc != null && pc.n == requiredN)
            {
                Debug.Log("n is correct! Door opens!");
                gameObject.SetActive(false); // �����̂������i�u���b�N��������j
            }
        }
    }
}