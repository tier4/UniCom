using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

namespace UniCom
{
    public class Subscriber<T>
    {
        public Subscriber(string topic, Action<T> func)
        {
            _topic = topic;
            _func = func;
            MessageBroker.Default.Receive<ComData<T>>().Subscribe(
                x =>
                {
                    if(x.hash != typeof(T).GetHashCode())
                    {
                        Debug.LogError("Hashcode does not match. Chekck data type");
                        return;
                    }
                    if(x.topic == _topic)
                    {
                        _func(x.data);
                    }
                }
                );
            return;
        }

        private string _topic;
        private ComData<T> _data;
        Action<T> _func;
    }
}