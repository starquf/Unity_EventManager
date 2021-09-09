using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventInvoke : MonoBehaviour
{
    private readonly string eventName = "test1";

    void Start()
    {
        // 이벤트 호출
        EventManager.Invoke(eventName);
        EventManager.Invoke(eventName);
    }
}
