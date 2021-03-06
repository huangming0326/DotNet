//
// File generated by HDevelop for HALCON/.NET (C#) Version 18.11.1.1
// Non-ASCII strings in this file are encoded in local-8-bit encoding (cp936).
// 
// Please note that non-ASCII characters in string constants are exported
// as octal codes in order to guarantee that the strings are correctly
// created on all systems, independent on any compiler settings.
// 
// Source files with different encoding should not be mixed in one project.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HalconDotNet;

public partial class HDevelopExport
{
    public static void function()
    {
        Console.WriteLine("----Invoke Class1.function()-OK---");
        return;
    }
#if !(NO_EXPORT_MAIN || NO_EXPORT_APP_MAIN)
    public static void HDevelopExport()
  {
    // Default settings used in HDevelop
    HOperatorSet.SetSystem("width", 512);
    HOperatorSet.SetSystem("height", 512);
    if (HalconAPI.isWindows)
      HOperatorSet.SetSystem("use_window_thread","true");
    action();
  }
#endif

#if !NO_EXPORT_MAIN
    // Main procedure 
    private void action()
  {


    // Local iconic variables 

    HObject ho_Image=null;

    // Local control variables 

    HTuple hv_AcqHandle = new HTuple(), hv_Mean = new HTuple();
    HTuple hv_Deviation = new HTuple();
    // Initialize local and output iconic variables 
    HOperatorSet.GenEmptyObj(out ho_Image);
    //Image Acquisition 02: Code generated by Image Acquisition 02
    hv_AcqHandle.Dispose();
    HOperatorSet.OpenFramegrabber("GigEVision2", 0, 0, 0, 0, 0, 0, "progressive", 
        -1, "default", -1, "false", "default", "c42f90f2b7fa_Hikvision_MVCE12010GM", 
        0, -1, out hv_AcqHandle);
    HOperatorSet.GrabImageStart(hv_AcqHandle, -1);
    while ((int)(1) != 0)
    {
      ho_Image.Dispose();
      HOperatorSet.GrabImageAsync(out ho_Image, hv_AcqHandle, -1);
      //Image Acquisition 02: Do something
      hv_Mean.Dispose();hv_Deviation.Dispose();
      HOperatorSet.Intensity(ho_Image, ho_Image, out hv_Mean, out hv_Deviation);
    }
    HOperatorSet.CloseFramegrabber(hv_AcqHandle);

    ho_Image.Dispose();

    hv_AcqHandle.Dispose();
    hv_Mean.Dispose();
    hv_Deviation.Dispose();

  }

#endif


}
#if !(NO_EXPORT_MAIN || NO_EXPORT_APP_MAIN)
public class HDevelopExportApp
{
  static void Main(string[] args)
  {
    new HDevelopExport();
  }
}
#endif

