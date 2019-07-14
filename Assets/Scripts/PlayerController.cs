using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{
	public float speed;
	public Text countText;
	public Text winText;
	private Rigidbody rb;
	private int count = 0;
	void Start(){
		rb = GetComponent<Rigidbody>();
    		winText.text = "";
		
	}
	void FixedUpdate(){
		float moveHorizontal 	= Input.GetAxis("Horizontal");
		float moveVeritcal 		= Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVeritcal);
		rb.AddForce(movement * speed);


	}
	  void OnTriggerEnter(Collider other)  {
         if (other.gameObject.CompareTag ("pickup")){
            other.gameObject.SetActive (false);
           	count = count + 1;
           	setCounttext();
        }
    }
    void setCounttext(){
    	countText.text = "Counts: " + count.ToString();
    	if(count == 4){
    		countText.text = "";
    		winText.text = "You won";

    	}
    }
}
