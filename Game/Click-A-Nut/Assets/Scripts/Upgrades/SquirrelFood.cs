using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SquirrelFood : MonoBehaviour, IPointerClickHandler
{
    public GameObject SquirrelFoodUpgrade;
    public GameObject PopUp;
    public void Buy()
    {
        if(GetComponent<Money>().Nuts >= 100 && GetComponent<Money>().SquirrelCount >= 1)
        {
            GetComponent<Money>().Nuts -= 100;
            GetComponent<Money>().PerSquirrel += 0.1f;
            Destroy(this.gameObject);
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
