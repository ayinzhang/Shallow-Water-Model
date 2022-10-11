using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Camera))]
public class MotionBlur : MonoBehaviour
{
    public Material material;
    public RenderTexture accumulationTex;
    [Range(0, 1)]
    public float blurAmount = 0.5f;
    void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        if (!accumulationTex) accumulationTex = new RenderTexture(src);
        material.SetFloat("_BlurAmount", 1 - blurAmount);
        Graphics.Blit(src, accumulationTex, material);
        Graphics.Blit(accumulationTex, dest);
    }
}
