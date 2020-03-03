using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class time : MonoBehaviour {
   // public Data data;

    public float timer = 0f;

    private int h = 0;

    private int m = 0;

    private int s = 0;

    private string timeStr = string.Empty;

    public GUIStyle style;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1f)
        {
            s++;
            timer = 0;
        }
        if (s >= 60)
        {
            m++;
            s = 0;
        }
        if (m >= 60)
        {
            h++;
            m = 0;
        }
        if (h >= 99)
        {
            h = 0;
        }
        Data.timer = this.timer;
    }

    void OnGUI()
    {
        timeStr = string.Format("{0:D2}:{1:D2}:{2:D2}", h, m, s);
        GUI.skin.label = style;
        GUI.Label(new Rect(10, 10, 100, 200), timeStr);
    }

}
