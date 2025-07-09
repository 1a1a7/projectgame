using UnityEngine;

public class NIncrementZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController pc = other.GetComponent<PlayerController>();
            if (pc != null)
            {
                pc.SetN(pc.n + 2);
                Debug.Log("n += 1 Å® åªç›ÇÃ n: " + pc.n);
            }
        }
    }
}