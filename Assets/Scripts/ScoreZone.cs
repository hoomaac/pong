using UnityEngine;
using UnityEngine.EventSystems;

public class ScoreZone : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ball"))
        {
            BaseEventData data = new(EventSystem.current);
            scoreTrigger.Invoke(data);
        }
    }
}
