using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ColourSelect : MonoBehaviour
{
    [SerializeField] Material[] mats;
    [SerializeField] Material mat;


    public void OnOne()
    {
        mat = mats[0];
    }

    public void OnTwo()
    {
        mat = mats[1];
    }

    public void OnThree()
    {
        mat = mats[2];
    }

    public void OnFour()
    {
        mat = mats[3];
    }

}
