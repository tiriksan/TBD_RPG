using UnityEngine;
using System;

public class BossEncounter : MonoBehaviour, IBossEncounter {

    void Start () {
	
	}
	
	void Update () {
	
	}

    public void OnAreaEnter(Collider col)
    {
        AddPlayerToEncounter(col.GetComponent<PlayerStats>());
    }

    public void OnAreaExit(Collider col)
    {
        
    }

    private void AddPlayerToEncounter(PlayerStats player)
    {

    }
}
