using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class obj : MonoBehaviour {

    [SerializeField]
    private Text pickUpText;
    public GameObject Arrows;
    public Image Screw, Cogg, imgLife3;
    private bool pickUpAllowed;

    // Use this for initialization
    private void Start () {
        pickUpText.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	private void Update () {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
            PickUp();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Mikatroon"))
        {
            pickUpText.gameObject.SetActive(true);
            pickUpAllowed = true;
        }        
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Mikatroon"))
        {
            pickUpText.gameObject.SetActive(false);
            pickUpAllowed = false;
        }
    }

    private void PickUp()
    {
        Destroy(gameObject);
        if (this.gameObject.name == "screw")
            Screw.gameObject.SetActive(true);
        if (this.gameObject.name == "gear")
            Cogg.gameObject.SetActive(true);
        if(Screw.gameObject.activeSelf && Cogg.gameObject.activeSelf)
         Arrows.gameObject.SetActive(true);
    }

}
