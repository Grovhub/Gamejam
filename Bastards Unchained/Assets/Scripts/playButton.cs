﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void play()
	{
		SceneManager.LoadScene("SampleScene");
		print("tobias");
	}
}
