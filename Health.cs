using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public Image healthBar;
    public float healthAmt = 100;
    //public float damage = 50;

    private void Update(){
       if(healthAmt <= 0){
            Debug.Log("You win/Lose"); 
            SceneManager.LoadScene("Win screen");
            //Time.timeScale = 0;

        }
        if(Input.GetKeyDown(KeyCode.W)){
            SceneManager.LoadScene("Win screen");
        }
        //these are test functions
        if(Input.GetKeyDown(KeyCode.E)){
            TakeDamage(20);
        }
        if(Input.GetKeyDown(KeyCode.T)){
            Healing(10);
        }
        if(Input.GetKeyDown(KeyCode.P)){
            Debug.Log("P pressed");
            Time.timeScale = 0;
        }
        if(Input.GetKeyDown(KeyCode.R)){
            Debug.Log("R pressed");
            SceneManager.LoadScene("SampleScene");
        }
        }
        void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "Player"){
            Debug.Log("Yes");
            TakeDamage(25);
        }
        if(col.gameObject.tag == "Enemy"){
            Debug.Log("Oh");
            TakeDamage  (10);
        }
    
        }
    

    public void TakeDamage(float Damage){
        healthAmt -= Damage;
        healthBar.fillAmount = healthAmt / 100;
    }
    public void Healing(float healPoints){
        healthAmt += healPoints;
        healthAmt = Mathf.Clamp(healthAmt, 0, 100);

        healthBar.fillAmount = healthAmt / 100;
    }
}

