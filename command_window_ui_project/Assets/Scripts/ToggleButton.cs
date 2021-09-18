using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleButton : MonoBehaviour
{
    public Button Button1;
    public Button Button2;
    public Text Text;
    public bool isToggled = true;

    public void Toggle(){
        if(isToggled == false){
            string s = Text.text;
            s.Replace(" (O)", "");
            print(s);
            Text.text = s;
            Button1.interactable = true;
            Button2.interactable = true;
            isToggled = true;
        }
        else{
            Text.text += " (O)";
            Button1.interactable = false;
            Button2.interactable = false;
            isToggled = false;
        }
    }
}
