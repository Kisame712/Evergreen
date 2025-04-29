using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaf : MonoBehaviour
{
    AudioSource leafAudio;
    public ParticleSystem eatEffect;

    void Start()
    {
        leafAudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            StartCoroutine(SoundThenDestroy());
        }
    }

    IEnumerator SoundThenDestroy()
    {
        leafAudio.Play();
        eatEffect.Play();
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
    }
}
