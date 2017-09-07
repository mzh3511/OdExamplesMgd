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
namespace OdViewExMgd
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToExtentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expotToDWFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToSVGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBitmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publish3dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDwfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setActiveLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAvtiveLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileDependencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveAsFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.setActiveLayoutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(852, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.zoomToExtentsToolStripMenuItem,
            this.zoomWindowToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator1,
            this.pageSetupToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.printToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.file_open_handler);
            // 
            // zoomToExtentsToolStripMenuItem
            // 
            this.zoomToExtentsToolStripMenuItem.Enabled = false;
            this.zoomToExtentsToolStripMenuItem.Name = "zoomToExtentsToolStripMenuItem";
            this.zoomToExtentsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.zoomToExtentsToolStripMenuItem.Text = "Zoom to extents";
            this.zoomToExtentsToolStripMenuItem.Click += new System.EventHandler(this.zoom_extents_handler);
            // 
            // zoomWindowToolStripMenuItem
            // 
            this.zoomWindowToolStripMenuItem.Enabled = false;
            this.zoomWindowToolStripMenuItem.Name = "zoomWindowToolStripMenuItem";
            this.zoomWindowToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.zoomWindowToolStripMenuItem.Text = "Zoom window";
            this.zoomWindowToolStripMenuItem.Click += new System.EventHandler(this.zoomWindowToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToPDFToolStripMenuItem,
            this.expotToDWFToolStripMenuItem,
            this.exportToSVGToolStripMenuItem,
            this.saveBitmapToolStripMenuItem,
            this.publishToolStripMenuItem,
            this.publish3dToolStripMenuItem,
            this.importDwfToolStripMenuItem});
            this.exportToolStripMenuItem.Enabled = false;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // exportToPDFToolStripMenuItem
            // 
            this.exportToPDFToolStripMenuItem.Name = "exportToPDFToolStripMenuItem";
            this.exportToPDFToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exportToPDFToolStripMenuItem.Text = "Export to PDF...";
            this.exportToPDFToolStripMenuItem.Click += new System.EventHandler(this.exportToPDFToolStripMenuItem_Click);
            // 
            // expotToDWFToolStripMenuItem
            // 
            this.expotToDWFToolStripMenuItem.Name = "expotToDWFToolStripMenuItem";
            this.expotToDWFToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.expotToDWFToolStripMenuItem.Text = "Export to DWF...";
            this.expotToDWFToolStripMenuItem.Click += new System.EventHandler(this.exportToDWFToolStripMenuItem_Click);
            // 
            // exportToSVGToolStripMenuItem
            // 
            this.exportToSVGToolStripMenuItem.Name = "exportToSVGToolStripMenuItem";
            this.exportToSVGToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exportToSVGToolStripMenuItem.Text = "Export to SVG...";
            this.exportToSVGToolStripMenuItem.Click += new System.EventHandler(this.exportToSVGToolStripMenuItem_Click);
            // 
            // saveBitmapToolStripMenuItem
            // 
            this.saveBitmapToolStripMenuItem.Name = "saveBitmapToolStripMenuItem";
            this.saveBitmapToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.saveBitmapToolStripMenuItem.Text = "Save Bitmap...";
            this.saveBitmapToolStripMenuItem.Click += new System.EventHandler(this.saveBitmapToolStripMenuItem_Click);
            // 
            // publishToolStripMenuItem
            // 
            this.publishToolStripMenuItem.Name = "publishToolStripMenuItem";
            this.publishToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.publishToolStripMenuItem.Text = "Publish...";
            this.publishToolStripMenuItem.Click += new System.EventHandler(this.publishToolStripMenuItem_Click);
            // 
            // publish3dToolStripMenuItem
            // 
            this.publish3dToolStripMenuItem.Name = "publish3dToolStripMenuItem";
            this.publish3dToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.publish3dToolStripMenuItem.Text = "3dPublish...";
            this.publish3dToolStripMenuItem.Click += new System.EventHandler(this.publish3dToolStripMenuItem_Click);
            // 
            // importDwfToolStripMenuItem
            // 
            this.importDwfToolStripMenuItem.Name = "importDwfToolStripMenuItem";
            this.importDwfToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.importDwfToolStripMenuItem.Text = "ImportDwf";
            this.importDwfToolStripMenuItem.Click += new System.EventHandler(this.importDwfToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // pageSetupToolStripMenuItem
            // 
            this.pageSetupToolStripMenuItem.Enabled = false;
            this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.pageSetupToolStripMenuItem.Text = "PageSetup";
            this.pageSetupToolStripMenuItem.Click += new System.EventHandler(this.pageSetupToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Enabled = false;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Enabled = false;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveAsToolStripMenuItem.Text = "SaveAs";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // setActiveLayoutToolStripMenuItem
            // 
            this.setActiveLayoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setAvtiveLayoutToolStripMenuItem,
            this.fileDependencyToolStripMenuItem});
            this.setActiveLayoutToolStripMenuItem.Name = "setActiveLayoutToolStripMenuItem";
            this.setActiveLayoutToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.setActiveLayoutToolStripMenuItem.Text = "View";
            // 
            // setAvtiveLayoutToolStripMenuItem
            // 
            this.setAvtiveLayoutToolStripMenuItem.Enabled = false;
            this.setAvtiveLayoutToolStripMenuItem.Name = "setAvtiveLayoutToolStripMenuItem";
            this.setAvtiveLayoutToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.setAvtiveLayoutToolStripMenuItem.Text = "Set Avtive Layout";
            this.setAvtiveLayoutToolStripMenuItem.Click += new System.EventHandler(this.setActiveLayoutToolStripMenuItem_Click);
            // 
            // fileDependencyToolStripMenuItem
            // 
            this.fileDependencyToolStripMenuItem.Enabled = false;
            this.fileDependencyToolStripMenuItem.Name = "fileDependencyToolStripMenuItem";
            this.fileDependencyToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.fileDependencyToolStripMenuItem.Text = "File Dependency";
            this.fileDependencyToolStripMenuItem.Click += new System.EventHandler(this.fileDependencyToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 468);
            this.panel1.TabIndex = 1;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "DWG";
            this.openFileDialog.Filter = "DWG files|*.dwg|DXF files|*.dxf";
            // 
            // saveAsFileDialog
            // 
            this.saveAsFileDialog.DefaultExt = "DWG";
            this.saveAsFileDialog.Filter = "\"DWG files|*.dwg|DXF files|*.dxf\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 492);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "OdViewExMgd";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.ToolStripMenuItem zoomToExtentsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem setActiveLayoutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem setAvtiveLayoutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem zoomWindowToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exportToPDFToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveBitmapToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem expotToDWFToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem publish3dToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exportToSVGToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem publishToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem importDwfToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fileDependencyToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    private System.Windows.Forms.SaveFileDialog saveAsFileDialog;
    private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
  }
}

