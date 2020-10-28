using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FarmSquirrel : MonoBehaviour, IPointerClickHandler
{
    public GameObject PopUp;
    public void Buy()
    {
        if (GameObject.Find("ButtonManager").GetComponent<Money>().Nuts >= 5500 && GameObject.Find("ButtonManager").GetComponent<Money>().SquirrelCount >= 100 && GameObject.Find("ButtonManager").GetComponent<Money>().FarmCount >= 3)
        {
            GameObject.Find("ButtonManager").GetComponent<Money>().Nuts -= 5500;
            GameObject.Find("ButtonManager").GetComponent<Money>().PerSquirrel += 0.5f;
            GameObject.Find("ButtonManager").GetComponent<Money>().PerFarm += 3;
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
