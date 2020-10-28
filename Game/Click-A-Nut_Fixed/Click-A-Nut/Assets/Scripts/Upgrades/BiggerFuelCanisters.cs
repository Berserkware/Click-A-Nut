using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BiggerFuelCanisters : MonoBehaviour, IPointerClickHandler
{
    public GameObject PopUp;
    public void Buy()
    {
        if (GameObject.Find("ButtonManager").GetComponent<Money>().Nuts >= 76000000 && GameObject.Find("ButtonManager").GetComponent<Money>().SpaceshipCount >= 8)
        {
            GameObject.Find("ButtonManager").GetComponent<Money>().Nuts -= 76000000;
            GameObject.Find("ButtonManager").GetComponent<Money>().PerSpaceship += 2400000;
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