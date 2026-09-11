using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace ReactUI;

public sealed class UIVariableBindImage : UIVariableBind
{
	public enum EFitSizeType
	{
		none,
		nativeSize,
		widthHeight,
		UGCIconAdapt
	}

	public List<UIAtlas> MultiUIAtlas;

	private string spriteBind;

	private string fillAmountBind;

	private EFitSizeType autoFitSizeType;

	private int autoFitMaxWidth;

	private int autoFitMaxHeight;

	private bool autoDisable;

	private bool refreshImageOnInitial;

	private UISprite m_image;

	private UITexture m_rawImage;

	private UINetworkTexture m_networkTexture;

	private UIVariable imageVariable;

	private UIVariable fillAmountVariable;

	private UIAtlas m_defaultAtlas;

	private Action m_spriteLoadedCallback;

	private Action<UIAtlas, string> m_spriteNameLoadedCallback;

	private bool m_lastSpriteIsResourceID;

	private string m_lastSpriteName;

	private ResourceID m_lastSpriteResourceID;

	private static string S_ItemIconPrefix;

	protected override void BindVariables()
	{
	}

	protected override void UnbindVariables()
	{
	}

	private void autoSize()
	{
	}

	private void onSpriteLoaded()
	{
	}

	private void onSpriteNameLoaded(UIAtlas atlasData, string spriteName)
	{
	}

	private void RefreshImage()
	{
	}

	private void RefreshFillAmount()
	{
	}

	private void RefreshDisableStatus(UISprite img)
	{
	}

	private new void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void _003CRefreshImage_003Eb__26_0(bool succ, bool isReloaded, Texture2D tex)
	{
	}
}
