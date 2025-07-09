using UnityEngine;

public class DoorController : MonoBehaviour
{
    public int requiredN = 5;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerController pc = collision.gameObject.GetComponent<PlayerController>();
            if (pc != null && pc.n >= requiredN)
            {
                Debug.Log("n is correct! Door opens!");
                gameObject.SetActive(false); // ”à‚ªÁ‚¦‚éi•¨—“I‚É‚à’Ê‚ê‚éj
            }
        }
    }
}