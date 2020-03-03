using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using UnityEngine;

public class SpeedUp : MonoBehaviour {

    //public GameObject speedup;
    private float timer = 0f;
    public Move move;
    public bool spable = false;
    public bool issp = false;
	// Use this for initialization
	void Start () {
        GameObject.FindGameObjectWithTag("fire").GetComponent<ParticleSystem>().Stop();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.K))
        {
            if (spable)
            {       
                move.speedUp = 0.15f;
                spable = false;
                issp = true;
                GameObject.FindGameObjectWithTag("fire").GetComponent<ParticleSystem>().Play();
            }
           // else
            //{
            //    move.speedUp = 0f;
             //   GameObject.FindGameObjectWithTag("fire").GetComponent<ParticleSystem>().Stop();               
            //}
        }
        //else
        //{
        // move.speedUp = 0f;
        // GameObject.FindGameObjectWithTag("fire").GetComponent<ParticleSystem>().Stop();
        // }
        if (issp)
        {
            timer += Time.deltaTime;
            if (timer > 5f)
            {
                GameObject.FindGameObjectWithTag("fire").GetComponent<ParticleSystem>().Stop();
                move.speedUp = 0f;
                timer = 0f;
                issp = false;
            }
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SpeedUp")
        {
            spable = true;
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            //UnityEditor.EditorApplication.isPlaying = false;
            //MessageBox.Show("游戏结束");
            //GameObject.Destroy(speedup);
        }
       
    }

    
}
