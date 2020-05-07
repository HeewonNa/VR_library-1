using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//한영
public class ChHan : MonoBehaviour
{
    public void _ch()
    {
        if (GameManager.instance.ch_KorEn)
        {
            GameManager.instance.ch_KorEn = false;
        }
        else
        {
            GameManager.instance.ch_KorEn = true;
        }
        GameManager.instance.Test();
    }
}
