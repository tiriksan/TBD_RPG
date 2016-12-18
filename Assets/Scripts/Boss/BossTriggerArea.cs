using UnityEngine;

public class BossTriggerArea : MonoBehaviour {

    public IBossEncounter bossEncounter;

    private void OnTriggerEnter(Collider col)
    {
        bossEncounter.OnAreaEnter(col);
    }

    private void OnTriggerExit(Collider col)
    {
        bossEncounter.OnAreaExit(col);
    }
	
}
