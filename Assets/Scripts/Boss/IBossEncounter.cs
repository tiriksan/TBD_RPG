using UnityEngine;

public interface IBossEncounter
{
    void OnAreaEnter(Collider col);
    void OnAreaExit(Collider col);
}

