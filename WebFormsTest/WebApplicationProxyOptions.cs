﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fritz.WebFormsTest
{
  public class WebApplicationProxyOptions : MarshalByRefObject
  {

    public bool SkipCrawl { get; set; } = true;

    public bool SkipPrecompile { get; set; } = true;

    /// <summary>
    /// Location of the website on disk, overrides the auto-locator
    /// </summary>
    public string PhysicalRootFolder { get; set; }


  }

}