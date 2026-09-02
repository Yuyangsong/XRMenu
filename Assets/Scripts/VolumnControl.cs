using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumnControl : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider volumnSlider;
    public void SetVolumn(float volumn)
    {
        audioMixer.SetFloat("MasterVolumn", volumn);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float volumn;
        if (audioMixer.GetFloat("MasterVolumn", out volumn))
        {
            volumnSlider.value = volumn;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
