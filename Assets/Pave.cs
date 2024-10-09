using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pave : MonoBehaviour
{
    public Animator animator;

    public void UIAnimation()
    {

        animator.SetTrigger("rigger");
    }
}
