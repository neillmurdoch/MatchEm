using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform originalParent = null;
    private int originalLayer = 0;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.LogFormat("OnBeginDrag: {0}, {1}, {2}", this.name, eventData.position.ToString(), LayerMask.LayerToName(gameObject.layer));

        originalParent = this.transform.parent;
        originalLayer = gameObject.layer;

        this.transform.SetParent(this.transform.root);
        gameObject.layer = LayerMask.NameToLayer("Dragging");

        //GetComponent<CanvasGroup>().blocksRaycasts = false;

        //DropTarget[] targets = GameObject.FindObjectsOfType<DropTarget>();
        //foreach (var target in targets)
        //{
        //    Renderer renderer = GetComponent<Renderer>();
        //    renderer.material.color = Color.black;
        //}

    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;
        Debug.LogFormat("OnDrag: {0}, {1}, {2}", this.name, eventData.position.ToString(), LayerMask.LayerToName(gameObject.layer));
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.SetParent(originalParent);
        gameObject.layer = originalLayer;

        Debug.LogFormat("OnEndDrag: {0}, {1}, {2}", this.name, eventData.position.ToString(), LayerMask.LayerToName(gameObject.layer));

        //GetComponent<CanvasGroup>().blocksRaycasts = true;

        //DropTarget[] targets = GameObject.FindObjectsOfType<DropTarget>();
        //foreach (var target in targets)
        //{
        //    Renderer renderer = GetComponent<Renderer>();
        //    renderer.material.color = Color.white;
        //}

    }
}
