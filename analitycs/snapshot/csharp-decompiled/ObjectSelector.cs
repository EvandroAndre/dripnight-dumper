using System;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelector : MonoBehaviour
{
	public enum SelectorType
	{
		ByMasterRank
	}

	[Serializable]
	public class SelectionRule
	{
		public int threshold;

		public GameObject selectedObject;
	}

	private ParticleSystem activeParticle;

	public SelectorType SelectType;

	public List<SelectionRule> Rules;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
