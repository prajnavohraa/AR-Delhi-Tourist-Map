using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioClip[] aClips;
    public AudioSource myAudioSource;
    string monumentName;

    // Start is called before the first frame update
    void Start()
    {
        myAudioSource=GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount>0 && Input.touches[0].phase==TouchPhase.Began){
            Ray ray= Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if(Physics.Raycast(ray, out Hit)){
                monumentName=Hit.transform.name;
                switch(monumentName){
                    case "IndiaGate":
                        myAudioSource.clip=aClips[0];
                        myAudioSource.Play();
                        break;
                    case "LotusTemple":
                        myAudioSource.clip=aClips[1];
                        myAudioSource.Play();
                        break;
                    case "redfort":
                        myAudioSource.clip=aClips[2];
                        myAudioSource.Play();
                        break;
                    case "nationalMuseum":
                        myAudioSource.clip=aClips[3];
                        myAudioSource.Play();
                        break;
                    case "Akshardham":
                        myAudioSource.clip=aClips[4];
                        myAudioSource.Play();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
