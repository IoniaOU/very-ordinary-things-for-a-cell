using UnityEngine;
using System.Collections;

public class Reaction
{
	public string reactionName;

	public Molecule enzyme;
	public Molecule inputA;
	public Molecule inputB;
	public Molecule Output;
	public Molecule[] Waste;

	public Reaction(string _reactionName, Molecule _enzyme, Molecule _inputA, Molecule _inputB, Molecule _output, Molecule[] _waste)
	{
		reactionName = _reactionName;
		enzyme = _enzyme;
		inputA = _inputA;
		inputB = _inputB;
		Output = _output;
		Waste = _waste;
	}
}
