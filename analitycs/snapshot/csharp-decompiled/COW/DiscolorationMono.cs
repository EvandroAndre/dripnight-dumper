using GCommon;
using UnityEngine;

namespace COW;

public class DiscolorationMono : MonoBehaviour
{
	public Animation m_anim;

	public UITexture m_texture;

	public UITexture m_texture2;

	private const string Anim1 = "FF_UI_Discoloration_01";

	private const string Anim2 = "FF_UI_Discoloration_02";

	private bool m_TwoTextureCarousel;

	private TextureIconCDNResource m_NowCDNRes;

	private TextureIconCDNResource m_NowCDNRes1;

	private bool hasSecondTex;

	private bool texture1Download;

	private bool texture2Download;

	private int m_X;

	private int m_Y;

	private int m_Z;

	public void SetDiscolorUI(int x, int y, int z, ResourceID id, ResourceID id2)
	{
	}

	private void InitDiscolorationMatState(bool needInitTex2 = false)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void UnRegisterCDNUrl()
	{
	}

	private void PlayAnim()
	{
	}

	private bool CheckTextureCanPlay()
	{
		return false;
	}

	private void _003CSetDiscolorUI_003Eb__14_0(bool result)
	{
	}

	private void _003CSetDiscolorUI_003Eb__14_1(bool result)
	{
	}
}
