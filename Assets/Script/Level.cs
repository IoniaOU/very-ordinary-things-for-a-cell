using UnityEngine;
using System.Collections;

public class Level 
{
	public Molecule[] molecules;
	public Molecule targetMolecule;


	public Level( Molecule[] _molecules, Molecule _targetMolecule)
	{
		molecules = _molecules;
		targetMolecule = _targetMolecule;
	}
}
