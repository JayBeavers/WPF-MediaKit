using System;
using System.Collections.Generic;
using System.Linq;
using DirectShowLib;

namespace WPFMediaKit.DirectShow.Controls
{
    public class MultimediaUtil
    {
		#region Audio Renderer Methods
		/// <summary>
		/// The private cache of the audio renderer names
		/// </summary>
		private static string[] m_audioRendererNames;

		/// <summary>
		/// An array of audio renderer device names
		/// on the current system
		/// </summary>
		public static string[] AudioRendererNames
		{
			get
			{
				if (m_audioRendererNames == null)
				{
					m_audioRendererNames = (from a in GetDevices(FilterCategory.AudioRendererCategory)
					                        select a.Name).ToArray();
				}
				return m_audioRendererNames;
			}
		}
		#endregion

		#region Video Input Devices
		public static string[] VideoInputNames
		{
			get
			{
				return (from d in VideoInputDevices select d.Name).ToArray();
			}
		}

		#endregion

		private static DsDevice[] GetDevices(Guid filterCategory)
		{
			return (from d in DsDevice.GetDevicesOfCat(filterCategory) select d).ToArray();
		}

    	public static DsDevice[] VideoInputDevices
		{
			get
			{
				return GetDevices(FilterCategory.VideoInputDevice);
			}
		}

		public static string[] VideoInputsDevicePaths
		{
			get
			{
				return (from d in VideoInputDevices select d.DevicePath).ToArray();
			}
		}
    }
}
