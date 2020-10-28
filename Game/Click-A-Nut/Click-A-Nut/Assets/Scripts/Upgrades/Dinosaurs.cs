using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Dinosaurs : MonoBehaviour, IPointerClickHandler
{
    public GameObject PopUp;
    public void Buy()
    {
        if (GameObject.Find("ButtonManager").GetComponent<Money>().Nuts >= 1000000000 && GameObject.Find("ButtonManager").GetComponent<Money>().LabCount >= 10 && GameObject.Find("ButtonManager").GetComponent<Money>().PlanetNutCount >= 20)
        {
            GameObject.Find("ButtonManager").GetComponent<Money>().Nuts -= 1000000000;
            GameObject.Find("ButtonManager").GetComponent<Money>().PerPlanetNut += 16000000;
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