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
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Teigha.Runtime;
using Teigha.DatabaseServices;
using Teigha.GraphicsSystem;
using Teigha.Export_Import;

namespace OdViewExMgd
{
  public partial class PDFExport : Form
  {
    Database database;
    public PDFExport(Database db)
    {
      InitializeComponent();

      database = db;
      PageParams pp = new PageParams();
      PapWidth.Text = pp.PaperWidth.ToString();
      PapHeight.Text = pp.PaperHeight.ToString();
    }

    private void btBrowse_Click(object sender, EventArgs e)
    {
      if(DialogResult.OK == saveFileDialog.ShowDialog())
      {
        outputFile.Text = saveFileDialog.FileName;
      }
    }

    private void Cancel_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void Export_Click(object sender, EventArgs e)
    {
      if(outputFile.Text.Length > 0)
      {
        using (mPDFExportParams param = new mPDFExportParams())
        {
          param.Database = database;
          using (FileStreamBuf fileStrem = new FileStreamBuf(outputFile.Text, false, FileShareMode.DenyNo, FileCreationDisposition.CreateAlways))
          {
            param.OutputStream = fileStrem;

            param.Flags = (embedded_fonts.Checked ? PDFExportFlags.EmbededTTF : 0) |
                          (SHXTextAsGeometry.Checked ? PDFExportFlags.SHXTextAsGeometry : 0) |
                          (TTGeometry.Checked ? PDFExportFlags.TTFTextAsGeometry : 0) |
                          (ESimpGeometryOpt.Checked ? PDFExportFlags.SimpleGeomOptimization : 0) |
                          (ZoomExtents.Checked ? PDFExportFlags.ZoomToExtentsMode : 0) |
                          (EnableLayerSup_pdfv1_5.Checked ? PDFExportFlags.EnableLayers : 0) |
                          (ExportOffLay.Checked ? PDFExportFlags.IncludeOffLayers : 0);

            param.Title = textBox_title.Text;
            param.Author = textBox_author.Text;
            param.Subject = textBox_subject.Text;
            param.Keywords = textBox_keywords.Text;
            param.Creator = textBox_creator.Text;
            param.Producer = textBox_producer.Text;
            param.UseHLR = UseHidLRAlgorithm.Checked;
            param.EncodeStream = EncodedSZ.Checked;

            bool bV15 = EnableLayerSup_pdfv1_5.Checked || ExportOffLay.Checked;
            param.Versions = bV15 ? PDFExportVersions.PDFv1_5 : PDFExportVersions.PDFv1_4;

            StringCollection strColl = new StringCollection();
            if (radioButton_All.Checked)
            {
              using (DBDictionary layouts = (DBDictionary)database.LayoutDictionaryId.GetObject(OpenMode.ForRead))
              {
                foreach (DBDictionaryEntry entry in layouts)
                {
                  strColl.Add(entry.Key);
                }
              }
            }
            param.Layouts = strColl;

            int nPages = Math.Max(1, strColl.Count);
            PageParamsCollection pParCol = new PageParamsCollection();
            Double width = Double.Parse(PapWidth.Text);
            Double height = Double.Parse(PapHeight.Text);
            for (int i = 0; i < nPages; ++i)
            {
              PageParams pp = new PageParams();
              pp.setParams(width, height);
              pParCol.Add(pp);
            }
            param.PageParams = pParCol;
            Export_Import.ExportPDF(param);
          }
        }
        Close();
      }
    }

    private void EnableLayerSup_pdfv1_5_CheckedChanged(object sender, EventArgs e)
    {
      ExportOffLay.Enabled = EnableLayerSup_pdfv1_5.Checked;
      if (!EnableLayerSup_pdfv1_5.Checked)
        ExportOffLay.Checked = EnableLayerSup_pdfv1_5.Checked;
    }
  }
}