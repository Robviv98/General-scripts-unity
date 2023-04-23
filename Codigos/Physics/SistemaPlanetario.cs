using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaPlanetario : MonoBehaviour
{
    int Num = 0;
    public float pesoA=1;

    public GameObject[] planets;
    float[] peso;
    float Fx=0, Fy=0, Fz=0;
    float K = 1;
    public float impulsoI = 10;

    Rigidbody rb;




    private void Start()
    {
        K = transform.parent.GetComponent<DatosGPlanetas>().K;
        initial();
        recorrer();

    }
    
    private void FixedUpdate()
    {
        recorrer();
    }
    void initial()
    {
        Num = transform.parent.childCount;
        planets = new GameObject[Num];
        peso = new float[Num];
        rb = GetComponent<Rigidbody>();

        for (int c = 0; c < Num; c++)
        {
            planets[c] = transform.parent.GetChild(c).gameObject;
            peso[c] = planets[c].GetComponent<SistemaPlanetario>().pesoA;

        }



        if (this.name != "Sun")
        {
            rb.AddForce(new Vector3(-impulsoI,0,0),ForceMode.Impulse);
        }
        
    }

    void recorrer()
    {
        Fx = 0;
        Fy = 0;
        Fz = 0;
        //Debug.Log("H");
        for (int i = 0; i < Num; i++)
        {
            if (this.name == planets[i].name)
            {
                continue;
            }
            Fx += (Vector3.Normalize(-transform.position + planets[i].transform.position).x) * (K * pesoA * planets[i].GetComponent<SistemaPlanetario>().pesoA) / Mathf.Pow(Vector3.Distance(transform.position, planets[i].transform.position), 2);
            Fy += (Vector3.Normalize(-transform.position + planets[i].transform.position).y) * (K * pesoA * planets[i].GetComponent<SistemaPlanetario>().pesoA) / Mathf.Pow(Vector3.Distance(transform.position, planets[i].transform.position), 2);
            Fz += (Vector3.Normalize(-transform.position + planets[i].transform.position).z) * (K * pesoA * planets[i].GetComponent<SistemaPlanetario>().pesoA) / Mathf.Pow(Vector3.Distance(transform.position, planets[i].transform.position), 2);
        }


        
        this.rb.AddForce(new Vector3(Fx,Fy,Fz)*Time.deltaTime,ForceMode.Force);

    }

}
