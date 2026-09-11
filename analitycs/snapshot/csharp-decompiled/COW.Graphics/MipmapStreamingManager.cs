using System.Collections.Generic;
using UnityEngine;

namespace COW.Graphics;

public class MipmapStreamingManager : MonoBehaviour
{
	private enum MipmapSel
	{
		Close,
		Lowest,
		Normal,
		Undefined
	}

	private enum Phase
	{
		Init,
		Opaque,
		Blend,
		Resume,
		Undefined
	}

	private MipmapSel m_MipmapSel;

	private Phase m_Phase;

	public List<MipmapStreamingObj> m_Objects;

	public Camera m_Camera;

	public List<float> m_DistanceLevels;

	public List<MipmapStreamingObj.TextureInfo> m_TextureInfos;

	private void Update()
	{
	}

	private void OnInitPreviewMat(Material mat)
	{
	}

	private void OnNoPreviewInitTerrain(Material mat)
	{
	}

	private void OnPreparePreviewOpaqueMat(Material mat)
	{
	}

	private void OnPreparePreivewBlendMat(Material mat)
	{
	}

	private void OnResumeMat(Material mat)
	{
	}

	private void OnDestroy()
	{
	}

	private void Awake()
	{
	}

	private int ComputeMipmapLevel(MipmapStreamingObj obj)
	{
		return 0;
	}
}
