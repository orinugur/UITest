using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUi : MonoBehaviour
{
    //[SerializeField] SimplePopUp popup_SimpleUI;
    [SerializeField] Button Button;
    // Start is called before the first frame update
    //WaitForSecondsRealtime WaitForSecondsRealtime = new WaitForSecondsRealtime (1f);  
    public void OnClick_PopupSimpleMsg()
    {
        UiManager.Instance.OpenSimplePopup("�θӸ���Ӹ��ǵ�ǵ������");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
