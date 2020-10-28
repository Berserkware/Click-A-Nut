using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class EletricTree : MonoBehaviour, IPointerClickHandler
{
    public GameObject PopUp;
    public void Buy()
    {
        if (GameObject.Find("ButtonManager").GetComponent<Money>().Nuts >= 15000 && GameObject.Find("ButtonManager").GetComponent<Money>().TreeCount >= 50 && GameObject.Find("ButtonManager").GetComponent<Money>().LabCount >= 1)
        {
            GameObject.Find("ButtonManager").GetComponent<Money>().Nuts -= 15000;
            GameObject.Find("ButtonManager").GetComponent<Money>().PerTree += 10;
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
