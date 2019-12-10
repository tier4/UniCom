﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace UniCom
{
    public static class ComPublisher
    {
        public static void ComPublish<T>(string topic, T data)
        {
            var comData = new ComData<T>(topic, data);
            MessageBroker.Default.Publish<ComData<T>>(comData);
        }
    }
    public class Publisher<T>
    {
        public Publisher(string topic)
        {
            _topic = topic;
        }

        public void Publish(T data)
        {
            ComData<T> com_data = new ComData<T>(_topic, data);
            MessageBroker.Default.Publish<ComData<T>>(com_data);
        }

        private string _topic;
    }
}