﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour {
    public float lifeTime = 0.8f;
	void Start () {
        Destroy(this.gameObject, lifeTime);
	}
	
	
}
