using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonGroup : MonoBehaviour
{
    public List<TabButton> tabButtons; 
    public List<GameObject> objectsToSwap;
    public TabButton selectedTab;

    public void Subscribe(TabButton button){
        if(tabButtons == null){
            tabButtons = new List<TabButton>();
        }

        tabButtons.Add(button);
    }

    public void OnTabSelected(TabButton button){
        if(selectedTab != null){
            selectedTab.Deselect();
        }

        selectedTab = button;

        selectedTab.Select();
        ResetTabs();
        int index = button.transform.GetSiblingIndex();
        for(int i=0; i<objectsToSwap.Count; i++){
            if (i == index){
                objectsToSwap[i].SetActive(true);
            }
            else{
                objectsToSwap[i].SetActive(false);
            }
        }
    }

    public void OnTabEnter(TabButton button){
        ResetTabs();
    }

    public void OnTabExit(TabButton button){
        ResetTabs();
    }

    public void ResetTabs(){
        foreach(TabButton button in tabButtons){
            
        }
    }
}
