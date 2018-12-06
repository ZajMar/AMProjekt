using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;



public class CardInit : MonoBehaviour {

    public MaterialInit materialy;
    // Use this for initialization
    void Start () {
        
       int id = Random.Range(1, 52);
        GetComponent<Renderer>().material = materialy.getMaterial(id);
    }
    void Update()
    {

    }
	

}
