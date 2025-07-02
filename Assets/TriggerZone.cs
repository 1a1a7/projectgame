using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    public int newValue = 5; // ���̒l��n���Z�b�g�����

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController pc = other.GetComponent<PlayerController>();
            if (pc != null)
            {
                pc.SetN(newValue);
            }
        }
    }
}
