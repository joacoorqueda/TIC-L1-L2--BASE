﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayManager : MonoBehaviour
{
    [SerializeField] GameObject[] objectsCollection;
    public int randomNumber;
    [SerializeField]Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        objectsCollection = GameObject.FindGameObjectsWithTag("ObjetosLaB");
        AgregarCollider();

        for (int i = 0; i <objectsCollection.Length; i++) 
        {
        //Destroy(objectsCollection[0]);
        }
           
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.P))
        {
            PocisionarElementosDelArray();
            GenerarNroAlAzar();
            

        }
        if(Input.GetKeyDown(KeyCode.I))
        {
            Instanciarobjetoalazar();     

        }
    }

   


    void DestruirElementosDelArray()
    {
        for (int i = 0; i < objectsCollection.Length; i++)
        {
            Destroy(objectsCollection[0]);
        }
    }

    void PocisionarElementosDelArray()
    {
        for (int i = 0; i < objectsCollection.Length; i++)
        {

            objectsCollection[0].transform.position = new Vector3(2.8f + i , 0.7f, 9f);
        }

       
    }

    void AgregarCollider()
    {
        for (int i = 0; i < objectsCollection.Length; i++)
        {
            objectsCollection[i].AddComponent<BoxCollider>();
        }
    }

    void GenerarNroAlAzar()
    {
        randomNumber = Random.Range(1,11);
    }

    void Instanciarobjetoalazar()
    {
        Instantiate(objectsCollection[Random.Range(0, objectsCollection.Length)], spawnPoint.position, Quaternion.identity);
    }

}
