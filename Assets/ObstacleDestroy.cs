using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleDestroy : MonoBehaviour
{
   
    Animator animator;
    //RepeatBg v;
    //RepeatBg u;
    //RepeatBg t;
    GameObject[] q1;
    //RepeatBg rbg;
    ObstacleSpawn os;
    int i;
    //ObstacleSpawn os;
    private void Start()
    {
        animator = GetComponent<Animator>();
        q1 = GameObject.FindGameObjectsWithTag("Game");  
        //rbg = GameObject.FindGameObjectsWithTag("Ground").
        //v=GameObject.Find("Background").GetComponent<RepeatBg>();
        //u = GameObject.Find("Ground").GetComponent<RepeatBg>();
        //t = GameObject.Find("Bottom").GetComponent<RepeatBg>();
        os = GameObject.Find("ObstacleSpawn").GetComponent<ObstacleSpawn>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            //Destroy(this.gameObject);
            animator.SetTrigger("Dead");
            //v.offsetvalue = 0;
            //u.offsetvalue = 0;
            //t.offsetvalue = 0;
            os.CancelInvoke("spawn");
            //animator.transform.position = transform.position;
            //animator.enabled = false;
            for (i = 0; i < q1.Length; i++)
            {
                q1[i].GetComponent<RepeatBg>().offsetvalue = 0;
            }
            //SceneManager.LoadScene(1);
        }
    }

}
