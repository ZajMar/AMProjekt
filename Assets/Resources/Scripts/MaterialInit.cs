using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialInit : MonoBehaviour {

    public List<Material> materials;
	// Use this for initialization
	void Start () {
		
	}
    public Material getMaterial(int id)
    {
        return materials[id];
    }
    // Update is called once per frame
    void Update () {
		
	}
}
