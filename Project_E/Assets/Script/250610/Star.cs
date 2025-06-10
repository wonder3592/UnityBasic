using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class Star : MonoBehaviour
{
    string star;

    void Start()
    {
       
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    public void Phase1()
    {
        star = string.Empty;

        // 페이즈 1
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 0; j < i; j++)
            {
                star += "★";
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;

        // 페이즈 2
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 0; j < 5 - i; j++)
            {
                star += "　";
            }
            for (int k = 0;  k < i ;  k++)
            {
                star += "★";
            }
            star += "\n";
        }
        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;

        // 페이즈 3
        for (int i = 1; i <= 5; i++)
        {
            for (int k = 0; k < i; k++)
            {
                star += "★";
            }
            star += "\n";
        }
        for (int i = 1; i <= 5; i++)
        {
            for (int k = 4; k>=i; k--)
            {
                star += "★";
            }
            star += "\n";
        }
        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // 페이즈 4
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 5; j >= i; j--)
            {
                star += "　";
            }
            for (int k = 0; k < i; k++)
            {
                star += "★";
            }
            star += "\n";
        }
        for (int w= 1; w <= 5; w++)
        {
            for (int j = 0; j <= w; j++)
            {
                star += "　";
            }
            for (int k = 4; k >= w; k--)
            {
                star += "★";
            }
            star += "\n";
        }
        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // 페이즈 5
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 5; j >= i; j--)
            {
                star += "　";
            }
            for (int k = 0; k < i; k++)
            {
                star += "★";
            }
            for (int j = 1; j < i; j++)
            {
                star += "★";
            }
            star += "\n";
        }
        for (int w = 1; w <= 5; w++)
        {
            for (int j = 0; j <= w; j++)
            {
                star += "　";
            }
            for (int k = 4; k >= w; k--)
            {
                star += "★";
            }
            for (int k = 3; k >= w; k--)
            {
                star += "★";
            }
            star += "\n";
        }

        Debug.Log(star);
    }
}
