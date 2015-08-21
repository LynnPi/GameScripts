using UnityEngine; //41 Post - Created by DimasTheDriver on March/13/2013 . Part of the 'Unity: animated Ellipsis' post. Available at: http://www.41post.com/?p=5130
using System.Collections;

public class FakeLoadingOperationIndeterminate : MonoBehaviour 
{
	private AnimatedEllipsis animatedEllipsis;
	public GUISkin fontGUISkin;
	
	// Use this for initialization
	void Start () 
	{
		//Initialize the animatedEllipsis. 
		this.animatedEllipsis = this.GetComponent<AnimatedEllipsis>();
		
		//Initialize the delegate
		this.animatedEllipsis.onCompletion = DisplayMessageOnCompletion;
		
		//Start the animation of the indeterminated animated ellipsis
		this.animatedEllipsis.Animate(1f);
	}
	
	void OnGUI() 
	{
		GUI.Label(new Rect(100,100,1000,300), this.animatedEllipsis.text, this.fontGUISkin.label);
		if(!this.animatedEllipsis.isCompleted)
		{
			if(GUI.Button(new Rect(1100,150,300,70), "this.animatedEllipsis.isCompleted = true"))
			{
				this.animatedEllipsis.isCompleted = true;
			}
		}
	}
	
	//This method will be referenced by the 'animatedEllipsis' delegate
	public void DisplayMessageOnCompletion()
	{
		this.animatedEllipsis.text = "Completed!";
	}
}
