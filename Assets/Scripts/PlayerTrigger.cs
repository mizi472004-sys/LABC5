using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Đi vào Trigger: " + other.gameObject.name);
    }
}
