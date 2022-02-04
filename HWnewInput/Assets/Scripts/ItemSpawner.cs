using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ItemSpawner : MonoBehaviour
{



    [SerializeField] private GameObject[] Itemspawn;

    [SerializeField] private int NumItems = 12;

    [SerializeField] private float Xbond = 12f;
    [SerializeField] private float Zbond = 12f;
    [SerializeField] private float Ybond = 100f;

    [SerializeField] private float TimeTOSpawn = 2f;
    [SerializeField] private float currentTime;
    SpawnControlls spawncontrolls;
 

    void SpreadItems()
    {
        int Yoav = Random.Range(0, Itemspawn.Length);
        Vector3 randomPos = new Vector3(Random.Range(-Xbond, Xbond), Random.Range(70, Ybond), Random.Range(-Zbond, Zbond) );

        GameObject clone = Instantiate(Itemspawn[Yoav],  randomPos, Quaternion.identity);

    }


    private void Awake()
    {
        spawncontrolls = new SpawnControlls();
    }

    private void OnEnable()
    {
        spawncontrolls.Enable();
    }
    private void OnDisable()
    {
        spawncontrolls.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        bool isKeyHeld = spawncontrolls.Player.PPspawn.ReadValue<float>() > 0.1f;

        if (isKeyHeld)
        {
            Debug.Log("WORKING");
            if (currentTime > TimeTOSpawn)
            {
                SpreadItems();
                 currentTime = 0;
            }
            
        }

        

    }
}
