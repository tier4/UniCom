using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

namespace UniCom
{
    public static class ComSubscriber
    {
        public static IObservable<T> Receive<T>(string topic)
        {
            return MessageBroker.Default.Receive<ComData<T>>().Where(x => x.topic == topic).Select(x => x.data);
        }
    }
}