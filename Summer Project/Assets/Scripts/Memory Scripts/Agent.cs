/* This is the Agent class of the memory model. */
using UnityEngine;
//using Memory;

public class Agent : MonoBehaviour{
    /* The only thing the Agent knows is the memory it is using*/
    //The memory will be: each row for each user, each column for their memories
    public Memory[] memory; //FIXME: these should be dynamically changed
    public string name;
    
    /* Constructor */
    Agent(string s) {
        name = s;
    }
    
    /* Create a new memory for a new User */
    void addUser(string name) {
        
    }
    
    /* Load the memory for a User previously encountered by this Agent, this is
        where we import from the user's file into the Memory array */
    bool loadUser(string name) {
		return false;
    }
    
    /* Adds to this Agent's memory for the current user */
   	void addToMemory(Memory d) {
        
    }
}