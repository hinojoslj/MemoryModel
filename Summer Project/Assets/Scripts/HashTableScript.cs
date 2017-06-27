using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HashTableScript : MonoBehaviour {
	public InputInfo[] memory;
	Dictionary<int, InputInfo> memories = new Dictionary<int, InputInfo>();

	// Use this for initialization
	void Start () {
/*		for(int i = 0; i < memory.Length; i++){
			memory = GameObject.FindGameObjectsWithTag ("Memory").GetComponent<InputInfo> ();
			memories.Add (i, memory[i]);
		}
		*/
	}
}
