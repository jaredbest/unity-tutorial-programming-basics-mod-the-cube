using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    float startDelay = 2;
    float invokeInterval = 1.5f;

    float xRotationSpeed = 0f;
    float yRotationSpeed = 0f;
    float zRotationSpeed = 0f;

    

    void Start()
    {
        InvokeRepeating("ChangeColor", startDelay, invokeInterval);
        InvokeRepeating("ChangeRotation", startDelay, invokeInterval);
    }

    void Update()
    {
        transform.Rotate((xRotationSpeed * Time.deltaTime), (yRotationSpeed * Time.deltaTime), (zRotationSpeed * Time.deltaTime));
    }

    void ChangeColor()
    {
        Material material = Renderer.material;
        float r = Random.Range(0.0f, 1.0f);
        float g = Random.Range(0.0f, 1.0f);
        float b = Random.Range(0.0f, 1.0f);
        float a = Random.Range(0.0f, 1.0f);

        material.color = new Color(r, g, b, a);
    }

    public void ChangeRotation()
    {
        xRotationSpeed += Random.Range(-60.0f, 60.0f);
        yRotationSpeed += Random.Range(-60.0f, 60.0f);
        zRotationSpeed += Random.Range(-60.0f, 60.0f);
    }
}
