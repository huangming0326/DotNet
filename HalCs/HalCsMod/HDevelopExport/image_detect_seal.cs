//
// File generated by HDevelop for HALCON/.NET (C#) Version 18.11.1.1
// Non-ASCII strings in this file are encoded in UTF-8.
// 
// Please note that non-ASCII characters in string constants are exported
// as octal codes in order to guarantee that the strings are correctly
// created on all systems, independent on any compiler settings.
// 
// Source files with different encoding should not be mixed in one project.
//
//  This file is intended to be used with the HDevelopTemplate or
//  HDevelopTemplateWPF projects located under %HALCONEXAMPLES%\c#

using System;
using System.Windows.Forms;
using HalconDotNet;

public partial class HDevelopExport
{
  public HTuple hv_ExpDefaultWinHandle;

  public void HDevelopStop()
  {
    MessageBox.Show("Press button to continue", "Program stop");
  }

  // Procedures 
  public void image_detect_seal (HObject ho_Image, HTuple hv_BarcodeRow, HTuple hv_areaSeal, 
      out HTuple hv_Area, out HTuple hv_seal)
  {




    // Local iconic variables 

    HObject ho_GrayImage, ho_ImageReducedBarcode;
    HObject ho_ImageReduced, ho_Red, ho_Green, ho_Blue, ho_Hue;
    HObject ho_Saturation, ho_ImageResult3, ho_HighSaturation;
    HObject ho_HueHighSaturation, ho_RedRegion, ho_ConnectedRegions;
    HObject ho_SelectedRegions, ho_ImageRed;

    // Local control variables 

    HTuple hv_thresholdColorSealMin = new HTuple();
    HTuple hv_thresholdColorSealMax = new HTuple(), hv_Width = new HTuple();
    HTuple hv_Height = new HTuple(), hv_Column = new HTuple();
    HTuple   hv_areaSeal_COPY_INP_TMP = new HTuple(hv_areaSeal);

    // Initialize local and output iconic variables 
    HOperatorSet.GenEmptyObj(out ho_GrayImage);
    HOperatorSet.GenEmptyObj(out ho_ImageReducedBarcode);
    HOperatorSet.GenEmptyObj(out ho_ImageReduced);
    HOperatorSet.GenEmptyObj(out ho_Red);
    HOperatorSet.GenEmptyObj(out ho_Green);
    HOperatorSet.GenEmptyObj(out ho_Blue);
    HOperatorSet.GenEmptyObj(out ho_Hue);
    HOperatorSet.GenEmptyObj(out ho_Saturation);
    HOperatorSet.GenEmptyObj(out ho_ImageResult3);
    HOperatorSet.GenEmptyObj(out ho_HighSaturation);
    HOperatorSet.GenEmptyObj(out ho_HueHighSaturation);
    HOperatorSet.GenEmptyObj(out ho_RedRegion);
    HOperatorSet.GenEmptyObj(out ho_ConnectedRegions);
    HOperatorSet.GenEmptyObj(out ho_SelectedRegions);
    HOperatorSet.GenEmptyObj(out ho_ImageRed);
    hv_Area = new HTuple();
    hv_seal = new HTuple();
    //** Initial
    //* Initializing Location

    //BarcodeRow := 1000
    //BarcodeCol := 0

    //MoneyRow := 0
    //MoneyCol := 0

    hv_thresholdColorSealMin.Dispose();
    hv_thresholdColorSealMin = 200;
    hv_thresholdColorSealMax.Dispose();
    hv_thresholdColorSealMax = 255;

    hv_areaSeal_COPY_INP_TMP.Dispose();
    hv_areaSeal_COPY_INP_TMP = 5000;

    //* Initializing Image
    //read_image (Image, 'C:/Users/iwake/OneDrive - wake/Desktop/Mia/Images/V0.0/3 (2).jpg')
    hv_Width.Dispose();hv_Height.Dispose();
    HOperatorSet.GetImageSize(ho_Image, out hv_Width, out hv_Height);
    ho_GrayImage.Dispose();
    HOperatorSet.Rgb1ToGray(ho_Image, out ho_GrayImage);
    //get_domain (Image, Domain)
    //crop_part (Image, ImagePart, BarcodeRow, 0, Width, Height)
    ho_ImageReducedBarcode.Dispose();
    HOperatorSet.Rectangle1Domain(ho_Image, out ho_ImageReducedBarcode, hv_BarcodeRow, 
        0, hv_Height, hv_Width);
    ho_ImageReduced.Dispose();
    HOperatorSet.ReduceDomain(ho_Image, ho_ImageReducedBarcode, out ho_ImageReduced
        );

    //** Progressing
    ho_Red.Dispose();ho_Green.Dispose();ho_Blue.Dispose();
    HOperatorSet.Decompose3(ho_ImageReduced, out ho_Red, out ho_Green, out ho_Blue
        );
    ho_Hue.Dispose();ho_Saturation.Dispose();ho_ImageResult3.Dispose();
    HOperatorSet.TransFromRgb(ho_Red, ho_Green, ho_Blue, out ho_Hue, out ho_Saturation, 
        out ho_ImageResult3, "hsv");
    ho_HighSaturation.Dispose();
    HOperatorSet.Threshold(ho_Saturation, out ho_HighSaturation, 100, 255);
    ho_HueHighSaturation.Dispose();
    HOperatorSet.ReduceDomain(ho_Hue, ho_HighSaturation, out ho_HueHighSaturation
        );
    ho_RedRegion.Dispose();
    HOperatorSet.Threshold(ho_HueHighSaturation, out ho_RedRegion, hv_thresholdColorSealMin, 
        hv_thresholdColorSealMax);
    ho_ConnectedRegions.Dispose();
    HOperatorSet.Connection(ho_RedRegion, out ho_ConnectedRegions);
    ho_SelectedRegions.Dispose();
    HOperatorSet.SelectShapeStd(ho_ConnectedRegions, out ho_SelectedRegions, "max_area", 
        0);
    ho_Red.Dispose();
    HOperatorSet.ClosingCircle(ho_SelectedRegions, out ho_Red, 3.5);
    ho_ImageRed.Dispose();
    HOperatorSet.ReduceDomain(ho_Image, ho_RedRegion, out ho_ImageRed);
    //rgb1_to_gray (ImageRed, ImageRedGray)
    //* sub_image (ImageRedGray,GrayImage, ImageNoSeal, 1, 100)
    hv_Area.Dispose();hv_Area.Dispose();hv_Column.Dispose();
    HOperatorSet.AreaCenter(ho_Red, out hv_Area, out hv_Area, out hv_Column);
    //stop ()
    HOperatorSet.DispObj(ho_HueHighSaturation, hv_ExpDefaultWinHandle);
    HOperatorSet.DispObj(ho_ImageReduced, hv_ExpDefaultWinHandle);
    if ((int)(new HTuple(hv_Area.TupleGreater(hv_areaSeal_COPY_INP_TMP))) != 0)
    {
      hv_seal.Dispose();
      hv_seal = 1;
    }
    ho_GrayImage.Dispose();
    ho_ImageReducedBarcode.Dispose();
    ho_ImageReduced.Dispose();
    ho_Red.Dispose();
    ho_Green.Dispose();
    ho_Blue.Dispose();
    ho_Hue.Dispose();
    ho_Saturation.Dispose();
    ho_ImageResult3.Dispose();
    ho_HighSaturation.Dispose();
    ho_HueHighSaturation.Dispose();
    ho_RedRegion.Dispose();
    ho_ConnectedRegions.Dispose();
    ho_SelectedRegions.Dispose();
    ho_ImageRed.Dispose();

    hv_areaSeal_COPY_INP_TMP.Dispose();
    hv_thresholdColorSealMin.Dispose();
    hv_thresholdColorSealMax.Dispose();
    hv_Width.Dispose();
    hv_Height.Dispose();
    hv_Column.Dispose();

    return;
    ho_GrayImage.Dispose();
    ho_ImageReducedBarcode.Dispose();
    ho_ImageReduced.Dispose();
    ho_Red.Dispose();
    ho_Green.Dispose();
    ho_Blue.Dispose();
    ho_Hue.Dispose();
    ho_Saturation.Dispose();
    ho_ImageResult3.Dispose();
    ho_HighSaturation.Dispose();
    ho_HueHighSaturation.Dispose();
    ho_RedRegion.Dispose();
    ho_ConnectedRegions.Dispose();
    ho_SelectedRegions.Dispose();
    ho_ImageRed.Dispose();

    hv_areaSeal_COPY_INP_TMP.Dispose();
    hv_thresholdColorSealMin.Dispose();
    hv_thresholdColorSealMax.Dispose();
    hv_Width.Dispose();
    hv_Height.Dispose();
    hv_Column.Dispose();

    return;
  }


}

