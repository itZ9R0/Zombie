using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Transform tr;
    Rigidbody rb;
    float ad;
    float ws;
    float w;
    Animator Anm;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();
        Anm = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        w = Input.GetAxis("Vertical");
        rb.velocity = tr.forward * w * 10f;
        if(w != 0){
            Anm.SetBool("isRun" , true);
        }else{
            Anm.SetBool("isRun",false);
        }
        if(Input.GetKeyDown( KeyCode.LeftControl)){
            Anm.SetBool("isDash", true);
        }else{
            Anm.SetBool("isDash", false);
        }
        if(Input.GetKeyDown( KeyCode.Space)){
            Anm.SetBool("isAttack", true);
        }else{
            Anm.SetBool("isAttack", false);
        }
        tr.Rotate(0,ad * 10f,0);
        
    }
    public void rot_player(float yRotate)
    {
        tr.rotation = Quaternion.Euler(0,yRotate ,0);
    }
}
