using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject[] objects;
    public float moveAmount;
    public Button button;
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        button.onClick.AddListener(MoveObject);
    }

    void MoveObject()
    {
        int randomNumber = Random.Range(1, 7);
        Vector3 moveVector = new Vector3(moveAmount, 0, 0 );

        if (randomNumber == 1)
        {
            objects[0].transform.position += moveVector;
            spriteRenderer.color = Color.blue;
        }
        else if (randomNumber == 2)
        {
            objects[1].transform.position += moveVector;
            spriteRenderer.color = new Color(204f/255f,0f, 204f/255f, 1f);
        }
        else if (randomNumber == 3)
        {
            objects[2].transform.position += moveVector;
            spriteRenderer.color = new Color(1f, 128f / 255f, 0f, 1f);
        }
        else if (randomNumber == 4)
        {
            objects[3].transform.position += moveVector;
            spriteRenderer.color = Color.red;
        }
        else if (randomNumber == 5)
        {
            objects[4].transform.position += moveVector;
            spriteRenderer.color = Color.yellow;
        }
        else
        {
            objects[4].transform.position += moveVector;
            spriteRenderer.color = Color.green;
        }
    }
}
