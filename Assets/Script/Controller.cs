using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour
{
	public float translationX;
	public float translationY;
	public bool carry;
	public bool full;
	public bool isThereEnzyme;
    private bool sfxReady = true;

	void Start () {

	}

	void Update ()
	{
		translationX = Input.GetAxis("Horizontal")*0.25f;
		translationY = Input.GetAxis("Vertical")*0.25f;
		carry = Input.GetButton ("Jump");
        if (carry&&sfxReady&&!gameObject.GetComponent<AudioSource>().isPlaying)
        {
            gameObject.GetComponent<AudioSource>().Play();
            sfxReady = false;
        }
        if (!carry)
        {
            sfxReady = true;
        }
	}

	void FixedUpdate()
	{
		transform.Translate(translationX, translationY, 0);
		if (carry)
		{
			gameObject.transform.localScale = Vector3.Lerp (gameObject.transform.localScale, new Vector3 (2, 2, 2), 0.2f);
		}
		else
		{
			isThereEnzyme = false;
			if (!gameObject.transform.localScale.Equals (new Vector3 (1, 1, 1)))
			{
				gameObject.transform.localScale = Vector3.Lerp (gameObject.transform.localScale, new Vector3 (1, 1, 1), 0.2f);
			}
		}
	}

	void OnTriggerStay2D(Collider2D other)
	{
		if (carry&&other.gameObject.tag.Equals("Molecule")&&!other.gameObject.GetComponent<MoleculeControl>().isEnzyme)
		{
			other.gameObject.transform.position = Vector3.Lerp(other.gameObject.transform.position,gameObject.transform.position+new Vector3(0,0,0.15f),0.4f);
		}
		else if(carry&&other.gameObject.tag.Equals("Molecule")&&other.gameObject.GetComponent<MoleculeControl>().isEnzyme&&!isThereEnzyme)
		{
			other.gameObject.transform.position = Vector3.Lerp(other.gameObject.transform.position,gameObject.transform.position+new Vector3(0,0,0.15f),0.4f);
		}
	}
}
