/* This is the Memory class of the memory model. */
using UnityEngine;
using System.Collections.Generic;

public class Memory : MonoBehaviour{
    /* The Memory knows are the who, whom, when, requester, response, and statement */
    public string memName; //name of the memory
    public string[] who; //who else was there
    public string time; //when the interrogative statement was made (game, scene, eventID)
    public string requester; //who made the interrogative statement
    public string statement; //the interrogative statement
    public string response; //the user's response
    public string[] whom; //who the information is about

    /* Constructor: Memory has other Agent(s)/User(s) we know of */
	public Memory(string n, string[] w, string t, string req, string s, string res, string[] m) 
	{
	    memName = n;
        who = w;
        time = t;
        requester = req;
        statement = s;
        response = res;
        whom = m;
    }
    
    //Setters
    public void setMemName(string chosenMemName)
    {
        memName = chosenMemName;
    }
    
	public void setWho(string[] chosenWho) 
	{
		who = chosenWho;
	}

	public void setTime(string chosenTime) 
	{
		time = chosenTime;
	}

	public void setRequester(string chosenRequester) 
	{
		requester = chosenRequester;
	}

	public void setStatement(string chosenStatement) 
	{
		statement = chosenStatement;
	}

	public void setResponse(string chosenResponse) 
	{
		response = chosenResponse;
	}
	
	public void setWhom(string[] chosenWhom) 
	{
		whom = chosenWhom;
	}

    //Getters
    public string getMemName()
    {
        return memName;    
    }
    
	public string[] getWho() 
	{
		return who;
	}

	public string getTime() 
	{
		return time;
	}

	public string getRequester() 
	{
		return requester;
	}

	public string getStatement() 
	{
		return statement;
	}

	public string getResponse() {
	
		return response;
	}
	
	public string[] getWhom() 
	{
		return whom;
	}

	public Memory getMemory()
	{
		return this;
	}
	
	//prints all memory information
	public void printMemory() 
	{
	    string tempPrint;
	    tempPrint = "\nMEMNAME: " + testString(memName);
	    tempPrint += "\nWHO: " + testStringArray(who);
	    tempPrint += "\nTIME: " + testString(time);
	    tempPrint += "\nREQUESTER: " + testString(requester);
	    tempPrint += "\nSTATEMENT: " + testString(statement);
		tempPrint += "\nRESPONSE: " + testString (response);
	    tempPrint +="\nWHOM: " + testStringArray(whom);
		Debug.Log (tempPrint);
	}

    public string testStringArray(string[] sArray)
    {
        string tempStr = "";
        if (sArray.Length > 0)
        {
            foreach (string s in sArray)
            {
                tempStr += s + " ";
            }
            return tempStr;
        }
        return "string array is empty";
    }
    
    public string testString(string s)
    {
        if (s.Length > 0) 
        {
            return s;
        }
        return "string is empty";
    }
	

    /* Getters and Setters for this instance of Memory */
    //FIXME: y'all can implement these
}