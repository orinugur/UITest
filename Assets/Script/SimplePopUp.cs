using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SimplePopUp : MonoBehaviour
{
    [SerializeField] Text Text_Msg;
    private void OnEnable()
    {
        StartCoroutine(coCloseSelf());
    }
    private void OnDisable()
    {
            
    }

    public void SetUI(string msg)
    {
        Text_Msg.text = msg;
        CheckAndChangeColor(msg);
    }
    private void CheckAndChangeColor(string msg)
    {
        if(msg.Contains("Ãâ·Â"))
        {
            Text_Msg.color = Color.red;
        }
    }
    IEnumerator coCloseSelf()
    {
        yield return new WaitForSecondsRealtime(1.5F);
        UiManager.Instance.CloseSpecificUI(UIType.simplePopup);
    }
}
