using UnityEngine; //41 Post - Created by DimasTheDriver on March/13/2013 . Part of the 'Unity: animated Ellipsis' post. Available at: http://www.41post.com/?p=5130
using System.Collections;

public class FakeLoadingOperationDeterminate : MonoBehaviour 
{
	private AnimatedEllipsis animatedEllipsis;
	
	//Use this counter to simulate a fake loading operation
	private int counter = 0;
	
	public GUISkin fontGUISkin;
	
	// Use this for initialization
	void Start () 
	{
		this.animatedEllipsis = this.GetComponent<AnimatedEllipsis>();
		
		this.animatedEllipsis.onCompletion = DisplayMessageOnCompletion;
		
		//Start the fake loading operatrion for the determinated animated ellipsis (see below)
		StartCoroutine(LoadingOperation());
	}
	
	void OnGUI() 
	{
		GUI.Label(new Rect(100,250,1000,300), this.animatedEllipsis.text + " " + Mathf.Clamp(this.counter, this.animatedEllipsis.minProgress, this.animatedEllipsis.maxProgress)+"%", this.fontGUISkin.label);
	}
	
	IEnumerator LoadingOperation()
	{
		//While the counter hasn't reached 100
		while(counter <= 100)
		{
			//Print out the current progress, at the console
			Debug.Log("Progress:" + counter);
			//Update the progress of 'animatedEllipsisDet'
			this.animatedEllipsis.Animate(counter);
			//Make the code execution wait for 0.15 seconds
			yield return new WaitForSeconds(0.15f);
			//Increment counter
			++counter;
		}
	}
	
	
	//This method will be referenced by the 'animatedEllipsis' delegate
	public void DisplayMessageOnCompletion()
	{
		this.animatedEllipsis.text = "Done!";
	}
}
