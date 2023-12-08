using UnityEngine;
using UnityEngine.EventSystems;

public class ScoreZone : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ball")
        {
            BaseEventData data = new BaseEventData(EventSystem.current);
            scoreTrigger.Invoke(data);
        }
    }
}
