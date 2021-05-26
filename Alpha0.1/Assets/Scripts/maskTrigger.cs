using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maskTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Mask.canUse = true;
    }
}
