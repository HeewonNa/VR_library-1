using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class List : MonoBehaviour
{
	public Search[] list = new Search[20];
	private string apiurl = "http://www.aladin.co.kr/ttb/api/ItemList.aspx?ttbkey=ttbanny5051756001&MaxResults=20&start=1&SearchTarget=Book&output=js&Version=20131101";
	string listtype;
	public string image;
	public MeshRenderer[] cubeRenderer;
	public int i;
	public int j;
	WWW request;
	WWW www;
	public Text[] Text3;
	string text2;
	string json;
	string URL;


    void Start()
    {
		if (SceneManager.GetActiveScene().name == "BestSeller"){
			listtype= "&QueryType=Bestseller";
		}
		if (SceneManager.GetActiveScene().name == "NewSpecial"){
			listtype= "&QueryType=ItemNewSpecial";
		}
		if (SceneManager.GetActiveScene().name == "BlogBest"){
			listtype= "&QueryType=BlogBest";
		}
		StartCoroutine("OnResponse");
    }

	public IEnumerator OnResponse()
	{
		for(i=0;i<20;i++){
			URL = apiurl+listtype;
			request = new WWW(URL);
			yield return request;
			json = request.text;
			json = json.Replace(";", ""); //마지막 ; 없애기
			json = json.Replace("\\'", "*");
			json = json.Replace("&lt", "*"); 
			json = json.Replace("&gt", "*"); 

			list[i]= JsonUtility.FromJson<Search>(json); //이제 여기서 item(책) 추출해야 함

			text2 = "책 제목 : " + list[i].item[i].title + "\n\n"+ "저자 : "
				+list[i].item[i].author+"\n\n"+"출판사 : " +list[i].item[i].publisher+"\n\n"+
				"정가 : " +list[i].item[i].priceStandard+"원"+"\n\n"+"출간일 : " +
				list[i].item[i].pubDate+"\n\n"+list[i].item[i].description; 
			Text3[i].text = String.Copy(text2);

			list[i].item[i].coverReplace();
			image = list[i].item[i].cover;
		//	sample[i] = "http://www.aladin.co.kr/shop/book/wletslookViewer.aspx?ISBN="+list[i].item[0].isbn+"&mode=image";
			//	Application.OpenURL(sample[i]);

			www = new WWW(image);
			yield return www;
			cubeRenderer[i].material.mainTexture = www.texture;
		}
}
}
