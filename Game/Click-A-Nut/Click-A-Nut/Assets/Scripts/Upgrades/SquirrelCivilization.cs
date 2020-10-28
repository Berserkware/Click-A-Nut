﻿using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SquirrelCivilization : MonoBehaviour, IPointerClickHandler
{
    public GameObject PopUp;
    public void Buy()
    {
        if (GameObject.Find("ButtonManager").GetComponent<Money>().Nuts >= 523000000 && GameObject.Find("ButtonManager").GetComponent<Money>().SquirrelCount >= 50 && GameObject.Find("ButtonManager").GetComponent<Money>().PlanetNutCount >= 5)
        {
            GameObject.Find("ButtonManager").GetComponent<Money>().Nuts -= 523000000;
            GameObject.Find("ButtonManager").GetComponent<Money>().PerPlanetNut += 10000000;
            GameObject.Find("ButtonManager").GetComponent<Money>().PerSquirrel += 10;
            Destroy(this.gameObject);
            PopUp.SetActive(false);
        }
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            PopUp.SetActive(true);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PopUp.SetActive(false);
        }
    }

    private void Start()
    {
        PopUp.SetActive(false);

    }
}