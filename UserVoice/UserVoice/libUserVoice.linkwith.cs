using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libUserVoice.a", LinkTarget.ArmV7 | LinkTarget.Simulator, ForceLoad = true)]
