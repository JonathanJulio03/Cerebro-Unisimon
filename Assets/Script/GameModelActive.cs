using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameModelActive : MonoBehaviour {

	public GameObject[] Activar;
	public GameObject[] DesActivar;

	public GameObject[] ButtonActivar;
	public GameObject[] ButtonDesactivar;
	// Use this for initialization
	void Start () {
		if (Activar != null) {
			foreach(GameObject objet in Activar)
			{
				foreach(Renderer ren in objet.GetComponentsInChildren<Renderer> ()){
					ren.enabled = false;
				}
				foreach(MeshCollider ren in objet.GetComponentsInChildren<MeshCollider> ()){
					ren.enabled = false;
				}
			}
		}
		if (DesActivar != null) {
			foreach(GameObject objet in DesActivar)
			{
				foreach(Renderer ren in objet.GetComponentsInChildren<Renderer> ()){
					ren.enabled = false;
				}
				foreach(MeshCollider ren in objet.GetComponentsInChildren<MeshCollider> ()){
					ren.enabled = false;
				}
			}
		}	
		/*if (ButtonActivar != null) {
			foreach(GameObject objet in ButtonActivar)
			{
				objet.SetActive (false);
			}
		}		
		if (ButtonDesactivar != null) {
			foreach(GameObject objet in ButtonDesactivar)
			{
				objet.SetActive (false);
			}
		}*/
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void PointerEnter()
	{	
		if (Activar != null) {
			foreach(GameObject objet in Activar)
			{
				foreach(Renderer ren in objet.GetComponentsInChildren<Renderer> ()){
					ren.enabled = true;
				}
				foreach(MeshCollider ren in objet.GetComponentsInChildren<MeshCollider> ()){
					ren.enabled = true;
				}
			}
		}	
		if (DesActivar != null) {
			foreach(GameObject objet in DesActivar)
			{
				foreach(Renderer ren in objet.GetComponentsInChildren<Renderer> ()){
					ren.enabled = false;
				}
				foreach(MeshCollider ren in objet.GetComponentsInChildren<MeshCollider> ()){
					ren.enabled = false;
				}
			}
		}
		if (ButtonActivar != null) {
			foreach(GameObject objet in ButtonActivar)
			{
				objet.SetActive (true);
			}
		}		
		if (ButtonDesactivar != null) {
			foreach(GameObject objet in ButtonDesactivar)
			{
				objet.SetActive (false);
			}
		}	
	}
}
