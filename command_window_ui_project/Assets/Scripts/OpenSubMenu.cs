using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSubMenu : MonoBehaviour
{
    public GameObject Image;

    public void OpenImage(){
        if (Image != null){
            Image.SetActive(true);
            Animator animator = Image.GetComponent<Animator>();
            if (animator != null){
                animator.SetBool("Open", true);
            }
        }
    }
}
