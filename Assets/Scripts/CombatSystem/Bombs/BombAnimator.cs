using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombAnimator : MonoBehaviour
{
    private Animator m_Animator;
    public void CallBombAnimator(bool exploding)
    {
        m_Animator.SetBool("Exploding", exploding);
    }

    private void Start()
    {
        m_Animator = GetComponent<Animator>();
    }
}
