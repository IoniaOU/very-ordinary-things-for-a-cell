using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MoleculeControl : MonoBehaviour
{
	public string mName;
	public bool isEnzyme;
	public GameObject attachedEnzyme;

	void Start()
	{
	
	}

	void Update()
	{
	
	}


	void OnCollisionStay2D(Collision2D col)
	{
        Data.damage.value += 0.1f;
		if (col.gameObject.GetComponent<MoleculeControl>().isEnzyme)
		{
			if (attachedEnzyme == null)
			{
				attachedEnzyme = col.gameObject;
			}
		}
		if (attachedEnzyme != null)
		{
			if (col.gameObject.tag == "Molecule")
			{
				for (int i = 0; i < Data.reactions.Length; i++)
				{
					if (Data.reactions[i].inputB != null)
					{
						if ((Data.reactions[i].inputA.moleculeName.Equals(mName)) && (Data.reactions[i].inputB.moleculeName.Equals(col.gameObject.GetComponent<MoleculeControl>().mName)))
						{
							if (Data.reactions[i].enzyme.moleculeName.Equals(attachedEnzyme.GetComponent<MoleculeControl>().mName))
							{
								GameObject molecule = Instantiate(Data.moleculePrefab, col.transform.position, Quaternion.identity) as GameObject;
								molecule.transform.GetChild(0).GetComponent<TextMesh>().text = Data.reactions[i].Output.moleculeName;
								molecule.transform.GetChild(1).GetComponent<TextMesh>().text = Data.reactions[i].Output.moleculeCompound;
								molecule.GetComponent<MoleculeControl>().mName = Data.reactions[i].Output.moleculeName;
								molecule.GetComponent<Renderer>().material.color = Data.reactions[i].Output.moleculeColor;
								for (int j = 0; j < Data.reactions[i].Waste.Length; j++)
								{
									GameObject wasteMolecule = Instantiate(Data.moleculePrefab, col.transform.position, Quaternion.identity) as GameObject;
									wasteMolecule.tag = "Waste";
									wasteMolecule.transform.localScale *= Data.reactions[i].Waste[j].moleculeSize;
									wasteMolecule.transform.GetChild(0).GetComponent<TextMesh>().text = Data.reactions[i].Waste[j].moleculeName;
									wasteMolecule.transform.GetChild(1).GetComponent<TextMesh>().text = Data.reactions[i].Waste[j].moleculeCompound;
									wasteMolecule.GetComponent<MoleculeControl>().mName = Data.reactions[i].Waste[j].moleculeName;
									wasteMolecule.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-10, 10), Random.Range(-10, 10)));
									wasteMolecule.GetComponent<Renderer>().material.color = Data.reactions[i].Waste[j].moleculeColor;
								}
								Data.status.text = Data.reactions[i].reactionName;
								attachedEnzyme.GetComponent<Renderer>().material.color = Color.magenta;
								attachedEnzyme.tag = "Waste";
								Destroy(gameObject);
								Destroy(col.gameObject);
							}
						}
					}
					else
					{
						if ((Data.reactions[i].inputA.moleculeName.Equals(mName)))
						{
							if (Data.reactions[i].enzyme.moleculeName.Equals(attachedEnzyme.GetComponent<MoleculeControl>().mName))
							{
								GameObject molecule = Instantiate(Data.moleculePrefab, col.transform.position, Quaternion.identity) as GameObject;
								molecule.transform.GetChild(0).GetComponent<TextMesh>().text = Data.reactions[i].Output.moleculeName;
								molecule.transform.GetChild(1).GetComponent<TextMesh>().text = Data.reactions[i].Output.moleculeCompound;
								molecule.GetComponent<MoleculeControl>().mName = Data.reactions[i].Output.moleculeName;
								molecule.GetComponent<Renderer>().material.color = Data.reactions[i].Output.moleculeColor;
								for (int j = 0; j < Data.reactions[i].Waste.Length; j++)
								{
									GameObject wasteMolecule = Instantiate(Data.moleculePrefab, col.transform.position, Quaternion.identity) as GameObject;
									wasteMolecule.tag = "Waste";
									wasteMolecule.transform.localScale *= Data.reactions[i].Waste[j].moleculeSize;
									wasteMolecule.transform.GetChild(0).GetComponent<TextMesh>().text = Data.reactions[i].Waste[j].moleculeName;
									wasteMolecule.transform.GetChild(1).GetComponent<TextMesh>().text = Data.reactions[i].Waste[j].moleculeCompound;
									wasteMolecule.GetComponent<MoleculeControl>().mName = Data.reactions[i].Waste[j].moleculeName;
									wasteMolecule.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-10, 10), Random.Range(-10, 10)));
									wasteMolecule.GetComponent<Renderer>().material.color = Data.reactions[i].Waste[j].moleculeColor;
								}
								Data.status.text = Data.reactions[i].reactionName;
								attachedEnzyme.GetComponent<Renderer>().material.color = Color.magenta;
								attachedEnzyme.tag = "Waste";
								Destroy(gameObject);
							}

						}
					}
				}
			}
		}
	}

	void OnCollisionExit2D(Collision2D col)
	{
		if (col.gameObject.Equals(attachedEnzyme))
		{
			attachedEnzyme = null;
		}
	}
		
}
