//----------------------------------------------------------------------------
//  Copyright (C) 2004-2018 by EMGU Corporation. All rights reserved.       
//----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Emgu.TF.Lite
{
    public partial class TfLiteInvoke
    {
        /// <summary>
        /// The file name of the tfextern library
        /// </summary>
#if UNITY_EDITOR_OSX
      public const string ExternLibrary = "Assets/Emgu.TF/Plugins/emgutf.bundle/Contents/MacOS/libtfliteextern.dylib";
#elif UNITY_STANDALONE_OSX
      public const string ExternLibrary = "@executable_path/../Plugins/emgutf.bundle/Contents/MacOS/libtfliteextern.dylib";
#elif (__IOS__ || UNITY_IPHONE) && (!UNITY_EDITOR_WIN)
      public const string ExternLibrary = "__Internal";
//#elif (!__IOS__) && __UNIFIED__
//      public const string ExternLibrary = "libtfliteextern.dylib";
#else
        public const string ExternLibrary = "tfliteextern";
#endif

        /// <summary>
        /// The List of the opencv modules
        /// </summary>
        public static List<String> TensorflowModuleList = new List<String>
        {
            ExternLibrary
        };

    }
}
