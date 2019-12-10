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
