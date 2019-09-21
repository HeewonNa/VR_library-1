using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class API : MonoBehaviour
{
    [System.Serializable]
    public class Search //처음 query시 나온 결과
    {
        public string version;
        public string title;
        public string link;
        public string pubDate;
        public string imageUrl;
        public string totalResults;
        public string startIndex;
        public string itemsPerPage;
        public string query;
        public string searchCategoryId;
        public string searchCategoryName;
        public Book[] item;
    }

    [System.Serializable]
    public class Book // Search class -> item 배열에 있는 결과(도서에 대한 데이터)
    {
        //멤버 변수들
        public string title;
        public string link;
        public string author;
        public string pubDate;
        public string description;
        public string creator;
        public string isbn;
        public int isbn13;
        public int itemId;
        public int priceSales;
        public int priceStandard;
        public string stockStatus;
        public int mileage;
        public string cover;
        public int categoryId;
        public string categoryName;
        public string publisher;
        public int customerReviewRank;

        //멤버 함수들
        public void CoverReplace() { this.cover = this.cover.Replace("sum", "500"); } //cover 표지 바꾸기
    }
    protected int SearchBookNum = 0; //검색된 책 개수
    public string URL = "http://www.aladin.co.kr/ttb/api/ItemSearch.aspx?ttbkey=ttbanny5051756001&Query=unity&QueryType=Title&MaxResults=10&start=1&SearchTarget=Book&output=js";
    public const string API_KEY = "ttbanny5051756001";
    //public Text responseText;

    //검색 시 생길 책 오브젝트 관련 배열
    public GameObject[] cube;



}


