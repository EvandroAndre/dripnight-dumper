using System;

namespace COW.GamePlay;

[Serializable]
internal struct QTEParams
{
	public bool isQTE;

	public string shield;

	public float qte_time;

	public float duration;
}
