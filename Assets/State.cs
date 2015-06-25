using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

public class State : MonoBehaviour {

	public string GameSeed;

	// Use this for initialization
	void Start () {
		// load

		if (this.GameSeed == null) {
			this.GameSeed = string.Concat(RandomHexChar().Take(10));
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private string hexChars = "0123456789ABCDEF";
	private System.Random rand = new System.Random((int) (DateTime.Now.Ticks & Int32.MaxValue));

	IEnumerable<char> RandomHexChar()
	{
		while (true) {
			yield return hexChars[rand.Next(15)];
		}
	}
}
