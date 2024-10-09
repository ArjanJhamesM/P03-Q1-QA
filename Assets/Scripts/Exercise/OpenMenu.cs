using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public Animator animator;

    public void UIAnimation()
    {
        animator.SetTrigger("StartAnim");
    }
}
