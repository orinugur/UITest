using System.Collections;
using System.Collections.Generic;
using UnityEngine;


   public enum UIType
    {
        simplePopup,
        MainUI,
    }

public class UiManager : MonoBehaviour
{
    public static UiManager Instance {  get; set; }
    
    [SerializeField] SimplePopUp _simplePopup;

private Dictionary<UIType, GameObject> _openedUIDic = new Dictionary<UIType, GameObject>();

    public void Awake()
    {
        UiManager.Instance = this;
    }
    public void OpenUI(UIType uiType, GameObject uiObject)
    {
        if(_openedUIDic.ContainsKey(uiType) == false)
        {
            uiObject.SetActive(true);
            _openedUIDic.Add(uiType, uiObject);
        }
    }
    public void OpenSimplePopup(string msg)
    {
        if(_simplePopup !=null)
        {
            OpenUI(UIType.simplePopup,_simplePopup.gameObject);
            //_simplePopup.gameObject.SetActive(true);
            _simplePopup.SetUI(msg);
        }
    }
    private void CloseUI(UIType uiType)
    {
        if(_openedUIDic.ContainsKey(uiType))
        {
            var uiobject = _openedUIDic[uiType];//상수시간접근
            uiobject.SetActive(false);
            _openedUIDic.Remove(uiType);
        }
    }
    public void CloseSpecificUI(UIType uitype)

    {
        CloseUI(uitype);

    }
}
