<<<<<<< HEAD:Scripts/Behaviours/Trigger.cs
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
	public FloatBase Data;
	public FunctionBase Work;
	
	private void OnTriggerEnter(Collider other)
	{
		Work.Run(Data);
	}
=======
﻿using UnityEngine;
using UnityEngine.UI;

public class HealthBehaviour : MonoBehaviour
{
    public GameAction HealthAction;
    public Image HealthBarImage;


    private void Start()
    {
        HealthAction.Call(HealthBarImage);
    }
>>>>>>> master:Scripts/HealthBehaviour.cs
}