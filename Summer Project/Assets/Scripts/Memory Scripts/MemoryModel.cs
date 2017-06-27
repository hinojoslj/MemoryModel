/* This is the controller class of the memory model. */
using UnityEngine;
using System.Collections;
//using Agent;
//using Memory;

public class MemoryModel : MonoBehaviour {
    /* The only thing the Controller knows are the Agents */
    public Agent[] agent;
    
    // Use this for initialization
	void Start () {
	    //FIXME: do Unity stuffs here
	}
    
    /* Constructor */
    MemoryModel() {
        
    }
    
    /* Creates a new Memory to be added to the Agent (the who) */
    //NOTE: we will handle who knows in the Update method: add to each Agent's memory
    void addToMemory(string agent, string whom, string when, string requester, string response, string statement) {
        
    }
    
    /* Search for this statement in this Agent's memory, returns the Response */
    string getResponse(string agent, string statement) {
        //FIXME: tracking the user we are interacting with === more than 1
		string test = "Hello";
		return test;
    }
}