using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RandomEventGenerator : MonoBehaviour
{
    public delegate void RandomEvent();
    public static event RandomEvent BlauTrigger;
    public static event RandomEvent LilaTrigger;
    public static event RandomEvent OrangeTrigger;
    public static event RandomEvent RotTrigger;
    public static event RandomEvent BootTrigger;
    public Button uiButton;
    public SpriteRenderer spriteRendererColor;


    IEnumerator DisableButton(Image button)
    {
        button.gameObject.GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(EventListener.duration);
        button.gameObject.GetComponent<Button>().interactable = true;
    }

    public void MoveObject(Image button)
    {
        StartCoroutine(DisableButton(button));

        int randomNumber = Random.Range(1, 7);

        switch (randomNumber)
        {
            case 1:
                spriteRendererColor.color = Color.blue;
                if (BlauTrigger != null)
                {
                    BlauTrigger();
                }
                break;
            case 2:
                spriteRendererColor.color = new Color(204f / 255f, 0f, 204f / 255f, 1f);
                if (LilaTrigger != null)
                {
                    LilaTrigger();
                }
                break;
            case 3:
                spriteRendererColor.color = new Color(1f, 128f / 255f, 0f, 1f);
                if (OrangeTrigger != null)
                {
                    OrangeTrigger();
                }
                break;
            case 4:
                spriteRendererColor.color = Color.red;
                if (RotTrigger != null)
                {
                    RotTrigger();
                }
                break;
            case 5:
                spriteRendererColor.color = Color.yellow;
                if (BootTrigger != null)
                {
                    BootTrigger();
                }
                break;
            case 6:
                spriteRendererColor.color = Color.yellow;
                if (BootTrigger != null)
                {
                    BootTrigger();
                }
                break;
        }
    }
}

