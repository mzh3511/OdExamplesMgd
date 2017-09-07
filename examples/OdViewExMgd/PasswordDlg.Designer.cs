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
namespace OdViewExMgd
{
  partial class PasswordDlg
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
      this.label1 = new System.Windows.Forms.Label();
      this.password = new System.Windows.Forms.MaskedTextBox();
      this.btOK = new System.Windows.Forms.Button();
      this.TextFileName = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(156, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Enter password for the drawing:";
      // 
      // password
      // 
      this.password.Location = new System.Drawing.Point(12, 72);
      this.password.Name = "password";
      this.password.PasswordChar = '*';
      this.password.Size = new System.Drawing.Size(268, 20);
      this.password.TabIndex = 1;
      // 
      // btOK
      // 
      this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btOK.Location = new System.Drawing.Point(205, 98);
      this.btOK.Name = "btOK";
      this.btOK.Size = new System.Drawing.Size(75, 23);
      this.btOK.TabIndex = 2;
      this.btOK.Text = "OK";
      this.btOK.UseVisualStyleBackColor = true;
      // 
      // TextFileName
      // 
      this.TextFileName.BackColor = System.Drawing.SystemColors.Control;
      this.TextFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.TextFileName.Location = new System.Drawing.Point(12, 25);
      this.TextFileName.Multiline = true;
      this.TextFileName.Name = "TextFileName";
      this.TextFileName.ReadOnly = true;
      this.TextFileName.Size = new System.Drawing.Size(268, 41);
      this.TextFileName.TabIndex = 4;
      this.TextFileName.TabStop = false;
      // 
      // PasswordDlg
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 130);
      this.Controls.Add(this.TextFileName);
      this.Controls.Add(this.btOK);
      this.Controls.Add(this.password);
      this.Controls.Add(this.label1);
      this.Name = "PasswordDlg";
      this.Text = "Password";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    public System.Windows.Forms.MaskedTextBox password;
    private System.Windows.Forms.Button btOK;
    public System.Windows.Forms.TextBox TextFileName;
  }
}