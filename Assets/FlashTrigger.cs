using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class FlashTrigger : MonoBehaviour
{
    void Update()
    {
        Destroy(gameObject,5);
    }
}
