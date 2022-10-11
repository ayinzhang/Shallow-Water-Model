using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public Material material;

    IEnumerator Clock()
    {
        yield return new WaitForSeconds(4.5f);
        GetComponent<ShallowWater>().enabled = true;
        yield return new WaitForSeconds(3f);
        ShallowWater.watercondition = 2;
    }

    void Start()
    {
        StartCoroutine("Clock");
    }
}
