using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class Main : MonoBehaviour
{
    public Animator animator;
    public static Main inst;
    public TMP_Text titleText;

    public GameObject leftButton;
    public GameObject rightButton;
    public GameObject centerButton;

    public TMP_Text leftbtnTxt;
    public TMP_Text rightbtnTxt;
    public TMP_Text centerbtnTxt;

    public Action<bool> callBack;
    public bool isEnable;
    public GameObject panel;
    public Button bgclose;
    public GameObject panelclose;



    private void Start()
    {
        QuiteShow();
       
    }
    public void SetContent(string title, string ltbtn, string rtbtn, string cbtn, Action<bool> callBack=null)
    {

        titleText.text = title;

        leftButton.SetActive(!string.IsNullOrEmpty(ltbtn));
        rightButton.SetActive(!string.IsNullOrEmpty(rtbtn));
        centerButton.SetActive(!string.IsNullOrEmpty(cbtn));

        leftbtnTxt.text = ltbtn;
        rightbtnTxt.text = rtbtn;
        centerbtnTxt.text = cbtn;

        if(callBack!=null)
        {
            callBack(false);
        }
    }

    void NetworkShow(Action<bool> callBack)
    {
        Debug.Log("In Network Show");
        callBack(true);
        SetContent("NetWork Failed", "", "", "Retry",callBack,true);
        panelclose.SetActive(false);


    }

    private void SetContent(string v1, string v2, string v3, string v4, Action<bool> callBack, bool v5)
    {
        throw new NotImplementedException();
    }

    void QuiteShow()
    {
        SetContent("Are You Quite", "Yes", "No", "",callBack,false);
        bgclose.GetComponent<Button>().interactable = false;
      
    }
    public void OnCloseButton()
    {
        panel.SetActive(false);
    }

    public void OnYesButtonClick()
    {

        NetworkShow((result) => Debug.Log("You Click Yes Button"));
    }


}

