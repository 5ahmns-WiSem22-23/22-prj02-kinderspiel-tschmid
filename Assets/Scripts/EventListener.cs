using UnityEngine;

public class EventListener : MonoBehaviour
{
    public enum EventListenerType {
        blueFish,
        redFish,
        purpleFish,
        orangeFish,
        boat
    }

    float time;

    Color spriteRendererColor;

    public EventListenerType eventListenerType;

    public static float moveAmount = 1;
    public static float duration = 1;
    public static SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GameObject.FindGameObjectWithTag("colorIndicator").GetComponent<SpriteRenderer>();

        switch (eventListenerType)
        {
            case EventListenerType.blueFish:
                RandomEventGenerator.BlauTrigger += HandleEvent;
                spriteRendererColor = Color.blue;
            break;
            case EventListenerType.redFish:
                RandomEventGenerator.RotTrigger += HandleEvent;
                spriteRendererColor = Color.red;
                break;
            case EventListenerType.purpleFish:
                RandomEventGenerator.LilaTrigger += HandleEvent;
                spriteRendererColor = new Color(204f / 255f, 0f, 204f / 255f, 1f);
                break;
            case EventListenerType.orangeFish:
                RandomEventGenerator.OrangeTrigger += HandleEvent;
                spriteRendererColor = new Color(1f, 128f / 255f, 0f, 1f);
                break;
            case EventListenerType.boat:
                RandomEventGenerator.BootTrigger += HandleEvent;
                spriteRendererColor = Color.yellow;
                break;
        }

    }

    private void Update()
    {
        time += Time.deltaTime;

        if(time > duration)
        {
            time = 0;
        }
    }

    private void HandleEvent()
    {
        iTween.MoveBy(this.gameObject, iTween.Hash("x", moveAmount, "easeType", "easeInOutExpo", "loopType", "none", "time", duration));
        //gameObject.transform.position = new Vector3(gameObject.transform.position.x + 1 ,gameObject.transform.position.y, gameObject.transform.position.z);
        spriteRenderer.color = spriteRendererColor;
    }

    private void OnDestroy()
    {
        switch (eventListenerType)
        {
            case EventListenerType.blueFish:
                RandomEventGenerator.BlauTrigger -= HandleEvent;
                break;
            case EventListenerType.redFish:
                RandomEventGenerator.RotTrigger -= HandleEvent;
                break;
            case EventListenerType.purpleFish:
                RandomEventGenerator.LilaTrigger -= HandleEvent;
                break;
            case EventListenerType.orangeFish:
                RandomEventGenerator.OrangeTrigger -= HandleEvent;
                break;
        }
    }
}
