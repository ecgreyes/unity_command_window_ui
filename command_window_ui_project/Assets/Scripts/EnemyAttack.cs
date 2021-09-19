using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAttack : MonoBehaviour
{
    public Text Textfield;
    public GameObject Text;
    public Text ButtonText;

    public void SetText(string text){
        Textfield.text = "Hit"+ButtonText+"for X Damage!";
        Text.SetActive(true);
    }
}
