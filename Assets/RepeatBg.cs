using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBg : MonoBehaviour
{
    Material bgmat;
    public float offsetvalue;
    PlayerMovement pm;
    // Start is called before the first frame update
    void Start()
    {
        bgmat = GetComponent<MeshRenderer>().material;
        pm = GetComponent<PlayerMovement>();
    }
    
    // Update is called once per frame
    private void FixedUpdate()
    {
       
        bgmat.mainTextureOffset = new Vector2(offsetvalue * Time.time, 0);
    }


}
