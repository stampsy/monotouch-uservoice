using MonoTouch.ObjCRuntime;

#if DEBUG
[assembly: LinkWith ("libUserVoice.sim.a", LinkTarget.Simulator, ForceLoad = true)]
#endif