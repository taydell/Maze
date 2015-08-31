using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour 
{
	public Text timerText;
	public int timer;
	public Text restartText;
	private bool time;
	public TextMesh tm;


	private int milliseconds = 0;
	private int seconds = 0;
	private int minutes = 0;
	private bool restart;


	// Use this for initialization
	void Start () 
	{
		tm = (TextMesh)GameObject.Find("Sign Time").GetComponent<TextMesh>();
		time = false;
		restart = false;
		restartText.text = "Press 'R' to Restart";
		timer = 0;
		setTimer(); 


	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(time == true)
		{
			timer +=1;
			setTimer();
			tm.text = "Final Time: " + "(Minutes: " + minutes.ToString() + " Seconds: "+ seconds.ToString()+")";
		}

		if(Input.GetKeyDown(KeyCode.R))
		{
			Restart();
		}

	}

	void setTimer()
	{
		timer +=1;
		milliseconds = (timer %60);
		seconds = (timer/60) % 60;
		minutes = (timer /3600)% 24;
		
		timerText.text = "Playtime:" + "(Minutes: " + minutes.ToString() + " Seconds: "+ seconds.ToString()+")";
		
	}
	public void Restart()
	{
		Application.LoadLevel(Application.loadedLevel);
	}
	void OnTriggerEnter(Collider other)
	{
		time = false;
	}
	void OnTriggerExit(Collider other)
	{
		time = true;
	}

}
