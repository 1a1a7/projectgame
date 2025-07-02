using UnityEngine;

public class DoorController : MonoBehaviour
{
    public int requiredN = 5;

    private void OnTriggerEnter(Collider other)
    {
        // ここではなく、物理接触でブロックさせるため Trigger をOFFに
        if (other.CompareTag("Player"))
        {
            PlayerController pc = other.GetComponent<PlayerController>();
            if (pc != null && pc.n == requiredN)
            {
                Debug.Log("n is correct! Door opens!");
                gameObject.SetActive(false); // 扉自体を消す（ブロックも消える）
            }
        }
    }
}