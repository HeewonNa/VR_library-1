using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caps : MonoBehaviour
{
    public void _ch()
    {
        if (GameManager.instance.capsLock)
        {
            GameManager.instance.capsLock = false;
        }
        else
        {
            GameManager.instance.capsLock = true;
        }
        GameManager.instance.Test();
    }
}
