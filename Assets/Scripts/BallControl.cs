using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    Vector3 yon;
    public float hiz;
    public ZeminSpawner zeminSpawner;
    public static bool dustu_mu;
    public float eklenecekHiz;

    void Start()
    {
        yon = Vector3.forward;
        dustu_mu = false;
    }

    
    void Update()
    {
        if(transform.position.y <= 0.5f)
        {
            dustu_mu = true;
        }

        if(dustu_mu == true)
        {
            return;
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            if (yon.x == 0)
            {
                yon = Vector3.left;
            }
            else
            {
                yon = Vector3.forward;
            }
            hiz += eklenecekHiz * Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        Vector3 hareket = yon * hiz * Time.deltaTime;
        transform.Translate(hareket);
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("zemin"))
        {
            collision.gameObject.AddComponent<Rigidbody>();
            zeminSpawner.Zemin_Spawner();
            StartCoroutine(ZeminiSil(collision.gameObject));
        }
    }

    IEnumerator ZeminiSil(GameObject SilincekZemin)
    {
        yield return new WaitForSeconds(3f);
        Destroy(SilincekZemin); 
    }

}
