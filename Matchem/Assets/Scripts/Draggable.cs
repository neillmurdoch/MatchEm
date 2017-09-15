using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform originalParent = null;
    private int originalLayer = -1;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.LogFormat("OnBeginDrag: {0}, {1}, {2}", this.name, eventData.position.ToString(), LayerMask.LayerToName(gameObject.layer));

        originalParent = this.transform.parent;
        originalLayer = gameObject.layer;
    
        this.transform.SetParent(this.transform.root);

        gameObject.layer = 2;   // Ignore raycast layer while moving.
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(eventData.position);
        this.transform.position = new Vector3(pos.x, pos.y, 0f);
        //Debug.LogFormat("OnDrag: {0}, {1}, {2}, {3}", this.name, eventData.position.ToString(), LayerMask.LayerToName(gameObject.layer), this.transform.position.ToString());
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.SetParent(originalParent);
        gameObject.layer = originalLayer;
        
        Debug.LogFormat("OnEndDrag: {0}, {1}, {2}", this.name, eventData.position.ToString(), LayerMask.LayerToName(gameObject.layer));
        
    }
}
