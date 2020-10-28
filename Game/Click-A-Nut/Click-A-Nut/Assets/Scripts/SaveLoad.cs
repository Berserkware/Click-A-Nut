using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

public class SaveLoad : MonoBehaviour
{
    
    Money money; //Declares a variable, where the Type is "Money", and the name is "money".
    MoneyData moneyData; //declares a variable, where the Type is "MoneyData", and the name is "moneyData".
    //money and moneyData don't need to be public, because we'll only be using them inside this script, our SaveLoad class.

    void Start()
    {
        //Until we assign a value to "money" it's null, so lets assign it the value of the money script in our Money component, attached to this GameObject (ButtonManager)
        money = gameObject.GetComponent<Money>();
    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Saved called");
            Save();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("Load called");
            Load();
        }

    }

    private void Load()
    {
        string file = Application.dataPath + "/Scripts/SavedData.xml";
		
		//checks if a file exists at the XML file location so that we don't get a null error if there's no save data yet.
		if (System.IO.File.Exists(file))
		{
			//We have to create a new moneyData object, so that the next like has a moneyData object to look at for GetType
			moneyData = new MoneyData();
			XmlSerializer formatter = new XmlSerializer(moneyData.GetType());
			
			FileStream aFile = new FileStream(file, FileMode.Open);
			byte[] buffer = new byte[aFile.Length];
			aFile.Read(buffer, 0, (int)aFile.Length);
			MemoryStream stream = new MemoryStream(buffer);

			//Gives the moneyData variable the value of the MoneyData object created from our save file
			moneyData = (MoneyData)formatter.Deserialize(stream);
			money.LoadMoneyData(moneyData);
		}
		else
		{
			Debug.Log("No Save data created yet");
		}
    }


    private void Save()
    {
        //We need to assign a value to moneyData, because it's not a monobehaviour we use the "new" keyword instead of GetComponent
        //Right now we have a MoneyData object but all the variables inside that object will be "null", so we need to assign values.
        moneyData = new MoneyData();

        //The MoneyData class contains a function called SetMoneyData, that takes a variable where the type is "Money" as an input.
        //Each time we run our Save function it will call the SetMoneyData function which will set all the variables in moneyData to be equal to the values of those variables in our money object
        moneyData.SetMoneyData(money);

        string path = Application.dataPath + "/Scripts/SavedData.xml";
        FileStream outFile = File.Create(path);
        XmlSerializer formatter = new XmlSerializer(moneyData.GetType());
        formatter.Serialize(outFile, moneyData);
    }

}
