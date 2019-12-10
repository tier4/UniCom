using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleSubscriber : MonoBehaviour {

    public string Topic;
    public string SubscriberName;
    private UniCom.Subscriber<bool> subscriber;

	// Use this for initialization
	void Start ()
    {
        subscriber = new UniCom.Subscriber<bool>(Topic,callback);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void callback(bool data)
    {
        Debug.Log(SubscriberName + ":" + data);
    }
}