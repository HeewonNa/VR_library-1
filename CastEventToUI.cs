using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.Extras;
using UnityEngine.EventSystems;

namespace POLYART
{
    public class CastEventToUI : MonoBehaviour
    {
        private SteamVR_LaserPointer laserPointer;

        private void OnEnable()
        {
            laserPointer = gameObject.GetComponent<SteamVR_LaserPointer>();

            // 이벤트 할당
            laserPointer.PointerIn += OnPointerEnter;
            laserPointer.PointerOut += OnPointerExit;
            laserPointer.PointerClick += OnPointerClick;
        }

        private void OnDisable()
        {
            // 이벤트 연결 해제
            laserPointer.PointerIn -= OnPointerEnter;
            laserPointer.PointerOut -= OnPointerExit;
            laserPointer.PointerClick -= OnPointerClick;
        }

        //레이저 포인터가 들어갔을 경우
        void OnPointerEnter(object sender, PointerEventArgs e)
        {
            IPointerEnterHandler enterHandler = e.target.GetComponent<IPointerEnterHandler>();
            if (enterHandler == null) return;

            enterHandler.OnPointerEnter(new PointerEventData(EventSystem.current));
        }

        // 레이저 포인터가 나갔을경우
        void OnPointerExit(object sender, PointerEventArgs e)
        {
            IPointerExitHandler exitHandler = e.target.GetComponent<IPointerExitHandler>();
            if (exitHandler == null) return;

            exitHandler.OnPointerExit(new PointerEventData(EventSystem.current));
        }

        //트리커 버튼을 클릭했을경우
        void OnPointerClick(object sender, PointerEventArgs e)
        {
            IPointerClickHandler clickHandler = e.target.GetComponent<IPointerClickHandler>();
            if (clickHandler == null) return;

            clickHandler.OnPointerClick(new PointerEventData(EventSystem.current));
        }


        /*void Update()
        {
            GameObject hitObject;
            RaycastHit rayHit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out rayHit))
            {
              
            }
            */


    }
}
