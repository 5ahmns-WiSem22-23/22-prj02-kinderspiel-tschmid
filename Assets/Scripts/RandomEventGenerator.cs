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


    IEnumerator DisableButton(Image button)
    {
        //button.color = new Color(1, 182 / 255f, 182 / 255f, 1);
        button.gameObject.GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(EventListener.duration);
        //button.color = Color.white;
        button.gameObject.GetComponent<Button>().interactable = true;
    }

    public void MoveObject(Image button)
    {
        StartCoroutine(DisableButton(button));

        int randomNumber = Random.Range(1, 7);

        switch (randomNumber)
        {
            case 1:
                if (BlauTrigger != null)
                {
                Debug.Log("Blau");
                    BlauTrigger();
                }
                break;
            case 2:
                if (LilaTrigger != null)
                {
                Debug.Log("Lila");
                    LilaTrigger();
                }
                break;
            case 3:
                if (OrangeTrigger != null)
                {
                Debug.Log("Orange");
                    OrangeTrigger();
                }
                break;
            case 4:
                if (RotTrigger != null)
                {
                Debug.Log("Rot");
                    RotTrigger();
                }
                break;
            case 5:
                if (BootTrigger != null)
                {
                Debug.Log("Boot");
                    BootTrigger();
                }
                break;
            case 6:
                if (BootTrigger != null)
                {
                Debug.Log("Boot");
                    BootTrigger();
                }
                break;
        }
    }
}

