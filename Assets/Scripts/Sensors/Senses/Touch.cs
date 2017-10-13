using UnityEngine;
using System.Collections;

public class Touch : Sense
{
	void OnEnable()
	{
		TouchEventManager.onTouch += ChangeColor;
	}
	
	
	void OnDisable()
	{
		TouchEventManager.onTouch -= ChangeColor;
	}

    void OnTriggerEnter(Collider other)
    {
		Debug.Log ("touched?");
        Aspect aspect = other.GetComponent<Aspect>();
        if (aspect != null)
        {
            //Check the aspect
            if (aspect.aspectName == aspectName)
            {
                print("Enemy Touch Detected");
            }
        }

		TouchEventManager.OnTouchEvent ();
    }

	void ChangeColor() 
	{
		Color col = new Color(Random.value, Random.value, Random.value);
		GetComponent<Renderer>().material.color = col;
	}
}
