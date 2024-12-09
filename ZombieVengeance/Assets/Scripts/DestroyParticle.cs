using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class DestroyParticle : MonoBehaviour
{
    private float delayTimer = 1;
	void Update ()
    {
        delayTimer -= Time.deltaTime;
        if(delayTimer<= 0)
        {
            Destroy(this.gameObject);
        }
	}
}