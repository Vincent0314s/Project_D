using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxController : MonoBehaviour
{
    [Range(0,2)]
    public float rotateSpeed = 0.5f;

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", rotateSpeed * Time.time);
    }
}
