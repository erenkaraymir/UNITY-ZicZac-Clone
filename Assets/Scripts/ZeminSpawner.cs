using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminSpawner : MonoBehaviour
{

    public GameObject son_zemin;

    void Start()
    {
        for (int i = 0; i < 40; i++)
        {
            Zemin_Spawner();
        }
    }
        
 

    public void Zemin_Spawner()
    {
        Vector3 yon;
        if(Random.Range(0,2) == 0)
        {
            yon = Vector3.left; 
        }
        else
        {
            yon = Vector3.forward;
        }
        son_zemin = Instantiate(son_zemin, son_zemin.transform.position + yon, Quaternion.identity);

    }
}
