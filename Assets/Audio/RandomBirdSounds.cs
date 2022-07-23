using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBirdSounds : MonoBehaviour
{
    public AudioSource[] birdSquawks;
    AudioSource birdSquawk;
    int randomizer;
    int index;
    public Vector2 mapSize;

    private void FixedUpdate()
    {
        randomizer = Random.Range(1, 100);
        if (randomizer == 97)
        {
            index = Random.Range(0, birdSquawks.Length);
            birdSquawk = birdSquawks[index];
            birdSquawk.transform.position = new Vector3 ((Random.Range(-mapSize.x, mapSize.x)), (Random.Range(5, 35)), (Random.Range(-mapSize.y, mapSize.y)));
            birdSquawk.pitch = Random.Range(0.7f, 1.15f);
            birdSquawk.Play();
        }
    }

}
