using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class PopupUI : MonoBehaviour
{
    public TMP_Text text;
    public TMP_Text description;
    public TMP_Text yestxt, notxt;
    public Button yes, no;
    public popupType popuptype;
    //callback onYes;
    //callback onNo;

    private void Start()
    {

    }

    public enum popupType
    {
        popup_tdyn,
        popup_tdr,
        popup_tdoc,
        popup_tdo,
        popup_tdvc
    }

    public void Createpopup( string text , string description, string yestxt = "yes", string notxt = "no")
    {

    }


    //public void showType(popupType type)
    //{
    //    popuptype = type;
    //    switch (type)
    //    {
    //        case popupType.popup_tdyn:
    //            text.gameObject.SetActive(true);
    //            description.gameObject.SetActive(true);
    //            yes.gameObject.SetActive(true);
    //            no.gameObject.SetActive(true);
    //            break;

    //        case popupType.popup_tdr:
    //            text.gameObject.SetActive(true);
    //            description.gameObject.SetActive(true);
    //            retry.gameObject.SetActive(true);
    //            break;

    //        case popupType.popup_tdoc:
    //            text.gameObject.SetActive(true);
    //            description.gameObject.SetActive(true);
    //            ok.gameObject.SetActive(true);
    //            cancle.gameObject.SetActive(true);
    //            break;

    //        case popupType.popup_tdo:
    //            text.gameObject.SetActive(true);
    //            description.gameObject.SetActive(true);
    //            ok.gameObject.SetActive(true);
    //            break;

    //        case popupType.popup_tdvc:
    //            text.gameObject.SetActive(true);
    //            description.gameObject.SetActive(true);
    //            validate.gameObject.SetActive(true);
    //            cancle.gameObject.SetActive(true);
    //            break;

    //    }
    //}
    //public void OnYesButton()
    //{
    //    if (onYes != null)
    //    {
    //        onYes();
    //    }
    //}

  
}

