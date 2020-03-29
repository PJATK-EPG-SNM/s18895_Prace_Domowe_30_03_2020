using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public new string name;
    public int damage;
    public int maxHealth = 5;
    public int currentHealth { get; private set; }
    public Animator animator;
    public BoxCollider2D dmg;
    public PlayerController pc;
    public string getName()
    {
        return name;
    }
    public void setName(string nm)
    {
        name = nm;
    }
    void Awake()
    {
        //UnityEngine.SceneManagement.SceneManager.LoadScene("LevelOne");
        currentHealth = 3;
        StartCoroutine(Odliczanie());

    }
    void Update()
    {
            if (Time.timeScale == 0)
        {
            if (Input.GetKeyDown("space"))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag =="Obstacles")
        {
            TakeDamage(1);
            StartCoroutine(Animacja());
        }
        if (collision.collider.tag == "Villagers")
        {
            TakeDamage(maxHealth);
        }
    }
    IEnumerator Odliczanie()
    {
        Time.timeScale = 0;
       // UnityEngine.SceneManagement.SceneManager.LoadScene("Countdown");
        yield return new WaitForSecondsRealtime(5);
        Time.timeScale = 1;
    }
    IEnumerator Animacja()
    {
        dmg.enabled = false;
        animator.SetBool("IsCollision", true);
        pc.moveSpeed -= 10f;
        yield return new WaitForSeconds(2);
        dmg.enabled = true;
        animator.SetBool("IsCollision", false);
        pc.moveSpeed += 10f;
    }

    public void TakeDamage(int damage)
    {
        name = "Bear";
        currentHealth -= damage;
        if (currentHealth > 0)
        {
            Debug.Log(name + " takes " + damage + " points of damage.\nYou have " + currentHealth + " points of health.");
        }
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    public virtual void Die()
    {
        Debug.Log("Oh, " + name + " been hunted.\nYou should be more careful next time!");
        Time.timeScale = 0;
        print("Press 'space' key to reload the game...");
    }
}
