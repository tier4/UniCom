using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class ExamplePublisher : MonoBehaviour
{
    public bool BoolValue;

    public string Topic;

    public string NameSpace;
    // Use this for initialization
    void Start()
    {
        Observable.EveryUpdate()
            .Subscribe(_ => UniCom.ComPublisher.ComPublish(Topic, BoolValue))
            .AddTo(this);
    }
}
