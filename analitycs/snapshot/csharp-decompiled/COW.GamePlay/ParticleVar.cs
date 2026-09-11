using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay;

public class ParticleVar : MonoBehaviour
{
	public enum KHJMCEDAHDJ
	{
		Tint,
		Tritone,
		Colorama
	}

	[Serializable]
	public class Setting
	{
		[Serializable]
		public class Binding
		{
			public ParticleSystem ParticleSystem;

			public float Weight;
		}

		public string Name;

		public List<Binding> Bindings;

		public KHJMCEDAHDJ CCType;

		public Color TintColor;

		public Color Highlight;

		public Color Midtone;

		public Color Shadow;

		public Gradient RampColor;
	}

	private sealed class NHACIBAPHHI
	{
		public string JCIFFMHHBHK;

		internal bool EIPKFCNJHDJ(Setting FADOEDJHAGD)
		{
			return false;
		}
	}

	public List<Setting> Settings;

	private void OnEnable()
	{
	}

	public void Apply(string JCIFFMHHBHK)
	{
	}

	public void InternalApplySetting(Setting NBDGPKJOCNP)
	{
	}

	public static void TrySet(GameObject BFDPFCHOLNO, string DGDDJLEOPBL)
	{
	}
}
