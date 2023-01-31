using UnityEngine;

public class Destroy : MonoBehaviour
{
    public string targetTag = "boat";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == targetTag)
        {
            Destroy(gameObject);
            GameManager.boatCounter++;
            Debug.Log(GameManager.boatCounter);
        }

    }
}
