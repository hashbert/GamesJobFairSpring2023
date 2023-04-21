using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    private Outline _outline;

    private void Awake()
    {
        _outline = GetComponent<Outline>();
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        _outline.enabled = true;
        print("pointer entered human");
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
        //_outline.enabled = false;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        print("pointer clicked human");
    }
}
