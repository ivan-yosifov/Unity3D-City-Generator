using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	public float nextTime = 0f;
	public float timer = 0.5f;
	public int counter = 10;
	public int minHeight = 1;
	public int maxHeight = 10;
	public float horizontalSpacing = 2f;
	public float verticalSpacing = 1f;
	
	// Update is called once per frame
	void Update () {
		if(counter > 0 && Time.fixedTime > nextTime){
			nextTime = Time.fixedTime + timer;
			
			for(int j = 10; j > 0; j--){
				int randomNumber = Random.Range (minHeight, maxHeight);
				for(int i = 0; i < randomNumber; i++){
					CustomBox cBox = new CustomBox();
					
					cBox.box.transform.position = new Vector3(counter * horizontalSpacing,
						i * verticalSpacing, j * horizontalSpacing);
					cBox.PickRandomColor();
				}
			}
			counter--;
		}
	}
	
	class CustomBox{
		public GameObject box = GameObject.CreatePrimitive(PrimitiveType.Cube);
		
		public void PickRandomColor(){
			box.GetComponent<Renderer>().material.color = 
				new Color((float)Random.Range (0.0f, 1.0f), (float)Random.Range (0.0f, 1.0f),
					(float)Random.Range (0.0f, 1.0f));
		}
	}
}
