﻿/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_Enemy : MonoBehaviour
{

    public int rutina;
    public float crono;
    public Animator ani;
    public Quaternion angulo;
    public float grado;
    

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    public void Comportamiento_Enemy(){
             crono += 1* Time.deltaTime;
        if(crono>=4){
            rutina = Random.Range(0,2);
            crono = 0;
        }  
        switch (rutina) {
            case 0:
            ani.SetBool("walk", false);
            break;

            case 1:
            grado = Random.Range(0,360);
            angulo = Quaternion.Euler(0,grado,0);
            rutina++;
            break;

            case 2:
            transform.rotation =Quaternion.RotateTowards(transform.rotation, angulo, 0.5f);
            transform.Translate(vector3.forward*1*Time.deltaTime);
            ani.SetBool("walk",true);
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {
     Comportamiento_Enemy();  
    }
}
 */