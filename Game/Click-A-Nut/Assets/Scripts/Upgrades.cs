using UnityEngine;

public class Upgrades : MonoBehaviour
{
    public GameObject[] PopUpWindows;
    public GameObject[] UpgradesThings;
    public float Time;

    private void Start()
    {
        PopUpWindows[0].SetActive(false);
        
    }
    public void SquirrelFood()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            PopUpWindows[0].SetActive(true);
        }
        
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            SquirrelFood();
        }
    }

}
