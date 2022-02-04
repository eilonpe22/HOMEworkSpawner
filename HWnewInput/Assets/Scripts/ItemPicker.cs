using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPicker : MonoBehaviour
{

    public GameObject[] PickAnItem;
 
    // Update is called once per frame
    void Update()
    {
        
    }


    void Picker()
    {
        int randIndex = Random.Range(0, PickAnItem.Length);
        GameObject clone = Instantiate(PickAnItem[randIndex], transform.position, Quaternion.identity);
    }
}
