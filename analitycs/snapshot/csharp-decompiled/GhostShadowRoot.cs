using System.Collections.Generic;
using UnityEngine;

public class GhostShadowRoot : MonoBehaviour
{
	public delegate void onEffectFinsih();

	public onEffectFinsih OnEffectFinish;

	public List<GhostShadowEffect> GhostEffectList;

	public float EndTime;

	private bool bActive;

	public bool IsActive => false;

	public void Active(float endTime)
	{
	}

	private void Update()
	{
	}

	public void DisActive()
	{
	}
}
