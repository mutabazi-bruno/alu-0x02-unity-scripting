using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int health = 5;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trap"))
        {
            health--;
            Debug.Log("Health: " + health);
        }
    }
}
