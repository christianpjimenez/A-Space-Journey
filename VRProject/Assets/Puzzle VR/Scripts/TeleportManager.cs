using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeleportManager : MonoBehaviour
{
	#region Singleton

	private static TeleportManager instance;
	public static TeleportManager Instance
	{
		get
		{
			if (instance == null)
			{
				instance = new TeleportManager ();
			}
			return instance;
		}
	}

	#endregion

	public Image Fading;
	[Range (0f, 1f)] public float time = 0.5f;
	public Transform player;
	float positionInitial;

	private void Awake ()
	{
		if (instance == null)
		{
			instance = this;
		}
		else
		{
			Destroy (gameObject);
		}
	}

	private void Start ()
	{
        positionInitial = player.position.y;
		Fade (true);
	}

	public void Fade (bool isFadeIn)
	{
		if (isFadeIn) Fading.CrossFadeAlpha (0, time, true);
		else Fading.CrossFadeAlpha (1, time, true);
	}

	public void Teleport (Vector3 _newPos)
	{
		StartCoroutine ("MovePosition", _newPos);
	}

	IEnumerator MovePosition (Vector3 newPos)
	{
		Fade (false);
		yield return new WaitForSeconds (time);
		player.position = new Vector3 (newPos.x, newPos.y + positionInitial, newPos.z);
		yield return new WaitForSeconds (time);
		Fade (true);
	}

}