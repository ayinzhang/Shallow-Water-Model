using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;

    IEnumerator Rotate()
    {
        for (float i = 0; i <= 2; i += 0.016f) 
        {
            transform.position = new Vector3(10 * Mathf.Cos(i * Mathf.PI), 0, 10 * Mathf.Sin(i * Mathf.PI));
            transform.LookAt(target, new Vector3(0, 1, 0));yield return new WaitForSeconds(0.025f);
        }
        for (float i = 0; i <= 0.25f; i += 0.005f)
        {
            transform.position = new Vector3(10 * Mathf.Cos(i * Mathf.PI), 10 * Mathf.Sin(i * Mathf.PI), 0);
            transform.LookAt(target, new Vector3(0, 1, 0)); yield return new WaitForSeconds(0.025f);
        }
    }

    void Start()
    {
        StartCoroutine("Rotate");
    }
}
