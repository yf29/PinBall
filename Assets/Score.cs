using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text Scoretext;
    private int score = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("SmallCloudTag"))
            {
            score += 10;
            Scoretext.text = string.Format("Score:{0}", score);
        }

        if (collision.gameObject.CompareTag("SmallStarTag"))
        {
            score += 10;
            Scoretext.text = string.Format("Score:{0}", score);
        }

        if (collision.gameObject.CompareTag("LargeCloudTag"))
        {
            score += 20;
            Scoretext.text = string.Format("Score:{0}", score);
        }



    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
