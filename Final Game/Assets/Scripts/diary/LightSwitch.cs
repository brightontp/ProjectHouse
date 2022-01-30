using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
	public GameObject GlowInDark;
	public GameObject lighting;
	public Interaction script;
	private Light lighted;
	public int flicker;
	// Use this for initialization
	void Start()
	{
		lighted = lighting.GetComponent<Light>();
		lighted.intensity = 10;  //normal scene lighting
		GlowInDark.SetActive(false);  //cant see text on walls
		
	}

	// Update is called once per frame
	void Update()
	{
		// Toggle light on/off when key is pressed.
		if (script.activate == "on")
		{
			for (int i = 0; i < flicker; i++)
            {
				
				StartCoroutine(LightFlicker());   //dims lighting
				GlowInDark.SetActive(true); //can see text on wall
			}
			
		}
	}

	IEnumerator LightFlicker()
	{
		lighted.intensity = 0;
		yield return new WaitForSecondsRealtime(0.4f);
		lighted.intensity = 4;
		yield return new WaitForSecondsRealtime(0.3f);

	}
}
