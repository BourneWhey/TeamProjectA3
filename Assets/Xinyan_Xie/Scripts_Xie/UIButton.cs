using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UIElements;
using static UnityEngine.UI.Button;

public class UIButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{ 

    [FormerlySerializedAs("onPress")]
    [SerializeField]
    private ButtonClickedEvent m_onPress= new ButtonClickedEvent();
    public ButtonClickedEvent onClick
    {
        get { return m_onPress; }
        set { m_onPress = value; }
    }

    public bool isPress;

    public void OnPointerDown(PointerEventData eventData)
    {
        isPress = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPress = false;
    }

    private void Update()
    {
        if (isPress)
        {
            m_onPress.Invoke();
        }
    }
}


