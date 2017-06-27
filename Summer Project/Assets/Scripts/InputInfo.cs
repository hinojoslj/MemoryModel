using UnityEngine;
using System.Collections;

public class InputInfo : MonoBehaviour {
	public string agent;
    public string category;
	public string whom;
	public bool ans;
    public float ansNum;

    public InputInfo() {
    }

	public InputInfo(string chosenAgent, string chosenCategory, string chosenWhom, bool chosenAns, float chosenNum) {
		agent = chosenAgent;
		category = chosenCategory;
		whom = chosenWhom;
        ans = chosenAns;
        ansNum = chosenNum;
    }
}
