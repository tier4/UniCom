# UniCom

Pub/Sub library for Unity

# How to use

1. Add Unicom.Publisher<T> instance
2. Set Topic in the constructor of the Publisher instance
```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamplePublisher : MonoBehaviour
{
    private UniCom.Publisher<bool> pub_;

    public bool BoolValue;

    public string Topic;

    public string NameSpace;

	// Use this for initialization
	void Start ()
    {
        pub_ = new UniCom.Publisher<bool>(Topic);
    }
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(NameSpace + ":" + BoolValue);
        pub_.Publish(BoolValue);
	}
}

```

1. Add Unicom.Subscriber<T> instance
2. Set Topic in the constructor of the Subscriber instance

```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleSubscriber : MonoBehaviour {

    public string Topic;
    public string NameSpace;
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
        Debug.Log(NameSpace + ":" + data);
    }
}
```

if the topic and it's type is matched, the callback function was called.

# Demo

1. Open SampleScene.Unity and Run

[![Image Alt Text](http://img.youtube.com/vi/fJ2IT3p2Boo/maxresdefault.jpg)](https://www.youtube.com/watch?v=fJ2IT3p2Boo&feature=youtu.be)