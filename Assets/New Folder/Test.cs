using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Test : MonoBehaviour
{
    public Material material;
    private void Start()
    {
        Test1();
        transform.GetComponent<Image>().material =material;
    }

    public void DoWork(Action<bool> callback)
    {
        callback(true);
    }

    public void Test1()
    {
        DoWork((result) => Debug.Log(result));
    }

    // public GameObject popUpPrefab;

    //public void ShowPopUp(string content)
    //{
    //    GameObject popUpInstance = Instantiate(popUpPrefab);
    //    PopUpController popUpController = popUpInstance.GetComponent<PopUpController>();
    //    popUpController.SetContent(content);
    //}

   


}
