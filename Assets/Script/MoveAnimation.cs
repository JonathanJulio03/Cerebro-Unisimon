using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimation : MonoBehaviour {

	public GameObject parte;
	public float ejeXMax;
	public float ejeXMin;
	public float velocidad;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MoveA(){
		if (parte.transform.position.x > ejeXMin)
			parte.transform.Translate (new Vector3 (-Time.deltaTime*velocidad, 0,0));
	}

	public void MoveC(){
		if (parte.transform.position.x < ejeXMax)
			parte.transform.Translate (new Vector3 (Time.deltaTime*velocidad, 0,0));
	}

}
