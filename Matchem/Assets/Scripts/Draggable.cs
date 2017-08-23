using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Transform originalParent = null;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.LogFormat("OnBeginDrag: {0}", eventData.position.ToString());

        originalParent = this.transform.parent;

        this.transform.SetParent(this.transform.parent.parent);
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;
        Debug.Log("OnDrag");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        this.transform.SetParent(originalParent);
    }
}
