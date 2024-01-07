using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class CameraShakeTrigger : MonoBehaviour
{
    private void Update()
    {
        Destroy(gameObject,20);
    }
}
