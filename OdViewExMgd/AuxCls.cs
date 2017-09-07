///////////////////////////////////////////////////////////////////////////////
// Copyright ?2009-2010, Open Design Alliance (the "Alliance") 
// 
// This software is owned by the Alliance, and may only be incorporated into 
// application programs owned by members of the Alliance subject to a signed 
// Membership Agreement and Supplemental Software License Agreement with the
// Alliance. The structure and organization of this software are the valuable 
// trade secrets of the Alliance and its suppliers. The software is also 
// protected by copyright law and international treaty provisions. Application 
// programs incorporating this software must include the following statement 
// with their copyright notices:
//
// Teigha?NET for .dwg files 2009-2010 by Open Design Alliance. All rights reserved.
//
// By use of this software, you acknowledge and accept these terms.
//
//
// *DWG is the native and proprietary file format for AutoCAD?and a trademark 
// of Autodesk, Inc. The Open Design Alliance is not associated with Autodesk.
///////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Teigha;
using Teigha.GraphicsSystem;
using Teigha.Runtime;
using Teigha.GraphicsInterface;
using Teigha.DatabaseServices;
using Teigha.Export_Import;


namespace OdViewExMgd
{
  class Aux
  {
    public static ObjectId active_viewport_id(Database database)
    {
      if (database.TileMode)
      {
        return database.CurrentViewportTableRecordId;
      }
      else
      {
        using(BlockTableRecord paperBTR = (BlockTableRecord)database.CurrentSpaceId.GetObject(OpenMode.ForRead))
        {
          Layout l = (Layout)paperBTR.LayoutId.GetObject(OpenMode.ForRead);
          return l.CurrentViewportId;
        }
      }
    }

    public static void preparePlotstyles(Database database, ContextForDbDatabase ctx)
    {
      using (BlockTableRecord paperBTR = (BlockTableRecord)database.CurrentSpaceId.GetObject(OpenMode.ForRead))
      {
        using (Layout pLayout = (Layout)paperBTR.LayoutId.GetObject(OpenMode.ForRead))
        {
          if (ctx.IsPlotGeneration ? pLayout.PlotPlotStyles : pLayout.ShowPlotStyles)
          {
            String pssFile = pLayout.CurrentStyleSheet;
            if (pssFile.Length > 0)
            {
              String testpath = ((HostAppServ)HostApplicationServices.Current).FindFile(pssFile, database, FindFileHint.Default);
              if (testpath.Length > 0)
              {
                using (FileStreamBuf pFileBuf = new FileStreamBuf(testpath))
                {
                  ctx.LoadPlotStyleTable(pFileBuf);
                }
              }
            }
          }
        }
      }
    }
  }
}
