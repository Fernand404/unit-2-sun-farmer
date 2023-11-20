using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int health = 100;
    private int MAX_HEALTH = 100;
   
 
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Damage(10);
        }
    }

    public void Damage(int amount)
    {
        if(amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("cannot have negative damage");
        }
        this.health -= amount;
        
        if(health <= 0)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        if(amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative heal");
        }

        bool wouldBeOverMaxHealth = health + amount > MAX_HEALTH;
        if(wouldBeOverMaxHealth)
        {
            this.health = MAX_HEALTH;
        }
        else
        {
        this.health += amount;
        }
    }

    private void Die()
    {
        Debug.Log("i am dead");
        Destroy(gameObject); 
    }
}
