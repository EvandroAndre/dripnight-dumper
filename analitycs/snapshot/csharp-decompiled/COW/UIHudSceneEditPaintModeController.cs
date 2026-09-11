using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditPaintModeController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<CSVBaseData, UGCAI_Procedural_cdn_Data> _003C_003E9__7_0;

		public static Predicate<UGCAI_Procedural_cdn_Data> _003C_003E9__9_0;

		public static Predicate<UGCAI_Procedural_cdn_Data> _003C_003E9__9_1;

		public static Predicate<UGCAI_Procedural_cdn_Data> _003C_003E9__9_2;

		public static Predicate<UGCAI_Procedural_cdn_Data> _003C_003E9__9_3;

		internal UGCAI_Procedural_cdn_Data _003COnUIInit_003Eb__7_0(CSVBaseData data)
		{
			return null;
		}

		internal bool _003CWrapCDNPic_003Eb__9_0(UGCAI_Procedural_cdn_Data data)
		{
			return false;
		}

		internal bool _003CWrapCDNPic_003Eb__9_1(UGCAI_Procedural_cdn_Data data)
		{
			return false;
		}

		internal bool _003CWrapCDNPic_003Eb__9_2(UGCAI_Procedural_cdn_Data data)
		{
			return false;
		}

		internal bool _003CWrapCDNPic_003Eb__9_3(UGCAI_Procedural_cdn_Data data)
		{
			return false;
		}
	}

	private List<UGCAI_Procedural_cdn_Data> m_Datas;

	private SceneEditAgent agent;

	private UIHudSceneEditPaintModePickView m_View;

	private bool m_banRaceMode;

	private SceneEditAgent Agent => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void ShowPanel()
	{
	}

	private void WrapCDNPic()
	{
	}

	private void OnClickToHide(List<GameObject> hits)
	{
	}

	private void HidePanel()
	{
	}

	private void OnModeSelect(SceneEditPaintTool.AGDLPAPNDME style)
	{
	}

	private void OnItemGenModeSelect()
	{
	}

	private void _003COnUIInit_003Eb__7_1()
	{
	}

	private void _003COnUIInit_003Eb__7_2()
	{
	}

	private void _003COnUIInit_003Eb__7_3()
	{
	}

	private void _003CWrapCDNPic_003Eb__9_4()
	{
	}

	private void _003CWrapCDNPic_003Eb__9_5()
	{
	}

	private void _003CWrapCDNPic_003Eb__9_6()
	{
	}

	private void _003CWrapCDNPic_003Eb__9_7()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
