using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ValueManipulation : MonoBehaviour
{
    public List<DataObject> DataObjects;
    public TextMeshProUGUI scoreText;

    public void Manipulate()
    {
        foreach(DataObject dataObject in DataObjects)
        {
            dataObject.firstInt+= Random.Range(-50, 50);
            dataObject.secondInt+= Random.Range(-2, 2);
            Debug.Log(dataObject.firstInt);
            Debug.Log(dataObject.secondInt);
            Debug.Log(DataObject.title);
        }
    }
}
