using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Animator animate1,animate2;
    public Transform my3Dmodel1;
    public Transform my3Dmodel2;

    private int counter;
    private MoveCard myCard;
    private Vector3 showCardPosition;
    private Quaternion showCardRotation;
    // Use this for initialization
    void Start() {
        animate1 = my3Dmodel1.GetComponent<Animator>();
        animate2 = my3Dmodel2.GetComponent<Animator>();
        showCardPosition.x = -0.15f;
        showCardPosition.y = 0.005f;
        showCardPosition.z = -0.25f;
        showCardRotation = new Quaternion(-90, 180, 0, 1);
        counter = 0;
    }
    void Update()
    {

    }
	// Update is called once per frame
	public void playAnim () {
        counter = (counter + 1) % 2;
        animate1.speed = 0.1f;
        animate2.speed = 0.1f;
        if (counter == 1)
        {
            animate1.Play("card animation");
            animate2.Play("card2animation");
        }
        else
        {
            animate1.Play("cardIdle2");
        }
        
	}
    public void ClickAction()
    {
        playAnim();
    }
}
