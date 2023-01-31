using UnityEngine.SceneManagement;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    public string targetTag = "fish";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == targetTag)
        {
            GameManager.fishCounter++;
            Debug.Log(GameManager.fishCounter);
            Destroy(collision.gameObject);
        }

    }

    private void Update()
    {
        if(GameManager.fishCounter >= 2)
        {
            SceneManager.LoadScene(3);
        }
    }
}
