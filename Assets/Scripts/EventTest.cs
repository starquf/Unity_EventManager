using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventTest : MonoBehaviour
{
    private readonly string eventName = "test1";

    void Awake()
    {
        // �̷������� �̺�Ʈ �߰�
        EventManager.AddEvent(eventName, TestMethod);

        UnityAction action = () => { };
        
        action = () => 
        {
            Debug.Log("Ŭ���� �̺�Ʈ");
            EventManager.RemoveEvent(eventName, action);
        };

        // �̷������ε� �߰�����
        EventManager.AddEvent(eventName, action);
    }

    void TestMethod()
    {
        Debug.Log("�̺�Ʈ �߻�!");
    }
}
