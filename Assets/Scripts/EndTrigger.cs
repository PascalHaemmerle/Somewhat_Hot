
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;
    private void OnTriggerEnter()
    {
        //if (colllisionInfo.collider.tag == "Player")
            gameManager.winLevel();
    }
}
