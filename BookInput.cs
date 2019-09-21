using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookInput : API
{
    //[SerializeField] private Text txt_Book; //출력할 책 이름
    [SerializeField] private InputField inputTxT_Book; //입력받은 책 이름
    [SerializeField][Range(0f, 1f)] private float speed = 1f;

    public string url = "http://www.aladin.co.kr/ttb/api/ItemSearch.aspx?ttbkey=ttbanny5051756001&QueryType=Title&MaxResults=10&start=1&SearchTarget=Book&output=js";
    public string newURL; // 검색한 책에 대한 url
    private string currentBook; // 현재 책 이름
    public Search query = new Search();

    //그려낼 cube를 위한 선언
   
    protected int arraysize;
    private float pos = 2.7f;

    //click 시에 나올 정보를 위한 선언
    private GameObject target;
    private GameObject CurrentBookTarget; //현재 선택된 bookobj
    public GameObject background;
    public GameObject info; 
    public GameObject BackButton;
    public GameObject Cam;  // maincamera
    private string txt;
    private bool movingObj = false;
    private int a = 1;
    private float runningTime = 0f;
    private float yPos = 0f;

    Vector3 position1;
    Vector3 scale1;
    Vector3 position2;
    Vector3 scale2;
    Vector3 CamPosReset;


    void Start()
    {
        background.SetActive(false);
        info.SetActive(false);
        BackButton.SetActive(false);
        CamPosReset = Cam.transform.position;
    }

    void Update()
    {
        
        if (Input.GetMouseButton(0))
        {
            a = 2;
            target = GetClickedObject(); 
           
            for(int i = 0; i < SearchBookNum; i++)
            {
                if (target == cube[i].gameObject) {
                    CurrentBookTarget = target;
                    txt = "제목 : " + query.item[i].title + "\n\n저자 : " + query.item[i].author
                        + "\n\n출판사 : " + query.item[i].publisher + "\n\n출간일: " + query.item[i].pubDate
                        + "\n\n정가 : " + query.item[i].priceStandard + "\n\n미리보기 : " + query.item[i].description;
                    ChangeScaleUp();//함수호출
                    break;
                }
            }
            
        }

        //Camera 설정 다시하기
        /*if (SearchBookNum > 0)
        {
            Debug.Log("x : " + cube[SearchBookNum - 1].transform.position.x);
            if (Cam.transform.position.x < 5.23f)
            {
                Cam.transform.position = new Vector3(5.23f, Cam.transform.position.y, Cam.transform.position.z);
            }
            if (Cam.transform.position.x > cube[SearchBookNum-1].transform.position.x)
            {
                Cam.transform.position = new Vector3(cube[SearchBookNum - 1].transform.position.x-5.44f, Cam.transform.position.y, Cam.transform.position.z);
            }
               
        }*/

        if (movingObj == true)
        {
            //ScaleUp된 obj를 상하로 약간만 움직이는 코드작성
            runningTime += Time.deltaTime * speed;
            yPos = Mathf.Sin(runningTime) * 0.135f + Cam.transform.position.y;
            //Debug.Log(yPos);
            CurrentBookTarget.transform.position = new Vector3(CurrentBookTarget.transform.position.x, yPos, CurrentBookTarget.transform.position.z);
        }
    }

    public void SearchInput()
    {
        //Camera를 처음 위치로 이동시키기(Cam position reset)
        Cam.transform.position = CamPosReset;

        //cube object reset 하기
        ResetCube();

        //검색어로 api에서 불러오기
        currentBook = inputTxT_Book.text;
        newURL = url + "&Query=" + currentBook;

        WWW request = new WWW(newURL);
        StartCoroutine(OnResponse(request));
    }

    public IEnumerator OnResponse(WWW req)
    {
        yield return req;
        Debug.Log("Text Start");
        string json = req.text;
       
        json = json.Replace(";", ""); //마지막 ; 없애기
        json = json.Replace("\\'", "*");
        Debug.Log(json);

        query = JsonUtility.FromJson<Search>(json); //이제 여기서 item(책) 추출해야 함
        SearchBookNum = query.item.Length;

        //받아온 개수로 cube 그려내기
        arraysize = SearchBookNum;
        Debug.Log("arraysize : " + arraysize);
        cube = new GameObject[arraysize];
        
        for (int i = 0; i < arraysize; i++)
        {
            cube[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);  //큐브 오브젝트 생성

            //오브젝트 텍스쳐 변경
            query.item[i].CoverReplace();
            string image = query.item[i].cover;

            WWW www = new WWW(image);
            yield return www;
            cube[i].GetComponent<Renderer>().material.mainTexture = www.texture;

            //큐브 포지션 설정
            cube[i].transform.position = new Vector3(pos * i, 1, 0.8f); // 0.8f
            cube[i].transform.localScale = new Vector3(1.5f, 1.7f, 0.25f);
            cube[i].transform.Rotate(Vector3.back * 180);
        }
        Debug.Log("End");
    }


    //cube array를 초기화시키는 함수
    public void ResetCube()
    {
        for (int i = 0; i < cube.Length; i++)
            Destroy(cube[i]);
    }

    private GameObject GetClickedObject()

    {
        RaycastHit hit;
        GameObject target = null;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //마우스 포인트 근처 좌표를 만든다. 

        if (true == (Physics.Raycast(ray.origin, ray.direction * 10, out hit)))   //마우스 근처에 오브젝트가 있는지 확인

        {
            target = hit.collider.gameObject;
        }
        
        return target;
    }

    //선택한 책이 커지는 함수
    public void ChangeScaleUp()
    {
        scale1 = CurrentBookTarget.transform.localScale;
        position1 = CurrentBookTarget.transform.position;
        
        Debug.Log("ChangeScaleUp()///x : " + target.transform.position.x + " y : " + target.transform.position.y + " z : " + target.transform.position.z);
        scale2.x = 2.2f;
        scale2.y = 3;
        scale2.z = 0.3f;
        position2.x = Cam.transform.position.x - 2.45f;
        position2.y = 0.68f;
        position2.z = 0.0f;
        CurrentBookTarget.transform.localScale = scale2;
        CurrentBookTarget.transform.position = position2;
        
        movingObj = true;

        info.GetComponent<Text>().text = txt;
        background.SetActive(true);
        info.SetActive(true);
        BackButton.SetActive(true);
    }

    //뒤로가기 버튼을 누르면 책이 작아지는 함수
    public void ChangeScaleDown()
    {
        a = 1;
        /*Back button click 시 target이 NULL로 변경되므로 이를 해결해야함!!*/
        movingObj = false;
        CurrentBookTarget.transform.localScale = scale1;
        CurrentBookTarget.transform.position = position1;
        background.SetActive(false);
        info.SetActive(false);
        BackButton.SetActive(false);
    }
}
