using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelGenerator : MonoBehaviour
{
	public int currentLevelIndex;
	public GameObject moleculePrefab;
	public Text status;
    public Slider damage;
	void Start ()
	{
		Data.status = status;
        Data.damage = damage;
		Data.moleculePrefab = moleculePrefab;
		currentLevelIndex = Data.currentLevel;

		for (int i = 0; i < Data.levels [currentLevelIndex].molecules.Length; i++)
		{
			GameObject molecule = Instantiate (moleculePrefab, new Vector3(Random.Range(-9,9),Random.Range(-6,6),0), Quaternion.identity) as GameObject;
			if (i == 0)
			{
				molecule.transform.position = Vector3.zero;
			}
			molecule.transform.GetChild (0).GetComponent<TextMesh> ().text = Data.levels [currentLevelIndex].molecules[i].moleculeName;
			molecule.transform.GetChild (1).GetComponent<TextMesh> ().text = Data.levels [currentLevelIndex].molecules[i].moleculeCompound;
			molecule.GetComponent<MoleculeControl> ().mName= Data.levels[currentLevelIndex].molecules[i].moleculeName;
			molecule.GetComponent<Renderer> ().material.color = Data.levels [currentLevelIndex].molecules [i].moleculeColor;
			molecule.GetComponent<MoleculeControl> ().isEnzyme = Data.levels [currentLevelIndex].molecules [i].isEnyzme;
            molecule.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-3, 3), Random.Range(-3, 3)));
		}
	}

	void Update ()
	{
	}
}
