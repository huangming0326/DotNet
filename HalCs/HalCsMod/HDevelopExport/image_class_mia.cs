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


using System;
using HalconDotNet;

public partial class HDevelopExport
{
  public void image_class_mia (HObject ho_Image, HTuple hv_WindowHandle, out HTuple hv_DecodedDataStrings)
  {




    // Local iconic variables 

    HObject ho_SymbolXLDs;

    // Local control variables 

    HTuple hv_DataCodeHandle = new HTuple(), hv_ResultHandles = new HTuple();
    // Initialize local and output iconic variables 
    HOperatorSet.GenEmptyObj(out ho_SymbolXLDs);
    hv_DecodedDataStrings = new HTuple();
    //* INIT BARCODE
    //create_data_code_2d_model ('Data Matrix ECC 200', [], [], DataCodeHandle)
    //create_data_code_2d_model ('Data Matrix ECC 200', 'maximum_recognition', [], DataCodeHandle)
    //create_data_code_2d_model ('Data Matrix ECC 200', 'train', 'all', DataCodeHandle)
    //*train
    //read_image (ImageTrain, 'C:/Users/iwake/OneDrive - wake/Desktop/Mia/Images/V3/3CWDL.bmp')
    //* find_data_code_2d (ImageTrain, SymbolXLDs, DataCodeHandle, 'train', 'all', \
    //                   ResultHandlesTrain, DecodedDataStringsTrain)
    //*end train
    hv_DataCodeHandle.Dispose();
    HOperatorSet.ReadDataCode2dModel("C:/Users/iwake/OneDrive - wake/Desktop/BarCode/Halcon/DataCodeHandle.dcm", 
        out hv_DataCodeHandle);
    ho_SymbolXLDs.Dispose();hv_ResultHandles.Dispose();hv_DecodedDataStrings.Dispose();
    HOperatorSet.FindDataCode2d(ho_Image, out ho_SymbolXLDs, hv_DataCodeHandle, "stop_after_result_num", 
        1, out hv_ResultHandles, out hv_DecodedDataStrings);
    //find_data_code_2d (Image, SymbolXLDs, DataCodeHandle, 'symbol_search', 1, ResultHandles, DecodedDataStrings1)

    //image_display_datacode(ho_SymbolXLDs, hv_ResultHandles, hv_WindowHandle, hv_DecodedDataStrings, hv_DataCodeHandle);
    ho_SymbolXLDs.Dispose();

    hv_DataCodeHandle.Dispose();
    hv_ResultHandles.Dispose();

    return;
  }

}
