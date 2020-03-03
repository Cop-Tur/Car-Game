using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour {

    public static bool isfinish;
    public static float timer;

    private void Awake()
    {
        isfinish = true;
        timer = 0f;
    }
    // Use this for initialization
    void Start () {
        GameObject.DontDestroyOnLoad(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
