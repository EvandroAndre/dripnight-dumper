using UnityEngine;

namespace COW;

public interface IVoucher
{
	UIVoucherController OpenVoucherController(Transform parent);

	void OnVoucherItemClick(object[] data);

	UIVoucherItemController OpenVoucherItemController(Transform parent);
}
