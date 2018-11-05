using UnityEngine;
using System.Collections;

public class TouchMng : MonoBehaviour {
	
		void Start()
		{
			if (Input.touchSupported) {
				print("タッチ入力に対応している");
			}
		}
	}