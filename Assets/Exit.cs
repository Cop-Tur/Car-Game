using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour {
  //  public Data data;
    private float timer1=0f;
    public bool isend = false;
    public bool isfinish = false;
	// Use this for initialization
	void Start () {
        
    }

    // Update is called once per frame
    void Update () {
        if (isend)
        {
            
            timer1 += Time.deltaTime;
            if (timer1 > 1f)
            {
                //MessageBox.Show("游戏结束");
                // UnityEditor.EditorApplication.isPlaying = false;
                //UnityEngine.Application.Quit();
                Data.isfinish = this.isfinish;
                SceneManager.LoadScene("End");
                isend = false;
            }
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "endgate")
        {
            isend = true;
            isfinish = true;
            //MessageBox.Show("游戏结束");
            //UnityEditor.EditorApplication.isPlaying = false;
            //UnityEngine.Application.Quit();
        }
        if (collision.gameObject.tag == "UnFinish")
        {
            isend = true;
            isfinish = false;
        }

    }

   // private void OnCollisionExit(Collision collision)
   // {
    //    if (collision.gameObject.tag == "track")
    //    {
     //       isfinish = true;
    //    }
  //  }
}
