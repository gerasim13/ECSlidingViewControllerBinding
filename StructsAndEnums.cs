using System;

namespace ECSlidingViewControllerLibrary
{
	[Flags]
	public enum ECSlidingViewControllerOperation
	{
		None,
		AnchorLeft,
		AnchorRight,
		ResetFromLeft,
		ResetFromRight
	}

	[Flags]
	public enum ECSlidingViewControllerTopViewPosition
	{
		AnchoredLeft,
		AnchoredRight,
		Centered
	}

	[Flags]
	public enum ECSlidingViewControllerAnchoredGesture
	{
		None     = 0,
		Panning  = 1 << 0,
		Tapping  = 1 << 1,
		Custom   = 1 << 2,
		Disabled = 1 << 3
	}
}

