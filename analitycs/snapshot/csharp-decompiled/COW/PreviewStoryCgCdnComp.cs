using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class PreviewStoryCgCdnComp : MonoBehaviour
{
	public UINetworkTexture m_Typetitlenettex;

	public UINetworkTexture m_Maintitlenettex;

	public GameObject m_Maintitledefault;

	public uint CdnMainId;

	public uint CdnTypeId;

	protected void Awake()
	{
	}

	public void RefreshMainTitleCdnTex(string url, uint endTime)
	{
	}

	private bool _003CAwake_003Eb__5_0(AdvertDesc x)
	{
		return false;
	}
}
