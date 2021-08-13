using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Controller movement;

    private void OnCollisionEnter(Collision colllisionInfo)
    {
        
        if (colllisionInfo.collider.tag == "Bullet__")
        {
            Debug.Log("Player Hit");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
