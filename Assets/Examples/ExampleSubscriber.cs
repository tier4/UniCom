using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class ExampleSubscriber : MonoBehaviour
{

    public string Topic;
    public string SubscriberName;

    // Use this for initialization
    void Start()
    {
        UniCom.ComSubscriber.Receive<bool>(Topic)
            .Subscribe(callback)
            .AddTo(this);
    }
    public void callback(bool data)
    {
        Debug.Log(SubscriberName + ":" + data);
    }
}