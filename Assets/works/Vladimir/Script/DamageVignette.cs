using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageVignette : MonoBehaviour
{
    [SerializeField] private Animator vignetteAnimator;
    private int getDamageAnimId = Animator.StringToHash("GetDamage");
    
    public void GetDamage()
    {
        vignetteAnimator.SetTrigger(getDamageAnimId);
    }
}
