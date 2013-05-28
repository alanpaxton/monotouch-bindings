using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libMapBox.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, 
                     Frameworks = "CoreFoundation CoreLocation QuartzCore UIKit Foundation CoreGraphics", 
                     LinkerFlags = "-lz -lsqlite3", ForceLoad = true, IsCxx = true)]
