///////////////////////////////////////////////////////////////////////////////
// Copyright © 2009-2010, Open Design Alliance (the "Alliance") 
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
// Teigha™.NET for .dwg files 2009-2010 by Open Design Alliance. All rights reserved.
//
// By use of this software, you acknowledge and accept these terms.
//
//
// *DWG is the native and proprietary file format for AutoCAD® and a trademark 
// of Autodesk, Inc. The Open Design Alliance is not associated with Autodesk.
///////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text;
using Teigha.DatabaseServices;
using Teigha.Geometry;

namespace OdWriteExMgd
{
  public partial class DbFiller
  {
    EntityBoxes m_EntityBoxes;
    double m_textSize;
    Vector3d m_textOffset;
    Vector3d m_textLine;
    ObjectIdCollection m_layoutEntities;

    public DbFiller()
    {
      m_EntityBoxes = new EntityBoxes();
      m_textSize = 0.2;
      m_textOffset = new Vector3d(0.5 * m_textSize, -0.5 * m_textSize, 0);
      m_textLine = new Vector3d(0, -1.6 * m_textSize, 0);
      m_layoutEntities = new ObjectIdCollection();
    }
  }
}
