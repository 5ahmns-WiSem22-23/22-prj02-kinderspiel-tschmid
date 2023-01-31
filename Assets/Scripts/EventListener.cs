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

    public EventListenerType eventListenerType;

    public static float moveAmount = 1;
    public static float duration = 1;

    private void Start()
    {
        

        switch (eventListenerType)
        {
            case EventListenerType.blueFish:
                RandomEventGenerator.BlauTrigger += HandleEvent;
            break;
            case EventListenerType.redFish:
                RandomEventGenerator.RotTrigger += HandleEvent;
                break;
            case EventListenerType.purpleFish:
                RandomEventGenerator.LilaTrigger += HandleEvent;
                break;
            case EventListenerType.orangeFish:
                RandomEventGenerator.OrangeTrigger += HandleEvent;
                
                break;
            case EventListenerType.boat:
                RandomEventGenerator.BootTrigger += HandleEvent;
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
