using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;


public class TabButton : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
{
    public UnityEvent onTabSelected;
    public UnityEvent onTabDeselected;
    public ButtonGroup buttonGroup;

    public void OnPointerClick(PointerEventData eventData){
        buttonGroup.OnTabSelected(this);
    }

    public void OnPointerEnter(PointerEventData eventData){
        buttonGroup.OnTabEnter(this);
    }

    public void OnPointerExit(PointerEventData eventData){
        buttonGroup.OnTabExit(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        buttonGroup.Subscribe(this);
    }

    public void Select(){
        if(onTabSelected != null){
            onTabSelected.Invoke();
        }
    }

    public void Deselect(){
        if(onTabDeselected != null){
            onTabDeselected.Invoke();
        }
    }
}
