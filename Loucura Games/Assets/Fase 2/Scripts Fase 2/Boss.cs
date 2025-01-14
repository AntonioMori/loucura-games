using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : Enemy 
{
    public GameObject boomerang;
    public float minBoomerangTime, maxBoomerangTime;

    // Start is called before the first frame update
    private void Awake()
    {
            Invoke("ThrowBoomerang", Random.Range(minBoomerangTime, maxBoomerangTime));

    }

    void ThrowBoomerang()
    {
        if (!isDead)
        {
            anim.SetTrigger("Boomerang");
            GameObject tempBoomerang = Instantiate(boomerang, transform.position, transform.rotation);
            if(facingRight)
            {
                tempBoomerang.GetComponent<Boomerang>().direction = 1;
            }
            else
            {
                tempBoomerang.GetComponent<Boomerang>().direction = -1;

            }
            Invoke("ThrowBoomerang", Random.Range(minBoomerangTime, maxBoomerangTime));
        }
    }

    void BossDefeated()
    {
        Invoke("LoadScene", 8f);
    }

    void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

