using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TallerBuildings : MonoBehaviour, IPointerClickHandler
{
    public GameObject PopUp;
    public void Buy()
    {
        if (GameObject.Find("ButtonManager").GetComponent<Money>().Nuts >= 560000 && GameObject.Find("ButtonManager").GetComponent<Money>().NutCorpCount >= 1)
        {
            GameObject.Find("ButtonManager").GetComponent<Money>().Nuts -= 560000;
            GameObject.Find("ButtonManager").GetComponent<Money>().PerNutCorp += 5000;
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