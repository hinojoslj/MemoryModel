using UnityEngine;
using System.Collections.Generic;

public class MemoryMaker : MonoBehaviour {
	public string user; //who is the user that this memory belongs to
	public string memName;
	public string[] who; //who else was there
	public string time; //when the interrogative statement was made (game, scene, eventID)
	public string requester; //who made the interrogative statement
	public string statement; //the interrogative statement
	public string response; //the user's response
	public string[] whom; //who the information is about
	public List<Memory> memList = new List<Memory>();
	private GameObject memoryList;
	//might change this soon (next line)
	private Memory mem; 

	// Use this for initialization
	void Start () {
		memoryList = GameObject.Find ("MemoryList");
		//might change this soon (next line)
		//createMemory(memName, who, time, requester, statement, response, whom);
		if (System.IO.File.Exists (@"C:\Users\hinoj_000\Documents\UTEP\ISG\Summer Project\Memory Model\File Memories\" + user + ".txt")) {
			Debug.Log ("File Exists! Updating file..");
			updateFile ();
			grabMemories ();
		} else {
			Debug.Log ("File does not exist! Creating file..");
			createFile ();
			grabMemories ();
		}
	}

	// Update is called once per frame
	void Update () {

	}

	//This will create a type object Memory by grabbing the values from Unity.
	public void createMemory(string chosenName, string[] chosenWho, string chosenTime, string chosenRequester, string chosenStatement, string chosenResponse, string[] chosenWhom){
		mem = new Memory(chosenName, chosenWho, chosenTime, chosenRequester, chosenStatement, chosenResponse, chosenWhom);
		Debug.Log("Memory was created!");
		memList.Add (mem);
	}

	//This method creates a file with the values from Unity.
	public void createFile(){

		using (System.IO.StreamWriter file = 
			new System.IO.StreamWriter(@"C:\Users\hinoj_000\Documents\UTEP\ISG\Summer Project\Memory Model\File Memories\" + user + ".txt"))
		{
			//file.Write ("Memory Name:");
			if(mem.getMemName() != ""){
				file.WriteLine(mem.getMemName());
			}else{
				//Ideally, this should never happen. 
				//If memoryName is null, have it fix it. 
				mem.setMemName("Memory1");
				file.WriteLine(mem.getMemName());
			}

			//file.Write ("Who: ");
			string[] temp = mem.getWho();
			for(int i = 0; i < temp.Length; i++){
				if(temp[i] != ""){
					if (i != temp.Length - 1) {
						file.Write (temp [i] + " ");
					} else {
						file.Write (temp [i]);
					}
				}
				else{
					file.WriteLine("null");
				}
			}
			file.WriteLine ();

			//file.Write (" Time: ");
			if(mem.getStatement() != ""){
				file.WriteLine(mem.getTime());
			}else{
				file.WriteLine("null");
			}

			//file.Write (" Requester: ");
			if(mem.getRequester() != null){
				file.WriteLine(mem.getRequester());
			}else{
				file.WriteLine("null");
			}

			//file.Write (" Statement: ");
			if(mem.getStatement() != ""){
				file.WriteLine(mem.getStatement());
			}else{
				file.WriteLine("null");
			}

			//file.Write (" Response: ");
			if(mem.getResponse() != ""){
				file.WriteLine(mem.getResponse());
			}else{
				file.WriteLine("null");
			}

			//file.Write (" Whom: ");
			temp = mem.getWhom ();
			for(int i = 0; i < temp.Length; i++){
				if(temp[i] != ""){
					if (i != temp.Length - 1) {
						file.Write (temp [i] + " ");
					} else {
						file.Write (temp [i]);
					}				}
				else{
					file.WriteLine("null");
				}
			}

		}
	}

	//This will write the memories continuing from the last memory.
	public void updateFile(){
		using (System.IO.StreamWriter file = new System.IO.StreamWriter (@"C:\Users\hinoj_000\Documents\UTEP\ISG\Summer Project\Memory Model\File Memories\" + user + ".txt", true)) {
			//file.Write ("update is working.");
		}

	}

	//This will grab the memories from the txt file and it will create the memory instances into Unity
	public void grabMemories(){

		int count = -1; 
		string line;
		System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\hinoj_000\Documents\UTEP\ISG\Summer Project\Memory Model\File Memories\" + user + ".txt");
		while ((line = file.ReadLine ()) != null) {
			if (line.Contains ("USER")) {
				//DO NOTHING
			} else if(line.Contains("Memory")){
				count = 1;
				//Put string into name
				memName = line;
				//memoryList.AddComponent<Memory>().GetComponent<Memory>().setMemName(memName);

				//memoryList.GetComponent<Memory> ().setMemName (memName);
				Debug.Log ("Line: " + line + " " + count);
			} else if (count == 2) {
				who = line.Split (' ');

				//memoryList.GetComponent<Memory> ().setWho (who);
				Debug.Log ("Line: " + line + " " + count);
			} else if (count == 3) {
				//put string into whom
				time = line;
				//memoryList.GetComponent<Memory> ().setTime (time);
				Debug.Log ("Line: " + line + " " + count);
			} else if (count == 4) {
				//put string into statement
				requester = line;
				//memoryList.GetComponent<Memory> ().setRequester (requester);
				Debug.Log ("Line: " + line + " " + count);
			} else if (count == 5) {
				statement = line;
				//memoryList.GetComponent<Memory> ().setStatement (statement);
				Debug.Log ("Line: " + line + " " + count);
			} else if (count == 6) {
				//put string into yadayada
				response = line;
				//memoryList.GetComponent<Memory> ().setResponse (response);
				Debug.Log ("Line: " + line + " " + count);
			} else if(count == 7) {
				//whom = line;
				whom = line.Split (' ');
				//memoryList.GetComponent<Memory> ().setWhom (whom);
				Debug.Log ("Line: " + line + " " + count);
				createMemory(memName, who, time, requester, statement, response, whom);
			}
			else if(line == null){
				Debug.Log ("Warning: Null encountered! Cross check txt file and memories..");
			}
			else{
				count = 0;
				Debug.Log("Count updated: " + count);
			}
			count++;
		}

		makeMemoryList ();
	}

	//This sets the memory fields inside the unity instances equal to the memory list. 
	public void makeMemoryList() {
		int listSize = memList.Count;
		Debug.Log ("List Size: " + listSize);
		for (int i = 0; i < listSize; i++) {
			memoryList.AddComponent<Memory> ();
		}
			

		Memory[] memArray = memoryList.GetComponents<Memory> ();
		int j = 0;
		foreach (Memory m in memList) {
			memArray [j].memName = m.getMemName();
			memArray [j].who = m.getWho();
			memArray [j].time = m.getTime();
			memArray [j].requester = m.getRequester();
			memArray [j].statement = m.getStatement();
			memArray [j].response = m.getResponse();
			memArray [j].whom = m.getWhom();
			j++;
		} 

	}
}
