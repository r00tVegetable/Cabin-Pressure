using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectsMenager : MonoBehaviour
{
    [SerializeField] AudioSource bacgroundmusic;
    [SerializeField] AudioSource sleepmusic;
    [SerializeField] AudioSource pauseMusic;

    [SerializeField] GameObject sleeppanel;

   public void Sleep()
   {
        bacgroundmusic.Stop();
        sleepmusic.Play();
        sleeppanel.SetActive(true);
        StartCoroutine(EndCount());
        Cursor.visible = false;
    }

    IEnumerator EndCount()
    {
        yield return new WaitForSecondsRealtime(21f);
        Time.timeScale = 0f;
    }
}
