using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject[] objects; 
    public float moveAmount = 10.0f; 
    public float duration = 1.0f; 
    public SpriteRenderer spriteRenderer;
    public Button uiButton;


    void Start()
    {
        uiButton.onClick.AddListener(MoveObject);
    }


    public void MoveObject()
    {
        int randomNum = Random.Range(1, 7); 

        switch (randomNum)
        {
            case 1:
                iTween.MoveBy(objects[0], iTween.Hash("x", moveAmount, "easeType", "easeInOutExpo", "loopType", "none", "time", duration));
                spriteRenderer.color = Color.blue;
                break;
            case 2:
                iTween.MoveBy(objects[1], iTween.Hash("x", moveAmount, "easeType", "easeInOutExpo", "loopType", "none", "time", duration));
                spriteRenderer.color = new Color(204f / 255f, 0f, 204f / 255f, 1f);

                break;
            case 3:
                iTween.MoveBy(objects[2], iTween.Hash("x", moveAmount, "easeType", "easeInOutExpo", "loopType", "none", "time", duration));
                spriteRenderer.color = new Color(1f, 128f / 255f, 0f, 1f);
                break;
            case 4:
                iTween.MoveBy(objects[3], iTween.Hash("x", moveAmount, "easeType", "easeInOutExpo", "loopType", "none", "time", duration));
                spriteRenderer.color = Color.red;
                break;
            case 5:
            case 6:
                iTween.MoveBy(objects[4], iTween.Hash("x", -moveAmount, "easeType", "easeInOutExpo", "loopType", "none", "time", duration));
                spriteRenderer.color = Color.yellow;
                break;
        }
    }
}
