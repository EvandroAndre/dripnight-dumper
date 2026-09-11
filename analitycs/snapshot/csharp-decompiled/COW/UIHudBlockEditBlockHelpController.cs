using System;
using System.Collections.Generic;
using COW.Gameplay.UGC.BlockEdit;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBlockEditBlockHelpController : UIPopupWindowController
{
	private UIHudBlockEditBlockHelpView m_View;

	private UIClickMask m_ClickMask;

	public Action onClosed;

	private int minHeight;

	private int maxHeight;

	private int margineDis;

	private int rowSpacing;

	private int titleIntroLen;

	private int paraIntroLen;

	private bool isFirstLine;

	private string m_Url;

	public bool isOpen;

	private List<SerializeBlockFieldDefine> InputField;

	private List<SerializeBlockFieldDefine> OutputField;

	private string[] ResourcesName;

	private int curX;

	private int curY;

	private int typeBgOffset;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnTweenAnimationFinish()
	{
	}

	public void SetPos(Vector3 pos)
	{
	}

	public void InitHelp(BlockData blockData)
	{
	}

	protected override void OnUIClose()
	{
	}

	private void InitUrl(string id)
	{
	}

	private void Reposition()
	{
	}

	private void ResetPos()
	{
	}

	private void BuildPartingLine(Transform parent)
	{
	}

	private void BuildParaInfo(SerializeBlockFieldDefine fielddefine, ParaCate cate)
	{
	}

	private void BuildReturnInfo(DataBlockDefine define)
	{
	}

	private GameObject BuildParaIcon(ParaCate cate, Transform parent)
	{
		return null;
	}

	private GameObject BuildParaName(string name, Transform parent)
	{
		return null;
	}

	private void BuildParaType(string typename, Transform parent)
	{
	}

	private void BuildParaIntroContent(string content, Transform parent)
	{
	}

	private void _003CInitUrl_003Eb__21_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnTweenAnimationFinish()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
