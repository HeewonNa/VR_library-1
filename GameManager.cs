using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool ch_KorEn; //한영
    public bool capsLock; //대소문
    [SerializeField]
    private GameObject KeyBoardList;
    [SerializeField]
    private Key[] K_key;


    void Awake()
    {
        instance = this;
        K_key = KeyBoardList.GetComponentsInChildren<Key>();
    }
    
    public void Test()
    {
        if (ch_KorEn) //한글인경우
        {
            for (int i = 0; i < K_key.Length; i++)
            {
                if (capsLock)
                {
                    K_key[i].T.text = K_key[i].En_b;
                }
                else
                {
                    K_key[i].T.text = K_key[i].En_s;
                }
            }
        }
        else
        {
            for (int i = 0; i < K_key.Length; i++)
            {
                if (capsLock)
                {
                    K_key[i].T.text = K_key[i].kor_b;
                }
                else
                {
                    K_key[i].T.text = K_key[i].kor_s;
                }
            }
        }
    }

    public void Ch_KeyKorEn()
    {
        if (ch_KorEn) //한글인경우
        {
            for (int i = 0; i < K_key.Length; i++)
            {
                if (capsLock)
                {
                    K_key[i].T.text = K_key[i].En_b;
                }
                else
                {
                    K_key[i].T.text = K_key[i].En_s;
                }
            }
        }
        else
        {
            for (int i = 0; i < K_key.Length; i++)
            {
                if (capsLock)
                {
                    K_key[i].T.text = K_key[i].kor_b;
                }
                else
                {
                    K_key[i].T.text = K_key[i].kor_s;
                }
            }
        }
    }
}

