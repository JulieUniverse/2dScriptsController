using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poop : MonoBehaviour {

    public CircleCollider2D stinkRadius;
    public BoxCollider2D poopCollider;
    public GameMaster gm;
    private GameObject poop;


    void Awake()
    {
        gm = FindObjectOfType<GameMaster>();
        poop = GameObject.FindWithTag("Poop");
    }
    void FixedUpdate()
    {
        SelfDestruct();
    }
    public void SelfDestruct()
    {
        if(gm.death == true)
        GameObject.Destroy(poop);
    }
}
