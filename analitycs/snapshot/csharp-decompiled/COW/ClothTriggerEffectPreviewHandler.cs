using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class ClothTriggerEffectPreviewHandler
{
	private sealed class _003CSelectPrivilegeItemAfterInit_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIChangeWeaponPreviewMainController ctrl;

		public uint triggerID;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSelectPrivilegeItemAfterInit_003Ed__5(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private IClothTriggerEffectPreviewContext m_Context;

	public ClothTriggerEffectPreviewHandler(IClothTriggerEffectPreviewContext context)
	{
	}

	public bool ShouldPreviewEventTriggerEffect(uint triggerID)
	{
		return false;
	}

	private static void OpenPrivilegePreviewWindow(uint clothOrBundleId, uint clothesSetID, bool isFemaleAvatar, uint triggerID)
	{
	}

	public static List<uint> GetEffectTriggerIDs(uint itemId)
	{
		return null;
	}

	private static IEnumerator SelectPrivilegeItemAfterInit(UIChangeWeaponPreviewMainController ctrl, uint triggerID)
	{
		return null;
	}

	public void PreviewEventTriggerEffect(ClothTriggerEffectPreviewData data)
	{
	}

	private bool HasWithoutAvatarClothEffectRes(uint clothID, int clothEffectTriggerID)
	{
		return false;
	}

	public static ResourceID GetWithoutAvatarClothEffectRes(uint clothID, int clothEffectTriggerID)
	{
		return default(ResourceID);
	}

	private void RefreshMultipleEventTriggerEffect(ClothTriggerEffectPreviewData data, List<uint> clothList)
	{
	}
}
