using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libUserVoice.ios.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s, ForceLoad = true)]
