using System;
using System.Linq;
using App1.CustomControls;
using App1.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("MyCompany")]
[assembly: ExportEffect(typeof(LabelShadowEffect), "LabelShadowEffect")]
namespace App1.Droid.Renderers
{
	public class LabelShadowEffect : PlatformEffect
	{
		protected override void OnAttached()
		{
			try
			{
				var control = Control as Android.Widget.TextView;
				var effect = (ShadowEffect)Element.Effects.FirstOrDefault(e => e is ShadowEffect);
				if (effect != null)
				{
					float radius = effect.Radius;
					float distanceX = effect.DistanceX;
					float distanceY = effect.DistanceY;
					Android.Graphics.Color color = effect.Color.ToAndroid();
					control.SetShadowLayer(radius, distanceX, distanceY, color);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
			}
		}

		protected override void OnDetached()
		{
		}
	}
}