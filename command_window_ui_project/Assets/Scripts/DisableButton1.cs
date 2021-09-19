using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableButton1 : MonoBehaviour
{
    public Button thisButton;

    public void DisableButton(){
        thisButton.enabled = false;
    }
}
