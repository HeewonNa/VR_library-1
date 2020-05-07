using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextandSend : MonoBehaviour
{
    public InputField search;
    public Text q, w, e, r, t, y, u, i, o, p, a, s, d, f, g, h, j, k, l, z, x, c, v, b, n, m;
    public Text num1, num2, num3, num4, num5, num6, num7, num8, num9, num0;
    //GameManager.Program hang = new GameManager.Program();
    List<string> HanK = new List<string>();
    public string input = "", inputnew = "", inputnojong="";

    int wc = 0;


    public void setget_q()
    {
        if (GameManager.instance.ch_KorEn)
        {
            search.text += q.text;
            input += q.text;
        }
        else jaumm(q.text);
    }
    public void setget_w()
    {
        if (GameManager.instance.ch_KorEn)
        {
            search.text += w.text;
            input += w.text;
        }
        else jaumm(w.text);
    }
    public void setget_e()
    {
        if (GameManager.instance.ch_KorEn)
        {
            search.text += e.text;
            input += e.text;
        }
        else jaumm(e.text);
    }
    public void setget_r()
    {
        if (GameManager.instance.ch_KorEn)
        {
            search.text += r.text;
            input += r.text;
        }
        else jaumm(r.text);
    }
    public void setget_t()
    {
        if (GameManager.instance.ch_KorEn)
        {
            search.text += t.text;
            input += t.text;
        }
        else jaumm(t.text);
    }
    public void setget_y()
    {
        if (GameManager.instance.ch_KorEn)
        {
            search.text += y.text;
            input += y.text;
        }
        else moumm(y.text);
    }
    public void setget_u()
    {
        if (GameManager.instance.ch_KorEn)
        {
            search.text += u.text;
            input += u.text;
        }
        else moumm(u.text);
    }
    public void setget_i()
    {
        if (GameManager.instance.ch_KorEn)
        {
            search.text += i.text;
            input += i.text;
        }
        else moumm(i.text);
    }
    public void setget_o()
    {
        if (GameManager.instance.ch_KorEn)
        {
            search.text += o.text;
            input += o.text;
        }
        else moumm(o.text);
    }
    public void setget_p()
    {
        if (GameManager.instance.ch_KorEn)
        {
            search.text += p.text;
            input += p.text;
        }
        else moumm(p.text);
    }
    public void setget_a()
    {
        if (GameManager.instance.ch_KorEn)
        {
            search.text += a.text;
            input += a.text;
        }
        else jaumm(a.text);

    }
    public void setget_s()
    {
        if (GameManager.instance.ch_KorEn)
        {
            search.text += s.text;
            input += s.text;
        }
        else jaumm(s.text);
    }
    public void setget_d()
    {
        if (GameManager.instance.ch_KorEn)
        {
            search.text += d.text;
            input += d.text;
        }
        else jaumm(d.text);
    }
    public void setget_f()
    {
        if (GameManager.instance.ch_KorEn)
        {
            search.text += f.text;
            input += f.text;
        }
        else jaumm(f.text);
    }
    public void setget_g()
    {
        if (GameManager.instance.ch_KorEn)
        {
            search.text += g.text;
            input += g.text;
        }
        else jaumm(g.text);
    }
    public void setget_h()
    {
        if (GameManager.instance.ch_KorEn)
        {
            search.text += h.text;
            input += h.text;
        }
        else moumm(h.text);
    }
    public void setget_j()
    {
        if (GameManager.instance.ch_KorEn)
        {
            search.text += j.text;
            input += j.text;
        }
        else moumm(j.text);
    }
    public void setget_k()
    {
        if (GameManager.instance.ch_KorEn)
        {
            search.text += k.text;
            input += k.text;
        }
        else moumm(k.text);
    }
    public void setget_l()
    {
        if (GameManager.instance.ch_KorEn)
        {
            search.text += l.text;
            input += l.text;
        }
        else moumm(l.text);
    }
    public void setget_z()
    {
        if (GameManager.instance.ch_KorEn)
        {
            search.text += z.text;
            input += z.text;
        }
        else jaumm(z.text);
    }
    public void setget_x()
    {
        if (GameManager.instance.ch_KorEn)
        {
            search.text += x.text;
            input += x.text;
        }
        else jaumm(x.text);
    }
    public void setget_c()
    {
        if (GameManager.instance.ch_KorEn)
        {
            search.text += c.text;
            input += c.text;
        }
        else jaumm(c.text);
    }
    public void setget_v()
    {
        if (GameManager.instance.ch_KorEn)
        {
            search.text += v.text;
            input += v.text;
        }
        else jaumm(v.text);
    }
    public void setget_b()
    {
        if (GameManager.instance.ch_KorEn)
        {
            search.text += b.text;
            input += b.text;
        }
        else moumm(b.text);
    }
    public void setget_n()
    {
        if (GameManager.instance.ch_KorEn)
        {
            search.text += n.text;
            input += n.text;
        }
        else moumm(n.text);
    }
    public void setget_m()
    {
        if (GameManager.instance.ch_KorEn)
        {
            search.text += m.text;
            input += m.text;
        }
        else moumm(m.text);
    }
    //number
    public void setnum_1()
    {
        search.text += num1.text;
    }
    public void setnum_2()
    {
        search.text += num2.text;
    }
    public void setnum_3()
    {
        search.text += num3.text;

    }
    public void setnum_4()
    {
        search.text += num4.text;
    }
    public void setnum_5()
    {
        search.text += num5.text;
    }
    public void setnum_6()
    {
        search.text += num6.text;
    }
    public void setnum_7()
    {
        search.text += num7.text;
    }
    public void setnum_8()
    {
        search.text += num8.text;
    }
    public void setnum_9()
    {
        search.text += num9.text;
    }
    public void setnum_0()
    {
        search.text += num0.text;
    }
    public void backspace()
    {
        if(search.text.Length>0) search.text = search.text.Substring(0, search.text.Length-1);
        input = search.text;
        if(wc%3 == 2)
        {
            HanK.Add("");
            wc++;
        }
        if (wc % 3 == 1)
        {
            HanK.Add("");
            HanK.Add("");
            wc+=2;
        }
    }
    public void space()
    {
        search.text += " ";
        input += " ";
    }
    public void jaumm(string ja)
    {
        HanK.Add(ja);
        if (wc % 3  != 0) //받침
        {
            inputnojong = search.text;
            search.text = input;
            inputnew += Program1.combine(HanK[3 * (wc / 3)], HanK[1 + 3 * (wc / 3)], HanK[2 + 3 * (wc / 3)]);
            search.text += inputnew;
            inputnew = "";
            if (wc % 3 == 2) input = search.text;
        }
        else if(wc%3 == 0) //초성
        {
            inputnojong = search.text;
            search.text += ja;
        }
        wc++;
    }

    public void moumm(string mo)
    {
        if (wc > 0 && (HanK[wc - 1] == "ㅗ"|| HanK[wc - 1] == "ㅜ"|| HanK[wc - 1] == "ㅡ"))
        {
            if(HanK[wc - 1] == "ㅗ"&&mo =="ㅏ")
            {
                search.text = input;
                inputnew += Program1.combine(HanK[3 * (wc / 3)], "ㅘ", " ");
                HanK[3 * (wc / 3)+1] = "ㅘ";
                search.text += inputnew;
                inputnew = "";
            }
            if (HanK[wc - 1] == "ㅗ" && mo == "ㅐ")
            {
                search.text = input;
                inputnew += Program1.combine(HanK[3 * (wc / 3)], "ㅙ", " ");
                HanK[3 * (wc / 3) + 1] = "ㅙ";
                search.text += inputnew;
                inputnew = "";
            }
            if (HanK[wc - 1] == "ㅗ" && mo == "ㅣ")
            {
                search.text = input;
                inputnew += Program1.combine(HanK[3 * (wc / 3)], "ㅚ", " ");
                HanK[3 * (wc / 3) + 1] = "ㅚ";
                search.text += inputnew;
                inputnew = "";
            }
            if (HanK[wc - 1] == "ㅜ" && mo == "ㅓ")
            {
                search.text = input;
                inputnew += Program1.combine(HanK[3 * (wc / 3)], "ㅝ", " ");
                HanK[3 * (wc / 3) + 1] = "ㅝ";
                search.text += inputnew;
                inputnew = "";
            }
            if (HanK[wc - 1] == "ㅜ" && mo == "ㅔ")
            {
                search.text = input;
                inputnew += Program1.combine(HanK[3 * (wc / 3)], "ㅞ", " ");
                HanK[3 * (wc / 3) + 1] = "ㅞ";
                search.text += inputnew;
                inputnew = "";
            }
            if (HanK[wc - 1] == "ㅜ" && mo == "ㅣ")
            {
                search.text = input;
                inputnew += Program1.combine(HanK[3 * (wc / 3)], "ㅟ", " ");
                HanK[3 * (wc / 3) + 1] = "ㅟ";
                search.text += inputnew;
                inputnew = "";
            }
            if (HanK[wc - 1] == "ㅡ" && mo == "ㅣ")
            {
                search.text = input;
                inputnew += Program1.combine(HanK[3 * (wc / 3)], "ㅢ", " ");
                HanK[3 * (wc / 3) + 1] = "ㅢ";
                search.text += inputnew;
                inputnew = "";
            }
        }
        else
        {
            if (wc % 3 == 1) //초+중+종(평상시)
            {
                HanK.Add(mo);
                search.text = input;
                inputnew += Program1.combine(HanK[3 * (wc / 3)], HanK[1 + 3 * (wc / 3)], " ");
                search.text += inputnew;
                inputnew = "";
            }
            else if (wc % 3 == 0) //받침없을때 종성이었던 애랑 결합
            {
                HanK.Add(HanK[wc - 1]);
                HanK.Add(mo);
                wc += 1;
                search.text = inputnojong;
                input = search.text;
                inputnew = "";
                inputnew += Program1.combine(HanK[3 * (wc / 3)], HanK[3 * (wc / 3) + 1], " ");
                search.text += inputnew;
                inputnew = "";
            }
            wc++;
        }
 //       else search.text += mo;
    }


    public class Program1
    {
       // public static readonly string HTable_ChoSung = "ㄱㄲㄴㄷㄸㄹㅁㅂㅃㅅㅆㅇㅈㅉㅊㅋㅌㅍㅎ"; // 초성리스트
     //   public static readonly string HTable_JungSung = "ㅏㅐㅑㅒㅓㅔㅕㅖㅗㅘㅙㅚㅛㅜㅝㅞㅟㅠㅡㅢㅣ"; // 중성리스트 
       // public static readonly string HTable_JongSung = " ㄱㄲㄳㄴㄵㄶㄷㄹㄺㄻㄼㄽㄾㄿㅀㅁㅂㅄㅅㅆㅇㅈㅊㅋㅌㅍㅎ"; // 종성리스트
        public static readonly string[] HTable_ChoSung = { "ㄱ", "ㄲ", "ㄴ", "ㄷ", "ㄸ", "ㄹ", "ㅁ", "ㅂ", "ㅃ", "ㅅ", "ㅆ", "ㅇ", "ㅈ", "ㅉ", "ㅊ", "ㅋ", "ㅌ", "ㅍ", "ㅎ" };
        public static readonly string[] HTable_JungSung = { "ㅏ", "ㅐ", "ㅑ", "ㅒ", "ㅓ", "ㅔ", "ㅕ", "ㅖ", "ㅗ", "ㅘ", "ㅙ", "ㅚ", "ㅛ", "ㅜ", "ㅝ", "ㅞ", "ㅟ", "ㅠ", "ㅡ", "ㅢ", "ㅣ"};
        public static readonly string[] HTable_JongSung = { " ", "ㄱ", "ㄲ", "ㄳ", "ㄴ", "ㄵ", "ㄶ", "ㄷ", "ㄹ", "ㄺ", "ㄻ", "ㄼ", "ㄽ", "ㄾ", "ㄿ", "ㅀ", "ㅁ", "ㅂ", "ㅄ", "ㅅ", "ㅆ", "ㅇ", "ㅈ", "ㅊ", "ㅋ", "ㅌ", "ㅍ", "ㅎ" };

        public static char combine(string choSung, string jungSung, string jongSung)
        {
            int i_ChoSungPos, i_JungSungPos, i_JongSungPos;
            int i_Unicode;
            //i_ChoSungPos = alp.IndexOf("a") + 12484;    // 초성 
            // IndexOf 문자열내의 문자위치를 가져오는겁니다.
            i_ChoSungPos = System.Array.IndexOf(HTable_ChoSung, choSung);    // 초성 
            i_JungSungPos = System.Array.IndexOf(HTable_JungSung, jungSung);   // 중성 
            i_JongSungPos = System.Array.IndexOf(HTable_JongSung, jongSung);   // 종성
            i_Unicode = 0xAC00 + ((i_ChoSungPos * 21) + i_JungSungPos) * 28 + i_JongSungPos;
            // 중성의개수는 21개 종성의 개수는 28개  한글코드의 값 = ((초성 * 21) + 중성) * 28 + 종성 + 0xAC00 
            // 자음 모음이 다모여서 한개의 글씨 시작위치는 0xAC00 끝은  0xD79F 이다.
            char Temp = (char)(i_Unicode); // 코드값을문자로변환
            return Temp;
        }


    }
}
