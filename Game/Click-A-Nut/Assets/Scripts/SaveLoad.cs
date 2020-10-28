using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

public class SaveLoad : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            Money money = GetComponent<Money>();
            Save(money);
        }

    }

    private Money Load()
    {
        string file = "filepath";
        Money money = GetComponent<Money>();
        XmlSerializer formatter = new XmlSerializer(money.GetType());
        FileStream aFile = new FileStream(file, FileMode.Open);
        byte[] buffer = new byte[aFile.Length];
        aFile.Read(buffer, 0, (int)aFile.Length);
        MemoryStream stream = new MemoryStream(buffer);
        return (Money)formatter.Deserialize(stream);
    }


    private void Save(Money money)
    {
        string path = Application.dataPath + "/Scripts/SavedData.xml";
        FileStream outFile = File.Create(path);
        XmlSerializer formatter = new XmlSerializer(money.GetType());
        formatter.Serialize(outFile, money);
    }

}
