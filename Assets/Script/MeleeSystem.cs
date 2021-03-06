﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeSystem : MonoBehaviour {
    public static bool clicked = false;
    private PigController  Pigscript;
    private TreeController Treescript;
    private StoneController Stonescript;
    public static int power = 5;
    // Use this for initialization
    private GameObject target;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter (Collider other)
    {
        if (clicked)
        {
            Debug.Log("Clicked");
            target = other.gameObject;
            ApplyDamage(target);
            Debug.Log(target);
            clicked = false;
        
        }
    }

    void ApplyDamage(GameObject other)
    {
        if (other.tag == "PigTag")
        {
            
            Pigscript = (PigController)other.GetComponent(typeof(PigController));
            Pigscript.HpController(power);

        }

        if (other.tag == "TreeTag")
        {
            
            Treescript = (TreeController)other.GetComponent(typeof(TreeController));
            Treescript.HpController(power);
        }
        if (other.tag == "StoneTag")
        {

            Stonescript = (StoneController)other.GetComponent(typeof(StoneController));
            Stonescript.HpController(power);
        }

    }
}
