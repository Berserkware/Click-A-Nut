﻿using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SquirrelFood : MonoBehaviour, IPointerClickHandler
{
    public GameObject PopUp;
    public void Buy()
    {
        if(GameObject.Find("ButtonManager").GetComponent<Money>().Nuts >= 300 && GameObject.Find("ButtonManager").GetComponent<Money>().SquirrelCount >= 1)
        {
            GameObject.Find("ButtonManager").GetComponent<Money>().Nuts -= 300;
            GameObject.Find("ButtonManager").GetComponent<Money>().PerSquirrel += 0.1f;
            Destroy(this.gameObject);
            PopUp.SetActive(false);
        }
    }
    public void OnPointerClick (PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            PopUp.SetActive(true);
        }
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            PopUp.SetActive(false);
        }
    }

    private void Start()
    {
        PopUp.SetActive(false);
        
    }
}
