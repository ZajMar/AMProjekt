using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitCardStart : MonoBehaviour {



    public List<Object> pPrefab;
    public GameObject gameCard;
    private Animation animator;
    private GameObject pNewObject;
    // Use this for initialization
    void Start () {

        Vector3 showCardPosition;
        Quaternion showCardRotation;
        showCardPosition.x = -0.25f;
        showCardPosition.y = 0.010f;
        showCardPosition.z = -0.25f;
        showCardRotation = new Quaternion(-90, 180, 0, 0);
        pNewObject = (GameObject)GameObject.Instantiate(pPrefab[0], showCardPosition, showCardRotation);
        pNewObject.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        pNewObject.transform.SetPositionAndRotation(new Vector3(-0.25f, 0.010f, -0.15f),new Quaternion(-90, 180, 0, 0));
    }
	
	// Update is called once per frame
	void Update () {
		
	}

}
