using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMng : MonoBehaviour {
		public Text ScoreTextGUI; //Text用変数
		private int score = 0; //スコア計算用変数

		void Start()
		{
			score   = 0;
			SetScore();   //初期スコアを代入して表示
		}

		void OnCollisionEnter( Collision collision )
	{
		string yourTag = collision.gameObject.tag;

		if (yourTag == "SmallStarTag") {
			score += 20;
		} else if (yourTag == "SmallCloudTag") {
			score += 50;
		} else if (yourTag == "LargeCloudTag") {
			score += 10;
		}
		else {
			score += 5;
	}
			SetScore();
		}

		void SetScore()
		{
//			ScoreTextGUI.text = string.Format(score);
		ScoreTextGUI.text = score.ToString ();
		}
	}
