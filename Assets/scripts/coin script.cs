using UnityEngine;

public class CoinController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false); // Deactivate the coin
            Invoke("ReactivateCoin", 3f); // Reactivate the coin after 3 seconds
        }
    }

    void ReactivateCoin()
    {
        gameObject.SetActive(true); // Reactivate the coin
    }
}
