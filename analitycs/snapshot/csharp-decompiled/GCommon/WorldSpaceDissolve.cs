using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class WorldSpaceDissolve : MonoBehaviour
{
	public List<Renderer> targets;

	public Transform FadeCenterDummy;

	public float AnimCtl;

	public float WaveScale;

	public float HeightScale;

	public bool Invert;

	public bool TopFront;

	public Color Color;

	public float CC;

	public float ColorIntensive;

	public float ColorPower;

	public float AlphaIntensive;

	public Texture DistortTexRG;

	public Vector2 DistortTiling;

	public Vector2 DistortOffset;

	public Vector2 DistortXY;

	public Vector2 DistortPanner;

	public Texture SeamTex;

	public Vector2 SeamTexTiling;

	public Vector2 SeamTexOffset;

	public float SeamSize;

	public float FixAlpha;

	public bool SeamAddMul;

	public bool Updating;

	public bool _NULL_BasicSettings;

	public bool _NULL_ColorCorrection;

	public bool _NULL_Distort;

	public bool _NULL_Seam;

	private MaterialPropertyBlock _mpb;

	private int DummyPos01_ID;

	private int AnimCtl_ID;

	private int Color_ID;

	private int ColorCorrection_ID;

	private int DistortTexRG_ID;

	private int DistortTexRG_ST_ID;

	private int DistortValue_ID;

	private int SeamTex_ID;

	private int SeamTex_ST_ID;

	private int Vector01_ID;

	private int Toggle_ID;

	private void InitShaderID()
	{
	}

	public void UpdateData()
	{
	}

	public void InitData()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}
}
