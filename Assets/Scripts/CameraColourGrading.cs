using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ScreenCameraShader : MonoBehaviour
{
    //public Shader awesomeShader = null;
    public Material m_renderMaterial;
    public Material[] mats;
    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, m_renderMaterial);
    }


    public void OnOne()
    {
        m_renderMaterial = mats[0];
    }

    public void OnTwo()
    {
        m_renderMaterial = mats[1];
    }

    public void OnThree()
    {
        m_renderMaterial = mats[2];
    }

    public void OnFour()
    {
        m_renderMaterial = mats[3];
    }

}
