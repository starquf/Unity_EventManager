using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventInvoke : MonoBehaviour
{
    private readonly string eventName = "test1";

    void Start()
    {
        // �̺�Ʈ ȣ��
        EventManager.Invoke(eventName);
        EventManager.Invoke(eventName);
    }
}
