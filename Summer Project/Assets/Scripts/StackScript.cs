using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StackScript : MonoBehaviour {

	public Stack<InputInfo> ob = new Stack<InputInfo>();
    public InputInfo[] allInfo;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < allInfo.Length; i++)
        {
			Debug.Log(allInfo[i].agent + " pushed!");
            ob.Push(allInfo[i]);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
