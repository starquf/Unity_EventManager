using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventTest : MonoBehaviour
{
    private readonly string eventName = "test1";

    void Awake()
    {
        // 이런식으로 이벤트 추가
        EventManager.AddEvent(eventName, TestMethod);

        UnityAction action = () => { };
        
        action = () => 
        {
            Debug.Log("클로져 이벤트");
            EventManager.RemoveEvent(eventName, action);
        };

        // 이런식으로도 추가가능
        EventManager.AddEvent(eventName, action);
    }

    void TestMethod()
    {
        Debug.Log("이벤트 발생!");
    }
}
