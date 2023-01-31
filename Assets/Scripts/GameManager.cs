using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int boatCounter;
    public static int fishCounter;

    public Destroy otherScript;

    private void Update()
    {
        if (boatCounter >= 2)
        {
            SceneManager.LoadScene(2);
        }
    }
}
