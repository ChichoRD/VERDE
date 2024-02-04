using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCondition : MonoBehaviour, ICondition
{
    [SerializeField] Vector2 timeRange = new Vector2(1, 2);
    private float timeToWait;
    float timePassed;

    private void Awake() => timeToWait = Random.Range(timeRange.x, timeRange.y);

    public bool CheckCondition()
    {
        timePassed += Time.deltaTime;
        if(timePassed >= timeToWait)
        {
            timeToWait = Random.Range(timeRange.x, timeRange.y);
            timePassed = 0;
            return true;
        }
        return false;
    }

    private void OnValidate() => gameObject.name = $"Wait {timeRange.x} - {timeRange.y}s";
}
