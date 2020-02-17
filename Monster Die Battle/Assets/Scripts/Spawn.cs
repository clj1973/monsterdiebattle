using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	//Game prefab
	GameObject SmallMon;
	GameObject MedMon;
	GameObject LgMon;

	//Set health to zero
	int smonhealth = 0;
	int smoninthealth = 0;
	int mmonhealth = 0;
	int lmonhealth = 0;

	//Set Atack to zero
	int smonattack = 0;
	int mmonattack = 0;
	int lmonattack = 0;

	//Set health bonus to zero
	int smonhealthbonus = 0;
	int	smonattackbonus = 0;
	
	int mmonhealthbonus = 0;
	int	mmonattackbonus = 0;
	
	int lmonhealthbonus = 0;
	int	lmonattackbonus = 0;

	//Start spawn
	public void myspawn ()
	{
		print ("Spawn 1");
	}

	public void myspawnone ()
	{
		print ("Spawn 2");
	}


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
