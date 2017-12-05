using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[Serializable]
public class UI {

	[Serializable]
	public class HUD
	{
		[Header("Text")]
		public Text txtCoinCount;
		public Text txtLifeCount;
		public Text txtTimer;

		[Header("Other")]
		public GameObject hudPanel;
	}
	public HUD hud;
}
