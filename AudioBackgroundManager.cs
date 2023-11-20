
using UnityEngine;

public class AudioBackgroundManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
     [SerializeField] AudioSource SFXSource;

     public AudioClip Background;
    
    private void Start(){
        musicSource.clip = Background;
        musicSource.Play();
    }
}
