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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Teigha;
using Teigha.DatabaseServices;
using Teigha.GraphicsSystem;
using Teigha.Runtime;
using Teigha.GraphicsInterface;
using Teigha.Geometry;
using Teigha.Export_Import;

namespace OdViewExMgd
{
  public partial class BMPExport : Form
  {
    Database database;
    public BMPExport(Database db)
    {
      database = db;
      InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void buttonBkgColor_Click(object sender, EventArgs e)
    {
      colorDialog.ShowDialog();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (DialogResult.OK == openFileDialog.ShowDialog())
      {
        using (GsModule gsModule = (GsModule)SystemObjects.DynamicLinker.LoadModule("WinDirectX.txv", false, true))
        {
          // create graphics device
          using (Teigha.GraphicsSystem.Device dev = gsModule.CreateBitmapDevice())
          {
            // setup device properties
            using (Dictionary props = dev.Properties)
            {
              props.AtPut("BitPerPixel", new RxVariant(int.Parse(comboBox1.Text)));
            }
            ContextForDbDatabase ctx = new ContextForDbDatabase(database);
            ctx.PaletteBackground = colorDialog.Color;
            LayoutHelperDevice helperDevice = LayoutHelperDevice.SetupActiveLayoutViews(dev, ctx);

            helperDevice.SetLogicalPalette(Device.LightPalette); // light palette
            Rectangle rect = new Rectangle(0, 0, (int)numericUpDownWidth.Value, (int)numericUpDownHeight.Value);
            helperDevice.OnSize(rect);
            ctx.SetPlotGeneration(checkBoxPlotGeneration.Checked);
            if (ctx.IsPlotGeneration)
              helperDevice.BackgroundColor = colorDialog.Color;
            else
              helperDevice.BackgroundColor = Color.FromArgb(0, 173, 174, 173); 
            
            helperDevice.Update();

            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
              Export_Import.ExportBitmap(helperDevice, saveFileDialog.FileName);
              Close();
            }
          }
        }
      }
    }
  }
}