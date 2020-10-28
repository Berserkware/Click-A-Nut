using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class IslandFarm : MonoBehaviour, IPointerClickHandler
{
    public GameObject PopUp;
    public void Buy()
    {
        if (GameObject.Find("ButtonManager").GetComponent<Money>().Nuts >= 10000000 && GameObject.Find("ButtonManager").GetComponent<Money>().NutIslandCount >= 10 && GameObject.Find("ButtonManager").GetComponent<Money>().FarmCount >= 50)
        {
            GameObject.Find("ButtonManager").GetComponent<Money>().Nuts -= 10000000;
            GameObject.Find("ButtonManager").GetComponent<Money>().PerNutIsland += 456000;
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