using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform originalParent = null;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.LogFormat("OnBeginDrag: {0}", eventData.position.ToString());

        originalParent = this.transform.parent;

        this.transform.SetParent(this.transform.root);

        GetComponent<CanvasGroup>().blocksRaycasts = false;

        DropTarget[] targets = GameObject.FindObjectsOfType<DropTarget>();
        foreach (var target in targets)
        {
            Renderer renderer = GetComponent<Renderer>();
            renderer.material.color = Color.black;
        }

    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;
        //Debug.Log("OnDrag");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.LogFormat("OnEndDrag: {0}", eventData.position.ToString());
        this.transform.SetParent(originalParent);

        GetComponent<CanvasGroup>().blocksRaycasts = true;

        DropTarget[] targets = GameObject.FindObjectsOfType<DropTarget>();
        foreach (var target in targets)
        {
            Renderer renderer = GetComponent<Renderer>();
            renderer.material.color = Color.white;
        }

    }
}
