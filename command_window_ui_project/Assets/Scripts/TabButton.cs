using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class TabButton : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
{
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
