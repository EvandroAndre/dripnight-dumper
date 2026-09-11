using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

public class TrampleObject : MetaObject
{
	public bool Enable;

	public uint MeshTemplateID;

	public uint TriggerTemplateID;

	[NonSerialized]
	private float timeStamp;

	[NonSerialized]
	private GameObject m_AudioSource;

	[NonSerialized]
	private List<Material> mats;

	[NonSerialized]
	private MaterialEffect materialEffect;

	public void Init()
	{
	}

	private void GenerateShadowMats(GameObject go)
	{
	}

	public void SetStatus(bool enable)
	{
	}

	public void PlaySound(ResourceID resourceID)
	{
	}

	public void SetStatus(bool enable, ulong curTimeStamp)
	{
	}

	public void Update()
	{
	}
}
