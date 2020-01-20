using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

	//ボールが見える可能性のあるz軸の最大値
	private float visiblePosZ = -6.5f;

	//ゲームオーバを表示するテキスト
	private GameObject gameoverText;
	public GameObject ScoreText;
	public int score=0;



	// Use this for initialization
	void Start () {
		
		//シーン中のGameOverTextオブジェクトを取得
		this.gameoverText = GameObject.Find("GameOverText");
		this.ScoreText = GameObject.Find ("ScoreText");
	}

	// Update is called once per frame
	void Update () {
		//ボールが画面外に出た場合
		if (this.transform.position.z < this.visiblePosZ) {
			//GameoverTextにゲームオーバを表示
			this.gameoverText.GetComponent<Text> ().text = "Game Over";
			string scoretext = score.ToString ();
			this.ScoreText.GetComponent<Text> ().text = "あなたのスコア:"+scoretext;
		}
	}
	void OnCollisionEnter (Collision collision)
	{
		string yourtag = collision.gameObject.tag;
		if (yourtag == " LargeCloudTag") {
			score += 30;
		} else if (yourtag == "SmallCloudTag") {
			score += 20;
		} else if (yourtag == "LargeStarTag") {
			score += 30;
		} else if (yourtag == "SmallStarTag") {
			score += 5;
		}
	}

}






			
