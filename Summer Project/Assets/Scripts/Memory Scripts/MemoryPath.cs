/* This is the class that will be used as a template to make the
 * memories and it dictates which memories will be stored depening
 * on the user input. */
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MemoryPath : MonoBehaviour {
	public string user; 	//who is the user that this memory belongs to
	private int memName; 	//the name of the memory
	public string[] who;	//who else was there
	public string time; 	//when the interrogative statement was made (game, scene, eventID)
	public string requester;//who made the interrogative statement
	public string statement;//the interrogative statement
	public string response; //the user's response
	public string[] whom; 	//who the information is about
	public bool visit = false; 		//was this memory visited
	public bool newMem;
	private MemoryMaker mem; 


    // Use this for initialization
	void Start () {
	}

	void Update () {
		if (visit == true) {
			visitCheck ();
		}

	}

	public void visitCheck(){
			mem.createMemory(user, who, time, requester, statement, response, whom); 	
	}
    
}