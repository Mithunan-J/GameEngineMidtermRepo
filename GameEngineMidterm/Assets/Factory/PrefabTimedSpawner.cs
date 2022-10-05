using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabTimedSpawner : MonoBehaviour
{
    [SerializeField]
    private float spawnRatePerMinute = 30;

    private int currentCount = 0;

    [SerializeField]
    private TimedObjectFactory factory;

    private void Update()
    {
        var targetCount = Time.time * (spawnRatePerMinute / 60);
        while (targetCount > currentCount)
        {
            var inst = factory.GetNewInstance();
            inst.transform.position = new Vector3(Random.Range(-7.0f, 7.0f), Random.Range(-5.0f, 5.0f), 0);
            currentCount++;
        }
    }




}

public class TimedObjectFactory : GenericFactory<TimeoutObject>
{

}

public class TimeoutObject : MonoBehaviour
{
    [SerializeField]
    private float timeout = 2;

    private float startTime;

    private void OnEnable()
    {
        startTime = Time.time;
    }

    private void Update()
    {
        if (Time.time - startTime > timeout)
        {
            Destroy(gameObject);
        }
    }
}