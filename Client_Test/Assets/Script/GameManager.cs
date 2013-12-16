using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject _Card;

	public int _MaxHP;

	public GUIText _Player1_HP;
	public GUIText _Player1_Name;
	public GUIText _Player2_HP;
	public GUIText _Player2_Name;

	private int player1HP;
	private int player2HP;

	private GameObject textu;
	private Texture tt;

	private GameObject[] Cards_Me = new GameObject[30];
	private GameObject[] Cards_You = new GameObject[30];
	private GameObject uiLabel;

	void Awake () {
		// Texture avatarTexture = GameObject.Find("Me_Avatar").GetComponent("Texture") as Texture;
		// GameObject gameobj = GameObject.Find ("Me_Avatar");
		// (Texture2D)Resources.Load("02_Resource/03_UI/Avatar");
		// Texture textu = GetComponent("Me_Avatar") as Texture;
		// GameObject textu = GetComponent("Me_Avatar") as GameObject;

		textu = GameObject.Find ("Me_Avatar");
		//tt = Resources.Load("Avatar1") as Texture;

		textu.renderer.material.SetTexture ("_MainTex", Resources.Load ("Image/Avatar1") as Texture);
		//textu.GetComponent<Texture>().

		_Player1_HP.text = (_MaxHP + 1).ToString ();
		_Player2_HP.text = (_MaxHP - 1).ToString ();
		_Player1_Name.text = "장석일";
		_Player2_Name.text = "데이빗장";

		player1HP = _MaxHP;
		player2HP = _MaxHP;

		SpawnObject ();
	}


	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void SpawnObject()
	{


		for(int i = 0; i < 1; i++)
		{

			Cards_Me[i] = Instantiate(_Card, new Vector3(-4f, 0f, 0.8f +(-0.02f * i)), Quaternion.Euler(new Vector3(0f, 180f, 0f))) as GameObject;
			Cards_You[i] = Instantiate(_Card, new Vector3(4f, 0f, 0.8f +(-0.02f * i)), Quaternion.Euler(new Vector3(0f, 180f, 0f))) as GameObject;

			// Card Object - Initiallize here
			Cards_Me[i].transform.localScale += new Vector3(-0.5f, -0.5f, 0); // 축소
//			Cards_Me[i].transform.localScale += new Vector3(0.5f, 0.5f, 0); // 확대


//			Cards_Me[i].transform.FindChild("Card_TextAttack").GetComponentInChildren<UILabel>();
			Debug.Log("SpawnObject OK");

		}
	}
}
