using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       //Tells the script we are using Unity's UI system.

public class PlayerController : MonoBehaviour
{

    public float speed;     //creates a variable that will show up in the inspector in Unity so that it can be adjusted there instead of changing the code.
    public Text countText;  //creates a new variable to hold a reference to the UI text - Count Text.
    public Text winText;    //creates a new variable to hold a reference to the UI text - Win Text.

    private Rigidbody rb;
    private int count;      //creating a int to store score 

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;      //starts count at 0
        SetCountText ();    //calls SetCountText function
        winText.text = "";  //sets it so text is not displayed.


    }
    void FixedUpdate()
    {
        //gets input from player
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical); //no movement along the y axis as the sphere will not go up and down.

        rb.AddForce(movement * speed); //grabbed from new vector3 declared above.
    }
    //called everytime the colliders touch.
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;      //after Pick Up has been set to false, ie picked up, the count is increased by 1.
            SetCountText ();   //calls SetCounterText function
        }
    }

    void SetCountText ()    //creates a function to set the starting value of the UI texts property.
        {
        countText.text = "Count: " + count.ToString ();  //set starting value of UI text's property
        if (count >=10)
        {
            winText.text = "You win";
        }
        }
}

   