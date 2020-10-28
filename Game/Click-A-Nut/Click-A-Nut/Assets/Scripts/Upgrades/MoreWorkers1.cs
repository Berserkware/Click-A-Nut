using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MoreWorkers1 : MonoBehaviour, IPointerClickHandler
{
    public GameObject PopUp;
    public void Buy()
    {
        if (GameObject.Find("ButtonManager").GetComponent<Money>().Nuts >= 56000 && GameObject.Find("ButtonManager").GetComponent<Money>().FactoryCount >= 20)
        {
            GameObject.Find("ButtonManager").GetComponent<Money>().Nuts -= 56000;
            GameObject.Find("ButtonManager").GetComponent<Money>().PerFactory += 50;
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
