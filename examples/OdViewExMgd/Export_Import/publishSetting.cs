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
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
  public partial class publishSetting : Form
  {
    DWFPageData pageData;
    public publishSetting(DWFPageData pd, String drawing)
    {
      pageData = pd;
      InitializeComponent();

      textBoxLayoutName.Text  = pageData.Layout;
      textBoxSheetName.Text = pageData.PageTitle;
      textBoxDrawingName.Text = drawing;
      textBoxSubject.Text = pageData.PageSubject;
      textBoxCompany.Text = pageData.PageCompany;
      textBoxCom.Text = pageData.PageComments;
      textBoxAuthor.Text = pageData.PageAuthor;
      textBoxFilename.Text = pageData.Preview.FileName;
      textBoxWidth.Text = pageData.Preview.Width.ToString();
      textBoxHeight.Text = pageData.Preview.Height.ToString();
      textBoxColorDepth.Text = pageData.Preview.ColorDepth.ToString();
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void buttonOk_Click(object sender, EventArgs e)
    {
      pageData.PageTitle          = textBoxSheetName.Text;
      pageData.PageSubject        = textBoxSubject.Text;
      pageData.PageCompany        = textBoxCompany.Text;
      pageData.PageComments       = textBoxCom.Text;
      pageData.PageAuthor         = textBoxAuthor.Text;
      pageData.Preview.FileName   = textBoxFilename.Text;
      pageData.Preview.Width      = int.Parse(textBoxWidth.Text);
      pageData.Preview.Height     = int.Parse(textBoxHeight.Text);
      pageData.Preview.ColorDepth = int.Parse(textBoxColorDepth.Text);
    }

    private void buttonFN_Click(object sender, EventArgs e)
    {
      if (DialogResult.OK == openFileDialog1.ShowDialog())
      {
        String strPreview = openFileDialog1.FileName;
        int find;
        switch (openFileDialog1.FilterIndex)
        {
          case 1:
            find = strPreview.LastIndexOf(".jpg");
            if (find == -1)
            {
              strPreview += String.Format(".jpg");
            }
            break;
          case 2:
            find = strPreview.LastIndexOf(".png");
            if (find == -1)
            {
              strPreview += String.Format(".png");
            }
            break;
        }
        textBoxFilename.Text = strPreview;
      }
      Update();
    }
  }
}