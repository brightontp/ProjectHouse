using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
	public GameObject GlowInDark;
	public GameObject lighting;
	public Interaction script;
	// Use this for initialization
	void Start()
	{
		lighting.SetActive(true);
		GlowInDark.SetActive(false);
	}

	// Update is called once per frame
	void Update()
	{
		// Toggle light on/off when L key is pressed.
		if (script.activate == "on")
		{
			
			lighting.SetActive(false);
			GlowInDark.SetActive(true);
		}
	}

}
