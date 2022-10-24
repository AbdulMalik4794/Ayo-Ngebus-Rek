using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
   	public float speed = 1000f;
    public GameObject WarningSign;
    public WheelJoint2D backWheel;
    public WheelJoint2D frontWheel;
    public Rigidbody2D rb;
    private float movement = 0f;
    private float rotation = 0f;
    private bool gasIsPressed = false;
    private bool remIsPressed = false;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(gasIsPressed)
        {
            movement = CrossPlatformInputManager.GetAxis("Horizontal") * speed;
        }
        else if(remIsPressed)
        {
            movement = 1;
        }
        else
        {
            movement = 0;
        }
    }
	void FixedUpdate()
    {
        if (movement > 0)
        {
            backWheel.useMotor = false;
            frontWheel.useMotor = false;

            JointMotor2D motor = new JointMotor2D { motorSpeed = 0, 
            	maxMotorTorque = 10000 };
            backWheel.motor = motor;
            frontWheel.motor = motor;
        }
        else if (movement < 0)
        {
            backWheel.useMotor = true;
            frontWheel.useMotor = true;

            JointMotor2D motor = new JointMotor2D { motorSpeed = movement, 
            	maxMotorTorque = 10000 };
            backWheel.motor = motor;
            frontWheel.motor = motor;
        }
        else
        {
            backWheel.useMotor = false;
            frontWheel.useMotor = false;            
        }

       rb.AddTorque(rotation * 700 * Time.fixedDeltaTime);
    }
    public void GasIsPressed()
    {
        gasIsPressed = true;
    }
    public void GasIsNotPressed()
    {
        gasIsPressed = false;
    }
    public void RemIsPressed()
    {
        remIsPressed = true;
    }
    public void RemIsNotPressed()
    {
        remIsPressed = false;
    }
    //********************************************
    private void OnTriggerEnter2D(Collider2D collision){
    	switch (collision.name){
    		case "botolbesar(Clone)":
	    		Score.scoreAmount +=3;
	    		Destroy(collision.gameObject);
	    		break;
	    	case "botoltanggung(Clone)":
	    		Score.scoreAmount +=5;
	    		Destroy(collision.gameObject);
	    		break;
	    	case "botolgelas(Clone)":
	    		Score.scoreAmount +=10;
	    		Destroy(collision.gameObject);
	    		break;
            case "Enemy":
                SceneManager.LoadScene("Game Over");
                break;
            case "Penyeberangan":
            	WarningSign.gameObject.SetActive (false);
            	break;
    	}
    }
}