using UnityEngine;
using System.Collections;

public class CratesAnimationDemo : MonoBehaviour
{
	public GameObject crate1;
	public GameObject crate2;
	public GameObject crate3a;
	public GameObject crate3b;
	public GameObject crate5;
	public GameObject barrel3;
	public GameObject container1;
	
	void OnGUI()
	{
		GUI.Label(new Rect(Screen.width - (Screen.width / 3) - 78, 15, 100, 20), "Crates/Barrel:");
		if (GUI.Button(new Rect(Screen.width - (Screen.width / 3) + 20, 10, 100, 30),"Open"))
		{
			if (!crate1.GetComponent<Animation>().isPlaying && !crate2.GetComponent<Animation>().isPlaying && !crate5.GetComponent<Animation>().isPlaying)
			{
				crate1.GetComponent<Animation>()["Crate_01"].speed = 1;
				crate2.GetComponent<Animation>()["Crate_02"].speed = 1;
				crate5.GetComponent<Animation>()["Crate_05"].speed = 1;
				
				crate1.GetComponent<Animation>()["Crate_01"].time = 0;
				crate2.GetComponent<Animation>()["Crate_02"].time = 0;
				crate5.GetComponent<Animation>()["Crate_05"].time = 0;
			
				crate1.GetComponent<Animation>().Play();
				crate2.GetComponent<Animation>().Play();
				crate5.GetComponent<Animation>().Play();
				
				barrel3.GetComponent<Animation>().Play();
			}
		}
		
		if (GUI.Button(new Rect(Screen.width - (Screen.width / 3) + 135, 10, 100, 30),"Close"))
		{
			if (!crate1.GetComponent<Animation>().isPlaying && !crate2.GetComponent<Animation>().isPlaying && !crate5.GetComponent<Animation>().isPlaying)
			{
				crate1.GetComponent<Animation>()["Crate_01"].speed = -1;
				crate2.GetComponent<Animation>()["Crate_02"].speed = -1;
				crate5.GetComponent<Animation>()["Crate_05"].speed = -1;
				
				crate1.GetComponent<Animation>()["Crate_01"].time = crate1.GetComponent<Animation>()["Crate_01"].length;
				crate2.GetComponent<Animation>()["Crate_02"].time = crate2.GetComponent<Animation>()["Crate_02"].length;
				crate5.GetComponent<Animation>()["Crate_05"].time = crate5.GetComponent<Animation>()["Crate_05"].length;
			
				crate1.GetComponent<Animation>().Play();
				crate2.GetComponent<Animation>().Play();
				crate5.GetComponent<Animation>().Play();
				
				barrel3.GetComponent<Animation>().Stop();
			}
		}
		
		GUI.Label (new Rect (Screen.width - (Screen.width / 3) - 60, 55, 100, 20), "Toolboxes:");
		if (GUI.Button(new Rect(Screen.width - (Screen.width / 3) + 20, 50, 100, 30),"Open"))
		{
			if (!crate3a.GetComponent<Animation>().isPlaying && !crate3b.GetComponent<Animation>().isPlaying)
			{
				crate3a.GetComponent<Animation>()["Crate_03"].speed = 1;
				crate3b.GetComponent<Animation>()["Crate_03"].speed = 1;
				
				crate3a.GetComponent<Animation>()["Crate_03"].time = 0;
				crate3b.GetComponent<Animation>()["Crate_03"].time = 0;
			
				crate3a.GetComponent<Animation>().Play();
				crate3b.GetComponent<Animation>().Play();
			}
		}
		
		if (GUI.Button(new Rect(Screen.width - (Screen.width / 3) + 135, 50, 100, 30),"Close"))
		{
			if (!crate3a.GetComponent<Animation>().isPlaying && !crate3b.GetComponent<Animation>().isPlaying)
			{
				crate3a.GetComponent<Animation>()["Crate_03"].speed = -1;
				crate3b.GetComponent<Animation>()["Crate_03"].speed = -1;
				
				crate3a.GetComponent<Animation>()["Crate_03"].time = crate3a.GetComponent<Animation>()["Crate_03"].length;
				crate3b.GetComponent<Animation>()["Crate_03"].time = crate3b.GetComponent<Animation>()["Crate_03"].length;
			
				crate3a.GetComponent<Animation>().Play();
				crate3b.GetComponent<Animation>().Play();
			}
		}
		
		GUI.Label (new Rect (Screen.width - (Screen.width / 3) - 57, 95, 100, 20), "Container:");
		if (GUI.Button(new Rect(Screen.width - (Screen.width / 3) + 20, 90, 100, 30),"Open"))
		{
			if (!container1.GetComponent<Animation>().isPlaying)
			{
				container1.GetComponent<Animation>()["Container_01"].speed = 1;
				
				container1.GetComponent<Animation>()["Container_01"].time = 0;
			
				container1.GetComponent<Animation>().Play();
			}
		}
		
		if (GUI.Button(new Rect(Screen.width - (Screen.width / 3) + 135, 90, 100, 30),"Close"))
		{
			if (!container1.GetComponent<Animation>().isPlaying)
			{
				container1.GetComponent<Animation>()["Container_01"].speed = -1;
				
				container1.GetComponent<Animation>()["Container_01"].time = container1.GetComponent<Animation>()["Container_01"].length;
	
				container1.GetComponent<Animation>().Play();
			}
		}
	}
}
