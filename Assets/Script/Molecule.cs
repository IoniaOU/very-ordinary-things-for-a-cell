using UnityEngine;
using System.Collections;

public class Molecule
{
	public string moleculeName;
	public string moleculeCompound;
	public float moleculeSize;
	public Color moleculeColor;
	public bool isEnyzme;
	public Molecule(string _moleculeName, string _moleculeCompound, float _moleculeSize, Color _moleculeColor, bool _isEnyzme)
	{
		moleculeName = _moleculeName;
		moleculeCompound = _moleculeCompound;
		moleculeSize = _moleculeSize;
		moleculeColor = _moleculeColor;
		isEnyzme = _isEnyzme;
	}
}
