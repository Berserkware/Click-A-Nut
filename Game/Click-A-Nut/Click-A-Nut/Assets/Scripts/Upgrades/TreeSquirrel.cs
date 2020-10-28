using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TreeSquirrel : MonoBehaviour, IPointerClickHandler
{
    public GameObject PopUp;
    public void Buy()
    {
        if (GameObject.Find("ButtonManager").GetComponent<Money>().Nuts >= 1200 && GameObject.Find("ButtonManager").GetComponent<Money>().SquirrelCount >= 10 && GameObject.Find("ButtonManager").GetComponent<Money>().TreeCount >= 2)
        {
            GameObject.Find("ButtonManager").GetComponent<Money>().Nuts -= 1200;
            GameObject.Find("ButtonManager").GetComponent<Money>().PerSquirrel *= 2;
            GameObject.Find("ButtonManager").GetComponent<Money>().PerTree += 2;
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
