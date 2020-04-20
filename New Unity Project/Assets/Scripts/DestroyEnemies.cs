using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemies : MonoBehaviour
{

    bool canAttack = true;

    void Start(){
        Debug.Log("We're STARTING!");
    }

    void Update(){
        if (Input.GetKey(KeyCode.F)){
            if(canAttack){
                canAttack = false;
                StartCoroutine(Attack());
            }
		}
    }

    void OnCollisionEnter(Collision col){

        if(col.gameObject.tag == "Enemy"){
            Destroy(col.gameObject);
        }
    }

    IEnumerator Attack(){

        while(transform.rotation.eulerAngles.z < 65){
            transform.Rotate(0f,0f,1f);
            yield return null;
        }
        while(transform.rotation.eulerAngles.z > 0){
            transform.Rotate(0f,0f,-1f);
            yield return null;
        }
        while(transform.rotation.eulerAngles.z < 45){
            transform.Rotate(0f,0f,1f);
            yield return null;
        }
        canAttack = true;
    }

}
