using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidtermObserver : MonoBehaviour
{
    Subject subject = new Subject();
    public GameObject soundObject;
    public SoundM sm;
    public GameM gm;
    
    // Start is called before the first frame update
    void Start()
    {
        sm = new SoundM(soundObject);
        subject.AddObserver(sm);
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.F))
        {
            subject.Notify();
            
        }
    }
}

public abstract class Observer
    {
        public abstract void OnNotify();
    }

public class Subject
{
    List<Observer> observers = new List<Observer>();

    public void Notify()
    {
        for(int i = 0; i < observers.Count; i++)
        {
            observers[i].OnNotify();
        }
    }

    public void AddObserver(Observer ob)
    {
        observers.Add(ob);
    }
}

public class SoundM : Observer
{
    public GameObject soundObject;
    public AudioClip fireBall;

    public SoundM(GameObject gm)
    {
        soundObject = gm;
    }
    public override void OnNotify()
    {
        GameObject.Find("SoundManager").GetComponent<AudioSource>().Play();   
    }
}

public class GameM : Observer
{
    GameObject fireballPrefab;
    public override void OnNotify()
    {
        Debug.Log("fireball2");
        //GameObject fb = GameObject.Instantiate(fireballPrefab, GameObject.Find("Player").transform);
        //fb.GetComponent<Rigidbody>().AddForce(fb.transform.forward * 10f);
    }
}




